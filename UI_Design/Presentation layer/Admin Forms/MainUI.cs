using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    public partial class MainUI : Form
    {
        private string Admin_ID;

        public MainUI()
        {
            InitializeComponent();
            customizeDesign();
        }

        public MainUI(string admin_ID)
        {
            InitializeComponent();
            customizeDesign();
            Admin_ID = admin_ID;
            
        }

        public void openChildFromOutside(Form F)
        {
            if (panelAdminSubMenu.Visible == false)
            {
                panelAdminSubMenu.Visible = true;
                openChildForm(F);
            }
        }

        private void customizeDesign()
        {
            panelAdminSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelAdminSubMenu.Visible == true)
            {
                panelAdminSubMenu.Visible = false;
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

        #region AdminSubmenu
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAdminSubMenu);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Add_Student(Admin_ID));
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Ban_Student(Admin_ID));
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new Fine_Section(Admin_ID));
            hideSubMenu();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            openChildForm( new Record(Admin_ID));
            hideSubMenu();

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            openChildForm(new Manage_Devices());
            hideSubMenu();
        }
        #endregion


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
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

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void admin_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l1= new Login();
            l1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
