namespace UI_Design
{
    partial class Student_Login
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
            this.btn_stdLogin = new System.Windows.Forms.Button();
            this.btn_showadminpass = new System.Windows.Forms.Button();
            this.txtPass_std = new System.Windows.Forms.TextBox();
            this.txtID_std = new System.Windows.Forms.TextBox();
            this.STD_Password = new System.Windows.Forms.Label();
            this.STD_ID = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // btn_stdLogin
            // 
            this.btn_stdLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_stdLogin.Location = new System.Drawing.Point(210, 177);
            this.btn_stdLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_stdLogin.Name = "btn_stdLogin";
            this.btn_stdLogin.Size = new System.Drawing.Size(66, 23);
            this.btn_stdLogin.TabIndex = 11;
            this.btn_stdLogin.Text = "Log in";
            this.btn_stdLogin.UseVisualStyleBackColor = true;
            this.btn_stdLogin.Click += new System.EventHandler(this.btn_stdLogin_Click);
            // 
            // btn_showadminpass
            // 
            this.btn_showadminpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_showadminpass.Location = new System.Drawing.Point(326, 135);
            this.btn_showadminpass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_showadminpass.Name = "btn_showadminpass";
            this.btn_showadminpass.Size = new System.Drawing.Size(20, 20);
            this.btn_showadminpass.TabIndex = 10;
            this.btn_showadminpass.Text = "E";
            this.btn_showadminpass.UseVisualStyleBackColor = true;
            // 
            // txtPass_std
            // 
            this.txtPass_std.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass_std.Location = new System.Drawing.Point(173, 136);
            this.txtPass_std.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPass_std.Name = "txtPass_std";
            this.txtPass_std.Size = new System.Drawing.Size(145, 20);
            this.txtPass_std.TabIndex = 9;
            this.txtPass_std.UseSystemPasswordChar = true;
            // 
            // txtID_std
            // 
            this.txtID_std.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID_std.Location = new System.Drawing.Point(173, 88);
            this.txtID_std.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID_std.Name = "txtID_std";
            this.txtID_std.Size = new System.Drawing.Size(145, 20);
            this.txtID_std.TabIndex = 8;
            // 
            // STD_Password
            // 
            this.STD_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.STD_Password.AutoSize = true;
            this.STD_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STD_Password.Location = new System.Drawing.Point(67, 133);
            this.STD_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.STD_Password.Name = "STD_Password";
            this.STD_Password.Size = new System.Drawing.Size(78, 20);
            this.STD_Password.TabIndex = 7;
            this.STD_Password.Text = "Password";
            // 
            // STD_ID
            // 
            this.STD_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.STD_ID.AutoSize = true;
            this.STD_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STD_ID.Location = new System.Drawing.Point(67, 88);
            this.STD_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.STD_ID.Name = "STD_ID";
            this.STD_ID.Size = new System.Drawing.Size(26, 20);
            this.STD_ID.TabIndex = 6;
            this.STD_ID.Text = "ID";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Student_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 328);
            this.Controls.Add(this.btn_stdLogin);
            this.Controls.Add(this.btn_showadminpass);
            this.Controls.Add(this.txtPass_std);
            this.Controls.Add(this.txtID_std);
            this.Controls.Add(this.STD_Password);
            this.Controls.Add(this.STD_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Student_Login";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_stdLogin;
        private System.Windows.Forms.Button btn_showadminpass;
        private System.Windows.Forms.TextBox txtPass_std;
        private System.Windows.Forms.TextBox txtID_std;
        private System.Windows.Forms.Label STD_Password;
        private System.Windows.Forms.Label STD_ID;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}