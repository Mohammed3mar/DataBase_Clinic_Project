namespace Bone_Art_Clinic
{
    partial class Physiotherapist_Medical
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Physiotherapist_Medical));
            this.P_Gender = new System.Windows.Forms.ComboBox();
            this.P_Name = new System.Windows.Forms.ComboBox();
            this.Add_Photo = new System.Windows.Forms.Button();
            this.Prev = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Type_of_Session = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Add_Medical_Record = new System.Windows.Forms.Button();
            this.Physiotherapy_M_R_DGV = new System.Windows.Forms.DataGridView();
            this.Allergies = new System.Windows.Forms.RichTextBox();
            this.Prescription = new System.Windows.Forms.RichTextBox();
            this.P_Age = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.P_M_R_Photo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Physiotherapy_M_R_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_M_R_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // P_Gender
            // 
            this.P_Gender.BackColor = System.Drawing.Color.LightSteelBlue;
            this.P_Gender.FormattingEnabled = true;
            this.P_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.P_Gender.Location = new System.Drawing.Point(248, 130);
            this.P_Gender.Name = "P_Gender";
            this.P_Gender.Size = new System.Drawing.Size(235, 21);
            this.P_Gender.TabIndex = 239;
            // 
            // P_Name
            // 
            this.P_Name.BackColor = System.Drawing.Color.LightSteelBlue;
            this.P_Name.FormattingEnabled = true;
            this.P_Name.Location = new System.Drawing.Point(248, 67);
            this.P_Name.Name = "P_Name";
            this.P_Name.Size = new System.Drawing.Size(233, 21);
            this.P_Name.TabIndex = 238;
            // 
            // Add_Photo
            // 
            this.Add_Photo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Add_Photo.FlatAppearance.BorderSize = 0;
            this.Add_Photo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Photo.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Photo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Add_Photo.Location = new System.Drawing.Point(387, 314);
            this.Add_Photo.Name = "Add_Photo";
            this.Add_Photo.Size = new System.Drawing.Size(96, 54);
            this.Add_Photo.TabIndex = 237;
            this.Add_Photo.Text = "Add Photo";
            this.Add_Photo.UseVisualStyleBackColor = true;
            this.Add_Photo.Click += new System.EventHandler(this.Add_Photo_Click);
            // 
            // Prev
            // 
            this.Prev.FlatAppearance.BorderSize = 0;
            this.Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prev.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prev.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Prev.Location = new System.Drawing.Point(12, 330);
            this.Prev.Margin = new System.Windows.Forms.Padding(4);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(83, 45);
            this.Prev.TabIndex = 236;
            this.Prev.Text = "Prev";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 32);
            this.label4.TabIndex = 235;
            this.label4.Text = "Medical Record";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(528, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 223;
            this.label1.Text = "Allergies :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(244, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 24);
            this.label7.TabIndex = 222;
            this.label7.Text = "Patient Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label9.Location = new System.Drawing.Point(528, 192);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 24);
            this.label9.TabIndex = 228;
            this.label9.Text = "Prescription :";
            // 
            // Type_of_Session
            // 
            this.Type_of_Session.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Type_of_Session.FormattingEnabled = true;
            this.Type_of_Session.Items.AddRange(new object[] {
            "Orthopedic",
            "Physiotherapy"});
            this.Type_of_Session.Location = new System.Drawing.Point(532, 67);
            this.Type_of_Session.Name = "Type_of_Session";
            this.Type_of_Session.Size = new System.Drawing.Size(233, 21);
            this.Type_of_Session.TabIndex = 227;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(528, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 24);
            this.label5.TabIndex = 226;
            this.label5.Text = "Type of Session :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(244, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 225;
            this.label6.Text = "Gender :";
            // 
            // Add_Medical_Record
            // 
            this.Add_Medical_Record.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Add_Medical_Record.FlatAppearance.BorderSize = 0;
            this.Add_Medical_Record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Medical_Record.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Medical_Record.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Add_Medical_Record.Location = new System.Drawing.Point(655, 330);
            this.Add_Medical_Record.Name = "Add_Medical_Record";
            this.Add_Medical_Record.Size = new System.Drawing.Size(110, 38);
            this.Add_Medical_Record.TabIndex = 234;
            this.Add_Medical_Record.Text = "Add";
            this.Add_Medical_Record.UseVisualStyleBackColor = true;
            this.Add_Medical_Record.Click += new System.EventHandler(this.Add_Medical_Record_Click);
            // 
            // Physiotherapy_M_R_DGV
            // 
            this.Physiotherapy_M_R_DGV.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.Physiotherapy_M_R_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Physiotherapy_M_R_DGV.Location = new System.Drawing.Point(13, 387);
            this.Physiotherapy_M_R_DGV.Name = "Physiotherapy_M_R_DGV";
            this.Physiotherapy_M_R_DGV.Size = new System.Drawing.Size(798, 168);
            this.Physiotherapy_M_R_DGV.TabIndex = 233;
            // 
            // Allergies
            // 
            this.Allergies.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Allergies.Location = new System.Drawing.Point(532, 130);
            this.Allergies.Name = "Allergies";
            this.Allergies.Size = new System.Drawing.Size(233, 39);
            this.Allergies.TabIndex = 232;
            this.Allergies.Text = "";
            // 
            // Prescription
            // 
            this.Prescription.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Prescription.Location = new System.Drawing.Point(532, 219);
            this.Prescription.Name = "Prescription";
            this.Prescription.Size = new System.Drawing.Size(233, 45);
            this.Prescription.TabIndex = 231;
            this.Prescription.Text = "";
            // 
            // P_Age
            // 
            this.P_Age.BackColor = System.Drawing.Color.LightSteelBlue;
            this.P_Age.Location = new System.Drawing.Point(250, 204);
            this.P_Age.Margin = new System.Windows.Forms.Padding(4);
            this.P_Age.Name = "P_Age";
            this.P_Age.Size = new System.Drawing.Size(233, 20);
            this.P_Age.TabIndex = 229;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(246, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 224;
            this.label2.Text = "Age :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 242;
            this.pictureBox2.TabStop = false;
            // 
            // P_M_R_Photo
            // 
            this.P_M_R_Photo.Location = new System.Drawing.Point(250, 234);
            this.P_M_R_Photo.Name = "P_M_R_Photo";
            this.P_M_R_Photo.Size = new System.Drawing.Size(131, 134);
            this.P_M_R_Photo.TabIndex = 240;
            this.P_M_R_Photo.TabStop = false;
            // 
            // Physiotherapist_Medical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(823, 568);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.P_Gender);
            this.Controls.Add(this.P_Name);
            this.Controls.Add(this.Add_Photo);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.P_M_R_Photo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Type_of_Session);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Add_Medical_Record);
            this.Controls.Add(this.Physiotherapy_M_R_DGV);
            this.Controls.Add(this.Allergies);
            this.Controls.Add(this.Prescription);
            this.Controls.Add(this.P_Age);
            this.Controls.Add(this.label2);
            this.Name = "Physiotherapist_Medical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Physiotherapist_Medical";
            this.Load += new System.EventHandler(this.Physiotherapist_Medical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Physiotherapy_M_R_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_M_R_Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox P_Gender;
        private System.Windows.Forms.ComboBox P_Name;
        private System.Windows.Forms.Button Add_Photo;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox P_M_R_Photo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Type_of_Session;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Add_Medical_Record;
        private System.Windows.Forms.DataGridView Physiotherapy_M_R_DGV;
        private System.Windows.Forms.RichTextBox Allergies;
        private System.Windows.Forms.RichTextBox Prescription;
        private System.Windows.Forms.TextBox P_Age;
        private System.Windows.Forms.Label label2;
    }
}