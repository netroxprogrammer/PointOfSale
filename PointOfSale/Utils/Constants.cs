using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Utils
{
    class Constants
    {
          public static bool  checkLogin = false;
        public static String userlogin = "";
        public  static String f = "Data Source =";
        public static  String f1 = System.Environment.MachineName.ToLower().ToString();
        public static String f3 = "\\sqlexpress;";
        public String serverUrl = f + f1 + f3;
       
        public const String databaseName = "Initial Catalog=Point_Of_Sale";
        public const String securityCheck = ";Integrated Security=True;Pooling=False;MultipleActiveResultSets=True;";
    }
}
