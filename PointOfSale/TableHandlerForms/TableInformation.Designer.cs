namespace PointOfSale.TableInformationForm
{
    partial class TableInformation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableInformation_View_brt = new System.Windows.Forms.Button();
            this.tableInformation_viewTable_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableInformation_colmnName_listView = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableInformation_View_brt);
            this.groupBox1.Controls.Add(this.tableInformation_viewTable_comboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tableInformation_View_brt
            // 
            this.tableInformation_View_brt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableInformation_View_brt.Image = global::PointOfSale.Properties.Resources.favicon_16x164;
            this.tableInformation_View_brt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tableInformation_View_brt.Location = new System.Drawing.Point(126, 54);
            this.tableInformation_View_brt.Name = "tableInformation_View_brt";
            this.tableInformation_View_brt.Size = new System.Drawing.Size(68, 25);
            this.tableInformation_View_brt.TabIndex = 1;
            this.tableInformation_View_brt.Text = "View";
            this.tableInformation_View_brt.UseVisualStyleBackColor = true;
            this.tableInformation_View_brt.Click += new System.EventHandler(this.tableInformation_View_brt_Click);
            // 
            // tableInformation_viewTable_comboBox
            // 
            this.tableInformation_viewTable_comboBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableInformation_viewTable_comboBox.FormattingEnabled = true;
            this.tableInformation_viewTable_comboBox.Location = new System.Drawing.Point(111, 19);
            this.tableInformation_viewTable_comboBox.Name = "tableInformation_viewTable_comboBox";
            this.tableInformation_viewTable_comboBox.Size = new System.Drawing.Size(266, 23);
            this.tableInformation_viewTable_comboBox.TabIndex = 1;
            this.tableInformation_viewTable_comboBox.SelectedIndexChanged += new System.EventHandler(this.tableInformation_viewTable_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Table";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableInformation_colmnName_listView);
            this.groupBox2.Location = new System.Drawing.Point(9, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 295);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tableInformation_colmnName_listView
            // 
            this.tableInformation_colmnName_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName});
            this.tableInformation_colmnName_listView.FullRowSelect = true;
            this.tableInformation_colmnName_listView.GridLines = true;
            this.tableInformation_colmnName_listView.Location = new System.Drawing.Point(105, 13);
            this.tableInformation_colmnName_listView.Name = "tableInformation_colmnName_listView";
            this.tableInformation_colmnName_listView.Size = new System.Drawing.Size(118, 276);
            this.tableInformation_colmnName_listView.TabIndex = 0;
            this.tableInformation_colmnName_listView.UseCompatibleStateImageBehavior = false;
            this.tableInformation_colmnName_listView.View = System.Windows.Forms.View.Details;
            this.tableInformation_colmnName_listView.SelectedIndexChanged += new System.EventHandler(this.tableInformation_colmnName_listView_SelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.Text = "     Column Name";
            this.columnName.Width = 403;
            // 
            // TableInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 423);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TableInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Information";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TableInformatiion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tableInformation_viewTable_comboBox;
        private System.Windows.Forms.Button tableInformation_View_brt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView tableInformation_colmnName_listView;
        private System.Windows.Forms.ColumnHeader columnName;
    }
}