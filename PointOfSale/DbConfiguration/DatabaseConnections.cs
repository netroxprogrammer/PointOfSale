using PointOfSale.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.DbConfiguration
{
    class DatabaseConnections
    {
        // Setting  for Singleton Class
        public SqlConnection connection;
        private static DatabaseConnections instance = null;
        private static readonly Object padlock = new object();
       
        DatabaseConnections()
        {
            Constants c = new Constants();
            Debug.WriteLine("-----------------------"+System.Environment.MachineName.ToLower());
            connection = new SqlConnection(c.serverUrl + Constants.databaseName + Constants.securityCheck);
        }

        public static DatabaseConnections Instance
        {
            get
            {
                //lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DatabaseConnections();
                    }
                    return instance;
                }
            }
        }


        /*
      #Create Database Connection
   */

        public SqlConnection getConnection()
        {

            try
            {
                connection.Open();
                Debug.WriteLine("Connection  ok");
            }
            catch
            {
                Debug.WriteLine("Sorry Database Connection Fail");
            }
            return connection;
        }
    }


}

