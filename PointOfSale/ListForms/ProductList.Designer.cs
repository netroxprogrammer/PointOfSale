namespace PointOfSale.ListForms
{
    partial class ProductList
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
            this.WorkingForm_AllProduct_listView = new System.Windows.Forms.ListView();
            this.Product_contextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inactiveProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.choice = new System.Windows.Forms.GroupBox();
            this.Select_Search_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Serach_Product_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseDate = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Product_contextStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.choice.SuspendLayout();
            this.chooseDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkingForm_AllProduct_listView
            // 
            this.WorkingForm_AllProduct_listView.AllowDrop = true;
            this.WorkingForm_AllProduct_listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorkingForm_AllProduct_listView.ContextMenuStrip = this.Product_contextStrip;
            this.WorkingForm_AllProduct_listView.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkingForm_AllProduct_listView.FullRowSelect = true;
            this.WorkingForm_AllProduct_listView.GridLines = true;
            this.WorkingForm_AllProduct_listView.Location = new System.Drawing.Point(-1, 98);
            this.WorkingForm_AllProduct_listView.Name = "WorkingForm_AllProduct_listView";
            this.WorkingForm_AllProduct_listView.Size = new System.Drawing.Size(960, 512);
            this.WorkingForm_AllProduct_listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.WorkingForm_AllProduct_listView.TabIndex = 1;
            this.WorkingForm_AllProduct_listView.UseCompatibleStateImageBehavior = false;
            this.WorkingForm_AllProduct_listView.View = System.Windows.Forms.View.Details;
            this.WorkingForm_AllProduct_listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.WorkingForm_AllProduct_listView_MouseDoubleClick);
            // 
            // Product_contextStrip
            // 
            this.Product_contextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem1,
            this.addNewProductToolStripMenuItem,
            this.inactiveProductToolStripMenuItem,
            this.showAllProductsToolStripMenuItem});
            this.Product_contextStrip.Name = "Product_contextStrip";
            this.Product_contextStrip.Size = new System.Drawing.Size(171, 92);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.refreshToolStripMenuItem1_Click);
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.addNewProductToolStripMenuItem.Text = "Add New Product";
            this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewProductToolStripMenuItem_Click);
            // 
            // inactiveProductToolStripMenuItem
            // 
            this.inactiveProductToolStripMenuItem.Name = "inactiveProductToolStripMenuItem";
            this.inactiveProductToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.inactiveProductToolStripMenuItem.Text = "Inactive Product";
            this.inactiveProductToolStripMenuItem.Click += new System.EventHandler(this.inactiveProductToolStripMenuItem_Click);
            // 
            // showAllProductsToolStripMenuItem
            // 
            this.showAllProductsToolStripMenuItem.Name = "showAllProductsToolStripMenuItem";
            this.showAllProductsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.showAllProductsToolStripMenuItem.Text = "Show All Products";
            this.showAllProductsToolStripMenuItem.Click += new System.EventHandler(this.showAllProductsToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chooseDate);
            this.groupBox1.Controls.Add(this.choice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Serach_Product_comboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(53, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Product";
            // 
            // choice
            // 
            this.choice.Controls.Add(this.Select_Search_comboBox);
            this.choice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice.Location = new System.Drawing.Point(302, 17);
            this.choice.Name = "choice";
            this.choice.Size = new System.Drawing.Size(175, 57);
            this.choice.TabIndex = 4;
            this.choice.TabStop = false;
            this.choice.Text = "select choice";
            // 
            // Select_Search_comboBox
            // 
            this.Select_Search_comboBox.FormattingEnabled = true;
            this.Select_Search_comboBox.Location = new System.Drawing.Point(6, 21);
            this.Select_Search_comboBox.Name = "Select_Search_comboBox";
            this.Select_Search_comboBox.Size = new System.Drawing.Size(163, 23);
            this.Select_Search_comboBox.TabIndex = 2;
            this.Select_Search_comboBox.SelectedIndexChanged += new System.EventHandler(this.Select_Search_comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = ">>>>>>";
            // 
            // Serach_Product_comboBox
            // 
            this.Serach_Product_comboBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serach_Product_comboBox.FormattingEnabled = true;
            this.Serach_Product_comboBox.Items.AddRange(new object[] {
            "BarCode",
            "product Name",
            "Company Name",
            "Purpose",
            "Category",
            "Descreption",
            "Expirydate"});
            this.Serach_Product_comboBox.Location = new System.Drawing.Point(100, 32);
            this.Serach_Product_comboBox.Name = "Serach_Product_comboBox";
            this.Serach_Product_comboBox.Size = new System.Drawing.Size(147, 23);
            this.Serach_Product_comboBox.TabIndex = 1;
            this.Serach_Product_comboBox.Text = "   << select Choice >>";
            this.Serach_Product_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Choise";
            // 
            // chooseDate
            // 
            this.chooseDate.Controls.Add(this.label4);
            this.chooseDate.Controls.Add(this.label3);
            this.chooseDate.Controls.Add(this.dateTimePicker2);
            this.chooseDate.Controls.Add(this.dateTimePicker1);
            this.chooseDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseDate.Location = new System.Drawing.Point(483, 17);
            this.chooseDate.Name = "chooseDate";
            this.chooseDate.Size = new System.Drawing.Size(373, 57);
            this.chooseDate.TabIndex = 5;
            this.chooseDate.TabStop = false;
            this.chooseDate.Text = "select Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(47, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(223, 23);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(144, 23);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "To";
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 613);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WorkingForm_AllProduct_listView);
            this.MaximizeBox = false;
            this.Name = "ProductList";
            this.Text = "ProductList";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ProductList_Load);
            this.Product_contextStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.choice.ResumeLayout(false);
            this.chooseDate.ResumeLayout(false);
            this.chooseDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView WorkingForm_AllProduct_listView;
        private System.Windows.Forms.ContextMenuStrip Product_contextStrip;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inactiveProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllProductsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Serach_Product_comboBox;
        private System.Windows.Forms.GroupBox choice;
        private System.Windows.Forms.ComboBox Select_Search_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox chooseDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}