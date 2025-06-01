namespace Fire_Map___30074676
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.NewLongitude = new System.Windows.Forms.TextBox();
            this.NewLatitude = new System.Windows.Forms.TextBox();
            this.ContactNewNumber = new System.Windows.Forms.TextBox();
            this.StationNewName = new System.Windows.Forms.TextBox();
            this.UpdateStation = new System.Windows.Forms.Button();
            this.longitudeupdatelbl = new System.Windows.Forms.Label();
            this.latitudelbl = new System.Windows.Forms.Label();
            this.contactupdatelbl = new System.Windows.Forms.Label();
            this.firestationupdatelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewLongitude
            // 
            this.NewLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewLongitude.Location = new System.Drawing.Point(115, 161);
            this.NewLongitude.Name = "NewLongitude";
            this.NewLongitude.Size = new System.Drawing.Size(312, 23);
            this.NewLongitude.TabIndex = 8;
            // 
            // NewLatitude
            // 
            this.NewLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewLatitude.Location = new System.Drawing.Point(101, 109);
            this.NewLatitude.Name = "NewLatitude";
            this.NewLatitude.Size = new System.Drawing.Size(326, 23);
            this.NewLatitude.TabIndex = 7;
            // 
            // ContactNewNumber
            // 
            this.ContactNewNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNewNumber.Location = new System.Drawing.Point(201, 68);
            this.ContactNewNumber.Name = "ContactNewNumber";
            this.ContactNewNumber.Size = new System.Drawing.Size(226, 23);
            this.ContactNewNumber.TabIndex = 6;
            // 
            // StationNewName
            // 
            this.StationNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StationNewName.Location = new System.Drawing.Point(201, 23);
            this.StationNewName.Name = "StationNewName";
            this.StationNewName.Size = new System.Drawing.Size(226, 23);
            this.StationNewName.TabIndex = 5;
            // 
            // UpdateStation
            // 
            this.UpdateStation.BackColor = System.Drawing.Color.SkyBlue;
            this.UpdateStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateStation.Location = new System.Drawing.Point(33, 204);
            this.UpdateStation.Name = "UpdateStation";
            this.UpdateStation.Size = new System.Drawing.Size(376, 39);
            this.UpdateStation.TabIndex = 4;
            this.UpdateStation.Text = "Update Fire Station Details";
            this.UpdateStation.UseVisualStyleBackColor = false;
            this.UpdateStation.Click += new System.EventHandler(this.UpdateStation_Click);
            // 
            // longitudeupdatelbl
            // 
            this.longitudeupdatelbl.AutoSize = true;
            this.longitudeupdatelbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudeupdatelbl.Location = new System.Drawing.Point(15, 161);
            this.longitudeupdatelbl.Name = "longitudeupdatelbl";
            this.longitudeupdatelbl.Size = new System.Drawing.Size(94, 20);
            this.longitudeupdatelbl.TabIndex = 3;
            this.longitudeupdatelbl.Text = "Longitude :";
            // 
            // latitudelbl
            // 
            this.latitudelbl.AutoSize = true;
            this.latitudelbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudelbl.Location = new System.Drawing.Point(15, 112);
            this.latitudelbl.Name = "latitudelbl";
            this.latitudelbl.Size = new System.Drawing.Size(80, 20);
            this.latitudelbl.TabIndex = 2;
            this.latitudelbl.Text = "Latitude :";
            // 
            // contactupdatelbl
            // 
            this.contactupdatelbl.AutoSize = true;
            this.contactupdatelbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactupdatelbl.Location = new System.Drawing.Point(12, 68);
            this.contactupdatelbl.Name = "contactupdatelbl";
            this.contactupdatelbl.Size = new System.Drawing.Size(177, 20);
            this.contactupdatelbl.TabIndex = 1;
            this.contactupdatelbl.Text = "New Contact Number :";
            // 
            // firestationupdatelbl
            // 
            this.firestationupdatelbl.AutoSize = true;
            this.firestationupdatelbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firestationupdatelbl.Location = new System.Drawing.Point(12, 23);
            this.firestationupdatelbl.Name = "firestationupdatelbl";
            this.firestationupdatelbl.Size = new System.Drawing.Size(183, 20);
            this.firestationupdatelbl.TabIndex = 0;
            this.firestationupdatelbl.Text = "Fire Station New Name:";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 255);
            this.ControlBox = false;
            this.Controls.Add(this.UpdateStation);
            this.Controls.Add(this.NewLongitude);
            this.Controls.Add(this.NewLatitude);
            this.Controls.Add(this.longitudeupdatelbl);
            this.Controls.Add(this.firestationupdatelbl);
            this.Controls.Add(this.ContactNewNumber);
            this.Controls.Add(this.StationNewName);
            this.Controls.Add(this.latitudelbl);
            this.Controls.Add(this.contactupdatelbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateForm";
            this.Text = "Update Fire Station Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewLongitude;
        private System.Windows.Forms.TextBox NewLatitude;
        private System.Windows.Forms.TextBox ContactNewNumber;
        private System.Windows.Forms.TextBox StationNewName;
        private System.Windows.Forms.Button UpdateStation;
        private System.Windows.Forms.Label longitudeupdatelbl;
        private System.Windows.Forms.Label latitudelbl;
        private System.Windows.Forms.Label contactupdatelbl;
        private System.Windows.Forms.Label firestationupdatelbl;
    }
}