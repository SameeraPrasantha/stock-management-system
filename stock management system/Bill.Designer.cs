
namespace stock_management_system
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.btnMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtBill = new System.Windows.Forms.DateTimePicker();
            this.lblBillNumber = new System.Windows.Forms.Label();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warranty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.lblSN = new System.Windows.Forms.Label();
            this.cmbSelectItem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtWarranty = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(77, 32);
            this.btnMenu.TabIndex = 17;
            this.btnMenu.Text = "Main Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(344, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Make a Bill";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(59, 101);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "Date";
            // 
            // dtBill
            // 
            this.dtBill.Enabled = false;
            this.dtBill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBill.Location = new System.Drawing.Point(98, 98);
            this.dtBill.Name = "dtBill";
            this.dtBill.Size = new System.Drawing.Size(90, 20);
            this.dtBill.TabIndex = 19;
            // 
            // lblBillNumber
            // 
            this.lblBillNumber.AutoSize = true;
            this.lblBillNumber.ForeColor = System.Drawing.Color.White;
            this.lblBillNumber.Location = new System.Drawing.Point(214, 101);
            this.lblBillNumber.Name = "lblBillNumber";
            this.lblBillNumber.Size = new System.Drawing.Size(60, 13);
            this.lblBillNumber.TabIndex = 20;
            this.lblBillNumber.Text = "Bill Number";
            // 
            // txtBillNo
            // 
            this.txtBillNo.Location = new System.Drawing.Point(280, 98);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(125, 20);
            this.txtBillNo.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(296, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Quantity";
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ItemNames,
            this.BillNumber,
            this.SN,
            this.QTY,
            this.Warranty,
            this.Price});
            this.dataTable.Location = new System.Drawing.Point(98, 190);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(714, 212);
            this.dataTable.TabIndex = 26;
            this.dataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellContentClick);
            this.dataTable.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataTable_CellValidating);
            this.dataTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellValueChanged);
            this.dataTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataTable_KeyDown);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 46;
            // 
            // ItemNames
            // 
            this.ItemNames.HeaderText = "Item Name";
            this.ItemNames.Name = "ItemNames";
            // 
            // BillNumber
            // 
            this.BillNumber.HeaderText = "Bill Number";
            this.BillNumber.Name = "BillNumber";
            this.BillNumber.ReadOnly = true;
            // 
            // SN
            // 
            this.SN.HeaderText = "Serial Number";
            this.SN.Name = "SN";
            // 
            // QTY
            // 
            this.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            this.QTY.Width = 54;
            // 
            // Warranty
            // 
            this.Warranty.HeaderText = "Warranty";
            this.Warranty.Name = "Warranty";
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(401, 459);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 32);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(687, 408);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(125, 20);
            this.txtSum.TabIndex = 29;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(650, 411);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.Text = "Total";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(530, 459);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(77, 32);
            this.btnPrint.TabIndex = 30;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.ForeColor = System.Drawing.Color.White;
            this.lblCustomer.Location = new System.Drawing.Point(59, 147);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(82, 13);
            this.lblCustomer.TabIndex = 32;
            this.lblCustomer.Text = "Customer Name";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(147, 143);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(127, 21);
            this.cmbCustomer.TabIndex = 33;
            this.cmbCustomer.Click += new System.EventHandler(this.cmbCustomer_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(801, 84);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(77, 32);
            this.btnSubmit.TabIndex = 35;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(801, 128);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 32);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(636, 144);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(92, 20);
            this.txtPrice.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(599, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Price";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(265, 459);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(77, 32);
            this.btnNew.TabIndex = 40;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.button7_Click);
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.AutoSize = true;
            this.lblItemNumber.ForeColor = System.Drawing.Color.White;
            this.lblItemNumber.Location = new System.Drawing.Point(633, 12);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(67, 13);
            this.lblItemNumber.TabIndex = 42;
            this.lblItemNumber.Text = "Item Number";
            this.lblItemNumber.Visible = false;
            this.lblItemNumber.TextChanged += new System.EventHandler(this.lblItemNumber_TextChanged);
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.ForeColor = System.Drawing.Color.White;
            this.lblSN.Location = new System.Drawing.Point(633, 38);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(73, 13);
            this.lblSN.TabIndex = 41;
            this.lblSN.Text = "Serial Number";
            this.lblSN.Visible = false;
            // 
            // cmbSelectItem
            // 
            this.cmbSelectItem.FormattingEnabled = true;
            this.cmbSelectItem.Location = new System.Drawing.Point(486, 97);
            this.cmbSelectItem.Name = "cmbSelectItem";
            this.cmbSelectItem.Size = new System.Drawing.Size(242, 21);
            this.cmbSelectItem.TabIndex = 44;
            this.cmbSelectItem.SelectionChangeCommitted += new System.EventHandler(this.cmbSelectItem_SelectionChangeCommitted);
            this.cmbSelectItem.SelectedValueChanged += new System.EventHandler(this.cmbSelectItem_SelectedValueChanged);
            this.cmbSelectItem.TextChanged += new System.EventHandler(this.cmbSelectItem_TextChanged);
            this.cmbSelectItem.Click += new System.EventHandler(this.cmbSelectItem_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(420, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Select Item";
            // 
            // txtQTY
            // 
            this.txtQTY.Location = new System.Drawing.Point(349, 143);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.ReadOnly = true;
            this.txtQTY.Size = new System.Drawing.Size(27, 20);
            this.txtQTY.TabIndex = 46;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.ForeColor = System.Drawing.Color.White;
            this.lblItemName.Location = new System.Drawing.Point(633, 65);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(58, 13);
            this.lblItemName.TabIndex = 47;
            this.lblItemName.Text = "Item Name";
            this.lblItemName.Visible = false;
            // 
            // txtWarranty
            // 
            this.txtWarranty.FormattingEnabled = true;
            this.txtWarranty.Items.AddRange(new object[] {
            "1 - Month",
            "3 - Month",
            "6 - Month",
            "1 - Year",
            "2 - Year"});
            this.txtWarranty.Location = new System.Drawing.Point(454, 143);
            this.txtWarranty.Name = "txtWarranty";
            this.txtWarranty.Size = new System.Drawing.Size(127, 21);
            this.txtWarranty.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(398, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Warranty";
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreview
            // 
            this.printPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreview.Document = this.printDocument;
            this.printPreview.Enabled = true;
            this.printPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreview.Icon")));
            this.printPreview.Name = "printPreview";
            this.printPreview.Visible = false;
            // 
            // logo
            // 
            this.logo.Image = global::stock_management_system.Properties.Resources.stock_management_system;
            this.logo.Location = new System.Drawing.Point(12, 391);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(101, 100);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 50;
            this.logo.TabStop = false;
            this.logo.Visible = false;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(909, 503);
            this.ControlBox = false;
            this.Controls.Add(this.logo);
            this.Controls.Add(this.txtWarranty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtQTY);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbSelectItem);
            this.Controls.Add(this.lblItemNumber);
            this.Controls.Add(this.lblSN);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBillNo);
            this.Controls.Add(this.lblBillNumber);
            this.Controls.Add(this.dtBill);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtBill;
        private System.Windows.Forms.Label lblBillNumber;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNew;
        public System.Windows.Forms.Label lblItemNumber;
        public System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.ComboBox cmbSelectItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQTY;
        public System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.ComboBox txtWarranty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warranty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreview;
        private System.Windows.Forms.PictureBox logo;
    }
}