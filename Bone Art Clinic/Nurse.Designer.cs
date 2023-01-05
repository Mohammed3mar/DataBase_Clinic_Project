namespace Bone_Art_Clinic
{
    partial class Nurse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nurse));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Equipment = new System.Windows.Forms.TabPage();
            this.label28 = new System.Windows.Forms.Label();
            this.E_NameCB = new System.Windows.Forms.ComboBox();
            this.EquipmentDGV = new System.Windows.Forms.DataGridView();
            this.Equipment_DGV = new System.Windows.Forms.DataGridView();
            this.E_Name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Delete_Equipment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.E_Speciality = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.View_Equipment = new System.Windows.Forms.Button();
            this.Add_Equipment = new System.Windows.Forms.Button();
            this.Appointments = new System.Windows.Forms.TabPage();
            this.Appointment_DGV = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Prev = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.Equipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Equipment_DGV)).BeginInit();
            this.Appointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Appointment_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Equipment);
            this.tabControl1.Controls.Add(this.Appointments);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(220, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 501);
            this.tabControl1.TabIndex = 15;
            // 
            // Equipment
            // 
            this.Equipment.BackColor = System.Drawing.Color.SlateGray;
            this.Equipment.Controls.Add(this.label28);
            this.Equipment.Controls.Add(this.E_NameCB);
            this.Equipment.Controls.Add(this.EquipmentDGV);
            this.Equipment.Controls.Add(this.Equipment_DGV);
            this.Equipment.Controls.Add(this.E_Name);
            this.Equipment.Controls.Add(this.label10);
            this.Equipment.Controls.Add(this.Delete_Equipment);
            this.Equipment.Controls.Add(this.label1);
            this.Equipment.Controls.Add(this.E_Speciality);
            this.Equipment.Controls.Add(this.label5);
            this.Equipment.Controls.Add(this.label7);
            this.Equipment.Controls.Add(this.View_Equipment);
            this.Equipment.Controls.Add(this.Add_Equipment);
            this.Equipment.Location = new System.Drawing.Point(4, 25);
            this.Equipment.Name = "Equipment";
            this.Equipment.Padding = new System.Windows.Forms.Padding(3);
            this.Equipment.Size = new System.Drawing.Size(793, 472);
            this.Equipment.TabIndex = 0;
            this.Equipment.Text = "Equipment";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label28.Location = new System.Drawing.Point(487, 82);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(195, 24);
            this.label28.TabIndex = 127;
            this.label28.Text = "Equipment Name :";
            // 
            // E_NameCB
            // 
            this.E_NameCB.BackColor = System.Drawing.Color.LightSteelBlue;
            this.E_NameCB.FormattingEnabled = true;
            this.E_NameCB.Location = new System.Drawing.Point(466, 113);
            this.E_NameCB.Name = "E_NameCB";
            this.E_NameCB.Size = new System.Drawing.Size(233, 24);
            this.E_NameCB.TabIndex = 126;
            // 
            // EquipmentDGV
            // 
            this.EquipmentDGV.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.EquipmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EquipmentDGV.Location = new System.Drawing.Point(26, 276);
            this.EquipmentDGV.Name = "EquipmentDGV";
            this.EquipmentDGV.Size = new System.Drawing.Size(747, 174);
            this.EquipmentDGV.TabIndex = 102;
            // 
            // Equipment_DGV
            // 
            this.Equipment_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Equipment_DGV.Location = new System.Drawing.Point(26, 260);
            this.Equipment_DGV.MaximumSize = new System.Drawing.Size(80, 0);
            this.Equipment_DGV.Name = "Equipment_DGV";
            this.Equipment_DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Equipment_DGV.Size = new System.Drawing.Size(80, 0);
            this.Equipment_DGV.TabIndex = 101;
            // 
            // E_Name
            // 
            this.E_Name.BackColor = System.Drawing.Color.LightSteelBlue;
            this.E_Name.Location = new System.Drawing.Point(26, 110);
            this.E_Name.Margin = new System.Windows.Forms.Padding(4);
            this.E_Name.Multiline = true;
            this.E_Name.Name = "E_Name";
            this.E_Name.Size = new System.Drawing.Size(233, 20);
            this.E_Name.TabIndex = 85;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(528, 230);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 96;
            // 
            // Delete_Equipment
            // 
            this.Delete_Equipment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Delete_Equipment.FlatAppearance.BorderSize = 0;
            this.Delete_Equipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Equipment.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Equipment.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Delete_Equipment.Location = new System.Drawing.Point(531, 159);
            this.Delete_Equipment.Name = "Delete_Equipment";
            this.Delete_Equipment.Size = new System.Drawing.Size(110, 38);
            this.Delete_Equipment.TabIndex = 81;
            this.Delete_Equipment.Text = "Delete";
            this.Delete_Equipment.UseVisualStyleBackColor = true;
            this.Delete_Equipment.Click += new System.EventHandler(this.Delete_Equipment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 44);
            this.label1.TabIndex = 93;
            this.label1.Text = "Equipments";
            // 
            // E_Speciality
            // 
            this.E_Speciality.BackColor = System.Drawing.Color.LightSteelBlue;
            this.E_Speciality.FormattingEnabled = true;
            this.E_Speciality.Items.AddRange(new object[] {
            "Orthopedic",
            "Physiotherapy"});
            this.E_Speciality.Location = new System.Drawing.Point(26, 173);
            this.E_Speciality.Name = "E_Speciality";
            this.E_Speciality.Size = new System.Drawing.Size(236, 24);
            this.E_Speciality.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(22, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 24);
            this.label5.TabIndex = 88;
            this.label5.Text = "Specialization :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(22, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 84;
            this.label7.Text = "Name :";
            // 
            // View_Equipment
            // 
            this.View_Equipment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.View_Equipment.FlatAppearance.BorderSize = 0;
            this.View_Equipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View_Equipment.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Equipment.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.View_Equipment.Location = new System.Drawing.Point(149, 222);
            this.View_Equipment.Name = "View_Equipment";
            this.View_Equipment.Size = new System.Drawing.Size(110, 38);
            this.View_Equipment.TabIndex = 83;
            this.View_Equipment.Text = "View";
            this.View_Equipment.UseVisualStyleBackColor = true;
            this.View_Equipment.Click += new System.EventHandler(this.View_Equipment_Click);
            // 
            // Add_Equipment
            // 
            this.Add_Equipment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Add_Equipment.FlatAppearance.BorderSize = 0;
            this.Add_Equipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Equipment.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Equipment.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Add_Equipment.Location = new System.Drawing.Point(26, 222);
            this.Add_Equipment.Name = "Add_Equipment";
            this.Add_Equipment.Size = new System.Drawing.Size(110, 38);
            this.Add_Equipment.TabIndex = 82;
            this.Add_Equipment.Text = "Add";
            this.Add_Equipment.UseVisualStyleBackColor = true;
            this.Add_Equipment.Click += new System.EventHandler(this.Add_Equipment_Click);
            // 
            // Appointments
            // 
            this.Appointments.BackColor = System.Drawing.Color.SlateGray;
            this.Appointments.Controls.Add(this.Appointment_DGV);
            this.Appointments.Controls.Add(this.label13);
            this.Appointments.Controls.Add(this.label15);
            this.Appointments.Location = new System.Drawing.Point(4, 25);
            this.Appointments.Name = "Appointments";
            this.Appointments.Padding = new System.Windows.Forms.Padding(3);
            this.Appointments.Size = new System.Drawing.Size(793, 472);
            this.Appointments.TabIndex = 1;
            this.Appointments.Text = "Appointments";
            // 
            // Appointment_DGV
            // 
            this.Appointment_DGV.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.Appointment_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Appointment_DGV.Location = new System.Drawing.Point(24, 80);
            this.Appointment_DGV.Name = "Appointment_DGV";
            this.Appointment_DGV.Size = new System.Drawing.Size(756, 372);
            this.Appointment_DGV.TabIndex = 122;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(526, 230);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 16);
            this.label13.TabIndex = 117;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label15.Location = new System.Drawing.Point(18, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(363, 44);
            this.label15.TabIndex = 114;
            this.label15.Text = "View Appointments";
            // 
            // Prev
            // 
            this.Prev.FlatAppearance.BorderSize = 0;
            this.Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prev.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prev.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Prev.Location = new System.Drawing.Point(67, 381);
            this.Prev.Margin = new System.Windows.Forms.Padding(4);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(83, 45);
            this.Prev.TabIndex = 246;
            this.Prev.Text = "Prev";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 183);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 245;
            this.pictureBox2.TabStop = false;
            // 
            // Nurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1036, 526);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Nurse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nurse";
            this.Load += new System.EventHandler(this.Nurse_Load);
            this.tabControl1.ResumeLayout(false);
            this.Equipment.ResumeLayout(false);
            this.Equipment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Equipment_DGV)).EndInit();
            this.Appointments.ResumeLayout(false);
            this.Appointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Appointment_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Equipment;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox E_NameCB;
        private System.Windows.Forms.DataGridView EquipmentDGV;
        private System.Windows.Forms.DataGridView Equipment_DGV;
        private System.Windows.Forms.TextBox E_Name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox E_Speciality;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button View_Equipment;
        private System.Windows.Forms.Button Add_Equipment;
        private System.Windows.Forms.Button Delete_Equipment;
        private System.Windows.Forms.TabPage Appointments;
        private System.Windows.Forms.DataGridView Appointment_DGV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Prev;
    }
}