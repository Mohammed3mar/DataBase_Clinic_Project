using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bone_Art_Clinic
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            fillDoctor();
            fillNurse();
            fillReceptionist();
        }

        private void Add_Doctor_Click(object sender, EventArgs e)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = MyConnection.GetCon();

            string query = "insert into DoctorTBL values('" + D_Name.Text + "','" + D_Age.Text + "','" + D_Phone_Number.Text + "','" + D_Gender.Text + "','" + D_User_Name.Text + "', '" + D_Password.Text + "', '" + D_Speciality.Text + "')";
            Admincls ad = new Admincls();
            try
            {
                ad.AddDoctor(query);
                MessageBox.Show("Doctor Successfully Added");

            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            Admincls dc = new Admincls();
            string qury = "select * from DoctorTBL";
            DataSet ds = dc.ShowDctor(qury);
            Doctor_DGV.DataSource = ds.Tables[0];

            try
            {
                Con.Open();
                DataSet des = new DataSet();
                string DName = "SELECT D_Name FROM DoctorTBL";
                SqlDataAdapter sda = new SqlDataAdapter(DName, Con);
                sda.Fill(des);
                D_NameCB.DataSource = des.Tables[0];
                D_NameCB.DisplayMember = des.Tables[0].Columns[0].ToString();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Doctor Name" + ex);
            }
            finally
            {
                Con.Close();
            }
        }

        private void View_Doctors_Click(object sender, EventArgs e)
        {
            Admincls dc = new Admincls();
            string query = "select * from DoctorTBL";
            DataSet ds = dc.ShowDctor(query);
            Doctor_DGV.DataSource = ds.Tables[0];
        }

        ConnectionString MyCon = new ConnectionString();
        private void fillDoctor()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select D_Name from DoctorTBL", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("D_Name", typeof(string));
            dt.Load(rdr);
            D_NameCB.ValueMember = "D_Name";
            D_NameCB.DataSource = dt;
            Con.Close();
        }

        private void fillNurse()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select N_Name from NurseTBL", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("N_Name", typeof(string));
            dt.Load(rdr);
            Nurse_NameCB.ValueMember = "N_Name";
            Nurse_NameCB.DataSource = dt;
            Con.Close();
        }

        private void fillReceptionist()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select R_Name from ReceptionistTBL", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("R_Name", typeof(string));
            dt.Load(rdr);
            R_NameCB.ValueMember = "R_Name";
            R_NameCB.DataSource = dt;
            Con.Close();
        }

        private void Delete_Doctor_Click(object sender, EventArgs e)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = MyConnection.GetCon();
            try
            {
                Con.Open();
                SqlCommand del = new SqlCommand("DELETE FROM [DoctorTBL] WHERE D_Name = '" + D_NameCB.Text + "'", Con);
                del.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Deleted");
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                Con.Close();
            }

            Admincls dc = new Admincls();
            string query = "select * from DoctorTBL";
            DataSet ds = dc.ShowDctor(query);
            Doctor_DGV.DataSource = ds.Tables[0];

            try
            {
                Con.Open();
                DataSet des = new DataSet();
                string DName = "SELECT D_Name FROM DoctorTBL";
                SqlDataAdapter sda = new SqlDataAdapter(DName, Con);
                sda.Fill(des);
                D_NameCB.DataSource = des.Tables[0];
                D_NameCB.DisplayMember = des.Tables[0].Columns[0].ToString();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Doctor Name" + ex);
            }
            finally
            {
                Con.Close();
            }
        }

        private void View_Nurses_Click(object sender, EventArgs e)
        {
            Admincls nr = new Admincls();
            string query = "select * from NurseTBL";
            DataSet ds = nr.ShowNurse(query);
            Nurse_DGV.DataSource = ds.Tables[0];
        }

        private void Add_Nurse_Click(object sender, EventArgs e)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = MyConnection.GetCon();

            string query = "insert into NurseTBL values('" + N_Name.Text + "','" + N_Age.Text + "','" + N_Phone_Number.Text + "','" + N_Gender.Text + "','" + N_User_Name.Text + "', '" + N_Password.Text + "')";
            Admincls ad = new Admincls();
            try
            {
                ad.AddNurse(query);
                MessageBox.Show("Nurse Successfully Added");

            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            Admincls nr = new Admincls();
            string qery = "select * from NurseTBL";
            DataSet ds = nr.ShowNurse(qery);
            Nurse_DGV.DataSource = ds.Tables[0];

            try
            {
                Con.Open();
                DataSet des = new DataSet();
                string NName = "SELECT N_Name FROM NurseTBL";
                SqlDataAdapter sda = new SqlDataAdapter(NName, Con);
                sda.Fill(des);
                Nurse_NameCB.DataSource = des.Tables[0];
                Nurse_NameCB.DisplayMember = des.Tables[0].Columns[0].ToString();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Nurse Name" + ex);
            }
            finally
            {
                Con.Close();
            }
        }

        private void Delete_Nurse_Click(object sender, EventArgs e)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = MyConnection.GetCon();
            try
            {
                Con.Open();
                SqlCommand del = new SqlCommand("DELETE FROM [NurseTBL] WHERE N_Name = '" + Nurse_NameCB.Text + "'", Con);
                del.ExecuteNonQuery();
                MessageBox.Show("Nurse Successfully Deleted");
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                Con.Close();
            }

            Admincls dc = new Admincls();
            string query = "select * from NurseTBL";
            DataSet ds = dc.ShowNurse(query);
            Nurse_DGV.DataSource = ds.Tables[0];

            try
            {
                Con.Open();
                DataSet des = new DataSet();
                string NName = "SELECT N_Name FROM NurseTBL";
                SqlDataAdapter sda = new SqlDataAdapter(NName, Con);
                sda.Fill(des);
                Nurse_NameCB.DataSource = des.Tables[0];
                Nurse_NameCB.DisplayMember = des.Tables[0].Columns[0].ToString();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Nurse Name" + ex);
            }
            finally
            {
                Con.Close();
            }
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
            this.Hide();
        }

        private void Add_Receptionist_Click(object sender, EventArgs e)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = MyConnection.GetCon();

            string query = "insert into ReceptionistTBL values('" + R_Name.Text + "','" + R_Age.Text + "','" + R_Phone_Number.Text + "','" + R_Gender.Text + "','" + R_User_Name.Text + "', '" + R_Password.Text + "')";
            Admincls ad = new Admincls();
            try
            {
                ad.AddReceptionist(query);
                MessageBox.Show("Receptionist Successfully Added");

            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            Admincls dc = new Admincls();
            string qry = "select * from ReceptionistTBL";
            DataSet ds = dc.ShowReceptionist(qry);
            Receptionist_DGV.DataSource = ds.Tables[0];

            try
            {
                Con.Open();
                DataSet des = new DataSet();
                string RName = "SELECT R_Name FROM ReceptionistTBL";
                SqlDataAdapter sda = new SqlDataAdapter(RName, Con);
                sda.Fill(des);
                R_NameCB.DataSource = des.Tables[0];
                R_NameCB.DisplayMember = des.Tables[0].Columns[0].ToString();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Receptionist Name" + ex);
            }
            finally
            {
                Con.Close();
            }
        }

        private void View_Receptionist_Click(object sender, EventArgs e)
        {
            Admincls rc = new Admincls();
            string query = "select * from ReceptionistTBL";
            DataSet ds = rc.ShowDctor(query);
            Receptionist_DGV.DataSource = ds.Tables[0];
        }

        private void Delete_Receptionist_Click(object sender, EventArgs e)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = MyConnection.GetCon();
            try
            {
                Con.Open();
                SqlCommand del = new SqlCommand("DELETE FROM [ReceptionistTBL] WHERE R_Name = '" + R_NameCB.Text + "'", Con);
                del.ExecuteNonQuery();
                MessageBox.Show("Receptionist Successfully Deleted");
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                Con.Close();
            }

            Admincls dc = new Admincls();
            string query = "select * from ReceptionistTBL";
            DataSet ds = dc.ShowNurse(query);
            Receptionist_DGV.DataSource = ds.Tables[0];

            try
            {
                Con.Open();
                DataSet des = new DataSet();
                string RName = "SELECT R_Name FROM ReceptionistTBL";
                SqlDataAdapter sda = new SqlDataAdapter(RName, Con);
                sda.Fill(des);
                R_NameCB.DataSource = des.Tables[0];
                R_NameCB.DisplayMember = des.Tables[0].Columns[0].ToString();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Nurse Name" + ex);
            }
            finally
            {
                Con.Close();
            }
        }
    }
}
