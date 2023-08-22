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
    public partial class Payments_Form : Form
    {
        DataContext context = new DataContext();
        public Payments_Form()
        {
            InitializeComponent();
        }

        public void ShowAllPaymentInformation()
        {
            var paymentInformation = (from payment in context.Payments
                                      join invoice in context.Invoices
                                      on payment.InvoiceId equals invoice.Id
                                      join customer in context.Customers
                                      on invoice.CustomerId equals customer.Id
                                      select (new
                                      {
                                          invoiceNumber = invoice.Id,
                                          customerName = customer.FullName,
                                          paymentDate = payment.PaymentDate,
                                          paymentMethod = payment.PaymentMethod,
                                          amount = payment.Amount,
                                          baaqi=payment.Baaqi,

                                      })).OrderByDescending(p => p.paymentDate).ToList();

            materialDataTablePaymentsList.DataSource = paymentInformation;
        }

        private void Payments_Form_Load(object sender, EventArgs e)
        {
            ShowAllPaymentInformation();
            materialDataTablePaymentsList.RowsDefaultCellStyle.BackColor = Color.White;
            materialDataTablePaymentsList.DefaultCellStyle.SelectionForeColor = Color.Black;
            materialDataTablePaymentsList.ShowVerticalScroll = false;
        }

        // search method
        public void searchPayment(string searchPhrase)
        {


            var context = new DataContext();
            var paymentInformation = (from payment in context.Payments
                                      join invoice in context.Invoices
                                      on payment.InvoiceId equals invoice.Id
                                      join customer in context.Customers
                                      on invoice.CustomerId equals customer.Id
                                      select (new
                                      {
                                          invoiceNumber = invoice.Id,
                                          customerName = customer.FullName,
                                          paymentDate = payment.PaymentDate,
                                          paymentMethod = payment.PaymentMethod,
                                          amount = payment.Amount,
                                          baaqi = payment.Baaqi,
                                          telephone=customer.Phone

                                      })).Where(customer=>customer.customerName.Contains(searchPhrase)||customer.telephone.Contains(searchPhrase)).OrderByDescending(p => p.paymentDate).ToList();

            materialDataTablePaymentsList.DataSource = paymentInformation;
        }
            private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            searchPayment(textBoxSearch.Text);
        }

        private void Payments_Form_Shown(object sender, EventArgs e)
        {
            materialDataTablePaymentsList.ShowVerticalScroll = false;
        }

        private void materialDataTablePaymentsList_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void Payments_Form_SizeChanged(object sender, EventArgs e)
        {
            materialDataTablePaymentsList.ShowVerticalScroll = false;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
