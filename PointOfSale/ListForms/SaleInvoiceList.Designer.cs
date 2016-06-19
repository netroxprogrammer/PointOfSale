namespace PointOfSale.ListForms
{
    partial class SaleInvoiceList
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
            this.saleInvoiceList_Data_listView = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaleInvoiceList_contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchByDate = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ToDatePiker = new System.Windows.Forms.DateTimePicker();
            this.FromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.emplye_customer_group = new System.Windows.Forms.GroupBox();
            this.customer_comboBox = new System.Windows.Forms.ComboBox();
            this.payment = new System.Windows.Forms.GroupBox();
            this.payement_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saleList_Search_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Sale_List_Total_Balance_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaleList_Total_Paid_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaleInvoiceList_contextMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SearchByDate.SuspendLayout();
            this.emplye_customer_group.SuspendLayout();
            this.payment.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saleInvoiceList_Data_listView
            // 
            this.saleInvoiceList_Data_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader1});
            this.saleInvoiceList_Data_listView.ContextMenuStrip = this.SaleInvoiceList_contextMenu;
            this.saleInvoiceList_Data_listView.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleInvoiceList_Data_listView.FullRowSelect = true;
            this.saleInvoiceList_Data_listView.GridLines = true;
            this.saleInvoiceList_Data_listView.LabelEdit = true;
            this.saleInvoiceList_Data_listView.Location = new System.Drawing.Point(-1, 120);
            this.saleInvoiceList_Data_listView.Name = "saleInvoiceList_Data_listView";
            this.saleInvoiceList_Data_listView.Size = new System.Drawing.Size(949, 474);
            this.saleInvoiceList_Data_listView.TabIndex = 0;
            this.saleInvoiceList_Data_listView.UseCompatibleStateImageBehavior = false;
            this.saleInvoiceList_Data_listView.View = System.Windows.Forms.View.Details;
            this.saleInvoiceList_Data_listView.SelectedIndexChanged += new System.EventHandler(this.saleInvoiceList_Data_listView_SelectedIndexChanged);
            this.saleInvoiceList_Data_listView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saleInvoiceList_Data_listView_MouseClick);
            this.saleInvoiceList_Data_listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.saleInvoiceList_Data_listView_MouseDoubleClick);
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Inv. No";
            this.columnHeader12.Width = 98;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Date";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Payment Mode";
            this.columnHeader14.Width = 81;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Discount";
            this.columnHeader15.Width = 100;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "NetAmount";
            this.columnHeader16.Width = 100;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "paid Amt";
            this.columnHeader17.Width = 100;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Balance";
            this.columnHeader18.Width = 100;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "User Name";
            this.columnHeader19.Width = 114;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Description";
            // 
            // SaleInvoiceList_contextMenu
            // 
            this.SaleInvoiceList_contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.viewReportToolStripMenuItem});
            this.SaleInvoiceList_contextMenu.Name = "SaleInvoiceList_contextMenu";
            this.SaleInvoiceList_contextMenu.Size = new System.Drawing.Size(138, 48);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // viewReportToolStripMenuItem
            // 
            this.viewReportToolStripMenuItem.Name = "viewReportToolStripMenuItem";
            this.viewReportToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.viewReportToolStripMenuItem.Text = "View Report";
            this.viewReportToolStripMenuItem.Click += new System.EventHandler(this.viewReportToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchByDate);
            this.groupBox1.Controls.Add(this.emplye_customer_group);
            this.groupBox1.Controls.Add(this.payment);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.saleList_Search_comboBox);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(923, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Panel";
            // 
            // SearchByDate
            // 
            this.SearchByDate.Controls.Add(this.button1);
            this.SearchByDate.Controls.Add(this.label5);
            this.SearchByDate.Controls.Add(this.label4);
            this.SearchByDate.Controls.Add(this.ToDatePiker);
            this.SearchByDate.Controls.Add(this.FromDatePicker);
            this.SearchByDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SearchByDate.Location = new System.Drawing.Point(650, 20);
            this.SearchByDate.Name = "SearchByDate";
            this.SearchByDate.Size = new System.Drawing.Size(267, 63);
            this.SearchByDate.TabIndex = 7;
            this.SearchByDate.TabStop = false;
            this.SearchByDate.Text = "Search By Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "From";
            // 
            // ToDatePiker
            // 
            this.ToDatePiker.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDatePiker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDatePiker.Location = new System.Drawing.Point(118, 34);
            this.ToDatePiker.Name = "ToDatePiker";
            this.ToDatePiker.Size = new System.Drawing.Size(70, 21);
            this.ToDatePiker.TabIndex = 1;
            // 
            // FromDatePicker
            // 
            this.FromDatePicker.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDatePicker.Location = new System.Drawing.Point(6, 34);
            this.FromDatePicker.Name = "FromDatePicker";
            this.FromDatePicker.Size = new System.Drawing.Size(97, 21);
            this.FromDatePicker.TabIndex = 0;
            // 
            // emplye_customer_group
            // 
            this.emplye_customer_group.Controls.Add(this.customer_comboBox);
            this.emplye_customer_group.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emplye_customer_group.ForeColor = System.Drawing.Color.Blue;
            this.emplye_customer_group.Location = new System.Drawing.Point(254, 22);
            this.emplye_customer_group.Name = "emplye_customer_group";
            this.emplye_customer_group.Size = new System.Drawing.Size(197, 61);
            this.emplye_customer_group.TabIndex = 6;
            this.emplye_customer_group.TabStop = false;
            this.emplye_customer_group.Text = "Customer/Emplyee";
            // 
            // customer_comboBox
            // 
            this.customer_comboBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_comboBox.FormattingEnabled = true;
            this.customer_comboBox.Items.AddRange(new object[] {
            "cash",
            "credit"});
            this.customer_comboBox.Location = new System.Drawing.Point(22, 22);
            this.customer_comboBox.Name = "customer_comboBox";
            this.customer_comboBox.Size = new System.Drawing.Size(146, 23);
            this.customer_comboBox.TabIndex = 5;
            this.customer_comboBox.Text = "  << Select  Customer";
            this.customer_comboBox.SelectedIndexChanged += new System.EventHandler(this.customer_comboBox_SelectedIndexChanged);
            // 
            // payment
            // 
            this.payment.Controls.Add(this.payement_comboBox1);
            this.payment.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.ForeColor = System.Drawing.Color.Blue;
            this.payment.Location = new System.Drawing.Point(457, 22);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(187, 61);
            this.payment.TabIndex = 4;
            this.payment.TabStop = false;
            this.payment.Text = "payment";
            // 
            // payement_comboBox1
            // 
            this.payement_comboBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payement_comboBox1.FormattingEnabled = true;
            this.payement_comboBox1.Items.AddRange(new object[] {
            "cash",
            "credit"});
            this.payement_comboBox1.Location = new System.Drawing.Point(22, 22);
            this.payement_comboBox1.Name = "payement_comboBox1";
            this.payement_comboBox1.Size = new System.Drawing.Size(146, 23);
            this.payement_comboBox1.TabIndex = 5;
            this.payement_comboBox1.Text = "  << Select  Peyment>>";
            this.payement_comboBox1.SelectedIndexChanged += new System.EventHandler(this.payement_comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Category";
            // 
            // saleList_Search_comboBox
            // 
            this.saleList_Search_comboBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleList_Search_comboBox.FormattingEnabled = true;
            this.saleList_Search_comboBox.Items.AddRange(new object[] {
            "Customer",
            "Employee",
            "Date",
            "paymentType"});
            this.saleList_Search_comboBox.Location = new System.Drawing.Point(102, 41);
            this.saleList_Search_comboBox.Name = "saleList_Search_comboBox";
            this.saleList_Search_comboBox.Size = new System.Drawing.Size(146, 23);
            this.saleList_Search_comboBox.TabIndex = 0;
            this.saleList_Search_comboBox.Text = "  << Select Category>>";
            this.saleList_Search_comboBox.SelectedIndexChanged += new System.EventHandler(this.saleList_Search_comboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Sale_List_Total_Balance_textBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.SaleList_Total_Paid_textBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 600);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 70);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total";
            // 
            // Sale_List_Total_Balance_textBox
            // 
            this.Sale_List_Total_Balance_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Sale_List_Total_Balance_textBox.Location = new System.Drawing.Point(453, 32);
            this.Sale_List_Total_Balance_textBox.Name = "Sale_List_Total_Balance_textBox";
            this.Sale_List_Total_Balance_textBox.ReadOnly = true;
            this.Sale_List_Total_Balance_textBox.Size = new System.Drawing.Size(133, 26);
            this.Sale_List_Total_Balance_textBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total  Balnace:";
            // 
            // SaleList_Total_Paid_textBox
            // 
            this.SaleList_Total_Paid_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SaleList_Total_Paid_textBox.Location = new System.Drawing.Point(144, 32);
            this.SaleList_Total_Paid_textBox.Name = "SaleList_Total_Paid_textBox";
            this.SaleList_Total_Paid_textBox.ReadOnly = true;
            this.SaleList_Total_Paid_textBox.Size = new System.Drawing.Size(133, 26);
            this.SaleList_Total_Paid_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Paid:";
            // 
            // SaleInvoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 682);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saleInvoiceList_Data_listView);
            this.MaximizeBox = false;
            this.Name = "SaleInvoiceList";
            this.Text = "SaleInvoiceList";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SaleInvoiceList_FormClosed);
            this.Load += new System.EventHandler(this.SaleInvoiceList_Load);
            this.SaleInvoiceList_contextMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SearchByDate.ResumeLayout(false);
            this.SearchByDate.PerformLayout();
            this.emplye_customer_group.ResumeLayout(false);
            this.payment.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView saleInvoiceList_Data_listView;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox saleList_Search_comboBox;
        private System.Windows.Forms.GroupBox payment;
        private System.Windows.Forms.ComboBox payement_comboBox1;
        private System.Windows.Forms.GroupBox emplye_customer_group;
        private System.Windows.Forms.ComboBox customer_comboBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ContextMenuStrip SaleInvoiceList_contextMenu;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SaleList_Total_Paid_textBox;
        private System.Windows.Forms.TextBox Sale_List_Total_Balance_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox SearchByDate;
        private System.Windows.Forms.DateTimePicker FromDatePicker;
        private System.Windows.Forms.DateTimePicker ToDatePiker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}