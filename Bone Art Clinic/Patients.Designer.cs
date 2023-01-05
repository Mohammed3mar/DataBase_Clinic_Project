namespace Bone_Art_Clinic
{
    partial class Patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            this.Browse = new System.Windows.Forms.Button();
            this.P_Gender = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.P_Age = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.P_National_ID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.P_Phone_Number = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.P_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Add_Patient = new System.Windows.Forms.Button();
            this.Patient_Page = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.P_Photo = new System.Windows.Forms.PictureBox();
            this.Prev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.FlatAppearance.BorderSize = 0;
            this.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browse.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Browse.Location = new System.Drawing.Point(660, 204);
            this.Browse.Margin = new System.Windows.Forms.Padding(4);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(100, 43);
            this.Browse.TabIndex = 125;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // P_Gender
            // 
            this.P_Gender.BackColor = System.Drawing.Color.LightSteelBlue;
            this.P_Gender.FormattingEnabled = true;
            this.P_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.P_Gender.Location = new System.Drawing.Point(507, 49);
            this.P_Gender.Name = "P_Gender";
            this.P_Gender.Size = new System.Drawing.Size(233, 21);
            this.P_Gender.TabIndex = 124;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label12.Location = new System.Drawing.Point(503, 90);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 24);
            this.label12.TabIndex = 122;
            this.label12.Text = "Upload Photo";
            // 
            // P_Age
            // 
            this.P_Age.BackColor = System.Drawing.Color.LightSteelBlue;
            this.P_Age.Location = new System.Drawing.Point(230, 251);
            this.P_Age.Margin = new System.Windows.Forms.Padding(4);
            this.P_Age.Name = "P_Age";
            this.P_Age.Size = new System.Drawing.Size(233, 20);
            this.P_Age.TabIndex = 121;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label10.Location = new System.Drawing.Point(503, 22);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 24);
            this.label10.TabIndex = 120;
            this.label10.Text = "Gender :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label11.Location = new System.Drawing.Point(227, 223);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 24);
            this.label11.TabIndex = 119;
            this.label11.Text = "Age :";
            // 
            // P_National_ID
            // 
            this.P_National_ID.BackColor = System.Drawing.Color.LightSteelBlue;
            this.P_National_ID.Location = new System.Drawing.Point(231, 118);
            this.P_National_ID.Margin = new System.Windows.Forms.Padding(4);
            this.P_National_ID.Multiline = true;
            this.P_National_ID.Name = "P_National_ID";
            this.P_National_ID.Size = new System.Drawing.Size(233, 20);
            this.P_National_ID.TabIndex = 118;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label9.Location = new System.Drawing.Point(227, 90);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 24);
            this.label9.TabIndex = 117;
            this.label9.Text = "National ID";
            // 
            // P_Phone_Number
            // 
            this.P_Phone_Number.BackColor = System.Drawing.Color.LightSteelBlue;
            this.P_Phone_Number.Location = new System.Drawing.Point(231, 184);
            this.P_Phone_Number.Margin = new System.Windows.Forms.Padding(4);
            this.P_Phone_Number.Name = "P_Phone_Number";
            this.P_Phone_Number.Size = new System.Drawing.Size(233, 20);
            this.P_Phone_Number.TabIndex = 116;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label8.Location = new System.Drawing.Point(227, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 24);
            this.label8.TabIndex = 115;
            this.label8.Text = "Phone Number";
            // 
            // P_Name
            // 
            this.P_Name.BackColor = System.Drawing.Color.LightSteelBlue;
            this.P_Name.Location = new System.Drawing.Point(231, 48);
            this.P_Name.Margin = new System.Windows.Forms.Padding(4);
            this.P_Name.Multiline = true;
            this.P_Name.Name = "P_Name";
            this.P_Name.Size = new System.Drawing.Size(233, 20);
            this.P_Name.TabIndex = 114;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(227, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 24);
            this.label7.TabIndex = 113;
            this.label7.Text = "Name";
            // 
            // Add_Patient
            // 
            this.Add_Patient.FlatAppearance.BorderSize = 0;
            this.Add_Patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Patient.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Patient.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Add_Patient.Location = new System.Drawing.Point(520, 293);
            this.Add_Patient.Margin = new System.Windows.Forms.Padding(4);
            this.Add_Patient.Name = "Add_Patient";
            this.Add_Patient.Size = new System.Drawing.Size(133, 43);
            this.Add_Patient.TabIndex = 112;
            this.Add_Patient.Text = "Add Patient";
            this.Add_Patient.UseVisualStyleBackColor = true;
            this.Add_Patient.Click += new System.EventHandler(this.Add_Patient_Click);
            // 
            // Patient_Page
            // 
            this.Patient_Page.AutoSize = true;
            this.Patient_Page.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient_Page.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Patient_Page.Location = new System.Drawing.Point(13, 9);
            this.Patient_Page.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Patient_Page.Name = "Patient_Page";
            this.Patient_Page.Size = new System.Drawing.Size(124, 37);
            this.Patient_Page.TabIndex = 110;
            this.Patient_Page.Text = "Patient";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 109;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 256;
            this.pictureBox2.TabStop = false;
            // 
            // P_Photo
            // 
            this.P_Photo.Location = new System.Drawing.Point(507, 118);
            this.P_Photo.Name = "P_Photo";
            this.P_Photo.Size = new System.Drawing.Size(146, 125);
            this.P_Photo.TabIndex = 123;
            this.P_Photo.TabStop = false;
            // 
            // Prev
            // 
            this.Prev.FlatAppearance.BorderSize = 0;
            this.Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prev.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prev.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Prev.Location = new System.Drawing.Point(12, 293);
            this.Prev.Margin = new System.Windows.Forms.Padding(4);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(83, 45);
            this.Prev.TabIndex = 257;
            this.Prev.Text = "Prev";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(770, 349);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.P_Photo);
            this.Controls.Add(this.P_Gender);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.P_Age);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.P_National_ID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.P_Phone_Number);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.P_Name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Add_Patient);
            this.Controls.Add(this.Patient_Page);
            this.Controls.Add(this.label1);
            this.Name = "Patients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.Patients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.PictureBox P_Photo;
        private System.Windows.Forms.ComboBox P_Gender;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox P_Age;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox P_National_ID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox P_Phone_Number;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox P_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Add_Patient;
        private System.Windows.Forms.Label Patient_Page;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Prev;
    }
}