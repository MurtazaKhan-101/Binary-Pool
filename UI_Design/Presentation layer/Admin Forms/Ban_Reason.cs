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
    public partial class Ban_Reason : Form
    {
        private string Admin_ID;
        private string STD_ID;
        private string STD_NAME;


        public Ban_Reason()
        {
            InitializeComponent();
        }

        public Ban_Reason(string Admin_ID , string Student_ID , string Std_Name)
        {
            InitializeComponent();
            this.Admin_ID = Admin_ID;
            this.STD_ID = Student_ID;
            this.STD_NAME = Std_Name;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            string Reason = null;
            if(CB_overtime.Checked) {
                Reason = "Extra Time Is Consumed";
            }

            string ConnectingString = ConnectionClass.ConnectingString;
            string query = "INSERT INTO BAN VALUES('"+ Admin_ID + "' , '"+STD_ID+"' , '"+ STD_NAME + "' , '"+txt_Duration.Text+"' , '"+Reason+"' , '"+txt_Description.Text+"')";
            
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
            MessageBox.Show("The Student ID you have entered is banned successfully");
            Ui.openChildFromOutside(new Ban_Student(Admin_ID));
        }

        private void Ban_Reason_Load(object sender, EventArgs e)
        {

        }

        private void txt_Description_Click(object sender, EventArgs e)
        {
            txt_Description.Text = null;
        }
    }
}
