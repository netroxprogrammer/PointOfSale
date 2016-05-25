using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Utils.TablesClass
{
    class TotalEmployeeData
    {

        private int _employeeEmerganceyId;
        private int _employeeId;
        private String _name;
        private String _relation;
        private String _contact;
        private String _location;
        private String _employeeName;
        private String _employeePhone;
        private String _employeeFatherName;
        private String _employeeCNIC;
        private String _employeeAddress;
        private String _employeeLocation;

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

        public string EmployeePhone
        {
            get
            {
                return _employeePhone;
            }

            set
            {
                _employeePhone = value;
            }
        }

        public string EmployeeFatherName
        {
            get
            {
                return _employeeFatherName;
            }

            set
            {
                _employeeFatherName = value;
            }
        }

        public string EmployeeCNIC
        {
            get
            {
                return _employeeCNIC;
            }

            set
            {
                _employeeCNIC = value;
            }
        }

        public string EmployeeAddress
        {
            get
            {
                return _employeeAddress;
            }

            set
            {
                _employeeAddress = value;
            }
        }

        public string EmployeeLocation
        {
            get
            {
                return _employeeLocation;
            }

            set
            {
                _employeeLocation = value;
            }
        }

        public string EmployeeName
        {
            get
            {
                return _employeeName;
            }

            set
            {
                _employeeName = value;
            }
        }
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
