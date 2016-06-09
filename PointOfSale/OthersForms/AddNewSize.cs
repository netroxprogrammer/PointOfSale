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
    public partial class AddNewSize : Form
    {
        public AddNewSize()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            HandleProducts handleProduct = new HandleProducts();
            TableUnits names = new TableUnits();
           String unitName = unitNAme.Text;

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
    }
}
