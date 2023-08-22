using System.Drawing;
using System.Windows.Forms;

namespace BlueLight_Management_System.UI.Forms
{
    partial class Edit_Invoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Invoice));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonSaveWithPrint = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialDataTable1 = new MaterialSkin2Framework.Controls.MaterialDataTable();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxShowBaaqi = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxShowPaidAmount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxShowTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxShowDiscount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxShowSubTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPaidAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.Services = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataTable1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonSaveWithPrint);
            this.groupBox5.Controls.Add(this.buttonSave);
            this.groupBox5.Font = new System.Drawing.Font("Lato Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox5.Location = new System.Drawing.Point(787, 392);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(213, 178);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Actions";
            // 
            // buttonSaveWithPrint
            // 
            this.buttonSaveWithPrint.BackColor = System.Drawing.Color.White;
            this.buttonSaveWithPrint.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonSaveWithPrint.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSaveWithPrint.Location = new System.Drawing.Point(6, 112);
            this.buttonSaveWithPrint.Name = "buttonSaveWithPrint";
            this.buttonSaveWithPrint.Size = new System.Drawing.Size(201, 36);
            this.buttonSaveWithPrint.TabIndex = 13;
            this.buttonSaveWithPrint.Text = "Daabac";
            this.buttonSaveWithPrint.UseVisualStyleBackColor = false;
            this.buttonSaveWithPrint.Click += new System.EventHandler(this.buttonSaveWithPrint_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonSave.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(10, 55);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(201, 36);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Update";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialDataTable1);
            this.groupBox2.Font = new System.Drawing.Font("Lato Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox2.Location = new System.Drawing.Point(10, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(989, 346);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Service";
            // 
            // materialDataTable1
            // 
            this.materialDataTable1.AllowUserToAddRows = false;
            this.materialDataTable1.AllowUserToDeleteRows = false;
            this.materialDataTable1.AllowUserToResizeRows = false;
            this.materialDataTable1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materialDataTable1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialDataTable1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialDataTable1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.materialDataTable1.CellSelectionPrimaryColor = MaterialSkin2Framework.Primary.Teal900;
            this.materialDataTable1.ColorStripColor = MaterialSkin2Framework.Primary.Cyan900;
            this.materialDataTable1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialDataTable1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.materialDataTable1.ColumnHeadersHeight = 56;
            this.materialDataTable1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.materialDataTable1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Services,
            this.Quantity,
            this.Price,
            this.Total,
            this.DueDate,
            this.InvoiceItemId,
            this.InvoiceId});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.materialDataTable1.DefaultCellStyle = dataGridViewCellStyle6;
            this.materialDataTable1.Depth = 0;
            this.materialDataTable1.EnableHeadersVisualStyles = false;
            this.materialDataTable1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialDataTable1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.materialDataTable1.Location = new System.Drawing.Point(9, 25);
            this.materialDataTable1.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.materialDataTable1.Name = "materialDataTable1";
            this.materialDataTable1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialDataTable1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.materialDataTable1.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDataTable1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.materialDataTable1.RowTemplate.Height = 52;
            this.materialDataTable1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.materialDataTable1.ShowVerticalScroll = false;
            this.materialDataTable1.Size = new System.Drawing.Size(975, 303);
            this.materialDataTable1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(410, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Edit Invoice";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxShowBaaqi);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.textBoxShowPaidAmount);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.textBoxShowTotal);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.textBoxShowDiscount);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.textBoxShowSubTotal);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Font = new System.Drawing.Font("Lato Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox4.Location = new System.Drawing.Point(362, 392);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 178);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Xogta Lacagta";
            // 
            // textBoxShowBaaqi
            // 
            this.textBoxShowBaaqi.Font = new System.Drawing.Font("Lato Black", 12F);
            this.textBoxShowBaaqi.Location = new System.Drawing.Point(100, 137);
            this.textBoxShowBaaqi.Name = "textBoxShowBaaqi";
            this.textBoxShowBaaqi.ReadOnly = true;
            this.textBoxShowBaaqi.Size = new System.Drawing.Size(154, 27);
            this.textBoxShowBaaqi.TabIndex = 27;
            this.textBoxShowBaaqi.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(5, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 19);
            this.label17.TabIndex = 26;
            this.label17.Text = "Baaqi:";
            // 
            // textBoxShowPaidAmount
            // 
            this.textBoxShowPaidAmount.Font = new System.Drawing.Font("Lato Black", 12F);
            this.textBoxShowPaidAmount.Location = new System.Drawing.Point(100, 108);
            this.textBoxShowPaidAmount.Name = "textBoxShowPaidAmount";
            this.textBoxShowPaidAmount.ReadOnly = true;
            this.textBoxShowPaidAmount.Size = new System.Drawing.Size(154, 27);
            this.textBoxShowPaidAmount.TabIndex = 25;
            this.textBoxShowPaidAmount.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(5, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 19);
            this.label16.TabIndex = 24;
            this.label16.Text = "La Bixiyay:";
            // 
            // textBoxShowTotal
            // 
            this.textBoxShowTotal.Font = new System.Drawing.Font("Lato Black", 12F);
            this.textBoxShowTotal.Location = new System.Drawing.Point(100, 80);
            this.textBoxShowTotal.Name = "textBoxShowTotal";
            this.textBoxShowTotal.ReadOnly = true;
            this.textBoxShowTotal.Size = new System.Drawing.Size(154, 27);
            this.textBoxShowTotal.TabIndex = 23;
            this.textBoxShowTotal.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(5, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 19);
            this.label14.TabIndex = 22;
            this.label14.Text = "La Rabo:";
            // 
            // textBoxShowDiscount
            // 
            this.textBoxShowDiscount.Font = new System.Drawing.Font("Lato Black", 12F);
            this.textBoxShowDiscount.Location = new System.Drawing.Point(100, 51);
            this.textBoxShowDiscount.Name = "textBoxShowDiscount";
            this.textBoxShowDiscount.ReadOnly = true;
            this.textBoxShowDiscount.Size = new System.Drawing.Size(154, 27);
            this.textBoxShowDiscount.TabIndex = 21;
            this.textBoxShowDiscount.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(5, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 19);
            this.label13.TabIndex = 20;
            this.label13.Text = "Discount:";
            // 
            // textBoxShowSubTotal
            // 
            this.textBoxShowSubTotal.Font = new System.Drawing.Font("Lato Black", 12F);
            this.textBoxShowSubTotal.Location = new System.Drawing.Point(100, 23);
            this.textBoxShowSubTotal.Name = "textBoxShowSubTotal";
            this.textBoxShowSubTotal.ReadOnly = true;
            this.textBoxShowSubTotal.Size = new System.Drawing.Size(154, 27);
            this.textBoxShowSubTotal.TabIndex = 19;
            this.textBoxShowSubTotal.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(5, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 19);
            this.label15.TabIndex = 18;
            this.label15.Text = "Total:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxDiscount);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.comboBoxPaymentMethod);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxPaidAmount);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Lato Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox3.Location = new System.Drawing.Point(10, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 178);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lacag Bixin";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Font = new System.Drawing.Font("Lato Black", 12F);
            this.textBoxDiscount.Location = new System.Drawing.Point(5, 145);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.ReadOnly = true;
            this.textBoxDiscount.Size = new System.Drawing.Size(154, 27);
            this.textBoxDiscount.TabIndex = 23;
            this.textBoxDiscount.Text = "0";
            this.textBoxDiscount.TextChanged += new System.EventHandler(this.textBoxDiscount_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(5, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 19);
            this.label12.TabIndex = 22;
            this.label12.Text = "Discount:";
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.Font = new System.Drawing.Font("Lato", 12F);
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Items.AddRange(new object[] {
            "ZAAD",
            "EDAHAB",
            "KAASH-PLUS",
            "CASH"});
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(5, 94);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(154, 27);
            this.comboBoxPaymentMethod.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(5, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Waxa Lagu Bixiyay:";
            // 
            // textBoxPaidAmount
            // 
            this.textBoxPaidAmount.Font = new System.Drawing.Font("Lato Black", 12F);
            this.textBoxPaidAmount.Location = new System.Drawing.Point(5, 42);
            this.textBoxPaidAmount.Name = "textBoxPaidAmount";
            this.textBoxPaidAmount.Size = new System.Drawing.Size(154, 27);
            this.textBoxPaidAmount.TabIndex = 19;
            this.textBoxPaidAmount.Text = "0";
            this.textBoxPaidAmount.TextChanged += new System.EventHandler(this.textBoxPaidAmount_TextChanged);
            this.textBoxPaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPaidAmount_KeyPress);
            this.textBoxPaidAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPaidAmount_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(5, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Lacagta La Bixiyay:";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            this.printPreviewDialog1.DoubleClick += new System.EventHandler(this.printPreviewDialog1_DoubleClick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Services
            // 
            this.Services.DataPropertyName = "serviceName";
            this.Services.HeaderText = "Adeega";
            this.Services.Name = "Services";
            this.Services.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "quantity";
            this.Quantity.HeaderText = "Tirada";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "price";
            this.Price.HeaderText = "Qiimaha";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // DueDate
            // 
            this.DueDate.DataPropertyName = "dueDate";
            this.DueDate.HeaderText = "Waqtiga La Rabo";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            // 
            // InvoiceItemId
            // 
            this.InvoiceItemId.DataPropertyName = "invoiceItemId";
            this.InvoiceItemId.HeaderText = "InvoiceItemId";
            this.InvoiceItemId.Name = "InvoiceItemId";
            this.InvoiceItemId.ReadOnly = true;
            this.InvoiceItemId.Visible = false;
            // 
            // InvoiceId
            // 
            this.InvoiceId.DataPropertyName = "invoiceId";
            this.InvoiceId.HeaderText = "InvoiceId";
            this.InvoiceId.Name = "InvoiceId";
            this.InvoiceId.ReadOnly = true;
            this.InvoiceId.Visible = false;
            // 
            // Edit_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 578);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edit_Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Edit_Invoice_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialDataTable1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox5;
        private Button buttonSaveWithPrint;
        private Button buttonSave;
        private GroupBox groupBox2;
        private MaterialSkin2Framework.Controls.MaterialDataTable materialDataTable1;
        private Label label1;
        private GroupBox groupBox4;
        private TextBox textBoxShowBaaqi;
        private Label label17;
        private TextBox textBoxShowPaidAmount;
        private Label label16;
        private TextBox textBoxShowTotal;
        private Label label14;
        private TextBox textBoxShowDiscount;
        private Label label13;
        private TextBox textBoxShowSubTotal;
        private Label label15;
        private GroupBox groupBox3;
        private TextBox textBoxDiscount;
        private Label label12;
        private ComboBox comboBoxPaymentMethod;
        private Label label9;
        private TextBox textBoxPaidAmount;
        private Label label8;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private DataGridViewTextBoxColumn Services;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn DueDate;
        private DataGridViewTextBoxColumn InvoiceItemId;
        private DataGridViewTextBoxColumn InvoiceId;
    }
}