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
            String priceCheck = null;
            String customerDefault = null;
            String customerInactive = null;
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
          int id = customerHandle.addCustomerBasicInformation(cutomerName,Decimal.ToInt32(customerDiscount), priceCheck);
            // Add CustomerInformation Table
            CustomerInfomation customer = new CustomerInfomation();
           customer.CustomerId = id;

         
            customer.CustomerPersonContact = contactPerson;
            customer.CustomerReffered= refferedBy;
            customer.CustomerPhone1 = phone1;
            customer.CustomerPhone2 = phone2;
            customer.CustomerPhone3 = phone3;
            customer.CustomerFax =  fax1;
            customer.CustomerFax1 = fax2;
            customer.CustomerFax2 = fax3;
            customer.CustomerEmail = email;
            customer.CustomerAddress = fax1;
            customer.CustomerRemark = remark;
            customer.CustomerDefault = customerDefault;
            customer.CustomerInactive = customerInactive;
            Debug.WriteLine("check" + customer.CustomerPersonContact);
           customerHandle.addCustomerInformation(customer);
        }
    }
}
