namespace PointOfSale.ListForms
{
    partial class CrstalReportView
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
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport31 = new PointOfSale.CrystalReport3();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 53);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = "C:\\Users\\mac\\Documents\\Visual Studio 2015\\Projects\\PointOfSale\\PointOfSale\\Crysta" +
    "lReport3.rpt";
            this.crystalReportViewer2.Size = new System.Drawing.Size(520, 448);
            this.crystalReportViewer2.TabIndex = 0;
            this.crystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer2.Load += new System.EventHandler(this.crystalReportViewer2_Load);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(192, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Print Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CrstalReportView
            // 
            this.ClientSize = new System.Drawing.Size(520, 483);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.crystalReportViewer2);
            this.Name = "CrstalReportView";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CrstalReportView_FormClosed);
            this.Load += new System.EventHandler(this.CrstalReportView_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private CrystalReport3 CrystalReport31;
        private System.Windows.Forms.Button button1;
    }
}