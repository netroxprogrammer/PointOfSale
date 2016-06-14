using PointOfSale.DbConfiguration;
using PointOfSale.Utils.TablesClass;
using System;
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
    public partial class UpdateInvoiceForm : Form
    {
        HandleInvoice invoice;
        private String SerialId;
        private String netAmount;
        
       
        public String oldBalacne
        {
            set
            {
                Old_Balance.Text = value;
            }
        }
        public String OldPayment
        {
            set
            {
                Old_Payment.Text = value;
            }
        }

        public string SerialId1
        {
            get
            {
                return SerialId;
            }

            set
            {
                SerialId = value;
            }
        }

        public string NetAmount
        {
            get
            {
                return netAmount;
            }

            set
            {
                netAmount = value;
            }
        }

        public UpdateInvoiceForm()
        {
            InitializeComponent();
        }

        private void UpdateInvoiceForm_Load(object sender, EventArgs e)
        {
            invoice = new HandleInvoice();
        }

        private void UpdateInvoice_UpdateButton_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode  == Keys.Enter)
            {
                if (!String.IsNullOrEmpty(new_Payemnt_tetbox.Text))
                {
                    int newPayment = Int32.Parse(new_Payemnt_tetbox.Text);
                    int oldPayment = Int32.Parse(Old_Payment.Text);
                    int newTotalPayment = newPayment + oldPayment;
                    int findbalace = Int32.Parse(netAmount) - newTotalPayment;
                   
                    new_Balance.Text = findbalace.ToString();
                    TableInvoice tble = new TableInvoice();
                    tble.TotalPayment = newTotalPayment;
                    tble.Balance = findbalace;
                   
                    tble.InvoiceId = Int32.Parse(SerialId);
                    if (findbalace <= 0)
                    {
                        tble.PaymentMethod = "cash";
                    }
                    else
                    {
                        tble.PaymentMethod = "credit";
                    }
                        invoice.UpdateInvoiceBalancea(tble);
                    MessageBox.Show("Update Date SuccessFully");
                }
            }
        }

        private void new_Payemnt_tetbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
