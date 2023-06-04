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
using ZXing;

namespace UI_Design
{
    public partial class Fine_Slip : Form
    {
        private string Student_ID; 
        public Fine_Slip()
        {
            InitializeComponent();
        }
        public Fine_Slip(string STD_ID)
        {
            InitializeComponent();
            Student_ID = STD_ID;
            reload_Timer.Start();
            reload_Timer.Enabled= false;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Fine_Slip_Load(object sender, EventArgs e)
        {

            FillData();

        }

        private void txtFineID_TextChanged(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void FillData()
        {

            string query = "SELECT * FROM FINE_GENERATE WHERE Student_ID = '" + Student_ID + "'";
            string ConnectingString = ConnectionClass.ConnectingString;
            try
            {
                SqlConnection Conn = new SqlConnection(ConnectingString);
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(query, Conn);
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtFineID.Text = reader["Fine_ID"].ToString();
                    txtDues.Text = reader["Fine_Amount"].ToString();
                    txt_issue.Text = reader["Issue_Date"].ToString();
                    txtLastDate.Text = reader["Due_Date"].ToString();
                }
                reader.Close();
                Conn.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string result = BarcodeScanner.Option1_ExecProcess();

            if(result == Student_ID)
            {
                string ConnectingString = ConnectionClass.ConnectingString;
                SqlConnection conn = new SqlConnection(ConnectingString);
                string DeleteFromFine = "DELETE FROM FINE_GENERATE WHERE Student_ID = '" + result + "';";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(DeleteFromFine,conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Your Fine is Added to your Fees");
                }
                catch(Exception EX)
                {
                    MessageBox.Show("Error: " + EX.Message);
                }
                reload_Timer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid Card");
            }
        }

        private void reload_Timer_Tick(object sender, EventArgs e)
        {
            txtFineID.Text = "";
            txtDues.Text = "";
            txt_issue.Text = "";
            txtLastDate.Text = "";
            FillData();
            reload_Timer.Enabled = false;
        }
    }
}
