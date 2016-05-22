using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Utils.TablesClass
{
    class TableEmployeeEmergancey
    {
        private int _employeeEmerganceyId;
        private int _employeeId;
        private String _name;
        private String _relation;
        private String _contact;
        private String _location;

        public int EmployeeEmerganceyId
        {
            get
            {
                return _employeeEmerganceyId;
            }

            set
            {
                _employeeEmerganceyId = value;
            }
        }

        public int EmployeeId
        {
            get
            {
                return _employeeId;
            }

            set
            {
                _employeeId = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Relation
        {
            get
            {
                return _relation;
            }

            set
            {
                _relation = value;
            }
        }

        public string Contact
        {
            get
            {
                return _contact;
            }

            set
            {
                _contact = value;
            }
        }

        public string Location
        {
            get
            {
                return _location;
            }

            set
            {
                _location = value;
            }
        }
    }
}
