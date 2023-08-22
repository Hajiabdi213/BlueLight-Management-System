using System.Drawing;
using System.Windows.Forms;

namespace BlueLight_Management_System.UI.Forms
{
    partial class Invoices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddInvoice = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.materialDataTableInvoicesList = new MaterialSkin2Framework.Controls.MaterialDataTable();
            this.Macmiilka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taariikh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baaqi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboBoxSearchByStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataTableInvoicesList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoices";
            // 
            // buttonAddInvoice
            // 
            this.buttonAddInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(225)))));
            this.buttonAddInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAddInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(225)))));
            this.buttonAddInvoice.FlatAppearance.BorderSize = 0;
            this.buttonAddInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddInvoice.Font = new System.Drawing.Font("Lato", 18F);
            this.buttonAddInvoice.ForeColor = System.Drawing.Color.White;
            this.buttonAddInvoice.Location = new System.Drawing.Point(638, 10);
            this.buttonAddInvoice.Name = "buttonAddInvoice";
            this.buttonAddInvoice.Size = new System.Drawing.Size(227, 43);
            this.buttonAddInvoice.TabIndex = 2;
            this.buttonAddInvoice.Text = "+ Add New";
            this.buttonAddInvoice.UseVisualStyleBackColor = false;
            this.buttonAddInvoice.Click += new System.EventHandler(this.buttonAddInvoice_Click_1);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Lato", 18F);
            this.textBoxSearch.Location = new System.Drawing.Point(561, 59);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(304, 36);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // materialDataTableInvoicesList
            // 
            this.materialDataTableInvoicesList.AllowUserToAddRows = false;
            this.materialDataTableInvoicesList.AllowUserToDeleteRows = false;
            this.materialDataTableInvoicesList.AllowUserToResizeRows = false;
            this.materialDataTableInvoicesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDataTableInvoicesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materialDataTableInvoicesList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialDataTableInvoicesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialDataTableInvoicesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.materialDataTableInvoicesList.CellSelectionPrimaryColor = MaterialSkin2Framework.Primary.Grey50;
            this.materialDataTableInvoicesList.ColorStripColor = MaterialSkin2Framework.Primary.Grey50;
            this.materialDataTableInvoicesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialDataTableInvoicesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.materialDataTableInvoicesList.ColumnHeadersHeight = 56;
            this.materialDataTableInvoicesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.materialDataTableInvoicesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Macmiilka,
            this.duedate,
            this.InvoiceId,
            this.CustomerId,
            this.Telephone,
            this.Status,
            this.Taariikh,
            this.TotalAmount,
            this.Discount,
            this.paidAmount,
            this.Baaqi,
            this.EditButton,
            this.DeleteButton});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.materialDataTableInvoicesList.DefaultCellStyle = dataGridViewCellStyle4;
            this.materialDataTableInvoicesList.Depth = 0;
            this.materialDataTableInvoicesList.EnableHeadersVisualStyles = false;
            this.materialDataTableInvoicesList.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialDataTableInvoicesList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.materialDataTableInvoicesList.Location = new System.Drawing.Point(13, 101);
            this.materialDataTableInvoicesList.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.materialDataTableInvoicesList.MultiSelect = false;
            this.materialDataTableInvoicesList.Name = "materialDataTableInvoicesList";
            this.materialDataTableInvoicesList.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialDataTableInvoicesList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.materialDataTableInvoicesList.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDataTableInvoicesList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.materialDataTableInvoicesList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.AliceBlue;
            this.materialDataTableInvoicesList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.materialDataTableInvoicesList.RowTemplate.Height = 52;
            this.materialDataTableInvoicesList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.materialDataTableInvoicesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.materialDataTableInvoicesList.ShowVerticalScroll = false;
            this.materialDataTableInvoicesList.Size = new System.Drawing.Size(852, 426);
            this.materialDataTableInvoicesList.TabIndex = 4;
            this.materialDataTableInvoicesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.materialDataTableInvoicesList_CellContentClick);
            this.materialDataTableInvoicesList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.materialDataTableInvoicesList_CellFormatting);
            this.materialDataTableInvoicesList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.materialDataTableInvoicesList_ColumnHeaderMouseClick);
            // 
            // Macmiilka
            // 
            this.Macmiilka.DataPropertyName = "customerName";
            this.Macmiilka.HeaderText = "Macmiilka";
            this.Macmiilka.Name = "Macmiilka";
            this.Macmiilka.ReadOnly = true;
            // 
            // duedate
            // 
            this.duedate.DataPropertyName = "dueDate";
            this.duedate.HeaderText = "DueDate";
            this.duedate.Name = "duedate";
            this.duedate.ReadOnly = true;
            this.duedate.Visible = false;
            // 
            // InvoiceId
            // 
            this.InvoiceId.DataPropertyName = "invoiceId";
            this.InvoiceId.HeaderText = "InvoiceId";
            this.InvoiceId.Name = "InvoiceId";
            this.InvoiceId.ReadOnly = true;
            this.InvoiceId.Visible = false;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "customerId";
            this.CustomerId.HeaderText = "ClientId";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.Visible = false;
            // 
            // Telephone
            // 
            this.Telephone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Telephone.DataPropertyName = "customerPhone";
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Status.DataPropertyName = "status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 119;
            // 
            // Taariikh
            // 
            this.Taariikh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Taariikh.DataPropertyName = "issuedDate";
            this.Taariikh.HeaderText = "Taariikh";
            this.Taariikh.Name = "Taariikh";
            this.Taariikh.ReadOnly = true;
            this.Taariikh.Visible = false;
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalAmount.DataPropertyName = "total";
            this.TotalAmount.HeaderText = "Total ";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Discount.DataPropertyName = "discount";
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // paidAmount
            // 
            this.paidAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paidAmount.DataPropertyName = "paidAmount";
            this.paidAmount.HeaderText = "La Bixiyay";
            this.paidAmount.Name = "paidAmount";
            this.paidAmount.ReadOnly = true;
            // 
            // Baaqi
            // 
            this.Baaqi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Baaqi.DataPropertyName = "baaqi";
            this.Baaqi.HeaderText = "Baaqi";
            this.Baaqi.Name = "Baaqi";
            this.Baaqi.ReadOnly = true;
            // 
            // EditButton
            // 
            this.EditButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EditButton.DataPropertyName = "invoiceId";
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
            this.DeleteButton.DataPropertyName = "invoiceId";
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
            // comboBoxSearchByStatus
            // 
            this.comboBoxSearchByStatus.Font = new System.Drawing.Font("Lato", 18F);
            this.comboBoxSearchByStatus.FormattingEnabled = true;
            this.comboBoxSearchByStatus.Items.AddRange(new object[] {
            "In Progress",
            "Completed"});
            this.comboBoxSearchByStatus.Location = new System.Drawing.Point(13, 49);
            this.comboBoxSearchByStatus.Name = "comboBoxSearchByStatus";
            this.comboBoxSearchByStatus.Size = new System.Drawing.Size(210, 37);
            this.comboBoxSearchByStatus.TabIndex = 5;
            this.comboBoxSearchByStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchByStatus_SelectedIndexChanged);
            this.comboBoxSearchByStatus.SelectedValueChanged += new System.EventHandler(this.comboBoxSearchByStatus_SelectedValueChanged);
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 537);
            this.Controls.Add(this.comboBoxSearchByStatus);
            this.Controls.Add(this.materialDataTableInvoicesList);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonAddInvoice);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Invoices";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.Invoices_Load);
            this.Shown += new System.EventHandler(this.Invoices_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.materialDataTableInvoicesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button buttonAddInvoice;
        private TextBox textBoxSearch;
        private MaterialSkin2Framework.Controls.MaterialDataTable materialDataTableInvoicesList;
        private ComboBox comboBoxSearchByStatus;
        private DataGridViewTextBoxColumn Macmiilka;
        private DataGridViewTextBoxColumn duedate;
        private DataGridViewTextBoxColumn InvoiceId;
        private DataGridViewTextBoxColumn CustomerId;
        private DataGridViewTextBoxColumn Telephone;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Taariikh;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn paidAmount;
        private DataGridViewTextBoxColumn Baaqi;
        private DataGridViewButtonColumn EditButton;
        private DataGridViewButtonColumn DeleteButton;
    }
}