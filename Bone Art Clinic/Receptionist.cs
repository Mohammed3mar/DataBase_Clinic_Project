using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bone_Art_Clinic
{
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {

        }

        private void Prev_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
            this.Hide();
        }

        private void Orthopedist_App_Click(object sender, EventArgs e)
        {
            Appointment D = new Appointment();
            D.Show();
            this.Hide();
        }

        private void Physiotherapist_App_Click(object sender, EventArgs e)
        {
            Appointment D = new Appointment();
            D.Show();
            this.Hide();
        }

        private void Adding_Patient_Click(object sender, EventArgs e)
        {
            Patients p = new Patients();
            p.Show();
            this.Hide();
        }
    }
}
