using System;
using System.Windows.Forms;

namespace Fire_Map___30074676
{
    public partial class UpdateForm : Form
    {

        //creating an object of UpdateForm to connect to the main form 
        public static UpdateForm instance;

        public UpdateForm()
        {
            InitializeComponent();
            instance = this;
        }

        //Event handler for the Update button to accept the updated details from the user and send it to the main form
        private void UpdateStation_Click(object sender, EventArgs e)
        {
            if (StationNewName.Text == "" || ContactNewNumber.Text == "" || NewLatitude.Text == "" || NewLongitude.Text == "")
            {
                MessageBox.Show("Please fill in all the fields!","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FireMap.instance.updatedstationName = StationNewName.Text.ToString();
                FireMap.instance.updatedcontactNumber = ContactNewNumber.Text.ToString();
                FireMap.instance.UpdatedLatitude = Convert.ToDouble(NewLatitude.Text);
                FireMap.instance.UpdatedLongitude = Convert.ToDouble(NewLongitude.Text);
                this.Close();
            }
        }
    }
}
