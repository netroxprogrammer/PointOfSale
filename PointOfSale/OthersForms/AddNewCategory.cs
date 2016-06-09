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
    public partial class AddNewCategory : Form
    {
        public AddNewCategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandleProducts handleProduct = new HandleProducts();
            TableCategory names = new TableCategory();

            String categoryName =  AddNewCategory_name_tetxbox.Text;
            if (categoryName != "")
            {
                names.cagtegoryName = categoryName;
                int id = handleProduct.addCategoryName(names);
                if (id >= 0)
                {
                    MessageBox.Show("One Category Insert");

                }
                else
                {
                    MessageBox.Show("Due to Internal  issue Category Not Save");
                }
            }
            else
            {
                MessageBox.Show("Please Give Name");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
