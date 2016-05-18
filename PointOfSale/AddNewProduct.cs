using PointOfSale.DbConfiguration;
using PointOfSale.Utils;
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

namespace PointOfSale
{
    public partial class AddNewProduct : Form
    {
        HandleProducts handleProducts;
        public AddNewProduct()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddNewProduct_Load(object sender, EventArgs e)
        {
             handleProducts = new HandleProducts();
            loadProductCategory();
             loadCompanyNames();
            loadProductName();
            this.TopMost = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {


            DialogResult result = colorDialog1.ShowDialog();
            colorDialog1.SolidColorOnly = false;
        
            if (result == DialogResult.OK)
            {
                Color c = colorDialog1.Color;

                if (c.IsKnownColor)
                {
                    // MessageBox.Show(c.Name.ToString());
                    addProducts_colorName_label.Text = c.Name.ToString();
                    addProducts_colorName_label.BackColor = c;
                }
                else {
                    
                    MessageBox.Show("Please Select Simple Color");
                }

            }
        }

        private void addProducts_colorName_label_Click(object sender, EventArgs e)
        {

        }

        

        private void adddNewProducts_Category_comboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void adddNewProducts_companyName_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
        private void adddNewProducts_ProductName_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /*
        *  Load CompanyName
        */
        public void loadCompanyNames()
        {
            ArrayList getProd = handleProducts.getCompanyNames(); ;
            foreach (TableCompany products in getProd)
            {

                adddNewProducts_companyName_comboBox.Items.Add(products.companyName);
            }
        }

        /*
        *  Load Product Category
        */
        public void loadProductCategory()
        {
            ArrayList getCatrg = handleProducts.getCategory();
            foreach (TableCategory category in getCatrg)
            {

                adddNewProducts_Category_comboBox.Items.Add(category.cagtegoryName);
            }
        }

        /*
        *  Load Product Name
        */
        public void loadProductName()
        {
            ArrayList getname = handleProducts.getProductNames();
            foreach (TableProductName name in getname)
            {

                adddNewProducts_ProductName_comboBox.Items.Add(name.productName);
            }
        }

    }
}

