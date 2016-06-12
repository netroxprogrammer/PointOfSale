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
    public partial class ProductList : Form
    {
        HandleProducts products;
        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            products = new HandleProducts();
            getProductsList("no");
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
                    em.ProductPurpose , em.ProductDescription, em.Category, em.ProductExpidate.ToString()
                };
                ListViewItem items = new ListViewItem(rows);
                WorkingForm_AllProduct_listView.Items.Add(items);
            }




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
            String expdate = WorkingForm_AllProduct_listView.SelectedItems[0].SubItems[7].Text;
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
            getProductsList("no");
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            getProductsList("no");
        }
    }
}
