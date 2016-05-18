using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class Customer_Information : Form
    {
        public Customer_Information()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void Customer_Information_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void customerInformation_Discount_numericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cutomerName = customerInformation_customerName_extBox.Text;
            decimal customerDiscount = customerInformation_Discount_numericUpDown.Value;



        }
    }
}
