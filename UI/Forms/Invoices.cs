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

namespace BlueLight_Management_System.UI.Forms
{
    public partial class Invoices : Form
    {
        public Invoices()
        {
            InitializeComponent();
        }
        // method to refresh

        public void refreshDataEnventHandler1(object sender, Add_New_Invoice.AddNewEventArgs args)
        {
            ShowAllInvoices();
        }
        public void refreshDataEnventHandler2(object sender, Edit_Invoice.UpdateEventArgs args)

        {
            ShowAllInvoices();

        }

        // show all invoices
        public void ShowAllInvoices()
        {
            var context = new DataContext();
            var services = (
                from invoice in context.Invoices
                join customer in context.Customers on invoice.CustomerId equals customer.Id
                select (
                    new
                    {
                        customerId = customer.Id,
                        customerName = customer.FullName,
                        customerPhone = customer.Phone,
                        issuedDate = invoice.IssuedDate,
                        duedate = invoice.DueDate,
                        total = invoice.GrandTotal, 
                        discount = invoice.Discount,
                        paidAmount =   invoice.PaidAmount,
                        baaqi = invoice.Baaqi,
                        invoiceId = invoice.Id,                    
                          status = invoice.Baaqi<=0?"Completed": "In Progress"

                    }
                )
            ).Distinct().OrderByDescending(i => i.issuedDate).ToList();
            
            materialDataTableInvoicesList.DataSource = services;

        }
        // search method
        public void SearchInvoices(string searchPhrase)
        {


            var context = new DataContext();
            var searchedInvoices = (
                from invoice in context.Invoices
                join customer in context.Customers.Where(c => c.Phone.Contains(searchPhrase)||c.FullName.Contains(searchPhrase)) on invoice.CustomerId equals customer.Id
                select (
                    new
                    {
                        customerId = customer.Id,
                        customerName = customer.FullName,
                        customerPhone = customer.Phone,
                        issuedDate = invoice.IssuedDate,
                        duedate = invoice.DueDate,                        
                       total = invoice.GrandTotal,
                       discount = invoice.Discount, 
                        paidAmount = invoice.PaidAmount,                        
                        baaqi = invoice.Baaqi,
                        invoiceId = invoice.Id,
                        status = invoice.Baaqi <= 0 ? "Completed" : "In Progress",
                    }
                )
            ).OrderByDescending(i => i.issuedDate).ToList();
           

            if (comboBoxSearchByStatus.SelectedIndex>=0)
            {
                searchedInvoices = searchedInvoices.Where(i => i.status == comboBoxSearchByStatus.Text).ToList();
            }
            materialDataTableInvoicesList.DataSource = searchedInvoices;


        }


        private void Invoices_Load(object sender, EventArgs e)
        {

            ShowAllInvoices();
            if (comboBoxSearchByStatus.SelectedIndex < 0)
            {
                comboBoxSearchByStatus.Text = "Filter by status";
            }

            materialDataTableInvoicesList.RowsDefaultCellStyle.BackColor = Color.White;
            materialDataTableInvoicesList.DefaultCellStyle.SelectionForeColor = Color.Black;

            materialDataTableInvoicesList.ClearSelection();
            
        }

        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            SearchInvoices(textBoxSearch.Text.Trim());

        }

        private void comboBoxSearchByStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            SearchInvoices(comboBoxSearchByStatus.Text.Trim().ToLower());
        }

       

        private void materialDataTableInvoicesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Delete Invoice and invoice-items
            var invoiceId = Convert.ToInt32(materialDataTableInvoicesList.CurrentRow.Cells["InvoiceId"].Value);
            if (materialDataTableInvoicesList.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                // User message
                if (MessageBox.Show("Are you sure to Delete this Invoice", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var context = new DataContext();
                    var targetInvoiceItems = context.InvoiceItems.Where(i => i.InvoiceId == invoiceId).ToList();
                    if (targetInvoiceItems != null)
                    {
                        context.InvoiceItems.RemoveRange(targetInvoiceItems);
                        context.SaveChanges();
                    }


                    var targetInvoice = context.Invoices.SingleOrDefault(i => i.Id == invoiceId);
                    if (targetInvoice != null)
                    {
                        context.Invoices.Remove(targetInvoice);
                        context.SaveChanges();

                        ShowAllInvoices();

                    }
                    return;
                };

            }
            else if (materialDataTableInvoicesList.Columns[e.ColumnIndex].Name == "EditButton")
            {
                var context = new DataContext();
                var targetInvoice = context.Invoices.SingleOrDefault(i => i.Id == invoiceId);
                if (targetInvoice != null)
                {
                    Edit_Invoice edit_Invoice = new Edit_Invoice(this);
                    edit_Invoice.targetInvoiceId = targetInvoice.Id;
                    edit_Invoice.UpdateEventHandler += refreshDataEnventHandler2;
                    edit_Invoice.ShowDialog();

                }
            }
        }

        private void buttonAddInvoice_Click_1(object sender, EventArgs e)
        {
            Add_New_Invoice invoice_Management = new Add_New_Invoice(this);
            invoice_Management.AddNewEventHandler += refreshDataEnventHandler1;
            invoice_Management.ShowDialog();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchInvoices(textBoxSearch.Text.Trim());
        }

        private void comboBoxSearchByStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchInvoices(textBoxSearch.Text);

        }

        private void materialDataTableInvoicesList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Make sure we're dealing with the correct column and a valid row
            if (e.ColumnIndex == materialDataTableInvoicesList.Columns["Baaqi"].Index && e.RowIndex >= 0)
            {
                // Get the cell value as a string
                string cellValue = materialDataTableInvoicesList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

                // Check if the cell value is not "0"
                if (cellValue != "0.00")
                {
                    // Set the cell's background color to your desired color (e.g., yellow)
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);

                }
                else
                {
                    // If the cell value is "0" or empty, reset the cell's background color to the default
                    e.CellStyle.ForeColor = materialDataTableInvoicesList.DefaultCellStyle.ForeColor;
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Regular);

                }

            }


            if (e.ColumnIndex == materialDataTableInvoicesList.Columns["Status"].Index && e.RowIndex >= 0)
            {
                // Get the cell value as a string
                string cellValue = materialDataTableInvoicesList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

                // Check if the cell value is not "0"
                if (cellValue == "Completed")
                {
                    // Set the cell's background color to your desired color (e.g., yellow)
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font= new Font(e.CellStyle.Font, FontStyle.Bold);
                }
                else
                {
                    // If the cell value is "0" or empty, reset the cell's background color to the default
                    e.CellStyle.ForeColor = materialDataTableInvoicesList.DefaultCellStyle.ForeColor;
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Regular);
                }
            }
        }

        private void Invoices_Shown(object sender, EventArgs e)
        {
            materialDataTableInvoicesList.ClearSelection();
        }

        private void materialDataTableInvoicesList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }

    

       
 }

