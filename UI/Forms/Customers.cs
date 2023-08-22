using MaterialSkin2Framework.Controls;
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
using System.Data.Entity;

namespace BlueLight_Management_System.UI.Forms
{
    public partial class Customers : Form
    {
        //--
        private int currentPage = 1;
        //--
        public Customers()
        {
            InitializeComponent();
        }

        //Disable All TextBoxes
        public void DisableTextBoxes()
        {
            textboxFirstName.Enabled = false;
            textBoxLastName.Enabled = false;
            textBoxTelephone.Enabled = false;
        }

        //--
        //public void SearchAndShowCustomersWithPagination(int pageNumber, int pageSize)
        //{
        //    var context = new DataContext();

        //    var query =
        //        from customer in context.Customers
        //        join invoice in context.Invoices
        //            on customer.Id equals invoice.CustomerId
        //            into result
        //        select new
        //        {
        //            customerId = customer.Id,
        //            customerName = customer.FullName,
        //            customerPhone = customer.Phone,
        //            numberOfServices = result.Count(),
        //            //amountDue = result.Sum(i => i.Amount), // todo: 
        //            registeredAt = customer.RegisteredAt,
        //            UpdatedAt = customer.UpdatedAt
        //        };

        //    if (!string.IsNullOrEmpty(textBoxSearch.Text))
        //    {
        //        query = query.Where(c =>
        //            c.customerName.ToLower().Contains(textBoxSearch.Text.ToLower().Trim()) ||
        //            c.customerPhone.ToLower().Contains(textBoxSearch.Text.ToLower().Trim())
        //        );
        //    }

        //    var customerWithInvoices = query
        //        .Distinct()
        //        .OrderByDescending(c => c.customerId)
        //        .Skip((pageNumber - 1) * pageSize)
        //        .Take(pageSize)
        //        .ToList();

        //    materialDataTableCustomers.DataSource = customerWithInvoices;
        //}

        //--
        public void SearchCustomers()
        {
            var context = new DataContext();

            var filteredCustomers = new List<Customer>();
            foreach (var customer in context.Customers.ToList())
            {


                if (customer.FullName.ToLower().Contains(textBoxSearch.Text.ToLower().Trim()) || customer.Phone.ToLower().Contains(textBoxSearch.Text.ToLower().Trim()))
                {
                    filteredCustomers.Add(customer);


                }
            }
            var customerWithInvoices =
                (from customer in filteredCustomers

                 join invoice in context.Invoices
                   on customer.Id equals invoice.CustomerId
                   into result

                 select
                 (new
                 {

                     customerId = customer.Id,
                     customerName = customer.FullName,
                     customerPhone = customer.Phone,
                     //invoiceId = invoice.Id,
                     numberOfServices = context.Invoices.Where(i => i.CustomerId == customer.Id).Count(),
                     amountDue = context.Invoices.Where(i => i.CustomerId == customer.Id).Count(),
                      registeredAt = customer.RegisteredAt,
                     UpdatedAt = customer.UpdatedAt
                 })).Distinct().ToList();


            materialDataTableCustomers.DataSource = customerWithInvoices;

        }
        // Disable all textboxes
        public void DisableTexboxes()
        {
            textboxFirstName.Enabled = false;
            textBoxLastName.Enabled = false;
            textBoxTelephone.Enabled = false;
        }

       

