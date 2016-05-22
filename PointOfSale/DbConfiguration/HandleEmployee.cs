using PointOfSale.Utils.TablesClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.DbConfiguration
{
    class HandleEmployee
    {
        /*
        Add Employee Informatoion
        */
        public int AddEmployees(TableEmployee names)
        {

            Debug.WriteLine("Add AddEmployees Data");

        
            String sql = "insert into Employees(employeeName, employeePhone, employeeFatherName,"+
                "employeeCNIC,employeeAddress,employeeLocation)" +
                "output INSERTED.employeeId values(@employeeName,@employeePhone,@employeeFatherName,"+
                "@employeeCNIC,@employeeAddress,@employeeLocation)";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());

            commands.CommandType = CommandType.Text;
            commands.Parameters.AddWithValue("@employeeName", names.EmployeeName);
            commands.Parameters.AddWithValue("@employeePhone", names.EmployeePhone);
            commands.Parameters.AddWithValue("@employeeFatherName", names.EmployeeFatherName);
            commands.Parameters.AddWithValue("@employeeCNIC", names.EmployeeCNIC);
            commands.Parameters.AddWithValue("@employeeAddress", names.EmployeeAddress);
            commands.Parameters.AddWithValue("@employeeLocation", names.EmployeeLocation);
           
            int id = (int)commands.ExecuteScalar();


            Debug.WriteLine("Database Entry number " + id);
            return id;

        }
        /*
                Add  Emergency Employee Informatoion
                */
        public int AddEmerganceEmployeeContact(TableEmployeeEmergancey names)
        {

            Debug.WriteLine("Add AddEmerganceEmployeeContact Data");


            String sql = "insert into EmployeeEmergency(employeeId, name, contact," +
                "relation,location)" +
                "output INSERTED.employeeEmergencyId values(@employeeId,@name,@contact," +
                "@relation,@location)";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());

            commands.CommandType = CommandType.Text;
            commands.Parameters.AddWithValue("@employeeId", names.EmployeeId);
            commands.Parameters.AddWithValue("@name", names.Name);
            commands.Parameters.AddWithValue("@contact", names.Contact);
            commands.Parameters.AddWithValue("@relation", names.Relation);
            commands.Parameters.AddWithValue("@location", names.Location);
           

            int id = (int)commands.ExecuteScalar();


            Debug.WriteLine("Database Entry number " + id);
            return id;

        }
    }
}
