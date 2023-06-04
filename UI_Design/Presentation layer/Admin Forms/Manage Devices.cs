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
using System.Timers;
using System.Windows.Forms;

namespace UI_Design
{
    public partial class Manage_Devices : Form
    {

        public Manage_Devices()
        {
            InitializeComponent();

            FillGridview();
        }

        private void Device_Record_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            
            if (e.ColumnIndex == Change_Status.Index)
            {
                set_State(e.RowIndex);
            }else if(e.ColumnIndex == Under_Maintainance.Index)
            {
                Set_Under_Maintainance(index);
            }
        }        

        private void FillGridview()
        {
            string Free_Query = "SELECT * FROM DEVICES WHERE AVAILABLE_STATUS = 'Free' Order By Device_ID;";
            string OccupyQuery = "SELECT * FROM DEVICES WHERE AVAILABLE_STATUS = 'Occupied' Order By Device_ID ;";
            string UnderMAintainanceQuery = "SELECT * FROM DEVICES WHERE AVAILABLE_STATUS = 'Under Maintainance' Order By Device_ID ;";
            SqlConnection sqlConnection = new SqlConnection(ConnectionClass.ConnectingString);
            try
            {
                sqlConnection.Open();
                SqlCommand FreesqlCommand = new SqlCommand(Free_Query, sqlConnection);
                SqlDataReader Freereader = FreesqlCommand.ExecuteReader();
                while (Freereader.Read())
                {
                    Device_Record.Rows.Add(Freereader["Device_ID"], Freereader["OS_TYPE"], Freereader["AVAILABLE_STATUS"], "Occupy", "Add");
                }
                Freereader.Close();
                sqlConnection.Close();
                sqlConnection.Open();
                SqlCommand OccupysqlCommand = new SqlCommand(OccupyQuery, sqlConnection);
                SqlDataReader Occupyreader = OccupysqlCommand.ExecuteReader();
                while (Occupyreader.Read())
                {
                    Device_Record.Rows.Add(Occupyreader["Device_ID"], Occupyreader["OS_TYPE"], Occupyreader["AVAILABLE_STATUS"], "Free" , "Add");
                }
                Occupyreader.Close();   
                sqlConnection.Close();
                sqlConnection.Open();
                SqlCommand UnderMAintainancesqlCommand = new SqlCommand(UnderMAintainanceQuery, sqlConnection);
                SqlDataReader UnderMAintainancereader = UnderMAintainancesqlCommand.ExecuteReader();
                while (UnderMAintainancereader.Read())
                {
                    Device_Record.Rows.Add(UnderMAintainancereader["Device_ID"], UnderMAintainancereader["OS_TYPE"], UnderMAintainancereader["AVAILABLE_STATUS"], "Un_Useable", "Remove");
                }
                UnderMAintainancereader.Close();
                sqlConnection.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void set_State(int index)
        {
            if (Device_Record.Rows[index].Cells[3].Value.ToString() == "Free")
            {
                String QUERY = "Update DEVICES SET AVAILABLE_STATUS = 'Free' Where DEVICE_ID = '" + Device_Record.Rows[index].Cells[0].Value.ToString() + "'";

                try
                {
                    SqlConnection Conn = new SqlConnection(ConnectionClass.ConnectingString);
                    Conn.Open();
                    SqlCommand Cmd = new SqlCommand(QUERY, Conn);
                    Cmd.ExecuteNonQuery();
                    Conn.Close();

                }

                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);

                }
                Device_Record.Rows.Clear();
                Device_Timer.Enabled = true;
            }
            else if (Device_Record.Rows[index].Cells[3].Value.ToString() == "Occupy")
            {
                string QUERY = "Update DEVICES SET AVAILABLE_STATUS = 'Occupied' Where DEVICE_ID = '" + Device_Record.Rows[index].Cells[0].Value.ToString() + "'";

                try
                {
                    SqlConnection Conn = new SqlConnection(ConnectionClass.ConnectingString);
                    Conn.Open();
                    SqlCommand Cmd = new SqlCommand(QUERY, Conn);
                    Cmd.ExecuteNonQuery();
                    Conn.Close();

                }

                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);

                }
                Device_Record.Rows.Clear();
                Device_Timer.Enabled = true;
            }


        }

        private void Set_Under_Maintainance(int index)
        {
            //Checking the Under maintainance
            if (Device_Record.Rows[index].Cells[4].Value.ToString() == "Add")
            {
                String QUERY = "Update DEVICES SET AVAILABLE_STATUS = 'Under Maintainance' Where DEVICE_ID = '" + Device_Record.Rows[index].Cells[0].Value.ToString() + "'";

                try
                {
                    SqlConnection Conn = new SqlConnection(ConnectionClass.ConnectingString);
                    Conn.Open();
                    SqlCommand Cmd = new SqlCommand(QUERY, Conn);
                    Cmd.ExecuteNonQuery();
                    Conn.Close();

                }

                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);

                }
                Device_Record.Rows.Clear();
                Device_Timer.Enabled = true;
            }
            else if (Device_Record.Rows[index].Cells[4].Value.ToString() == "Remove")
            {
                string QUERY = "Update DEVICES SET AVAILABLE_STATUS = 'Free' Where DEVICE_ID = '" + Device_Record.Rows[index].Cells[0].Value.ToString() + " '";

                try
                {
                    SqlConnection Conn = new SqlConnection(ConnectionClass.ConnectingString);
                    Conn.Open();
                    SqlCommand Cmd = new SqlCommand(QUERY, Conn);
                    Cmd.ExecuteNonQuery();
                    Conn.Close();

                }

                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);

                }
                Device_Record.Rows.Clear();
                Device_Timer.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FillGridview();
            Device_Timer.Enabled = false;
        }

        private void Device_Record_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void btn_FreeAll_Click(object sender, EventArgs e)
        {
            String QUERY = "Update DEVICES SET AVAILABLE_STATUS = 'Free' Where AVAILABLE_STATUS <> 'Under Maintainance';";

            try
            {
                SqlConnection Conn = new SqlConnection(ConnectionClass.ConnectingString);
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(QUERY, Conn);
                Cmd.ExecuteNonQuery();
                Conn.Close();

            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

            }

            Device_Record.Rows.Clear();
            Device_Timer.Enabled = true;
        }
    }
}
