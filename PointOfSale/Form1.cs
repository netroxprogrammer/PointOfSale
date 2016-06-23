using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using PointOfSale.DbConfiguration;
using PointOfSale.Employee;
using PointOfSale.ListForms;
using PointOfSale.OthersForms;
using PointOfSale.TableHandlerForms;
using PointOfSale.TableInformationForm;
using PointOfSale.Utils;
using PointOfSale.Utils.CutomerData;
using PointOfSale.Utils.TablesClass;
using System;
using System.Collections;
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
    public partial class WorkingForm : Form
    {
        String barcode = null;
        HandleProducts products;
        HandleEmployee employee;
        String tBalance = null;
        String tPayemnt = null;
        HandleInvoice invoice;
        HandleCustomer handleCustomer;
        ArrayList prod;
        static int counter = 0;
        int invoiceNumber = 0;
        int sum = 0;
        public WorkingForm()
        {
            InitializeComponent();
        }

        private void upperMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // 
        }

        private void userManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void perchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void WorkingForm_Load(object sender, EventArgs e)
        {
            products = new HandleProducts();
            employee = new HandleEmployee();
            handleCustomer =  new HandleCustomer();
            invoice = new HandleInvoice();

            invoiceNumber = invoice.getInvoiceNumber() + 1;
            SaleInvoice_invuse_textb.Text = invoiceNumber.ToString();
            loadAllData();
        
          
            workingForm_SaleInvoice_Panel.Visible = false;

            if (Constants.checkLogin == false)
            {
                this.Hide();
                new LoginAthuntication().Show();
            }
            if (Constants.checkLogin == true)
            {
                new LoginAthuntication().Hide();
            }




        }

        private void stockAdjustmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void customer_Button_Click(object sender, EventArgs e)
        {
            contextMenuStrip_Customer.Show(customer_Button, new Point(0, customer_Button.Height));
        }

        private void suppliers_Button_Click(object sender, EventArgs e)
        {
            contextMenuStrip_Supplier.Show(suppliers_Button, new Point(0, suppliers_Button.Height));
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void inventory_Button_Click(object sender, EventArgs e)
        {
            contextMenuStrip_Inventory.Show(inventory_Button, new Point(0, inventory_Button.Height));

        }

        private void addNewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Customer_Information().Show();
        }

        private void addNewCustomersToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            new Customer_Information().Show();

        }

        private void addNewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddNewProduct().Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //changePasswordToolStripMenuItem.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewTableInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TableInformation().Show();
        }

        private void importSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ImportSheet().Show();
        }

        private void addProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddOtherThings().Show();

        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddEmployee().Show();
        }

        private void customersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CustomerList().Show();


        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

       

      
        /*
        get Employee List
        */

      

       
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Customer_Information().Show();
        }

        private void listOfEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmployeList().Show();
        }

        private void addNewEmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void WorkingForm_EmployeList_MouseClick(object sender, MouseEventArgs e)
        {


            //MessageBox.Show(name);
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProductList().Show();
        }

        private void WorkingForm_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WorkingForm_Employ_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WorkingForm_AllProduct_listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void WorkingForm_customerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
       
            TableAddNewProducts getprod = products.productByItemCode(salePanel_itemCode_comboBox.SelectedItem.ToString());
            // Debug.WriteLine("Select Index ---  " + Sale_Panel_ProductName_comboBox.SelectedIndex + 1);
            //  salePanel_Descreption_comboBox.Items.Clear();
            //   salePanel_CompanyName_comboBox.Items.Clear();
            //   salePanel_Location_comboBox.Items.Clear();
            //   Sale_Panel_ProductName_comboBox.Items.Clear();
            //   salePanel_Purpose_comboBox.Items.Clear();
            salePanel_itemCode_comboBox.Text = getprod.BarCode;
            salePanel_itemCode_comboBox.Items.Add(getprod.BarCode);
            Sale_Panel_ProductName_comboBox.Text = getprod.ProductName;
            if (!String.IsNullOrEmpty(getprod.ProductDescription))
            {      //  check no empty space add in ComboBox

                salePanel_Descreption_comboBox.Text = getprod.ProductDescription;
                salePanel_Descreption_comboBox.Items.Add(getprod.ProductDescription);

            }
            else
            {
                salePanel_Descreption_comboBox.Text = "";
            }
            if (!String.IsNullOrEmpty(getprod.ProductCompanyName))
            {
                salePanel_CompanyName_comboBox.Text = getprod.ProductCompanyName;
                salePanel_CompanyName_comboBox.Items.Add(getprod.ProductCompanyName);


            }
            else
            {
                salePanel_CompanyName_comboBox.Text = "";
            }
            if (!String.IsNullOrEmpty(getprod.Location1))
            {
                salePanel_Location_comboBox.Text = getprod.Location1;
                salePanel_Location_comboBox.Items.Add(getprod.Location1);

            }
            else
            {
                salePanel_Location_comboBox.Text = "";
            }
            if (getprod.ProductExpidate != null)
            {
                SalePanel_Expirydate_dateTimePicker.Value = getprod.ProductExpidate;
            }
            else
            {


            }
            if (!String.IsNullOrEmpty(getprod.ProductPurpose))
            {
                salePanel_Purpose_comboBox.Text = getprod.ProductPurpose;
                salePanel_Purpose_comboBox.Items.Add(getprod.ProductPurpose);
            }
            else
            {
                salePanel_Purpose_comboBox.Text = "";
            }

            salePanel_Price_tetxbox.Text = getprod.ProductSalePrice.ToString();
            salePrice_QntHand_textBox.Clear();
            salePrice_QntHand_textBox.Text = getprod.ProductTotalPacks.ToString();
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            ///  salePanel_itemCode_comboBox.Items.Clear();
            // salePanel_Descreption_comboBox.Items.Clear();
            // salePanel_CompanyName_comboBox.Items.Clear();
            // salePanel_Location_comboBox.Items.Clear();
            // salePanel_Purpose_comboBox.Items.Clear();
            String Pname = Sale_Panel_ProductName_comboBox.SelectedItem.ToString();
            int index = Sale_Panel_ProductName_comboBox.SelectedIndex + 1;
            ArrayList get = products.productByName(index.ToString());
            Debug.WriteLine("Select Index ---  " + Sale_Panel_ProductName_comboBox.SelectedIndex + 1);
          
            foreach (TableAddNewProducts getprod in get)
            {

                salePanel_itemCode_comboBox.Text = getprod.BarCode;
                // salePanel_itemCode_comboBox.Items.Add(getprod.BarCode);

                if (!String.IsNullOrEmpty(getprod.ProductDescription))
                {      //  check no empty space add in ComboBox

                    salePanel_Descreption_comboBox.Text = getprod.ProductDescription;
                    // salePanel_Descreption_comboBox.Items.Add(getprod.ProductDescription);

                }
                else
                {
                    salePanel_Descreption_comboBox.Text = "";
                }

                if (!String.IsNullOrEmpty(getprod.ProductCompanyName))
                {
                    salePanel_CompanyName_comboBox.Text = getprod.ProductCompanyName;
                    //   salePanel_CompanyName_comboBox.Items.Add(getprod.ProductCompanyName);


                }
                else
                {
                    salePanel_CompanyName_comboBox.Text = "";
                }
                if (!String.IsNullOrEmpty(getprod.Location1))
                {
                    salePanel_Location_comboBox.Text = getprod.Location1;
                    ///   salePanel_Location_comboBox.Items.Add(getprod.Location1);

                }
                else
                {
                    salePanel_Location_comboBox.Text = "";
                }
                if (getprod.ProductExpidate != null)
                {
                    SalePanel_Expirydate_dateTimePicker.Value = getprod.ProductExpidate;
                }
                else
                {


                }
                if (!String.IsNullOrEmpty(getprod.ProductPurpose))
                {
                    salePanel_Purpose_comboBox.Text = getprod.ProductPurpose;
                    //  salePanel_Purpose_comboBox.Items.Add(getprod.ProductPurpose);
                }
                else
                {
                    salePanel_Purpose_comboBox.Text = "";
                }

                salePanel_Price_tetxbox.Text = getprod.ProductSalePrice.ToString();
                salePrice_QntHand_textBox.Text = getprod.ProductTotalPacks.ToString();
              
            }
           
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            //  salePanel_itemCode_comboBox.Items.Clear();
            //salePanel_CompanyName_comboBox.Items.Clear();
            //salePanel_Location_comboBox.Items.Clear();
            //salePanel_Purpose_comboBox.Items.Clear();
            String Pname = salePanel_Descreption_comboBox.SelectedItem.ToString();
            int index = salePanel_Descreption_comboBox.SelectedIndex + 1;
            TableAddNewProducts getprod = products.productByDiscreption(index.ToString());
            Debug.WriteLine("Select Index ---  " + salePanel_Descreption_comboBox.SelectedIndex + 1);

            salePanel_itemCode_comboBox.Text = getprod.BarCode;
            //salePanel_itemCode_comboBox.Items.Add(getprod.BarCode);

            if (!String.IsNullOrEmpty(getprod.ProductCompanyName))
            {
                salePanel_CompanyName_comboBox.Text = getprod.ProductCompanyName;
                // salePanel_CompanyName_comboBox.Items.Add(getprod.ProductCompanyName);


            }
            else
            {
                salePanel_CompanyName_comboBox.Text = "";
            }
            if (!String.IsNullOrEmpty(getprod.Location1))
            {
                salePanel_Location_comboBox.Text = getprod.Location1;
                salePanel_Location_comboBox.Items.Add(getprod.Location1);

            }
            else
            {
                salePanel_Location_comboBox.Text = "";
            }
            if (getprod.ProductExpidate != null)
            {
                SalePanel_Expirydate_dateTimePicker.Value = getprod.ProductExpidate;
            }
            else
            {


            }
            if (!String.IsNullOrEmpty(getprod.ProductPurpose))
            {
                salePanel_Purpose_comboBox.Text = getprod.ProductPurpose;
                salePanel_Purpose_comboBox.Items.Add(getprod.ProductPurpose);
            }
            else
            {
                salePanel_Purpose_comboBox.Text = "";
            }

            salePanel_Price_tetxbox.Text = getprod.ProductSalePrice.ToString();
            //salePanel_Dsecreption_comboBox.Items.Clear();
            salePrice_QntHand_textBox.Text = getprod.ProductTotalPacks.ToString();


        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
          int id=  saveInvoiceData();
            clearInvoiceForm();
            saleInvoice_productList.Clear();
            salePricE_totalPrice_textBox.Clear();
            saleInvoice_productList.Update();
            sum = 0;
            saleInvoice_totalAmn_textbox.Clear();
            saleInvoice_totalnetAmount_textbox.Clear();
            saleInvoice_afterCalculation_textbox.Clear();
            saleInvoice_Discount_Textbox.Clear();
        }

        /*
        Savc All Invoice Data List
        */
        public int  saveInvoiceData()
        {
            int getid = 0;
            String empNAme = null;
            String customerName = null;
            String totalamount = null;
            String totalnetAmount = null;
            String disountpersent = null;
            String discuntprise = null;
            String discount = null;
            String totalbill = null;
            
           
            if (!String.IsNullOrEmpty(saleInvoice_totalAmn_textbox.Text) && (!String.IsNullOrEmpty(saleInvoice_totalnetAmount_textbox.Text)))
            {
                if (salePanel_Employee_comboBox.SelectedIndex != -1)
                {
                    empNAme = salePanel_Employee_comboBox.SelectedItem.ToString();
                }
                else
                {
                    empNAme = "";
                }
                if (salePanel_Customer_comboBox.SelectedIndex != -1)
                {
                    customerName = salePanel_Customer_comboBox.SelectedItem.ToString();
                }
                else {
                    customerName = "";
                }
               

                DateTime date = dateTimePicker1.Value;
                totalamount = saleInvoice_totalAmn_textbox.Text;
                totalnetAmount = saleInvoice_totalnetAmount_textbox.Text;
                String peyemnt_method = "";

                if (saleInvoicePayment_cash.Checked)
                {
                    peyemnt_method = "Cash";
                }
                if (saleInvoicePayment_credit.Checked)
                {
                    peyemnt_method = "credit";
                }


               
              
                if (!String.IsNullOrEmpty(saleInvoice_Discount_Textbox.Text) &&
                    String.IsNullOrEmpty(saleInvoice_afterCalculation_textbox.Text))
                {
                    disountpersent = saleInvoice_Discount_Textbox.Text;
                    discount = disountpersent;
                    MessageBox.Show(discount);
                }
                else if (!String.IsNullOrEmpty(saleInvoice_afterCalculation_textbox.Text) &&
                   String.IsNullOrEmpty(saleInvoice_Discount_Textbox.Text))
                {
                    discuntprise = saleInvoice_afterCalculation_textbox.Text;
                    discount = discuntprise;
                }
                else
                {
                    // disountpersent = "0";
                    discount = "0";
                }

                if (!String.IsNullOrEmpty(salePricE_totalPrice_textBox.Text))
                {
                    totalbill = salePricE_totalPrice_textBox.Text;

                }
                if (String.IsNullOrEmpty(tPayemnt))
                {


                    if (!String.IsNullOrEmpty(saleInvoice_Payment_textbox.Text))
                    {
                        tPayemnt = saleInvoice_Payment_textbox.Text;
                    }
                    else
                    {
                        tPayemnt = "0";

                        saleInvoice_balacne_textbox.Text = salePricE_totalPrice_textBox.Text;

                    }
                }
                if (!String.IsNullOrEmpty(saleInvoice_balacne_textbox.Text))
                {
                    tBalance = saleInvoice_balacne_textbox.Text;

                }

                //   saleInvoice_afterCalculation_textbox


                TableInvoice inv = new TableInvoice();
                inv.EmployeeName = empNAme;
                inv.CustomerName = customerName;
                inv.CurrentDate = date;
                inv.TotalAmount = Int32.Parse(totalamount);
                inv.TotalNetAmount = Int32.Parse(totalnetAmount);
                inv.PaymentMethod = peyemnt_method;
                inv.TotalDiscount = Int32.Parse(discount);
                inv.Disception1 = writeDescription.Text;
               
                inv.LoginBy = Constants.userlogin;
                if (saleInvoicePayment_cash.Checked){
                    tBalance = "0";
                    inv.Balance = Int32.Parse(tBalance);
                    tPayemnt = salePricE_totalPrice_textBox.Text;
                    inv.TotalPayment = Int32.Parse(tPayemnt);
                }
                else
                {
                    inv.Balance = Int32.Parse(tBalance);
                }
                inv.TotalPayment = Int32.Parse(tPayemnt);

                int id = invoice.AddSaleoInvoice(inv);
                if (id > 0)
                {
                    getid = id;
                    MessageBox.Show("invoice Add");
                    //MessageBox.Show(id.ToString());
                    addInvoiceData();

                }
                tPayemnt = null;
            }
            return getid;
        }
        private void saleInvoiceListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaleInvoiceList list = new SaleInvoiceList();
            list.Show();
        }


        private void newSaleInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workingForm_SaleInvoice_Panel.Visible = true;


        }

        /*
       *  Load Product Name
       */
        public void loadAllData()
        {
            ArrayList getname = products.getProductList("no");
            foreach (TableAddNewProducts name in getname)
            {

                Sale_Panel_ProductName_comboBox.Items.Add(name.ProductName);
                if (!String.IsNullOrEmpty(name.ProductDescription))
                {
                    salePanel_Descreption_comboBox.Items.Add(name.ProductDescription);
                }
                else
                {
                    salePanel_Descreption_comboBox.Items.Add("No Description Found");

                }
                if (!String.IsNullOrEmpty(name.ProductCompanyName))
                {
                    salePanel_CompanyName_comboBox.Items.Add(name.ProductCompanyName);
                }
                else
                {

                    salePanel_CompanyName_comboBox.Items.Add("No Company Name Found");
                }
                if (!String.IsNullOrEmpty(name.Location1))
                {
                    salePanel_Location_comboBox.Items.Add(name.Location1);
                }
                else
                {
                    salePanel_Location_comboBox.Items.Add("No Company Location Found");

                }
                if (!String.IsNullOrEmpty(name.ProductPurpose))
                {
                    salePanel_Purpose_comboBox.Items.Add(name.ProductPurpose);
                }
                else
                {
                    salePanel_Location_comboBox.Items.Add("No Company Purpose Found");
                }
                if (!String.IsNullOrEmpty(name.BarCode))
                {
                    salePanel_itemCode_comboBox.Items.Add(name.BarCode);
                }
                else
                {
                    salePanel_Descreption_comboBox.Items.Add("No Company BarCode Found");
                }
            }

            // load Employee Names
            ArrayList empl = employee.getEmployeeBasic();
            foreach (TotalEmployeeData em in empl)
            {

                salePanel_Employee_comboBox.Items.Add(em.EmployeeName);
            }

            /*  Load Customer Names */

            ArrayList custm = handleCustomer.getCustomersNames();
            foreach (TotalCustomerClass cutm in custm)
            {
                salePanel_Customer_comboBox.Items.Add(cutm.customerName);
            }

        }

        private void Sale_Panel_ProductName_comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                salePanel_Descreption_comboBox.Items.Clear();
                salePanel_itemCode_comboBox.Items.Clear();
                Sale_Panel_ProductName_comboBox.Items.Clear();
                salePanel_Purpose_comboBox.Items.Clear();
                salePanel_CompanyName_comboBox.Items.Clear();
                salePanel_Location_comboBox.Items.Clear();
                loadAllData();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void salePanel_Dsecreption_comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                salePanel_Descreption_comboBox.Items.Clear();
                salePanel_itemCode_comboBox.Items.Clear();
                Sale_Panel_ProductName_comboBox.Items.Clear();
                salePanel_Purpose_comboBox.Items.Clear();
                salePanel_CompanyName_comboBox.Items.Clear();
                salePanel_Location_comboBox.Items.Clear();
                loadAllData();
            }

        }

        private void salePanel_CompanyName_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            //salePanel_Location_comboBox.Items.Clear();
            //salePanel_Purpose_comboBox.Items.Clear();
            String Pname = salePanel_CompanyName_comboBox.SelectedItem.ToString();
            int index = salePanel_CompanyName_comboBox.SelectedIndex + 1;
            TableAddNewProducts getprod = products.productByDiscreption(index.ToString());
            Debug.WriteLine("Select Index ---  " + salePanel_CompanyName_comboBox.SelectedIndex + 1);


            salePanel_itemCode_comboBox.Text = getprod.BarCode;
            //salePanel_itemCode_comboBox.Items.Add(getprod.BarCode);
            if (!String.IsNullOrEmpty(getprod.ProductDescription))
            {
                salePanel_Descreption_comboBox.Items.Add(getprod.ProductDescription);
            }
            else
            {
                //  salePanel_Dsecreption_comboBox.Text = "";
            }
            if (!String.IsNullOrEmpty(getprod.Location1))
            {
                salePanel_Location_comboBox.Text = getprod.Location1;
                salePanel_Location_comboBox.Items.Add(getprod.Location1);

            }
            else
            {
                salePanel_Location_comboBox.Text = "";
            }
            if (getprod.ProductExpidate != null)
            {
                SalePanel_Expirydate_dateTimePicker.Value = getprod.ProductExpidate;
            }
            else
            {


            }
            if (!String.IsNullOrEmpty(getprod.ProductPurpose))
            {
                salePanel_Purpose_comboBox.Text = getprod.ProductPurpose;
                salePanel_Purpose_comboBox.Items.Add(getprod.ProductPurpose);
            }
            else
            {
                salePanel_Purpose_comboBox.Text = "";
            }

            salePanel_Price_tetxbox.Text = getprod.ProductSalePrice.ToString();
            //salePanel_Dsecreption_comboBox.Items.Clear();
            salePrice_QntHand_textBox.Text = getprod.ProductTotalPacks.ToString();

            salePanel_CompanyName_comboBox.Text = Pname;


        }

        private void salePanel_CompanyName_comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                salePanel_Descreption_comboBox.Items.Clear();
                salePanel_itemCode_comboBox.Items.Clear();
                Sale_Panel_ProductName_comboBox.Items.Clear();
                salePanel_Purpose_comboBox.Items.Clear();
                salePanel_CompanyName_comboBox.Items.Clear();
                salePanel_Location_comboBox.Items.Clear();
                loadAllData();
            }

        }

        private void salePanel_Location_comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                salePanel_Descreption_comboBox.Items.Clear();
                salePanel_itemCode_comboBox.Items.Clear();
                Sale_Panel_ProductName_comboBox.Items.Clear();
                salePanel_Purpose_comboBox.Items.Clear();
                salePanel_CompanyName_comboBox.Items.Clear();
                salePanel_Location_comboBox.Items.Clear();
                loadAllData();
            }

        }

        private void salePanel_Purpose_comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                salePanel_Descreption_comboBox.Items.Clear();
                salePanel_itemCode_comboBox.Items.Clear();
                Sale_Panel_ProductName_comboBox.Items.Clear();
                salePanel_Purpose_comboBox.Items.Clear();
                salePanel_CompanyName_comboBox.Items.Clear();
                salePanel_Location_comboBox.Items.Clear();
                loadAllData();
            }

        }

        private void salePanel_itemCode_comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                salePanel_Descreption_comboBox.Items.Clear();
                salePanel_itemCode_comboBox.Items.Clear();
                Sale_Panel_ProductName_comboBox.Items.Clear();
                salePanel_Purpose_comboBox.Items.Clear();
                salePanel_CompanyName_comboBox.Items.Clear();
                salePanel_Location_comboBox.Items.Clear();
                loadAllData();
            }

        }

        private void salePanel_qntyu_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                int price = Int32.Parse(salePanel_Price_tetxbox.Text);
                int quantity = Int32.Parse(salePanel_qntyu_textBox.Text);

                salePanel_Amount_textBox.Text = (price * quantity).ToString();
                salePanel_NetAmount_textBox.Text = (price * quantity).ToString();
                //  salePanel_RS_textBox.Text = (price * quantity).ToString();
            }
        }

        private void salePanel_qntyu_textBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void inactiveProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void showAllProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void WorkingForm_customerPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void WorkingForm_customerPanel_DoubleClick(object sender, EventArgs e)
        {



        }

        private void WorkingForm_listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void inactiveCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
        }

        private void WorkingForm_Employ_Panel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void WorkingForm_EmployeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salePanel_Price_tetxbox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void salePanel_bonuce_textBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void salePanel_Discount_textBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void salePanel_RS_textBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (salePanel_itemCode_comboBox.SelectedIndex != -1 && !String.IsNullOrEmpty(salePanel_Price_tetxbox.Text))
            {

                if (Int32.Parse(salePrice_QntHand_textBox.Text) == 0)
                {
                    clearInvoiceForm();
                    MessageBox.Show("Sorry Product Quantity is ZERO");

                }
                else {

                    String PName = null, description = null, companyName = null, location = null, purpose = null;
                    //int invoiceNumber = invoice.getInvoiceNumber() +1;

                    float discount = 0;
                    int price, bonace, quantity = 0, amount = 0, Rs, netAmount = 0;
                    DateTime expriydate;
                    if (Sale_Panel_ProductName_comboBox.SelectedIndex != -1)
                    {
                        PName = Sale_Panel_ProductName_comboBox.SelectedItem.ToString();
                    }
                    else
                    {
                        Sale_Panel_ProductName_comboBox.BackColor = Color.Red;
                    }


                    price = Int32.Parse(salePanel_Price_tetxbox.Text);
                    if (!String.IsNullOrEmpty(salePanel_bonuce_textBox.Text))
                    {
                        bonace = Int32.Parse(salePanel_bonuce_textBox.Text);
                    }
                    else
                    {
                        bonace = 0;
                        salePanel_bonuce_textBox.Text = "0";
                    }
                    if (!String.IsNullOrEmpty(salePanel_qntyu_textBox.Text))
                    {
                        quantity = Int32.Parse(salePanel_qntyu_textBox.Text);
                    }
                    else
                    {
                        quantity = 1;
                        salePanel_qntyu_textBox.Text = "1";
                    }
                    if (!String.IsNullOrEmpty(salePanel_Amount_textBox.Text))
                    {
                        amount = Int32.Parse(salePanel_Amount_textBox.Text);
                    }
                    else
                    {
                        amount = price * quantity;
                        salePanel_Amount_textBox.Text = amount.ToString();
                    }

                    //     amount = Int32.Parse(salePanel_Amount_textBox.Text);
                    if (!String.IsNullOrEmpty(salePanel_Discount_textBox.Text))
                    {
                        int q = quantity * price;
                        discount = float.Parse(salePanel_Discount_textBox.Text);
                        double dvalue = Math.Round((discount / 100) * q);
                        //   salePanel_RS_textBox.Text = (q - dvalue).ToString();
                        salePanel_NetAmount_textBox.Text = (q - dvalue).ToString();
                    }
                    else
                    {

                        int q = quantity * price;

                        salePanel_RS_textBox.Text = q.ToString();
                        salePanel_NetAmount_textBox.Text = q.ToString();
                    }
                    if (!String.IsNullOrEmpty(salePanel_RS_textBox.Text) || String.IsNullOrEmpty(salePanel_RS_textBox.Text))
                    {
                        if (!String.IsNullOrEmpty(salePanel_Discount_textBox.Text))
                        {
                            {
                                int q = quantity * price;
                                discount = float.Parse(salePanel_Discount_textBox.Text);
                                double dvalue = Math.Round((discount / 100) * q);
                                salePanel_RS_textBox.Text = (q - dvalue).ToString();
                                salePanel_NetAmount_textBox.Text = (q - dvalue).ToString();
                            }

                        }

                    }

                    if (!String.IsNullOrEmpty(salePanel_NetAmount_textBox.Text))
                    {
                        netAmount = Int32.Parse(salePanel_NetAmount_textBox.Text);
                    }
                    else
                    {
                        salePanel_NetAmount_textBox.Text = salePanel_RS_textBox.Text;
                    }
                    expriydate = SalePanel_Expirydate_dateTimePicker.Value;

                    if (salePanel_Descreption_comboBox.SelectedIndex != -1)
                    {
                        description = salePanel_Descreption_comboBox.SelectedItem.ToString();
                    }
                    if (salePanel_CompanyName_comboBox.SelectedIndex != -1)
                    {
                        companyName = salePanel_CompanyName_comboBox.SelectedItem.ToString();
                    }
                    if (salePanel_Location_comboBox.SelectedIndex != -1)
                    {
                        location = salePanel_Location_comboBox.SelectedItem.ToString();
                    }
                    if (salePanel_Purpose_comboBox.SelectedIndex != -1)
                    {
                        purpose = salePanel_Purpose_comboBox.SelectedItem.ToString();
                    }

                    barcode = salePanel_itemCode_comboBox.Text;

                    String[] rows = { (++counter).ToString(), PName, location, purpose, expriydate.ToString(), price.ToString(), quantity.ToString(), amount.ToString(), discount.ToString(), netAmount.ToString(), bonace.ToString() };
                    ListViewItem item = new ListViewItem(rows);

                    saleInvoice_productList.Items.Add(item);
                    salePricE_totalPrice_textBox.Clear();
                    sum = 0;
                    for (int i = 0; i < saleInvoice_productList.Items.Count; i++)
                    {
                        sum = sum + Int32.Parse(saleInvoice_productList.Items[i].SubItems[9].Text);
                    }
                    PName = null;
                    clearInvoiceForm();
                    
                }
            }
        }
        /*
         clear  invocie form 
        */

            public  void clearInvoiceForm()
        {

            salePricE_totalPrice_textBox.Text = sum.ToString();
            saleInvoice_totalAmn_textbox.Text = sum.ToString();
            saleInvoice_totalnetAmount_textbox.Text = sum.ToString();
            salePanel_itemCode_comboBox.Text = "";
            Sale_Panel_ProductName_comboBox.Text = "";
            salePanel_Price_tetxbox.Clear();
            salePanel_qntyu_textBox.Clear();
            salePanel_Amount_textBox.Clear();
            salePanel_Discount_textBox.Clear();

            salePanel_RS_textBox.Clear();

            salePanel_NetAmount_textBox.Clear();

            salePanel_Descreption_comboBox.Text = "";
            salePanel_CompanyName_comboBox.Text = "";
            salePanel_Location_comboBox.Text = "";
            SalePanel_Expirydate_dateTimePicker.Value = DateTime.Now;
            salePanel_Purpose_comboBox.Text = "";
            SaleInvoice_invuse_textb.Clear();
            invoiceNumber = invoice.getInvoiceNumber() + 1;
            SaleInvoice_invuse_textb.Text = invoiceNumber.ToString();
            saleInvoice_balacne_textbox.Clear();
            saleInvoice_Payment_textbox.Clear();
        }
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salePanel_Discount_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                float discount;
                int price, bonace, quantity, amount, Rs, netAmount;
                price = Int32.Parse(salePanel_Price_tetxbox.Text);
                if (!String.IsNullOrEmpty(salePanel_qntyu_textBox.Text))
                {
                    quantity = Int32.Parse(salePanel_qntyu_textBox.Text);
                }
                else
                {
                    quantity = 1;
                    salePanel_qntyu_textBox.Text = "1";
                }
                if (!String.IsNullOrEmpty(salePanel_RS_textBox.Text) || String.IsNullOrEmpty(salePanel_RS_textBox.Text))
                {
                    if (!String.IsNullOrEmpty(salePanel_Discount_textBox.Text))
                    {
                        {
                            int q = quantity * price;
                            discount = float.Parse(salePanel_Discount_textBox.Text);
                            double dvalue = Math.Round((discount / 100) * q);
                            salePanel_RS_textBox.Text = (q - dvalue).ToString();
                            salePanel_NetAmount_textBox.Text = (q - dvalue).ToString();
                        }

                    }

                }
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                float disc;
                int totalprice, bonace, amount, Rs, netAmount;

                if (!String.IsNullOrEmpty(saleInvoice_Discount_Textbox.Text) &&
                    !String.IsNullOrEmpty(saleInvoice_totalAmn_textbox.Text))
                {
                    totalprice = Int32.Parse(saleInvoice_totalAmn_textbox.Text);
                    disc = Int32.Parse(saleInvoice_Discount_Textbox.Text);

                    // discount = float.Parse(salePanel_Discount_textBox.Text);
                    double dvalue = Math.Round((disc / 100) * totalprice);
                    salePricE_totalPrice_textBox.Text = (totalprice - dvalue).ToString();
                 //   saleInvoice_totalAmn_textbox.Text = (totalprice - dvalue).ToString();
                    saleInvoice_totalnetAmount_textbox.Text = (totalprice - dvalue).ToString();
                }
                if(String.IsNullOrEmpty(saleInvoice_Discount_Textbox.Text))
                {
                    saleInvoice_totalnetAmount_textbox.Text = saleInvoice_totalAmn_textbox.Text;
                    salePricE_totalPrice_textBox.Text = saleInvoice_totalAmn_textbox.Text;
                }



            }
        }

        private void textBox13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrEmpty(saleInvoice_Payment_textbox.Text))
                {
                    int ans = Int32.Parse(salePricE_totalPrice_textBox.Text) - Int32.Parse(saleInvoice_Payment_textbox.Text);
                    saleInvoice_balacne_textbox.Text = ans.ToString();
                }

            }
        }

        private void salePanel_Location_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salePanel_Purpose_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salePanel_RS_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {

                int price, bonace, quantity, Rs, netAmount;
                if (!String.IsNullOrEmpty(salePanel_RS_textBox.Text))
                {
                    Rs = Int32.Parse(salePanel_RS_textBox.Text);
                    price = Int32.Parse(salePanel_Price_tetxbox.Text);
                    if (!String.IsNullOrEmpty(salePanel_qntyu_textBox.Text))
                    {
                        quantity = Int32.Parse(salePanel_qntyu_textBox.Text);
                    }
                    else
                    {
                        quantity = 1;
                        salePanel_qntyu_textBox.Text = "1";
                    }
                    int amount = price * quantity;

                    if (amount > Rs)
                    {

                        salePanel_NetAmount_textBox.Text = (amount - Rs).ToString();
                    }
                }
            }

        }

        private void saleInvoice_afterCalculation_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                if (!String.IsNullOrEmpty(saleInvoice_afterCalculation_textbox.Text)) { 
                int ans = sum - Int32.Parse(saleInvoice_afterCalculation_textbox.Text);
                 //   saleInvoice_totalAmn_textbox.Text = ans.ToString();
                    saleInvoice_totalnetAmount_textbox.Text = ans.ToString();
                    salePricE_totalPrice_textBox.Text = ans.ToString();
                }
                if (String.IsNullOrEmpty(saleInvoice_afterCalculation_textbox.Text))
                {
                    saleInvoice_totalnetAmount_textbox.Text = saleInvoice_totalAmn_textbox.Text;
                    salePricE_totalPrice_textBox.Text = saleInvoice_totalAmn_textbox.Text;
                }


            }
        }

        private void WorkingForm_AllProduct_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salePanel_Customer_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saleInvoice_productList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                /*
                String id = saleInvoice_productList.SelectedItems[0].SubItems[0].Text;
                String name = saleInvoice_productList.SelectedItems[0].SubItems[1].Text;
                String phone = saleInvoice_productList.SelectedItems[0].SubItems[2].Text;
                String fName = saleInvoice_productList.SelectedItems[0].SubItems[3].Text;
                */
                String amount = saleInvoice_productList.SelectedItems[0].SubItems[7].Text;
                int price = Int32.Parse(salePricE_totalPrice_textBox.Text) - Int32.Parse(amount);
                salePricE_totalPrice_textBox.Text = price.ToString();
                saleInvoice_productList.SelectedItems[0].Remove();
                saleInvoice_productList.Update();
                saleInvoice_productList.Refresh();
                //  MessageBox.Show(name);

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void saleInvoice_Discount_Textbox_TextChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(saleInvoice_Discount_Textbox.Text))
            {
                saleInvoice_afterCalculation_textbox.Clear();
            }
        }

        private void saleInvoice_afterCalculation_textbox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(saleInvoice_afterCalculation_textbox.Text))
            {
                saleInvoice_Discount_Textbox.Clear();
            }
            else
            {
               
            }
        }

        private void saleInvoice_productList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            String id = saleInvoice_productList.SelectedItems[0].SubItems[0].Text;
            String proName = saleInvoice_productList.SelectedItems[0].SubItems[1].Text;
            String location = saleInvoice_productList.SelectedItems[0].SubItems[2].Text;
            String purpose = saleInvoice_productList.SelectedItems[0].SubItems[3].Text;

            String expiry = saleInvoice_productList.SelectedItems[0].SubItems[4].Text;
            String saleprice = saleInvoice_productList.SelectedItems[0].SubItems[5].Text;
            String quantity = saleInvoice_productList.SelectedItems[0].SubItems[6].Text;
            String amuont = saleInvoice_productList.SelectedItems[0].SubItems[7].Text;
            String discount = saleInvoice_productList.SelectedItems[0].SubItems[8].Text;
            String netamount = saleInvoice_productList.SelectedItems[0].SubItems[9].Text;

            Sale_Panel_ProductName_comboBox.Text = proName;
            salePanel_Price_tetxbox.Text = saleprice;
            salePanel_qntyu_textBox.Text = quantity;
            salePanel_Amount_textBox.Text = amuont;
            salePanel_Discount_textBox.Text = discount;
            salePanel_NetAmount_textBox.Text = netamount;
            SalePanel_Expirydate_dateTimePicker.Value = System.Convert.ToDateTime(expiry);
            salePanel_Location_comboBox.Text = location;
            salePanel_Purpose_comboBox.Text = purpose;
            salePanel_itemCode_comboBox.Text = barcode;
            int calculationl = Int32.Parse(salePricE_totalPrice_textBox.Text)-  (Int32.Parse(netamount) * Int32.Parse(quantity));

            int calculation2 = Int32.Parse(saleInvoice_totalAmn_textbox.Text) - (Int32.Parse(netamount) * Int32.Parse(quantity));

            int calculation3 = Int32.Parse(saleInvoice_totalnetAmount_textbox.Text) - (Int32.Parse(netamount) * Int32.Parse(quantity));

            salePricE_totalPrice_textBox.Text = calculationl.ToString();
            saleInvoice_totalAmn_textbox.Text = calculation2.ToString();
            saleInvoice_totalnetAmount_textbox.Text = calculation3.ToString();
            saleInvoice_productList.SelectedItems[0].Remove();

            saleInvoice_productList.Update();
            barcode = null;
        }

        private void salePricE_totalPrice_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        /*
        Add invoiceData in database
        */

        public void addInvoiceData()
        {

           

            foreach (ListViewItem item in saleInvoice_productList.Items)
            {
                TableInvoiceData data = new TableInvoiceData();

                //.Items[i].Selected = true;

                //  String netamount = saleInvoice_productList.SelectedItems[i].SubItems[9].Text;
                //MessageBox.Show(netamount.ToString());

                String listid = item.SubItems[0].Text;
                   String proName = item.SubItems[1].Text;
                   String location = item.SubItems[2].Text;
                   String purpose = item.SubItems[3].Text;

                   String expiry = item.SubItems[4].Text;
                   String saleprice = item.SubItems[5].Text;
                   String quantity = item.SubItems[6].Text;
                   String amuont = item.SubItems[7].Text;
                   String discount = item.SubItems[8].Text;
                   String netamount = item.SubItems[9].Text;
                   String bonus = item.SubItems[10].Text;
                MessageBox.Show(invoiceNumber.ToString());
                   data.InvoiceId = invoiceNumber;
                   data.ProductListNumber = Int32.Parse(listid);
                   data.ProductName = proName;
                if (!String.IsNullOrEmpty(location))
                {
                    data.Location = location;
                }
                else
                {
                    data.Location = "";
                }
                if (!String.IsNullOrEmpty(purpose))
                {
                    data.Purpose = purpose;
                }
                else
                {
                    data.Purpose = "";
                }
             
                   data.ExpiryDate1 = expiry;
                   data.SalePrice = Int32.Parse(saleprice);
                   data.Qty1 = Int32.Parse(quantity);
                   data.Amount1 = Int32.Parse(amuont);
                   data.Discount = Int32.Parse(discount);
                 data.NetAmount = Int32.Parse(netamount);

                invoice.addInvoiceData(data);

            }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (printSave.Checked)
            {
                if (saleInvoicePayment_cash.Checked)
                {
                    tBalance = "0";

                  tPayemnt    =salePricE_totalPrice_textBox.Text;
                }
               
                int id = saveInvoiceData();
                //  MessageBox.Show(id.ToString());
                sum = 0;
                ReportDocument cryRpt = new ReportDocument();

                cryRpt.Load("C:\\Users\\mac\\Documents\\Visual Studio 2015\\Projects\\PointOfSale\\PointOfSale\\CrystalReport4.rpt");

                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterDiscreteValue.Value = id;
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["InvoiceId"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;

                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                //CrystalReport4 report1 = new CrystalReport4();
                // cryRpt.PrintOptions.PaperOrientation = PaperOrientation.Portrait;
              
                //cryRpt.PrintOptions.PaperSize = PaperSiz;
                cryRpt.PrintToPrinter(1, false, 0,0 );

                clearInvoiceForm();
                saleInvoice_productList.Clear();
                salePricE_totalPrice_textBox.Clear();
                saleInvoice_productList.Update();
                saleInvoice_totalAmn_textbox.Clear();
                saleInvoice_totalnetAmount_textbox.Clear();
                saleInvoice_afterCalculation_textbox.Clear();
                saleInvoice_Discount_Textbox.Clear();
                printSave.Checked = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int id = saveInvoiceData();
            clearInvoiceForm();
            saleInvoice_productList.Clear();
            salePricE_totalPrice_textBox.Clear();
            saleInvoice_productList.Update();
            sum = 0;
            saleInvoice_totalAmn_textbox.Clear();
            saleInvoice_totalnetAmount_textbox.Clear();
            saleInvoice_afterCalculation_textbox.Clear();
            saleInvoice_Discount_Textbox.Clear();
            workingForm_SaleInvoice_Panel.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clearInvoiceForm();
            saleInvoice_productList.Items.Clear();
            salePricE_totalPrice_textBox.Clear();
            saleInvoice_productList.Update();
            sum = 0;
            saleInvoice_totalAmn_textbox.Clear();
            saleInvoice_totalnetAmount_textbox.Clear();
            saleInvoice_afterCalculation_textbox.Clear();
            saleInvoice_Discount_Textbox.Clear();
            workingForm_SaleInvoice_Panel.Visible = false;
        }

        private void saleInvoice_afterCalculation_textbox_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
