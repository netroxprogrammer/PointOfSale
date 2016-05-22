using PointOfSale.DbConfiguration;
using PointOfSale.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
                else
                {
                    MessageBox.Show("Due to Any  issue Product Name Not Save");
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

        private void otherthings_saveCategory_btn_Click(object sender, EventArgs e)
        {
            TableCategory names = new TableCategory();

               String categoryName = otherthings_Category_text.Text;
            if (categoryName != "")
            {
                names.cagtegoryName = categoryName;
              int id =   handleProduct.addCategoryName(names);
                if (id >= 0)
                {
                    MessageBox.Show("One Category Insert");

                }
                else
                {
                    MessageBox.Show("Due to Any  issue Category Not Save");
                }
            }
            else
            {
                MessageBox.Show("Please Give Name");
            }
        }

        private void otherthings_saveCompany_btn_Click(object sender, EventArgs e)
        {
            TableCompany names = new TableCompany();
            String companyName = otherthings_CompanyName_text.Text;
            if (companyName != "")
            {
                names.companyName = companyName;
                int id = handleProduct.addCompanyName(names);
                if (id >= 0)
                {
                    MessageBox.Show("One Company Name Insert");

                }
                else
                {
                    MessageBox.Show("Due to Any  issue Company Name Not Save");
                }
            }
            else
            {
                MessageBox.Show("Please Give Name");
            }
        }

        private void otherthings_saveDesc_btn_Click(object sender, EventArgs e)
        {
            TableDescription names = new TableDescription();
            String DescriptionName = otherthings_DescreptionNAme_text.Text;

            if (DescriptionName != "")
            {
                names.descriptionName = DescriptionName;
                Debug.WriteLine("Description is : "+names.descriptionName);
                int id = handleProduct.addDescriptionName(names);
                   if (id >= 0)
                   {
                       MessageBox.Show("One Description Insert");

                   }
                   else
                   {
                       MessageBox.Show("Due to Any  issue Description Name Not Save");
                   }
               }
               else
               {
                   MessageBox.Show("Please Give Name");
               
            }
        }
        

        private void otherthings_savePurpose_btn_Click(object sender, EventArgs e)
        {
            TablePurpose names = new TablePurpose();
            String purposeName = otherthings_PurposeNAme_text.Text;

            if (purposeName != "")
            {
                names.purposeName = purposeName;
                Debug.WriteLine("Description is : " + names.purposeName);
                int id = handleProduct.addPurposeName(names);
                if (id >= 0)
                {
                    MessageBox.Show("One Purpose Insert");

                }
                else
                {
                    MessageBox.Show("Due to Any  issue Purpose Name Not Save");
                }
            }
            else
            {
                MessageBox.Show("Please Give Name");

            }

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void otherthings_saveUnit_btn_Click(object sender, EventArgs e)
        {
            TableUnits names = new TableUnits();
            String unitName = otherthings_UnitName_text.Text;

            if (unitName != "")
            {
                names.unitsName = unitName;
                Debug.WriteLine("Description is : " + names.unitsName);
                int id = handleProduct.addUnitsName(names);
                if (id >= 0)
                {
                    MessageBox.Show("One Units Insert");

                }
                else
                {
                    MessageBox.Show("Due to Any  issue Units Name Not Save");
                }
            }
            else
            {
                MessageBox.Show("Please Give Name");

            }
        }

        private void otherthings_saveLocation_btn_Click(object sender, EventArgs e)
        {
            TableLocation names = new TableLocation();
            String locationName = otherthings_Location_text.Text;

            if (locationName != "")
            {
                names.locationName = locationName;
                Debug.WriteLine("Description is : " + names.locationName);
                int id = handleProduct.addLocationName(names);
                if (id >= 0)
                {
                    MessageBox.Show("One Location Insert");

                }
                else
                {
                    MessageBox.Show("Due to Any  issue Location Name Not Save");
                }
            }
            else
            {
                MessageBox.Show("Please Give Name");

            }
        }

        private void otherthings_saveDistrubutors_btn_Click(object sender, EventArgs e)
        {

            TableDistributors names = new TableDistributors();
            String distributorName = otherthings_DistributorsName_text.Text;

            if (distributorName != "")
            {
                names.distributorsName = distributorName;
                Debug.WriteLine("Description is : " + names.distributorsName);
                int id = handleProduct.addDistributorsName(names);
                if (id >= 0)
                {
                    MessageBox.Show("One Distributor Name Insert");

                }
                else
                {
                    MessageBox.Show("Due to Any  issue Distributor Name Not Save");
                }
            }
            else
            {
                MessageBox.Show("Please Give Name");

            }
        }
    }
}
