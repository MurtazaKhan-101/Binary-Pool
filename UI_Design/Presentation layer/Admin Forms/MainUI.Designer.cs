namespace UI_Design
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelAdminSubMenu = new System.Windows.Forms.Panel();
            this.admin_logout = new System.Windows.Forms.Button();
            this.btnManage_Devices = new System.Windows.Forms.Button();
            this.btn_Record = new System.Windows.Forms.Button();
            this.btn_Fine = new System.Windows.Forms.Button();
            this.btn_Ban = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelAdminSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.Black;
            this.panelSideMenu.Controls.Add(this.pictureBox3);
            this.panelSideMenu.Controls.Add(this.panelAdminSubMenu);
            this.panelSideMenu.Controls.Add(this.btnAdmin);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(251, 561);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelAdminSubMenu
            // 
            this.panelAdminSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelAdminSubMenu.Controls.Add(this.pictureBox4);
            this.panelAdminSubMenu.Controls.Add(this.admin_logout);
            this.panelAdminSubMenu.Controls.Add(this.btnManage_Devices);
            this.panelAdminSubMenu.Controls.Add(this.btn_Record);
            this.panelAdminSubMenu.Controls.Add(this.btn_Fine);
            this.panelAdminSubMenu.Controls.Add(this.btn_Ban);
            this.panelAdminSubMenu.Controls.Add(this.btn_Add);
            this.panelAdminSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdminSubMenu.Location = new System.Drawing.Point(0, 142);
            this.panelAdminSubMenu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelAdminSubMenu.Name = "panelAdminSubMenu";
            this.panelAdminSubMenu.Size = new System.Drawing.Size(251, 312);
            this.panelAdminSubMenu.TabIndex = 2;
            // 
            // admin_logout
            // 
            this.admin_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.admin_logout.FlatAppearance.BorderSize = 0;
            this.admin_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.admin_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_logout.ForeColor = System.Drawing.Color.White;
            this.admin_logout.Location = new System.Drawing.Point(0, 250);
            this.admin_logout.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.admin_logout.Name = "admin_logout";
            this.admin_logout.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.admin_logout.Size = new System.Drawing.Size(251, 54);
            this.admin_logout.TabIndex = 8;
            this.admin_logout.Text = "        Log out";
            this.admin_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_logout.UseVisualStyleBackColor = true;
            this.admin_logout.Click += new System.EventHandler(this.admin_logout_Click);
            // 
            // btnManage_Devices
            // 
            this.btnManage_Devices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManage_Devices.FlatAppearance.BorderSize = 0;
            this.btnManage_Devices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnManage_Devices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage_Devices.ForeColor = System.Drawing.Color.White;
            this.btnManage_Devices.Location = new System.Drawing.Point(0, 200);
            this.btnManage_Devices.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnManage_Devices.Name = "btnManage_Devices";
            this.btnManage_Devices.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnManage_Devices.Size = new System.Drawing.Size(251, 50);
            this.btnManage_Devices.TabIndex = 6;
            this.btnManage_Devices.Text = "Manage Devices";
            this.btnManage_Devices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManage_Devices.UseVisualStyleBackColor = true;
            this.btnManage_Devices.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btn_Record
            // 
            this.btn_Record.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Record.FlatAppearance.BorderSize = 0;
            this.btn_Record.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Record.ForeColor = System.Drawing.Color.White;
            this.btn_Record.Location = new System.Drawing.Point(0, 150);
            this.btn_Record.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_Record.Name = "btn_Record";
            this.btn_Record.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btn_Record.Size = new System.Drawing.Size(251, 50);
            this.btn_Record.TabIndex = 4;
            this.btn_Record.Text = "Record";
            this.btn_Record.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Record.UseVisualStyleBackColor = true;
            this.btn_Record.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_Fine
            // 
            this.btn_Fine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Fine.FlatAppearance.BorderSize = 0;
            this.btn_Fine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Fine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fine.ForeColor = System.Drawing.Color.White;
            this.btn_Fine.Location = new System.Drawing.Point(0, 100);
            this.btn_Fine.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_Fine.Name = "btn_Fine";
            this.btn_Fine.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btn_Fine.Size = new System.Drawing.Size(251, 50);
            this.btn_Fine.TabIndex = 3;
            this.btn_Fine.Text = "Fine Section";
            this.btn_Fine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Fine.UseVisualStyleBackColor = true;
            this.btn_Fine.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_Ban
            // 
            this.btn_Ban.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Ban.FlatAppearance.BorderSize = 0;
            this.btn_Ban.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Ban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ban.ForeColor = System.Drawing.Color.White;
            this.btn_Ban.Location = new System.Drawing.Point(0, 50);
            this.btn_Ban.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_Ban.Name = "btn_Ban";
            this.btn_Ban.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btn_Ban.Size = new System.Drawing.Size(251, 50);
            this.btn_Ban.TabIndex = 2;
            this.btn_Ban.Text = "Ban Section";
            this.btn_Ban.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ban.UseVisualStyleBackColor = true;
            this.btn_Ban.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(0, 0);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btn_Add.Size = new System.Drawing.Size(251, 50);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add Student";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(0, 86);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(251, 56);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(251, 86);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(251, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(683, 561);
            this.panelChildForm.TabIndex = 1;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI_Design.Properties.Resources.bp_logo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(151, 126);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Image = global::UI_Design.Properties.Resources.logout__1_1;
            this.pictureBox3.Location = new System.Drawing.Point(12, 501);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::UI_Design.Properties.Resources.logout;
            this.pictureBox4.Location = new System.Drawing.Point(55, 257);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI_Design.Properties.Resources.bp1;
            this.pictureBox2.Location = new System.Drawing.Point(43, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panelSideMenu.ResumeLayout(false);
            this.panelAdminSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelAdminSubMenu;
        private System.Windows.Forms.Button btn_Fine;
        private System.Windows.Forms.Button btn_Ban;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Record;
        private System.Windows.Forms.Button btnManage_Devices;
        private System.Windows.Forms.Button admin_logout;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}