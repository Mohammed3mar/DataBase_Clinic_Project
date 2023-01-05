﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patagames.Ocr;

namespace Bone_Art_Clinic
{
    public partial class OCR_Physiotherapist : Form
    {
        public OCR_Physiotherapist()
        {
            InitializeComponent();
        }

        private void OCR_Physiotherapist_Load(object sender, EventArgs e)
        {

        }

        private void Add_Photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OCR_Photo.Image = new Bitmap(openFileDialog.FileName);
                // image file path  
                Image_Path.Text = openFileDialog.FileName;
            }
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            Physiotherapist drd = new Physiotherapist();
            drd.Show();
            this.Hide();
        }

        private void Convert_to_Text_Click(object sender, EventArgs e)
        {
            using (var objOcr = OcrApi.Create())
            {
                objOcr.Init(Patagames.Ocr.Enums.Languages.English);
                string plainText = objOcr.GetTextFromImage(Image_Path.Text);
                OCR_Text.Text = plainText;
            }
        }
    }
}
