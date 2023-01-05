namespace Bone_Art_Clinic
{
    partial class OCR_Physiotherapist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OCR_Physiotherapist));
            this.Image_Path = new System.Windows.Forms.TextBox();
            this.Convert_to_Text = new System.Windows.Forms.Button();
            this.Add_Photo = new System.Windows.Forms.Button();
            this.OCR_Text = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Prev = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.OCR_Photo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OCR_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // Image_Path
            // 
            this.Image_Path.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Image_Path.Location = new System.Drawing.Point(257, 268);
            this.Image_Path.Name = "Image_Path";
            this.Image_Path.Size = new System.Drawing.Size(253, 20);
            this.Image_Path.TabIndex = 253;
            // 
            // Convert_to_Text
            // 
            this.Convert_to_Text.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Convert_to_Text.FlatAppearance.BorderSize = 0;
            this.Convert_to_Text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Convert_to_Text.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert_to_Text.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Convert_to_Text.Location = new System.Drawing.Point(538, 206);
            this.Convert_to_Text.Name = "Convert_to_Text";
            this.Convert_to_Text.Size = new System.Drawing.Size(200, 54);
            this.Convert_to_Text.TabIndex = 252;
            this.Convert_to_Text.Text = "Convert to Text";
            this.Convert_to_Text.UseVisualStyleBackColor = true;
            this.Convert_to_Text.Click += new System.EventHandler(this.Convert_to_Text_Click);
            // 
            // Add_Photo
            // 
            this.Add_Photo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Add_Photo.FlatAppearance.BorderSize = 0;
            this.Add_Photo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Photo.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Photo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Add_Photo.Location = new System.Drawing.Point(575, 126);
            this.Add_Photo.Name = "Add_Photo";
            this.Add_Photo.Size = new System.Drawing.Size(126, 54);
            this.Add_Photo.TabIndex = 251;
            this.Add_Photo.Text = "Add Photo";
            this.Add_Photo.UseVisualStyleBackColor = true;
            this.Add_Photo.Click += new System.EventHandler(this.Add_Photo_Click);
            // 
            // OCR_Text
            // 
            this.OCR_Text.BackColor = System.Drawing.Color.LightSteelBlue;
            this.OCR_Text.Location = new System.Drawing.Point(12, 316);
            this.OCR_Text.Name = "OCR_Text";
            this.OCR_Text.Size = new System.Drawing.Size(746, 196);
            this.OCR_Text.TabIndex = 250;
            this.OCR_Text.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 44);
            this.label8.TabIndex = 249;
            this.label8.Text = "OCR";
            // 
            // Prev
            // 
            this.Prev.FlatAppearance.BorderSize = 0;
            this.Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prev.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prev.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Prev.Location = new System.Drawing.Point(12, 264);
            this.Prev.Margin = new System.Windows.Forms.Padding(4);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(94, 45);
            this.Prev.TabIndex = 247;
            this.Prev.Text = "Prev";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 255;
            this.pictureBox2.TabStop = false;
            // 
            // OCR_Photo
            // 
            this.OCR_Photo.Location = new System.Drawing.Point(257, 12);
            this.OCR_Photo.Name = "OCR_Photo";
            this.OCR_Photo.Size = new System.Drawing.Size(253, 243);
            this.OCR_Photo.TabIndex = 248;
            this.OCR_Photo.TabStop = false;
            // 
            // OCR_Physiotherapist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(770, 525);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Image_Path);
            this.Controls.Add(this.Convert_to_Text);
            this.Controls.Add(this.Add_Photo);
            this.Controls.Add(this.OCR_Text);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.OCR_Photo);
            this.Controls.Add(this.Prev);
            this.Name = "OCR_Physiotherapist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OCR_Physiotherapist";
            this.Load += new System.EventHandler(this.OCR_Physiotherapist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OCR_Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Image_Path;
        private System.Windows.Forms.Button Convert_to_Text;
        private System.Windows.Forms.Button Add_Photo;
        private System.Windows.Forms.RichTextBox OCR_Text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox OCR_Photo;
        private System.Windows.Forms.Button Prev;
    }
}