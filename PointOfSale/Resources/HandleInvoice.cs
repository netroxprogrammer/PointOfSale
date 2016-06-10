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

        public int getinvoiceNumber()
        {

            Debug.WriteLine("get Invoice Number");

            int invoiceNumber =0;


        String sql = "Select count(invoiceId) from saleinvoice";
        SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());
        SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                invoiceNumber = reader.GetInt32(0);
            }
           reader.Close();
            return invoiceNumber;
        }

        /* 
        Add New Invoice
        */
        public int AddNewInvoice(TableInvoice names)
        {

            Debug.WriteLine("Add AddNewInvoice Data");


            String sql = "INSERT INTO saleinvoice (invoiceDate,totalAmount,"+
                   " TotalNetAmount,paymentMethod,TotalDiscount,totalpaymment,balance,writeDescription) output INSERTED.invoiceId values(" +
                   " @invoiceDate, @totalAmount,"+
                   " @TotalNetAmount, @paymentMethod, @TotalDiscount, @totalpaymment, @balance, @writeDescription)";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());

            commands.CommandType = CommandType.Text;
            commands.Parameters.AddWithValue("@invoiceDate", names.CurrentDate);
            commands.Parameters.AddWithValue("@totalAmount", names.TotalAmount);
            commands.Parameters.AddWithValue("@paymentMethod", names.PaymentMethod);
            commands.Parameters.AddWithValue("@TotalDiscount", names.TotalDiscount);
            commands.Parameters.AddWithValue("@totalpaymment", names.TotalPayment);
            commands.Parameters.AddWithValue("@balance", names.Balance);
            commands.Parameters.AddWithValue("@writeDescription", names.Disception1);
            int id = (int)commands.ExecuteScalar();


            Debug.WriteLine("Database Entry number " + id);
            return id;

        }
    
    }
}
