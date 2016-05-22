using PointOfSale.Utils;
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
    class HandleProducts
    {
        /*
        *   get Categorirs from table
        */
        public ArrayList getCategory()
        {

            Debug.WriteLine("get Categories");

            ArrayList list = new ArrayList();



            SqlCommand commands = new SqlCommand("Select  *from Categories", DatabaseConnections.Instance.getConnection());
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                TableCategory category = new TableCategory();
                category.categoryId = reader.GetInt32(0);
                category.cagtegoryName = reader.GetString(1);
                list.Add(category);
                Debug.WriteLine(category);

            }
            reader.Close();
            return list;
        }

        /*
        *      get Company Name from Table
        */
        public ArrayList getCompanyNames()
        {

            Debug.WriteLine("get companyName");

            ArrayList list = new ArrayList();



            SqlCommand commands = new SqlCommand("Select  *from companyName", DatabaseConnections.Instance.getConnection());
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                TableCompany company = new TableCompany();
                company.companyId = reader.GetInt32(0);
                company.companyName = reader.GetString(1);
                list.Add(company);
                Debug.WriteLine(company);

            }
            reader.Close();
            return list;
        }
        /*
       *      get Product Name from Table
       */
        public ArrayList getProductNames()
        {

            Debug.WriteLine("get ProductName");

            ArrayList list = new ArrayList();



            SqlCommand commands = new SqlCommand("Select  *from productName", DatabaseConnections.Instance.getConnection());
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                TableProductName productName = new TableProductName();
                productName.productId = reader.GetInt32(0);
                productName.productName = reader.GetString(1);
                list.Add(productName);
                Debug.WriteLine(productName);

            }
            reader.Close();
            return list;
        }


        /**
        Add Product Names and  Dicounts
        */
        public int addProductName(TableProductName names)
        {

            Debug.WriteLine("Add Customer Data");

            ArrayList list = new ArrayList();
            String sql = "insert into addProductNames( productNames, productMaxDiscount) output INSERTED.productNameId"+
                " values(@productNames,@productMaxDiscount)";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());

            commands.CommandType = CommandType.Text;
            commands.Parameters.AddWithValue("@productNames", names.productName);
            commands.Parameters.AddWithValue("@productMaxDiscount", names.productMaxDiscount);
           

            int id = (int)commands.ExecuteScalar();


            Debug.WriteLine("addProductNames Database Entry number " + id);
            return id;

        }

    }
}
