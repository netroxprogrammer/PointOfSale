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
    public partial class AddProductName : Form
    {
        public AddProductName()
        {
            InitializeComponent();
        }

        private void addProduct_Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
