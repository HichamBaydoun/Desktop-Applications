using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hicham_Baydoun
{
    public partial class BookTrip : Form
    {
        public BookTrip()
        {
            InitializeComponent();
        }

        //Prepare a connection
        SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=TripDB;Integrated Security=True");

        int cityFromID = 0;
        int cityToID = 0;

        //when form is loaded
        private void BookTrip_Load(object sender, EventArgs e)
        {
            dateTimeWhen.MinDate = DateTime.Today;

            //-> fill combo box with trip plan's descrition

            //construct the select text string
            string query = "select * from TripPlan";

            //prepare the command objcet
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandText = query;
            //create DataTable
            DataTable tripPlanTable = new DataTable();

            try
            {
                //ExecuteReader() method is used because the command will return record(s) from the database to the application
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                //tripPlanTable has now the same structure as TripPlan Table
                tripPlanTable.Load(reader);

                //bind
                comboPlan.DataSource = tripPlanTable;
                comboPlan.DisplayMember = "description";
                comboPlan.ValueMember = "id";

            }

            catch
            {
                MessageBox.Show("Could not load Combo Box");
            }
            finally
            {
                conn.Close();
            }

            //-> fill 1st list box with cities’ name ordered alphabetically  

            //construct the select text string
            query = "select name from City Order By name";

            //prepare the command objcet
            cmd = new SqlCommand(query, conn);
            cmd.CommandText = query;

            try
            {
                //ExecuteReader() method is used because the command will return record(s) from the database to the application
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listFrom.Items.Add(reader.GetString(0));
                }

            }

            catch
            {
                MessageBox.Show("Could not load List Box From");
            }
            finally
            {
                conn.Close();
            }
        }
        
        //load list box to with cities' names except the chosen one from list box fronm
        private void listFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            listTo.Items.Clear();
            if (listFrom.SelectedIndices.Count != 0)
            {
                string selectedCity = listFrom.SelectedItem.ToString();

                //construct the select text string
                string query = "select name from City where name != '" + selectedCity + "' Order By name";

                //prepare the command objcet
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandText = query;

                try
                {
                    //ExecuteReader() method is used because the command will return record(s) from the database to the application
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    //add city's name to the listBox
                    while (reader.Read())
                    {
                        listTo.Items.Add(reader.GetString(0));
                    }

                }

                catch
                {
                    MessageBox.Show("Could not load List Box To");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        //when 'Book' is pressed
        private void btnBook_Click(object sender, EventArgs e)
        {
            //-> Validate entries
            if (boxReservation.Text == "")
            {
                MessageBox.Show("Missing Entry: Enter Reservation for");
                return;
            }
            if (listFrom.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Missing Entry: Select City From");
                return;
            }
            if (listTo.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Missing Entry: Select City To");
                return;
            }

            //--> make the insertion

            //-> get id of cirtyFrom and cityTo for insertion query 

            //construct the select text string
            string cityNameFrom = listFrom.SelectedItem.ToString();
            string query = "select id from City where name = '" + cityNameFrom + "'";

            //prepare the command objcet
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandText = query;

            try
            {
                //ExecuteReader() method is used because the command will return record(s) from the database to the application
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cityFromID = reader.GetInt32(0);
                }

            }

            catch
            {
                MessageBox.Show("Could not get cityFrom id");
            }
            finally
            {
                conn.Close();
            }

            //construct the select text string
            string cityNameTo = listTo.SelectedItem.ToString();
            query = "select id from City where name = '" + cityNameTo + "'";

            //prepare the command objcet
            cmd = new SqlCommand(query, conn);
            cmd.CommandText = query;

            try
            {
                //ExecuteReader() method is used because the command will return record(s) from the database to the application
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cityToID = reader.GetInt32(0);
                }

            }

            catch
            {
                MessageBox.Show("Could not get cityTo id");
            }
            finally
            {
                conn.Close();
            }

            //-> make the insertion

            //construct the insert command Text
            string name = boxReservation.Text.ToString();
            int planID = (int)comboPlan.SelectedValue;
            int nbPerson = (int)numericPersons.Value;
            string cmdText = "Insert into [Trip] (reservationName, fromCity, toCity, planID, tripDate, nbPerson) " + 
                "VALUES ('" + name + "', " + cityFromID + ", " + cityToID + ", " + planID + ", '" + dateTimeWhen.Value.Date + "', " + nbPerson + ")";

            //prepare the command objcet
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            //enclose the code that connects to a database in a try catch block
            try{
                conn.Open();
                //ExecuteNonQuery method is used because the command will insert a record to the database 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Trip booked successfully!");
            }
            catch
            {
                MessageBox.Show("Error booking trip");
            }
            finally
            {
                conn.Close();
            }

            //clear all selections and entries
            boxReservation.Clear();
            comboPlan.SelectedIndex = 0;
            listFrom.SelectedIndices.Clear();
            dateTimeWhen.Value = dateTimeWhen.MinDate;
            numericPersons.Value = numericPersons.Minimum;
            listTo.Items.Clear();
        }

    }
}
