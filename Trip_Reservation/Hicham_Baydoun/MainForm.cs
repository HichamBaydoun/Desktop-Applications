using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hicham_Baydoun
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Book a trip
        private void bookATripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookTrip frm = new BookTrip();
            frm.Show();
        }

        //Reservations
        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservations frm = new Reservations();
            frm.Show();
        }
    }
}
