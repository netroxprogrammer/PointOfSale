using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Utils
{
    class TableLocation
    {
        private int  _locationId;
        private String _locationName;
        
        public int locationId
        {
            get
            {
                return this._locationId;
            }
            set
            {
                this._locationId = value;
            }
        }

        public  String locationName
        {
            get
            {
                return this._locationName;
            }
            set
            {
                this._locationName = value;

            }
        }
    }
}
