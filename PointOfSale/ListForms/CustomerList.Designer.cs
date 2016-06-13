namespace PointOfSale.ListForms
{
    partial class CustomerList
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
            this.WorkingForm_listView = new System.Windows.Forms.ListView();
            this.WorkingForm_rightClick_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.inactiveCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkingForm_rightClick_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkingForm_listView
            // 
            this.WorkingForm_listView.ContextMenuStrip = this.WorkingForm_rightClick_menu;
            this.WorkingForm_listView.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkingForm_listView.FullRowSelect = true;
            this.WorkingForm_listView.GridLines = true;
            this.WorkingForm_listView.Location = new System.Drawing.Point(3, 96);
            this.WorkingForm_listView.Name = "WorkingForm_listView";
            this.WorkingForm_listView.Size = new System.Drawing.Size(1066, 645);
            this.WorkingForm_listView.TabIndex = 1;
            this.WorkingForm_listView.UseCompatibleStateImageBehavior = false;
            this.WorkingForm_listView.View = System.Windows.Forms.View.Details;
            this.WorkingForm_listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.WorkingForm_listView_MouseDoubleClick);
            // 
            // WorkingForm_rightClick_menu
            // 
            this.WorkingForm_rightClick_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.inactiveCustomerToolStripMenuItem});
            this.WorkingForm_rightClick_menu.Name = "WorkingForm_rightClick_menu";
            this.WorkingForm_rightClick_menu.Size = new System.Drawing.Size(211, 114);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItem1.Text = "Refresh";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItem2.Text = "Add New Customer";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItem5.Text = "Make  this suplier Inactive";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItem6.Text = "Print Customer List";
            // 
            // inactiveCustomerToolStripMenuItem
            // 
            this.inactiveCustomerToolStripMenuItem.Name = "inactiveCustomerToolStripMenuItem";
            this.inactiveCustomerToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.inactiveCustomerToolStripMenuItem.Text = "Inactive Customer List";
            this.inactiveCustomerToolStripMenuItem.Click += new System.EventHandler(this.inactiveCustomerToolStripMenuItem_Click);
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 743);
            this.Controls.Add(this.WorkingForm_listView);
            this.MaximizeBox = false;
            this.Name = "CustomerList";
            this.Text = "CustomerList";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CustomerList_Load);
            this.WorkingForm_rightClick_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView WorkingForm_listView;
        private System.Windows.Forms.ContextMenuStrip WorkingForm_rightClick_menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem inactiveCustomerToolStripMenuItem;
    }
}