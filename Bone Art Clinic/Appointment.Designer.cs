namespace Bone_Art_Clinic
{
    partial class Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            this.P_Name = new System.Windows.Forms.ComboBox();
            this.Reserve_Appointment = new System.Windows.Forms.Button();
            this.Slot = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Type_of_Session = new System.Windows.Forms.ComboBox();
            this.P_Doctor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.D_O_A = new System.Windows.Forms.DateTimePicker();
            this.P_Phone_Number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Prev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // P_Name
            // 
            this.P_Name.BackColor = System.Drawing.Color.LightSteelBlue;
            this.P_Name.FormattingEnabled = true;
            this.P_Name.Location = new System.Drawing.Point(257, 130);
            this.P_Name.Name = "P_Name";
            this.P_Name.Size = new System.Drawing.Size(231, 21);
            this.P_Name.TabIndex = 82;
            // 
            // Reserve_Appointment
            // 
            this.Reserve_Appointment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Reserve_Appointment.FlatAppearance.BorderSize = 0;
            this.Reserve_Appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reserve_Appointment.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reserve_Appointment.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Reserve_Appointment.Location = new System.Drawing.Point(444, 321);
            this.Reserve_Appointment.Name = "Reserve_Appointment";
            this.Reserve_Appointment.Size = new System.Drawing.Size(113, 38);
            this.Reserve_Appointment.TabIndex = 79;
            this.Reserve_Appointment.Text = "Reserve";
            this.Reserve_Appointment.UseVisualStyleBackColor = true;
            this.Reserve_Appointment.Click += new System.EventHandler(this.Reserve_Appointment_Click);
            // 
            // Slot
            // 
            this.Slot.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Slot.FormattingEnabled = true;
            this.Slot.Items.AddRange(new object[] {
            "12:00   -    1:00",
            " 1:00    -    2:00",
            " 3:00    -    4:00",
            " 4:00    -    5:00",
            " 5:00    -    6:00",
            " 6:00    -    7:00",
            " 7:00    -    8:00"});
            this.Slot.Location = new System.Drawing.Point(528, 196);
            this.Slot.Name = "Slot";
            this.Slot.Size = new System.Drawing.Size(231, 21);
            this.Slot.TabIndex = 78;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label9.Location = new System.Drawing.Point(524, 170);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 24);
            this.label9.TabIndex = 77;
            this.label9.Text = "Slot";
            // 
            // Type_of_Session
            // 
            this.Type_of_Session.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Type_of_Session.FormattingEnabled = true;
            this.Type_of_Session.Items.AddRange(new object[] {
            "Orthopedic",
            "Physiotherapy"});
            this.Type_of_Session.Location = new System.Drawing.Point(528, 130);
            this.Type_of_Session.Name = "Type_of_Session";
            this.Type_of_Session.Size = new System.Drawing.Size(231, 21);
            this.Type_of_Session.TabIndex = 76;
            // 
            // P_Doctor
            // 
            this.P_Doctor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.P_Doctor.FormattingEnabled = true;
            this.P_Doctor.Location = new System.Drawing.Point(528, 267);
            this.P_Doctor.Name = "P_Doctor";
            this.P_Doctor.Size = new System.Drawing.Size(231, 21);
            this.P_Doctor.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(524, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 24);
            this.label5.TabIndex = 74;
            this.label5.Text = "Type of Session";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(524, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 73;
            this.label6.Text = "Doctor";
            // 
            // D_O_A
            // 
            this.D_O_A.CalendarMonthBackground = System.Drawing.Color.LightSteelBlue;
            this.D_O_A.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D_O_A.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.D_O_A.Location = new System.Drawing.Point(259, 267);
            this.D_O_A.Name = "D_O_A";
            this.D_O_A.Size = new System.Drawing.Size(231, 26);
            this.D_O_A.TabIndex = 70;
            this.D_O_A.Value = new System.DateTime(2022, 12, 27, 0, 0, 0, 0);
            // 
            // P_Phone_Number
            // 
            this.P_Phone_Number.BackColor = System.Drawing.Color.LightSteelBlue;
            this.P_Phone_Number.Location = new System.Drawing.Point(257, 198);
            this.P_Phone_Number.Margin = new System.Windows.Forms.Padding(4);
            this.P_Phone_Number.Name = "P_Phone_Number";
            this.P_Phone_Number.Size = new System.Drawing.Size(233, 20);
            this.P_Phone_Number.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(255, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 67;
            this.label1.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label8.Location = new System.Drawing.Point(269, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 44);
            this.label8.TabIndex = 66;
            this.label8.Text = "Appointments";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(255, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 24);
            this.label7.TabIndex = 65;
            this.label7.Text = "Patient Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(255, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 69;
            this.label2.Text = "D.O.A";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 219;
            this.pictureBox2.TabStop = false;
            // 
            // Prev
            // 
            this.Prev.FlatAppearance.BorderSize = 0;
            this.Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prev.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prev.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Prev.Location = new System.Drawing.Point(26, 314);
            this.Prev.Margin = new System.Windows.Forms.Padding(4);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(83, 45);
            this.Prev.TabIndex = 247;
            this.Prev.Text = "Prev";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(792, 378);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.P_Name);
            this.Controls.Add(this.Reserve_Appointment);
            this.Controls.Add(this.Slot);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Type_of_Session);
            this.Controls.Add(this.P_Doctor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.D_O_A);
            this.Controls.Add(this.P_Phone_Number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Name = "Appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox P_Name;
        private System.Windows.Forms.Button Reserve_Appointment;
        private System.Windows.Forms.ComboBox Slot;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Type_of_Session;
        private System.Windows.Forms.ComboBox P_Doctor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker D_O_A;
        private System.Windows.Forms.TextBox P_Phone_Number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Prev;
    }
}