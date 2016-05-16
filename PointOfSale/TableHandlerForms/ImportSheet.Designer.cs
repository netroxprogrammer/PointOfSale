namespace PointOfSale.TableHandlerForms
{
    partial class ImportSheet
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
            this.importSheet_uplaod_Button = new System.Windows.Forms.Button();
            this.importSheet_uplaod_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.importSheet_uplaod_progressBar = new System.Windows.Forms.ProgressBar();
            this.importSheet_uplaod_listView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.importSheet_uplaod_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.importSheet_uplaod_listView);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(-2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 589);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // importSheet_uplaod_Button
            // 
            this.importSheet_uplaod_Button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importSheet_uplaod_Button.Location = new System.Drawing.Point(530, 19);
            this.importSheet_uplaod_Button.Name = "importSheet_uplaod_Button";
            this.importSheet_uplaod_Button.Size = new System.Drawing.Size(152, 29);
            this.importSheet_uplaod_Button.TabIndex = 0;
            this.importSheet_uplaod_Button.Text = "Upload File";
            this.importSheet_uplaod_Button.UseVisualStyleBackColor = true;
            this.importSheet_uplaod_Button.Click += new System.EventHandler(this.importSheet_uplaod_Button_Click);
            // 
            // importSheet_uplaod_TextBox
            // 
            this.importSheet_uplaod_TextBox.Location = new System.Drawing.Point(65, 19);
            this.importSheet_uplaod_TextBox.Multiline = true;
            this.importSheet_uplaod_TextBox.Name = "importSheet_uplaod_TextBox";
            this.importSheet_uplaod_TextBox.Size = new System.Drawing.Size(441, 29);
            this.importSheet_uplaod_TextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.importSheet_uplaod_progressBar);
            this.groupBox2.Controls.Add(this.importSheet_uplaod_Button);
            this.groupBox2.Controls.Add(this.importSheet_uplaod_TextBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(820, 110);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upload";
            // 
            // importSheet_uplaod_progressBar
            // 
            this.importSheet_uplaod_progressBar.Location = new System.Drawing.Point(6, 69);
            this.importSheet_uplaod_progressBar.Name = "importSheet_uplaod_progressBar";
            this.importSheet_uplaod_progressBar.Size = new System.Drawing.Size(808, 23);
            this.importSheet_uplaod_progressBar.TabIndex = 2;
            // 
            // importSheet_uplaod_listView
            // 
            this.importSheet_uplaod_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.importSheet_uplaod_listView.Location = new System.Drawing.Point(36, 196);
            this.importSheet_uplaod_listView.Name = "importSheet_uplaod_listView";
            this.importSheet_uplaod_listView.Size = new System.Drawing.Size(198, 382);
            this.importSheet_uplaod_listView.TabIndex = 3;
            this.importSheet_uplaod_listView.UseCompatibleStateImageBehavior = false;
            this.importSheet_uplaod_listView.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Columns For  Import";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "                     Columns";
            this.columnHeader1.Width = 193;
            // 
            // importSheet_uplaod_openFileDialog
            // 
            this.importSheet_uplaod_openFileDialog.FileName = "openFileDialog1";
            // 
            // ImportSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 591);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ImportSheet";
            this.Text = "ImportSheet";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button importSheet_uplaod_Button;
        private System.Windows.Forms.TextBox importSheet_uplaod_TextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar importSheet_uplaod_progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView importSheet_uplaod_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.OpenFileDialog importSheet_uplaod_openFileDialog;
    }
}