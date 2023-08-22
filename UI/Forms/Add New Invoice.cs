//using Microsoft.EntityFrameworkCore;
using BlueLight_Management_System.Data;
using BlueLight_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueLight_Management_System.UI.Forms
{
    public partial class Add_New_Invoice : Form
    {
        public int invoiceId = 0;
        public DataContext context = new DataContext();
        public bool CustomerRegistrationEnabled = false;
       // public Customer customer = null;

        public Add_New_Invoice(Invoices invoices)
        {
            InitializeComponent();
        }

       public Add_New_Invoice()
        {
            InitializeComponent();
        }

        // --
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


        public void EnableCustomerFields()
        {
          
            textBoxFirstName.ReadOnly = false;
            textBoxLastName.ReadOnly = false;
            textBoxTelephone.ReadOnly = false;
            buttonSaveCustomer.Enabled = true;
        }

        public void DisableCustomerFields()
        {
            
            textBoxFirstName.ReadOnly = true;
            textBoxLastName.ReadOnly = true;
            textBoxTelephone.ReadOnly = true;
            buttonSaveCustomer.Enabled = false;
        }
        public void LoadCustomerInfoIntoFields()
        {
            //find customer
            var customerPhone = maskedTextBoxSearchCustomer.Text.Trim();
           var customer = context.Customers.FirstOrDefault(c => c.Phone == customerPhone);
            //check if the customer exists or not
            if (customer != null)
            {
                textBoxCustomerId.Text = customer.Id.ToString();
                textBoxFirstName.Text = customer.FirstName;
                textBoxLastName.Text = customer.LastName;
                textBoxTelephone.Text = customer.Phone;
            }
            else
            {
                MessageBox.Show(
                    $"Macmiil leh number kan {maskedTextBoxSearchCustomer.Text} ma jiro,\nFadlan iska sax ama diwaangalin cusub u samee",
                    "Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        //loading available services to the Combobox services
        public void LoadServices()
        {
            // showing available services on services comboBox
            var context = new DataContext();
            var services = context.Services.ToList();
            foreach (var service in services)
            {
                comboBoxServices.Items.Add(service.ServiceName);
            }
        }

        // add invoice Item
        public void AddInvoiceItem()
        {
            var service = context.Services.SingleOrDefault(
                s => s.ServiceName == comboBoxServices.Text
            );
            //checking if the ivoice item already exists

            if (service != null)
            {
                this.materialDataTable1.Rows.Add(
                    service.ServiceName,
                    numericUpDownQuantity.Text,
                    service.Price,
                    service.Price * numericUpDownQuantity.Value,
                    dateTimePickerDueDate.Text,
                    service.Id
                );
            }

            comboBoxServices.Text = "";
            ShowSubTotal();
            CalculateGrandTotal();

            // button text
            buttonAddItem.Text = "Add";
            //reset the quantity
            numericUpDownQuantity.Value = 0;
        }

        // show sub-total
        public void ShowSubTotal()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in materialDataTable1.Rows)
            {
                sum = sum + Convert.ToDecimal(row.Cells["Total"].Value);
            }

            textBoxShowSubTotal.Text = sum.ToString();
        }

        //calculate grand total
        public void CalculateBaaqi()
        {
            if (textBoxPaidAmount.Text.Trim().Length > 0)
            {
                textBoxShowBaaqi.Text = Convert.ToString(
                    Convert.ToDecimal(textBoxShowTotal.Text.Trim())
                        - Convert.ToDecimal(textBoxPaidAmount.Text.Trim())
                );
            }
            else
            {
                return;
            }
        }

        // calculate baaqi
        public void CalculateGrandTotal()
        {
            if (textBoxDiscount.Text.Trim().Length > 0)
            {
                textBoxShowTotal.Text = Convert.ToString(
                    Convert.ToDecimal(textBoxShowSubTotal.Text.Trim())
                        - Convert.ToDecimal(textBoxDiscount.Text.Trim())
                );
                CalculateBaaqi();
            }
            else
            {
                return;
            }
        }

        //Save Invoice Item
        public void SaveInvoiceItem(int invoiceId)
        {
            var invoiceItems = new List<InvoiceItem>();

            foreach (DataGridViewRow row in materialDataTable1.Rows)
            {
                var serviceName = row.Cells["Services"].Value;
                var service = context.Services.FirstOrDefault(
                    s => s.ServiceName == serviceName.ToString()
                );
                if (service != null)
                {
                    var invoiceItem = new InvoiceItem()
                    {
                        InvoiceId = invoiceId, //todo
                        ServiceId = service.Id,
                        Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),

                        Price = Convert.ToInt32(service.Price),
                        Total = 0

                    };

                    context.InvoiceItems.Add(invoiceItem);
                    context.SaveChanges();
                }
                else
                {
                    return;
                }
            }
        }


        // Make Payment
        public void MakePayment(int invoiceId)
        {

            //checking first if payment is made or not.
            if (Convert.ToDecimal(textBoxShowPaidAmount.Text)>0)
            {
                var payment = new Payment()
                {
                    InvoiceId = Convert.ToInt32(invoiceId),
                    Amount = Convert.ToDecimal(textBoxShowPaidAmount.Text),
                    PaymentDate = DateTime.Now,
                    PaymentMethod = comboBoxPaymentMethod.Text,
                    Baaqi= Convert.ToDecimal(textBoxShowBaaqi.Text)
                };
                context.Payments.Add(payment);
                context.SaveChanges();
            }
            else
            {
                return;
            }

        }
        //Save Invoice
        public void SaveInvoice()
        {
            
            var invoice = new Invoice()
            {
            
                InvoiceNumber=1,
                // TODO: check if a customer is selected
                CustomerId = Convert.ToInt32(textBoxCustomerId.Text),
                //TotalAmount = Convert.ToDecimal(textBoxShowTotal.Text),
                SubTotal = Convert.ToDecimal(textBoxShowSubTotal.Text),
                IssuedDate = DateTime.Now,
                DueDate = dateTimePickerDueDate.Value,
                PaidAmount = Convert.ToDecimal(textBoxShowPaidAmount.Text),
                Discount = Convert.ToDecimal(textBoxShowDiscount.Text),
                GrandTotal = 0,
                Baaqi = 0,
                Status = "In Progress",
                UpdatedAt = DateTime.Now,
                PaidDate= DateTime.Now,
                
            

            };
            // saving to the database
            context.Invoices.Add(invoice);
            
            context.SaveChanges();
             
            // saving invoice item 
            SaveInvoiceItem(invoice.Id);
            // saving the payment
            MakePayment(invoice.Id);
            invoiceId = invoice.Id;

        }

       

        private void Add_New_Invoice_Load(object sender, EventArgs e)
        {
            //LoadCustomerInfoIntoFields();
           // MessageBox.Show(customer.FirstName.ToString());
            LoadServices();
            materialDataTable1.RowsDefaultCellStyle.BackColor = Color.White;
            materialDataTable1.DefaultCellStyle.SelectionForeColor = Color.Black;


        }

       

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            var contex = new DataContext();



            // Center align the first line and increase font size

            string welcomeText = contex.CompanySettings.ToList().Count > 0 ? contex.CompanySettings.First().CompanyName.ToString() : "Blue Light Studio";
            Font welcomeFont = new Font("Arial", 16, FontStyle.Bold);
            StringFormat welcomeFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
            };
            RectangleF welcomeRect = new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height);
            e.Graphics.DrawString(welcomeText, welcomeFont, Brushes.Black, welcomeRect, welcomeFormat);

            var startY = e.MarginBounds.Top + 170; // Starting Y-coordinate
            var lineHeight = 20; // spacing between lines
            var lineThickness = 2; // Thickness of the separating lines
            int currentY = 0;
            int lastLineY = 0;


            // company logo
            if (contex.CompanySettings.ToList().Count > 0)
            {
                Image logo;
                // Convert the binary logo data to an Image object
                using (MemoryStream ms = new MemoryStream(contex.CompanySettings.First().CompanyLogo))
                {
                    logo = Image.FromStream(ms);
                }

                // Calculate the position and size of the logo
                int logoWidth = 200; // Adjust the width as needed
                int logoHeight = 100; // Adjust the height as needed
                int logoX = e.PageBounds.Right - logoWidth - e.MarginBounds.Right; // Adjust the X-coordinate to position the logo
                int logoY = e.MarginBounds.Bottom; // Adjust the Y-coordinate to position the logo

                // Draw the logo image
                e.Graphics.DrawImage(logo, logoX, logoY, logoWidth, logoHeight);

            }

            List<InvoiceItemDetails> invoiceItems;
            // Printing Invoice Items
            //checking if payment was already made or not
            if (Convert.ToDecimal(textBoxShowPaidAmount.Text) > 0)
            {


                invoiceItems = (from invoiceItem in contex.InvoiceItems.Where(i => i.InvoiceId == invoiceId)
                                join service in contex.Services on invoiceItem.ServiceId equals service.Id
                                join invoice in contex.Invoices on invoiceItem.InvoiceId equals invoice.Id
                                join payment in contex.Payments on invoice.Id equals payment.InvoiceId
                                join customer in contex.Customers on invoice.CustomerId equals customer.Id
                                select new InvoiceItemDetails
                                {
                                    serviceName = service.ServiceName,
                                    price = service.Price,
                                    invoiceId = invoice.Id,
                                    subtotal = invoice.SubTotal,
                                    quantity = invoiceItem.Quantity,
                                    invoiceItemTotal = invoiceItem.Total,
                                    paidAmount = invoice.PaidAmount,
                                    discount = invoice.Discount,
                                    baaqi = invoice.Baaqi,
                                    grandTotal = invoice.GrandTotal,
                                    issuedDate = invoice.IssuedDate,
                                    paymentMethod = payment.PaymentMethod,
                                    customerName = customer.FullName,
                                    customerPhone = customer.Phone
                                }).ToList();

            }
            else
            {
                invoiceItems = (from invoiceItem in contex.InvoiceItems.Where(i => i.InvoiceId == invoiceId)
                                join service in contex.Services on invoiceItem.ServiceId equals service.Id
                                join invoice in contex.Invoices on invoiceItem.InvoiceId equals invoice.Id
                                join customer in contex.Customers on invoice.CustomerId equals customer.Id
                                select new InvoiceItemDetails
                                {
                                    serviceName = service.ServiceName,
                                    price = service.Price,
                                    invoiceId = invoice.Id,
                                    subtotal = invoice.SubTotal,
                                    quantity = invoiceItem.Quantity,
                                    invoiceItemTotal = invoiceItem.Total,
                                    paidAmount = invoice.PaidAmount,
                                    discount = invoice.Discount,
                                    baaqi = invoice.Baaqi,
                                    grandTotal = invoice.GrandTotal,
                                    issuedDate = invoice.IssuedDate,
                                    paymentMethod = "Lama Bixin Waxba",
                                    customerName = customer.FullName,
                                    customerPhone = customer.Phone
                                }).ToList();
            }


            // Define column widths and positions
            int columnWidth = 100;
            int column1X = 10;
            int column2X = column1X + columnWidth + 20;
            int column3X = column2X + 200 + 20;
            int column4X = column3X + columnWidth + 20;
            int column5X = column4X + columnWidth + 20;
            int column6X = column5X + columnWidth + 20;
            // Draw the the invoice Id and Date
            e.Graphics.DrawString($"Date = {invoiceItems.First().issuedDate}", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(column1X, 150));
            e.Graphics.DrawString($"Invoice No = INV{invoiceItems.First().invoiceId}", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(column1X, 175));

            // Customer Information
            e.Graphics.DrawString($"Magaca Macmiilka = {invoiceItems.First().customerName}", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(column1X, 200));
            e.Graphics.DrawString($"Telephone No = {invoiceItems.First().customerPhone}", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(column1X, 225));


            // Draw table headers
            e.Graphics.DrawString("No. ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(column1X, startY));
            e.Graphics.DrawString("Adeega", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(column2X, startY));
            e.Graphics.DrawString("Cadadka ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(column3X, startY));
            e.Graphics.DrawString("Qiimaha", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(column4X, startY));
            e.Graphics.DrawString("Total", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(column5X, startY));

            // Draw separating line below headers
            int headerLineY = startY + lineHeight;
            e.Graphics.DrawLine(new Pen(Brushes.Black, lineThickness), column1X, headerLineY, column6X + columnWidth, headerLineY);

            // Draw invoice items data
            for (int i = 0; i < invoiceItems.Count; i++)
            {
                currentY = startY + (i + 1) * lineHeight; // Adjust the Y-coordinate for each row

                // Draw invoice item details in each column
                e.Graphics.DrawString((i + 1).ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(column1X, currentY));
                e.Graphics.DrawString(invoiceItems[i].serviceName, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(column2X, currentY));
                e.Graphics.DrawString(invoiceItems[i].quantity.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(column3X, currentY));
                e.Graphics.DrawString(invoiceItems[i].price.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(column4X, currentY));
                e.Graphics.DrawString(invoiceItems[i].invoiceItemTotal.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(column5X, currentY));

            }


            // Draw a line below the last record
            lastLineY = startY + (invoiceItems.Count + 1) * lineHeight - lineThickness / 2;
            e.Graphics.DrawLine(new Pen(Brushes.Black, lineThickness), column1X, lastLineY, column6X + columnWidth, lastLineY);

            // Payment Summary
            e.Graphics.DrawString("Payment Summary", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(column5X, currentY + 50)); // payment summary title
            e.Graphics.DrawLine(new Pen(Brushes.Black, lineThickness), column4X, lastLineY + 50, column6X + columnWidth, lastLineY + 50); //underline
                                                                                                                                          //sub total
            e.Graphics.DrawString("Sub Total = ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(column4X, currentY + 75));
            e.Graphics.DrawString(invoiceItems.First().subtotal.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(column5X, currentY + 75));
            // discount
            e.Graphics.DrawString("Discount = ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(column4X, currentY + 100));
            e.Graphics.DrawString(invoiceItems.First().discount.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(column5X, currentY + 100));
            //grand total
            e.Graphics.DrawString("Grand Total = ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(column4X, currentY + 125));
            e.Graphics.DrawString(invoiceItems.First().grandTotal.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(column5X, currentY + 125));
            //Paid Amount
            e.Graphics.DrawString("Paid Amount = ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(column4X, currentY + 150));
            e.Graphics.DrawString(invoiceItems.First().paidAmount.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(column5X, currentY + 150));
            //Payment Method
            e.Graphics.DrawString("P. Method = ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(column4X, currentY + 175));
            e.Graphics.DrawString(invoiceItems.First().paymentMethod.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(column5X, currentY + 175));
            // Baaqi
            e.Graphics.DrawString("Baaqi = ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(column4X, currentY + 200));
            e.Graphics.DrawString(invoiceItems.First().baaqi.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(column5X, currentY + 200));

            e.Graphics.DrawLine(new Pen(Brushes.Black, lineThickness), column4X, lastLineY + 225, column6X + columnWidth, lastLineY + 225);  // bottom line



        }

        private void buttonSaveAndPrint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ma hubtaa in aad Save Gareeyso.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes == true)
            {
                SaveInvoice();
                insert();
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();

                this.Close();
            }
            else
            {
                return;
            }
        }

        private void materialDataTable1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // removing invoice Item from the datagrid 
            if (materialDataTable1.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                materialDataTable1.Rows.RemoveAt(e.RowIndex);
                // refreshing the calculations
                ShowSubTotal();
                CalculateGrandTotal();

            } // updating the invoice Item 
            else if (materialDataTable1.Columns[e.ColumnIndex].Name == "editButton")
            {
                // loading data to the fields, to be edited
                numericUpDownQuantity.Text = materialDataTable1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                comboBoxServices.Text = materialDataTable1.Rows[e.RowIndex].Cells["Services"].Value.ToString();
                dateTimePickerDueDate.Text = materialDataTable1.Rows[e.RowIndex].Cells["DueDate"].Value.ToString();

                // removing the item from the datagrid to be edited
                materialDataTable1.Rows.RemoveAt(e.RowIndex);
                // refreshing the calculations
                ShowSubTotal();
                CalculateGrandTotal();

                // changing the text of "add" button into "edit"
                buttonAddItem.Text = "Edit";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCustomerId.Text = textBoxFirstName.Text = textBoxLastName.Text = textBoxTelephone.Text = textBoxTelephone.Text = "";
            textBoxPaidAmount.Text = textBoxDiscount.Text = textBoxShowBaaqi.Text = textBoxShowDiscount.Text = textBoxShowPaidAmount.Text = textBoxShowSubTotal.Text = textBoxShowTotal.Text = "0";
            maskedTextBoxSearchCustomer.Text = "";
            materialDataTable1.Rows.Clear();
        }

        private void buttonAddNewCustomer_Click(object sender, EventArgs e)
        {
            EnableCustomerFields();
          
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
           
           

            

            if (textBoxCustomerId.Text !="" && materialDataTable1.Rows.Count>0)
            {
                if (MessageBox.Show("Ma hubtaa in aad Save Gareeyso.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes == true)
                {
                    SaveInvoice();
                    insert();
                    this.Close();
                }
                else
                {
                    return;
                }
               
                    
            }else if(textBoxCustomerId.Text =="")
            {
                MessageBox.Show("Fadlan soo gali macmiilka", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Fadlan soo gali Adeega", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void textBoxDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateGrandTotal();
            //show disocunt
            textBoxShowDiscount.Text = textBoxDiscount.Text;
        }

       
        private void textBoxPaidAmount_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateBaaqi();
            //show paid amount
            textBoxShowPaidAmount.Text = textBoxPaidAmount.Text;
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if(numericUpDownQuantity.Value>0)
            {

                AddInvoiceItem();
            }
            else
            {
                MessageBox.Show("Fadlan soo gali Quantity ga.", "Message", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void buttonSearchCustomerAndFill_Click(object sender, EventArgs e)
        {
            LoadCustomerInfoIntoFields();
            DisableCustomerFields();
        }

        private void textBoxPaidAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxSearchCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control character
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancel the event to prevent non-numeric input
                e.Handled = true;
            }
        }

        private void textBoxPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control character
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancel the event to prevent non-numeric input
                e.Handled = true;
            }
        }

        private void textBoxDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control character
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancel the event to prevent non-numeric input
                e.Handled = true;
            }
        }

        private void comboBoxPaymentMethod_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void maskedTextBoxSearchCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPaymentMethod_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void buttonSaveCustomer_Click(object sender, EventArgs e)
        {

            var customer = new Customer()
            {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                FullName = $"{textBoxFirstName.Text} {textBoxLastName.Text}",
                Phone = textBoxTelephone.Text,
                RegisteredAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            context.Customers.Add(customer);
            context.SaveChanges();
            textBoxCustomerId.Text = customer.Id.ToString();

            DisableCustomerFields();

        }
    }


}
