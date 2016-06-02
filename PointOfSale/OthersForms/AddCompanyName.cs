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
    public partial class AddCompanyName : Form
    {
        public AddCompanyName()
        {
            InitializeComponent();
        }

        private void AddCompanyName_Cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
