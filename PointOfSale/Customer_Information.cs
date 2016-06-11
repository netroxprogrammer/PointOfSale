using PointOfSale.DbConfiguration;
using PointOfSale.Utils.CutomerData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class Customer_Information : Form
    {
        HandleCustomer customerHandle;
        private String customerId;

        public bool UnhideButton
        {
            set
            {
                AddCustomer_Udpate_btn.Visible = value;
            }
        }
        public string CustomerId
        {
            get
            {
                return customerId;
            }

            set
            {
                customerId = value;
            }
        }
        public String CustumerName
        {
            set
            {
                customerInformation_customerName_extBox.Text = value;
            }
        }
        public bool CustomerCash
        {
            set
            {
                customerInformation_cash_radioButton.Checked = value;
            }
        }

        public int CustomerDisccount
        {
            set
            {
                customerInformation_Discount_numericUpDown.Value = value;
            }
        }

        public bool Customercridt
        {
            set
            {
                customerInformation_credit_radioButton.Checked = value;
            }
        }
        public String CContact
        {
            set
            {
                customerInformation_ContactPerson_extBox.Text = value;
            }
        }
        public String CReffered
        {
            set
            {
                 customerInformation_RefferedBy_extBox.Text  = value;
            }
        }
        public String CPhone1
        {
            set
            {
                customerInformation_Phone1_extBox.Text = value;

            }
        }
        public String CPhone2
        {
            set
            {
                customerInformation_Phone2_extBox.Text = value;
            }
        }
        public String CPhone3
        {
            set
            {
                customerInformation_Phone3_extBox.Text = value;
            }
        }
        public String CFax1
        {
            set
            {
                customerInformation_Fax1_extBox.Text = value;
            }
        }
        public  String CFax2
        {
            set
            {
                customerInformation_Fax2_extBox.Text = value;
            }
        }
        public String CFax3
        {
            set
            {
                customerInformation_Fax3_extBox.Text = value;
            }
        }
        public String CEmail
        {
            set {
                customerInformation_Email_extBox.Text = value;
            }
        }
        public String CAddress
        {
            set
            {
                customerInformation_Address_extBox.Text = value;
            }
        }
        public String CRemark
        {
            set
            {
                customerInformation_Remark_extBox.Text = value;
            }
        }

        public bool updateButon
        {
            set
            {
                AddCustomer_Udpate_btn.Visible = value;
            }
        }
        public bool Cdefualt {
            set {
                customerInformation_default_checkBok.Checked = value;
                    
                    }
        }

        public bool cInActive
        {
            set
            {
                customerInformation_inactive_checkBok.Checked = value;
            }
        }
        public Customer_Information()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void Customer_Information_Load(object sender, EventArgs e)
        {
            customerHandle = new HandleCustomer();
            this.TopMost = true;
        }

        private void customerInformation_Discount_numericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewCustomer();
            customerInformation_customerName_extBox.Clear();
            customerInformation_Discount_numericUpDown.Value = 0;

            customerInformation_cash_radioButton.Checked = false;
            customerInformation_credit_radioButton.Checked = false;
            customerInformation_ContactPerson_extBox.Clear();
            customerInformation_RefferedBy_extBox.Clear();
            customerInformation_Phone1_extBox.Clear();
            customerInformation_Phone2_extBox.Clear();
            customerInformation_Phone3_extBox.Clear();
            customerInformation_Fax1_extBox.Clear();
            customerInformation_Fax2_extBox.Clear();
            customerInformation_Fax3_extBox.Clear();
            customerInformation_Email_extBox.Clear();
            customerInformation_Address_extBox.Clear();
            customerInformation_Remark_extBox.Clear();
            customerInformation_default_checkBok.Checked = false;
            customerInformation_inactive_checkBok.Checked = false;
                }

        private void customerInformation_ContactPerson_extBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCustomer_Udpate_btn_Click(object sender, EventArgs e)
        {
            String priceCheck = null;
            String customerDefault = null;
            String customerInactive = null;
            if (!String.IsNullOrEmpty(customerInformation_customerName_extBox.Text))
            {
                String cutomerName = customerInformation_customerName_extBox.Text;
                decimal customerDiscount = customerInformation_Discount_numericUpDown.Value;
                if (customerInformation_cash_radioButton.Checked)
                {
                    priceCheck = "cash";
                }

                if (customerInformation_credit_radioButton.Checked)
                {
                    priceCheck = "credit";
                }

                if (!customerInformation_credit_radioButton.Checked &&
                    !customerInformation_cash_radioButton.Checked)
                {
                    priceCheck = "";
                }
                String contactPerson = customerInformation_ContactPerson_extBox.Text;
                String refferedBy = customerInformation_RefferedBy_extBox.Text;
                String phone1 = customerInformation_Phone1_extBox.Text;
                String phone2 = customerInformation_Phone2_extBox.Text;
                String phone3 = customerInformation_Phone3_extBox.Text;
                String fax1 = customerInformation_Fax1_extBox.Text;
                String fax2 = customerInformation_Fax2_extBox.Text;
                String fax3 = customerInformation_Fax3_extBox.Text;
                String email = customerInformation_Email_extBox.Text;
                String Address = customerInformation_Address_extBox.Text;
                String remark = customerInformation_Remark_extBox.Text;
                if (customerInformation_default_checkBok.Checked)
                {
                    customerDefault = "default";
                }
                else
                {
                    customerDefault = " ";
                }
                if (customerInformation_inactive_checkBok.Checked)
                {
                    customerInactive = "inactive";
                }
                else
                {
                    customerInactive = " ";
                }
                //  add information  in CustomerBasic Table
                // int id = customerHandle.addCustomerBasicInformation(cutomerName, Decimal.ToInt32(customerDiscount), priceCheck);
                // Add CustomerInformation Table
                CustomerBasic customer = new CustomerBasic();
                customer.customerId = Int32.Parse(customerId);

                customer.customerName = cutomerName;
                customer.CustomerDiscount = Decimal.ToInt32(customerDiscount);
                customer.customerPrice = customerInactive;

                customerHandle.updateCsutomerBaisc(customer);
                CustomerInfomation customerinfo = new CustomerInfomation();
                customerinfo.CustomerPersonContact = contactPerson;
                customerinfo.CustomerReffered = refferedBy;
                customerinfo.CustomerPhone1 = phone1;
                customerinfo.CustomerPhone2 = phone2;
                customerinfo.CustomerPhone3 = phone3;
                customerinfo.CustomerFax = fax1;
                customerinfo.CustomerFax1 = fax2;
                customerinfo.CustomerFax2 = fax3;
                customerinfo.CustomerEmail = email;
                customerinfo.CustomerAddress = Address;
                customerinfo.CustomerRemark = Address;
                customerinfo.CustomerDefault = customerDefault;
                customerinfo.CustomerInactive = customerInactive;
                customerinfo.CustomerId = Int32.Parse(customerId);

                customerHandle.updateCsutomerInformation(customerinfo);
            }
        }
        private void customerInformation_Discount_numericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void customerInformation_Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void AddNewCustomer()
        {

            String priceCheck = null;
            String customerDefault = null;
            String customerInactive = null;
            String cutomerName = customerInformation_customerName_extBox.Text;
            if (!String.IsNullOrEmpty(customerInformation_customerName_extBox.Text))
            {
                decimal customerDiscount = customerInformation_Discount_numericUpDown.Value;
                if (customerInformation_cash_radioButton.Checked)
                {
                    priceCheck = "cash";
                }
                if (customerInformation_credit_radioButton.Checked)
                {
                    priceCheck = "credit";
                }
                if (!customerInformation_credit_radioButton.Checked &&
                    !customerInformation_cash_radioButton.Checked)
                {
                    priceCheck = "";
                }

                String contactPerson = customerInformation_ContactPerson_extBox.Text;
                String refferedBy = customerInformation_RefferedBy_extBox.Text;
                String phone1 = customerInformation_Phone1_extBox.Text;
                String phone2 = customerInformation_Phone2_extBox.Text;
                String phone3 = customerInformation_Phone3_extBox.Text;
                String fax1 = customerInformation_Fax1_extBox.Text;
                String fax2 = customerInformation_Fax2_extBox.Text;
                String fax3 = customerInformation_Fax3_extBox.Text;
                String email = customerInformation_Email_extBox.Text;
                String Address = customerInformation_Address_extBox.Text;
                String remark = customerInformation_Remark_extBox.Text;
                if (customerInformation_default_checkBok.Checked)
                {
                    customerDefault = "default";
                }
                else
                {
                    customerDefault = " ";
                }
                if (customerInformation_inactive_checkBok.Checked)
                {
                    customerInactive = "inactive";
                }
                else
                {
                    customerInactive = " ";
                }
                //  add information  in CustomerBasic Table
                int id = customerHandle.addCustomerBasicInformation(cutomerName, Decimal.ToInt32(customerDiscount), priceCheck);
                // Add CustomerInformation Table
                CustomerInfomation customer = new CustomerInfomation();
                customer.CustomerId = id;


                customer.CustomerPersonContact = contactPerson;
                customer.CustomerReffered = refferedBy;
                customer.CustomerPhone1 = phone1;
                customer.CustomerPhone2 = phone2;
                customer.CustomerPhone3 = phone3;
                customer.CustomerFax = fax1;
                customer.CustomerFax1 = fax2;
                customer.CustomerFax2 = fax3;
                customer.CustomerEmail = email;
                customer.CustomerAddress = fax1;
                customer.CustomerRemark = remark;
                customer.CustomerDefault = customerDefault;
                customer.CustomerInactive = customerInactive;
                Debug.WriteLine("check" + customer.CustomerPersonContact);
                customerHandle.addCustomerInformation(customer);
                MessageBox.Show("Add Customer");
            }
            else
            {
                customerInformation_customerName_extBox.BackColor = Color.Red;
            }
        }

        private void customerInformation_customerName_extBox_TextChanged(object sender, EventArgs e)
        {
            customerInformation_customerName_extBox.BackColor = Color.White;
        }

        private void customerInformation_SaveClose_Button_Click(object sender, EventArgs e)
        {
            
            AddNewCustomer();
            Close();
        }

        private void customerInformation_inactive_checkBok_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
