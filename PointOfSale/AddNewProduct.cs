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
        public static int count;
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
            loadDistrubutors();
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
             *  Load units
             */
        public void loadUnits()
        {
            ArrayList getname = handleProducts.getUnitsNames();
            foreach (TableUnits name in getname)
            {

                adddNewProducts_Units_comboBox.Items.Add(name.unitsName);
            }
        }
        public void loadDistrubutors()
        {
            ArrayList getname = handleProducts.getDistributors();
            foreach (TableDistributors name in getname)
            {

                addNewProduct_Distrubutors_comboBox.Items.Add(name.distributorsName);
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
            
             DateTime Expiridate;
            String code =  null;
            String pName = null;
            String CName = null;
            String purpose = null;
            String description = null;
            String  category = null, color1 = null, color2= null, color3=null;
            String location = null, fixDiscount = null, updateStock = null, inactiveProduct = null ;
            String batch = null, salePrice=null, profit=null, pPrice=null, maxDiscount=null;
            String size = null, QtyHand = null, QtyStock = null, minstock = null, maxQuantity = null;
            String unit = null, packs = null, TotalPacks = null,  Qtypack = null, distrubutors =null;

            // check Code

            if (!String.IsNullOrEmpty(addNewProduct_code_textbox.Text))
            {
                code = addNewProduct_code_textbox.Text;
              
            }
            else
            {
                addNewProduct_code_textbox.BackColor = Color.Red;
                
            }

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
           
            // Check Batch 
        
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
            // Check Quantity Packs
            if (!String.IsNullOrEmpty(addNewProduct_QtyPack_textbox.Text))
            {
               Qtypack = addNewProduct_QtyPack_textbox.Text;
               
            }
            else
            {
                addNewProduct_QtyPack_textbox.BackColor = Color.Red;
               
            }

            //  Packs
            if (!String.IsNullOrEmpty(addNewProduct_Packs_textbox.Text))
            {
                TotalPacks = addNewProduct_Packs_textbox.Text;
                
            }
            else
            {
                addNewProduct_Packs_textbox.BackColor = Color.Red;
                
            }

            //  give total  Pack.........
            if (!String.IsNullOrEmpty(addNewProduct_QtyPack_textbox.Text) && !String.IsNullOrEmpty(addNewProduct_Packs_textbox.Text))
            {
                int qPack = Int32.Parse(addNewProduct_QtyPack_textbox.Text);
                int pack = Int32.Parse(addNewProduct_Packs_textbox.Text);
               
                int total = qPack * pack;
                addNewProduct_TotalPacks_textbox.Text = System.Convert.ToString(total);
            }
            else
            {
                
            }
                //   Add Quantity Packs
                if (!String.IsNullOrEmpty(addNewProduct_QtyHand_textbox.Text))
            {
               QtyHand =  addNewProduct_QtyHand_textbox.Text;
               
            }
            else
            {
                addNewProduct_QtyHand_textbox.BackColor = Color.Red;
              
            }
            //   Add Quantity Stock
            if (!String.IsNullOrEmpty(addNewProduct_QtyStock_textbox.Text))
            {
                QtyStock = addNewProduct_QtyStock_textbox.Text;
                
            }
            else
            {
                addNewProduct_QtyStock_textbox.BackColor = Color.Red;
               
            }
             // Min Stock
            if (!String.IsNullOrEmpty(addNewProduct_MinStock_textbox.Text))
            {
                 minstock = addNewProduct_MinStock_textbox.Text;
                
            }
            else
            {
                addNewProduct_MinStock_textbox.BackColor = Color.Red;
                
            }
            // Check  Sale Price
            if (!String.IsNullOrEmpty(addNewProduct_SalePrice_textbox.Text))
            {
                salePrice = addNewProduct_SalePrice_textbox.Text;
               
            }
            else
            {
                addNewProduct_SalePrice_textbox.BackColor = Color.Red;
                

            }

       
            //  Check Distributors
            if (addNewProduct_Distrubutors_comboBox.SelectedIndex != -1) {
                distrubutors = addNewProduct_Distrubutors_comboBox.SelectedItem.ToString();
                
            }
            else
            {

                addNewProduct_Distrubutors_comboBox.BackColor = Color.Red;
              
            }

             // Check Update Stock
            if (addNewProduct_updatestock_checkBox.Checked)
            {
                DateTime now = DateTime.Now;
                updateStock = now.ToString() ;
               
            }
            else
            {
                updateStock = "No Entery Data";
            }

            // Check Product Inactive or not
            if (addNewProduct_inActive_checkBox.Checked)
            {
                inactiveProduct = "inactive";
            }
            else
            {
                inactiveProduct = "";
            }
            if(!String.IsNullOrEmpty(addNewProduct_code_textbox.Text) && adddNewProducts_ProductName_comboBox.SelectedIndex != -1 &&
                adddNewProducts_companyName_comboBox.SelectedIndex != -1 && adddNewProducts_Purpose_comboBox.SelectedIndex != -1 &&
                adddNewProducts_Description_comboBox.SelectedIndex != -1 && adddNewProducts_Category_comboBox.SelectedIndex != -1 &&
                adddNewProducts_Location_comboBox.SelectedIndex != -1 && !String.IsNullOrEmpty(addNewProduct_Batch_textbox.Text) &&
                !String.IsNullOrEmpty(addNewProduct_size_textbox.Text) && adddNewProducts_Units_comboBox.SelectedIndex != -1 &&
                !String.IsNullOrEmpty(addNewProduct_QtyPack_textbox.Text) && !String.IsNullOrEmpty(addNewProduct_Packs_textbox.Text) &&
                 !String.IsNullOrEmpty(addNewProduct_QtyHand_textbox.Text) && !String.IsNullOrEmpty(addNewProduct_QtyStock_textbox.Text) &&
                 !String.IsNullOrEmpty(addNewProduct_MinStock_textbox.Text) && !String.IsNullOrEmpty(addNewProduct_SalePrice_textbox.Text) &&
                 addNewProduct_Distrubutors_comboBox.SelectedIndex != -1)
            {
                profit = addNewProduct_Profit_textbox.Text;
                purpose = addNewProduct_purchasePrice_textbox.Text;
                maxDiscount = addNewProduct_MaxDiscount_textbox.Text;
                fixDiscount = addNewProduct_itemFixDiscount_textbox.Text;
                color1 = addProducts_colorName_label.Text;
                color2 = addProducts_colorName_label2.Text;
                color3 = addProducts_colorName_label3.Text;
                Expiridate = addNewProduct_Date_dateTimePicker.Value;

                MessageBox.Show("Okkkk");
              
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
            addNewProduct_size_textbox.BackColor = Color.White;
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

        private void addNewProduct_Packs_textbox_MouseClick(object sender, MouseEventArgs e)
        {

            addNewProduct_Packs_textbox.BackColor = Color.White;
        }

        private void addNewProduct_QtyHand_textbox_MouseClick(object sender, MouseEventArgs e)
        {
            addNewProduct_QtyHand_textbox.BackColor = Color.White;
        }

        private void addNewProduct_QtyStock_textbox_MouseClick(object sender, MouseEventArgs e)
        {
            addNewProduct_QtyStock_textbox.BackColor = Color.White;
        }

        private void addNewProduct_MinStock_textbox_MouseClick(object sender, MouseEventArgs e)
        {
            addNewProduct_MinStock_textbox.BackColor = Color.White;
        }

        private void addNewProduct_SalePrice_textbox_MouseClick(object sender, MouseEventArgs e)
        {
            addNewProduct_SalePrice_textbox.BackColor = Color.White;
        }

        private void addNewProduct_Distrubutors_comboBox_MouseClick(object sender, MouseEventArgs e)
        {
            addNewProduct_Distrubutors_comboBox.BackColor = Color.White;
        }

        private void addNewProduct_code_textbox_MouseClick(object sender, MouseEventArgs e)
        {
            addNewProduct_code_textbox.BackColor = Color.White;
        }

        private void gruop_Enter(object sender, EventArgs e)
        {

        }
    }
}

