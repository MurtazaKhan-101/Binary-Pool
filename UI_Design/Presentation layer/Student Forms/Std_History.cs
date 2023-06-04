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
    public partial class Std_History : Form
    {
        private string Std_ID;
        public Std_History()
        {
            InitializeComponent();
        }

        public Std_History(string StdID)
        {
            InitializeComponent();
            Std_ID = StdID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Std_History_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM USAGE Where STUDENT_ID = '" + Std_ID + "'; ";
            string ConnectingString = ConnectionClass.ConnectingString;
            SqlConnection Connection1 = new SqlConnection(ConnectingString);
            try
            {
                Connection1.Open();
                SqlCommand Cmd = new SqlCommand(query, Connection1);
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["DEVICE_ID"] , reader["STUDENT_ID"] , reader["INITIAL_TIME"] , reader["FINAL_TIME"] , reader["_Date"]);
                }
                reader.Close();
                Connection1.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ex");
                throw;
            }
       }
    }
}
