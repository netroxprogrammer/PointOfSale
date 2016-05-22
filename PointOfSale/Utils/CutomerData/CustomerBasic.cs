using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Utils.CutomerData
{
    class CustomerBasic
    {
        int _customerId;
        String _customerName;
        String _customerPrice;
        public int customerId
        {
            get
            {
                return this._customerId;
            }
            set
            {
                this._customerId = value;
            }
        }

        public  String customerName
        {
            get
            {
                return this._customerName;
            }
            set
            {
                this._customerName = value;
            }
        }
        public String customerPrice
        {
            get
            {
                return this._customerPrice;
            }
            set {
                this._customerPrice = value;
            }
        }

    }
}
