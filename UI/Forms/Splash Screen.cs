using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BlueLight_Management_System.UI.Forms
{
    public partial class Splash_Screen : Form
    {

        public Splash_Screen()
        {
            InitializeComponent();
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {

            
            timer1.Enabled = true;
            custom_Progress_Bar1.ForeColor = Color.FromArgb(18, 113, 255); 
            custom_Progress_Bar1.Increment(2);
            if (custom_Progress_Bar1.Value == 100)
            {
                timer1.Enabled = false;

                Login login = new Login();
              
                login.Show();
                this.Hide();
            }
        }

        private void Splash_Screen_Load(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();

            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            labelVersion.Text = string.Format("Version: {0}", version);
            
        }

        private void custom_Progress_Bar1_Click(object sender, EventArgs e)
        {

        }
    }
}
