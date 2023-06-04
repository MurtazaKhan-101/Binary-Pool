using System;
using System.Collections;
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
    public partial class MainUI2 : Form
    {
        string StdID;
        string Initial_Time = DateTime.Now.ToLocalTime().ToString();


        public MainUI2()
        {
            InitializeComponent();
            customizeDesign();
            
        }

        public MainUI2(string StdID)
        {
            InitializeComponent();
            customizeDesign();
            this.StdID = StdID;

        }

        private void customizeDesign()
        {
            panelStudentSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelStudentSubMenu.Visible == true)
            {
                panelStudentSubMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #region StudentSubmenu
        private void btnStudent_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStudentSubMenu);
            

        }
        private void btnSession_Click(object sender, EventArgs e)
        {
            openChildForm(new Session(StdID));
            hideSubMenu();
            

        }

        private void btn_Fine_Click(object sender, EventArgs e)
        {
            string query = "SELECT Count(*) FROM FINE_GENERATE WHERE STUDENT_ID = '" + StdID + "'";
            string ConnectingString = ConnectionClass.ConnectingString;
            try
            {
                SqlConnection Conn = new SqlConnection(ConnectingString);
                Conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, Conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count.ToString() == "1")
                {
                    openChildForm(new Fine_Slip(StdID));
                    hideSubMenu();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            openChildForm(new Profile(StdID));
            hideSubMenu();
        }
        DateTime T2 = DateTime.Now.AddMinutes(2);
        private void AppTimer_Tick(object sender, EventArgs e)
        {

            string finalTime = (TimeSpan.FromMinutes(T2.Minute) - TimeSpan.FromMinutes(DateTime.Now.Minute) - TimeSpan.FromSeconds(DateTime.Now.Second)).ToString();
            if (finalTime == "00:00:00")
            {
                this.Hide();
                Login log = new Login();
                log.ShowDialog();
       
            }

            SqlConnection sql = new SqlConnection(ConnectionClass.ConnectingString);
            try
            {
                string query = "SELECT COUNT(*) FROM Devices Where AVAILABLE_STATUS = 'Free All'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sql);
                sql.Open();
                DataTable data = new DataTable();
                sqlDataAdapter.Fill(data);
                string result = data.Rows[0][0].ToString();
                int no = int.Parse(result);
                if(no > 0)
                {
                    this.Hide();
                    Login login = new Login();
                    login.ShowDialog();
                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                
            }

        }
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Std_History(StdID));
            hideSubMenu();
        }
        private void btnLogout_Click_2(object sender, EventArgs e)
        {

        }
        #endregion


        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void std_logout_Click(object sender, EventArgs e)
        {
        }

        private void std_logout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login l2 = new Login();
            l2.Show();
        }

        private void std_exit_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notify_dues_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }

