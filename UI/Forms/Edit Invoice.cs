using BlueLight_Management_System.Data;
//using Studio_Management_System.Migrations;
using BlueLight_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueLight_Management_System.UI.Forms
{
    public partial class Edit_Invoice : Form
    {
        decimal paidAmount;
        decimal baaqi;
        decimal discount;
        public int targetInvoiceId { get; set; }
        DataContext context = new DataContext();

        public Edit_Invoice(Invoices invoicesForm)
        {
            InitializeComponent();
        }
        //--
        //
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void insert()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        //--
        //00
        //FUNCTIONS
        public void LoadInvoiceItems()
        {
            //TODO: get the invoiceId


            var invoiceData = (
                from targetInvoice in context.Invoices.Where(i => i.Id == targetInvoiceId)
                join invoiceItem in context.InvoiceItems
                    on targetInvoice.Id equals invoiceItem.InvoiceId
                join service in context.Services
                    on invoiceItem.ServiceId equals service.Id
                select (new
                {
                    invoiceId = targetInvoice.Id,
                    serviceName = service.ServiceName,
                    quantity = invoiceItem.Quantity,
                    price = invoiceItem.Price,
                    total = invoiceItem.Total,
                    dueDate = targetInvoice.DueDate,
                    invoiceItemId = invoiceItem.Id,
                    status = targetInvoice.Status



                })
            ).ToList();

            materialDataTable1.DataSource = invoiceData;
           // comboBoxStatus.Text = invoiceData.First().status;


        }


        // load payment information
        public void LoadPaymentInformation()
        {
            IEnumerable<InvoicePayment> invoicePayment;

            if (context.Payments.Where(p => p.InvoiceId == targetInvoiceId).ToList().Count > 0)
            {
                invoicePayment = from invoice in context.Invoices.Where(i => i.Id == targetInvoiceId)
                                 join payment in context.Payments
                                 on invoice.Id equals payment.InvoiceId
                                 select new InvoicePayment
                                 {
                                     invoiceId = payment.InvoiceId,
                                     paidAmount = invoice.PaidAmount,
                                     discount = invoice.Discount,
                                     subtotal = invoice.SubTotal,
                                     baaqi = invoice.Baaqi,
                                     grandTotal = invoice.GrandTotal,

                                     //total=invoice.TotalAmount,
                                 };

            }
            else
            {
                invoicePayment = from invoice in context.Invoices.Where(i => i.Id == targetInvoiceId)
                                 select new InvoicePayment
                                 {
                                     invoiceId = targetInvoiceId,
                                     paidAmount = 0,
                                     discount = 0,
                                     subtotal = invoice.SubTotal,
                                     baaqi = invoice.Baaqi,
                                     grandTotal = invoice.GrandTotal,
                                     //total=invoice.TotalAmount,
                                 };
            }

            textBoxShowPaidAmount.Text = invoicePayment.First().paidAmount.ToString();
            textBoxShowDiscount.Text = invoicePayment.First().discount.ToString();
            textBoxShowBaaqi.Text = invoicePayment.First().baaqi.ToString();
            textBoxShowTotal.Text = invoicePayment.First().grandTotal.ToString();
            textBoxShowSubTotal.Text = invoicePayment.First().subtotal.ToString();
            paidAmount = invoicePayment.First().paidAmount;
            baaqi = invoicePayment.First().baaqi;
            discount = invoicePayment.First().discount;

            //  textBoxShowSubTotal.Text=invoicePayment.First().total.ToString();

        }

        // Make Payment
        public void MakePayment(int invoiceId)
        {

            //checking first if payment is made or not.
            if (Convert.ToDecimal(textBoxPaidAmount.Text)> 0)
            {
                var payment = new Payment()
                {
                    InvoiceId = Convert.ToInt32(invoiceId),
                    Amount = Convert.ToDecimal(textBoxPaidAmount.Text),
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
        // Save Invoice
        public void UpdateInvoice()
        {
            //
            int invoiceId = targetInvoiceId; //TODO:  automate
            var targetInvoice = context.Invoices.First(i => i.Id == invoiceId);
            //update
            targetInvoice.SubTotal = Convert.ToDecimal(textBoxShowSubTotal.Text);
            targetInvoice.PaidAmount = Convert.ToDecimal(textBoxShowPaidAmount.Text);
            targetInvoice.Discount = Convert.ToDecimal(textBoxShowDiscount.Text);
            targetInvoice.Baaqi = Convert.ToDecimal(textBoxShowBaaqi.Text);
            //targetInvoice.Status = comboBoxStatus.Text;
            targetInvoice.UpdatedAt = DateTime.Now;


            // saving to the database

            context.SaveChanges();
            // saving invoice item 

            // saving the payment
            MakePayment(invoiceId);
        }

        //00

        

        public void CalculatePaidAmount(decimal paidAmount, decimal baaqi)
        {
            textBoxShowPaidAmount.Text = Convert.ToString(Convert.ToDecimal(textBoxPaidAmount.Text) + paidAmount);
            textBoxShowBaaqi.Text = Convert.ToString(baaqi - Convert.ToDecimal(textBoxPaidAmount.Text));
        }
        public void CalculateDiscount(decimal discount)
        {
            textBoxShowDiscount.Text = Convert.ToString(Convert.ToDecimal(textBoxDiscount.Text) + discount);
            textBoxShowBaaqi.Text = Convert.ToString(baaqi - Convert.ToDecimal(textBoxDiscount.Text));
        }
       

        

        

     

        private void Edit_Invoice_Load(object sender, EventArgs e)
        {
            LoadInvoiceItems();
            LoadPaymentInformation();
            materialDataTable1.RowsDefaultCellStyle.BackColor = Color.White;
            materialDataTable1.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            UpdateInvoice();
            insert();
            this.Close();
        }

        private void textBoxDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateDiscount(discount);
        }

        private void buttonSaveWithPrint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ma hubtaa in aad Update Gareeyso.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes == true)
            {
                UpdateInvoice();
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
            if (contex.Payments.Where(p => p.InvoiceId == targetInvoiceId).ToList().Count > 0)
            {


                invoiceItems = (from invoiceItem in contex.InvoiceItems.Where(i => i.InvoiceId == targetInvoiceId)
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
                                    paymentMethod = comboBoxPaymentMethod.Text, // TODO: ❓
                                    customerName = customer.FullName,
                                    customerPhone = customer.Phone
                                }).Distinct().ToList();

            }
            else
            {
                invoiceItems = (from invoiceItem in contex.InvoiceItems.Where(i => i.InvoiceId == targetInvoiceId)
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

                                }).Distinct().ToList();
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

        private void textBoxPaidAmount_KeyUp(object sender, KeyEventArgs e)
        {
            // textBoxShowBaaqi.Text = Convert.ToString(Convert.ToDecimal(textBoxShowBaaqi)-Convert.ToDecimal(textBoxPaidAmount.Text));
            //CalculatePaidAmount()
            //CalculatePaidAmount();

        }

        private void textBoxPaidAmount_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPaidAmount.Text.Trim() is "")
            {
                textBoxPaidAmount.Text = "0";
            }
            CalculatePaidAmount(paidAmount, baaqi);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_DoubleClick(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            printDocument1.Print();
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

        private void buttonClear_Click(object sender, EventArgs e)
        {

        }
    }

    public class InvoicePayment
    {
        public int invoiceId { get; set; }
        public decimal paidAmount { get; set; }
        public decimal discount { get; set; }
        public decimal subtotal { get; set; }
        public decimal baaqi { get; set; }
        public decimal grandTotal { get; set; }
        // public decimal total { get; set; }
    }

}
