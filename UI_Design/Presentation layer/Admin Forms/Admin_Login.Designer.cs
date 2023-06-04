namespace UI_Design
{
    partial class Admin_Login
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
            this.Admin_ID = new System.Windows.Forms.Label();
            this.Admin_Password = new System.Windows.Forms.Label();
            this.txtID_admin = new System.Windows.Forms.TextBox();
            this.txtPass_admin = new System.Windows.Forms.TextBox();
            this.btn_showadminpass = new System.Windows.Forms.Button();
            this.btn_adminLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Admin_ID
            // 
            this.Admin_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Admin_ID.AutoSize = true;
            this.Admin_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_ID.Location = new System.Drawing.Point(111, 138);
            this.Admin_ID.Name = "Admin_ID";
            this.Admin_ID.Size = new System.Drawing.Size(36, 29);
            this.Admin_ID.TabIndex = 0;
            this.Admin_ID.Text = "ID";
            this.Admin_ID.Click += new System.EventHandler(this.Admin_ID_Click);
            // 
            // Admin_Password
            // 
            this.Admin_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Admin_Password.AutoSize = true;
            this.Admin_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Password.Location = new System.Drawing.Point(111, 208);
            this.Admin_Password.Name = "Admin_Password";
            this.Admin_Password.Size = new System.Drawing.Size(120, 29);
            this.Admin_Password.TabIndex = 1;
            this.Admin_Password.Text = "Password";
            this.Admin_Password.Click += new System.EventHandler(this.Admin_Password_Click);
            // 
            // txtID_admin
            // 
            this.txtID_admin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID_admin.Location = new System.Drawing.Point(269, 138);
            this.txtID_admin.Name = "txtID_admin";
            this.txtID_admin.Size = new System.Drawing.Size(215, 26);
            this.txtID_admin.TabIndex = 2;
            this.txtID_admin.TextChanged += new System.EventHandler(this.txtID_admin_TextChanged);
            // 
            // txtPass_admin
            // 
            this.txtPass_admin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass_admin.Location = new System.Drawing.Point(269, 212);
            this.txtPass_admin.Name = "txtPass_admin";
            this.txtPass_admin.Size = new System.Drawing.Size(215, 26);
            this.txtPass_admin.TabIndex = 3;
            this.txtPass_admin.UseSystemPasswordChar = true;
            this.txtPass_admin.TextChanged += new System.EventHandler(this.txtPass_admin_TextChanged);
            // 
            // btn_showadminpass
            // 
            this.btn_showadminpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_showadminpass.Location = new System.Drawing.Point(499, 210);
            this.btn_showadminpass.Name = "btn_showadminpass";
            this.btn_showadminpass.Size = new System.Drawing.Size(30, 31);
            this.btn_showadminpass.TabIndex = 4;
            this.btn_showadminpass.Text = "E";
            this.btn_showadminpass.UseVisualStyleBackColor = true;
            this.btn_showadminpass.Click += new System.EventHandler(this.btn_showadminpass_Click);
            // 
            // btn_adminLogin
            // 
            this.btn_adminLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_adminLogin.Location = new System.Drawing.Point(325, 275);
            this.btn_adminLogin.Name = "btn_adminLogin";
            this.btn_adminLogin.Size = new System.Drawing.Size(99, 35);
            this.btn_adminLogin.TabIndex = 5;
            this.btn_adminLogin.Text = "Log in";
            this.btn_adminLogin.UseVisualStyleBackColor = true;
            this.btn_adminLogin.Click += new System.EventHandler(this.btn_adminLogin_Click);
            // 
            // Admin_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 505);
            this.Controls.Add(this.btn_adminLogin);
            this.Controls.Add(this.btn_showadminpass);
            this.Controls.Add(this.txtPass_admin);
            this.Controls.Add(this.txtID_admin);
            this.Controls.Add(this.Admin_Password);
            this.Controls.Add(this.Admin_ID);
            this.Name = "Admin_Login";
            this.Text = "A";
            this.Load += new System.EventHandler(this.Admin_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Admin_ID;
        private System.Windows.Forms.Label Admin_Password;
        private System.Windows.Forms.TextBox txtID_admin;
        private System.Windows.Forms.TextBox txtPass_admin;
        private System.Windows.Forms.Button btn_showadminpass;
        private System.Windows.Forms.Button btn_adminLogin;
    }
}