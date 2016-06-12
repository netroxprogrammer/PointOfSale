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
            this.Product_contextStrip.SuspendLayout();
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
            this.Product_contextStrip.Size = new System.Drawing.Size(171, 114);
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
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 613);
            this.Controls.Add(this.WorkingForm_AllProduct_listView);
            this.MaximizeBox = false;
            this.Name = "ProductList";
            this.Text = "ProductList";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ProductList_Load);
            this.Product_contextStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView WorkingForm_AllProduct_listView;
        private System.Windows.Forms.ContextMenuStrip Product_contextStrip;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inactiveProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllProductsToolStripMenuItem;
    }
}