using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Utils
{
    class TablePurpose
    {
        private int _purposeId;
        private String _purposeName;
        public int purposeId
        {
            get
            {
                return this._purposeId;

            }
            set
            {
                this._purposeId = value;
            }
        }
        public String purposeName
        {
            get
            {
                return this._purposeName;
            }
            set
            {
                this._purposeName = value;
            }
        }
    }
}
