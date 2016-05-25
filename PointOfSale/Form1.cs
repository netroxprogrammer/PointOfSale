using PointOfSale.DbConfiguration;
using PointOfSale.Employee;
using PointOfSale.OthersForms;
using PointOfSale.TableHandlerForms;
using PointOfSale.TableInformationForm;
using PointOfSale.Utils;
using PointOfSale.Utils.CutomerData;
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Customer_Information().Show();
        }
    }
}
