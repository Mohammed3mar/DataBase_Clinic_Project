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
    public partial class Physiotherapist : Form
    {
        public Physiotherapist()
        {
            InitializeComponent();
        }

        private void Physiotherapist_Load(object sender, EventArgs e)
        {

        }

        private void Prev_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
            this.Hide();
        }

        private void V_Appointment_Click(object sender, EventArgs e)
        {
            View_Appointments vd = new View_Appointments();
            vd.Show();
            this.Hide();
        }

        private void Medical_Record_Click(object sender, EventArgs e)
        {
            Physiotherapist_Medical dm = new Physiotherapist_Medical();
            dm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OCR_Physiotherapist ocrd = new OCR_Physiotherapist();
            ocrd.Show();
            this.Hide();
        }
    }
}
