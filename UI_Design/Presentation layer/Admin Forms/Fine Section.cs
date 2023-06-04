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
    public partial class Fine_Section : Form
    {
        private string Admin_ID;
        public Fine_Section()
        {
            InitializeComponent();
        }
        public Fine_Section(string Admin_id)
        {
            InitializeComponent();
            Admin_ID = Admin_id;
        }

        private void Fine_Section_Load(object sender, EventArgs e)
        {
            string ConnectingString = ConnectionClass.ConnectingString;
            string query = "Select * From _User";
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectingString);
                sqlConnection.Open();
                SqlCommand Cmd = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["Student_ID"], reader["Student_Name"], reader["Login_PAssword"], "Fine");
                }
                reader.Close();
                sqlConnection.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
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
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row_Index = e.RowIndex;
            string ID = dataGridView1.Rows[Row_Index].Cells[0].Value.ToString();
            string Name = dataGridView1.Rows[Row_Index].Cells[1].Value.ToString();
            Fine_Reason reason = new Fine_Reason(Admin_ID, ID);
            openChildForm(reason);
        }

        private void lbl_message_Click(object sender, EventArgs e)
        {

        }
    }
}
