﻿using PointOfSale.Utils;
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



            SqlCommand commands = new SqlCommand("Select  *from addProductNames", DatabaseConnections.Instance.getConnection());
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                TableProductName productName = new TableProductName();
                productName.productId = reader.GetInt32(0);
                productName.productName = reader.GetString(1);
                productName.productMaxDiscount = reader.GetInt32(2);
                list.Add(productName);
                Debug.WriteLine(productName);

            }
            reader.Close();
            return list;
        }


        /*
      *      get Descreption from Table
      */
        public ArrayList getDescreptions()
        {

            Debug.WriteLine("get Descreptions");

            ArrayList list = new ArrayList();



            SqlCommand commands = new SqlCommand("Select  *from Description", DatabaseConnections.Instance.getConnection());
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                TableDescription descriptionName = new TableDescription();
                descriptionName.descriptionId = reader.GetInt32(0);
                descriptionName.descriptionName = reader.GetString(1);
                
                list.Add(descriptionName);
                Debug.WriteLine(descriptionName);

            }
            reader.Close();
            return list;
        }

        /*
  *      get Location from Table
  */
        public ArrayList getProductLocationNames()
        {

            Debug.WriteLine("get getProductLocationNames");

            ArrayList list = new ArrayList();



            SqlCommand commands = new SqlCommand("Select  *from Location", DatabaseConnections.Instance.getConnection());
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                TableLocation locationName = new TableLocation();
                locationName.locationId = reader.GetInt32(0);
                locationName.locationName = reader.GetString(1);

                list.Add(locationName);
                Debug.WriteLine(locationName);

            }
            reader.Close();
            return list;
        }


        /*
*      get purpose from Table
*/
        public ArrayList getPurposeNames()
        {

            Debug.WriteLine("get PurposeNames");

            ArrayList list = new ArrayList();



            SqlCommand commands = new SqlCommand("Select  *from purpose", DatabaseConnections.Instance.getConnection());
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                TablePurpose purposeName = new TablePurpose();
                purposeName.purposeId = reader.GetInt32(0);
                purposeName.purposeName = reader.GetString(1);

                list.Add(purposeName);
                Debug.WriteLine(purposeName);

            }
            reader.Close();
            return list;
        }

        /*
*      get Units from Table
*/
        public ArrayList getUnitsNames()
        {

            Debug.WriteLine("get  Units Names");

            ArrayList list = new ArrayList();



            SqlCommand commands = new SqlCommand("Select  *from units", DatabaseConnections.Instance.getConnection());
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                TableUnits unitNames = new TableUnits();
                unitNames.unitsId = reader.GetInt32(0);
                unitNames.unitsName = reader.GetString(1);

                list.Add(unitNames);
                Debug.WriteLine(unitNames);

            }
            reader.Close();
            return list;
        }




        /*
      *      get Distributors from Table
      */
        public ArrayList getDistributors()
        {

            Debug.WriteLine("get Distributors");

            ArrayList list = new ArrayList();



            SqlCommand commands = new SqlCommand("Select  *from Distributors", DatabaseConnections.Instance.getConnection());
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                TableDistributors distributorsName = new TableDistributors();
                distributorsName.distributorsId = reader.GetInt32(0);
                distributorsName.distributorsName = reader.GetString(1);

                list.Add(distributorsName);
                Debug.WriteLine(distributorsName);

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

        /*
        Add Location
         */

        public int addLocationName(TableLocation names)
        {

            Debug.WriteLine("Add addLocationName Data");

            String sql = "insert into Location(locationName) output INSERTED.locationId" +
                " values(@locationName)";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());

            commands.CommandType = CommandType.Text;
            commands.Parameters.AddWithValue("@locationName", names.locationName);

            int id = (int)commands.ExecuteScalar();


            Debug.WriteLine("addLocationName Database Entry number " + id);
            return id;

        }

        /*
        Add DistributorsName
         */

        public int addDistributorsName(TableDistributors names)
        {

            Debug.WriteLine("Add DistributorsName Data");

            String sql = "insert into Distributors(distributorsName) output INSERTED.distributorsId" +
                " values(@distributorsName)";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());

            commands.CommandType = CommandType.Text;
            commands.Parameters.AddWithValue("@distributorsName", names.distributorsName);

            int id = (int)commands.ExecuteScalar();


            Debug.WriteLine("addDistributorsName Database Entry number " + id);
            return id;

        }
        /*
            get Distributors..
       */



     
            /*

        Add New Products....
        */
        public int addNewProducts(TableAddNewProducts names)
        {
            Debug.WriteLine("Add addNewProducts Data");

            String sql = "insert into addNewProducts(productBarCode,productName,productCompanyName,productPurpose" +
                " ,productDescription,productCategory,productLocation,productExpridate,productBatch,productColor1,productColor2,productColor3" +
                " ,productSize,productUnits,productQuantityPack,productQntHand,productTotalPack,productTotalPeice" +
                " ,productMinStock,productMaxStock,productSalePrice,ProductPurchasePrice,ProductProfit,ProductMaxDiscount,productTotalProfit,productItemDiscount" +
                " ,productDistributors,productUpdateStock,productInactive,updateDate, loginBy) output INSERTED.productId" +
                " values(@productBarCode,@productName,@productCompanyName,@productPurpose" +
                " ,@productDescription,@productCategory,@productLocation,@productExpridate,@productBatch,@productColor1,@productColor2,@productColor3" +
                " ,@productSize,@productUnits,@productQuantityPack,@productQntHand,@productTotalPack,@productTotalPeice" +
                " ,@productMinStock,@productMaxStock,@productSalePrice,@ProductPurchasePrice,@ProductProfit,@ProductMaxDiscount,@productTotalProfit,@productItemDiscount" +
                " ,@productDistributors,@productUpdateStock,@productInactive,@updateDate,@loginBy)";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());

            commands.CommandType = CommandType.Text;
            
            commands.Parameters.AddWithValue("@productBarCode", names.BarCode);
            commands.Parameters.AddWithValue("@productName", names.ProductName);
            commands.Parameters.AddWithValue("@productCompanyName", names.ProductCompanyName);
            commands.Parameters.AddWithValue("@productPurpose", names.ProductPurpose);
            commands.Parameters.AddWithValue("@productDescription", names.ProductDescription);

            commands.Parameters.AddWithValue("@productCategory", names.Category);
            commands.Parameters.AddWithValue("@productLocation", names.Location1);

            commands.Parameters.AddWithValue("@productExpridate", names.ProductExpidate);
            commands.Parameters.AddWithValue("@productBatch", names.ProductBatch);
            commands.Parameters.AddWithValue("@productColor1", names.ProductColor1);
            commands.Parameters.AddWithValue("@productColor2", names.ProductColor2);
            commands.Parameters.AddWithValue("@productColor3", names.ProductColor3);
            commands.Parameters.AddWithValue("@productSize", names.Productsize);
            commands.Parameters.AddWithValue("@productUnits", names.ProductUnits);
            commands.Parameters.AddWithValue("@productQuantityPack", names.ProductQuantityPack);
            commands.Parameters.AddWithValue("@productQntHand", names.ProductQntHand);
            commands.Parameters.AddWithValue("@productTotalPack", names.ProductTotalPacks);
            commands.Parameters.AddWithValue("@productTotalPeice", names.ProductTotalPeice);
            commands.Parameters.AddWithValue("@productMinStock", names.ProductMinStock);
            commands.Parameters.AddWithValue("@productMaxStock", names.ProductMaxStock);
            commands.Parameters.AddWithValue("@productSalePrice", names.ProductSalePrice);
            commands.Parameters.AddWithValue("@ProductPurchasePrice", names.ProductPurchasePrice);
            commands.Parameters.AddWithValue("@ProductProfit", names.ProductProfit);
            commands.Parameters.AddWithValue("@ProductMaxDiscount", names.MaxDiscount);
            commands.Parameters.AddWithValue("@productTotalProfit", names.ProductTotalPrice);
            commands.Parameters.AddWithValue("@productItemDiscount", names.ProductItemDiscount);
            commands.Parameters.AddWithValue("@productDistributors", names.ProductDistributors);
            commands.Parameters.AddWithValue("@productUpdateStock", names.ProductUpdateStock);
            commands.Parameters.AddWithValue("@productInactive", names.ProductInactive);
          
           commands.Parameters.AddWithValue("@updateDate", names.UpdateDate);
            commands.Parameters.AddWithValue("@loginBy", Constants.userlogin);
            commands.ExecuteNonQuery();


          //  Debug.WriteLine("addDistributorsName Database Entry number " + id);
            return 1;

        }
        /*
        Add New Products... 
        */
        public ArrayList getProductList(String actrive)
        {

            Debug.WriteLine("get Products");

            ArrayList lists = new ArrayList();


            String sql = "select  COALESCE(productId,''), productBarCode,productName,productCompanyName,COALESCE(productPurpose,'')" +
                " ,COALESCE(productDescription,''),COALESCE(productCategory,''),COALESCE(productLocation,''),productExpridate,COALESCE(productBatch,''),COALESCE(productColor1,''),COALESCE(productColor2,''),COALESCE(productColor3,'')" +
                " ,COALESCE(productSize,''),COALESCE(productUnits,''),productQuantityPack,productQntHand,COALESCE(productTotalPack,''),COALESCE(productTotalPeice,'')" +
                " ,COALESCE(productMinStock,''),productMaxStock,COALESCE(productSalePrice,''),COALESCE(ProductPurchasePrice,''),ProductProfit,ProductMaxDiscount,COALESCE(productTotalProfit,''),COALESCE(productItemDiscount,'')" +
                " ,COALESCE(productDistributors,''),COALESCE(productUpdateStock,''),COALESCE(productInactive,''),COALESCE(productEntryDate,''),COALESCE(updateDate,''), COALESCE(loginBy,'')  from  addNewProducts where productInactive='" + actrive + "'";
            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                TableAddNewProducts products = new TableAddNewProducts();

                 products.ProductId = reader.GetInt32(0);
                products.BarCode = reader.GetString(1);
                products.ProductName = reader.GetString(2);
                products.ProductCompanyName = reader.GetString(3);
                // Debug.WriteLine("Discount=== " + reader[4].ToString());

                products.ProductPurpose = reader.GetString(4);

                products.ProductDescription = reader.GetString(5);
                 products.Category= reader.GetString(6);


                products.Location1 = reader.GetString(7);
               products.ProductExpidate = reader.GetDateTime(8);
                products.ProductBatch = reader.GetString(9);
                products.ProductColor1 = reader.GetString(10);
                products.ProductColor2 = reader.GetString(11);
                products.ProductColor3 = reader.GetString(12);
                products.Productsize = reader.GetString(13);
                products.ProductUnits = reader.GetString(14);
                products.ProductQuantityPack = reader.GetInt32(15);
                products.ProductQntHand = reader.GetInt32(16);
                products.ProductTotalPacks = reader.GetInt32(17);

                products.ProductTotalPeice = reader.GetInt32(18);
            
                products.ProductMinStock = reader.GetInt32(19);
                products.ProductMaxStock = reader.GetInt32(20);
                products.ProductSalePrice = reader.GetInt32(21);
                products.ProductPurchasePrice = reader.GetInt32(22);
                products.ProductProfit = reader.GetInt32(23);
               
                products.MaxDiscount = reader.GetInt32(24);
                products.ProductTotalPrice = reader.GetInt32(25);
                products.ProductItemDiscount = reader.GetInt32(26);
                products.ProductDistributors = reader.GetString(27);
               
                products.ProductUpdateStock = reader.GetString(28);
                products.ProductInactive = reader.GetString(29);
                products.ProductEntryDate = reader.GetDateTime(30);
                products.UpdateDate = reader.GetString(31);
                products.LoginUser = reader.GetString(32);
                lists.Add(products);


            }
            reader.Close();
            return lists;
        }

        /*
         get All product without  filteration
        */
        /*
       Add New Products... 
       */

        public ArrayList getProductListNoFilter()
        {

            Debug.WriteLine("get Products");

            ArrayList lists = new ArrayList();


            String sql = "select  COALESCE(productId,''), productBarCode,productName,productCompanyName,COALESCE(productPurpose,'')" +
                " ,COALESCE(productDescription,''),COALESCE(productCategory,''),COALESCE(productLocation,''),productExpridate,COALESCE(productBatch,''),COALESCE(productColor1,''),COALESCE(productColor2,''),COALESCE(productColor3,'')" +
                " ,COALESCE(productSize,''),COALESCE(productUnits,''),productQuantityPack,productQntHand,COALESCE(productTotalPack,''),COALESCE(productTotalPeice,'')" +
                " ,COALESCE(productMinStock,''),productMaxStock,COALESCE(productSalePrice,''),COALESCE(ProductPurchasePrice,''),ProductProfit,ProductMaxDiscount,COALESCE(productTotalProfit,''),COALESCE(productItemDiscount,'')" +
                " ,COALESCE(productDistributors,''),COALESCE(productUpdateStock,''),COALESCE(productInactive,''),COALESCE(productEntryDate,''),COALESCE(updateDate,''), COALESCE(loginBy,'')  from addNewProducts";
            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                TableAddNewProducts products = new TableAddNewProducts();

                products.ProductId = reader.GetInt32(0);
                products.BarCode = reader.GetString(1);
                products.ProductName = reader.GetString(2);
                products.ProductCompanyName = reader.GetString(3);
                // Debug.WriteLine("Discount=== " + reader[4].ToString());

                products.ProductPurpose = reader.GetString(4);

                products.ProductDescription = reader.GetString(5);
                products.Category = reader.GetString(6);


                products.Location1 = reader.GetString(7);
                products.ProductExpidate = reader.GetDateTime(8);
                products.ProductBatch = reader.GetString(9);
                products.ProductColor1 = reader.GetString(10);
                products.ProductColor2 = reader.GetString(11);
                products.ProductColor3 = reader.GetString(12);
                products.Productsize = reader.GetString(13);
                products.ProductUnits = reader.GetString(14);
                products.ProductQuantityPack = reader.GetInt32(15);
                products.ProductQntHand = reader.GetInt32(16);
                products.ProductTotalPacks = reader.GetInt32(17);

                products.ProductTotalPeice = reader.GetInt32(18);

                products.ProductMinStock = reader.GetInt32(19);
                products.ProductMaxStock = reader.GetInt32(20);
                products.ProductSalePrice = reader.GetInt32(21);
                products.ProductPurchasePrice = reader.GetInt32(22);
                products.ProductProfit = reader.GetInt32(23);

                products.MaxDiscount = reader.GetInt32(24);
                products.ProductTotalPrice = reader.GetInt32(25);
                products.ProductItemDiscount = reader.GetInt32(26);
                products.ProductDistributors = reader.GetString(27);

                products.ProductUpdateStock = reader.GetString(28);
                products.ProductInactive = reader.GetString(29);
                products.ProductEntryDate = reader.GetDateTime(30);
                products.UpdateDate = reader.GetString(31);

                lists.Add(products);


            }
            reader.Close();
            return lists;
        }

        /*
        Search Product By Name
        */
        public ArrayList productByName(String id)
        {


            Debug.WriteLine("get productByName");

            ArrayList list = new ArrayList();

            String sql = "Select * from addNewProducts where productId = @id";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());
            commands.CommandType = CommandType.Text;

            commands.Parameters.AddWithValue("@id", Int32.Parse(id));
            TableAddNewProducts products = null;
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                 products = new TableAddNewProducts();
                products.ProductId = reader.GetInt32(0);
                products.BarCode = reader.GetString(1);
                products.ProductName = reader.GetString(2);
                products.ProductCompanyName = reader.GetString(3);
                // Debug.WriteLine("Discount=== " + reader[4].ToString());

                products.ProductPurpose = reader.GetString(4);

                products.ProductDescription = reader.GetString(5);
                products.Category = reader.GetString(6);


                products.Location1 = reader.GetString(7);
                products.ProductExpidate = reader.GetDateTime(8);
                products.ProductBatch = reader.GetString(9);
                products.ProductColor1 = reader.GetString(10);
                products.ProductColor2 = reader.GetString(11);
                products.ProductColor3 = reader.GetString(12);
                products.Productsize = reader.GetString(13);
                products.ProductUnits = reader.GetString(14);
                products.ProductQuantityPack = reader.GetInt32(15);
                products.ProductQntHand = reader.GetInt32(16);
                products.ProductTotalPacks = reader.GetInt32(17);

                products.ProductTotalPeice = reader.GetInt32(18);

                products.ProductMinStock = reader.GetInt32(19);
                products.ProductMaxStock = reader.GetInt32(20);
                products.ProductSalePrice = reader.GetInt32(21);
                products.ProductPurchasePrice = reader.GetInt32(22);
                products.ProductProfit = reader.GetInt32(23);

                products.MaxDiscount = reader.GetInt32(24);
                products.ProductTotalPrice = reader.GetInt32(25);
                products.ProductItemDiscount = reader.GetInt32(26);
                products.ProductDistributors = reader.GetString(27);

                products.ProductUpdateStock = reader.GetString(28);
                products.ProductInactive = reader.GetString(29);
                products.ProductEntryDate = reader.GetDateTime(30);
                products.UpdateDate = reader.GetString(31);

               list.Add(products);
                Debug.WriteLine(products);

            }
            reader.Close();
            return list;
        }
        /*
        get Product By ItemCode
        */
        public TableAddNewProducts productByItemCode(String id)
        {


            Debug.WriteLine("get productByItemCode");

            ArrayList list = new ArrayList();

            String sql = "Select * from addNewProducts where productBarCode = @id";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());
            commands.CommandType = CommandType.Text;

            commands.Parameters.AddWithValue("@id", id);
            TableAddNewProducts products = null;
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                products = new TableAddNewProducts();
                products.ProductId = reader.GetInt32(0);
                products.BarCode = reader.GetString(1);
                products.ProductName = reader.GetString(2);
                products.ProductCompanyName = reader.GetString(3);
                // Debug.WriteLine("Discount=== " + reader[4].ToString());

                products.ProductPurpose = reader.GetString(4);

                products.ProductDescription = reader.GetString(5);
                products.Category = reader.GetString(6);


                products.Location1 = reader.GetString(7);
                products.ProductExpidate = reader.GetDateTime(8);
                products.ProductBatch = reader.GetString(9);
                products.ProductColor1 = reader.GetString(10);
                products.ProductColor2 = reader.GetString(11);
                products.ProductColor3 = reader.GetString(12);
                products.Productsize = reader.GetString(13);
                products.ProductUnits = reader.GetString(14);
                products.ProductQuantityPack = reader.GetInt32(15);
                products.ProductQntHand = reader.GetInt32(16);
                products.ProductTotalPacks = reader.GetInt32(17);

                products.ProductTotalPeice = reader.GetInt32(18);

                products.ProductMinStock = reader.GetInt32(19);
                products.ProductMaxStock = reader.GetInt32(20);
                products.ProductSalePrice = reader.GetInt32(21);
                products.ProductPurchasePrice = reader.GetInt32(22);
                products.ProductProfit = reader.GetInt32(23);

                products.MaxDiscount = reader.GetInt32(24);
                products.ProductTotalPrice = reader.GetInt32(25);
                products.ProductItemDiscount = reader.GetInt32(26);
                products.ProductDistributors = reader.GetString(27);

                products.ProductUpdateStock = reader.GetString(28);
                products.ProductInactive = reader.GetString(29);
                products.ProductEntryDate = reader.GetDateTime(30);
                products.UpdateDate = reader.GetString(31);

                //   list.Add(products);
                Debug.WriteLine(products);

            }
            reader.Close();
            return products;
        }

        /*
         Product by Descrption
         */
        public TableAddNewProducts productByDiscreption(String id)
        {


            Debug.WriteLine("get productByDiscreption");

            ArrayList list = new ArrayList();

            String sql = "Select * from addNewProducts where productId = @id";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());
            commands.CommandType = CommandType.Text;

            commands.Parameters.AddWithValue("@id", Int32.Parse(id));
            TableAddNewProducts products = null;
            SqlDataReader reader = commands.ExecuteReader();
            if (reader.Read())
            {
                products = new TableAddNewProducts();
                products.ProductId = reader.GetInt32(0);
                products.BarCode = reader.GetString(1);
                products.ProductName = reader.GetString(2);
                products.ProductCompanyName = reader.GetString(3);
                // Debug.WriteLine("Discount=== " + reader[4].ToString());

                products.ProductPurpose = reader.GetString(4);

                products.ProductDescription = reader.GetString(5);
                products.Category = reader.GetString(6);


                products.Location1 = reader.GetString(7);
                products.ProductExpidate = reader.GetDateTime(8);
                products.ProductBatch = reader.GetString(9);
                products.ProductColor1 = reader.GetString(10);
                products.ProductColor2 = reader.GetString(11);
                products.ProductColor3 = reader.GetString(12);
                products.Productsize = reader.GetString(13);
                products.ProductUnits = reader.GetString(14);
                products.ProductQuantityPack = reader.GetInt32(15);
                products.ProductQntHand = reader.GetInt32(16);
                products.ProductTotalPacks = reader.GetInt32(17);

                products.ProductTotalPeice = reader.GetInt32(18);

                products.ProductMinStock = reader.GetInt32(19);
                products.ProductMaxStock = reader.GetInt32(20);
                products.ProductSalePrice = reader.GetInt32(21);
                products.ProductPurchasePrice = reader.GetInt32(22);
                products.ProductProfit = reader.GetInt32(23);

                products.MaxDiscount = reader.GetInt32(24);
                products.ProductTotalPrice = reader.GetInt32(25);
                products.ProductItemDiscount = reader.GetInt32(26);
                products.ProductDistributors = reader.GetString(27);

                products.ProductUpdateStock = reader.GetString(28);
                products.ProductInactive = reader.GetString(29);
                products.ProductEntryDate = reader.GetDateTime(30);
                products.UpdateDate = reader.GetString(31);

                //   list.Add(products);
                Debug.WriteLine(products);

            }
            reader.Close();
            return products;
        }

       public void updateProductList(TableAddNewProducts names)
        {
            String sql = "Update addNewProducts set ProductBarCode=@ProductBarCode,productName=@productName, productCompanyName=@productCompanyName,productPurpose=@productPurpose,productDescription=@productDescription," +
                     "productCategory = @productCategory,productLocation = @productLocation,productExpridate = @productExpridate," +
                     "productBatch = @productBatch,productColor1 = @productColor1,productColor2 = @productColor2,productColor3 = productColor3,productSize = @productSize,productUnits = @productUnits,productQuantityPack = @productQuantityPack," +
                      "productQntHand = @productQntHand,productTotalPack = @productTotalPack,productTotalPeice = @productTotalPeice," +
                      "productMinStock = @productMinStock,productMaxStock = @productMaxStock,productSalePrice = @productSalePrice," +
                       "ProductPurchasePrice = @ProductPurchasePrice,ProductProfit = @ProductProfit,ProductMaxDiscount = @ProductMaxDiscount,productTotalProfit = @productTotalProfit,productItemDiscount = @productItemDiscount,productDistributors = @productDistributors," +
                       "productUpdateStock = @productUpdateStock,productInactive = @productInactive, updateDate= @updateDate, loginBy=@loginBy where  productId = @productId";


             SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());

            commands.CommandType = CommandType.Text;
            
            commands.Parameters.AddWithValue("@productBarCode", names.BarCode);
            commands.Parameters.AddWithValue("@productName", names.ProductName);
            commands.Parameters.AddWithValue("@productCompanyName", names.ProductCompanyName);
            commands.Parameters.AddWithValue("@productPurpose", names.ProductPurpose);
            commands.Parameters.AddWithValue("@productDescription", names.ProductDescription);

            commands.Parameters.AddWithValue("@productCategory", names.Category);
            commands.Parameters.AddWithValue("@productLocation", names.Location1);

            commands.Parameters.AddWithValue("@productExpridate", names.ProductExpidate);
            commands.Parameters.AddWithValue("@productBatch", names.ProductBatch);
            commands.Parameters.AddWithValue("@productColor1", names.ProductColor1);
            commands.Parameters.AddWithValue("@productColor2", names.ProductColor2);
            commands.Parameters.AddWithValue("@productColor3", names.ProductColor3);
            commands.Parameters.AddWithValue("@productSize", names.Productsize);
            commands.Parameters.AddWithValue("@productUnits", names.ProductUnits);
            commands.Parameters.AddWithValue("@productQuantityPack", names.ProductQuantityPack);
            commands.Parameters.AddWithValue("@productQntHand", names.ProductQntHand);
            commands.Parameters.AddWithValue("@productTotalPack", names.ProductTotalPacks);
            commands.Parameters.AddWithValue("@productTotalPeice", names.ProductTotalPeice);
            commands.Parameters.AddWithValue("@productMinStock", names.ProductMinStock);
            commands.Parameters.AddWithValue("@productMaxStock", names.ProductMaxStock);
            commands.Parameters.AddWithValue("@productSalePrice", names.ProductSalePrice);
            commands.Parameters.AddWithValue("@ProductPurchasePrice", names.ProductPurchasePrice);
            commands.Parameters.AddWithValue("@ProductProfit", names.ProductProfit);
            commands.Parameters.AddWithValue("@ProductMaxDiscount", names.MaxDiscount);
            commands.Parameters.AddWithValue("@productTotalProfit", names.ProductTotalPrice);
            commands.Parameters.AddWithValue("@productItemDiscount", names.ProductItemDiscount);
            commands.Parameters.AddWithValue("@productDistributors", names.ProductDistributors);
           commands.Parameters.AddWithValue("@productUpdateStock", names.ProductUpdateStock);
            commands.Parameters.AddWithValue("@productInactive", names.ProductInactive);
          
            commands.Parameters.AddWithValue("@updateDate", names.UpdateDate);
            commands.Parameters.AddWithValue("@loginBy", Constants.userlogin);
            commands.Parameters.AddWithValue("@productId", names.ProductId);
            commands.ExecuteNonQuery();
 

            Debug.WriteLine("Update Products");
           
        }
        /*
get Product By productSearchAllTypes
*/
        public ArrayList productSearchAllTypes(TableAddNewProducts names)
        {


            Debug.WriteLine("get productByItemCode");

            ArrayList list = new ArrayList();

            String sql = "select  COALESCE(productId,''), productBarCode,productName,productCompanyName,COALESCE(productPurpose,'')" +
                " ,COALESCE(productDescription,''),COALESCE(productCategory,''),COALESCE(productLocation,''),productExpridate,COALESCE(productBatch,''),COALESCE(productColor1,''),COALESCE(productColor2,''),COALESCE(productColor3,'')" +
                " ,COALESCE(productSize,''),COALESCE(productUnits,''),productQuantityPack,productQntHand,COALESCE(productTotalPack,''),COALESCE(productTotalPeice,'')" +
                " ,COALESCE(productMinStock,''),productMaxStock,COALESCE(productSalePrice,''),COALESCE(ProductPurchasePrice,''),ProductProfit,ProductMaxDiscount,COALESCE(productTotalProfit,''),COALESCE(productItemDiscount,'')" +
                " ,COALESCE(productDistributors,''),COALESCE(productUpdateStock,''),COALESCE(productInactive,''),COALESCE(productEntryDate,''),COALESCE(updateDate,''), COALESCE(loginBy,'')  from addNewProducts where productBarCode = @productBarCode OR  productName= @productName OR " +
                 "productCompanyName = @productCompanyName OR productPurpose=@productPurpose OR productCategory = @productCategory OR productDescription = @productDescription AND  productInactive ='yes'";

            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());
            commands.CommandType = CommandType.Text;

            commands.Parameters.AddWithValue("@productBarCode", names.BarCode);
            commands.Parameters.AddWithValue("@productName", names.ProductName);
            commands.Parameters.AddWithValue("@productCompanyName", names.ProductCompanyName);
            commands.Parameters.AddWithValue("@productPurpose", names.ProductPurpose);
            commands.Parameters.AddWithValue("@productCategory", names.Category);
            commands.Parameters.AddWithValue("@productDescription", names.ProductDescription);


            TableAddNewProducts products = null;
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                products = new TableAddNewProducts();
                products.ProductId = reader.GetInt32(0);
                products.BarCode = reader.GetString(1);
                products.ProductName = reader.GetString(2);
                products.ProductCompanyName = reader.GetString(3);
                // Debug.WriteLine("Discount=== " + reader[4].ToString());

                products.ProductPurpose = reader.GetString(4);

                products.ProductDescription = reader.GetString(5);
                products.Category = reader.GetString(6);


                products.Location1 = reader.GetString(7);
                products.ProductExpidate = reader.GetDateTime(8);
                products.ProductBatch = reader.GetString(9);
                products.ProductColor1 = reader.GetString(10);
                products.ProductColor2 = reader.GetString(11);
                products.ProductColor3 = reader.GetString(12);
                products.Productsize = reader.GetString(13);
                products.ProductUnits = reader.GetString(14);
                products.ProductQuantityPack = reader.GetInt32(15);
                products.ProductQntHand = reader.GetInt32(16);
                products.ProductTotalPacks = reader.GetInt32(17);

                products.ProductTotalPeice = reader.GetInt32(18);

                products.ProductMinStock = reader.GetInt32(19);
                products.ProductMaxStock = reader.GetInt32(20);
                products.ProductSalePrice = reader.GetInt32(21);
                products.ProductPurchasePrice = reader.GetInt32(22);
                products.ProductProfit = reader.GetInt32(23);

                products.MaxDiscount = reader.GetInt32(24);
                products.ProductTotalPrice = reader.GetInt32(25);
                products.ProductItemDiscount = reader.GetInt32(26);
                products.ProductDistributors = reader.GetString(27);

                products.ProductUpdateStock = reader.GetString(28);
                products.ProductInactive = reader.GetString(29);
                products.ProductEntryDate = reader.GetDateTime(30);
                products.UpdateDate = reader.GetString(31);

                list.Add(products);
                Debug.WriteLine(products);

            }
            reader.Close();
            return list;
        }

        /// <summary>
        ///    Search By Date
        /// </summary>
        /// <param name="names"></param>
        /// <returns></returns>

        public ArrayList productBYDate(TableAddNewProducts names)
        {


            Debug.WriteLine("------------- get productByItemCode");

            ArrayList list = new ArrayList();

            //String sql = "Select * from addNewProducts where productBarCode = @productBarCode OR  productName= @productName OR " +
            //     "productCompanyName = @productCompanyName OR productPurpose=@productPurpose OR productCategory = @productCategory OR productDescription = @productDescription "+
            //     "OR  CONVERT(varchar(10),productExpridate,	105)  > CONVERT(varchar(10),@FromDate,	105) AND CONVERT(varchar(10),productExpridate,	105)  < CONVERT(varchar(10), @ToDate,	105) AND productInactive ='yes'";

            String sql = "Select  COALESCE(productId,''), productBarCode,productName,productCompanyName,COALESCE(productPurpose,'')" +
                " ,COALESCE(productDescription,''),COALESCE(productCategory,''),COALESCE(productLocation,''),productExpridate,COALESCE(productBatch,''),COALESCE(productColor1,''),COALESCE(productColor2,''),COALESCE(productColor3,'')" +
                " ,COALESCE(productSize,''),COALESCE(productUnits,''),productQuantityPack,productQntHand,COALESCE(productTotalPack,''),COALESCE(productTotalPeice,'')" +
                " ,COALESCE(productMinStock,''),productMaxStock,COALESCE(productSalePrice,''),COALESCE(ProductPurchasePrice,''),ProductProfit,ProductMaxDiscount,COALESCE(productTotalProfit,''),COALESCE(productItemDiscount,'')" +
                " ,COALESCE(productDistributors,''),COALESCE(productUpdateStock,''),COALESCE(productInactive,''),COALESCE(productEntryDate,''),COALESCE(updateDate,''), COALESCE(loginBy,'') from addNewProducts where productExpridate  > @FromDate AND productExpridate < @ToDate AND productInactive ='yes'";


            SqlCommand commands = new SqlCommand(sql, DatabaseConnections.Instance.getConnection());
            commands.CommandType = CommandType.Text;

            //commands.Parameters.AddWithValue("@productBarCode", names.BarCode);
            //commands.Parameters.AddWithValue("@productName", names.ProductName);
            //commands.Parameters.AddWithValue("@productCompanyName", names.ProductCompanyName);
            //commands.Parameters.AddWithValue("@productPurpose", names.ProductPurpose);
            //commands.Parameters.AddWithValue("@productCategory", names.Category);
            //commands.Parameters.AddWithValue("@productDescription", names.ProductDescription);
           commands.Parameters.AddWithValue("@FromDate", names.FromDate1);
            commands.Parameters.AddWithValue("@ToDate", names.ToDate);

            TableAddNewProducts products = null;
            SqlDataReader reader = commands.ExecuteReader();
            while (reader.Read())
            {
                products = new TableAddNewProducts();
                products.ProductId = reader.GetInt32(0);
                products.BarCode = reader.GetString(1);
                products.ProductName = reader.GetString(2);
                products.ProductCompanyName = reader.GetString(3);

                Debug.WriteLine("----------- " + reader.GetString(2));

                products.ProductPurpose = reader.GetString(4);

                products.ProductDescription = reader.GetString(5);
                products.Category = reader.GetString(6);


                products.Location1 = reader.GetString(7);
                products.ProductExpidate = reader.GetDateTime(8);
                products.ProductBatch = reader.GetString(9);
                products.ProductColor1 = reader.GetString(10);
                products.ProductColor2 = reader.GetString(11);
                products.ProductColor3 = reader.GetString(12);
                products.Productsize = reader.GetString(13);
                products.ProductUnits = reader.GetString(14);
                products.ProductQuantityPack = reader.GetInt32(15);
                products.ProductQntHand = reader.GetInt32(16);
                products.ProductTotalPacks = reader.GetInt32(17);

                products.ProductTotalPeice = reader.GetInt32(18);

                products.ProductMinStock = reader.GetInt32(19);
                products.ProductMaxStock = reader.GetInt32(20);
                products.ProductSalePrice = reader.GetInt32(21);
                products.ProductPurchasePrice = reader.GetInt32(22);
                products.ProductProfit = reader.GetInt32(23);

                products.MaxDiscount = reader.GetInt32(24);
                products.ProductTotalPrice = reader.GetInt32(25);
                products.ProductItemDiscount = reader.GetInt32(26);
                products.ProductDistributors = reader.GetString(27);

                products.ProductUpdateStock = reader.GetString(28);
                products.ProductInactive = reader.GetString(29);
                products.ProductEntryDate = reader.GetDateTime(30);
                products.UpdateDate = reader.GetString(31);

                list.Add(products);
                Debug.WriteLine(products);

            }
            reader.Close();
            return list;
        }



    }
}
