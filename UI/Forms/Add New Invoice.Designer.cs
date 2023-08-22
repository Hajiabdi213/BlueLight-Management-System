using System.Drawing;
using System.Windows.Forms;

namespace BlueLight_Management_System.UI.Forms
{
    partial class Add_New_Invoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_New_Invoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxSearchCustomer = new System.Windows.Forms.TextBox();
            this.buttonSearchCustomerAndFill = new System.Windows.Forms.Button();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddNewCustomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.labeldd = new System.Windows.Forms.Label();
            this.materialDataTable1 = new MaterialSkin2Framework.Controls.MaterialDataTable();
            this.labelq = new System.Windows.Forms.Label();
            this.comboBoxServices = new System.Windows.Forms.ComboBox();
            this.labelcs = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPaidAmount = new System.Windows.Forms.TextBox();
            this.labelp = new System.Windows.Forms.Label();
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSaveAndPrint = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.buttonSaveCustomer = new System.Windows.Forms.Button();
            this.Services = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataTable1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(398, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add New Invoice";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSaveCustomer);
            this.groupBox1.Controls.Add(this.maskedTextBoxSearchCustomer);
            this.groupBox1.Controls.Add(this.buttonSearchCustomerAndFill);
            this.groupBox1.Controls.Add(this.textBoxTelephone);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Controls.Add(this.textBoxCustomerId);
            this.groupBox1.Controls.Add(this.labelTelephone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonAddNewCustomer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Lato Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.Location = new System.Drawing.Point(10, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(989, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Macmiilka";
            // 
            // maskedTextBoxSearchCustomer
            // 
            this.maskedTextBoxSearchCustomer.Location = new System.Drawing.Point(5, 47);
            this.maskedTextBoxSearchCustomer.Name = "maskedTextBoxSearchCustomer";
            this.maskedTextBoxSearchCustomer.Size = new System.Drawing.Size(174, 27);
            this.maskedTextBoxSearchCustomer.TabIndex = 23;
            this.maskedTextBoxSearchCustomer.TextChanged += new System.EventHandler(this.maskedTextBoxSearchCustomer_TextChanged);
            this.maskedTextBoxSearchCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxSearchCustomer_KeyPress);
            // 
            // buttonSearchCustomerAndFill
            // 
            this.buttonSearchCustomerAndFill.BackColor = System.Drawing.Color.White;
            this.buttonSearchCustomerAndFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearchCustomerAndFill.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonSearchCustomerAndFill.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSearchCustomerAndFill.Image = global::BlueLight_Management_System.Properties.Resources._326690_magnify_search_zoom_icon;
            this.buttonSearchCustomerAndFill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchCustomerAndFill.Location = new System.Drawing.Point(185, 45);
            this.buttonSearchCustomerAndFill.Name = "buttonSearchCustomerAndFill";
            this.buttonSearchCustomerAndFill.Padding = new System.Windows.Forms.Padding(3);
            this.buttonSearchCustomerAndFill.Size = new System.Drawing.Size(26, 27);
            this.buttonSearchCustomerAndFill.TabIndex = 22;
            this.toolTip1.SetToolTip(this.buttonSearchCustomerAndFill, "baadh xogta macmiilka");
            this.buttonSearchCustomerAndFill.UseVisualStyleBackColor = false;
            this.buttonSearchCustomerAndFill.Click += new System.EventHandler(this.buttonSearchCustomerAndFill_Click);
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Font = new System.Drawing.Font("Lato Black", 12F);
            this.textBoxTelephone.Location = new System.Drawing.Point(756, 46);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.ReadOnly = true;
            this.textBoxTelephone.Size = new System.Drawing.Size(120, 27);
            this.textBoxTelephone.TabIndex = 20;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Lato Black", 12F);
            this.textBoxLastName.Location = new System.Drawing.Point(612, 46);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(120, 27);
            this.textBoxLastName.TabIndex = 19;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Lato Black", 12F);
            this.textBoxFirstName.Location = new System.Drawing.Point(468, 46);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(120, 27);
            this.textBoxFirstName.TabIndex = 18;
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Font = new System.Drawing.Font("Lato Black", 12F);
            this.textBoxCustomerId.Location = new System.Drawing.Point(374, 46);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.ReadOnly = true;
            this.textBoxCustomerId.Size = new System.Drawing.Size(70, 27);
            this.textBoxCustomerId.TabIndex = 17;
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.labelTelephone.Location = new System.Drawing.Point(756, 25);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(88, 19);
            this.labelTelephone.TabIndex = 16;
            this.labelTelephone.Text = "Telephone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(611, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(462, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(374, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID:";
            // 
            // buttonAddNewCustomer
            // 
            this.buttonAddNewCustomer.BackColor = System.Drawing.Color.White;
            this.buttonAddNewCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonAddNewCustomer.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAddNewCustomer.Location = new System.Drawing.Point(219, 42);
            this.buttonAddNewCustomer.Name = "buttonAddNewCustomer";
            this.buttonAddNewCustomer.Size = new System.Drawing.Size(138, 31);
            this.buttonAddNewCustomer.TabIndex = 11;
            this.buttonAddNewCustomer.Text = "+ Macmiil Cusub";
            this.buttonAddNewCustomer.UseVisualStyleBackColor = false;
            this.buttonAddNewCustomer.Click += new System.EventHandler(this.buttonAddNewCustomer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(5, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Raadi Macmiil:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownQuantity);
            this.groupBox2.Controls.Add(this.dateTimePickerDueDate);
            this.groupBox2.Controls.Add(this.buttonAddItem);
            this.groupBox2.Controls.Add(this.labeldd);
            this.groupBox2.Controls.Add(this.materialDataTable1);
            this.groupBox2.Controls.Add(this.labelq);
            this.groupBox2.Controls.Add(this.comboBoxServices);
            this.groupBox2.Controls.Add(this.labelcs);
            this.groupBox2.Font = new System.Drawing.Font("Lato Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox2.Location = new System.Drawing.Point(10, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(989, 252);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adeegyada:";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Font = new System.Drawing.Font("Lato", 12F);
            this.numericUpDownQuantity.Location = new System.Drawing.Point(9, 100);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(149, 27);
            this.numericUpDownQuantity.TabIndex = 23;
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.CalendarFont = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(5, 152);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(154, 27);
            this.dateTimePickerDueDate.TabIndex = 22;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.BackColor = System.Drawing.Color.White;
            this.buttonAddItem.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonAddItem.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAddItem.Location = new System.Drawing.Point(5, 197);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(99, 28);
            this.buttonAddItem.TabIndex = 21;
            this.buttonAddItem.Text = "Add";
            this.buttonAddItem.UseVisualStyleBackColor = false;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // labeldd
            // 
            this.labeldd.AutoSize = true;
            this.labeldd.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.labeldd.Location = new System.Drawing.Point(5, 133);
            this.labeldd.Name = "labeldd";
            this.labeldd.Size = new System.Drawing.Size(115, 19);
            this.labeldd.TabIndex = 19;
            this.labeldd.Text = "Goorta la rabo:";
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
            this.materialDataTable1.CellSelectionPrimaryColor = MaterialSkin2Framework.Primary.Grey50;
            this.materialDataTable1.ColorStripColor = MaterialSkin2Framework.Primary.Teal900;
            this.materialDataTable1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialDataTable1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.materialDataTable1.ColumnHeadersHeight = 56;
            this.materialDataTable1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.materialDataTable1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Services,
            this.Quantity,
            this.Price,
            this.Total,
            this.DueDate,
            this.editButton,
            this.DeleteButton});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.materialDataTable1.DefaultCellStyle = dataGridViewCellStyle10;
            this.materialDataTable1.Depth = 0;
            this.materialDataTable1.EnableHeadersVisualStyles = false;
            this.materialDataTable1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialDataTable1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.materialDataTable1.Location = new System.Drawing.Point(219, 25);
            this.materialDataTable1.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.materialDataTable1.Name = "materialDataTable1";
            this.materialDataTable1.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialDataTable1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.materialDataTable1.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDataTable1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.materialDataTable1.RowTemplate.Height = 52;
            this.materialDataTable1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.materialDataTable1.ShowVerticalScroll = false;
            this.materialDataTable1.Size = new System.Drawing.Size(770, 222);
            this.materialDataTable1.TabIndex = 18;
            this.materialDataTable1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.materialDataTable1_CellContentClick);
            // 
            // labelq
            // 
            this.labelq.AutoSize = true;
            this.labelq.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.labelq.Location = new System.Drawing.Point(5, 76);
            this.labelq.Name = "labelq";
            this.labelq.Size = new System.Drawing.Size(59, 19);
            this.labelq.TabIndex = 13;
            this.labelq.Text = "Tirada:";
            // 
            // comboBoxServices
            // 
            this.comboBoxServices.Font = new System.Drawing.Font("Lato", 12F);
            this.comboBoxServices.FormattingEnabled = true;
            this.comboBoxServices.Location = new System.Drawing.Point(5, 45);
            this.comboBoxServices.Name = "comboBoxServices";
            this.comboBoxServices.Size = new System.Drawing.Size(210, 27);
            this.comboBoxServices.TabIndex = 12;
            // 
            // labelcs
            // 
            this.labelcs.AutoSize = true;
            this.labelcs.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.labelcs.Location = new System.Drawing.Point(5, 25);
            this.labelcs.Name = "labelcs";
            this.labelcs.Size = new System.Drawing.Size(116, 19);
            this.labelcs.TabIndex = 10;
            this.labelcs.Text = "Nooca Adeega:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxDiscount);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.comboBoxPaymentMethod);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxPaidAmount);
            this.groupBox3.Controls.Add(this.labelp);
            this.groupBox3.Font = new System.Drawing.Font("Lato Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox3.Location = new System.Drawing.Point(10, 390);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 178);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lacag Bixin:";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Font = new System.Drawing.Font("Lato Black", 12F);
            this.textBoxDiscount.Location = new System.Drawing.Point(5, 145);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(154, 27);
            this.textBoxDiscount.TabIndex = 23;
            this.textBoxDiscount.Text = "0";
            this.textBoxDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDiscount_KeyPress);
            this.textBoxDiscount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxDiscount_KeyUp);
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
            this.comboBoxPaymentMethod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxPaymentMethod_KeyDown);
            this.comboBoxPaymentMethod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxPaymentMethod_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(5, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Waxa lagu bixiyay:";
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
            // labelp
            // 
            this.labelp.AutoSize = true;
            this.labelp.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.labelp.Location = new System.Drawing.Point(5, 22);
            this.labelp.Name = "labelp";
            this.labelp.Size = new System.Drawing.Size(137, 19);
            this.labelp.TabIndex = 18;
            this.labelp.Text = "Lacagta la bixiyay:";
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
            this.groupBox4.Location = new System.Drawing.Point(362, 390);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 178);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Xogta Lacagta:";
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
            this.label14.Size = new System.Drawing.Size(65, 19);
            this.label14.TabIndex = 22;
            this.label14.Text = "La rabo:";
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonClear);
            this.groupBox5.Controls.Add(this.buttonSaveAndPrint);
            this.groupBox5.Controls.Add(this.buttonSave);
            this.groupBox5.Font = new System.Drawing.Font("Lato Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox5.Location = new System.Drawing.Point(787, 390);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(213, 178);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "  ";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.White;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonClear.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.buttonClear.Location = new System.Drawing.Point(6, 121);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(199, 36);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Masax";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSaveAndPrint
            // 
            this.buttonSaveAndPrint.BackColor = System.Drawing.Color.White;
            this.buttonSaveAndPrint.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonSaveAndPrint.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSaveAndPrint.Location = new System.Drawing.Point(6, 74);
            this.buttonSaveAndPrint.Name = "buttonSaveAndPrint";
            this.buttonSaveAndPrint.Size = new System.Drawing.Size(199, 36);
            this.buttonSaveAndPrint.TabIndex = 13;
            this.buttonSaveAndPrint.Text = "Daabac";
            this.buttonSaveAndPrint.UseVisualStyleBackColor = false;
            this.buttonSaveAndPrint.Click += new System.EventHandler(this.buttonSaveAndPrint_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonSave.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(6, 26);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(199, 36);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // buttonSaveCustomer
            // 
            this.buttonSaveCustomer.BackColor = System.Drawing.Color.White;
            this.buttonSaveCustomer.Enabled = false;
            this.buttonSaveCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonSaveCustomer.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSaveCustomer.Location = new System.Drawing.Point(900, 46);
            this.buttonSaveCustomer.Name = "buttonSaveCustomer";
            this.buttonSaveCustomer.Size = new System.Drawing.Size(83, 29);
            this.buttonSaveCustomer.TabIndex = 24;
            this.buttonSaveCustomer.Text = "SAVE";
            this.buttonSaveCustomer.UseVisualStyleBackColor = false;
            this.buttonSaveCustomer.Click += new System.EventHandler(this.buttonSaveCustomer_Click);
            // 
            // Services
            // 
            this.Services.HeaderText = "Adeega";
            this.Services.Name = "Services";
            this.Services.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Tirada";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Qiimaha";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Goorta la rabo";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            // 
            // editButton
            // 
            this.editButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10);
            this.editButton.DefaultCellStyle = dataGridViewCellStyle8;
            this.editButton.HeaderText = "Edit";
            this.editButton.Name = "editButton";
            this.editButton.ReadOnly = true;
            this.editButton.Text = "Edit";
            this.editButton.UseColumnTextForButtonValue = true;
            this.editButton.Width = 128;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(10);
            this.DeleteButton.DefaultCellStyle = dataGridViewCellStyle9;
            this.DeleteButton.HeaderText = "Remove";
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseColumnTextForButtonValue = true;
            this.DeleteButton.Width = 127;
            // 
            // Add_New_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 578);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1026, 617);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1026, 617);
            this.Name = "Add_New_Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Add_New_Invoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataTable1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBoxTelephone;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private TextBox textBoxCustomerId;
        private Label labelTelephone;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button buttonAddNewCustomer;
        private Label label2;
        private GroupBox groupBox2;
        private Label labelq;
        private ComboBox comboBoxServices;
        private Label labelcs;
        private MaterialSkin2Framework.Controls.MaterialDataTable materialDataTable1;
        private Button buttonAddItem;
        private Label labeldd;
        private GroupBox groupBox3;
        private DateTimePicker dateTimePickerDueDate;
        private TextBox textBoxDiscount;
        private Label label12;
        private ComboBox comboBoxPaymentMethod;
        private Label label9;
        private TextBox textBoxPaidAmount;
        private Label labelp;
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
        private GroupBox groupBox5;
        private Button buttonClear;
        private Button buttonSaveAndPrint;
        private Button buttonSave;
        private Button buttonSearchCustomerAndFill;

        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private NumericUpDown numericUpDownQuantity;
        private ToolTip toolTip1;
        private TextBox maskedTextBoxSearchCustomer;
        private PrintDialog printDialog1;
        private Button buttonSaveCustomer;
        private DataGridViewTextBoxColumn Services;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn DueDate;
        private DataGridViewButtonColumn editButton;
        private DataGridViewButtonColumn DeleteButton;
    }
}