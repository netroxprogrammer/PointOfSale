using System;
using System.Collections.Generic;
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



    }
}
