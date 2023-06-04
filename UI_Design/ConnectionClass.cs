using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    internal class ConnectionClass
    {
        private static string connection = "Data Source=DESKTOP-O5MQAET;Initial Catalog = Project_Database; Integrated Security = True;Max Pool Size=200;";
        /*private static string connection = "Data Source=dbserver.ntu.edu.pk;Initial Catalog=Binary_Pool;Persist Security Info=True;User ID=ntu; Password = ntu; Max Pool Size=200;";*/
        private string query;

        public static string ConnectingString
        {
            get { return connection; }
        }

        
        public void MakeConnection()
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(connection);
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
