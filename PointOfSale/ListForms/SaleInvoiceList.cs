using PointOfSale.DbConfiguration;
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
        public SaleInvoiceList()
        {
            InitializeComponent();
        }

        private void SaleInvoiceList_Load(object sender, EventArgs e)
        {

            invoice = new HandleInvoice();
            ArrayList data = invoice.readInvoiceData();

            foreach (TableInvoice em in data)
            {
                String[] rows = { em.InvoiceId.ToString(), em.CurrentDate.ToString(), em.PaymentMethod, em.Discount1.ToString(),
                    em.TotalNetAmount.ToString() , em.TotalPayment.ToString(), em.Balance.ToString(), em.LoginBy
                };
                ListViewItem items = new ListViewItem(rows);
                saleInvoiceList_Data_listView.Items.Add(items);
            }
        }

        private void SaleInvice_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
