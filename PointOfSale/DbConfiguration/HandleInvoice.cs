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
    class HandleInvoice
    {
        public int getInvoiceNumber()
        {
          

            Debug.WriteLine("get getInvoiceNumber");
            int invoiceNumber = 0;

            String sql = "select invoiceId from saleinvoice";
            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {

                invoiceNumber = reader.GetInt32(0);
                Debug.WriteLine(invoiceNumber + "Numberrrr");
            }
            
            reader.Close();
            return invoiceNumber;

        }
        //  add SaleoInvoice
        public int AddSaleoInvoice(TableInvoice names)
        {

            Debug.WriteLine("Add AddSaleoInvoice Data");


            String sql = " insert into saleinvoice(employeName ,CustomerName , invoiceDate,"+
                        "totalAmount ,TotalNetAmount,paymentMethod,TotalDiscount,"+
                       " totalpaymment,balance,writeDescription,loginby) output INSERTED.invoiceId " +
                        "values (@employeName, @CustomerName, @invoiceDate,"+
                        "@totalAmount, @TotalNetAmount, @paymentMethod, @TotalDiscount,"+
                        "@totalpaymment, @balance, @writeDescription, @loginby)";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());

            commands.CommandType = CommandType.Text;
            commands.Parameters.AddWithValue("@employeName", names.EmployeeName);
            commands.Parameters.AddWithValue("@CustomerName", names.CustomerName);
            commands.Parameters.AddWithValue("@invoiceDate", names.CurrentDate);
          
            commands.Parameters.AddWithValue("@totalAmount", names.TotalAmount);
            commands.Parameters.AddWithValue("@TotalNetAmount", names.TotalNetAmount);
            commands.Parameters.AddWithValue("@paymentMethod", names.PaymentMethod);
            commands.Parameters.AddWithValue("@TotalDiscount", names.TotalDiscount);
            commands.Parameters.AddWithValue("@totalpaymment", names.TotalPayment);
            commands.Parameters.AddWithValue("@balance", names.Balance);
            commands.Parameters.AddWithValue("@writeDescription", names.Disception1);
            
            commands.Parameters.AddWithValue("@loginby", names.LoginBy);
            int id = (int)commands.ExecuteScalar();


            Debug.WriteLine("Database Entry number " + id);
            return id;

        }
        //  read InvoiceData
        public ArrayList readInvoiceData()
        {
            Debug.WriteLine("get readInvoiceData");

            ArrayList list = new ArrayList();

            String sql = "Select * from saleinvoice  where CONVERT(varchar(10),invoiceDate,105) =  CONVERT(varchar(10),GETDATE(),	105)";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());
            commands.CommandType = CommandType.Text;

          
            TableInvoice invlice = null;
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                invlice = new TableInvoice();
                invlice.InvoiceId = reader.GetInt32(0);
                invlice.CurrentDate = reader.GetDateTime(3);
                invlice.PaymentMethod = reader.GetString(6);

                 invlice.TotalDiscount = reader.GetInt32(7);
                // Debug.WriteLine("Discount=== " + reader[4].ToString());

                invlice.TotalNetAmount = reader.GetInt32(5);

                invlice.TotalPayment = reader.GetInt32(8);
                invlice.Balance= reader.GetInt32(9);
                invlice.Description1 = reader.GetString(10);

                list.Add(invlice);
                Debug.WriteLine(invlice);

            }
            reader.Close();
            return list;

        }

        //  read InvoiceData
        public ArrayList filerInvoiceData(TableInvoice names)
        {
            Debug.WriteLine("get filerInvoiceData");

            ArrayList list = new ArrayList();
            
            String sql = "Select * from saleinvoice where paymentMethod = @paymentMethod OR  CustomerName = @CustomerName OR employeName= @employeName ";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());
            commands.CommandType = CommandType.Text;
            commands.Parameters.AddWithValue("@paymentMethod", names.PaymentMethod);
            commands.Parameters.AddWithValue("@CustomerName", names.CustomerName);
            commands.Parameters.AddWithValue("@employeName", names.CustomerName);
           
            TableInvoice invlice = null;
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                invlice = new TableInvoice();
                invlice.InvoiceId = reader.GetInt32(0);
                invlice.CurrentDate = reader.GetDateTime(3);
                invlice.PaymentMethod = reader.GetString(6);

                invlice.TotalDiscount = reader.GetInt32(7);
                // Debug.WriteLine("Discount=== " + reader[4].ToString());

                invlice.TotalNetAmount = reader.GetInt32(5);

                invlice.TotalPayment = reader.GetInt32(8);
                invlice.Balance = reader.GetInt32(9);
                invlice.Description1 = reader.GetString(10);

                list.Add(invlice);
                Debug.WriteLine(invlice);

            }
            reader.Close();
            return list;

        }

        // Update Invoice Data
        public void UpdateInvoiceBalancea(TableInvoice names)
        {
            Debug.WriteLine("get filerInvoiceData");

            ArrayList list = new ArrayList();

            String sql = " Update saleinvoice set paymentMethod = @paymentMethod, totalpaymment = @totalpaymment ,balance = @balance where invoiceId = @invoiceId";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());
            commands.CommandType = CommandType.Text;
            commands.Parameters.AddWithValue("@paymentMethod", names.PaymentMethod);
            commands.Parameters.AddWithValue("@totalpaymment", names.TotalPayment);
            commands.Parameters.AddWithValue("@balance", names.Balance);
            commands.Parameters.AddWithValue("@invoiceId", names.InvoiceId);


            commands.ExecuteNonQuery();


            Debug.WriteLine("Update invoice balance");

        }
        //  read InvoiceData  for Crystal Report
        public TableInvoice filerInvoiceCrystalReport(TableInvoice names)
        {
            Debug.WriteLine("get filerInvoiceDataCrystalReport");

            ArrayList list = new ArrayList();

            String sql = "Select * from saleinvoice where invoiceId = @invoiceId";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());
            commands.CommandType = CommandType.Text;
            commands.Parameters.AddWithValue("@invoiceId", names.InvoiceId);
      

            TableInvoice invlice = null;
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                invlice = new TableInvoice();
                invlice.InvoiceId = reader.GetInt32(0);
                invlice.CurrentDate = reader.GetDateTime(3);
                invlice.PaymentMethod = reader.GetString(6);

                invlice.TotalDiscount = reader.GetInt32(7);
                // Debug.WriteLine("Discount=== " + reader[4].ToString());

                invlice.TotalNetAmount = reader.GetInt32(5);

                invlice.TotalPayment = reader.GetInt32(8);
                invlice.Balance = reader.GetInt32(9);
                invlice.Description1 = reader.GetString(10);

               // list.Add(invlice);
                Debug.WriteLine(invlice);

            }
            reader.Close();
            return invlice;

        }


        public void addInvoiceData(TableInvoiceData names)
        {

            Debug.WriteLine("Add AddSaleoInvoice Data");


            String sql = "insert into InvoiceData (invoiceId,productListNumber,productName,location," +
                         "purpose,Expirydate,salePrice,Qty,Amount,discount,netamount) " +
                          "values (@invoiceId, @productListNumber, @productName, @location," +
                         "@purpose, @Expirydate, @salePrice, @Qty, @Amount, @discount, @netamount)";

               SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());
            Debug.WriteLine("invoice list == " + names.InvoiceId);
            Debug.WriteLine("invoice list == " + names.ProductListNumber);
            Debug.WriteLine("invoice list == " + names.ProductName);
            Debug.WriteLine("invoice list == " + names.ProductName);
            Debug.WriteLine("invoice list == " + names.Location);
            Debug.WriteLine("invoice list == " + names.Purpose);
            Debug.WriteLine("invoice list == " + names.ExpiryDate1);
            commands.CommandType = CommandType.Text;
            commands.Parameters.AddWithValue("@invoiceId", names.InvoiceId);
            commands.Parameters.AddWithValue("@productListNumber", names.ProductListNumber);
            commands.Parameters.AddWithValue("@productName", names.ProductName);

            commands.Parameters.AddWithValue("@location", names.Location);
            commands.Parameters.AddWithValue("@purpose", names.Purpose);
            commands.Parameters.AddWithValue("@Expirydate", names.ExpiryDate1);
            commands.Parameters.AddWithValue("@salePrice", names.SalePrice);
            commands.Parameters.AddWithValue("@Qty", names.Qty1);
            commands.Parameters.AddWithValue("@Amount", names.Amount1);
            commands.Parameters.AddWithValue("@discount", names.Discount);

            commands.Parameters.AddWithValue("@netamount", names.NetAmount);
            commands.ExecuteScalar();


           //Debug.WriteLine("Database Entry number " + id);
           // return 1;

        }
        /*
             Search By Date
        */

        public ArrayList filerByDate(TableInvoice names)
        {
            Debug.WriteLine("get filerInvoiceData");

            ArrayList list = new ArrayList();

            String sql = "Select * from saleinvoice where paymentMethod = @paymentMethod OR  CustomerName = @CustomerName OR employeName= @employeName AND invoiceDate > @FromDate1 AND invoiceDate < @ToDate1 ";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());
            commands.CommandType = CommandType.Text;
            commands.Parameters.AddWithValue("@paymentMethod", names.PaymentMethod);
            commands.Parameters.AddWithValue("@CustomerName", names.CustomerName);
            commands.Parameters.AddWithValue("@employeName", names.CustomerName);
            commands.Parameters.AddWithValue("@FromDate1", names.FromDate1);
            commands.Parameters.AddWithValue("@ToDate1", names.ToDate1);
            TableInvoice invlice = null;
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                invlice = new TableInvoice();
                invlice.InvoiceId = reader.GetInt32(0);
                invlice.CurrentDate = reader.GetDateTime(3);
                invlice.PaymentMethod = reader.GetString(6);

                invlice.TotalDiscount = reader.GetInt32(7);
                // Debug.WriteLine("Discount=== " + reader[4].ToString());

                invlice.TotalNetAmount = reader.GetInt32(5);

                invlice.TotalPayment = reader.GetInt32(8);
                invlice.Balance = reader.GetInt32(9);
                invlice.Description1 = reader.GetString(10);

                list.Add(invlice);
                Debug.WriteLine(invlice);

            }
            reader.Close();
            return list;

        }

    }
}
