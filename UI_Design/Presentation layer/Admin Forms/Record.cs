using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    public partial class Record : Form
    {
        private string Admin_ID; 
        public Record()
        {
            InitializeComponent();
        }
        public Record(string A_ID)
        {
            InitializeComponent();
            Admin_ID = A_ID;
        }
        private void Record_Load(object sender, EventArgs e)
        {
            string query = "SELECT _USER.STUDENT_ID , STUDENT_NAME , DEVICE_ID , INITIAL_TIME, FINAL_TIME , _Date FROM _User  INNER JOIN Usage  ON _User.STUDENT_ID = USAGE.STUDENT_ID;";
            string ConnectingString = ConnectionClass.ConnectingString;
            try
            {
                SqlConnection Conn = new SqlConnection(ConnectingString);
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(query , Conn);
                SqlDataReader dataReader =  Cmd.ExecuteReader();
                while(dataReader.Read() )
                {
                    dataGridView1.Rows.Add(dataReader["STUDENT_ID"], dataReader["STUDENT_NAME"], dataReader["DEVICE_ID"], dataReader["INITIAL_TIME"], dataReader["FINAL_TIME"], dataReader["_Date"]);
                }
                dataReader.Close();
                Conn.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error  is "+EX.Message);
            }

            //Combo Box
            comboBox1.Items.Add("Student ID");
            comboBox1.Items.Add("Student Name");
            comboBox1.Items.Add("Initial Time");
            comboBox1.Items.Add("Final Time");
            comboBox1.Items.Add("Device ID");
            comboBox1.Items.Add("Date");


        }

        private void txt_Date_TextChanged(object sender, EventArgs e)
        { 
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //dataGridView1 = null; 
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = null;
            //string DateSearch = txt_Search.Text;
            string DateSearch = DatePicker.Value.ToShortDateString();
            string query = "SELECT _USER.STUDENT_ID , STUDENT_NAME , DEVICE_ID , INITIAL_TIME, FINAL_TIME , _Date FROM _User  INNER JOIN Usage ON _User.STUDENT_ID = USAGE.STUDENT_ID Where _Date = '" + DateSearch + "';";
            string ConnectingString = ConnectionClass.ConnectingString;
            try
            {
                SqlConnection Conn = new SqlConnection(ConnectingString);
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(query, Conn);
                SqlDataReader dataReader = Cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add(dataReader["STUDENT_ID"], dataReader["STUDENT_NAME"], dataReader["DEVICE_ID"], dataReader["INITIAL_TIME"], dataReader["FINAL_TIME"], dataReader["_Date"]);
                }
                dataReader.Close();
                Conn.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void OrderBY(string order)
        { 
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = null;
            string query = "SELECT _USER.STUDENT_ID , STUDENT_NAME , DEVICE_ID , INITIAL_TIME, FINAL_TIME , _Date FROM _User  INNER JOIN Usage ON _User.STUDENT_ID = USAGE.STUDENT_ID Order By '"+order+"';";
            string ConnectingString = ConnectionClass.ConnectingString;
            try
            {
                SqlConnection Conn = new SqlConnection(ConnectingString);
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(query, Conn);
                SqlDataReader dataReader = Cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add(dataReader["STUDENT_ID"], dataReader["STUDENT_NAME"], dataReader["DEVICE_ID"], dataReader["INITIAL_TIME"], dataReader["FINAL_TIME"], dataReader["_Date"]);
                }
                dataReader.Close();
                Conn.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (comboBox1.SelectedIndex == 0)
            {
               OrderBY("Student_ID");                
            }
            else if (comboBox1.SelectedIndex == 1)
            {
               OrderBY("STUDENT_NAME");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                OrderBY("Initial_Time");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                OrderBY("Final_Time");
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                OrderBY("DEVICE_ID");
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                OrderBY("_Date");
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
