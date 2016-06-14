namespace PointOfSale.ListForms
{
    partial class UpdateInvoiceForm
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
            this.Old_Balance = new System.Windows.Forms.TextBox();
            this.Old_Payment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.new_Payemnt_tetbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.new_Balance = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Balance";
            // 
            // Old_Balance
            // 
            this.Old_Balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Old_Balance.Location = new System.Drawing.Point(86, 29);
            this.Old_Balance.Name = "Old_Balance";
            this.Old_Balance.ReadOnly = true;
            this.Old_Balance.Size = new System.Drawing.Size(111, 20);
            this.Old_Balance.TabIndex = 1;
            // 
            // Old_Payment
            // 
            this.Old_Payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Old_Payment.Location = new System.Drawing.Point(302, 29);
            this.Old_Payment.Name = "Old_Payment";
            this.Old_Payment.ReadOnly = true;
            this.Old_Payment.Size = new System.Drawing.Size(111, 20);
            this.Old_Payment.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Old Payment";
            // 
            // new_Payemnt_tetbox
            // 
            this.new_Payemnt_tetbox.Location = new System.Drawing.Point(502, 29);
            this.new_Payemnt_tetbox.Name = "new_Payemnt_tetbox";
            this.new_Payemnt_tetbox.Size = new System.Drawing.Size(111, 20);
            this.new_Payemnt_tetbox.TabIndex = 5;
            this.new_Payemnt_tetbox.TextChanged += new System.EventHandler(this.new_Payemnt_tetbox_TextChanged);
            this.new_Payemnt_tetbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "New Payment";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Old_Balance);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.new_Payemnt_tetbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Old_Payment);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 67);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Invoice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "New Balance";
            // 
            // new_Balance
            // 
            this.new_Balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.new_Balance.Location = new System.Drawing.Point(532, 17);
            this.new_Balance.Name = "new_Balance";
            this.new_Balance.ReadOnly = true;
            this.new_Balance.Size = new System.Drawing.Size(111, 20);
            this.new_Balance.TabIndex = 6;
            // 
            // UpdateInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 383);
            this.Controls.Add(this.new_Balance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateInvoiceForm";
            this.Text = "UpdateInvoiceForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UpdateInvoiceForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Old_Balance;
        private System.Windows.Forms.TextBox Old_Payment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox new_Payemnt_tetbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox new_Balance;
    }
}