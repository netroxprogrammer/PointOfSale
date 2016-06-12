namespace PointOfSale.ListForms
{
    partial class EmployeList
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
            this.WorkingForm_EmployeList = new System.Windows.Forms.ListView();
            this.workingForm_Employee_rightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEmployeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.workingForm_Employee_rightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkingForm_EmployeList
            // 
            this.WorkingForm_EmployeList.ContextMenuStrip = this.workingForm_Employee_rightClick;
            this.WorkingForm_EmployeList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkingForm_EmployeList.FullRowSelect = true;
            this.WorkingForm_EmployeList.GridLines = true;
            this.WorkingForm_EmployeList.Location = new System.Drawing.Point(2, 97);
            this.WorkingForm_EmployeList.Name = "WorkingForm_EmployeList";
            this.WorkingForm_EmployeList.Size = new System.Drawing.Size(1227, 585);
            this.WorkingForm_EmployeList.TabIndex = 1;
            this.WorkingForm_EmployeList.UseCompatibleStateImageBehavior = false;
            this.WorkingForm_EmployeList.View = System.Windows.Forms.View.Details;
            this.WorkingForm_EmployeList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.WorkingForm_EmployeList_MouseDoubleClick);
            // 
            // workingForm_Employee_rightClick
            // 
            this.workingForm_Employee_rightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.addNewEmployeeToolStripMenuItem1});
            this.workingForm_Employee_rightClick.Name = "workingForm_Employee_rightClick";
            this.workingForm_Employee_rightClick.Size = new System.Drawing.Size(179, 70);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // addNewEmployeeToolStripMenuItem1
            // 
            this.addNewEmployeeToolStripMenuItem1.Name = "addNewEmployeeToolStripMenuItem1";
            this.addNewEmployeeToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.addNewEmployeeToolStripMenuItem1.Text = "Add New Employee";
            this.addNewEmployeeToolStripMenuItem1.Click += new System.EventHandler(this.addNewEmployeeToolStripMenuItem1_Click);
            // 
            // EmployeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 682);
            this.Controls.Add(this.WorkingForm_EmployeList);
            this.MaximizeBox = false;
            this.Name = "EmployeList";
            this.Text = "EmployeList";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EmployeList_Load);
            this.workingForm_Employee_rightClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView WorkingForm_EmployeList;
        private System.Windows.Forms.ContextMenuStrip workingForm_Employee_rightClick;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewEmployeeToolStripMenuItem1;
    }
}