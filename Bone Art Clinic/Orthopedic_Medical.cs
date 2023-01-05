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
    public partial class Orthopedic_Medical : Form
    {
        public Orthopedic_Medical()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Mohammed\\Documents\\Bone_Art_Clinic.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();

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

        private void Orthopedic_Medical_Load(object sender, EventArgs e)
        {
            fillPatient();

            Orthipedic_Medical_cls dmr = new Orthipedic_Medical_cls();
            string query = "select O_M_R_ID, P_Name, P_Age, P_Gender, Type_of_Session, Prescription, Allergies from O_M_R_TBL";
            DataSet ds = dmr.ShowDerma_M_R(query);
            Orthopedic_M_R_DGV.DataSource = ds.Tables[0];
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            Orthopedist dr = new Orthopedist();
            dr.Show();
            this.Hide();
        }

        private void Add_Medical_Record_Click(object sender, EventArgs e)
        {
            string query = "insert into O_M_R_TBL values('" + P_Name.Text + "','" + P_Age.Text + "','" + P_Gender.Text + "','" + O_M_R_Photo.Image + "','" + Type_of_Session.Text + "','" + Prescription.Text + "','" + Allergies.Text + "')";
            Orthipedic_Medical_cls ad = new Orthipedic_Medical_cls();
            try
            {
                ad.AddDerma_M_R(query);
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
                O_M_R_Photo.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void View_Click(object sender, EventArgs e)
        {
            Orthipedic_Medical_cls dmr = new Orthipedic_Medical_cls();
            string query = "select O_M_R_ID, P_Name, P_Age, P_Gender, Type_of_Session, Prescription, Allergies from O_M_R_TBL";
            DataSet ds = dmr.ShowDerma_M_R(query);
            Orthopedic_M_R_DGV.DataSource = ds.Tables[0];
        }
    }
}
