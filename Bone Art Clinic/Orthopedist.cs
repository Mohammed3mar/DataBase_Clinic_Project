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
    public partial class Orthopedist : Form
    {
        public Orthopedist()
        {
            InitializeComponent();
        }

        private void Orthopedist_Load(object sender, EventArgs e)
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
            View_Appointments vp = new View_Appointments();
            vp.Show();
            this.Hide();
        }

        private void Medical_Record_Click(object sender, EventArgs e)
        {
            Orthopedic_Medical mp = new Orthopedic_Medical();
            mp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OCR_Orthopedic ocr = new OCR_Orthopedic();
            ocr.Show();
            this.Hide();
        }

        private void V_History_Click(object sender, EventArgs e)
        {

        }
    }
}
