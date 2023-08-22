using System.Drawing;
using System.Windows.Forms;
using MaterialSkin2Framework;

namespace BlueLight_Management_System.UI.Forms
{
    partial class Customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.materialDataTableCustomers = new MaterialSkin2Framework.Controls.MaterialDataTable();
            this.Macmiilka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taariikh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baaqi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfServices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisteredAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin2Framework.Controls.MaterialDivider();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxFirstName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.materialDataTableCustomers)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customers";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Lato", 18F);
            this.textBoxSearch.Location = new System.Drawing.Point(336, 15);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(258, 36);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // materialDataTableCustomers
            // 
            this.materialDataTableCustomers.AllowUserToAddRows = false;
            this.materialDataTableCustomers.AllowUserToDeleteRows = false;
            this.materialDataTableCustomers.AllowUserToResizeRows = false;
            this.materialDataTableCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDataTableCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materialDataTableCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialDataTableCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialDataTableCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.materialDataTableCustomers.CellSelectionPrimaryColor = MaterialSkin2Framework.Primary.Grey50;
            this.materialDataTableCustomers.ColorStripColor = MaterialSkin2Framework.Primary.Grey50;
            this.materialDataTableCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialDataTableCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.materialDataTableCustomers.ColumnHeadersHeight = 56;
            this.materialDataTableCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.materialDataTableCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Macmiilka,
            this.CustomerId,
            this.Telephone,
            this.Taariikh,
            this.Baaqi,
            this.NumberOfServices,
            this.RegisteredAt,
            this.UpatedAt,
            this.EditButton,
            this.DeleteButton});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.materialDataTableCustomers.DefaultCellStyle = dataGridViewCellStyle4;
            this.materialDataTableCustomers.Depth = 0;
            this.materialDataTableCustomers.EnableHeadersVisualStyles = false;
            this.materialDataTableCustomers.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialDataTableCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.materialDataTableCustomers.Location = new System.Drawing.Point(13, 70);
            this.materialDataTableCustomers.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.materialDataTableCustomers.Name = "materialDataTableCustomers";
            this.materialDataTableCustomers.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialDataTableCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.materialDataTableCustomers.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDataTableCustomers.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.materialDataTableCustomers.RowTemplate.Height = 52;
            this.materialDataTableCustomers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.materialDataTableCustomers.ShowVerticalScroll = false;
            this.materialDataTableCustomers.Size = new System.Drawing.Size(581, 455);
            this.materialDataTableCustomers.TabIndex = 4;
            this.materialDataTableCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.materialDataTableCustomers_CellContentClick);
            // 
            // Macmiilka
            // 
            this.Macmiilka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Macmiilka.DataPropertyName = "customerName";
            this.Macmiilka.HeaderText = "Macmiilka";
            this.Macmiilka.Name = "Macmiilka";
            this.Macmiilka.ReadOnly = true;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "customerId";
            this.CustomerId.HeaderText = "Customer Id";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.Visible = false;
            // 
            // Telephone
            // 
            this.Telephone.DataPropertyName = "customerPhone";
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            // 
            // Taariikh
            // 
            this.Taariikh.DataPropertyName = "issuedDate";
            this.Taariikh.HeaderText = "Taariikh";
            this.Taariikh.Name = "Taariikh";
            this.Taariikh.ReadOnly = true;
            this.Taariikh.Visible = false;
            // 
            // Baaqi
            // 
            this.Baaqi.DataPropertyName = "amountDue";
            this.Baaqi.HeaderText = "Baaqi";
            this.Baaqi.Name = "Baaqi";
            this.Baaqi.ReadOnly = true;
            this.Baaqi.Visible = false;
            // 
            // NumberOfServices
            // 
            this.NumberOfServices.DataPropertyName = "numberOfServices";
            this.NumberOfServices.HeaderText = "No. Invoices";
            this.NumberOfServices.Name = "NumberOfServices";
            this.NumberOfServices.ReadOnly = true;
            // 
            // RegisteredAt
            // 
            this.RegisteredAt.DataPropertyName = "registeredAt";
            this.RegisteredAt.HeaderText = "Registered";
            this.RegisteredAt.Name = "RegisteredAt";
            this.RegisteredAt.ReadOnly = true;
            // 
            // UpatedAt
            // 
            this.UpatedAt.DataPropertyName = "updatedAt";
            this.UpatedAt.HeaderText = "Updated";
            this.UpatedAt.Name = "UpatedAt";
            this.UpatedAt.ReadOnly = true;
            // 
            // EditButton
            // 
            this.EditButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EditButton.DataPropertyName = "customerId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            this.EditButton.DefaultCellStyle = dataGridViewCellStyle2;
            this.EditButton.HeaderText = "Edit";
            this.EditButton.Name = "EditButton";
            this.EditButton.ReadOnly = true;
            this.EditButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditButton.Text = "Edit";
            this.EditButton.ToolTipText = "Edit";
            this.EditButton.UseColumnTextForButtonValue = true;
            this.EditButton.Width = 80;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeleteButton.DataPropertyName = "customerId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            this.DeleteButton.DefaultCellStyle = dataGridViewCellStyle3;
            this.DeleteButton.HeaderText = "Delete";
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseColumnTextForButtonValue = true;
            this.DeleteButton.Width = 80;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(225)))));
            this.buttonAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(225)))));
            this.buttonAddCustomer.FlatAppearance.BorderSize = 0;
            this.buttonAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCustomer.Font = new System.Drawing.Font("Lato", 18F);
            this.buttonAddCustomer.ForeColor = System.Drawing.Color.White;
            this.buttonAddCustomer.Location = new System.Drawing.Point(653, 14);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(211, 37);
            this.buttonAddCustomer.TabIndex = 5;
            this.buttonAddCustomer.Text = "Add Customer";
            this.buttonAddCustomer.UseVisualStyleBackColor = false;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.materialDivider1);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxCustomerId);
            this.panel1.Controls.Add(this.textBoxTelephone);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.textBoxLastName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textboxFirstName);
            this.panel1.Location = new System.Drawing.Point(600, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 454);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Add New Customer";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-1, 60);
            this.materialDivider1.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(258, 1);
            this.materialDivider1.TabIndex = 32;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Font = new System.Drawing.Font("Lato", 18F);
            this.buttonSave.Location = new System.Drawing.Point(9, 395);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(104, 39);
            this.buttonSave.TabIndex = 31;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 18F);
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "ID:";
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Font = new System.Drawing.Font("Lato", 18F);
            this.textBoxCustomerId.Location = new System.Drawing.Point(8, 103);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.ReadOnly = true;
            this.textBoxCustomerId.Size = new System.Drawing.Size(243, 36);
            this.textBoxCustomerId.TabIndex = 29;
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Enabled = false;
            this.textBoxTelephone.Font = new System.Drawing.Font("Lato", 18F);
            this.textBoxTelephone.Location = new System.Drawing.Point(8, 335);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(243, 36);
            this.textBoxTelephone.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 18F);
            this.label6.Location = new System.Drawing.Point(8, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "Telephone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 18F);
            this.label4.Location = new System.Drawing.Point(8, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "First Name:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Font = new System.Drawing.Font("Lato", 18F);
            this.buttonUpdate.Location = new System.Drawing.Point(158, 396);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(99, 39);
            this.buttonUpdate.TabIndex = 25;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Enabled = false;
            this.textBoxLastName.Font = new System.Drawing.Font("Lato", 18F);
            this.textBoxLastName.Location = new System.Drawing.Point(8, 257);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(243, 36);
            this.textBoxLastName.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 18F);
            this.label5.Location = new System.Drawing.Point(8, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Last Name:";
            // 
            // textboxFirstName
            // 
            this.textboxFirstName.Enabled = false;
            this.textboxFirstName.Font = new System.Drawing.Font("Lato", 18F);
            this.textboxFirstName.Location = new System.Drawing.Point(8, 180);
            this.textboxFirstName.Name = "textboxFirstName";
            this.textboxFirstName.Size = new System.Drawing.Size(243, 36);
            this.textboxFirstName.TabIndex = 22;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.materialDataTableCustomers);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customers";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialDataTableCustomers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxSearch;
        private MaterialSkin2Framework.Controls.MaterialDataTable materialDataTableCustomers;
        private Button buttonAddCustomer;
        private Panel panel1;
        private TextBox textBoxTelephone;
        private Label label6;
        private Label label4;
        private Button buttonUpdate;
        private TextBox textBoxLastName;
        private Label label5;
        private TextBox textboxFirstName;
        private Label label3;
        private TextBox textBoxCustomerId;
        private Button buttonSave;
        private ErrorProvider errorProvider1;
        private Label label2;
        private MaterialSkin2Framework.Controls.MaterialDivider materialDivider1;
        private DataGridViewTextBoxColumn Macmiilka;
        private DataGridViewTextBoxColumn CustomerId;
        private DataGridViewTextBoxColumn Telephone;
        private DataGridViewTextBoxColumn Taariikh;
        private DataGridViewTextBoxColumn Baaqi;
        private DataGridViewTextBoxColumn NumberOfServices;
        private DataGridViewTextBoxColumn RegisteredAt;
        private DataGridViewTextBoxColumn UpatedAt;
        private DataGridViewButtonColumn EditButton;
        private DataGridViewButtonColumn DeleteButton;
    }
}