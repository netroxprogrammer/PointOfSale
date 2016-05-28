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
            loadDescreptionName();
            loadLocation();
            loadPurposeName();
            loadUnits();
            this.TopMost = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getColors(addProducts_colorName_label);
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

        /*
       *  Load Descreption
       */
        public void loadDescreptionName()
        {
            ArrayList getname = handleProducts.getDescreptions();
            foreach (TableDescription name in getname)
            {

                adddNewProducts_Description_comboBox.Items.Add(name.descriptionName);
            }
        }

        /*
             *  Load Purpose
             */
        public void loadPurposeName()
        {
            ArrayList getname = handleProducts.getPurposeNames();
            foreach (TablePurpose name in getname)
            {

               adddNewProducts_Purpose_comboBox.Items.Add(name.purposeName);
            }
        }

        /*
             *  Load Location
             */
        public void loadLocation()
        {
            ArrayList getname = handleProducts.getProductLocationNames();
            foreach (TableLocation name in getname)
            {

                adddNewProducts_Location_comboBox.Items.Add(name.locationName);
            }
        }

        /*
             *  Load Location
             */
        public void loadUnits()
        {
            ArrayList getname = handleProducts.getUnitsNames();
            foreach (TableUnits name in getname)
            {

                adddNewProducts_Units_comboBox.Items.Add(name.unitsName);
            }
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            getColors(addProducts_colorName_label2);
        }
        /*
        Get Colors
        */
        public void getColors(Label textbox)
        {

            DialogResult result = colorDialog1.ShowDialog();
            colorDialog1.SolidColorOnly = false;

            if (result == DialogResult.OK)
            {
                Color c = colorDialog1.Color;

                if (c.IsKnownColor)
                {
                    // MessageBox.Show(c.Name.ToString());

                    // addProducts_colorName_label.Text = c.Name.ToString();
                    textbox.BackColor = c;

                }
                else {

                    MessageBox.Show("Please Select Simple Color");
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            getColors(addProducts_colorName_label3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String code = addNewProduct_code_textbox.Text;
            String pName = null;
            String CName = null;
            String purpose = null;
            String description = null;
            String  category = null;
            String location = null;
            String batch = null;
            String size = null;
            String unit = null, packs = null, TotalPacks = null,  Qtypack = null; ;
            /* String CName = adddNewProducts_companyName_comboBox.SelectedItem.ToString();
             String purpose = adddNewProducts_Purpose_comboBox.SelectedItem.ToString();
             String  description =  adddNewProducts_Description_comboBox.SelectedItem.ToString();
             String category = adddNewProducts_Category_comboBox.SelectedItem.ToString();
             String location = adddNewProducts_Location_comboBox.SelectedItem.ToString();
             DateTime dateTime = addNewProduct_Date_dateTimePicker.Value;
             String batch = addNewProduct_Batch_textbox.Text;
             String color1 = addProducts_colorName_label.Text;
             String color2 = addProducts_colorName_label2.Text;
             String color3 = addProducts_colorName_label3.Text;

             String size = addNewProduct_size_textbox.Text;
             String unit = adddNewProducts_Units_comboBox.Text;
             String   Qtypack = addNewProduct_QtyPack_textbox.Text;
             String QtyHand = addNewProduct_QtyHand_textbox.Text;
             String QtyStock = addNewProduct_QtyStock_textbox.Text;
             String maxQuantity = addNewProduct_MinStock_textbox.Text;
             String  salePrice = addNewProduct_SalePrice_textbox.Text;
             String  profit = addNewProduct_Profit_textbox.Text;
             String  pPrice = addNewProduct_purchasePrice_textbox.Text;
             String maxDiscount = addNewProduct_MaxDiscount_textbox.Text;*/

            //  check product Name empty or Not
            if (adddNewProducts_ProductName_comboBox.SelectedIndex != -1)
            {
                pName = adddNewProducts_ProductName_comboBox.SelectedItem.ToString();
            }
            else
            {
                adddNewProducts_ProductName_comboBox.BackColor = Color.Red;
            }
            // Check Company Name Empty Or  Not
            if(adddNewProducts_companyName_comboBox.SelectedIndex != -1)
            {
              CName= adddNewProducts_companyName_comboBox.SelectedItem.ToString();
            }
            else
            {
                adddNewProducts_companyName_comboBox.BackColor = Color.Red;
            }
             //   Check Purpose
             if(adddNewProducts_Purpose_comboBox.SelectedIndex != -1)
            {
              purpose = adddNewProducts_Purpose_comboBox.SelectedItem.ToString();
            }
            else
            {
                adddNewProducts_Purpose_comboBox.BackColor = Color.Red;
            }
             // Check Description
             if(adddNewProducts_Description_comboBox.SelectedIndex != -1)
            {
               description = adddNewProducts_Description_comboBox.SelectedItem.ToString();
            }
            else
            {
                adddNewProducts_Description_comboBox.BackColor = Color.Red;
            }
            // Check Category
            if(adddNewProducts_Category_comboBox.SelectedIndex != -1)
            {
                category =adddNewProducts_Category_comboBox.SelectedItem.ToString();
            }
            else
            {
                adddNewProducts_Category_comboBox.BackColor = Color.Red;
            }
            // Check Location 

            if (adddNewProducts_Location_comboBox.SelectedIndex != -1)
            {
                location = adddNewProducts_Location_comboBox.SelectedItem.ToString();
            }
            else
            {
                adddNewProducts_Location_comboBox.BackColor = Color.Red;
            }
            // Check Batch ]
            if (!String.IsNullOrEmpty(addNewProduct_Batch_textbox.Text))
            {
                batch = addNewProduct_Batch_textbox.Text;
            }
            else
            {
                addNewProduct_Batch_textbox.BackColor = Color.Red;
            }

            // check Size

            if (!String.IsNullOrEmpty(addNewProduct_size_textbox.Text))
            {
               size = addNewProduct_size_textbox.Text;
            }
            else
            {
                addNewProduct_size_textbox.BackColor = Color.Red;
            }
            // Check Units
            if (adddNewProducts_Units_comboBox.SelectedIndex != -1)
            {
               unit = adddNewProducts_Units_comboBox.SelectedItem.ToString();
            }
            else
            {
                adddNewProducts_Units_comboBox.BackColor = Color.Red;

            }
            // Check Packs
            if (!String.IsNullOrEmpty(addNewProduct_QtyPack_textbox.Text))
            {
               Qtypack = addNewProduct_QtyPack_textbox.Text;
            }
            else
            {
                addNewProduct_QtyPack_textbox.BackColor = Color.Red;
            }
        }

        private void adddNewProducts_ProductName_comboBox_MouseClick(object sender, MouseEventArgs e)
        {
            adddNewProducts_ProductName_comboBox.BackColor = Color.White;
        }

        private void adddNewProducts_companyName_comboBox_MouseClick(object sender, MouseEventArgs e)
        {
            adddNewProducts_companyName_comboBox.BackColor = Color.White;
        }

        private void adddNewProducts_Purpose_comboBox_MouseClick(object sender, MouseEventArgs e)
        {
            adddNewProducts_Purpose_comboBox.BackColor = Color.White;
        }

        private void adddNewProducts_Description_comboBox_MouseClick(object sender, MouseEventArgs e)
        {
            adddNewProducts_Description_comboBox.BackColor = Color.White;
        }

        private void adddNewProducts_Category_comboBox_MouseClick(object sender, MouseEventArgs e)
        {
            adddNewProducts_Category_comboBox.BackColor = Color.White;
        }

        private void adddNewProducts_Location_comboBox_MouseClick(object sender, MouseEventArgs e)
        {
            adddNewProducts_Location_comboBox.BackColor = Color.White;
        }

        private void addNewProduct_Batch_textbox_MouseClick(object sender, MouseEventArgs e)
        {
            addNewProduct_Batch_textbox.BackColor = Color.White;
        }

        private void addNewProduct_size_textbox_MouseClick(object sender, MouseEventArgs e)
        {
            addNewProduct_size_textbox.BackColor = Color.Red;
        }

        private void adddNewProducts_Units_comboBox_MouseClick(object sender, MouseEventArgs e)
        {
            adddNewProducts_Units_comboBox.BackColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addNewProduct_QtyPack_textbox_MouseClick(object sender, MouseEventArgs e)
        {
            addNewProduct_QtyPack_textbox.BackColor = Color.White;
        }
    }
}

