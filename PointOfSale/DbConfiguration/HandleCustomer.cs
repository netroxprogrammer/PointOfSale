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
        *    Add Information in Customer Information Table
        */

    }
}
