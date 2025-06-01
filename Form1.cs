//Coursework 2: Databases and Data Modelling - 30074676
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MongoDB.Driver;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using MongoDB.Driver.Core.Configuration;
using System.Collections;
using GMap.NET.WindowsPresentation;
using GMapMarker = GMap.NET.WindowsForms.GMapMarker;
using MongoDB.Bson;
using System.Net;
using System.Net.Sockets;
using System.Web.Script.Serialization;
using static System.Collections.Specialized.BitVector32;

namespace Fire_Map___30074676
{
    public partial class FireMap : Form
    {

        #region Variables
        string ConnectionString;
        string DatabaseName;
        string CollectionName;
        public string updatedstationName;
        public string updatedcontactNumber;
        public double UpdatedLatitude;
        public double UpdatedLongitude;
        GMapMarker selectedmarker;
        #endregion

        public static FireMap instance;   

        public FireMap()
        {
            InitializeComponent();
        }

        
        private void FireMap_Load(object sender, EventArgs e)
        {
            instance = this;

            // Set the connection string, database name and collection name
            ConnectionString = "mongodb+srv://30074676:bangladesh2030@irfandatabase.eiw13mn.mongodb.net/?authSource=admin&appName=IrfanDatabase";
            DatabaseName = "Geospatial_data";
            CollectionName = "UK-data";

            // Set the map provider and the initial position
            FireMapControl.MapProvider = GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            FireMapControl.Position = new PointLatLng(54.013176, 2.3252278);
            FireMapControl.ShowCenter = false;


            // Set the zoom level
            FireMapControl.MinZoom = 5;
            FireMapControl.MaxZoom = 100;
            FireMapControl.Zoom = 5;

            // Loading the previous stations from the database
            LoadPreviousStations();
        }


        //Event handler to insert the station details into the database and place a marker on the map
        private void InsertStation_Click(object sender, EventArgs e)
        {
            try
            {
                if (StationName.Text == "" || ContactNumber.Text == "" || Latitude.Text == "" || Longitude.Text == "")
                {
                    MessageBox.Show("Please fill in all the fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Retrive the coordinates from the value provided in the Textboxes
                    FireMapControl.Position = new PointLatLng(Convert.ToDouble(Latitude.Text), Convert.ToDouble(Longitude.Text));

                    //Create the markers and place the pin on the coordinates
                    GMapOverlay markers = new GMapOverlay("markers");
                    GMapMarker marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitude.Text), Convert.ToDouble(Longitude.Text)), GMarkerGoogleType.green_small);
                    marker.Tag = StationName.Text;
                    marker.ToolTipText = StationName.Text;
                    markers.Markers.Add(marker);
                    FireMapControl.Overlays.Add(markers);

                    #region Inserting_into_MongoDB
                    var client = new MongoClient(ConnectionString);
                    var db = client.GetDatabase(DatabaseName);
                    var collection = db.GetCollection<StationData>(CollectionName);

                    var newstation = new StationData
                    {
                        Name = StationName.Text,
                        Contact = ContactNumber.Text,
                        coordinates = new List<double>() { Convert.ToDouble(Latitude.Text), Convert.ToDouble(Longitude.Text) }
                    };
                    collection.InsertOneAsync(newstation);  //Inserting the station details into the database
                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Function to load the previously saved stations from the database
        private void LoadPreviousStations()
        {
            try
            {
                var client = new MongoClient(ConnectionString);
                var db = client.GetDatabase(DatabaseName);
                var collection = db.GetCollection<StationData>(CollectionName);

                var count = collection.CountDocuments(Builders<StationData>.Filter.Empty);
                if (count != 0)
                {
                    var stations = collection.Find(Builders<StationData>.Filter.Empty).ToList();

                    foreach (var station in stations)
                    {
                        GMapOverlay markers = new GMapOverlay("markers");
                        GMapMarker marker = new GMarkerGoogle(new PointLatLng(station.coordinates[0], station.coordinates[1]), GMarkerGoogleType.green_small);
                        marker.Tag = station.Name;
                        marker.ToolTipText = station.Name;
                        markers.Markers.Add(marker);
                        FireMapControl.Overlays.Add(markers);
                    }
                }
                FireMapControl.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        //Event handler to observe a marker when it is clicked
        private void FireMapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            selectedmarker = item;
            Update.Enabled = true;
            Delete.Enabled = true;
        }

        //Event handler to update a fire station details
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateForm updateForm = new UpdateForm();    //Create an instance of the UpdateForm
                updateForm.ShowDialog();     //Open the update form


                //Update the station details in the database
                var client = new MongoClient(ConnectionString);
                var db = client.GetDatabase(DatabaseName);
                var collection = db.GetCollection<StationData>(CollectionName);

                var filter = Builders<StationData>.Filter.Eq("Name", selectedmarker.Tag.ToString());

                var contactnumberupdate = Builders<StationData>.Update.Set("Contact", updatedcontactNumber);
                var coordinatesupdate = Builders<StationData>.Update.Set("coordinates", ( Convert.ToDouble(UpdatedLatitude), Convert.ToDouble(UpdatedLongitude)));
                var nameupdate = Builders<StationData>.Update.Set("Name", updatedstationName);


                //Remove the selected marker from the map and add the updated marker
                selectedmarker.Overlay.Markers.Remove(selectedmarker);
                GMapOverlay markers = new GMapOverlay("markers");
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(UpdatedLatitude), Convert.ToDouble(UpdatedLongitude)), GMarkerGoogleType.green_small);
                marker.Tag = updatedstationName;
                marker.ToolTipText = updatedstationName;
                markers.Markers.Add(marker);
                FireMapControl.Overlays.Add(markers);