        // Enable all textboxes
        public void EnableTextboxes()
        {
            textboxFirstName.Enabled = true;
            textBoxLastName.Enabled = true;
            textBoxTelephone.Enabled = true;
        }
        // Check empty textboxes
        private bool CheckEmptyTextBoxes()
        {
            var isEmptyFieldExist = false;
            List<bool> emptyCheckLists = new List<bool>();
            //01. check firstname
            if (string.IsNullOrEmpty(textboxFirstName.Text))
            {
                errorProvider1.SetError(textboxFirstName, "Enter The First Name");
                emptyCheckLists.Add(true);

            }
            else
            {
                errorProvider1.SetError(textboxFirstName, string.Empty);
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
            if (string.IsNullOrEmpty(textBoxTelephone.Text))
            {
                errorProvider1.SetError(textBoxTelephone, "Enter the Phone");
                emptyCheckLists.Add(true);
            }
            else
            {
                errorProvider1.SetError(textBoxTelephone, string.Empty);
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
        public void ShowAllCustomers()
        {
            var context = new DataContext();
            var customerWithInvoices =
                (from customer in context.Customers

                 join invoice in context.Invoices
                   on customer.Id equals invoice.CustomerId
                   into result

                 select
                 (new
                 {

                     customerId = customer.Id,
                     customerName = customer.FullName,
                     customerPhone = customer.Phone,

                     //invoiceId = invoice.Id,
                     numberOfServices = context.Invoices.Where(i => i.CustomerId == customer.Id).Count(),
                     amountDue = context.Invoices.Where(i => i.CustomerId == customer.Id).Count(),
                     registeredAt = customer.RegisteredAt,
                     UpdatedAt = customer.UpdatedAt

                 })).Distinct().OrderByDescending(c => c.customerId).ToList();


            materialDataTableCustomers.DataSource = customerWithInvoices;



        }

        //<---

        //public void ShowCustomersPage(int pageNumber)
        //{
        //    var context = new DataContext();
        //    int itemsPerPage = 500; // Set the number of items per page

        //    var customerWithInvoices = (
        //        from customer in context.Customers
        //        join invoice in context.Invoices on customer.Id equals invoice.CustomerId into result
        //        select new
        //        {
        //            customerId = customer.Id,
        //            customerName = customer.FullName,
        //            customerPhone = customer.Phone,
        //            numberOfServices = context.Invoices.Count(i => i.CustomerId == customer.Id),
        //            amountDue = context.Invoices.Count(i => i.CustomerId == customer.Id),
        //            registeredAt = customer.RegisteredAt,
        //            UpdatedAt = customer.UpdatedAt
        //        }
        //    ).Distinct().OrderByDescending(c => c.customerId)
        //     .Skip((pageNumber - 1) * itemsPerPage)
        //     .Take(itemsPerPage)
        //     .ToList();

        //    // materialDataTableCustomers.DataSource = new BindingList<object>(customerWithInvoices);
        //    materialDataTableCustomers.DataSource = customerWithInvoices;
        //    Application.EnableVisualStyles();
        //}

        //-->

        public void ClearAllFields()
        {
            textboxFirstName.Text = textBoxLastName.Text = textBoxTelephone.Text = textBoxCustomerId.Text = "";
        }


   
       

        private void Customers_Load(object sender, EventArgs e)
        {
            materialDataTableCustomers.ShowVerticalScroll = false;
            //ShowAllCustomers();
            ShowAllCustomers();
            DisableTexboxes();
            materialDataTableCustomers.RowsDefaultCellStyle.BackColor = Color.White;
            materialDataTableCustomers.DefaultCellStyle.SelectionForeColor = Color.Black;
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
                FirstName = textboxFirstName.Text,
                LastName = textBoxLastName.Text,
                FullName = $"{textboxFirstName.Text} {textBoxLastName.Text}",
                Phone = textBoxTelephone.Text,
                RegisteredAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };

            if (MessageBox.Show("Ma hubtaa in aad save gareyso.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                context.Customers.Add(customer);
                context.SaveChanges();
                textboxFirstName.Text = textBoxLastName.Text = textBoxTelephone.Text = "";

                ShowAllCustomers();
                buttonSave.Enabled = false;
                DisableTexboxes();

            }
            else
            {
                buttonSave.Enabled = false;
                DisableTexboxes();

            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchCustomers();
            //ShowAllCustomers();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            CheckEmptyTextBoxes();
            if (CheckEmptyTextBoxes())
            {
                return;
            }

            var customerId = int.Parse(textBoxCustomerId.Text);
            var context = new DataContext();
            var targetCustomer = context.Customers.SingleOrDefault(c => c.Id ==customerId );
            if (targetCustomer != null)
            {
                if (MessageBox.Show("Are you sure to update?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    targetCustomer.FirstName = textboxFirstName.Text;
                    targetCustomer.LastName = textBoxLastName.Text;
                    targetCustomer.Phone = textBoxTelephone.Text;
                    targetCustomer.FullName = "";
                    targetCustomer.UpdatedAt = DateTime.Now;

                    context.SaveChanges();
                    ShowAllCustomers();
                    ClearAllFields();
                    buttonUpdate.Enabled = false;
                    DisableTexboxes();
                    buttonAddCustomer.Enabled = true;
                }
                else
                {
                    buttonUpdate.Enabled = false;
                    buttonAddCustomer.Enabled = true;
                    ClearAllFields();
                    DisableTexboxes();
                }

            }
        }

        private void materialDataTableCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var customerId = Convert.ToInt32(materialDataTableCustomers.CurrentRow.Cells["CustomerId"].Value);
            //delete user
            if (materialDataTableCustomers.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                if (MessageBox.Show("Are you sure to Delete", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var context = new DataContext();
                    var targetCustomer = context.Customers.SingleOrDefault(c => c.Id == customerId);
                    if (targetCustomer != null)
                    {
                        context.Customers.Remove(targetCustomer);
                        context.SaveChanges();
                        ShowAllCustomers();

                    }
                    return;
                };

            }



            // update 
            if (materialDataTableCustomers.Columns[e.ColumnIndex].Name == "EditButton")
            {

                var context = new DataContext();
                var targetCustomer = context.Customers.SingleOrDefault(c => c.Id == customerId);
                if (targetCustomer != null)
                {

                    //show data in the boxes
                    buttonUpdate.Enabled = true;
                    buttonAddCustomer.Enabled = false;
                    EnableTextboxes();
                    textBoxCustomerId.Text = targetCustomer.Id.ToString();
                    textboxFirstName.Text = targetCustomer.FirstName;
                    textBoxLastName.Text = targetCustomer.LastName;
                    textBoxTelephone.Text = targetCustomer.Phone;
                    label2.Text = "Edit Customer";



                }
                return;


            }
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            buttonSave.Enabled = true;
            buttonUpdate.Enabled = false;
            EnableTextboxes();
        }

       

        
    }
}
