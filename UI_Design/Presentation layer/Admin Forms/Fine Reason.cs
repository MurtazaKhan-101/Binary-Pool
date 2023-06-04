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
    public partial class Fine_Reason : Form
    {
        private string Admin_ID, Std_ID;
        public Fine_Reason()
        {
            InitializeComponent();
        }
        public Fine_Reason(string Admin_ID , string Std_ID)
        {
            InitializeComponent();
            this.Admin_ID = Admin_ID;
            this.Std_ID = Std_ID;
        }

        private void Fine_Reason_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string ConnectingString = ConnectionClass.ConnectingString;
            string query = "INSERT INTO FINE_GENERATE VALUES( NEXT VALUE FOR FINE_ID_SEAQUENCE, '" + txt_Amount.Text + "' , '" + DateTime.Now.ToShortDateString() + "' , '" + DatePicker.Value.ToShortDateString() + "' , '" + Std_ID + "' , '" + Admin_ID + "' , '"+txt_Reason.Text+"' , '"+txt_Description+"');";
 
            try
            {
                SqlConnection Conn = new SqlConnection(ConnectingString);
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(query, Conn);
                Cmd.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            this.Hide();
            MainUI Ui = new MainUI(Admin_ID);
            MessageBox.Show("The Student ID you have entered is Fined successfully");
            Ui.openChildFromOutside(new Fine_Section(Admin_ID));
        }

        private void txt_Description_MouseEnter(object sender, EventArgs e)
        {
            txt_Description.Text = null;
        }

        private void txt_Description_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
