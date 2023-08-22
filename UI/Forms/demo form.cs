using BlueLight_Management_System.Data;
using BlueLight_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueLight_Management_System.UI.Forms
{
    public partial class demo_form : Form
    {
        public demo_form()
        {
            InitializeComponent();
        }

        public async Task<List<Customer>> SearchCustomersByFullNameOrPhoneAsync(string searchPhrase)
        {
            using (var context = new DataContext())
            {
                var query = @"SELECT * FROM Customers
                      WHERE FullName LIKE @searchPhrase OR Phone LIKE @searchPhrase";

                var parameter = new SqlParameter("@searchPhrase", $"%{searchPhrase}%");

                return await context.Customers.SqlQuery(query, parameter).ToListAsync();
            }
        }

        public async Task ShowAllCustomers()
        {
            // Create a new DataContext object.
            var context = new DataContext();

            // Get a list of all customers from the database.
            var customers = await context.Customers.ToListAsync();

            // Set the DataSource property of the DataGridView control to the list of customers.
            dataGridView1.DataSource = customers;
        }

        public async Task<List<Customer>> ShowAllCustomersAsync(string searchPhrase)
        {
            using (var context = new DataContext())
            {
                var query = @"SELECT * FROM Customers";

                var parameter = new SqlParameter("@searchPhrase", $"%{searchPhrase}%");

                return await context.Customers.SqlQuery(query, parameter).ToListAsync();
            }
        }


        public async Task SearchCustomersAsync()
        {
            using (var context = new DataContext())
            {
                string searchPhrase = textBox1.Text.ToLower().Trim();

                string query = @"
            SELECT
               
                c.FullName AS customerName,
                c.Phone AS customerPhone
             FROM Customers  c
                WHERE
                LOWER(c.FullName) LIKE '%' + @searchPhrase + '%'
                OR LOWER(c.Phone) LIKE '%' + @searchPhrase + '%'
";

                var parameter = new SqlParameter("@searchPhrase", searchPhrase);

                var customerWithInvoices = await context.Customers
                    .SqlQuery(query, parameter)
                    .ToListAsync();

                dataGridView1.DataSource = customerWithInvoices;
            }
        }




        private  async void demo_form_Load(object sender, EventArgs e)
        {
            //List<Customer> customers = await SearchCustomersByFullNameOrPhoneAsync("(519) 412-1681");
            //dataGridView1.DataSource = customers
            //;
            await ShowAllCustomers();
            
        }

        private  void materialButton1_Click(object sender, EventArgs e)
        {
           //await  SearchCustomersAsync();
             ShowAllCustomers();
        }
    }
}
