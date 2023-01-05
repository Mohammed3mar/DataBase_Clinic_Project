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
    public partial class View_Appointments : Form
    {
        public View_Appointments()
        {
            InitializeComponent();
        }

        private void View_Appointments_Load(object sender, EventArgs e)
        {
            View_Appointment_cls app = new View_Appointment_cls();
            string query = "select * from AppointmentTBL";
            DataSet ds = app.Show_Appointment(query);
            V_Appointments_DGV.DataSource = ds.Tables[0];
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            Orthopedist dr = new Orthopedist();
            dr.Show();
            this.Hide();
        }
    }
}
