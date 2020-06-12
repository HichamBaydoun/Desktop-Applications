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
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }
        HospitalDB_HichamDataSet hospital = new HospitalDB_HichamDataSet();
        HospitalDB_HichamDataSetTableAdapters.AppointmentTableAdapter ca;
        private void Appointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDB_HichamDataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.hospitalDB_HichamDataSet.Doctor);
            // TODO: This line of code loads data into the 'hospitalDB_HichamDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.hospitalDB_HichamDataSet.Patient);
            //fill list view and this has to be done upon insert and delete
            listApp.View = View.Details;
            listApp.FullRowSelect = true;
            fillLVAppoitment();
            comboPatient.SelectedIndex = -1;
            comboDoctor.SelectedIndex = -1;

            txtInfo.Text = "-> To Insert App:\r\nChoose patient and doctor, then press insert\r\n\r\n-> To Delete App:\r\nSelect an app in the listView, then press delete";
        }

        void fillLVAppoitment()
        {
            listApp.Items.Clear();
            listApp.Columns.Clear();
            //use the category table adapter
            ca = new HospitalDB_HichamDataSetTableAdapters.AppointmentTableAdapter();
            ca.Fill(hospital.Appointment);//select * from Appointment and fill in the table category

            //Appointment is a DataTable, so we can add columns to listview
            foreach (DataColumn c in hospital.Appointment.Columns)
                listApp.Columns.Add(c.ToString());
            //Appointment is a DataTable, so we can loop through all the rows to add to list view.
            ListViewItem itm;
            foreach (DataRow r in hospital.Appointment)
            {
                itm = new ListViewItem(r["app_no"].ToString());
                itm.SubItems.Add(r["pid"].ToString());
                itm.SubItems.Add(r["did"].ToString());
                listApp.Items.Add(itm);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Id is autoincrement so the user has to enter the description
            if (comboPatient.SelectedIndex == -1 || comboDoctor.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a Patient/Doctor");
                return;
            }
            //use the table adapter to insert
            ca.Insert((int)comboPatient.SelectedValue, (int)comboDoctor.SelectedValue);
            hospital.AcceptChanges();
            MessageBox.Show("Appointment Inserted successfully!");
            comboPatient.SelectedIndex = -1;
            comboDoctor.SelectedIndex = -1;
            //reflect changes in listview
            fillLVAppoitment();
        }

        int app_no = 0;
        int pid, did;
        private void listApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when one item is selected, show description in text box
            if (listApp.SelectedIndices.Count == 1)
            {
                app_no = Convert.ToInt32(listApp.SelectedItems[0].SubItems[0].Text);
                //get selected item and access the second column
                pid = Convert.ToInt32(listApp.SelectedItems[0].SubItems[1].Text);
                did = Convert.ToInt32(listApp.SelectedItems[0].SubItems[2].Text);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (app_no == 0)
            {
                MessageBox.Show("Please select an Appointment to delete");
                return;
            }
            try
            {
                //use table adapter to delete
                ca.Delete(app_no, pid, did);
                hospital.AcceptChanges();
                MessageBox.Show("Appointment deleted successfully!");
                //reflect changes in listview
                fillLVAppoitment();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
