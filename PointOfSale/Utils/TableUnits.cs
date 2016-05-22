using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Utils
{
    class TableUnits
    {
        private int _unitsId;
        private String _unitsName;

        public int unitsId
        {
            get
            {
                return  this._unitsId;
            }
            set
            {
                this._unitsId = value;
            }
        }
        public String unitsName
        {
            get
            {
                return this._unitsName;

            }
            set
            {
                this._unitsName = value;
            }
        }
    }
}
