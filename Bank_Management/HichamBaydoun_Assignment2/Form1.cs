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

namespace HichamBaydoun_Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Prepare a connection
        SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=BankDB;Integrated Security=True");

        int deleteID; //will save the id of the customer to be deleted

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (boxName.Text == "")
            {
                MessageBox.Show("Please enter a name");
                return;
            }

            //construct the insert command Text
            string name = boxName.Text.ToString();
            string cmdText = "Insert into Customer (name) VALUES ('" + name + "')";

            //prepare the command objcet
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            //enclose the code that connects to a database in a try catch block
            try
            {
                conn.Open();
                //ExecuteNonQuery method is used because the command will insert a record to the database 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer added successfully");
            }
            catch
            {
                MessageBox.Show("Error inserting name!");
            }
            finally
            {
                conn.Close();
            }

            //clear fields
            boxName.Clear();

            //--------------------------------------------------------------------------------------
            //when we add a customer, refresh the comboBox of Customer names in the ownership tab

            //construct the select text string
            string query = "select * from customer";

            //prepare the command objcet
            cmd = new SqlCommand(query, conn);
            cmd.CommandText = query;
            //create DataTable
            DataTable customerTable = new DataTable();

            try
            {
                //ExecuteReader() method is used because the command will return record(s) from the database to the application
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                //customerTable has now the same structure as Customer Table
                customerTable.Load(reader);

                //bind
                comboCustomer.DataSource = customerTable;
                comboCustomer.DisplayMember = "name";
                comboCustomer.ValueMember = "id";

            }

            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (boxSearch.Text == "")
            {
                boxSearchResult.Clear();
                MessageBox.Show("Please enter a name");
                btnDelete.Enabled = false;
                return;
            }

            try
            {
                //construct the select text string
                string name = boxSearch.Text.ToString();
                string query = "select * from customer where name = '" + name + "'";

                //prepare the command objcet
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandText = query;

                //ExecuteReader() method is used because the command will return  record(s) from the database to the application
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                //if not found
                if (!reader.Read())
                {
                    boxSearchResult.Clear();
                    MessageBox.Show("Customer not found");
                    btnDelete.Enabled = false;
                }
                
                //if found
                else
                {
                    boxSearchResult.Text = reader["name"].ToString();
                    deleteID = Convert.ToInt32(reader["ID"].ToString());
                    MessageBox.Show("Customer found");
                    btnDelete.Enabled = true;
                }

                //Close reader and conn
                reader.Close();
                conn.Close();
            }

            catch
            {
                MessageBox.Show("Error searching");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //construct the delete command Text
            string cmdText = "delete Customer where ID = " + deleteID;

            //prepare the command objcet
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            //enclose the code that connects to a database in a try catch block
            try
            {
                conn.Open();
                btnDelete.Enabled = false;
                //ExecuteNonQuery method is used because the command will insert a record to the database 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer deleted!");
            }
            catch{}
            finally
            {
                //clear fileds and close conn
                boxSearchResult.Clear();
                boxSearch.Clear();
                conn.Close();
            }

            //-------------------------------------------------------------------------------------------------------------------

            //when we delete a customer, refresh the comboBox of Customer names in the ownership tab

            //construct the select text string
            string query = "select * from customer";

            //prepare the command objcet
            cmd = new SqlCommand(query, conn);
            cmd.CommandText = query;
            //create DataTable
            DataTable customerTable = new DataTable();

            try
            {
                //ExecuteReader() method is used because the command will return record(s) from the database to the application
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                //customerTable has now the same structure as Customer Table
                customerTable.Load(reader);

                //bind
                comboCustomer.DataSource = customerTable;
                comboCustomer.DisplayMember = "name";
                comboCustomer.ValueMember = "id";

            }

            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //when we open the form, the comboBox is filled with customer names (if table customers contains data) in the ownership tab

            //construct the select text string
            string query = "select * from customer";

            //prepare the command objcet
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandText = query;
            //create DataTable
            DataTable customerTable = new DataTable();

            try
            {
                //ExecuteReader() method is used because the command will return record(s) from the database to the application
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                //customerTable has now the same structure as Customer Table
                customerTable.Load(reader);

                //bind
                comboCustomer.DataSource = customerTable;
                comboCustomer.DisplayMember = "name";
                comboCustomer.ValueMember = "id";

            }

            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }

            //----------------------------------------------------------------------------------------

            //when we open the form, the readonly text box shows the details of an account in the ownership tab

            try
            {
                //construct the select text string
                query = "select account.ID, balance, type from account, accountType where account.accountTypeID = accountType.ID";

                //prepare the command objcet
                cmd = new SqlCommand(query, conn);
                cmd.CommandText = query;

                //ExecuteReader() method is used because the command will return  record(s) from the database to the application
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    boxDetails.Text += reader["ID"].ToString() + " " + reader["balance"].ToString() + " " + reader["type"].ToString() + "\r\n";
                }

                reader.Close();
                conn.Close();
            }

            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            //construct the insert command Text
            int cid = (int)comboCustomer.SelectedValue;
            int aid = (int)numericID.Value;
            string cmdText = "Insert into Ownership VALUES (" + aid + ", " + cid + ")";

            //prepare the command objcet
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            //enclose the code that connects to a database in a try catch block
            try
            {
                conn.Open();
                //ExecuteNonQuery method is used because the command will insert a record to the database 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted successfully");
            }
            catch
            {
                MessageBox.Show("Already Exist!\r\nThe accountID and customerID you selected already exists as a row in ownership table");
            }
            finally
            {
                conn.Close();
            }

            //reset the selections
            comboCustomer.SelectedIndex = 0;
            numericID.Value = numericID.Minimum;
        }

    }
}
