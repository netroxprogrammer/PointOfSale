using PointOfSale.DbConfiguration;
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

namespace PointOfSale.ListForms
{
    public partial class ProductList : Form
    {
        HandleProducts products;
        int sum = 0;
        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            products = new HandleProducts();
            getProductsList("yes");

        }

        // list of  Products.
        public void getProductsList(String active)
        {

       
            WorkingForm_AllProduct_listView.Columns.Clear();
            WorkingForm_AllProduct_listView.Items.Clear();
            WorkingForm_AllProduct_listView.Columns.Add("Product Id", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Bar Code", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Name", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Company Name", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Purpose", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Description", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Category", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Sale Price", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Quantiy Hand", 110, HorizontalAlignment.Left);
            // WorkingForm_AllProduct_listView.Columns.Add("Location", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Expiry date", 110, HorizontalAlignment.Left);
            /*  WorkingForm_AllProduct_listView.Columns.Add("Batch", 110, HorizontalAlignment.Left);
              WorkingForm_AllProduct_listView.Columns.Add("Color 1", 110, HorizontalAlignment.Left);
              WorkingForm_AllProduct_listView.Columns.Add("Color 2", 110, HorizontalAlignment.Left);
              WorkingForm_AllProduct_listView.Columns.Add("Color 3", 110, HorizontalAlignment.Left);
              WorkingForm_AllProduct_listView.Columns.Add("Size", 110, HorizontalAlignment.Left);
              WorkingForm_AllProduct_listView.Columns.Add("Quantity Pack", 110, HorizontalAlignment.Left);
              WorkingForm_AllProduct_listView.Columns.Add("No. Packs", 110, HorizontalAlignment.Left);
              WorkingForm_AllProduct_listView.Columns.Add("Total Packs", 110, HorizontalAlignment.Left);
              WorkingForm_AllProduct_listView.Columns.Add("Qty in hands", 110, HorizontalAlignment.Left);
              WorkingForm_AllProduct_listView.Columns.Add("Max Stock", 110, HorizontalAlignment.Left);
              WorkingForm_AllProduct_listView.Columns.Add("Min Stock", 110, HorizontalAlignment.Left);
              WorkingForm_AllProduct_listView.Columns.Add("Sale Price", 110, HorizontalAlignment.Left);
              WorkingForm_AllProduct_listView.Columns.Add("Profit %", 110, HorizontalAlignment.Left);
              WorkingForm_AllProduct_listView.Columns.Add("Purchase Price", 110, HorizontalAlignment.Left);
              WorkingForm_AllProduct_listView.Columns.Add("Max discount", 110, HorizontalAlignment.Left);
              WorkingForm_AllProduct_listView.Columns.Add("Item Discount", 110, HorizontalAlignment.Left);
              WorkingForm_AllProduct_listView.Columns.Add("Item Fix Discont", 110, HorizontalAlignment.Left);

              WorkingForm_AllProduct_listView.Columns.Add("Distributors", 110, HorizontalAlignment.Left);
              WorkingForm_AllProduct_listView.Columns.Add("Update Stock Date", 110, HorizontalAlignment.Left);
              WorkingForm_AllProduct_listView.Columns.Add("Inactive Products", 110, HorizontalAlignment.Left);
              WorkingForm_AllProduct_listView.Columns.Add("Entry Date", 110, HorizontalAlignment.Left);
              WorkingForm_AllProduct_listView.Columns.Add("Update Product Date", 110, HorizontalAlignment.Left);*/

            products = new HandleProducts();
            // WorkingForm_customerPanel.Visible = false;

            ArrayList prod = products.getProductList(active);

            foreach (TableAddNewProducts em in prod)
            {
                String[] rows = { em.ProductId.ToString(), em.BarCode, em.ProductName, em.ProductCompanyName,
                    em.ProductPurpose , em.ProductDescription, em.Category, em.ProductSalePrice.ToString() ,em.ProductQntHand.ToString(), em.ProductExpidate.ToString()
                };
                ListViewItem items = new ListViewItem(rows);
                WorkingForm_AllProduct_listView.Items.Add(items);



                sum = sum + (em.ProductQntHand * em.ProductPurchasePrice);
              
            }

            Product_List_Total_Values_textBox.Text = sum.ToString();


        }

