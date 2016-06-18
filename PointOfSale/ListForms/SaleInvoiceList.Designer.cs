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
            this.emplye_customer_group = new System.Windows.Forms.GroupBox();
            this.customer_comboBox = new System.Windows.Forms.ComboBox();
            this.payment = new System.Windows.Forms.GroupBox();
            this.payement_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saleList_Search_comboBox = new System.Windows.Forms.ComboBox();
            this.SaleInvoiceList_contextMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.emplye_customer_group.SuspendLayout();
            this.payment.SuspendLayout();
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
            this.saleInvoiceList_Data_listView.Size = new System.Drawing.Size(949, 527);
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
            // emplye_customer_group
            // 
            this.emplye_customer_group.Controls.Add(this.customer_comboBox);
            this.emplye_customer_group.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emplye_customer_group.ForeColor = System.Drawing.Color.Blue;
            this.emplye_customer_group.Location = new System.Drawing.Point(267, 22);
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
            this.payment.Location = new System.Drawing.Point(470, 22);
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
            this.label1.Location = new System.Drawing.Point(19, 47);
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
            this.saleList_Search_comboBox.Location = new System.Drawing.Point(115, 41);
            this.saleList_Search_comboBox.Name = "saleList_Search_comboBox";
            this.saleList_Search_comboBox.Size = new System.Drawing.Size(146, 23);
            this.saleList_Search_comboBox.TabIndex = 0;
            this.saleList_Search_comboBox.Text = "  << Select Category>>";
            this.saleList_Search_comboBox.SelectedIndexChanged += new System.EventHandler(this.saleList_Search_comboBox_SelectedIndexChanged);
            // 
            // SaleInvoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 647);
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
            this.emplye_customer_group.ResumeLayout(false);
            this.payment.ResumeLayout(false);
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
    }
}