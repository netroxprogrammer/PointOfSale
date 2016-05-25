using PointOfSale.Utils;
using PointOfSale.Utils.CutomerData;
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
    class HandleCustomer
    {
        /*
        *   Add Information in Customer Basic Table
        */
        public int addCustomerBasicInformation(String customerName, int customerDiscount, String priceType)
        {
            Debug.WriteLine("Add Customer Data");

            ArrayList list = new ArrayList();
            String sql = "insert into customerBasic(customerName, customerDiscount, customerPaymentMethod) output INSERTED.customerId values(@customername,@customerDiscount,@customerPrice)";

             SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());

            commands.CommandType = CommandType.Text;
            commands.Parameters.AddWithValue("@customername",customerName);
            commands.Parameters.AddWithValue("@customerDiscount", customerDiscount);
            commands.Parameters.AddWithValue("@customerPrice",priceType);

            int id = (int)commands.ExecuteScalar();


            Debug.WriteLine("Database Entry number "+id);
            return id;
        }
        /*
        *    Add Information in Customer Information Table
        */
        public void addCustomerInformation(CustomerInfomation customer)
        {
            Debug.WriteLine("Add Customer Data");

            ArrayList list = new ArrayList();
            String sql = "insert into customerInformation(customerId, customerPersonContact, customerReffered,customerphone1 " +
                ",customerphone2, customerphone3,customerFax,customerFax1,customerFax2,customerEmail,customerAddress,customerRemark"+
                ",customerDefault, customerInactive)" +
                "output INSERTED.customerInformationId values(@customerid,@customerPersonContact,@customerReffered,@customerphone1"+
                ",@customerphone2,@customerphone3,@customerFax,@customerFax1,@customerFax2,@customerEmail,@customerAddress,@customerRemark"+
                ",@customerDefault,@customerInactive)";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());
            Debug.WriteLine("addCustomerInformation Database " + customer.CustomerId);
            Debug.WriteLine("addCustomerInformation Database " + customer.CustomerPersonContact);
            Debug.WriteLine("addCustomerInformation Database " + customer.CustomerReffered);
            Debug.WriteLine("addCustomerInformation Database " + customer.CustomerPhone1);
            Debug.WriteLine("addCustomerInformation Database " + customer.CustomerPhone2);

            Debug.WriteLine("addCustomerInformation Database " + customer.CustomerPhone3);
            Debug.WriteLine("addCustomerInformation Database " + customer.CustomerFax);
            Debug.WriteLine("addCustomerInformation Database " + customer.CustomerFax1);
            Debug.WriteLine("addCustomerInformation Database " + customer.CustomerFax2);
            Debug.WriteLine("addCustomerInformation Database " + customer.CustomerEmail);
            Debug.WriteLine("addCustomerInformation Database " + customer.CustomerAddress);
            Debug.WriteLine("addCustomerInformation Database " + customer.CustomerRemark);
            Debug.WriteLine("addCustomerInformation Database " + customer.CustomerDefault);



            commands.CommandType = CommandType.Text;
            commands.Parameters.AddWithValue("@customerid", customer.CustomerId);
            Debug.WriteLine("addCustomerInformation Database " +customer.CustomerId);
            commands.Parameters.AddWithValue("@customerPersonContact", customer.CustomerPersonContact);
            commands.Parameters.AddWithValue("@customerReffered", customer.CustomerReffered);
            commands.Parameters.AddWithValue("@customerphone1", customer.CustomerPhone1);
            commands.Parameters.AddWithValue("@customerphone2", customer.CustomerPhone2);
            commands.Parameters.AddWithValue("@customerphone3", customer.CustomerPhone3);
            commands.Parameters.AddWithValue("@customerFax", customer.CustomerFax);
            commands.Parameters.AddWithValue("@customerFax1", customer.CustomerFax1);
            commands.Parameters.AddWithValue("@customerFax2", customer.CustomerFax2);
            commands.Parameters.AddWithValue("@customerEmail", customer.CustomerEmail);
            commands.Parameters.AddWithValue("@customerAddress", customer.CustomerAddress);
            commands.Parameters.AddWithValue("@customerRemark", customer.CustomerRemark);
            commands.Parameters.AddWithValue("@customerDefault", customer.CustomerDefault);
            commands.Parameters.AddWithValue("@customerInactive", customer.CustomerInactive);
            int id = (int)commands.ExecuteScalar();


            Debug.WriteLine("addCustomerInformation Database Entry number " + id);

        }
        /*
        *    Get All Information About Customers 
        */

        public ArrayList getCustomers()
        {

            Debug.WriteLine("get Customers");

            ArrayList lists = new ArrayList();


            String sql = "SELECT customerBasic.customerId, customerBasic.customerName, customerBasic.customerDiscount, customerBasic.customerPaymentMethod,"+
                   "customerInformation.customerPersonContact,customerInformation.customerReffered,customerInformation.customerphone1,"+
                    "customerInformation.customerphone2, customerInformation.customerphone3, customerInformation.customerFax,"+
                    "customerInformation.customerFax, customerInformation.customerFax1, customerInformation.customerFax2, customerInformation.customerEmail,"+
                    "customerInformation.customerAddress, customerInformation.customerRemark,customerInformation.customerDefault,customerInformation.customerInactive from[customerBasic]" +
                    "INNER JOIN[customerInformation] ON customerBasic.customerId = customerInformation.customerId";
            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                TotalCustomerClass customers = new TotalCustomerClass();
               
                customers.customerId = reader.GetInt32(0);
                customers.customerName = reader.GetString(1);
                customers.CustomerDiscount = Int32.Parse(reader.GetString(2));
                Debug.WriteLine("Discount=== " + reader[4].ToString());

                customers.customerPrice = reader.GetString(3);
                customers.Date = System.Convert.ToString(reader[4].ToString());
                customers.CustomerPersonContact = reader.GetString(4);
                customers.CustomerReffered = reader.GetString(5);


                customers.CustomerPhone1 = reader.GetString(6);
                customers.CustomerPhone2 = reader.GetString(7);
                customers.CustomerPhone3 = reader.GetString(8);
                customers.CustomerFax = reader.GetString(9);
                customers.CustomerFax1 = reader.GetString(10);
                customers.CustomerFax2 = reader.GetString(11);
                customers.CustomerEmail = reader.GetString(12);
                customers.CustomerAddress = reader.GetString(13);
                customers.CustomerRemark = reader.GetString(14);
                customers.CustomerDefault = reader.GetString(15);
                customers.CustomerInactive = reader.GetString(16);
                lists.Add(customers);
               

            }
            reader.Close();
            return lists;
        }

        /*
        get Customebasic Columns
        */

        public List<TableColumns> getCustomerBasicColums()
        {
            List<TableColumns> listTable = new List<TableColumns>();

            SqlCommand commands = new SqlCommand("SELECT name FROM sys.columns WHERE object_id = OBJECT_ID('customerBasic')", DatabaseConnections.Instance.getConnection());

            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                TableColumns tbclm = new TableColumns();
                tbclm.TableName = reader.GetString(0);
                //tbclm.DataType = reader.GetString(7)
                listTable.Add(tbclm);
                Debug.WriteLine("Customer Columns List === "+reader.GetString(0));
            }

            return listTable;
        }


        /*
        get Customer  Information Columns
        */

        public List<TableColumns> getCustomerInformationColums()
        {
            List<TableColumns> listTable = new List<TableColumns>();

            SqlCommand commands = new SqlCommand("SELECT name FROM sys.columns WHERE object_id = OBJECT_ID('customerInformation')", DatabaseConnections.Instance.getConnection());

            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                TableColumns tbclm = new TableColumns();
                tbclm.TableName = reader.GetString(0);
                //tbclm.DataType = reader.GetString(7)
                listTable.Add(tbclm);
                Debug.WriteLine("Customer Columns List === " + reader.GetString(0));
            }

            return listTable;
        }

    }
}
