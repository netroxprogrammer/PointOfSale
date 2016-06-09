namespace PointOfSale
{
    partial class Customer_Information
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
            this.customerInformation_customerName_extBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customerInformation_Discount_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Payment = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customerInformation_credit_radioButton = new System.Windows.Forms.RadioButton();
            this.customerInformation_cash_radioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.contact_information_groupBox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.customerInformation_Remark_extBox = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.customerInformation_Address_extBox = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.customerInformation_Email_extBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.customerInformation_Fax3_extBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.customerInformation_Fax2_extBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.customerInformation_Fax1_extBox = new System.Windows.Forms.TextBox();
            this.customerInformation_Phone3_extBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.customerInformation_Phone2_extBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customerInformation_Phone1_extBox = new System.Windows.Forms.TextBox();
            this.customerInformation_RefferedBy_extBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customerInformation_ContactPerson_extBox = new System.Windows.Forms.TextBox();
            this.customerInformation_default_checkBok = new System.Windows.Forms.CheckBox();
            this.customerInformation_inactive_checkBok = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customerInformation_Cancel_Button = new System.Windows.Forms.Button();
            this.customerInformation_SaveClose_Button = new System.Windows.Forms.Button();
            this.customerInformation_SaveNew_Button = new System.Windows.Forms.Button();
            this.AddCustomer_Udpate_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerInformation_Discount_numericUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            this.contact_information_groupBox.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerInformation_customerName_extBox
            // 
            this.customerInformation_customerName_extBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInformation_customerName_extBox.Location = new System.Drawing.Point(19, 33);
            this.customerInformation_customerName_extBox.Multiline = true;
            this.customerInformation_customerName_extBox.Name = "customerInformation_customerName_extBox";
            this.customerInformation_customerName_extBox.Size = new System.Drawing.Size(299, 25);
            this.customerInformation_customerName_extBox.TabIndex = 0;
            this.customerInformation_customerName_extBox.TextChanged += new System.EventHandler(this.customerInformation_customerName_extBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.customerInformation_Discount_numericUpDown);
            this.panel1.Controls.Add(this.Payment);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.customerInformation_customerName_extBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 110);
            this.panel1.TabIndex = 3;
            // 
            // customerInformation_Discount_numericUpDown
            // 
            this.customerInformation_Discount_numericUpDown.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInformation_Discount_numericUpDown.Location = new System.Drawing.Point(336, 33);
            this.customerInformation_Discount_numericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.customerInformation_Discount_numericUpDown.Name = "customerInformation_Discount_numericUpDown";
            this.customerInformation_Discount_numericUpDown.Size = new System.Drawing.Size(133, 26);
            this.customerInformation_Discount_numericUpDown.TabIndex = 0;
            this.customerInformation_Discount_numericUpDown.ValueChanged += new System.EventHandler(this.customerInformation_Discount_numericUpDown_ValueChanged);
            this.customerInformation_Discount_numericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customerInformation_Discount_numericUpDown_KeyPress);
            // 
            // Payment
            // 
            this.Payment.AutoSize = true;
            this.Payment.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Payment.Location = new System.Drawing.Point(498, 8);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(103, 18);
            this.Payment.TabIndex = 5;
            this.Payment.Text = "Payment Terms";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.customerInformation_credit_radioButton);
            this.panel2.Controls.Add(this.customerInformation_cash_radioButton);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(501, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 25);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // customerInformation_credit_radioButton
            // 
            this.customerInformation_credit_radioButton.AutoSize = true;
            this.customerInformation_credit_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInformation_credit_radioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.customerInformation_credit_radioButton.Location = new System.Drawing.Point(82, 3);
            this.customerInformation_credit_radioButton.Name = "customerInformation_credit_radioButton";
            this.customerInformation_credit_radioButton.Size = new System.Drawing.Size(59, 20);
            this.customerInformation_credit_radioButton.TabIndex = 1;
            this.customerInformation_credit_radioButton.TabStop = true;
            this.customerInformation_credit_radioButton.Text = "credit";
            this.customerInformation_credit_radioButton.UseVisualStyleBackColor = true;
            // 
            // customerInformation_cash_radioButton
            // 
            this.customerInformation_cash_radioButton.AutoSize = true;
            this.customerInformation_cash_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInformation_cash_radioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.customerInformation_cash_radioButton.Location = new System.Drawing.Point(3, 3);
            this.customerInformation_cash_radioButton.Name = "customerInformation_cash_radioButton";
            this.customerInformation_cash_radioButton.Size = new System.Drawing.Size(55, 20);
            this.customerInformation_cash_radioButton.TabIndex = 0;
            this.customerInformation_cash_radioButton.TabStop = true;
            this.customerInformation_cash_radioButton.Text = "cash";
            this.customerInformation_cash_radioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(333, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Discount";
            // 
            // contact_information_groupBox
            // 
            this.contact_information_groupBox.Controls.Add(this.label14);
            this.contact_information_groupBox.Controls.Add(this.customerInformation_Remark_extBox);
            this.contact_information_groupBox.Controls.Add(this.label13);
            this.contact_information_groupBox.Controls.Add(this.customerInformation_Address_extBox);
            this.contact_information_groupBox.Controls.Add(this.label10);
            this.contact_information_groupBox.Controls.Add(this.customerInformation_Email_extBox);
            this.contact_information_groupBox.Controls.Add(this.label11);
            this.contact_information_groupBox.Controls.Add(this.customerInformation_Fax3_extBox);
            this.contact_information_groupBox.Controls.Add(this.label12);
            this.contact_information_groupBox.Controls.Add(this.customerInformation_Fax2_extBox);
            this.contact_information_groupBox.Controls.Add(this.label9);
            this.contact_information_groupBox.Controls.Add(this.label8);
            this.contact_information_groupBox.Controls.Add(this.customerInformation_Fax1_extBox);
            this.contact_information_groupBox.Controls.Add(this.customerInformation_Phone3_extBox);
            this.contact_information_groupBox.Controls.Add(this.label7);
            this.contact_information_groupBox.Controls.Add(this.customerInformation_Phone2_extBox);
            this.contact_information_groupBox.Controls.Add(this.label6);
            this.contact_information_groupBox.Controls.Add(this.customerInformation_Phone1_extBox);
            this.contact_information_groupBox.Controls.Add(this.customerInformation_RefferedBy_extBox);
            this.contact_information_groupBox.Controls.Add(this.label5);
            this.contact_information_groupBox.Controls.Add(this.label4);
            this.contact_information_groupBox.Controls.Add(this.customerInformation_ContactPerson_extBox);
            this.contact_information_groupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_information_groupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.contact_information_groupBox.Location = new System.Drawing.Point(12, 139);
            this.contact_information_groupBox.Name = "contact_information_groupBox";
            this.contact_information_groupBox.Size = new System.Drawing.Size(713, 308);
            this.contact_information_groupBox.TabIndex = 0;
            this.contact_information_groupBox.TabStop = false;
            this.contact_information_groupBox.Text = "Contact Information:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label14.Location = new System.Drawing.Point(358, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 18);
            this.label14.TabIndex = 26;
            this.label14.Text = "Remarks";
            // 
            // customerInformation_Remark_extBox
            // 
            this.customerInformation_Remark_extBox.Location = new System.Drawing.Point(361, 203);
            this.customerInformation_Remark_extBox.Name = "customerInformation_Remark_extBox";
            this.customerInformation_Remark_extBox.Size = new System.Drawing.Size(346, 99);
            this.customerInformation_Remark_extBox.TabIndex = 25;
            this.customerInformation_Remark_extBox.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(17, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 18);
            this.label13.TabIndex = 24;
            this.label13.Text = "Address";
            // 
            // customerInformation_Address_extBox
            // 
            this.customerInformation_Address_extBox.Location = new System.Drawing.Point(20, 203);
            this.customerInformation_Address_extBox.Name = "customerInformation_Address_extBox";
            this.customerInformation_Address_extBox.Size = new System.Drawing.Size(328, 99);
            this.customerInformation_Address_extBox.TabIndex = 23;
            this.customerInformation_Address_extBox.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(358, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Email";
            // 
            // customerInformation_Email_extBox
            // 
            this.customerInformation_Email_extBox.Location = new System.Drawing.Point(361, 153);
            this.customerInformation_Email_extBox.Multiline = true;
            this.customerInformation_Email_extBox.Name = "customerInformation_Email_extBox";
            this.customerInformation_Email_extBox.Size = new System.Drawing.Size(346, 27);
            this.customerInformation_Email_extBox.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(189, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Fax3";
            // 
            // customerInformation_Fax3_extBox
            // 
            this.customerInformation_Fax3_extBox.Location = new System.Drawing.Point(191, 153);
            this.customerInformation_Fax3_extBox.Multiline = true;
            this.customerInformation_Fax3_extBox.Name = "customerInformation_Fax3_extBox";
            this.customerInformation_Fax3_extBox.Size = new System.Drawing.Size(161, 27);
            this.customerInformation_Fax3_extBox.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(17, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 18);
            this.label12.TabIndex = 18;
            this.label12.Text = "Fax2";
            // 
            // customerInformation_Fax2_extBox
            // 
            this.customerInformation_Fax2_extBox.Location = new System.Drawing.Point(19, 153);
            this.customerInformation_Fax2_extBox.Multiline = true;
            this.customerInformation_Fax2_extBox.Name = "customerInformation_Fax2_extBox";
            this.customerInformation_Fax2_extBox.Size = new System.Drawing.Size(163, 27);
            this.customerInformation_Fax2_extBox.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(540, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fax1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(358, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Phone 3";
            // 
            // customerInformation_Fax1_extBox
            // 
            this.customerInformation_Fax1_extBox.Location = new System.Drawing.Point(543, 102);
            this.customerInformation_Fax1_extBox.Multiline = true;
            this.customerInformation_Fax1_extBox.Name = "customerInformation_Fax1_extBox";
            this.customerInformation_Fax1_extBox.Size = new System.Drawing.Size(164, 27);
            this.customerInformation_Fax1_extBox.TabIndex = 14;
            // 
            // customerInformation_Phone3_extBox
            // 
            this.customerInformation_Phone3_extBox.Location = new System.Drawing.Point(361, 102);
            this.customerInformation_Phone3_extBox.Multiline = true;
            this.customerInformation_Phone3_extBox.Name = "customerInformation_Phone3_extBox";
            this.customerInformation_Phone3_extBox.Size = new System.Drawing.Size(164, 27);
            this.customerInformation_Phone3_extBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(188, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Phone 2";
            // 
            // customerInformation_Phone2_extBox
            // 
            this.customerInformation_Phone2_extBox.Location = new System.Drawing.Point(188, 102);
            this.customerInformation_Phone2_extBox.Multiline = true;
            this.customerInformation_Phone2_extBox.Name = "customerInformation_Phone2_extBox";
            this.customerInformation_Phone2_extBox.Size = new System.Drawing.Size(164, 27);
            this.customerInformation_Phone2_extBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(16, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone 1";
            // 
            // customerInformation_Phone1_extBox
            // 
            this.customerInformation_Phone1_extBox.Location = new System.Drawing.Point(18, 102);
            this.customerInformation_Phone1_extBox.Multiline = true;
            this.customerInformation_Phone1_extBox.Name = "customerInformation_Phone1_extBox";
            this.customerInformation_Phone1_extBox.Size = new System.Drawing.Size(164, 27);
            this.customerInformation_Phone1_extBox.TabIndex = 9;
            // 
            // customerInformation_RefferedBy_extBox
            // 
            this.customerInformation_RefferedBy_extBox.Location = new System.Drawing.Point(361, 51);
            this.customerInformation_RefferedBy_extBox.Multiline = true;
            this.customerInformation_RefferedBy_extBox.Name = "customerInformation_RefferedBy_extBox";
            this.customerInformation_RefferedBy_extBox.Size = new System.Drawing.Size(346, 27);
            this.customerInformation_RefferedBy_extBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(358, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Refferred By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(17, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contact Person";
            // 
            // customerInformation_ContactPerson_extBox
            // 
            this.customerInformation_ContactPerson_extBox.Location = new System.Drawing.Point(19, 51);
            this.customerInformation_ContactPerson_extBox.Multiline = true;
            this.customerInformation_ContactPerson_extBox.Name = "customerInformation_ContactPerson_extBox";
            this.customerInformation_ContactPerson_extBox.Size = new System.Drawing.Size(319, 27);
            this.customerInformation_ContactPerson_extBox.TabIndex = 0;
            this.customerInformation_ContactPerson_extBox.TextChanged += new System.EventHandler(this.customerInformation_ContactPerson_extBox_TextChanged);
            // 
            // customerInformation_default_checkBok
            // 
            this.customerInformation_default_checkBok.AutoSize = true;
            this.customerInformation_default_checkBok.BackColor = System.Drawing.SystemColors.Control;
            this.customerInformation_default_checkBok.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInformation_default_checkBok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.customerInformation_default_checkBok.Location = new System.Drawing.Point(12, 466);
            this.customerInformation_default_checkBok.Name = "customerInformation_default_checkBok";
            this.customerInformation_default_checkBok.Size = new System.Drawing.Size(128, 19);
            this.customerInformation_default_checkBok.TabIndex = 4;
            this.customerInformation_default_checkBok.Text = "Default Customers";
            this.customerInformation_default_checkBok.UseVisualStyleBackColor = false;
            // 
            // customerInformation_inactive_checkBok
            // 
            this.customerInformation_inactive_checkBok.AutoSize = true;
            this.customerInformation_inactive_checkBok.BackColor = System.Drawing.SystemColors.Control;
            this.customerInformation_inactive_checkBok.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInformation_inactive_checkBok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.customerInformation_inactive_checkBok.Location = new System.Drawing.Point(12, 501);
            this.customerInformation_inactive_checkBok.Name = "customerInformation_inactive_checkBok";
            this.customerInformation_inactive_checkBok.Size = new System.Drawing.Size(136, 19);
            this.customerInformation_inactive_checkBok.TabIndex = 5;
            this.customerInformation_inactive_checkBok.Text = "Customer is Inactive";
            this.customerInformation_inactive_checkBok.UseVisualStyleBackColor = false;
            this.customerInformation_inactive_checkBok.CheckedChanged += new System.EventHandler(this.customerInformation_inactive_checkBok_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.AddCustomer_Udpate_btn);
            this.panel3.Controls.Add(this.customerInformation_Cancel_Button);
            this.panel3.Controls.Add(this.customerInformation_SaveClose_Button);
            this.panel3.Controls.Add(this.customerInformation_SaveNew_Button);
            this.panel3.Location = new System.Drawing.Point(299, 466);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 54);
            this.panel3.TabIndex = 6;
            // 
            // customerInformation_Cancel_Button
            // 
            this.customerInformation_Cancel_Button.Image = global::PointOfSale.Properties.Resources.favicon_16x161;
            this.customerInformation_Cancel_Button.Location = new System.Drawing.Point(329, 12);
            this.customerInformation_Cancel_Button.Name = "customerInformation_Cancel_Button";
            this.customerInformation_Cancel_Button.Size = new System.Drawing.Size(90, 29);
            this.customerInformation_Cancel_Button.TabIndex = 2;
            this.customerInformation_Cancel_Button.Text = "Cancel";
            this.customerInformation_Cancel_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customerInformation_Cancel_Button.UseVisualStyleBackColor = true;
            this.customerInformation_Cancel_Button.Click += new System.EventHandler(this.customerInformation_Cancel_Button_Click);
            // 
            // customerInformation_SaveClose_Button
            // 
            this.customerInformation_SaveClose_Button.Image = global::PointOfSale.Properties.Resources.favicon_16x16;
            this.customerInformation_SaveClose_Button.Location = new System.Drawing.Point(221, 12);
            this.customerInformation_SaveClose_Button.Name = "customerInformation_SaveClose_Button";
            this.customerInformation_SaveClose_Button.Size = new System.Drawing.Size(93, 29);
            this.customerInformation_SaveClose_Button.TabIndex = 1;
            this.customerInformation_SaveClose_Button.Text = "Save/Close";
            this.customerInformation_SaveClose_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customerInformation_SaveClose_Button.UseVisualStyleBackColor = true;
            this.customerInformation_SaveClose_Button.Click += new System.EventHandler(this.customerInformation_SaveClose_Button_Click);
            // 
            // customerInformation_SaveNew_Button
            // 
            this.customerInformation_SaveNew_Button.Image = global::PointOfSale.Properties.Resources.favicon_16x162;
            this.customerInformation_SaveNew_Button.Location = new System.Drawing.Point(120, 12);
            this.customerInformation_SaveNew_Button.Name = "customerInformation_SaveNew_Button";
            this.customerInformation_SaveNew_Button.Size = new System.Drawing.Size(95, 29);
            this.customerInformation_SaveNew_Button.TabIndex = 0;
            this.customerInformation_SaveNew_Button.Text = "Save/New";
            this.customerInformation_SaveNew_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customerInformation_SaveNew_Button.UseVisualStyleBackColor = true;
            this.customerInformation_SaveNew_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddCustomer_Udpate_btn
            // 
            this.AddCustomer_Udpate_btn.Image = global::PointOfSale.Properties.Resources.favicon_16x16;
            this.AddCustomer_Udpate_btn.Location = new System.Drawing.Point(14, 12);
            this.AddCustomer_Udpate_btn.Name = "AddCustomer_Udpate_btn";
            this.AddCustomer_Udpate_btn.Size = new System.Drawing.Size(93, 29);
            this.AddCustomer_Udpate_btn.TabIndex = 3;
            this.AddCustomer_Udpate_btn.Text = "Update";
            this.AddCustomer_Udpate_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddCustomer_Udpate_btn.UseVisualStyleBackColor = true;
            this.AddCustomer_Udpate_btn.Visible = false;
            this.AddCustomer_Udpate_btn.Click += new System.EventHandler(this.AddCustomer_Udpate_btn_Click);
            // 
            // Customer_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 532);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.customerInformation_inactive_checkBok);
            this.Controls.Add(this.customerInformation_default_checkBok);
            this.Controls.Add(this.contact_information_groupBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "Customer_Information";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Customer_Information_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerInformation_Discount_numericUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contact_information_groupBox.ResumeLayout(false);
            this.contact_information_groupBox.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerInformation_customerName_extBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton customerInformation_cash_radioButton;
        private System.Windows.Forms.GroupBox contact_information_groupBox;
        private System.Windows.Forms.RadioButton customerInformation_credit_radioButton;
        private System.Windows.Forms.Label Payment;
        private System.Windows.Forms.TextBox customerInformation_ContactPerson_extBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerInformation_RefferedBy_extBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customerInformation_Phone1_extBox;
        private System.Windows.Forms.TextBox customerInformation_Phone3_extBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox customerInformation_Phone2_extBox;
        private System.Windows.Forms.TextBox customerInformation_Fax1_extBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox customerInformation_Fax3_extBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox customerInformation_Fax2_extBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox customerInformation_Email_extBox;
        private System.Windows.Forms.RichTextBox customerInformation_Address_extBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox customerInformation_Remark_extBox;
        private System.Windows.Forms.CheckBox customerInformation_default_checkBok;
        private System.Windows.Forms.CheckBox customerInformation_inactive_checkBok;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button customerInformation_SaveNew_Button;
        private System.Windows.Forms.Button customerInformation_SaveClose_Button;
        private System.Windows.Forms.Button customerInformation_Cancel_Button;
        private System.Windows.Forms.NumericUpDown customerInformation_Discount_numericUpDown;
        private System.Windows.Forms.Button AddCustomer_Udpate_btn;
    }
}