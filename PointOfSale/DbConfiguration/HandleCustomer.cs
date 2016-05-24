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

        public  Tuple<ArrayList, ArrayList> getCustomers()
        {

            Debug.WriteLine("get Customers");

            ArrayList listbasic = new ArrayList();

            ArrayList listinformation = new ArrayList();

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
                CustomerBasic customerbasic = new CustomerBasic();
                CustomerInfomation customerInformations = new CustomerInfomation();
                customerbasic.customerId = reader.GetInt32(0);
                customerbasic.customerName = reader.GetString(1);
                customerbasic.CustomerDiscount = reader.GetInt32(2);
                customerbasic.customerPrice = reader.GetString(3);
                listbasic.Add(customerbasic);
                customerInformations.CustomerPersonContact = reader.GetString(4);
                customerInformations.CustomerReffered = reader.GetString(5);
                customerInformations.CustomerPhone1 = reader.GetString(6);
                customerInformations.CustomerPhone2 = reader.GetString(7);
                customerInformations.CustomerPhone3 = reader.GetString(8);
                customerInformations.CustomerFax = reader.GetString(9);
                customerInformations.CustomerFax1 = reader.GetString(10);
                customerInformations.CustomerFax2 = reader.GetString(11);
                customerInformations.CustomerEmail = reader.GetString(12);
                customerInformations.CustomerAddress = reader.GetString(13);
                customerInformations.CustomerRemark = reader.GetString(14);
                customerInformations.CustomerDefault = reader.GetString(15);
                customerInformations.CustomerInactive = reader.GetString(16);
                listinformation.Add(customerInformations);
                Debug.WriteLine(customerbasic);

            }
            reader.Close();
            return Tuple.Create(listbasic, listinformation);
        }
    }
}
