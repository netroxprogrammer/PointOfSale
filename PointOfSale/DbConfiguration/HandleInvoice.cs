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

            String sql = "select  count(invoiceId) from saleinvoice";
            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {

                invoiceNumber = reader.GetInt32(0);
              
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

            String sql = "Select * from saleinvoice";

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

            String sql = "Select * from saleinvoice where paymentMethod = @paymentMethod OR  CustomerName = @CustomerName OR employeName= @employeName";

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
    }
}
