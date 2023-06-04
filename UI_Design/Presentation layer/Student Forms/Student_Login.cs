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
    public partial class Student_Login : Form
    {
        public Student_Login()
        {
            InitializeComponent();
        }

        private void btn_stdLogin_Click(object sender, EventArgs e)
        {
            string id = txtID_std.Text;
            string pass = txtPass_std.Text;

            string conn = "Data Source=DESKTOP-O5MQAET;Initial Catalog=Project_Database;Integrated Security=True";

            string query = "SELECT COUNT(*) FROM _USER WHERE STUDENT_ID = '" + id + "' AND LOGIN_PASSWORD = '" + pass + "';";

            try
            {
                SqlConnection sqlconn = new SqlConnection(conn);
                SqlDataAdapter cmd = new SqlDataAdapter(query, sqlconn);

                DataTable dt = new DataTable();
                cmd.Fill(dt);
                if ((dt.Rows[0][0].ToString() == "1"))
                {
                    MessageBox.Show("Zindabaad");
                }
                else
                {
                    MessageBox.Show("Murdabaad");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An Error has occured: " + Ex.Message);
            }
        }
    }
}
