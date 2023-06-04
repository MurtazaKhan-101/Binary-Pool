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
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void Admin_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_adminLogin_Click(object sender, EventArgs e)
        {
            string id = txtID_admin.Text;
            string pass = txtPass_admin.Text;

            string conn = "Data Source=DESKTOP-O5MQAET;Initial Catalog=Project_Database;Integrated Security=True";

            string query = "SELECT COUNT(*) FROM _ADMIN WHERE ADMIN_ID = '" + id + "' AND ADMIN_PASSWORD = '" + pass + "';";

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

            /*this.Hide();
            Add_Student A1 = new Add_Student(id);*/
        }

        private void Admin_Password_Click(object sender, EventArgs e)
        {

        }

        private void txtID_admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_showadminpass_Click(object sender, EventArgs e)
        {

        }

        private void Admin_ID_Click(object sender, EventArgs e)
        {

        }
    }
}
