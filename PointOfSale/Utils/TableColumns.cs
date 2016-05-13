using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Utils
{
    class TableColumns
    {
        private String _columnName;
        private String _datatype;
        public String TableName
        {
            get
            {
                return this._columnName;
            }
            set
            {
                this._columnName = value;
            }
        }
        public String DataType
        {
            get
            {
                return this._datatype;
            }
            set
            {
                this._datatype = value;
            }
        }

    }
}
