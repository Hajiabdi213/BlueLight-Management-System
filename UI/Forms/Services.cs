//using Microsoft.EntityFrameworkCore;
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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }


        // Check empty textboxes method
        private bool CheckEmptyTextBoxes()
        {
            var isEmptyFieldExist = false;
            List<bool> emptyCheckLists = new List<bool>();
            if (string.IsNullOrEmpty(textboxServiceName.Text))
            {
                errorProvider1.SetError(textboxServiceName, "Enter The Service Name.");
                emptyCheckLists.Add(true);

            }
            else
            {
                errorProvider1.SetError(textboxServiceName, string.Empty);
                emptyCheckLists.Add(false);
            }
            //02. check price
            if (string.IsNullOrEmpty(textBoxPrice.Text))
            {
                errorProvider1.SetError(textBoxPrice, "Enter the Last Name");
                emptyCheckLists.Add(true);
            }
            else
            {
                errorProvider1.SetError(textBoxPrice, string.Empty);
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
        private void Services_Load(object sender, EventArgs e)
        {
            ShowAllServices();
            materialDataTable1.RowsDefaultCellStyle.BackColor = Color.White;
            materialDataTable1.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        // clear all
        public void ClearAllFields()
        {
            textBoxDescription.Text = textBoxPrice.Text = textboxServiceName.Text = "";
            buttonSave.Text = "SAVE";
        }
        // display all services
        public void ShowAllServices()
        {
            var context = new DataContext();
            materialDataTable1.ShowVerticalScroll = false;
            materialDataTable1.DataSource = context.Services.OrderByDescending(s => s.Id).ToList();
        }

      

       

       

       

        private void buttonSave_Click(object sender, EventArgs e)
        {
            CheckEmptyTextBoxes();
            if (CheckEmptyTextBoxes())
            {
                return;
            }
            var context = new DataContext();

            if (buttonSave.Text == "SAVE")
            {
                var service = new Service()
                {
                    ServiceName = textboxServiceName.Text,
                    Price = Convert.ToDecimal(textBoxPrice.Text),
                    Description = textBoxDescription.Text,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,

                };

                context.Services.Add(service);
                context.SaveChanges();
                ClearAllFields();
                ShowAllServices();
            }
            else
            {
                var serviceId = int.Parse(labelServiceId.Text);
                var targetService = context.Services.SingleOrDefault(s => s.Id == serviceId);
                if (targetService != null)
                {
                    if (MessageBox.Show("Are you sure to update?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        label2.Text = "Add Service";
                        targetService.ServiceName = textboxServiceName.Text;
                        targetService.Price = Convert.ToDecimal(textBoxPrice.Text);
                        targetService.Description = textBoxDescription.Text;
                        targetService.UpdatedAt = DateTime.Now;


                        context.SaveChanges();
                        ClearAllFields();
                        ShowAllServices();
                    }

                }
            }

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            var context = new DataContext();
            var targetServices = context.Services.Where(s => s.ServiceName.Contains(textBoxSearch.Text)).ToList();
            materialDataTable1.DataSource = targetServices;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textboxServiceName.Text = textBoxDescription.Text = textBoxPrice.Text = textBoxSearch.Text = string.Empty;
            label2.Text = "Add Service";
            buttonSave.Text = "Save";
        }

        private void materialDataTable1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var serviceId = Convert.ToInt32(materialDataTable1.CurrentRow.Cells["Service_Id"].Value);
            //delete 
            if (materialDataTable1.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                if (MessageBox.Show("Are you sure to Delete", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var context = new DataContext();
                    var targetService = context.Services.SingleOrDefault(u => u.Id == serviceId);
                    if (targetService != null)
                    {
                        context.Services.Remove(targetService);
                        context.SaveChanges();

                        ShowAllServices();

                    }
                    return;
                };

            }



            // update 
            if (materialDataTable1.Columns[e.ColumnIndex].Name == "EditButton")
            {

                var context = new DataContext();
                var targetService = context.Services.SingleOrDefault(u => u.Id == serviceId);
                if (targetService != null)
                {

                    //show data in the boxes
                    buttonSave.Text = "Update";
                    label2.Text = "Update Service";
                    textboxServiceName.Text = targetService.ServiceName;
                    textBoxPrice.Text = targetService.Price.ToString();
                    textBoxDescription.Text = targetService.Description;
                    labelServiceId.Text = targetService.Id.ToString();



                }
                return;


            }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control character
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                
              
                // Cancel the event to prevent non-numeric input
                e.Handled = true;
            }
           
        }
    }
}
