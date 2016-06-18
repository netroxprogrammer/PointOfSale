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
        int sum = 0;
        int tBalance  = 0;
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
                    em.TotalNetAmount.ToString() , em.TotalPayment.ToString(), em.Balance.ToString(), em.LoginBy, em.Description1
                };
                ListViewItem items = new ListViewItem(rows);
                saleInvoiceList_Data_listView.Items.Add(items);
            }

            for (int i = 0; i < saleInvoiceList_Data_listView.Items.Count; i++)
            {
                sum = sum + Int32.Parse(saleInvoiceList_Data_listView.Items[i].SubItems[5].Text);
                tBalance = tBalance + Int32.Parse(saleInvoiceList_Data_listView.Items[i].SubItems[6].Text);
            }

           
            SaleList_Total_Paid_textBox.Text = sum.ToString();

            Sale_List_Total_Balance_textBox.Text = tBalance.ToString();

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

        private void saleInvoiceList_Data_listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String id = saleInvoiceList_Data_listView.SelectedItems[0].SubItems[0].Text;
            String oldpay = saleInvoiceList_Data_listView.SelectedItems[0].SubItems[5].Text;
            String oldb = saleInvoiceList_Data_listView.SelectedItems[0].SubItems[6].Text;
            String netamt = saleInvoiceList_Data_listView.SelectedItems[0].SubItems[4].Text;
            UpdateInvoiceForm up = new UpdateInvoiceForm();
            up.oldBalacne = oldb;
            up.OldPayment = oldpay;
            up.SerialId1 = id;
            up.NetAmount = netamt;
            up.Show();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saleInvoiceList_Data_listView.Items.Clear();
               ArrayList data = invoice.readInvoiceData();
            foreach (TableInvoice em in data)
            {
                String[] rows = { em.InvoiceId.ToString(), em.CurrentDate.ToString(), em.PaymentMethod, em.TotalDiscount.ToString(),
                    em.TotalNetAmount.ToString() , em.TotalPayment.ToString(), em.Balance.ToString(), em.LoginBy, em.Description1
                };
                ListViewItem items = new ListViewItem(rows);
                saleInvoiceList_Data_listView.Items.Add(items);
            }
        }

        private void saleInvoiceList_Data_listView_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                if (saleInvoiceList_Data_listView.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    SaleInvoiceList_contextMenu.Show(Cursor.Position);
                }
            }
        }

        private void viewReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String id = saleInvoiceList_Data_listView.SelectedItems[0].SubItems[0].Text;
            CrstalReportView cs = new CrstalReportView();
            cs.InvoiceId = id;
            cs.Show();
            

        }

        private void SaleInvoiceList_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saleInvoiceList_Data_listView.Items.Clear();
               TableInvoice invoiceTable = new TableInvoice();
            invoiceTable.ToDate1 = ToDatePiker.Value;
            invoiceTable.FromDate1 = FromDatePicker.Value;
            invoiceTable.CustomerName = "no customer";
            invoiceTable.PaymentMethod = "no peyment";
            ArrayList data = invoice.filerInvoiceData(invoiceTable);
            loadArrayList(data);

           
        }
    }
    
}
