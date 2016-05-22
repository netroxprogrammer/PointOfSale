using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Utils
{
    class TableDescription
    {
        private int _descriptionId;
        private String _descriptionName;

        public int descriptionId
        {
            get
            {
                return this._descriptionId;
            }
            set
            {
                this._descriptionId = value;
            }
        }
        public String descriptionName
        {
            get
            {
                return this._descriptionName;
            }
            set
            {
                this._descriptionName = value;

            }
        }
    }
}
