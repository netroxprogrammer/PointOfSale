namespace PointOfSale.OthersForms
{
    partial class AddDiscription
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddDiscreption_Cancel_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "description";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 30);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddDiscreption_Cancel_btn);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(76, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 50);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = global::PointOfSale.Properties.Resources.favicon_16x162;
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddDiscreption_Cancel_btn
            // 
            this.AddDiscreption_Cancel_btn.Image = global::PointOfSale.Properties.Resources.favicon_16x161;
            this.AddDiscreption_Cancel_btn.Location = new System.Drawing.Point(115, 15);
            this.AddDiscreption_Cancel_btn.Name = "AddDiscreption_Cancel_btn";
            this.AddDiscreption_Cancel_btn.Size = new System.Drawing.Size(78, 31);
            this.AddDiscreption_Cancel_btn.TabIndex = 1;
            this.AddDiscreption_Cancel_btn.Text = "Cancel";
            this.AddDiscreption_Cancel_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddDiscreption_Cancel_btn.UseVisualStyleBackColor = true;
            this.AddDiscreption_Cancel_btn.Click += new System.EventHandler(this.AddDiscreption_Cancel_btn_Click);
            // 
            // AddDiscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 170);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddDiscription";
            this.Text = "AddDiscription";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddDiscreption_Cancel_btn;
    }
}