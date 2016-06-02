namespace PointOfSale.OthersForms
{
    partial class AddCompanyName
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddCompanyName_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddCompanyName_Cancel_button = new System.Windows.Forms.Button();
            this.AddCompanyName_Saave_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company Name";
            // 
            // AddCompanyName_TextBox
            // 
            this.AddCompanyName_TextBox.Location = new System.Drawing.Point(135, 32);
            this.AddCompanyName_TextBox.Multiline = true;
            this.AddCompanyName_TextBox.Name = "AddCompanyName_TextBox";
            this.AddCompanyName_TextBox.Size = new System.Drawing.Size(219, 21);
            this.AddCompanyName_TextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddCompanyName_Cancel_button);
            this.groupBox1.Controls.Add(this.AddCompanyName_Saave_button);
            this.groupBox1.Location = new System.Drawing.Point(78, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 50);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // AddCompanyName_Cancel_button
            // 
            this.AddCompanyName_Cancel_button.Image = global::PointOfSale.Properties.Resources.favicon_16x161;
            this.AddCompanyName_Cancel_button.Location = new System.Drawing.Point(119, 9);
            this.AddCompanyName_Cancel_button.Name = "AddCompanyName_Cancel_button";
            this.AddCompanyName_Cancel_button.Size = new System.Drawing.Size(75, 29);
            this.AddCompanyName_Cancel_button.TabIndex = 1;
            this.AddCompanyName_Cancel_button.Text = "Cancel";
            this.AddCompanyName_Cancel_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddCompanyName_Cancel_button.UseVisualStyleBackColor = true;
            this.AddCompanyName_Cancel_button.Click += new System.EventHandler(this.AddCompanyName_Cancel_button_Click);
            // 
            // AddCompanyName_Saave_button
            // 
            this.AddCompanyName_Saave_button.Image = global::PointOfSale.Properties.Resources.favicon_16x162;
            this.AddCompanyName_Saave_button.Location = new System.Drawing.Point(17, 9);
            this.AddCompanyName_Saave_button.Name = "AddCompanyName_Saave_button";
            this.AddCompanyName_Saave_button.Size = new System.Drawing.Size(81, 29);
            this.AddCompanyName_Saave_button.TabIndex = 0;
            this.AddCompanyName_Saave_button.Text = "Save";
            this.AddCompanyName_Saave_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddCompanyName_Saave_button.UseVisualStyleBackColor = true;
            // 
            // AddCompanyName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 135);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddCompanyName_TextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddCompanyName";
            this.Text = "AddCompanyName";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCompanyName_Saave_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddCompanyName_TextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddCompanyName_Cancel_button;
    }
}