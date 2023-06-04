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
    public partial class Profile : Form
    {
        private string Student_ID;
        public Profile()
        {
            InitializeComponent();
        }

        public Profile(string Std_ID)
        {
            InitializeComponent();
            Student_ID = Std_ID;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM _USER WHERE STUDENT_ID = '" + Student_ID + "';";
            string Connecting = ConnectionClass.ConnectingString;
            try
            {
                SqlConnection Conn = new SqlConnection(Connecting);
                Conn.Open();    
                SqlCommand Cmd = new SqlCommand(query , Conn);
                SqlDataReader Reader = Cmd.ExecuteReader();
                while(Reader.Read())
                {
                    txtID.Text = Reader.GetString(0);
                    txt_name.Text = Reader.GetString(1);
                    txt_Password.Text = Reader.GetString(2);
                }
                Reader.Close();
                Conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
         }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string name = txt_name.Text;
            string password = txt_Password.Text;
            string query = "UPDATE _USER SET STUDENT_NAME = '" + name + "' , LOGIN_PASSWORD = '" + password + "' WHERE STUDENT_ID = '" + ID + "';";
            String ConnectingString = ConnectionClass.ConnectingString;
            SqlConnection Conn = new SqlConnection(ConnectingString);
            SqlCommand Cmd = new SqlCommand(query, Conn);
            try
            {
                Conn.Open();
                Cmd.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            MessageBox.Show("Your Changes are saved Successfully!");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (txt_Password.UseSystemPasswordChar == false)
            {
                txt_Password.UseSystemPasswordChar = true;
                pictureBox4.Image = Properties.Resources.hide;
            }
            else if (txt_Password.UseSystemPasswordChar == true)
            {
                txt_Password.UseSystemPasswordChar = false;
                pictureBox4.Image = Properties.Resources.show;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
