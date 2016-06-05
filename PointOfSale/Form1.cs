using PointOfSale.DbConfiguration;
using PointOfSale.Employee;
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
        HandleProducts products;
        ArrayList prod;
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
            products = new HandleProducts(); ;
            loadProductName();
            WorkingForm_listView.Focus();
            WorkingForm_EmployeList.Focus();
            WorkingForm_Employ_Panel.Visible = false;
            workingForm_Product_Panel.Visible = false;
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
            contextMenuStrip_Customer.Show(customer_Button, new Point(0,customer_Button.Height));
        }

        private void suppliers_Button_Click(object sender, EventArgs e)
        {
            contextMenuStrip_Supplier.Show(suppliers_Button,new Point(0,suppliers_Button.Height));
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void inventory_Button_Click(object sender, EventArgs e)
        {
            contextMenuStrip_Inventory.Show(inventory_Button, new Point(0,inventory_Button.Height));

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
            AddCustomerList();


        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkingForm_listView.Columns.Clear();
            WorkingForm_listView.Columns.Add("Customer Id", 110, HorizontalAlignment.Left);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            AddCustomerList();
        }

        /*
        Add  Customer List...
        */

        public void AddCustomerList()
        {
            WorkingForm_Employ_Panel.Visible = false;
            WorkingForm_listView.Columns.Clear();
            HandleCustomer handleCustomer = new HandleCustomer();
            WorkingForm_listView.Items.Clear();


            //   foreach (TableColumns columns in list){
            WorkingForm_listView.Columns.Add("Customer Id", 110, HorizontalAlignment.Left);
            WorkingForm_listView.Columns.Add("Name", 110, HorizontalAlignment.Left);
            WorkingForm_listView.Columns.Add("Discuont ", 110, HorizontalAlignment.Left);
            WorkingForm_listView.Columns.Add("Payment", 110, HorizontalAlignment.Left);
            WorkingForm_listView.Columns.Add("Phone Contact", 110, HorizontalAlignment.Left);
            WorkingForm_listView.Columns.Add("Reffered", 110, HorizontalAlignment.Left);
            WorkingForm_listView.Columns.Add("Phone 1", 110, HorizontalAlignment.Left);
            WorkingForm_listView.Columns.Add("Phone 2", 110, HorizontalAlignment.Left);
            WorkingForm_listView.Columns.Add("Phone 3", 110, HorizontalAlignment.Left);
            WorkingForm_listView.Columns.Add("Fax 1", 110, HorizontalAlignment.Left);
            WorkingForm_listView.Columns.Add("Fax 2", 110, HorizontalAlignment.Left);
            WorkingForm_listView.Columns.Add("Fax 3", 110, HorizontalAlignment.Left);
            WorkingForm_listView.Columns.Add("Email", 110, HorizontalAlignment.Left);
            WorkingForm_listView.Columns.Add("Address", 110, HorizontalAlignment.Left);
            WorkingForm_listView.Columns.Add("Remark", 110, HorizontalAlignment.Left);
            WorkingForm_listView.Columns.Add("Default", 110, HorizontalAlignment.Left);
            WorkingForm_listView.Columns.Add("Inactive", 110, HorizontalAlignment.Left);
            //         }


            ArrayList data = handleCustomer.getCustomers();



            foreach (TotalCustomerClass clms in data)
            {
                String[] rows = { clms.customerId.ToString(),clms.customerName.ToString(),
                    clms.CustomerDiscount.ToString(),clms.customerPrice.ToString(), clms.CustomerPersonContact,
                    clms.CustomerReffered,
                    clms.CustomerPhone1, clms.CustomerPhone2, clms.CustomerPhone3, clms.CustomerFax, clms.CustomerFax1,
                    clms.CustomerFax2, clms.CustomerEmail, clms.CustomerAddress,
                    clms.CustomerRemark, clms.CustomerDefault,clms.CustomerInactive,};
                ListViewItem items = new ListViewItem(rows);

                WorkingForm_listView.Items.Add(items);
            }
        }
        /*
        get Employee List
        */

            public void getEmployeeList()
        {

            
            WorkingForm_EmployeList.Columns.Clear();
            WorkingForm_EmployeList.Items.Clear();
            WorkingForm_EmployeList.Columns.Add("Employee Id", 110, HorizontalAlignment.Left);
            WorkingForm_EmployeList.Columns.Add("Emloyee Name", 110, HorizontalAlignment.Left);
            WorkingForm_EmployeList.Columns.Add("Employee Phone ", 110, HorizontalAlignment.Left);
            WorkingForm_EmployeList.Columns.Add("Father Name", 110, HorizontalAlignment.Left);
            WorkingForm_EmployeList.Columns.Add("Employee CNIC", 110, HorizontalAlignment.Left);
            WorkingForm_EmployeList.Columns.Add("Employee Address", 110, HorizontalAlignment.Left);
            WorkingForm_EmployeList.Columns.Add("Location", 110, HorizontalAlignment.Left);
            WorkingForm_EmployeList.Columns.Add("Emergancy Name", 110, HorizontalAlignment.Left);
            WorkingForm_EmployeList.Columns.Add("Emergancy Contact", 110, HorizontalAlignment.Left);
            WorkingForm_EmployeList.Columns.Add("Emergancy Relation", 110, HorizontalAlignment.Left);
            WorkingForm_EmployeList.Columns.Add("Emergancy Location", 110, HorizontalAlignment.Left);

            HandleEmployee employee = new HandleEmployee();
            // WorkingForm_customerPanel.Visible = false;
            WorkingForm_Employ_Panel.Visible = true;
            workingForm_Product_Panel.Visible = false;
            workingForm_SaleInvoice_Panel.Visible = false;
            ArrayList empl = employee.getEmployee();

            foreach (TotalEmployeeData em in empl)
            {
                String[] rows = { em.EmployeeId.ToString(), em.EmployeeName, em.EmployeePhone, em.EmployeeFatherName,
                    em.EmployeeCNIC, em.EmployeeAddress, em.EmployeeLocation, em.Name, em.Contact, em.Relation, em.Location};
                ListViewItem items = new ListViewItem(rows);
                WorkingForm_EmployeList.Items.Add(items);
            }


        }

        /*
       get Products List
       */

        public void getProductsList()
        {

            WorkingForm_Employ_Panel.Visible = true;
            WorkingForm_AllProduct_listView.Columns.Clear();
            WorkingForm_AllProduct_listView.Items.Clear();
            WorkingForm_AllProduct_listView.Columns.Add("Product Id", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Bar Code", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Name", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Company Name", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Purpose", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Description", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Category", 110, HorizontalAlignment.Left);
           // WorkingForm_AllProduct_listView.Columns.Add("Location", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Expiry date", 110, HorizontalAlignment.Left);
          /*  WorkingForm_AllProduct_listView.Columns.Add("Batch", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Color 1", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Color 2", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Color 3", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Size", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Quantity Pack", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("No. Packs", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Total Packs", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Qty in hands", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Max Stock", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Min Stock", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Sale Price", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Profit %", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Purchase Price", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Max discount", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Item Discount", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Item Fix Discont", 110, HorizontalAlignment.Left);

            WorkingForm_AllProduct_listView.Columns.Add("Distributors", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Update Stock Date", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Inactive Products", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Entry Date", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Update Product Date", 110, HorizontalAlignment.Left);*/

             products = new HandleProducts();
            // WorkingForm_customerPanel.Visible = false;
            WorkingForm_Employ_Panel.Visible = true;
            workingForm_Product_Panel.Visible = true;
            workingForm_SaleInvoice_Panel.Visible = false;
            prod = products.getProductList();

            foreach (TableAddNewProducts em in prod)
            {
                String[] rows = { em.ProductId.ToString(), em.BarCode, em.ProductName, em.ProductCompanyName,
                    em.ProductPurpose , em.ProductDescription, em.Category, em.ProductExpidate.ToString() 
                };
                ListViewItem items = new ListViewItem(rows);
                WorkingForm_AllProduct_listView.Items.Add(items);
            }




        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Customer_Information().Show();
        }

        private void listOfEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getEmployeeList();
        }

        private void addNewEmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AddEmployee().Show();

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getEmployeeList();
        }

        private void WorkingForm_EmployeList_MouseClick(object sender, MouseEventArgs e)
        {

           

            String id = WorkingForm_EmployeList.SelectedItems[0].SubItems[0].Text;
            String name = WorkingForm_EmployeList.SelectedItems[0].SubItems[0].Text;
            String phone = WorkingForm_EmployeList.SelectedItems[0].SubItems[0].Text;
            String fName = WorkingForm_EmployeList.SelectedItems[0].SubItems[0].Text;
            String CNIC = WorkingForm_EmployeList.SelectedItems[0].SubItems[0].Text;
            String address = WorkingForm_EmployeList.SelectedItems[0].SubItems[0].Text;
            String location = WorkingForm_EmployeList.SelectedItems[0].SubItems[0].Text;
            String eName = WorkingForm_EmployeList.SelectedItems[0].SubItems[0].Text;
            String eContact = WorkingForm_EmployeList.SelectedItems[0].SubItems[0].Text;
            String eRelation = WorkingForm_EmployeList.SelectedItems[0].SubItems[0].Text;

            String eLocatipn = WorkingForm_EmployeList.SelectedItems[0].SubItems[0].Text;
            MessageBox.Show(name);
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getProductsList();
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

            String id = WorkingForm_AllProduct_listView.SelectedItems[0].SubItems[0].Text;
            String barCode = WorkingForm_AllProduct_listView.SelectedItems[0].SubItems[1].Text;
            String pname = WorkingForm_AllProduct_listView.SelectedItems[0].SubItems[2].Text;
            String CName = WorkingForm_AllProduct_listView.SelectedItems[0].SubItems[3].Text;
            String purpose = WorkingForm_AllProduct_listView.SelectedItems[0].SubItems[4].Text;
            String disc = WorkingForm_AllProduct_listView.SelectedItems[0].SubItems[5].Text;
            String category = WorkingForm_AllProduct_listView.SelectedItems[0].SubItems[6].Text;
            String expdate = WorkingForm_AllProduct_listView.SelectedItems[0].SubItems[7].Text;
            MessageBox.Show(CName);
            AddNewProduct p = new AddNewProduct();
         
           
            ArrayList  data = products.getProductList();

            foreach(TableAddNewProducts d in data)
            {
                if(d.BarCode == barCode)
                {
                    p.barCode = barCode;
                    p.PName = pname;
                    p.cName = CName;
                    p.Purpose = purpose;
                    p.descreption = disc;
                    p.PCategory = category;
                    p.ExpiryDate =System.Convert.ToDateTime(expdate);
                    p.Batch = d.ProductBatch.ToString();
                    p.PColor1 = d.ProductColor1;
                    p.PColor2 = d.ProductColor2;
                    p.PColor3 = d.ProductColor3;
                    p.pSize = d.Productsize.ToString();
                    p.Units = d.ProductUnits;
                    p.qntyPack = d.ProductQuantityPack.ToString();
                    p.packs = d.ProductTotalPeice.ToString();
                    p.QntyHand = d.ProductQntHand.ToString();
                    p.totalPacks = d.ProductTotalPacks.ToString();
                    p.maxQuantity = d.ProductMaxStock.ToString();
                    p.minQuantity = d.ProductMinStock.ToString();
                    p.salePrice = d.ProductSalePrice.ToString();
                    p.profit = d.ProductProfit.ToString();
                    p.purchasePrice = d.ProductPurchasePrice.ToString();
                    p.maxDiscount = d.MaxDiscount.ToString();
                    p.itemDiscont = d.ProductItemDiscount.ToString();
                    p.Distributor = d.ProductDistributors;

                }
            }
               p.Show();

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

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

         
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

        }

        private void saleInvoiceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void newSaleInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workingForm_SaleInvoice_Panel.Visible = true;


        }

        /*
       *  Load Product Name
       */
        public void loadProductName()
        {
            ArrayList getname = products.getProductList();
            foreach (TableAddNewProducts name in getname)
            {

                Sale_Panel_ProductName_comboBox.Items.Add(name.ProductName);
            }
        }

        private void Sale_Panel_ProductName_comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)

            {

            }
        }
    }
}
