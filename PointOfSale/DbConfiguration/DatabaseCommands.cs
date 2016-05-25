using PointOfSale.Utils;
using System;
using System.Collections;
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
        /**

            Login User
        **/
        public bool Login(String userName, String Password)
        {
            bool check = false;
            SqlCommand commands = new SqlCommand("Select  *from users where userName= @name AND userPassword=@pass", DatabaseConnections.Instance.getConnection());
            commands.Parameters.AddWithValue("@name", userName);

            commands.Parameters.AddWithValue("@pass", Password);
            SqlDataReader reader = commands.ExecuteReader();
            if (reader.Read())

            {
                Debug.WriteLine(reader.GetString(1));
                check = true;
                return check;
            }
           
           // reader.Close();
           
            return check;
        }

        /*
        Read Users
        */

        public ArrayList readUsers()

        {
            Debug.WriteLine("Read Users Function call");

            ArrayList list = new ArrayList();


          
            SqlCommand commands = new SqlCommand("Select  *from users", DatabaseConnections.Instance.getConnection());
            SqlDataReader reader = commands.ExecuteReader();
            if (reader.Read())

            {
                list.Add(reader.GetString(1));
                Debug.WriteLine(reader.GetString(1));
             
            }
            reader.Close();
            return list;
        }

        /**
         Check User ALready Login
        */

        public bool CheckUserAlreadyLogin(String Check,String userName)
        {
            bool check = false;
            String query = "UPDATE users SET userLogin = @check Where userName = @name";
            SqlCommand commands = new SqlCommand("", DatabaseConnections.Instance.getConnection());

            commands.Parameters.AddWithValue("@check", check);
            commands.Parameters.AddWithValue("@name", userName);

            SqlDataReader reader = commands.ExecuteReader();
            if (reader.Read())

            {
                Debug.WriteLine(reader.GetString(1));
                check = true;
                return check;
            }

             reader.Close();

            return check;
        }

        /*
        *
        *    View Table Lists
        *
        */

        public ArrayList getTableLists()
        {
            ArrayList listTable = new ArrayList();
            SqlCommand commands = new SqlCommand("SELECT * FROM information_schema.tables", DatabaseConnections.Instance.getConnection());

            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                listTable.Add(reader.GetString(2));
                Debug.WriteLine(reader.GetString(2));
            }
            return listTable; 
        }

        /*
        *
        *       Read Column Name from tables
        *
        */


        public List<TableColumns> readTableColumn(String tableName)
        {
            List<TableColumns> listTable = new List<TableColumns>();
         
            SqlCommand commands = new SqlCommand("SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tableName +"' ", DatabaseConnections.Instance.getConnection());

            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                TableColumns tbclm = new TableColumns();
                tbclm.TableName = reader.GetString(3);
                tbclm.DataType = reader.GetString(7);
                listTable.Add(tbclm);
                Debug.WriteLine(reader.GetString(3));
            }
            
            return listTable;
        }
    }

    

}
