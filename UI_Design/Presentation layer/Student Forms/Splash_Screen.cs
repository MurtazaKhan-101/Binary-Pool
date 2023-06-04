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
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(10);
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Login form = new Login();
                form.Show();
                this.Hide();
            }
        }

        private void Splash_Screen_Load(object sender, EventArgs e)
        {

        }
    }
}
