//using Microsoft.IdentityModel.Tokens;
using BlueLight_Management_System.Data;
using BlueLight_Management_System.Models;
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
    public partial class Add_New_Customer : Form
    {
        public Add_New_Customer(Add_New_Invoice add_New_Invoice)
        {
            InitializeComponent();
        }


        public delegate void AddNewDelegate(object sender, AddNewEventArgs args);
        public event AddNewDelegate AddNewEventHandler;

        public class AddNewEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void insert()
        {
            AddNewEventArgs args = new AddNewEventArgs();
            AddNewEventHandler.Invoke(this, args);
        }


        //--
        private void materialCard1_Paint(object sender, PaintEventArgs e) { }

        private bool CheckEmptyTextBoxes()
        {
            var isEmptyFieldExist = false;
            List<bool> emptyCheckLists = new List<bool>();
            //01. check firstname
            if (string.IsNullOrEmpty(textBoxFirstName.Text))
            {
                errorProvider1.SetError(textBoxFirstName, "Enter The First Name");
                emptyCheckLists.Add(true);

            }
            else
            {
                errorProvider1.SetError(textBoxFirstName, string.Empty);
                emptyCheckLists.Add(false);
            }
            //02. check lastname
            if (string.IsNullOrEmpty(textBoxLastName.Text))
            {
                errorProvider1.SetError(textBoxLastName, "Enter the Last Name");
                emptyCheckLists.Add(true);
            }
            else
            {
                errorProvider1.SetError(textBoxLastName, string.Empty);
                emptyCheckLists.Add(false);

            }

            // 03. Check Telephone
            if (string.IsNullOrEmpty(textBoxTelephoneNo.Text))
            {
                errorProvider1.SetError(textBoxTelephoneNo, "Enter the Phone");
                emptyCheckLists.Add(true);
            }
            else
            {
                errorProvider1.SetError(textBoxTelephoneNo, string.Empty);
                emptyCheckLists.Add(false);

            }
            foreach (var item in emptyCheckLists)
            {
                if (item is true)
                {
                    isEmptyFieldExist = true;
                    break;
                }
                else
                {
                    isEmptyFieldExist = false;
                }
            }
            return isEmptyFieldExist;

        }
        
        private void AddNewClientForm_Load(object sender, EventArgs e) { }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void buttonSave_Click(object sender, EventArgs e)
        {
            CheckEmptyTextBoxes();
            if (CheckEmptyTextBoxes())
            {
                return;
            }


            var context = new DataContext();
            var customer = new Customer()
            {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                FullName = $"{textBoxFirstName.Text} {textBoxLastName.Text}",
                Phone = textBoxTelephoneNo.Text,
                RegisteredAt = DateTime.Now,
                UpdatedAt   = DateTime.Now,
            };

            context.Customers.Add(customer);
            context.SaveChanges();
           
            Add_New_Invoice add_New_Invoice = new Add_New_Invoice();
           // add_New_Invoice.customer = customer;


            insert();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Text = textBoxLastName.Text = textBoxTelephoneNo.Text = "";
        }

        private void Add_New_Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
