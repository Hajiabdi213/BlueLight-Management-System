using System.Drawing;
using System.Windows.Forms;
using MaterialSkin2Framework;

namespace BlueLight_Management_System.UI.Forms
{
    partial class Services
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
            this.materialDataTable1 = new MaterialSkin2Framework.Controls.MaterialDataTable();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.InvoiceServices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textboxServiceName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialDivider1 = new MaterialSkin2Framework.Controls.MaterialDivider();
            this.label2 = new System.Windows.Forms.Label();
            this.labelServiceId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.materialDataTable1)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Services";
            // 
            // materialDataTable1
            // 
            this.materialDataTable1.AllowUserToAddRows = false;
            this.materialDataTable1.AllowUserToDeleteRows = false;
            this.materialDataTable1.AllowUserToResizeRows = false;
            this.materialDataTable1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDataTable1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materialDataTable1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialDataTable1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialDataTable1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.materialDataTable1.CellSelectionPrimaryColor = MaterialSkin2Framework.Primary.Grey50;
            this.materialDataTable1.ColorStripColor = MaterialSkin2Framework.Primary.Grey50;
            this.materialDataTable1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialDataTable1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.materialDataTable1.ColumnHeadersHeight = 56;
            this.materialDataTable1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.materialDataTable1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceName,
            this.Service_Id,
            this.Price,
            this.Description,
            this.StartedAt,
            this.UpdatedAt,
            this.EditButton,
            this.DeleteButton,
            this.InvoiceServices});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.materialDataTable1.DefaultCellStyle = dataGridViewCellStyle4;
            this.materialDataTable1.Depth = 0;
            this.materialDataTable1.EnableHeadersVisualStyles = false;
            this.materialDataTable1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialDataTable1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.materialDataTable1.Location = new System.Drawing.Point(13, 57);
            this.materialDataTable1.Margin = new System.Windows.Forms.Padding(9);
            this.materialDataTable1.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.materialDataTable1.MultiSelect = false;
            this.materialDataTable1.Name = "materialDataTable1";
            this.materialDataTable1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialDataTable1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.materialDataTable1.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDataTable1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.materialDataTable1.RowTemplate.Height = 52;
            this.materialDataTable1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.materialDataTable1.ShowVerticalScroll = false;
            this.materialDataTable1.Size = new System.Drawing.Size(590, 472);
            this.materialDataTable1.TabIndex = 4;
            this.materialDataTable1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.materialDataTable1_CellContentClick);
            // 
            // ServiceName
            // 
            this.ServiceName.DataPropertyName = "ServiceName";
            this.ServiceName.HeaderText = "Service Name";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            // 
            // Service_Id
            // 
            this.Service_Id.DataPropertyName = "Id";
            this.Service_Id.HeaderText = "Service Id";
            this.Service_Id.Name = "Service_Id";
            this.Service_Id.ReadOnly = true;
            this.Service_Id.Visible = false;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price (Shillings)";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // StartedAt
            // 
            this.StartedAt.DataPropertyName = "CreatedAt";
            this.StartedAt.HeaderText = "Started";
            this.StartedAt.Name = "StartedAt";
            this.StartedAt.ReadOnly = true;
            // 
            // UpdatedAt
            // 
            this.UpdatedAt.DataPropertyName = "updatedAt";
            this.UpdatedAt.HeaderText = "Updated";
            this.UpdatedAt.Name = "UpdatedAt";
            this.UpdatedAt.ReadOnly = true;
            // 
            // EditButton
            // 
            this.EditButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EditButton.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            this.EditButton.DefaultCellStyle = dataGridViewCellStyle2;
            this.EditButton.HeaderText = "Edit";
            this.EditButton.Name = "EditButton";
            this.EditButton.ReadOnly = true;
            this.EditButton.Text = "Edit";
            this.EditButton.UseColumnTextForButtonValue = true;
            this.EditButton.Width = 80;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeleteButton.DataPropertyName = "Id";
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
            // InvoiceServices
            // 
            this.InvoiceServices.DataPropertyName = "InvoiceItems";
            this.InvoiceServices.HeaderText = "InvoiceServices";
            this.InvoiceServices.Name = "InvoiceServices";
            this.InvoiceServices.ReadOnly = true;
            this.InvoiceServices.Visible = false;
            // 
            // textboxServiceName
            // 
            this.textboxServiceName.Font = new System.Drawing.Font("Lato", 18F);
            this.textboxServiceName.Location = new System.Drawing.Point(7, 123);
            this.textboxServiceName.Name = "textboxServiceName";
            this.textboxServiceName.Size = new System.Drawing.Size(225, 36);
            this.textboxServiceName.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 18F);
            this.label4.Location = new System.Drawing.Point(7, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Price (Shillings)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 18F);
            this.label5.Location = new System.Drawing.Point(7, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Lato", 18F);
            this.textBoxDescription.Location = new System.Drawing.Point(7, 294);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(225, 152);
            this.textBoxDescription.TabIndex = 18;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Lato", 18F);
            this.buttonClear.Location = new System.Drawing.Point(10, 460);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(114, 45);
            this.buttonClear.TabIndex = 19;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Lato", 18F);
            this.buttonSave.Location = new System.Drawing.Point(131, 460);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(114, 45);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.materialDivider1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelServiceId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.textBoxDescription);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textboxServiceName);
            this.panel1.Location = new System.Drawing.Point(614, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 510);
            this.panel1.TabIndex = 5;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(3, 52);
            this.materialDivider1.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(248, 1);
            this.materialDivider1.TabIndex = 24;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(36, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Add Service";
            // 
            // labelServiceId
            // 
            this.labelServiceId.AutoSize = true;
            this.labelServiceId.Location = new System.Drawing.Point(261, 93);
            this.labelServiceId.Name = "labelServiceId";
            this.labelServiceId.Size = new System.Drawing.Size(0, 13);
            this.labelServiceId.TabIndex = 22;
            this.labelServiceId.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 18F);
            this.label3.Location = new System.Drawing.Point(2, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Service Name:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Lato", 18F);
            this.textBoxPrice.Location = new System.Drawing.Point(7, 206);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(225, 36);
            this.textBoxPrice.TabIndex = 16;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Lato", 18F);
            this.textBoxSearch.Location = new System.Drawing.Point(351, 15);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(252, 36);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 537);
            this.Controls.Add(this.materialDataTable1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Services";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.Services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialDataTable1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MaterialSkin2Framework.Controls.MaterialDataTable materialDataTable1;
        private TextBox textboxServiceName;
        private Label label4;
        private Label label5;
        private TextBox textBoxDescription;
        private Button buttonClear;
        private Button buttonSave;
        private Panel panel1;
        private Label label3;
        private Label labelServiceId;
        private MaterialSkin2Framework.Controls.MaterialDivider materialDivider1;
        private Label label2;
        private DataGridViewTextBoxColumn ServiceName;
        private DataGridViewTextBoxColumn Service_Id;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn StartedAt;
        private DataGridViewTextBoxColumn UpdatedAt;
        private DataGridViewButtonColumn EditButton;
        private DataGridViewButtonColumn DeleteButton;
        private DataGridViewTextBoxColumn InvoiceServices;
        private TextBox textBoxSearch;
        private ErrorProvider errorProvider1;
        private TextBox textBoxPrice;
    }
}