using PointOfSale.DbConfiguration;
using PointOfSale.OthersForms;
using PointOfSale.Utils;
using PointOfSale.Utils.TablesClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class AddNewProduct : Form
    {
        public int  check=0;
        private bool t;
        private String id;
        public bool ActiveOrIn
        {
            set
            {
                addNewProduct_inActive_checkBox.Checked = value;
            }
        }
        public  String barCode
        {
            set
            {
                addNewProduct_code_textbox.Text = value;
            }
        }
        public String PName
        {
            set
            {
                adddNewProducts_ProductName_comboBox.Text = value;
            }
        }
        public  String cName
        {
            set
            {
                adddNewProducts_companyName_comboBox.Text = value;
            }
        }
        public String Purpose
        {
            set
            {
                adddNewProducts_Purpose_comboBox.Text = value;
            }
        } 

        public String descreption
        {
            set
            {
                adddNewProducts_Description_comboBox.Text = value;
            }
        }

        public String PCategory
        {
            set
            {
                adddNewProducts_Category_comboBox.Text = value;
            }
        }
        public String Location
        {
            set
            {
                adddNewProducts_Location_comboBox.Text = value;
            }
        }

        public DateTime ExpiryDate
        {
            set
            {
                addNewProduct_Date_dateTimePicker.Value = value;
            }
        }

        public String Batch
        {
            set
            {
                addNewProduct_Batch_textbox.Text = value;

            }
        }

        public  String PColor1
        {
            set
            {
                addProducts_colorName_label.Text = value;
                addProducts_colorName_label.BackColor = System.Drawing.Color.FromName(addProducts_colorName_label.Text);
            }
        }

        public String PColor2
        {
            set
            {
                addProducts_colorName_label2.Text = value;
                addProducts_colorName_label2.BackColor = System.Drawing.Color.FromName(addProducts_colorName_label2.Text);
            }
        }
        public String PColor3
        {
            set
            {
                addProducts_colorName_label3.Text = value;
                addProducts_colorName_label3.BackColor = System.Drawing.Color.FromName(addProducts_colorName_label3.Text);
            }
        }
        public String pSize
        {
            set
            {
                addNewProduct_size_textbox.Text = value;
            }
        }

        public String Units
        {
            set
            {
                adddNewProducts_Units_comboBox.Text = value;
            }
        }
        public String qntyPack
        {
            set
            {
                addNewProduct_QtyPack_textbox.Text = value;
            }
        }

        public String packs
        {
            set
            {
                addNewProduct_Packs_textbox.Text = value;
            }
        }
        public String QntyHand
        {
            set
            {
                addNewProduct_QtyHand_textbox.Text = value;
            }
        }
        public String totalPacks
        {
            set
            {
                addNewProduct_TotalPacks_textbox.Text = value;
            }
        }
        public String maxQuantity
        {
            set
            {
                addNewProduct_QtyStock_textbox.Text = value;

            }
        }
        public  String minQuantity
        {
            set
            {
                addNewProduct_MinStock_textbox.Text = value;
            }
        }
        public String salePrice
        {
            set
            {
                addNewProduct_SalePrice_textbox.Text = value;
            }
        }
        public String profit
        {
            set
            {
                addNewProduct_Profit_textbox.Text = value;
            }
        }
        public String purchasePrice
        {
            set
            {
                addNewProduct_purchasePrice_textbox.Text = value;
            }
        }

        public String maxDiscount
        {
            set
            {
                addNewProduct_MaxDiscount_textbox.Text = value;
            }
        }
        public String itemDiscont
        {
            set
            {
                addNewProduct_itemFixDiscount_textbox.Text = value;

            }
        }
        public String Distributor
        {
            set
            {
                addNewProduct_Distrubutors_comboBox.Text = value;
            }
        }

        public bool T
        {
            get
            {
                return t;
            }

            set
            {
                t = value;
                AddNewProduct_Update_btn.Visible = true;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

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

                    textbox.Text = c.Name.ToString();
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
            addNewProducts();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            addNewProducts();
            ClearForm();
        }


        /*
        Clear Form
        */

            public void ClearForm()
        {

            if (!String.IsNullOrEmpty(addNewProduct_code_textbox.Text) &&
                 (adddNewProducts_ProductName_comboBox.SelectedIndex != -1) &&
                 (adddNewProducts_Category_comboBox.SelectedIndex != -1))
            {

                addNewProduct_code_textbox.Clear();
                adddNewProducts_ProductName_comboBox.Text = "";
                adddNewProducts_companyName_comboBox.Text = "";
                adddNewProducts_Purpose_comboBox.Text = "";
                adddNewProducts_Description_comboBox.Text = "";
                adddNewProducts_Category_comboBox.Text = "";
                adddNewProducts_Location_comboBox.Text = "";
                addNewProduct_Date_dateTimePicker.Value = DateTime.Now;
                addNewProduct_Batch_textbox.Clear();
                addProducts_colorName_label.BackColor = SystemColors.Control;
                addProducts_colorName_label.Text = "1";
                addProducts_colorName_label2.BackColor = SystemColors.Control;
                addProducts_colorName_label2.Text = "2";
                addProducts_colorName_label3.BackColor = SystemColors.Control;
                addProducts_colorName_label3.Text = "3";

                addNewProduct_size_textbox.Clear();
                adddNewProducts_Units_comboBox.Text = "";
                addNewProduct_QtyPack_textbox.Clear();
                addNewProduct_Packs_textbox.Clear();
                addNewProduct_QtyHand_textbox.Clear();
                addNewProduct_TotalPacks_textbox.Clear();
                addNewProduct_MinStock_textbox.Clear();
                addNewProduct_QtyStock_textbox.Clear();
                addNewProduct_SalePrice_textbox.Clear();
                addNewProduct_Profit_textbox.Clear();
                addNewProduct_purchasePrice_textbox.Clear();
                addNewProduct_Distrubutors_comboBox.Text = "";
                addNewProduct_itemFixDiscount_textbox.Clear();

                addNewProduct_MaxDiscount_textbox.Clear();
                if (addNewProduct_updatestock_checkBox.Checked)
                {
                    addNewProduct_updatestock_checkBox.Checked = !addNewProduct_updatestock_checkBox.Checked;
                }
                if (addNewProduct_inActive_checkBox.Checked)
                {
                    addNewProduct_inActive_checkBox.Checked = !addNewProduct_inActive_checkBox.Checked;
                }
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

        private void addNewProduct_QtyStock_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void addNewProduct_QtyPack_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addNewProduct_purchasePrice_textbox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void addNewProduct_Profit_textbox_TextChanged(object sender, EventArgs e)
        {



        }

        private void addNewProduct_SalePrice_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            new AddProductName().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new AddCompanyName().Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new AddPurpose().Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new AddDiscription().Show();
        }

        private void addNewProduct_Profit_textbox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)

            {

                //if (!String.IsNullOrEmpty(addNewProduct_SalePrice_textbox.Text) &&
                //    String.IsNullOrEmpty(addNewProduct_purchasePrice_textbox.Text) &&
                //    !String.IsNullOrEmpty(addNewProduct_Profit_textbox.Text))
                //{
                float a = float.Parse(addNewProduct_Profit_textbox.Text);
                 float f = Int32.Parse(addNewProduct_Profit_textbox.Text) % 100;
               //     int t = ( f * Int32.Parse(addNewProduct_SalePrice_textbox.Text));
                 Debug.WriteLine("dataaaa "+ (a/100) * Int32.Parse(addNewProduct_SalePrice_textbox.Text));
                addNewProduct_purchasePrice_textbox.Text =  Math.Round (((a / 100) * Int32.Parse(addNewProduct_SalePrice_textbox.Text))).ToString();
                //}
            }
        }

        private void addNewProduct_purchasePrice_textbox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)

            {
                float sale = float.Parse(addNewProduct_SalePrice_textbox.Text);
                float purchase = float.Parse(addNewProduct_purchasePrice_textbox.Text);
                int prof = Convert.ToInt32(sale - purchase);
                addNewProduct_Profit_textbox.Text = prof.ToString();

            }
        }

        /*
          Add New Products
    */
    public void addNewProducts()
        {


            int totalprofit = 0;
            int purchasePrice = 0;
            DateTime? Expiridate = null;
            String code = null;
            String pName = null;
            String CName = null;
            String purpose = null;
            String description = null;
            String category = null, color1 = null, color2 = null, color3 = null;
            String location = null, fixDiscount = null, updateStock = null, inactiveProduct = null;
            String batch = null, salePrice = null, profit = null, pPrice = null, maxDiscount = null;
            String size = null, QtyHand = null, QtyStock = null, minstock = null, maxQuantity = null;
            String unit = null, packs = null, TotalPacks = null, Qtypack = null, distrubutors = null;

            // check Code

            if (!String.IsNullOrEmpty(addNewProduct_code_textbox.Text))
            {
                // check  Duplication off bar code....
               ArrayList list =   handleProducts.getProductListNoFilter();
                foreach(TableAddNewProducts  p  in list)
                {
                    if(p.BarCode == addNewProduct_code_textbox.Text)
                    {
                        MessageBox.Show("This barcode Already  used");
                       
                        ClearForm();
                        Close();
                    }
                    else {
                        code = addNewProduct_code_textbox.Text;

                    }
                }

               

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
            if (adddNewProducts_companyName_comboBox.SelectedIndex != -1)
            {
                CName = adddNewProducts_companyName_comboBox.SelectedItem.ToString();

            }
            else
            {
                CName = "";

            }
            //   Check Purpose
            if (adddNewProducts_Purpose_comboBox.SelectedIndex != -1)
            {
                purpose = adddNewProducts_Purpose_comboBox.SelectedItem.ToString();

            }
            else
            {
                purpose = "";

            }
            // Check Description
            if (adddNewProducts_Description_comboBox.SelectedIndex != -1)
            {
                description = adddNewProducts_Description_comboBox.SelectedItem.ToString();

            }
            else
            {
                description = "";


            }
            // Check Category
            if (adddNewProducts_Category_comboBox.SelectedIndex != -1)
            {
                category = adddNewProducts_Category_comboBox.SelectedItem.ToString();

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
                location = "";


            }

            // Check Batch 

            if (!String.IsNullOrEmpty(addNewProduct_Batch_textbox.Text))
            {
                batch = addNewProduct_Batch_textbox.Text;

            }
            else
            {
                batch = "0";


            }


            // check Size

            if (!String.IsNullOrEmpty(addNewProduct_size_textbox.Text))
            {
                size = addNewProduct_size_textbox.Text;

            }
            else
            {
                size = "0";

            }
            // Check Units
            if (adddNewProducts_Units_comboBox.SelectedIndex != -1)
            {
                unit = adddNewProducts_Units_comboBox.SelectedItem.ToString();

            }
            else
            {
                unit = "";



            }
            // Check Quantity Packs
            if (!String.IsNullOrEmpty(addNewProduct_QtyPack_textbox.Text))
            {
                Qtypack = addNewProduct_QtyPack_textbox.Text;

            }
            else
            {
                Qtypack = "0";


            }

            //  Packs
            if (!String.IsNullOrEmpty(addNewProduct_Packs_textbox.Text))
            {
                TotalPacks = addNewProduct_Packs_textbox.Text;

            }
            else
            {
                TotalPacks = "0";


            }

            //  give total  Pack.........

            if (!String.IsNullOrEmpty(addNewProduct_QtyPack_textbox.Text) && !String.IsNullOrEmpty(addNewProduct_Packs_textbox.Text) &&
                 !String.IsNullOrEmpty(addNewProduct_QtyHand_textbox.Text))
            {
                int qPack = Int32.Parse(addNewProduct_QtyPack_textbox.Text);
                int pack = Int32.Parse(addNewProduct_Packs_textbox.Text);
                int hand = Int32.Parse(addNewProduct_QtyHand_textbox.Text);
                int total = qPack * pack + hand;
                addNewProduct_TotalPacks_textbox.Text = System.Convert.ToString(total);
            }
            if (!String.IsNullOrEmpty(addNewProduct_QtyPack_textbox.Text) && !String.IsNullOrEmpty(addNewProduct_Packs_textbox.Text) &&
                 String.IsNullOrEmpty(addNewProduct_QtyHand_textbox.Text))
            {
                int qPack = Int32.Parse(addNewProduct_QtyPack_textbox.Text);
                int pack = Int32.Parse(addNewProduct_Packs_textbox.Text);

                int total = qPack * pack;
                addNewProduct_TotalPacks_textbox.Text = System.Convert.ToString(total);


            }
            if (String.IsNullOrEmpty(addNewProduct_QtyPack_textbox.Text) && String.IsNullOrEmpty(addNewProduct_Packs_textbox.Text) &&
                 !String.IsNullOrEmpty(addNewProduct_QtyHand_textbox.Text))
            {

                int total = Int32.Parse(addNewProduct_QtyHand_textbox.Text);
                addNewProduct_TotalPacks_textbox.Text = System.Convert.ToString(total);


            }
            if (String.IsNullOrEmpty(addNewProduct_QtyPack_textbox.Text) && String.IsNullOrEmpty(addNewProduct_Packs_textbox.Text) &&
                String.IsNullOrEmpty(addNewProduct_QtyHand_textbox.Text))
            {

                addNewProduct_TotalPacks_textbox.Text = "0";

                QtyHand = "0";


            }

            //
            if (!String.IsNullOrEmpty(addNewProduct_QtyHand_textbox.Text))
            {
                QtyHand = addNewProduct_QtyHand_textbox.Text;

            }
            else
            {
                QtyHand = "0";


            }
            //   Add Quantity Stock
            if (!String.IsNullOrEmpty(addNewProduct_QtyStock_textbox.Text))
            {
                QtyStock = addNewProduct_QtyStock_textbox.Text;

            }
            else
            {
                QtyStock = "0";


            }
            // Min Stock
            if (!String.IsNullOrEmpty(addNewProduct_MinStock_textbox.Text))
            {
                minstock = addNewProduct_MinStock_textbox.Text;

            }
            else
            {
                minstock = "0";


            }
            // Check  Sale Price
            if (!String.IsNullOrEmpty(addNewProduct_SalePrice_textbox.Text))
            {
                salePrice = addNewProduct_SalePrice_textbox.Text;

            }
            else
            {
                salePrice = "0";

            }


            //  Check Distributors
            if (addNewProduct_Distrubutors_comboBox.SelectedIndex != -1)
            {
                distrubutors = addNewProduct_Distrubutors_comboBox.SelectedItem.ToString();

            }
            else
            {

                distrubutors = "0";


            }

            // Check Update Stock
            if (addNewProduct_updatestock_checkBox.Checked)
            {



                updateStock = DateTime.Today.ToString("dd-MM-yyyy");

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
                inactiveProduct = "no";
            }
            if (!String.IsNullOrEmpty(addNewProduct_code_textbox.Text) && (adddNewProducts_ProductName_comboBox.SelectedIndex != -1) &&
                adddNewProducts_Category_comboBox.SelectedIndex != -1)
            {
                TableAddNewProducts products = new TableAddNewProducts();

                // check profit..
                if (!String.IsNullOrEmpty(addNewProduct_Profit_textbox.Text) && String.IsNullOrEmpty(addNewProduct_purchasePrice_textbox.Text))
                {
                    profit = addNewProduct_Profit_textbox.Text;
                    float a = float.Parse(profit);
                    double d = Math.Round((a / 100) * Int32.Parse(salePrice));
                    totalprofit = Convert.ToInt32(d);

                }
                else
                {
                    profit = "0";
                    totalprofit = 0;
                }


                if (!String.IsNullOrEmpty(addNewProduct_Profit_textbox.Text) && !String.IsNullOrEmpty(addNewProduct_purchasePrice_textbox.Text) && String.IsNullOrEmpty(addNewProduct_Profit_textbox.Text))
                {
                    totalprofit = Int32.Parse(salePrice) - purchasePrice;
                }
                else
                {
                    totalprofit = 0;
                }



                //  purpose = adddNewProducts_Purpose_comboBox.Text;
                if (!String.IsNullOrEmpty(addNewProduct_purchasePrice_textbox.Text))
                {
                    purchasePrice = Int32.Parse(addNewProduct_purchasePrice_textbox.Text);
                }
                else
                {
                    purchasePrice = 0;
                }
                String totalP;
                if (!String.IsNullOrEmpty(addNewProduct_TotalPacks_textbox.Text))
                {
                    totalP = addNewProduct_TotalPacks_textbox.Text;
                }
                else
                {
                    totalP = "0";
                }

                maxDiscount = addNewProduct_MaxDiscount_textbox.Text;
                fixDiscount = addNewProduct_itemFixDiscount_textbox.Text;
                color1 = addProducts_colorName_label.Text;
                color2 = addProducts_colorName_label2.Text;
                color3 = addProducts_colorName_label3.Text;
                Expiridate = addNewProduct_Date_dateTimePicker.Value;
                products.BarCode = code;
                products.ProductName = pName;
                products.ProductCompanyName = CName;
                products.ProductPurpose = purpose;
                products.ProductDescription = description;
                products.Category = category;
                products.Location1 = location;

                products.ProductExpidate = Expiridate.Value;
                products.ProductBatch = batch;
                products.ProductColor1 = color1;
                products.ProductColor2 = color2;
                products.ProductColor3 = color3;
                products.Productsize = size;
                products.ProductUnits = unit;
                products.ProductUpdateStock = updateStock;
                products.ProductQuantityPack = Int32.Parse(Qtypack);
                products.ProductTotalPeice = Int32.Parse(TotalPacks);
                products.ProductTotalPacks = Int32.Parse(totalP);

                if (maxQuantity == null)
                {
                    maxQuantity = "0";
                }

                if (!String.IsNullOrEmpty(maxDiscount))
                {
                    products.MaxDiscount = Int32.Parse(maxDiscount);
                }
                else
                {
                    products.MaxDiscount = 0;
                }
                if (!String.IsNullOrEmpty(fixDiscount))
                {

                    products.ProductItemDiscount = Int32.Parse(fixDiscount);

                }
                else
                {
                    products.ProductItemDiscount = 0;
                }

                products.ProductQntHand = Int32.Parse(QtyHand);
                products.ProductMinStock = Int32.Parse(minstock);
                products.ProductMaxStock = Int32.Parse(maxQuantity);
                products.ProductSalePrice = Int32.Parse(salePrice);
                products.ProductProfit = Int32.Parse(profit);
                products.ProductPurchasePrice = purchasePrice;
                products.ProductTotalPrice = totalprofit;
                DateTime Expiridatee = addNewProduct_Date_dateTimePicker.Value;
                products.ProductExpidate = Expiridatee;
                products.ProductDistributors = distrubutors;
                //products.ProductItemDiscount = Int32.Parse(fixDiscount);
                products.UpdateDate = updateStock;
                products.ProductInactive = inactiveProduct;


                handleProducts.addNewProducts(products);

                MessageBox.Show("  Product Enter");
                Debug.WriteLine("User Login--- " + Constants.userlogin);
               
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new AddNewCategory().Show();

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            adddNewProducts_ProductName_comboBox.Items.Clear();
            adddNewProducts_companyName_comboBox.Items.Clear();
            adddNewProducts_Purpose_comboBox.Items.Clear();
            adddNewProducts_Category_comboBox.Items.Clear();
            adddNewProducts_Description_comboBox.Items.Clear();
            adddNewProducts_Location_comboBox.Items.Clear();
            adddNewProducts_Purpose_comboBox.Items.Clear();
            adddNewProducts_Units_comboBox.Items.Clear();
            addNewProduct_Distrubutors_comboBox.Items.Clear();
            loadProductCategory();
            loadCompanyNames();
            loadProductName();
            loadDescreptionName();
            loadLocation();
            loadPurposeName();
            loadUnits();
            loadDistrubutors();


        }

        private void button13_Click(object sender, EventArgs e)
        {
            new AddNewSize().Show();
        }

        private void AddNewProduct_Update_btn_Click(object sender, EventArgs e)
        {
            updateProducts();
        }

        public void updateProducts()
        {
            int totalprofit = 0;
            int purchasePrice = 0;
            DateTime? Expiridate = null;
            String code = null;
            String pName = null;
            String CName = null;
            String purpose = null;
            String description = null;
            String category = null, color1 = null, color2 = null, color3 = null;
            String location = null, fixDiscount = null, updateStock = null, inactiveProduct = null;
            String batch = null, salePrice = null, profit = null, pPrice = null, maxDiscount = null;
            String size = null, QtyHand = null, QtyStock = null, minstock = null, maxQuantity = null;
            String unit = null, packs = null, TotalPacks = null, Qtypack = null, distrubutors = null;

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
            if (adddNewProducts_companyName_comboBox.SelectedIndex != -1)
            {
                CName = adddNewProducts_companyName_comboBox.SelectedItem.ToString();

            }
            else
            {
                CName = "";

            }
            //   Check Purpose
            if (adddNewProducts_Purpose_comboBox.SelectedIndex != -1)
            {
                purpose = adddNewProducts_Purpose_comboBox.SelectedItem.ToString();

            }
            else
            {
                purpose = "";

            }
            // Check Description
            if (adddNewProducts_Description_comboBox.SelectedIndex != -1)
            {
                description = adddNewProducts_Description_comboBox.SelectedItem.ToString();

            }
            else
            {
                description = "";


            }
            // Check Category
            if (adddNewProducts_Category_comboBox.SelectedIndex != -1)
            {
                category = adddNewProducts_Category_comboBox.SelectedItem.ToString();

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
                location = "";


            }

            // Check Batch 

            if (!String.IsNullOrEmpty(addNewProduct_Batch_textbox.Text))
            {
                batch = addNewProduct_Batch_textbox.Text;

            }
            else
            {
                batch = "0";


            }


            // check Size

            if (!String.IsNullOrEmpty(addNewProduct_size_textbox.Text))
            {
                size = addNewProduct_size_textbox.Text;

            }
            else
            {
                size = "0";

            }
            // Check Units
            if (adddNewProducts_Units_comboBox.SelectedIndex != -1)
            {
                unit = adddNewProducts_Units_comboBox.SelectedItem.ToString();

            }
            else
            {
                unit = "";



            }
            // Check Quantity Packs
            if (!String.IsNullOrEmpty(addNewProduct_QtyPack_textbox.Text))
            {
                Qtypack = addNewProduct_QtyPack_textbox.Text;

            }
            else
            {
                Qtypack = "0";


            }

            //  Packs
            if (!String.IsNullOrEmpty(addNewProduct_Packs_textbox.Text))
            {
                TotalPacks = addNewProduct_Packs_textbox.Text;

            }
            else
            {
                TotalPacks = "0";


            }

            //  give total  Pack.........

            if (!String.IsNullOrEmpty(addNewProduct_QtyPack_textbox.Text) && !String.IsNullOrEmpty(addNewProduct_Packs_textbox.Text) &&
                 !String.IsNullOrEmpty(addNewProduct_QtyHand_textbox.Text))
            {
                int qPack = Int32.Parse(addNewProduct_QtyPack_textbox.Text);
                int pack = Int32.Parse(addNewProduct_Packs_textbox.Text);
                int hand = Int32.Parse(addNewProduct_QtyHand_textbox.Text);
                int total = qPack * pack + hand;
                addNewProduct_TotalPacks_textbox.Text = System.Convert.ToString(total);
            }
            if (!String.IsNullOrEmpty(addNewProduct_QtyPack_textbox.Text) && !String.IsNullOrEmpty(addNewProduct_Packs_textbox.Text) &&
                 String.IsNullOrEmpty(addNewProduct_QtyHand_textbox.Text))
            {
                int qPack = Int32.Parse(addNewProduct_QtyPack_textbox.Text);
                int pack = Int32.Parse(addNewProduct_Packs_textbox.Text);

                int total = qPack * pack;
                addNewProduct_TotalPacks_textbox.Text = System.Convert.ToString(total);


            }
            if (String.IsNullOrEmpty(addNewProduct_QtyPack_textbox.Text) && String.IsNullOrEmpty(addNewProduct_Packs_textbox.Text) &&
                 !String.IsNullOrEmpty(addNewProduct_QtyHand_textbox.Text))
            {

                int total = Int32.Parse(addNewProduct_QtyHand_textbox.Text);
                addNewProduct_TotalPacks_textbox.Text = System.Convert.ToString(total);


            }
            if (String.IsNullOrEmpty(addNewProduct_QtyPack_textbox.Text) && String.IsNullOrEmpty(addNewProduct_Packs_textbox.Text) &&
                String.IsNullOrEmpty(addNewProduct_QtyHand_textbox.Text))
            {

                addNewProduct_TotalPacks_textbox.Text = "0";

                QtyHand = "0";


            }

            //
            if (!String.IsNullOrEmpty(addNewProduct_QtyHand_textbox.Text))
            {
                QtyHand = addNewProduct_QtyHand_textbox.Text;

            }
            else
            {
                QtyHand = "0";


            }
            //   Add Quantity Stock
            if (!String.IsNullOrEmpty(addNewProduct_QtyStock_textbox.Text))
            {
                QtyStock = addNewProduct_QtyStock_textbox.Text;

            }
            else
            {
                QtyStock = "0";


            }
            // Min Stock
            if (!String.IsNullOrEmpty(addNewProduct_MinStock_textbox.Text))
            {
                minstock = addNewProduct_MinStock_textbox.Text;

            }
            else
            {
                minstock = "0";


            }
            // Check  Sale Price
            if (!String.IsNullOrEmpty(addNewProduct_SalePrice_textbox.Text))
            {
                salePrice = addNewProduct_SalePrice_textbox.Text;

            }
            else
            {
                salePrice = "0";

            }


            //  Check Distributors
            if (addNewProduct_Distrubutors_comboBox.SelectedIndex != -1)
            {
                distrubutors = addNewProduct_Distrubutors_comboBox.SelectedItem.ToString();

            }
            else
            {

                distrubutors = "0";


            }

            // Check Update Stock
            if (addNewProduct_updatestock_checkBox.Checked)
            {



                updateStock = DateTime.Today.ToString("dd-MM-yyyy");

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
                inactiveProduct = "no";
            }
            if (!String.IsNullOrEmpty(addNewProduct_code_textbox.Text) && (adddNewProducts_ProductName_comboBox.SelectedIndex != -1) &&
                adddNewProducts_Category_comboBox.SelectedIndex != -1)
            {
                TableAddNewProducts products = new TableAddNewProducts();

                // check profit..
                if (!String.IsNullOrEmpty(addNewProduct_Profit_textbox.Text) && String.IsNullOrEmpty(addNewProduct_purchasePrice_textbox.Text))
                {
                    profit = addNewProduct_Profit_textbox.Text;
                    float a = float.Parse(profit);
                    double d = Math.Round((a / 100) * Int32.Parse(salePrice));
                    totalprofit = Convert.ToInt32(d);

                }
                else
                {
                    profit = "0";
                    totalprofit = 0;
                }


                if (!String.IsNullOrEmpty(addNewProduct_Profit_textbox.Text) && !String.IsNullOrEmpty(addNewProduct_purchasePrice_textbox.Text) && String.IsNullOrEmpty(addNewProduct_Profit_textbox.Text))
                {
                    totalprofit = Int32.Parse(salePrice) - purchasePrice;
                }
                else
                {
                    totalprofit = 0;
                }



                //  purpose = adddNewProducts_Purpose_comboBox.Text;
                if (!String.IsNullOrEmpty(addNewProduct_purchasePrice_textbox.Text))
                {
                    purchasePrice = Int32.Parse(addNewProduct_purchasePrice_textbox.Text);
                }
                else
                {
                    purchasePrice = 0;
                }
                String totalP;
                if (!String.IsNullOrEmpty(addNewProduct_TotalPacks_textbox.Text))
                {
                    totalP = addNewProduct_TotalPacks_textbox.Text;
                }
                else
                {
                    totalP = "0";
                }

                maxDiscount = addNewProduct_MaxDiscount_textbox.Text;
                fixDiscount = addNewProduct_itemFixDiscount_textbox.Text;
                color1 = addProducts_colorName_label.Text;
                color2 = addProducts_colorName_label2.Text;
                color3 = addProducts_colorName_label3.Text;
                Expiridate = addNewProduct_Date_dateTimePicker.Value;
                products.BarCode = code;
                products.ProductName = pName;
                products.ProductCompanyName = CName;
                products.ProductPurpose = purpose;
                products.ProductDescription = description;
                products.Category = category;
                products.Location1 = location;

                products.ProductExpidate = Expiridate.Value;
                products.ProductBatch = batch;
                products.ProductColor1 = color1;
                products.ProductColor2 = color2;
                products.ProductColor3 = color3;
                products.Productsize = size;
                products.ProductUnits = unit;
                products.ProductUpdateStock = updateStock;
                products.ProductQuantityPack = Int32.Parse(Qtypack);
                products.ProductTotalPeice = Int32.Parse(TotalPacks);
                products.ProductTotalPacks = Int32.Parse(totalP);

                if (maxQuantity == null)
                {
                    maxQuantity = "0";
                }

                if (!String.IsNullOrEmpty(maxDiscount))
                {
                    products.MaxDiscount = Int32.Parse(maxDiscount);
                }
                else
                {
                    products.MaxDiscount = 0;
                }
                if (!String.IsNullOrEmpty(fixDiscount))
                {

                    products.ProductItemDiscount = Int32.Parse(fixDiscount);

                }
                else
                {
                    products.ProductItemDiscount = 0;
                }

                products.ProductQntHand = Int32.Parse(QtyHand);
                products.ProductMinStock = Int32.Parse(minstock);
                products.ProductMaxStock = Int32.Parse(maxQuantity);
                products.ProductSalePrice = Int32.Parse(salePrice);
                products.ProductProfit = Int32.Parse(profit);
                products.ProductPurchasePrice = purchasePrice;
                products.ProductTotalPrice = totalprofit;
                DateTime Expiridatee = addNewProduct_Date_dateTimePicker.Value;
                products.ProductExpidate = Expiridatee;
                products.ProductDistributors = distrubutors;
                //products.ProductItemDiscount = Int32.Parse(fixDiscount);
                products.UpdateDate = updateStock;
                products.ProductInactive = inactiveProduct;

                products.ProductId = Int32.Parse(id);
                handleProducts.updateProductList(products);

                MessageBox.Show("  Update Product");
                Debug.WriteLine("User Login--- " + Constants.userlogin);
            }

            }
        }
}

