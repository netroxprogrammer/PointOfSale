namespace PointOfSale
{
    partial class LoginAthuntication
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
            this.loginAthuntication_comboBox = new System.Windows.Forms.ComboBox();
            this.loginAthuntication_password_textbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LoginAthunticatuon_Cancel_btn = new System.Windows.Forms.Button();
            this.LoginAthunticatuon_Login_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // loginAthuntication_comboBox
            // 
            this.loginAthuntication_comboBox.FormattingEnabled = true;
            this.loginAthuntication_comboBox.Location = new System.Drawing.Point(114, 32);
            this.loginAthuntication_comboBox.Name = "loginAthuntication_comboBox";
            this.loginAthuntication_comboBox.Size = new System.Drawing.Size(209, 34);
            this.loginAthuntication_comboBox.TabIndex = 2;
            // 
            // loginAthuntication_password_textbox
            // 
            this.loginAthuntication_password_textbox.Location = new System.Drawing.Point(114, 70);
            this.loginAthuntication_password_textbox.Name = "loginAthuntication_password_textbox";
            this.loginAthuntication_password_textbox.PasswordChar = '*';
            this.loginAthuntication_password_textbox.Size = new System.Drawing.Size(209, 33);
            this.loginAthuntication_password_textbox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginAthuntication_comboBox);
            this.groupBox1.Controls.Add(this.loginAthuntication_password_textbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(85, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 119);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Please Login";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LoginAthunticatuon_Cancel_btn);
            this.groupBox2.Controls.Add(this.LoginAthunticatuon_Login_btn);
            this.groupBox2.Location = new System.Drawing.Point(116, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 50);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // LoginAthunticatuon_Cancel_btn
            // 
            this.LoginAthunticatuon_Cancel_btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginAthunticatuon_Cancel_btn.Image = global::PointOfSale.Properties.Resources.favicon_16x161;
            this.LoginAthunticatuon_Cancel_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoginAthunticatuon_Cancel_btn.Location = new System.Drawing.Point(121, 19);
            this.LoginAthunticatuon_Cancel_btn.Name = "LoginAthunticatuon_Cancel_btn";
            this.LoginAthunticatuon_Cancel_btn.Size = new System.Drawing.Size(80, 23);
            this.LoginAthunticatuon_Cancel_btn.TabIndex = 8;
            this.LoginAthunticatuon_Cancel_btn.Text = "Cancel";
            this.LoginAthunticatuon_Cancel_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoginAthunticatuon_Cancel_btn.UseVisualStyleBackColor = true;
            this.LoginAthunticatuon_Cancel_btn.Click += new System.EventHandler(this.LoginAthunticatuon_Cancel_btn_Click);
            // 
            // LoginAthunticatuon_Login_btn
            // 
            this.LoginAthunticatuon_Login_btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginAthunticatuon_Login_btn.Image = global::PointOfSale.Properties.Resources.favicon_16x163;
            this.LoginAthunticatuon_Login_btn.Location = new System.Drawing.Point(15, 19);
            this.LoginAthunticatuon_Login_btn.Name = "LoginAthunticatuon_Login_btn";
            this.LoginAthunticatuon_Login_btn.Size = new System.Drawing.Size(80, 25);
            this.LoginAthunticatuon_Login_btn.TabIndex = 7;
            this.LoginAthunticatuon_Login_btn.Text = "Login";
            this.LoginAthunticatuon_Login_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoginAthunticatuon_Login_btn.UseVisualStyleBackColor = true;
            this.LoginAthunticatuon_Login_btn.Click += new System.EventHandler(this.LoginAthunticatuon_Login_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PointOfSale.Properties.Resources.android_icon_72x7210;
            this.pictureBox1.InitialImage = global::PointOfSale.Properties.Resources.android_icon_72x7210;
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 87);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LoginAthuntication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 234);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginAthuntication";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoginAthuntication_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox loginAthuntication_comboBox;
        private System.Windows.Forms.TextBox loginAthuntication_password_textbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LoginAthunticatuon_Login_btn;
        private System.Windows.Forms.Button LoginAthunticatuon_Cancel_btn;
    }
}