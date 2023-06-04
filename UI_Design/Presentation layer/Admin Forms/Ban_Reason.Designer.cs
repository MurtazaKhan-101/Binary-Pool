namespace UI_Design
{
    partial class Ban_Reason
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
            this.project_DatabaseDataSet1 = new UI_Design.Project_DatabaseDataSet();
            this.CB_overtime = new System.Windows.Forms.CheckBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.btn_Done = new System.Windows.Forms.Button();
            this.txt_Duration = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.project_DatabaseDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // project_DatabaseDataSet1
            // 
            this.project_DatabaseDataSet1.DataSetName = "Project_DatabaseDataSet";
            this.project_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CB_overtime
            // 
            this.CB_overtime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CB_overtime.AutoSize = true;
            this.CB_overtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_overtime.Location = new System.Drawing.Point(198, 11);
            this.CB_overtime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB_overtime.Name = "CB_overtime";
            this.CB_overtime.Size = new System.Drawing.Size(155, 33);
            this.CB_overtime.TabIndex = 2;
            this.CB_overtime.Text = "Extra Time";
            this.CB_overtime.UseVisualStyleBackColor = true;
            this.CB_overtime.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_Description
            // 
            this.txt_Description.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txt_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Description.ForeColor = System.Drawing.Color.White;
            this.txt_Description.Location = new System.Drawing.Point(57, 13);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(243, 61);
            this.txt_Description.TabIndex = 5;
            this.txt_Description.Text = "Add the description of banning the student......";
            this.txt_Description.Click += new System.EventHandler(this.txt_Description_Click);
            // 
            // btn_Done
            // 
            this.btn_Done.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_Done.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_Done.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Done.ForeColor = System.Drawing.Color.White;
            this.btn_Done.Location = new System.Drawing.Point(248, 219);
            this.btn_Done.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(112, 49);
            this.btn_Done.TabIndex = 7;
            this.btn_Done.Text = "Done";
            this.btn_Done.UseVisualStyleBackColor = false;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // txt_Duration
            // 
            this.txt_Duration.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_Duration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txt_Duration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Duration.ForeColor = System.Drawing.Color.White;
            this.txt_Duration.Location = new System.Drawing.Point(57, 14);
            this.txt_Duration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Duration.Name = "txt_Duration";
            this.txt_Duration.Size = new System.Drawing.Size(254, 23);
            this.txt_Duration.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txt_Duration);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(131, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 53);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.CB_overtime);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(131, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 53);
            this.panel2.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI_Design.Properties.Resources.danger;
            this.pictureBox2.Location = new System.Drawing.Point(4, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI_Design.Properties.Resources.duration;
            this.pictureBox1.Location = new System.Drawing.Point(4, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.txt_Description);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(131, 130);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 81);
            this.panel4.TabIndex = 18;
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
            // Ban_Reason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 275);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Done);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ban_Reason";
            this.Text = "Ban_Reason";
            this.Load += new System.EventHandler(this.Ban_Reason_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project_DatabaseDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Project_DatabaseDataSet project_DatabaseDataSet1;
        private System.Windows.Forms.CheckBox CB_overtime;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.TextBox txt_Duration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}