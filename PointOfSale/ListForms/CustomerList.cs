using PointOfSale.DbConfiguration;
using PointOfSale.Utils.CutomerData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.ListForms
{
    public partial class CustomerList : Form
    {
        HandleCustomer handleCustomer;
        
        public CustomerList()
        {
            InitializeComponent();
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            handleCustomer = new HandleCustomer();
            AddCustomerList("");
        }
        // add Customer List
        public void AddCustomerList(String filter)
        {

            WorkingForm_listView.Columns.Clear();
            handleCustomer = new HandleCustomer();
            WorkingForm_listView.Items.Clear();


            //   foreach (TableColumns columns in list){
            WorkingForm_listView.Columns.Add("Customer Id", 110, HorizontalAlignment.Left);
            WorkingForm_listView.Columns.Add("Name", 110, HorizontalAlignment.Left);
            WorkingForm_listView.Columns.Add("Discuont ", 110, HorizontalAlignment.Left);
            WorkingForm_listView.Columns.Add("Payment", 110, HorizontalAlignment.Left);
            WorkingForm_listView.Columns.Add("Phone Contact", 110, HorizontalAlignment.Left);
            WorkingForm_listView.Columns.Add("Reffered", 110, HorizontalAlignment.Left);
            WorkingForm_listView.Columns.Add("Phone 1", 110, HorizontalAlignment.Left);
            /*   WorkingForm_listView.Columns.Add("Phone 2", 110, HorizontalAlignment.Left);
               WorkingForm_listView.Columns.Add("Phone 3", 110, HorizontalAlignment.Left);
               WorkingForm_listView.Columns.Add("Fax 1", 110, HorizontalAlignment.Left);
               WorkingForm_listView.Columns.Add("Fax 2", 110, HorizontalAlignment.Left);
               WorkingForm_listView.Columns.Add("Fax 3", 110, HorizontalAlignment.Left);
               WorkingForm_listView.Columns.Add("Email", 110, HorizontalAlignment.Left);
               WorkingForm_listView.Columns.Add("Address", 110, HorizontalAlignment.Left);
               WorkingForm_listView.Columns.Add("Remark", 110, HorizontalAlignment.Left);
               WorkingForm_listView.Columns.Add("Default", 110, HorizontalAlignment.Left);
               WorkingForm_listView.Columns.Add("Inactive", 110, HorizontalAlignment.Left);*/
            //         }


            ArrayList data = handleCustomer.getCustomers(filter);



            foreach (TotalCustomerClass clms in data)
            {
                String[] rows = { clms.customerId.ToString(),clms.customerName.ToString(),
                    clms.CustomerDiscount.ToString(),clms.customerPrice.ToString(), clms.CustomerPersonContact,
                    clms.CustomerReffered,
                    clms.CustomerPhone1};
                ListViewItem items = new ListViewItem(rows);

                WorkingForm_listView.Items.Add(items);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddCustomerList("");
        }

        private void inactiveCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomerList("inactive");
        }

        private void WorkingForm_listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            String id = WorkingForm_listView.SelectedItems[0].SubItems[0].Text;
            String name = WorkingForm_listView.SelectedItems[0].SubItems[1].Text;
            String Discount = WorkingForm_listView.SelectedItems[0].SubItems[2].Text;
            String payment = WorkingForm_listView.SelectedItems[0].SubItems[3].Text;
            String pContact = WorkingForm_listView.SelectedItems[0].SubItems[4].Text;
            String reffered = WorkingForm_listView.SelectedItems[0].SubItems[5].Text;
            String Phone1 = WorkingForm_listView.SelectedItems[0].SubItems[6].Text;

            Customer_Information cs = new Customer_Information();
            ArrayList data = handleCustomer.getCustomersNoFilter();



            foreach (TotalCustomerClass clms in data)
            {
                if (clms.customerId == Int32.Parse(id))
                {
                    cs.CustomerId = id;
                    cs.CustumerName = name;
                    cs.CustomerDisccount = Int32.Parse(Discount);
                    if (payment == "cash")
                    {
                        cs.CustomerCash = true;
                    }
                    if (payment == "credit")
                    {

                        cs.CustomerCash = true;
                    }

                    cs.CContact = pContact;
                    cs.CReffered = reffered;
                    cs.CPhone1 = Phone1;
                    cs.CPhone2 = clms.CustomerPhone2;
                    cs.CPhone3 = clms.CustomerPhone3;
                    cs.CFax1 = clms.CustomerFax;
                    cs.CFax2 = clms.CustomerFax1;
                    cs.CFax3 = clms.CustomerFax2;
                    cs.CEmail = clms.CustomerEmail;
                    cs.CAddress = clms.CustomerAddress;
                    cs.CRemark = clms.CustomerRemark;
                    if (clms.CustomerDefault == "default")
                    {
                        cs.Cdefualt = true;
                    }
                    if (clms.CustomerInactive == "inactive")
                    {
                        cs.cInActive = true;
                    }
                    cs.updateButon = true;
                }

            }
            cs.Show();
        }
    }
}
