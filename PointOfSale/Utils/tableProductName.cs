using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Utils
{

  
    class TableProductName
    {
        private int _productId;
        private String _productName;

        public int productId
        {
            get
            {
                return this._productId;
            }
            set
            {
                this._productId = value;

            }
        }
        public String productName
        {
            get
            {
                return this._productName;
            }
            set
            {

                this._productName = value;
            }
        }

    }
}
