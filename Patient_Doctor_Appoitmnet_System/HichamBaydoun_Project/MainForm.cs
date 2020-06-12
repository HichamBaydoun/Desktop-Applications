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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.MdiParent = this;
            p.Show();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctor d = new Doctor();
            d.MdiParent = this;
            d.Show();
        }

        private void appoitmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Appointment a = new Appointment();
            a.MdiParent = this;
            a.Show();
        }

        private void specialityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Speciality s = new Speciality();
            s.MdiParent = this;
            s.Show();
        }

        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Location l = new Location();
            l.MdiParent = this;
            l.Show();
        }
    }
}
