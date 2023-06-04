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
    public partial class Session_Timer : Form
    {
        string Device_ID;
        string Std_ID;
        public Session_Timer()
        {
            InitializeComponent();
            
        }
        public Session_Timer(string Device_Id , string Std_ID)
        {
            InitializeComponent();
            Device_ID = Device_Id;
            this.Std_ID = Std_ID;
            
        }
        DateTime t = DateTime.Now.AddMinutes(50);
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime T = DateTime.Now;
             string time= (TimeSpan.FromHours(t.Hour) + TimeSpan.FromMinutes(t.Minute) - TimeSpan.FromHours(T.Hour) -  TimeSpan.FromMinutes((T.Minute)) - TimeSpan.FromSeconds((T.Second))).ToString();
            label1.Text = time;

            string query = "SELECT COUNT(*) FROM BAN WHERE Student_ID = '" + Std_ID + "'";
            SqlConnection Comn = new SqlConnection(ConnectionClass.ConnectingString);
            try
            {
                Comn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, Comn);
                DataTable dataTable= new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows[0][0].ToString() == "1")
                {
                    Timer.Enabled = false;
                    MessageBox.Show("You are banned!");
                    this.Hide();
                }
                Comn.Close();

            }
            catch (Exception EX)
            {
                MessageBox.Show("Error is :" + EX.Message);
                
            }
            
        }

        private void Session_Timer_Load(object sender, EventArgs e)
        {
            I_TIME.Text = DateTime.Now.ToString();
            F_Time.Text = DateTime.Now.AddMinutes(50).ToString();
        }

        private void btn_End_Click(object sender, EventArgs e)
        {
            String QUERY = "UPDATE DEVICES SET AVAILABLE_STATUS = 'Free' WHERE DEVICE_ID = '" + Device_ID + "';";
            string query2 = "Update USAGE  SET FINAL_TIME = '" + DateTime.Now.ToString()+"' Where Device_ID = '"+ Device_ID + "' ;";
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
                this.Hide();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
