using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    public partial class Add_Student : Form
    {
        private string Admin_ID; 
        public Add_Student()
        {
           InitializeComponent();
        }
        
        public Add_Student(string admin_id)
        {
            InitializeComponent();
            this.Admin_ID = admin_id;
            
        }
        private void btn_stdcreate_Click(object sender, EventArgs e)
        {
            string id = txtID_std.Text;
            string name = txtstudentName.Text;
            string pass = txtPass_std.Text;
            string conn = ConnectionClass.ConnectingString;
            string query = "INSERT INTO _USER(STUDENT_ID , STUDENT_NAME ,LOGIN_PASSWORD , ADMIN_ID)" +
                "VALUES ('" + id + "','" + name + "','" + pass + "' , '" + Admin_ID + "');";
            try
            {
                SqlConnection sql_conn = new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand(query,sql_conn);
                sql_conn.Open();
                cmd.ExecuteNonQuery();
                sql_conn.Close();
                MessageBox.Show("Added Successfully");
                txtID_std.Text = "";
                txtPass_std.Text = "";
                txtstudentName.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An Error has occured: " + Ex.Message);
            }
        }

        private void Add_Student_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (txtPass_std.UseSystemPasswordChar == false)
            {
                txtPass_std.UseSystemPasswordChar = true;
                pictureBox4.Image = Properties.Resources.hide;
            }
            else if (txtPass_std.UseSystemPasswordChar == true)
            {
                txtPass_std.UseSystemPasswordChar = false;
                pictureBox4.Image = Properties.Resources.show;
            }
        }

        private void hide_pass_Click(object sender, EventArgs e)
        {

        }
    }
}
