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
           // reader.Close();
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

            // reader.Close();

            return check;
        }


    }



}
