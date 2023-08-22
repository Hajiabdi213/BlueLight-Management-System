using BlueLight_Management_System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueLight_Management_System.UI.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            var context = new DataContext();
            labelUsersNo.Text = context.Customers.ToList().Count.ToString();
            labelInvoicesNo.Text=context.Invoices.ToList().Count.ToString();
            labelCompletedNo.Text=context.Invoices.Where(i=>i.Baaqi<=0).ToList().Count.ToString();
            labelProcessingNo.Text= context.Invoices.Where(i => i.Baaqi>0).ToList().Count.ToString();
        }
    }
}
