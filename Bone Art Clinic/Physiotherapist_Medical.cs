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

namespace Bone_Art_Clinic
{
    public partial class Physiotherapist_Medical : Form
    {
        public Physiotherapist_Medical()
        {
            InitializeComponent();
        }

        ConnectionString MyCon = new ConnectionString();

        private void fillPatient()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select P_Name from PatientTBL", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("P_Name", typeof(string));
            dt.Load(rdr);
            P_Name.ValueMember = "P_Name";
            P_Name.DataSource = dt;
            Con.Close();
        }

        private void Physiotherapist_Medical_Load(object sender, EventArgs e)
        {
            fillPatient();
            Physiotherapist_Medical_cls dmr = new Physiotherapist_Medical_cls();
            string query = "select P_M_R_ID, P_Name, P_Age, P_Gender, Type_of_Session, Prescription, Allergies from Ph_M_R_TBL";
            DataSet ds = dmr.ShowPlastic_M_R(query);
            Physiotherapy_M_R_DGV.DataSource = ds.Tables[0];
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            Physiotherapist dr = new Physiotherapist();
            dr.Show();
            this.Hide();
        }

        private void Add_Medical_Record_Click(object sender, EventArgs e)
        {
            string query = "insert into Ph_M_R_TBL values('" + P_Name.Text + "','" + P_Age.Text + "','" + P_Gender.Text + "','" + P_M_R_Photo.Image + "','" + Type_of_Session.Text + "','" + Prescription.Text + "','" + Allergies.Text + "')";
            Physiotherapist_Medical_cls ad = new Physiotherapist_Medical_cls();
            try
            {
                ad.AddPlastic_M_R(query);
                MessageBox.Show("Medical Record Added Successfully");

            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Add_Photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                P_M_R_Photo.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void View_Click(object sender, EventArgs e)
        {

        }
    }
}
