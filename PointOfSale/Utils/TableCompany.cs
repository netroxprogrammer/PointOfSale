using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Utils
{
    class TableCompany
    {
        private int _companyId;
        private String _companyName;

        public int companyId
        {
            get
            {
                return this._companyId;
            }
            set
            {
                this._companyId = value;

            }
        }
        public String companyName
        {
            get
            {
                return this._companyName;
            }
            set
            {
                this._companyName = value;
            }
        }
    }
}
