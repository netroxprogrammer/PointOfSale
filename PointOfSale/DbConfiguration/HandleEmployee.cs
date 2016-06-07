using PointOfSale.Utils.TablesClass;
using System;
using System.Collections;
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
/*
get all Employee Data
*/
        public ArrayList getEmployee()
        {

            Debug.WriteLine("get Employee");

            ArrayList lists = new ArrayList();


            String sql = "SELECT Employees.employeeId , employeeName, Employees.employeePhone, Employees.employeeFatherName, Employees.employeeCNIC,"+
                "Employees.employeeAddress, Employees.employeeLocation, EmployeeEmergency.name, EmployeeEmergency.relation,EmployeeEmergency.contact,"+
                 "EmployeeEmergency.location from[Employees]  INNER JOIN [EmployeeEmergency] ON Employees.employeeId = EmployeeEmergency.employeeId";
            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                TotalEmployeeData emplooye = new TotalEmployeeData();

                emplooye.EmployeeId = reader.GetInt32(0);
                emplooye.EmployeeName = reader.GetString(1);
                emplooye.EmployeePhone = reader.GetString(2);
                // Debug.WriteLine("Discount=== " + reader[4].ToString());

                emplooye.EmployeeFatherName = reader.GetString(3);
               
                emplooye.EmployeeCNIC = reader.GetString(4);
                emplooye.EmployeeAddress = reader.GetString(5);


                emplooye.EmployeeLocation = reader.GetString(6);
                emplooye.Name = reader.GetString(7);
                emplooye.Relation = reader.GetString(8);
                emplooye.Contact = reader.GetString(9);
                emplooye.Location = reader.GetString(10);
              
                lists.Add(emplooye);


            }
            reader.Close();
            return lists;
        }

        /*
      get  Basic Information of Employe   
    */
        public ArrayList getEmployeeBasic()
        {

            Debug.WriteLine("get Employee");

            ArrayList lists = new ArrayList();


            String sql = "select *from Employees";
            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                TotalEmployeeData emplooye = new TotalEmployeeData();

                emplooye.EmployeeId = reader.GetInt32(0);
                emplooye.EmployeeName = reader.GetString(1);
                emplooye.EmployeePhone = reader.GetString(2);
                // Debug.WriteLine("Discount=== " + reader[4].ToString());

                emplooye.EmployeeFatherName = reader.GetString(3);

                emplooye.EmployeeCNIC = reader.GetString(4);
                emplooye.EmployeeAddress = reader.GetString(5);
                emplooye.EmployeeLocation = reader.GetString(6);
          
                lists.Add(emplooye);


            }
            reader.Close();
            return lists;
        }
    }
}
