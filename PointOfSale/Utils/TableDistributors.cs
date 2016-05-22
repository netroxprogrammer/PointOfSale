using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Utils
{
    class TableDistributors
    {
        private int _distributorsId;
        private String _distributorsName;

        public int distributorsId
        {
            get
            {
                return this._distributorsId;
            }
            set
            {
                this._distributorsId = value;
            }
        }
        public String distributorsName
        {
            get
            {
                return this._distributorsName;
            }
            set
            {
                this._distributorsName = value;
            }
        }
    }
}
