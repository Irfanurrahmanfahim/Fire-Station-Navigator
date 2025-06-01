namespace Fire_Map___30074676
{
    partial class FireMap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FireMap));
            this.FireMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.insertpanel = new System.Windows.Forms.Panel();
            this.Longitude = new System.Windows.Forms.TextBox();
            this.Latitude = new System.Windows.Forms.TextBox();
            this.ContactNumber = new System.Windows.Forms.TextBox();
            this.StationName = new System.Windows.Forms.TextBox();
            this.InsertStation = new System.Windows.Forms.Button();
            this.longitudelbl = new System.Windows.Forms.Label();
            this.latitudelbl = new System.Windows.Forms.Label();
            this.contactlbl = new System.Windows.Forms.Label();
            this.firestationlbl = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.findstation = new System.Windows.Forms.Panel();
            this.FindNearestStation = new System.Windows.Forms.Button();
            this.stationdetails = new System.Windows.Forms.TextBox();
            this.neareststationlbl = new System.Windows.Forms.Label();
            this.PostCode = new System.Windows.Forms.TextBox();
            this.FireEncounter = new System.Windows.Forms.Label();
            this.insertpanel.SuspendLayout();
            this.findstation.SuspendLayout();
            this.SuspendLayout();
            // 
            // FireMapControl
            // 
            this.FireMapControl.Bearing = 0F;
            this.FireMapControl.CanDragMap = true;
            this.FireMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.FireMapControl.GrayScaleMode = false;
            this.FireMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.FireMapControl.LevelsKeepInMemory = 5;
            this.FireMapControl.Location = new System.Drawing.Point(458, 12);
            this.FireMapControl.MarkersEnabled = true;
            this.FireMapControl.MaxZoom = 2;
            this.FireMapControl.MinZoom = 2;
            this.FireMapControl.MouseWheelZoomEnabled = true;
            this.FireMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.FireMapControl.Name = "FireMapControl";
            this.FireMapControl.NegativeMode = false;
            this.FireMapControl.PolygonsEnabled = true;
            this.FireMapControl.RetryLoadTile = 0;
            this.FireMapControl.RoutesEnabled = true;
            this.FireMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.FireMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.FireMapControl.ShowTileGridLines = false;
            this.FireMapControl.Size = new System.Drawing.Size(793, 709);
            this.FireMapControl.TabIndex = 0;
            this.FireMapControl.Zoom = 0D;
            this.FireMapControl.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.FireMapControl_OnMarkerClick);
            // 
            // insertpanel
            // 
            this.insertpanel.BackColor = System.Drawing.Color.Beige;
            this.insertpanel.Controls.Add(this.Longitude);
            this.insertpanel.Controls.Add(this.Latitude);
            this.insertpanel.Controls.Add(this.ContactNumber);
            this.insertpanel.Controls.Add(this.StationName);
            this.insertpanel.Controls.Add(this.InsertStation);
            this.insertpanel.Controls.Add(this.longitudelbl);
            this.insertpanel.Controls.Add(this.latitudelbl);
            this.insertpanel.Controls.Add(this.contactlbl);
            this.insertpanel.Controls.Add(this.firestationlbl);
            this.insertpanel.Location = new System.Drawing.Point(7, 12);
            this.insertpanel.Name = "insertpanel";
            this.insertpanel.Size = new System.Drawing.Size(436, 282);
            this.insertpanel.TabIndex = 1;
            // 
            // Longitude
            // 
            this.Longitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Longitude.Location = new System.Drawing.Point(146, 175);
            this.Longitude.Name = "Longitude";
            this.Longitude.Size = new System.Drawing.Size(272, 23);
            this.Longitude.TabIndex = 8;
            // 
            // Latitude
            // 
            this.Latitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Latitude.Location = new System.Drawing.Point(127, 127);
            this.Latitude.Name = "Latitude";
            this.Latitude.Size = new System.Drawing.Size(291, 23);
            this.Latitude.TabIndex = 7;
            // 
            // ContactNumber
            // 
            this.ContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumber.Location = new System.Drawing.Point(200, 78);
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.Size = new System.Drawing.Size(218, 23);
            this.ContactNumber.TabIndex = 6;
            // 
            // StationName
            // 
            this.StationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StationName.Location = new System.Drawing.Point(159, 29);
            this.StationName.Name = "StationName";
            this.StationName.Size = new System.Drawing.Size(259, 23);
            this.StationName.TabIndex = 5;
            // 
            // InsertStation
            // 
            this.InsertStation.BackColor = System.Drawing.Color.Lime;
            this.InsertStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertStation.Location = new System.Drawing.Point(19, 216);
            this.InsertStation.Name = "InsertStation";
            this.InsertStation.Size = new System.Drawing.Size(400, 52);
            this.InsertStation.TabIndex = 4;
            this.InsertStation.Text = "Mark A New Fire Station";
            this.InsertStation.UseVisualStyleBackColor = false;
            this.InsertStation.Click += new System.EventHandler(this.InsertStation_Click);
            // 
            // longitudelbl
            // 
            this.longitudelbl.AutoSize = true;
            this.longitudelbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudelbl.Location = new System.Drawing.Point(14, 171);
            this.longitudelbl.Name = "longitudelbl";
            this.longitudelbl.Size = new System.Drawing.Size(126, 26);
            this.longitudelbl.TabIndex = 3;
            this.longitudelbl.Text = "Longitude :";
            // 
            // latitudelbl
            // 
            this.latitudelbl.AutoSize = true;
            this.latitudelbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudelbl.Location = new System.Drawing.Point(14, 123);
            this.latitudelbl.Name = "latitudelbl";
            this.latitudelbl.Size = new System.Drawing.Size(107, 26);
            this.latitudelbl.TabIndex = 2;
            this.latitudelbl.Text = "Latitude :";
            // 
            // contactlbl
            // 
            this.contactlbl.AutoSize = true;
            this.contactlbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactlbl.Location = new System.Drawing.Point(14, 74);
            this.contactlbl.Name = "contactlbl";
            this.contactlbl.Size = new System.Drawing.Size(189, 26);
            this.contactlbl.TabIndex = 1;
            this.contactlbl.Text = "Contact Number :";
            // 
            // firestationlbl
            // 
            this.firestationlbl.AutoSize = true;
            this.firestationlbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firestationlbl.Location = new System.Drawing.Point(14, 25);
            this.firestationlbl.Name = "firestationlbl";
            this.firestationlbl.Size = new System.Drawing.Size(139, 26);
            this.firestationlbl.TabIndex = 0;
            this.firestationlbl.Text = "Fire Station :";
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Update.Enabled = false;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(7, 311);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(435, 50);
            this.Update.TabIndex = 2;
            this.Update.Text = "Update Selected Fire Station\'s Information";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Crimson;
            this.Delete.Enabled = false;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(7, 376);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(435, 50);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete Selected Fire Station";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // findstation
            // 
            this.findstation.BackColor = System.Drawing.Color.Beige;
            this.findstation.Controls.Add(this.FindNearestStation);
            this.findstation.Controls.Add(this.stationdetails);
            this.findstation.Controls.Add(this.neareststationlbl);
            this.findstation.Controls.Add(this.PostCode);
            this.findstation.Controls.Add(this.FireEncounter);
            this.findstation.Location = new System.Drawing.Point(10, 442);
            this.findstation.Name = "findstation";
            this.findstation.Size = new System.Drawing.Size(431, 279);
            this.findstation.TabIndex = 4;
            // 
            // FindNearestStation
            // 
            this.FindNearestStation.BackColor = System.Drawing.Color.LightSteelBlue;
            this.FindNearestStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindNearestStation.Location = new System.Drawing.Point(61, 234);
            this.FindNearestStation.Name = "FindNearestStation";
            this.FindNearestStation.Size = new System.Drawing.Size(307, 35);
            this.FindNearestStation.TabIndex = 12;
            this.FindNearestStation.Text = "Find Nearest Fire Station";
            this.FindNearestStation.UseVisualStyleBackColor = false;
            this.FindNearestStation.Click += new System.EventHandler(this.FindNearestStation_Click);
            // 
            // stationdetails
            // 
            this.stationdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationdetails.Location = new System.Drawing.Point(8, 84);
            this.stationdetails.Multiline = true;
            this.stationdetails.Name = "stationdetails";
            this.stationdetails.ReadOnly = true;
            this.stationdetails.Size = new System.Drawing.Size(412, 143);
            this.stationdetails.TabIndex = 11;
            // 
            // neareststationlbl
            // 
            this.neareststationlbl.AutoSize = true;
            this.neareststationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neareststationlbl.Location = new System.Drawing.Point(4, 59);
            this.neareststationlbl.Name = "neareststationlbl";
            this.neareststationlbl.Size = new System.Drawing.Size(237, 20);
            this.neareststationlbl.TabIndex = 10;
            this.neareststationlbl.Text = "Nearest Fire Station Details:";
            // 
            // PostCode
            // 
            this.PostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostCode.Location = new System.Drawing.Point(273, 21);
            this.PostCode.Name = "PostCode";
            this.PostCode.Size = new System.Drawing.Size(147, 23);
            this.PostCode.TabIndex = 9;
            // 
            // FireEncounter
            // 
            this.FireEncounter.AutoSize = true;
            this.FireEncounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FireEncounter.Location = new System.Drawing.Point(4, 22);
            this.FireEncounter.Name = "FireEncounter";
            this.FireEncounter.Size = new System.Drawing.Size(272, 20);
            this.FireEncounter.TabIndex = 0;
            this.FireEncounter.Text = "Fire encountered at (PostCode) :";
            // 
            // FireMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 733);
            this.Controls.Add(this.findstation);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.insertpanel);
            this.Controls.Add(this.FireMapControl);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FireMap";
            this.Text = "Fire Station Navigator";
            this.Load += new System.EventHandler(this.FireMap_Load);
            this.insertpanel.ResumeLayout(false);
            this.insertpanel.PerformLayout();
            this.findstation.ResumeLayout(false);
            this.findstation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl FireMapControl;
        private System.Windows.Forms.Panel insertpanel;
        private System.Windows.Forms.Label latitudelbl;
        private System.Windows.Forms.Label contactlbl;
        private System.Windows.Forms.Label firestationlbl;
        private System.Windows.Forms.Button InsertStation;
        private System.Windows.Forms.Label longitudelbl;
        private System.Windows.Forms.TextBox StationName;
        private System.Windows.Forms.TextBox Longitude;
        private System.Windows.Forms.TextBox Latitude;
        private System.Windows.Forms.TextBox ContactNumber;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Panel findstation;
        private System.Windows.Forms.Label FireEncounter;
        private System.Windows.Forms.TextBox PostCode;
        private System.Windows.Forms.Button FindNearestStation;
        private System.Windows.Forms.TextBox stationdetails;
        private System.Windows.Forms.Label neareststationlbl;
    }
}

