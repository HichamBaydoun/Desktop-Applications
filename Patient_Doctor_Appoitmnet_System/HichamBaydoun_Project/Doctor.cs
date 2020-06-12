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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void doctorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDB_HichamDataSet);
            MessageBox.Show("Doctor Inserted/Updated successfully!");

        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDB_HichamDataSet.Clinic_Location' table. You can move, or remove it, as needed.
            this.clinic_LocationTableAdapter.Fill(this.hospitalDB_HichamDataSet.Clinic_Location);
            // TODO: This line of code loads data into the 'hospitalDB_HichamDataSet.Speciality' table. You can move, or remove it, as needed.
            this.specialityTableAdapter.Fill(this.hospitalDB_HichamDataSet.Speciality);
            // TODO: This line of code loads data into the 'hospitalDB_HichamDataSet.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.hospitalDB_HichamDataSet.Appointment);
            // TODO: This line of code loads data into the 'hospitalDB_HichamDataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.hospitalDB_HichamDataSet.Doctor);

            txtInfo.Text = "-> To Insert:\r\nPress +  , then fill form (id is auto-increment), then press the save icon\r\n\r\n-> To Delete:\r\nChoose doctor by pressing the arrow ->, press X  ,then press the save icon\r\n\r\n-> To Update:\r\nChoose doctor by pressing the arrow ->, change info in textBox, then press the save icon";

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Patient deleted successfully!");
        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
