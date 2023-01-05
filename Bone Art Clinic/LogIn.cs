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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void Sign_In_Click(object sender, EventArgs e)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = MyConnection.GetCon();

            if (Profile.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Your Position");
            }

            else if (Profile.SelectedIndex == 0)
            {
                if (User_Name.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Please Enter Both Admin Name and Password");
                }
                else
                {
                    Con.Open();
                    string query = "Select * From AdminTBL Where A_User_Name='" + User_Name.Text.Trim() + "' and A_Password ='" + Password.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        Admin ad = new Admin();
                        ad.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Admin Name or Password!");
                    }
                    Con.Close();
                }
            }

            else if (Profile.SelectedIndex == 1)
            {
                if (User_Name.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Please Enter Both Receptionest Name and Password");
                }

                else
                {
                    Con.Open();
                    string query = "Select * From ReceptionistTBL Where R_User_Name='" + User_Name.Text.Trim() + "' and R_Password ='" + Password.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        Receptionist rc = new Receptionist();
                        rc.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Receptionest Not Found!");
                    }
                    Con.Close();
                }
            }

            else if (Profile.SelectedIndex == 2)
            {
                if (User_Name.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Please Enter Both Doctor Name and Password");
                }

                else
                {
                    Con.Open();
                    string query = "Select * From DoctorTBL Where D_User_Name  ='" + User_Name.Text.Trim() + "' and D_Password ='" + Password.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        Orthopedist dr = new Orthopedist();
                        dr.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Doctor Not Found!");
                    }
                    Con.Close();
                }

            }
            else if (Profile.SelectedIndex == 3)
            {
                if (User_Name.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Please Enter Both Doctor Name and Password");
                }

                else
                {
                    Con.Open();
                    string query = "Select * From DoctorTBL Where D_User_Name  ='" + User_Name.Text.Trim() + "' and D_Password ='" + Password.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        Physiotherapist dc = new Physiotherapist();
                        dc.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Doctor Not Found!");
                    }
                    Con.Close();
                }
            }
            else if (Profile.SelectedIndex == 4)
            {
                if (User_Name.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Please Enter Both Nurse Name and Password");
                }

                else
                {
                    Con.Open();
                    string query = "Select * From NurseTBL Where N_User_Name='" + User_Name.Text.Trim() + "' and N_Password ='" + Password.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        Nurse nu = new Nurse();
                        nu.Show();
                        this.Hide(); ;
                    }
                    else
                    {
                        MessageBox.Show("Nurse Not Found!");
                    }
                    Con.Close();
                }
            }
        }

        private void Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
