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
    public partial class Ban_Student : Form
    {
        private string Admin_ID;
        public Ban_Student()
        {
            InitializeComponent();
        }
        public Ban_Student(string Admin_ID)
        {
            InitializeComponent();
            this.Admin_ID = Admin_ID;
            Ban_Timer.Start();
            
        }
        private void Ban_Student_Load(object sender, EventArgs e)
        {
            fill_Gridview();
            Ban_Timer.Enabled = false;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row_Index = e.RowIndex;
            if (dataGridView1.Rows[Row_Index].Cells[3].Value.ToString() == "BAN")
            {
                string ID = dataGridView1.Rows[Row_Index].Cells[0].Value.ToString();
                string Name = dataGridView1.Rows[Row_Index].Cells[1].Value.ToString();

                Ban_Reason reason = new Ban_Reason(Admin_ID, ID, Name);
                dataGridView1.Rows.Clear();
                fill_Gridview();
                openChildForm(reason);
            }else if (dataGridView1.Rows[Row_Index].Cells[3].Value.ToString() == "UNBAN")
            {
                string query = "DELETE FROM BAN WHERE STUDENT_ID = '" + dataGridView1.Rows[Row_Index].Cells[0].Value.ToString() +"';";
                SqlConnection sqlConnection= new SqlConnection(ConnectionClass.ConnectingString);
                try
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand(query , sqlConnection);
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }
            }
            dataGridView1.Rows.Clear();
            fill_Gridview();
            Ban_Timer.Enabled = true;
        }

        private void lbl_message_Click(object sender, EventArgs e)
        {

        }

        private void fill_Gridview()
        {
            string ConnectingString = ConnectionClass.ConnectingString;
            string BANquery = "SELECT _USER.STUDENT_ID ,_USER.STUDENT_NAME  ,  LOGIN_PASSWORD FROM _USER INNER JOIN BAN ON _USER.STUDENT_ID = BAN.STUDENT_ID ";
            string UNBANquery = "SELECT * FROM _USER EXCEPT SELECT _USER.STUDENT_ID ,_USER.STUDENT_NAME  ,  LOGIN_PASSWORD , _USER.ADMIN_ID FROM _USER INNER JOIN BAN ON _USER.STUDENT_ID = BAN.STUDENT_ID  ";
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectingString);
                sqlConnection.Open();
                SqlCommand BANCmd = new SqlCommand(BANquery, sqlConnection);
                SqlDataReader BANreader = BANCmd.ExecuteReader();
                while (BANreader.Read())
                {
                    dataGridView1.Rows.Add(BANreader["Student_ID"], BANreader["Student_Name"], BANreader["Login_PAssword"], "UN_Ban");
                }
                BANreader.Close();
                sqlConnection.Close();
                sqlConnection.Open();
                SqlCommand UNBANCmd = new SqlCommand(UNBANquery, sqlConnection);
                SqlDataReader UNBANreader = UNBANCmd.ExecuteReader();

                while (UNBANreader.Read())
                {
                    dataGridView1.Rows.Add(UNBANreader["Student_ID"], UNBANreader["Student_Name"], UNBANreader["Login_PAssword"], "BAN");
                }
                UNBANreader.Close();
                sqlConnection.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void Ban_Timer_Tick(object sender, EventArgs e)
        {
            fill_Gridview();
            Ban_Timer.Enabled = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            fill_Gridview();
            Gridview_Timer.Enabled = true;
        }

        private void child_pannel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
