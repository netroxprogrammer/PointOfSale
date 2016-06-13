using PointOfSale.DbConfiguration;
using PointOfSale.Utils.CutomerData;
using PointOfSale.Utils.TablesClass;
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
    public partial class SaleInvoiceList : Form
    { 
        HandleInvoice invoice;
        HandleCustomer handleCustomer;
        HandleEmployee employee;
        public SaleInvoiceList()
        {
            InitializeComponent();
        }

        private void SaleInvoiceList_Load(object sender, EventArgs e)
        {

            invoice = new HandleInvoice();
            handleCustomer = new HandleCustomer();
            employee = new HandleEmployee();
            ArrayList data = invoice.readInvoiceData();

            

            foreach (TableInvoice em in data)
            {
                String[] rows = { em.InvoiceId.ToString(), em.CurrentDate.ToString(), em.PaymentMethod, em.TotalDiscount.ToString(),
                    em.TotalNetAmount.ToString() , em.TotalPayment.ToString(), em.Balance.ToString(), em.LoginBy
                };
                ListViewItem items = new ListViewItem(rows);
                saleInvoiceList_Data_listView.Items.Add(items);
            }
        }

        private void SaleInvice_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saleInvoiceList_Data_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saleList_Search_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (saleList_Search_comboBox.SelectedIndex != -1)
            {
                if (saleList_Search_comboBox.SelectedItem.ToString() == "Employee")
                {
                    payment.Enabled = false;
                    emplye_customer_group.Enabled = true;
                    customer_comboBox.Items.Clear();
                    loadEmployee(); ;
                }


                if (saleList_Search_comboBox.SelectedItem.ToString() == "Customer")
                {
                    payment.Enabled = false;
                    emplye_customer_group.Enabled = true;
                    customer_comboBox.Items.Clear();
                    laodCustomer(); 
                }
                if (saleList_Search_comboBox.SelectedItem.ToString() == "paymentType")
                {
                    customer_comboBox.Items.Clear();
                    emplye_customer_group.Enabled = false;
                    payment.Enabled = true;
                }
                
            }
        }

        private void payement_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            saleInvoiceList_Data_listView.Items.Clear();
            TableInvoice table = new TableInvoice();
            if (saleList_Search_comboBox.SelectedIndex != -1)
            {
                if (saleList_Search_comboBox.SelectedItem.ToString() == "paymentType")
                {
                    if (payement_comboBox1.SelectedIndex != -1)
                    {
                        table.PaymentMethod = payement_comboBox1.SelectedItem.ToString();
                        table.CustomerName = "no customer";
                        ArrayList data = invoice.filerInvoiceData(table);
                        loadArrayList(data);
                    }
                    else
                    {
                        table.CustomerName = "no customer";
                        table.PaymentMethod = "no peyment";
                    }
                }
            }
        }

        // load Customer

        public void laodCustomer()
        {
            ArrayList custm = handleCustomer.getCustomersNames();
            foreach (TotalCustomerClass cutm in custm)
            {
                 customer_comboBox.Items.Add(cutm.customerName);
            }

        }


        // load employee

        public void loadEmployee()
        {
            ArrayList empl = employee.getEmployeeBasic();
            foreach (TotalEmployeeData em in empl)
            {

                customer_comboBox.Items.Add(em.EmployeeName);
            }

        }

        private void customer_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            saleInvoiceList_Data_listView.Items.Clear();
            TableInvoice table = new TableInvoice();
            if (saleList_Search_comboBox.SelectedIndex != -1)
            {
                if (saleList_Search_comboBox.SelectedItem.ToString() == "Customer"  || 
                    saleList_Search_comboBox.SelectedItem.ToString() == "Employee" )
                {
                    if (customer_comboBox.SelectedIndex != -1)
                    {
                        table.CustomerName = customer_comboBox.SelectedItem.ToString();
                        table.PaymentMethod = "no peyment";
                        ArrayList data = invoice.filerInvoiceData(table);

                        loadArrayList(data);
                    }
                    else
                    {
                        table.CustomerName = "no customer";
                        table.PaymentMethod = "no peyment";
                    }
                }
            }
        }
            // ArrayList in ListView

            public void loadArrayList( ArrayList  data)
        {

            foreach (TableInvoice em in data)
            {
                String[] rows = { em.InvoiceId.ToString(), em.CurrentDate.ToString(), em.PaymentMethod, em.TotalDiscount.ToString(),
                    em.TotalNetAmount.ToString() , em.TotalPayment.ToString(), em.Balance.ToString(), em.LoginBy
                };
                ListViewItem items = new ListViewItem(rows);
                saleInvoiceList_Data_listView.Items.Add(items);
            }
        }
    }
    
}
