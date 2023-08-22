using DGVPrinterHelper;
using MaterialSkin2Framework.Controls;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using BlueLight_Management_System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using Microsoft.Office.Interop.Excel;

namespace BlueLight_Management_System.UI.Forms
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        // Customers Report 👨‍🦱
        public void CustomersReport(DateTime startDate, DateTime endDate)
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
                     numberOfServices = context.Invoices.Where(i => i.CustomerId == customer.Id).Count(),
                     registeredAt = customer.RegisteredAt,
                   

                 })).Distinct().OrderByDescending(c => c.customerId).Where(c=>c.registeredAt>=startDate && c.registeredAt<=endDate).ToList();
            materialDataTable1.AutoGenerateColumns = false; // Disable auto-generated columns
            materialDataTable1.Columns.Clear(); // Clear existing columns
            // Add custom columns
            materialDataTable1.Columns.Add("customerId", "ID");
            materialDataTable1.Columns.Add("customerName", "Name");
            materialDataTable1.Columns.Add("customerPhone", "Phone");
            materialDataTable1.Columns.Add("numberOfServices", "Number of Services");
            materialDataTable1.Columns.Add("registeredAt", "Date Registered");
            // Map data source properties to column names
            materialDataTable1.Columns["customerId"].DataPropertyName = "customerId";
            materialDataTable1.Columns["customerName"].DataPropertyName = "customerName";
            materialDataTable1.Columns["customerPhone"].DataPropertyName = "customerPhone";
            materialDataTable1.Columns["numberOfServices"].DataPropertyName = "numberOfServices";
            materialDataTable1.Columns["registeredAt"].DataPropertyName = "registeredAt";
            materialDataTable1.DataSource = customerWithInvoices;         
        }        
        public void PaymentReports(DateTime startDate, DateTime endDate)
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
                                      })).OrderByDescending(p => p.paymentDate).Where(p=>p.paymentDate>=startDate && p.paymentDate<=endDate).ToList();
            materialDataTable1.AutoGenerateColumns = false; // Disable auto-generated columns
            materialDataTable1.Columns.Clear(); // Clear existing columns

            // Add custom columns
            materialDataTable1.Columns.Add("invoiceNumber", "Invoice NO.");
            materialDataTable1.Columns.Add("customerName", "Customer Name");
            materialDataTable1.Columns.Add("paymentDate", "Date");
            materialDataTable1.Columns.Add("paymentmethod", "Payment Method.");
            materialDataTable1.Columns.Add("amount", "Paid Amount");
            materialDataTable1.Columns.Add("baaqi", "Baaqi");
            // Map data source properties to column names
            materialDataTable1.Columns["invoiceNumber"].DataPropertyName = "invoiceNumber";
            materialDataTable1.Columns["customerName"].DataPropertyName = "customerName";
            materialDataTable1.Columns["paymentDate"].DataPropertyName = "paymentDate";
            materialDataTable1.Columns["paymentMethod"].DataPropertyName = "paymentMethod";
            materialDataTable1.Columns["amount"].DataPropertyName = "amount";
            materialDataTable1.Columns["baaqi"].DataPropertyName = "baaqi";
            materialDataTable1.DataSource = paymentInformation;
        }


        public void InvoicesReport(DateTime startDate, DateTime endDate)
        {
            var context = new DataContext();
            var services = (
                from invoice in context.Invoices
                join customer in context.Customers on invoice.CustomerId equals customer.Id
                select (
                    new
                    {                   
                        customerName = customer.FullName,
                        customerPhone = customer.Phone,
                        issuedDate = invoice.IssuedDate,
                        duedate = invoice.DueDate,
                        paidAmount = invoice.PaidAmount,
                        invoiceId = invoice.Id,
                        baaqi = invoice.Baaqi,
                        total = invoice.GrandTotal,
                        discount = invoice.Discount,
                        status = invoice.Baaqi <= 0 ? "Completed" : "In Progress",

                    }
                )
            ).Distinct().OrderBy(i => i.issuedDate).Where(i=>i.issuedDate>=startDate && i.issuedDate<=endDate).ToList();


            materialDataTable1.AutoGenerateColumns = false; // Disable auto-generated columns
            materialDataTable1.Columns.Clear(); // Clear existing columns

            // Add custom columns
            materialDataTable1.Columns.Add("customerName", "Customer Name");
            materialDataTable1.Columns.Add("customerPhone", "Telephone");
            materialDataTable1.Columns.Add("issuedDate", "Date");
            materialDataTable1.Columns.Add("Status", "Status");
            materialDataTable1.Columns.Add("total", "Total");
            materialDataTable1.Columns.Add("Discount", "Discount");
            materialDataTable1.Columns.Add("paidAmount", "Paid Amount");
            materialDataTable1.Columns.Add("baaqi", "Baaqi");                       
            // Map data source properties to column names
            materialDataTable1.Columns["customerName"].DataPropertyName = "customerName";
            materialDataTable1.Columns["customerPhone"].DataPropertyName = "customerPhone";
            materialDataTable1.Columns["issuedDate"].DataPropertyName = "issuedDate";
            materialDataTable1.Columns["Status"].DataPropertyName = "Status";
            materialDataTable1.Columns["total"].DataPropertyName = "total";
            materialDataTable1.Columns["Discount"].DataPropertyName = "Discount";
            materialDataTable1.Columns["paidAmount"].DataPropertyName = "paidAmount";
            materialDataTable1.Columns["baaqi"].DataPropertyName = "baaqi";
            materialDataTable1.DataSource = services;
        }


        public void FilterByReportType()
        {
            if (comboBoxReportType.SelectedIndex >= 0)
            {
                if (comboBoxReportType.Text.Contains("Invoices"))
                {
                    InvoicesReport(Convert.ToDateTime(dateTimePickerStart.Text), Convert.ToDateTime(dateTimePickerEnd.Text));
                    return;
                }
                else if (comboBoxReportType.Text.Contains("Payments"))
                {
                    PaymentReports(Convert.ToDateTime(dateTimePickerStart.Text), Convert.ToDateTime(dateTimePickerEnd.Text));
                    return;
                }
                else
                {
                    CustomersReport(Convert.ToDateTime(dateTimePickerStart.Text), Convert.ToDateTime(dateTimePickerEnd.Text));
                    return;
                }
            }
        }

        
        public void PrintReport()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = comboBoxReportType.Text.Contains("Customers") ? "Customers Report" :
               comboBoxReportType.Text.Contains("Invoices") ? "Invoices Report" :
               comboBoxReportType.Text.Contains("Payments") ? "Payments Report" :
               "Report";
            printer.SubTitle = $"from: {dateTimePickerStart.Text} - to: {dateTimePickerEnd.Text}";

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;

            printer.Footer = "BlueLight Studio Reports";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(materialDataTable1);
        }
        private void comboBoxReportType_SelectedValueChanged(object sender, EventArgs e)
        {
            FilterByReportType();
            
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            CustomersReport(Convert.ToDateTime(dateTimePickerStart.Text), Convert.ToDateTime(dateTimePickerEnd.Text));
            comboBoxReportType.Text = "Invoices report";

            dateTimePickerEnd.Text = DateTime.Now.AddDays(1).ToString();
            //materialDataTable1.RowsDefaultCellStyle.BackColor = Color.White;
            //materialDataTable1.DefaultCellStyle.SelectionForeColor = Color.Black;
            materialDataTable1.ShowVerticalScroll = false;

        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            FilterByReportType();
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            FilterByReportType();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintReport();
          
        }

       
        //
        private void SaveDataGridViewToExcel(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count > 0)
            {
                // Show the Save File Dialog
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Workbook|*.xlsx",
                    Title = "Save Excel File",
                    FileName = $"{comboBoxReportType.Text}.xlsx" 
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;

                    Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                    xcelApp.Application.Workbooks.Add(Type.Missing);

                    // Add the header row with merged cells and text "The Header Of the report"
                    AddHeaderRow(materialDataTable1, xcelApp);

                    // Write the data rows
                    AddDataRows(materialDataTable1, xcelApp);

                    xcelApp.Columns.AutoFit();

                    // Save the Excel file
                    xcelApp.ActiveWorkbook.SaveAs(fileName);
                    xcelApp.ActiveWorkbook.Close();
                    xcelApp.Quit();

                    MessageBox.Show($"{comboBoxReportType.Text} exported into excel file successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AddHeaderRow(DataGridView dataGridView, Microsoft.Office.Interop.Excel.Application xcelApp)
        {
            int headerColumnCount = dataGridView.Columns.Count;
            Range headerRange = xcelApp.Range[xcelApp.Cells[1, 1], xcelApp.Cells[1, headerColumnCount]];
            Range columnNames = xcelApp.Range[xcelApp.Cells[2, 1], xcelApp.Cells[1, headerColumnCount]];
            columnNames.Font.Bold = true;
            columnNames.Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            headerRange.Merge();
            headerRange.Value = comboBoxReportType.Text;
            headerRange.Font.Bold = true;
            headerRange.Font.Size = 18;            
            headerRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            headerRange.VerticalAlignment = XlVAlign.xlVAlignCenter;
            headerRange.Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;

            // Add the column names after the merged header cells
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                xcelApp.Cells[2, i + 1] = dataGridView.Columns[i].HeaderText;
            }
        }

        private void AddDataRows(DataGridView dataGridView, Microsoft.Office.Interop.Excel.Application xcelApp)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    xcelApp.Cells[i + 3, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            SaveDataGridViewToExcel(materialDataTable1);
        }

        private void Reports_Shown(object sender, EventArgs e)
        {
            materialDataTable1.ShowVerticalScroll = false;
        }

        private void Reports_MaximumSizeChanged(object sender, EventArgs e)
        {
            materialDataTable1.ShowVerticalScroll = false;
        }

        private void Reports_MinimumSizeChanged(object sender, EventArgs e)
        {
            materialDataTable1.ShowVerticalScroll = false;
        }

        private void Reports_SizeChanged(object sender, EventArgs e)
        {
            materialDataTable1.ShowVerticalScroll = false;
        }
        //


    }
}
