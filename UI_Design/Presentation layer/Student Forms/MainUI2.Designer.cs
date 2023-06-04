namespace UI_Design
{
    partial class MainUI2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI2));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelStudentSubMenu = new System.Windows.Forms.Panel();
            this.std_logout = new System.Windows.Forms.Button();
            this.btn_Fine = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnSession = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.AppTimer = new System.Windows.Forms.Timer(this.components);
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelStudentSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.Black;
            this.panelSideMenu.Controls.Add(this.pictureBox4);
            this.panelSideMenu.Controls.Add(this.panelStudentSubMenu);
            this.panelSideMenu.Controls.Add(this.btnStudent);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(251, 561);
            this.panelSideMenu.TabIndex = 1;
            // 
            // panelStudentSubMenu
            // 
            this.panelStudentSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelStudentSubMenu.Controls.Add(this.pictureBox3);
            this.panelStudentSubMenu.Controls.Add(this.std_logout);
            this.panelStudentSubMenu.Controls.Add(this.btn_Fine);
            this.panelStudentSubMenu.Controls.Add(this.btnProfile);
            this.panelStudentSubMenu.Controls.Add(this.btnHistory);
            this.panelStudentSubMenu.Controls.Add(this.btnSession);
            this.panelStudentSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStudentSubMenu.Location = new System.Drawing.Point(0, 142);
            this.panelStudentSubMenu.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.panelStudentSubMenu.Name = "panelStudentSubMenu";
            this.panelStudentSubMenu.Size = new System.Drawing.Size(251, 287);
            this.panelStudentSubMenu.TabIndex = 2;
            // 
            // std_logout
            // 
            this.std_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.std_logout.FlatAppearance.BorderSize = 0;
            this.std_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.std_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.std_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_logout.ForeColor = System.Drawing.Color.White;
            this.std_logout.Location = new System.Drawing.Point(0, 200);
            this.std_logout.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.std_logout.Name = "std_logout";
            this.std_logout.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.std_logout.Size = new System.Drawing.Size(251, 51);
            this.std_logout.TabIndex = 7;
            this.std_logout.Text = "        Log out";
            this.std_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.std_logout.UseVisualStyleBackColor = true;
            this.std_logout.Click += new System.EventHandler(this.std_logout_Click_1);
            // 
            // btn_Fine
            // 
            this.btn_Fine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Fine.FlatAppearance.BorderSize = 0;
            this.btn_Fine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Fine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fine.ForeColor = System.Drawing.Color.White;
            this.btn_Fine.Location = new System.Drawing.Point(0, 150);
            this.btn_Fine.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btn_Fine.Name = "btn_Fine";
            this.btn_Fine.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btn_Fine.Size = new System.Drawing.Size(251, 50);
            this.btn_Fine.TabIndex = 6;
            this.btn_Fine.Text = "Dues";
            this.btn_Fine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Fine.UseVisualStyleBackColor = true;
            this.btn_Fine.Click += new System.EventHandler(this.btn_Fine_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(0, 100);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(251, 50);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Location = new System.Drawing.Point(0, 50);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnHistory.Size = new System.Drawing.Size(251, 50);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "History";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSession
            // 
            this.btnSession.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSession.FlatAppearance.BorderSize = 0;
            this.btnSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSession.ForeColor = System.Drawing.Color.White;
            this.btnSession.Location = new System.Drawing.Point(0, 0);
            this.btnSession.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnSession.Name = "btnSession";
            this.btnSession.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnSession.Size = new System.Drawing.Size(251, 50);
            this.btnSession.TabIndex = 1;
            this.btnSession.Text = "Start Session";
            this.btnSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSession.UseVisualStyleBackColor = true;
            this.btnSession.Click += new System.EventHandler(this.btnSession_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Location = new System.Drawing.Point(0, 86);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnStudent.Size = new System.Drawing.Size(251, 56);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "Student";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(251, 86);
            this.panelLogo.TabIndex = 0;
            // 
            // AppTimer
            // 
            this.AppTimer.Enabled = true;
            this.AppTimer.Interval = 1000000;
            this.AppTimer.Tick += new System.EventHandler(this.AppTimer_Tick);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(251, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(683, 561);
            this.panelChildForm.TabIndex = 2;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox4.Image = global::UI_Design.Properties.Resources.logout__1_1;
            this.pictureBox4.Location = new System.Drawing.Point(12, 501);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UI_Design.Properties.Resources.logout;
            this.pictureBox3.Location = new System.Drawing.Point(56, 207);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI_Design.Properties.Resources.bp1;
            this.pictureBox2.Location = new System.Drawing.Point(43, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI_Design.Properties.Resources.bp_logo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(146, 125);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainUI2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "MainUI2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.panelSideMenu.ResumeLayout(false);
            this.panelStudentSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelStudentSubMenu;
        private System.Windows.Forms.Button btnSession;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Timer AppTimer;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btn_Fine;
        private System.Windows.Forms.Button std_logout;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}