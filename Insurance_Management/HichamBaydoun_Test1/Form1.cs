using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HichamBaydoun_Test1
{

    public partial class Form1 : Form
    {
        //list that contains Insurance objects
        List<Insurance> listInsurances = new List<Insurance>();

        public Form1()
        {
            InitializeComponent();
        }

        //The phone text box allows entering digits only
        private void boxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //“Search” button is initially disabled
            btnSearch.Enabled = false;

            //GroupBox Search is not visible
            grpBoxSearch.Visible = false;

            //load comboBox with items
            string[] items = new string[3] {"Medical", "Life", "Car"};
            comboType.Items.AddRange(items);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //making sure customer name and phone(8 digits)
            if (boxName.Text == String.Empty || boxPhone.Text == String.Empty || boxPhone.Text.Trim().Length != 8)
            {
                MessageBox.Show("You must fill customer name and phone. Make sure phone is of 8 digits.");
            }
            else{
                //Add a new policy 
                listInsurances.Add(new Insurance(comboType.Text, boxName.Text, boxPhone.Text, (int)numericCost.Value, (int)numericYears.Value));

                //clear and reset all fields
                boxName.Clear();
                boxPhone.Clear();
                comboType.SelectedIndex = -1;
                numericCost.Value = numericCost.Minimum;
                numericYears.Value = numericYears.Minimum;
            }
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Enable the search button after the first policy 
            if (comboType.SelectedIndex != -1)
            {
                btnSearch.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //“Search Area” becomes visible after clicking on "Search"
            grpBoxSearch.Visible = true;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if ((radioType.Checked == false && radioCustomer.Checked == false) || boxFilter.Text == String.Empty)
            {
                MessageBox.Show("Make sure to select an option and enter a value in the textbox");
            }
            else
            {
                string filter = boxFilter.Text;
                //if type is selected
                if (radioType.Checked)
                {
                    listBoxSearch.Items.Clear();

                    var query1 = from x in listInsurances
                                 where x.Type.ToLower().Equals(filter.ToLower()) 
                                 select x;

                    foreach (var element in query1)
                    {
                        listBoxSearch.Items.Add(element);
                    }
                }
                //if customer is selected
                else if (radioCustomer.Checked)
                {
                    listBoxSearch.Items.Clear();

                    var query2 = from x in listInsurances
                                 where x.Customer.ToLower().Contains(filter.ToLower())
                                 select x;

                    foreach (var element in query2)
                    {
                        listBoxSearch.Items.Add(element);
                    }
                }

            }
        }

        //Customers who bought a policy for more than 2 years
        private void button1_Click(object sender, EventArgs e)
        {
            listBoxSearch.Items.Clear();

            var query3 = from x in listInsurances
                         where x.Years > 2
                         select x.Customer;

            foreach (var element in query3)
            {
                listBoxSearch.Items.Add(element);
            }
        }
        //Find the most expensive policy (as a total cost)
        private void button2_Click(object sender, EventArgs e)
        {
            listBoxSearch.Items.Clear();

            var max = listInsurances.Max(x => x.PolicyAmount * x.Years);

            var mostExpensivePolicy = from x in listInsurances
                                      where x.PolicyAmount * x.Years == max
                                      select x;

            foreach (var element in mostExpensivePolicy)
            {
                listBoxSearch.Items.Add(element);
            }
        }
    }
}
