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
    public partial class AddDiscription : Form
    {
        public AddDiscription()
        {
            InitializeComponent();
        }

        private void AddDiscreption_Cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
