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
    public partial class Session : Form
    {
        
        protected string Std_ID;
        public Session()
        {
            InitializeComponent();
        }

        public Session(string stdID)
        {
            InitializeComponent();
            Std_ID = stdID;
            Gridview_Timer.Start();
            Data_Timer.Enabled = true;
            Data_Timer.Start();
        }


        private void DeviceRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Session_Load(object sender, EventArgs e)
        {
            fill_Gridviw();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            child_pannel.Controls.Add(childForm);
            child_pannel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string student_ID = Std_ID;
            string Device_ID = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string OS_Type = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string AvailibleStatus = dataGridView1.Rows[index].Cells[2].Value.ToString();
            
            if (AvailibleStatus == "Free")
            {
                String QUERY = "UPDATE DEVICES SET AVAILABLE_STATUS = 'Occupied' WHERE DEVICE_ID = '"+Device_ID+"';";
                string query2 = "INSERT INTO USAGE VALUES( '"+ Device_ID + "' ,  '" + student_ID + "' , '" + DateTime.Now.ToShortTimeString() + "' , '"+DateTime.Now.AddMinutes(50).ToShortTimeString()+"' , '" + DateTime.Now.ToShortDateString() + "');";

                try
                {
                    string Connection = ConnectionClass.ConnectingString;
                    SqlConnection Conn = new SqlConnection(Connection);
                    Conn.Open();
                    SqlCommand Cmd = new SqlCommand(QUERY, Conn);
                    SqlCommand Cmd1 = new SqlCommand(query2, Conn);
                    Cmd.ExecuteNonQuery();
                    Cmd1.ExecuteNonQuery();
                    Conn.Close();
                    dataGridView1.Rows[index].Cells[2].Value = "Occupied";
                    Session_Timer session_Timer = new Session_Timer(Device_ID, student_ID);
                    openChildForm(session_Timer);
                }
             
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                   
                }

                dataGridView1.Refresh();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Session_Timer_Tick(object sender, EventArgs e)
        {
            
            fill_Gridviw();
            Gridview_Timer.Enabled = false;
        }
        private void fill_Gridviw()
        {
            String conn = ConnectionClass.ConnectingString;
            string query = "SELECT * FROM Devices;";
            SqlConnection C1 = new SqlConnection(conn);
            try
            {
                C1.Open();
                SqlCommand Cmd = new SqlCommand(query, C1);
                SqlDataReader Reading = Cmd.ExecuteReader();
                DataTable t1 = new DataTable();

                while (Reading.Read())
                {
                    dataGridView1.Rows.Add(Reading["DEVICE_ID"], Reading["OS_TYPE"], Reading["AVAILABLE_STATUS"], "ACQUIRE");

                    //dataGridView1.DataSource.Equals(Reading);
                }
                Reading.Close();
                C1.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            dataGridView1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            dataGridView1.Rows.Clear();
            fill_Gridviw();
            Gridview_Timer.Enabled = true;
        }

        private void Data_Timer_Tick(object sender, EventArgs e)
        {
            String conn = ConnectionClass.ConnectingString;
            string query = "SELECT * FROM Devices;";
            SqlConnection C1 = new SqlConnection(conn);
            try
            {
                C1.Open();
                SqlCommand Cmd = new SqlCommand(query, C1);
                SqlDataReader Reading = Cmd.ExecuteReader();
                DataGridView data = new DataGridView();
                data.Columns.Add("Device_ID", "Device_ID");
                data.Columns.Add("OS_TYPE" , "OS_TYPE");
                data.Columns.Add("AVAILABLE_STATUS", "AVAILABLE_STATUS");


                while (Reading.Read())
                {
                    int i = 0;
                    data.Rows.Add(Reading["DEVICE_ID"], Reading["OS_TYPE"], Reading["AVAILABLE_STATUS"]);
                    if (data.Rows[i].Cells[2].Value.ToString() != dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        dataGridView1.Rows.Clear();
                        fill_Gridviw();
                        
                        
                    }
                    i++;
                    //dataGridView1.DataSource.Equals(Reading);
                }
                Reading.Close();
                C1.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            dataGridView1.Refresh();

        }
    }



}