                //Update the station details in the database
                collection.UpdateOne(filter, contactnumberupdate);
                collection.UpdateOne(filter, coordinatesupdate);
                collection.UpdateOne(filter, nameupdate);

                Update.Enabled = false;
                Delete.Enabled = false;

                FireMapControl.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Event handler to delete a fire station
        private void Delete_Click(object sender, EventArgs e)
        {
            try { 
            if (selectedmarker != null)
            {
                // Remove the station details from MongoDB
                var client = new MongoClient(ConnectionString);
                var db = client.GetDatabase(DatabaseName);
                var collection = db.GetCollection<StationData>(CollectionName);

                // Delete the station details from the database if the station name matches the selected marker's tag
                collection.DeleteOne(station => station.Name == selectedmarker.Tag.ToString());

                // Remove the selected marker from its overlay
                FireMapControl.Overlays.Remove(selectedmarker.Overlay);

                // Refresh the map to reflect the changes
                FireMapControl.Refresh();

                // Dispose the selected marker
                selectedmarker.Dispose();
                selectedmarker = null;
            }

            Update.Enabled = false;
            Delete.Enabled = false;
        }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Event handler to find the nearest fire station
        private void FindNearestStation_Click(object sender, EventArgs e)
        {
            try
            {
                if (PostCode.Text == "") 
                {
                    MessageBox.Show("Please give a postcode first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (WebClient web = new WebClient())
                    {
                        string postcode = PostCode.Text;    //getting the postcode from the textbox

                        JavaScriptSerializer serializer = new JavaScriptSerializer();    

                        string areaurl = string.Format($"http://api.openweathermap.org/geo/1.0/zip?zip={postcode},GB&appid=631d8f360d3c7e3efab7ef8844707ae9");
                        var areadata = web.DownloadString(areaurl);   //getting the latitude and longitude of the selected area in json format by making api call

                        Postcodedetails area = new Postcodedetails();
                        area = serializer.Deserialize<Postcodedetails>(areadata);   //deserailizing area details


                        //Create a red marker and place it on the map to indicate the fire
                        GMapOverlay firemarkers = new GMapOverlay("markers");
                        GMapMarker marker = new GMarkerGoogle(
                        new PointLatLng(area.lat, area.lon), GMarkerGoogleType.red_small);
                        marker.ToolTipText = postcode;
                        firemarkers.Markers.Add(marker);
                        FireMapControl.Overlays.Add(firemarkers);

                       
                        FindClosestMarker(new PointLatLng(area.lat, area.lon));    //calling FindClosestMarker function to find the nearest fire station
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Function to calculate the distance between two points and find the closest marker
        private void FindClosestMarker(PointLatLng location)
        {
            string stationName = "Unknown";
            string contactNumber = "Unknown";

            var client = new MongoClient(ConnectionString);
            var db = client.GetDatabase(DatabaseName);
            var collection = db.GetCollection<StationData>(CollectionName);

            var stations = collection.Find(Builders<StationData>.Filter.Empty).ToList();

            double minDistance = double.MaxValue;
            foreach (var station in stations)
            {
                double distance = CalculateDistance(location, new PointLatLng(station.coordinates[0], station.coordinates[1]));
                if (distance < minDistance)
                {
                    minDistance = distance;
                    stationName = station.Name;
                    contactNumber = station.Contact;
                }
            }

            stationdetails.Text = ($"The nearest station is {minDistance.ToString("F2")} km away.                       " + 
                                   $"Station Name: {stationName},    " +
                                   $"Contact Number: {contactNumber}");
        }

        //Function to calculate the distance between two points
        private double CalculateDistance(PointLatLng location1, PointLatLng location2)
        {
            return GMapProviders.GoogleMap.Projection.GetDistance(location1, location2);
        }

    }
}
