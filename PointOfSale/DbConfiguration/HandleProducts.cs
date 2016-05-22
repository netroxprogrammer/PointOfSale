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

        /**
        Add Categoire Names
        */
        public int addCategoryName(TableCategory names)
        {

            Debug.WriteLine("Add addCategoryName Data");
            
            String sql = "insert into Categories(categoryName) output INSERTED.categoryId" +
                " values(@categoryName)";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());

            commands.CommandType = CommandType.Text;
            commands.Parameters.AddWithValue("@categoryName", names.cagtegoryName);
     
            int id = (int)commands.ExecuteScalar();


            Debug.WriteLine("addProductNames Database Entry number " + id);
            return id;

        }
        /*
        Add Company 
        */
        public int addCompanyName(TableCompany names)
        {

            Debug.WriteLine("Add addCategoryName Data");

            String sql = "insert into companyName(companyName) output INSERTED.companyId" +
                " values(@companyName)";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());

            commands.CommandType = CommandType.Text;
            commands.Parameters.AddWithValue("@companyName", names.companyName);

            int id = (int)commands.ExecuteScalar();


            Debug.WriteLine("addProductNames Database Entry number " + id);
            return id;

        }
        /*
       Add Description
       */
        public int addDescriptionName(TableDescription names)
        {

            Debug.WriteLine("Add addDescriptionName Data");

            String sql = "insert into Description(descriptionName) output INSERTED.descriptionId" +
                " values(@descriptionName)";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());

            commands.CommandType = CommandType.Text;
            commands.Parameters.AddWithValue("@descriptionName", names.descriptionName);

            int id = (int)commands.ExecuteScalar();


            Debug.WriteLine("addProductNames Database Entry number " + id);
            return id;

        }

        /*
      Add Purpose
      */
        public int addPurposeName(TablePurpose names)
        {

            Debug.WriteLine("Add addPurposeName Data");

            String sql = "insert into purpose(purposeName) output INSERTED.purposeId" +
                " values(@purposeName)";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());

            commands.CommandType = CommandType.Text;
            commands.Parameters.AddWithValue("@purposeName", names.purposeName);

            int id = (int)commands.ExecuteScalar();


            Debug.WriteLine("addPurposeName Database Entry number " + id);
            return id;

        }
        /*
    Add Units
    */
        public int addUnitsName(TableUnits names)
        {

            Debug.WriteLine("Add addUnitsName Data");

            String sql = "insert into units(unitsName) output INSERTED.unitsId" +
                " values(@unitsName)";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());

            commands.CommandType = CommandType.Text;
            commands.Parameters.AddWithValue("@unitsName", names.unitsName);

            int id = (int)commands.ExecuteScalar();


            Debug.WriteLine("addUnitsName Database Entry number " + id);
            return id;

        }
    }
}
