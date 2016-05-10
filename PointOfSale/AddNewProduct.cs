using System;
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
        public AddNewProduct()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddNewProduct_Load(object sender, EventArgs e)
        {
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
    }
}

