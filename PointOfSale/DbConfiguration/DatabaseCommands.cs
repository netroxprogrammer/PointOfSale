using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.DbConfiguration
{
    class DatabaseCommands
    {
        public bool Login(String userName, String Password)
        {
            bool check = false;
            SqlCommand commands = new SqlCommand("Select  *from users where userName= @name", DatabaseConnections.Instance.getConnection());
            commands.Parameters.AddWithValue("@name", userName);
            SqlDataReader reader = commands.ExecuteReader();
            if (reader.Read())

            {
                Debug.WriteLine(reader.GetString(1));
                check = true;
                return check;
            }
            return check;
        }
    }
}