        private void WorkingForm_AllProduct_listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            String id = WorkingForm_AllProduct_listView.SelectedItems[0].SubItems[0].Text;
            String barCode = WorkingForm_AllProduct_listView.SelectedItems[0].SubItems[1].Text;
            String pname = WorkingForm_AllProduct_listView.SelectedItems[0].SubItems[2].Text;
            String CName = WorkingForm_AllProduct_listView.SelectedItems[0].SubItems[3].Text;
            String purpose = WorkingForm_AllProduct_listView.SelectedItems[0].SubItems[4].Text;
            String disc = WorkingForm_AllProduct_listView.SelectedItems[0].SubItems[5].Text;
            String category = WorkingForm_AllProduct_listView.SelectedItems[0].SubItems[6].Text;
            String expdate = WorkingForm_AllProduct_listView.SelectedItems[0].SubItems[9].Text;
            //  MessageBox.Show(CName);
            AddNewProduct p = new AddNewProduct();


            ArrayList data = products.getProductListNoFilter();


            foreach (TableAddNewProducts d in data)
            {
                if (d.BarCode == barCode && d.ProductId == Int32.Parse(id))
                {
                    p.Id = id;
                    p.barCode = barCode;
                    p.PName = pname;
                    p.cName = CName;
                    p.Purpose = purpose;
                    p.descreption = disc;
                    p.PCategory = category;
                    p.ExpiryDate = System.Convert.ToDateTime(expdate);
                    p.Batch = d.ProductBatch.ToString();
                    p.PColor1 = d.ProductColor1;
                    p.PColor2 = d.ProductColor2;
                    p.PColor3 = d.ProductColor3;
                    p.pSize = d.Productsize.ToString();
                    p.Units = d.ProductUnits;
                    p.qntyPack = d.ProductQuantityPack.ToString();
                    p.packs = d.ProductTotalPeice.ToString();
                    p.QntyHand = d.ProductQntHand.ToString();
                    p.totalPacks = d.ProductTotalPacks.ToString();
                    p.maxQuantity = d.ProductMaxStock.ToString();
                    p.minQuantity = d.ProductMinStock.ToString();
                    p.salePrice = d.ProductSalePrice.ToString();
                    p.profit = d.ProductProfit.ToString();
                    p.purchasePrice = d.ProductPurchasePrice.ToString();
                    p.maxDiscount = d.MaxDiscount.ToString();
                    p.itemDiscont = d.ProductItemDiscount.ToString();
                    p.Distributor = d.ProductDistributors;
                    if (d.ProductInactive == "inactive")
                    {
                        p.ActiveOrIn = true;
                    }
                    p.T = true;
                }


            }
            p.Show();

        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddNewProduct().Show();
        }

        private void inactiveProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getProductsList("inactive");
        }

        private void showAllProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getProductsList("yes");
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            getProductsList("yes");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(Serach_Product_comboBox.SelectedIndex != -1)
            {
                if(Serach_Product_comboBox.SelectedItem.ToString() == "BarCode")
                {
                    choice.Enabled = true;
                    chooseDate.Enabled = false;
                    Select_Search_comboBox.Items.Clear();
                    Select_Search_comboBox.Text = " << BarCode >>";
                  ArrayList  data =    products.getProductList("yes");
                    foreach (TableAddNewProducts p in data)
                    {
                        Select_Search_comboBox.Items.Add(p.BarCode);
                    }
                }
                if (Serach_Product_comboBox.SelectedItem.ToString() == "product Name")
                {

                    choice.Enabled = true;
                    chooseDate.Enabled = false;
                    Select_Search_comboBox.Items.Clear();
                    Select_Search_comboBox.Text = " << product Name >>";
                    loadProductName();

                }
                if (Serach_Product_comboBox.SelectedItem.ToString() == "Company Name")
                {

                    choice.Enabled = true;
                    chooseDate.Enabled = false;
                    Select_Search_comboBox.Items.Clear();
                    Select_Search_comboBox.Text = " << Company Name >>";
                    loadCompanyNames();
                }
                if (Serach_Product_comboBox.SelectedItem.ToString() == "Purpose")
                {

                    choice.Enabled = true;
                    chooseDate.Enabled = false;
                    Select_Search_comboBox.Items.Clear();
                    Select_Search_comboBox.Text = " << Purpose >>";
                    loadPurposeName();
                }
                if (Serach_Product_comboBox.SelectedItem.ToString() == "Category")
                {

                    choice.Enabled = true;
                    chooseDate.Enabled = false;
                    Select_Search_comboBox.Items.Clear();
                    Select_Search_comboBox.Text = " << Category >>";
                    loadProductCategory();
                }

                if (Serach_Product_comboBox.SelectedItem.ToString() == "Descreption")
                {

                    choice.Enabled = true;
                   
                    Select_Search_comboBox.Items.Clear();
                    Select_Search_comboBox.Text = " << Descreption >>";
                    loadDescreptionName();
                }
                if (Serach_Product_comboBox.SelectedItem.ToString() == "Expirydate")
                {
                    chooseDate.Enabled = true;
                    choice.Enabled = false;
                }
            }
        }
        
        /*
        *  Load Product Category
        */
        public void loadProductCategory()
        {
            ArrayList getCatrg = products.getCategory();
            foreach (TableCategory category in getCatrg)
            {

                Select_Search_comboBox.Items.Add(category.cagtegoryName);
            }
        }

        /*
       *  Load CompanyName
       */
        public void loadCompanyNames()
        {
            ArrayList getProd = products.getCompanyNames(); ;
            foreach (TableCompany products in getProd)
            {

                Select_Search_comboBox.Items.Add(products.companyName);
            }
        }

        /*
        *  Load Product Name
        */
        public void loadProductName()
        {
            ArrayList getname = products.getProductNames();
            foreach (TableProductName name in getname)
            {

                Select_Search_comboBox.Items.Add(name.productName);
            }
        }

        /*
       *  Load Descreption
       */
        public void loadDescreptionName()
        {
            ArrayList getname = products.getDescreptions();
            foreach (TableDescription name in getname)
            {

                Select_Search_comboBox.Items.Add(name.descriptionName);
            }
        }

        /*
             *  Load Purpose
             */
        public void loadPurposeName()
        {
            ArrayList getname = products.getPurposeNames();
            foreach (TablePurpose name in getname)
            {

                Select_Search_comboBox.Items.Add(name.purposeName);
            }
        }

        /*
             *  Load Location
             */
        public void loadLocation()
        {
            ArrayList getname = products.getProductLocationNames();
            foreach (TableLocation name in getname)
            {

                Select_Search_comboBox.Items.Add(name.locationName);
            }
        }

        private void Select_Search_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Select_Search_comboBox.SelectedIndex != -1 && Serach_Product_comboBox.SelectedIndex != -1)
            {
                if (Serach_Product_comboBox.SelectedItem.ToString() == "BarCode")
                {
                    //  filter by bar code
                    TableAddNewProducts addp = new TableAddNewProducts();
                    addp.BarCode = Select_Search_comboBox.SelectedItem.ToString();
                    addp.ProductName = "emptyNAmes";
                    addp.ProductCompanyName = "emptyNAmes";
                    addp.ProductDescription = "emptyNAmes";
                    addp.ProductPurpose = "emptyNAmes";
                    addp.Category = "emptyNAmes";


                  ArrayList list =  products.productSearchAllTypes(addp);
                    addFilterList(list);
                }
                  // filter  by name
                if (Serach_Product_comboBox.SelectedItem.ToString() == "product Name")
                {
                    TableAddNewProducts addp = new TableAddNewProducts();
                    addp.ProductName = Select_Search_comboBox.SelectedItem.ToString();
                    addp.BarCode = "emptyNAmes";
                    addp.ProductCompanyName = "emptyNAmes";
                    addp.ProductDescription = "emptyNAmes";
                    addp.ProductPurpose = "emptyNAmes";
                    addp.Category = "emptyNAmes";
                    ArrayList list = products.productSearchAllTypes(addp);
                    addFilterList(list);
                }

                // filter  by Descreption
                if (Serach_Product_comboBox.SelectedItem.ToString() == "Descreption")
                {
                    TableAddNewProducts addp = new TableAddNewProducts();
                    addp.ProductDescription = Select_Search_comboBox.SelectedItem.ToString();
                    addp.BarCode = "emptyNAmes";
                    addp.ProductCompanyName = "emptyNAmes";
                    addp.ProductName = "emptyNAmes";
                    addp.ProductPurpose = "emptyNAmes";
                    addp.Category = "emptyNAmes";
                    ArrayList list = products.productSearchAllTypes(addp);
                    addFilterList(list);
                }
                // filter  by Purpose
                if (Serach_Product_comboBox.SelectedItem.ToString() == "Purpose")
                {
                    TableAddNewProducts addp = new TableAddNewProducts();
                    addp.ProductPurpose = Select_Search_comboBox.SelectedItem.ToString();
                    addp.BarCode = "emptyNAmes";
                    addp.ProductCompanyName = "emptyNAmes";
                    addp.ProductDescription = "emptyNAmes";
                    addp.ProductName = "emptyNAmes";
                    addp.Category = "emptyNAmes";
                    ArrayList list = products.productSearchAllTypes(addp);
                    addFilterList(list);
                }

                // filter  by Category
                if (Serach_Product_comboBox.SelectedItem.ToString() == "Category")
                {
                    TableAddNewProducts addp = new TableAddNewProducts();
                    addp.Category = Select_Search_comboBox.SelectedItem.ToString();
                    addp.BarCode = "emptyNAmes";
                    addp.ProductCompanyName = "emptyNAmes";
                    addp.ProductDescription = "emptyNAmes";
                    addp.ProductPurpose = "emptyNAmes";
                    addp.ProductName = "emptyNAmes";
                    ArrayList list = products.productSearchAllTypes(addp);
                    addFilterList(list);
                }
                // filter  by Company name
                if (Serach_Product_comboBox.SelectedItem.ToString() == "Company Name")
                {
                    TableAddNewProducts addp = new TableAddNewProducts();
                    addp.ProductCompanyName = Select_Search_comboBox.SelectedItem.ToString();
                    addp.BarCode = "emptyNAmes";
                    addp.ProductName = "emptyNAmes";
                    addp.ProductDescription = "emptyNAmes";
                    addp.ProductPurpose = "emptyNAmes";
                    addp.Category = "emptyNAmes";
                    ArrayList list = products.productSearchAllTypes(addp);
                    addFilterList(list);
                }
            }

        }

        /* 
          Add Filter List

    */
     public void addFilterList(ArrayList list)
        {
        


            WorkingForm_AllProduct_listView.Columns.Clear();
            WorkingForm_AllProduct_listView.Items.Clear();
            WorkingForm_AllProduct_listView.Columns.Add("Product Id", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Bar Code", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Name", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Company Name", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Purpose", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Description", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Category", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Sale Price", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Quantiy Hand", 110, HorizontalAlignment.Left);
            // WorkingForm_AllProduct_listView.Columns.Add("Location", 110, HorizontalAlignment.Left);
            WorkingForm_AllProduct_listView.Columns.Add("Expiry date", 110, HorizontalAlignment.Left);


            foreach (TableAddNewProducts em in list)
            {
                Debug.WriteLine("--------------- "+em.ProductName);


                String[] rows = { em.ProductId.ToString(), em.BarCode, em.ProductName, em.ProductCompanyName,
                    em.ProductPurpose , em.ProductDescription, em.Category, em.ProductSalePrice.ToString() ,em.ProductQntHand.ToString(), em.ProductExpidate.ToString()
                };
                ListViewItem items = new ListViewItem(rows);
                WorkingForm_AllProduct_listView.Items.Add(items);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableAddNewProducts addp = new TableAddNewProducts();
            addp.ProductCompanyName = "emptyNAmes";
            addp.BarCode = "emptyNAmes";
            addp.ProductName = "emptyNAmes";
            addp.ProductDescription = "emptyNAmes";
            addp.ProductPurpose = "emptyNAmes";
            addp.Category = "emptyNAmes";
            addp.FromDate1 = from_dateTimePicker.Value;
            addp.ToDate = To_dateTimePicker.Value;
            ArrayList list = products.productBYDate(addp);
            addFilterList(list);

        }
    }
}
