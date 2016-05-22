using PointOfSale.DbConfiguration;
using PointOfSale.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.OthersForms
{
    public partial class AddOtherThings : Form
    {
        HandleProducts handleProduct;
        public AddOtherThings()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void otherthings_saveProduct_btn_Click(object sender, EventArgs e)
        {
            String productName = otherthings_ProductName_text.Text;
            String productDiscount = otherthings_ProductDiscount_text.Text;

            TableProductName names = new TableProductName();
            if (productName !="")
            {
                names.productName = productName;
                names.productMaxDiscount = Decimal.ToInt32(System.Convert.ToDecimal(productDiscount));
                int  id = handleProduct.addProductName(names);
                if (id >= 0)
                {
                    MessageBox.Show("One Product Insert");

                }
            }
            else
            {
                MessageBox.Show("Please Give Name");
            }
        }

        private void AddOtherThings_Load(object sender, EventArgs e)
        {
            handleProduct = new HandleProducts();
        }
    }
}
