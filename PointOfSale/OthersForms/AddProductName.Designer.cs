namespace PointOfSale.OthersForms
{
    partial class AddProductName
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
            this.label2 = new System.Windows.Forms.Label();
            this.addProductName_textBox = new System.Windows.Forms.TextBox();
            this.AddproductDiscount_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addProduct_Cancel_Button = new System.Windows.Forms.Button();
            this.AddProduct_Save_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max Discount";
            // 
            // addProductName_textBox
            // 
            this.addProductName_textBox.Location = new System.Drawing.Point(103, 31);
            this.addProductName_textBox.Multiline = true;
            this.addProductName_textBox.Name = "addProductName_textBox";
            this.addProductName_textBox.Size = new System.Drawing.Size(224, 26);
            this.addProductName_textBox.TabIndex = 2;
            // 
            // AddproductDiscount_textBox
            // 
            this.AddproductDiscount_textBox.Location = new System.Drawing.Point(103, 67);
            this.AddproductDiscount_textBox.Multiline = true;
            this.AddproductDiscount_textBox.Name = "AddproductDiscount_textBox";
            this.AddproductDiscount_textBox.Size = new System.Drawing.Size(224, 26);
            this.AddproductDiscount_textBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addProduct_Cancel_Button);
            this.groupBox1.Controls.Add(this.AddProduct_Save_Button);
            this.groupBox1.Location = new System.Drawing.Point(89, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 49);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // addProduct_Cancel_Button
            // 
            this.addProduct_Cancel_Button.Image = global::PointOfSale.Properties.Resources.favicon_16x161;
            this.addProduct_Cancel_Button.Location = new System.Drawing.Point(154, 15);
            this.addProduct_Cancel_Button.Name = "addProduct_Cancel_Button";
            this.addProduct_Cancel_Button.Size = new System.Drawing.Size(78, 28);
            this.addProduct_Cancel_Button.TabIndex = 5;
            this.addProduct_Cancel_Button.Text = "Cancel";
            this.addProduct_Cancel_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addProduct_Cancel_Button.UseVisualStyleBackColor = true;
            this.addProduct_Cancel_Button.Click += new System.EventHandler(this.addProduct_Cancel_Button_Click);
            // 
            // AddProduct_Save_Button
            // 
            this.AddProduct_Save_Button.Image = global::PointOfSale.Properties.Resources.favicon_16x162;
            this.AddProduct_Save_Button.Location = new System.Drawing.Point(34, 15);
            this.AddProduct_Save_Button.Name = "AddProduct_Save_Button";
            this.AddProduct_Save_Button.Size = new System.Drawing.Size(78, 28);
            this.AddProduct_Save_Button.TabIndex = 4;
            this.AddProduct_Save_Button.Text = "Save";
            this.AddProduct_Save_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddProduct_Save_Button.UseVisualStyleBackColor = true;
            // 
            // AddProductName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 170);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddproductDiscount_textBox);
            this.Controls.Add(this.addProductName_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddProductName";
            this.Text = "AddProductName";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addProductName_textBox;
        private System.Windows.Forms.TextBox AddproductDiscount_textBox;
        private System.Windows.Forms.Button AddProduct_Save_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addProduct_Cancel_Button;
    }
}