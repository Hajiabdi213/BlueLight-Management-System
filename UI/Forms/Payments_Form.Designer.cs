using System.Drawing;
using System.Windows.Forms;

namespace BlueLight_Management_System.UI.Forms
{
    partial class Payments_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.materialDataTablePaymentsList = new MaterialSkin2Framework.Controls.MaterialDataTable();
            this.InvoiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baaqi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataTablePaymentsList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payments";
            // 
            // materialDataTablePaymentsList
            // 
            this.materialDataTablePaymentsList.AllowUserToAddRows = false;
            this.materialDataTablePaymentsList.AllowUserToDeleteRows = false;
            this.materialDataTablePaymentsList.AllowUserToResizeRows = false;
            this.materialDataTablePaymentsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDataTablePaymentsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materialDataTablePaymentsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialDataTablePaymentsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialDataTablePaymentsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.materialDataTablePaymentsList.CellSelectionPrimaryColor = MaterialSkin2Framework.Primary.Grey50;
            this.materialDataTablePaymentsList.ColorStripColor = MaterialSkin2Framework.Primary.Grey50;
            this.materialDataTablePaymentsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialDataTablePaymentsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.materialDataTablePaymentsList.ColumnHeadersHeight = 56;
            this.materialDataTablePaymentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.materialDataTablePaymentsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceId,
            this.Telephone,
            this.Customer,
            this.Date,
            this.PaymentMethod,
            this.Amount,
            this.Baaqi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.materialDataTablePaymentsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.materialDataTablePaymentsList.Depth = 0;
            this.materialDataTablePaymentsList.EnableHeadersVisualStyles = false;
            this.materialDataTablePaymentsList.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialDataTablePaymentsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.materialDataTablePaymentsList.Location = new System.Drawing.Point(11, 74);
            this.materialDataTablePaymentsList.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.materialDataTablePaymentsList.MultiSelect = false;
            this.materialDataTablePaymentsList.Name = "materialDataTablePaymentsList";
            this.materialDataTablePaymentsList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialDataTablePaymentsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.materialDataTablePaymentsList.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDataTablePaymentsList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.materialDataTablePaymentsList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.AliceBlue;
            this.materialDataTablePaymentsList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.materialDataTablePaymentsList.RowTemplate.Height = 52;
            this.materialDataTablePaymentsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.materialDataTablePaymentsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.materialDataTablePaymentsList.ShowVerticalScroll = false;
            this.materialDataTablePaymentsList.Size = new System.Drawing.Size(852, 459);
            this.materialDataTablePaymentsList.TabIndex = 5;
            this.materialDataTablePaymentsList.SizeChanged += new System.EventHandler(this.materialDataTablePaymentsList_SizeChanged);
            // 
            // InvoiceId
            // 
            this.InvoiceId.DataPropertyName = "invoiceNumber";
            this.InvoiceId.HeaderText = "Invoice Number";
            this.InvoiceId.Name = "InvoiceId";
            this.InvoiceId.ReadOnly = true;
            // 
            // Telephone
            // 
            this.Telephone.DataPropertyName = "telephone";
            this.Telephone.HeaderText = "Phone";
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            this.Telephone.Visible = false;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "customerName";
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "paymentDate";
            this.Date.HeaderText = "Payment Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.DataPropertyName = "paymentMethod";
            this.PaymentMethod.HeaderText = "Payment Method";
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "amount";
            this.Amount.HeaderText = "Paid Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Baaqi
            // 
            this.Baaqi.DataPropertyName = "baaqi";
            this.Baaqi.HeaderText = "Baaqi";
            this.Baaqi.Name = "Baaqi";
            this.Baaqi.ReadOnly = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Lato", 18F);
            this.textBoxSearch.Location = new System.Drawing.Point(605, 14);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(258, 36);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyUp);
            // 
            // Payments_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 537);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.materialDataTablePaymentsList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payments_Form";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Payments_Form_Load);
            this.Shown += new System.EventHandler(this.Payments_Form_Shown);
            this.SizeChanged += new System.EventHandler(this.Payments_Form_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.materialDataTablePaymentsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MaterialSkin2Framework.Controls.MaterialDataTable materialDataTablePaymentsList;
        private TextBox textBoxSearch;
        private DataGridViewTextBoxColumn InvoiceId;
        private DataGridViewTextBoxColumn Telephone;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn PaymentMethod;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Baaqi;
    }
}