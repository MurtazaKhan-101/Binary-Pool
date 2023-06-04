namespace UI_Design
{
    partial class Fine_Reason
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fine_Reason));
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.txt_Reason = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DatePicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Amount
            // 
            this.txt_Amount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_Amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txt_Amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Amount.ForeColor = System.Drawing.Color.White;
            this.txt_Amount.Location = new System.Drawing.Point(57, 16);
            this.txt_Amount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(243, 23);
            this.txt_Amount.TabIndex = 3;
            // 
            // txt_Reason
            // 
            this.txt_Reason.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_Reason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txt_Reason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Reason.ForeColor = System.Drawing.Color.White;
            this.txt_Reason.Location = new System.Drawing.Point(57, 15);
            this.txt_Reason.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Reason.Name = "txt_Reason";
            this.txt_Reason.Size = new System.Drawing.Size(243, 23);
            this.txt_Reason.TabIndex = 9;
            // 
            // txt_Description
            // 
            this.txt_Description.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txt_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Description.ForeColor = System.Drawing.Color.White;
            this.txt_Description.Location = new System.Drawing.Point(57, 12);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(243, 61);
            this.txt_Description.TabIndex = 11;
            this.txt_Description.Text = "Explain the reason for fininig the Student....";
            this.txt_Description.TextChanged += new System.EventHandler(this.txt_Description_TextChanged);
            this.txt_Description.MouseEnter += new System.EventHandler(this.txt_Description_MouseEnter);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_Submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(235, 278);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(184, 46);
            this.btn_Submit.TabIndex = 12;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txt_Amount);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(146, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 53);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.DatePicker);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(146, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 53);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.txt_Reason);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(146, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 53);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.txt_Description);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(146, 189);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 81);
            this.panel4.TabIndex = 17;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::UI_Design.Properties.Resources.info;
            this.pictureBox4.Location = new System.Drawing.Point(4, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UI_Design.Properties.Resources.settings;
            this.pictureBox3.Location = new System.Drawing.Point(4, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI_Design.Properties.Resources.clock_time;
            this.pictureBox2.Location = new System.Drawing.Point(4, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // DatePicker
            // 
            this.DatePicker.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DatePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.DatePicker.BorderRadius = 1;
            this.DatePicker.Color = System.Drawing.Color.Silver;
            this.DatePicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.DatePicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.DatePicker.DisabledColor = System.Drawing.Color.Gray;
            this.DatePicker.DisplayWeekNumbers = false;
            this.DatePicker.DPHeight = 0;
            this.DatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DatePicker.FillDatePicker = false;
            this.DatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DatePicker.ForeColor = System.Drawing.Color.White;
            this.DatePicker.Icon = ((System.Drawing.Image)(resources.GetObject("DatePicker.Icon")));
            this.DatePicker.IconColor = System.Drawing.Color.Gray;
            this.DatePicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.DatePicker.LeftTextMargin = 5;
            this.DatePicker.Location = new System.Drawing.Point(56, 8);
            this.DatePicker.MinimumSize = new System.Drawing.Size(4, 32);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(240, 32);
            this.DatePicker.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI_Design.Properties.Resources.dollar;
            this.pictureBox1.Location = new System.Drawing.Point(4, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Fine_Reason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 338);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Fine_Reason";
            this.Text = "Fine_Reason";
            this.Load += new System.EventHandler(this.Fine_Reason_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.TextBox txt_Reason;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Button btn_Submit;
        private Bunifu.UI.WinForms.BunifuDatePicker DatePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}