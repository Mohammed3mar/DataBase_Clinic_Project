﻿using System;
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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }

        private void Patients_Load(object sender, EventArgs e)
        {

        }

        private void Prev_Click(object sender, EventArgs e)
        {
            Receptionist re = new Receptionist();
            re.Show();
            this.Hide();
        }

        private void Add_Patient_Click(object sender, EventArgs e)
        {
            string query = "insert into PatientTBL values('" + P_National_ID.Text + "','" + P_Name.Text + "','" + P_Age.Text + "','" + P_Phone_Number.Text + "','" + P_Gender.Text + "','" + P_Photo.Image + "')";
            Patientcls MP = new Patientcls();
            try
            {
                MP.AddPatient(query);
                MessageBox.Show("Patient Successfully Added");

            }


            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                P_Photo.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}
