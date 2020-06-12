using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HichamBaydoun_Project
{
    public partial class Location : Form
    {
        public Location()
        {
            InitializeComponent();
        }

        HospitalDB_HichamDataSet hospitalDS = new HospitalDB_HichamDataSet();
        HospitalDB_HichamDataSetTableAdapters.Clinic_LocationTableAdapter locationTA = new HospitalDB_HichamDataSetTableAdapters.Clinic_LocationTableAdapter();
        BindingSource locationBS = new BindingSource();

        private void Location_Load(object sender, EventArgs e)
        {
            //fill clinic_location table
            locationTA.Fill(hospitalDS.Clinic_Location);
            //set datagridview's datasource
            dgLocation.DataSource = hospitalDS.Clinic_Location;
            locationBS.DataSource = hospitalDS.Clinic_Location;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //this works for insert and update.
            try
            {
                this.Validate();
                this.locationBS.EndEdit();
                this.locationTA.Update(hospitalDS.Clinic_Location);
                MessageBox.Show("Location Inserted/Updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgLocation.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a location to remove");
                return;
            }
            int lid;
            string location;
            foreach (DataGridViewRow row in dgLocation.SelectedRows)
            {
                //we put the try/catch in the loop so the execution continues in case some of the customers can be removed.
                try
                {   //get the info of the location to be deleted
                    lid = Convert.ToInt32(row.Cells["lid"].Value);
                    location = row.Cells["location"].Value.ToString();
                    locationTA.Delete(lid, location);
                    locationTA.Fill(hospitalDS.Clinic_Location);//reflect changes in datagridview
                    MessageBox.Show("Location deleted successfully!");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            //whenever the user is entering any character, the filter is the where clause in the select statement
            locationBS.Filter = "location like '%" + txtLocation.Text + "%'";//filter locations with name containing the value in the textbox
        }
    }
}
