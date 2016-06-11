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

    }
}
