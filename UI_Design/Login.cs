using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = txtID_login;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //MessageBox.Show(txt_id.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string id = txtID_login.Text;
            string pass = txtPass_login.Text;

            string conn = ConnectionClass.ConnectingString;
            string BANQuery = "SELECT COUNT(*) FROM BAN WHERE STUDENT_ID = '" + id + "';";
            string adminquery = "SELECT COUNT(*) FROM _ADMIN WHERE ADMIN_ID = '" + id + "' AND ADMIN_PASSWORD = '" + pass + "';";
            string studentquery = "SELECT COUNT(*) FROM _USER WHERE STUDENT_ID = '" + id + "' AND LOGIN_PASSWORD = '" + pass + "';";
            try
            {
                SqlConnection sqlconn = new SqlConnection(conn);
                SqlDataAdapter cmd = new SqlDataAdapter(adminquery, sqlconn);
                SqlDataAdapter cmd2 = new SqlDataAdapter(BANQuery, sqlconn);
                SqlDataAdapter cmd3 = new SqlDataAdapter(studentquery, sqlconn); 
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                DataTable dt2 = new DataTable();
                cmd3.Fill(dt2);
                DataTable BANTable = new DataTable();
                cmd2.Fill(BANTable);
                if (BANTable.Rows[0][0].ToString() == "1" )
                {
                    MessageBox.Show("You are Banned!");
                }
                else if ((dt.Rows[0][0].ToString() == "1"))
                {
                    //MessageBox.Show("Signed in as Admin");
                    this.Hide();
                    MainUI m1 = new MainUI(id);
                    m1.ShowDialog();
                }
                else if ((dt2.Rows[0][0].ToString() == "1"))
                {
                    //MessageBox.Show("Signed in as Student " + id);
                    this.Hide();
                    MainUI2 m2 = new MainUI2(id);
                    m2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect Credentials");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An Error has occured: " + Ex.Message);
            }
        }

        private void btn_Login_MouseHover(object sender, EventArgs e)
        {

        }

        private void Scanner_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPass_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string result = BarcodeScanner.Option1_ExecProcess();

            string ConnectingString = ConnectionClass.ConnectingString;

            string barcodequery = "SELECT COUNT(*) FROM _USER WHERE STUDENT_ID = '" + result + "';";
            string barcodequery2 = "SELECT COUNT(*) FROM _ADMIN WHERE ADMIN_ID = '" + result + "';";
            string banquery = "SELECT COUNT(*) FROM BAN WHERE STUDENT_ID = '" + result + "';";

            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectingString);
                SqlDataAdapter cmd1 = new SqlDataAdapter(barcodequery, sqlconn);
                SqlDataAdapter cmd2 = new SqlDataAdapter(barcodequery2, sqlconn);
                SqlDataAdapter cmd3 = new SqlDataAdapter(banquery, sqlconn);
                DataTable dt1 = new DataTable();
                cmd1.Fill(dt1);
                DataTable dt2 = new DataTable();
                cmd2.Fill(dt2);
                DataTable dt3 = new DataTable();
                cmd3.Fill(dt3);
                sqlconn.Close();
                
                if ((dt3.Rows[0][0].ToString() == "1"))
                {
                    MessageBox.Show("You are Banned !!");
                }
                else if ((dt1.Rows[0][0].ToString() == "1"))
                {
                    //MessageBox.Show("Signed in as Student");
                    this.Hide();
                    MainUI2 m = new MainUI2(result);
                    m.Show();
                }
                else if ((dt2.Rows[0][0].ToString() == "1"))
                {
                    //MessageBox.Show("Signed in as Student");
                    this.Hide();
                    MainUI m = new MainUI(result);
                    m.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An Error has occured: " + Ex.Message);
            }
        }

        private void txtID_login_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtID_login.Text))
            {
                e.Cancel = true;
                txtID_login.Focus();
                errorProvider1.SetError(txtID_login, "Please Enter Your ID !!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtID_login, null);
            }
        }

        private void txtPass_login_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass_login.Text))
            {
                e.Cancel = true;
                txtPass_login.Focus();
                errorProvider2.SetError(txtPass_login, "Please Enter Your Password !!");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtPass_login, null);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (txtPass_login.UseSystemPasswordChar == false)
            {
                txtPass_login.UseSystemPasswordChar = true;
                pictureBox4.Image = Properties.Resources.hide;
            }
            else if (txtPass_login.UseSystemPasswordChar == true)
            {
                txtPass_login.UseSystemPasswordChar = false;
                pictureBox4.Image = Properties.Resources.show;
            }
        }
    }
}
