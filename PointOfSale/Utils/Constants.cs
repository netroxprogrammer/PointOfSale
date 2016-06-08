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
        public const String serverUrl = "Data Source=mac-pc\\sqlexpress;";
        public const String databaseName = "Initial Catalog=Point_Of_Sale";
        public const String securityCheck = ";Integrated Security=True;Pooling=False;MultipleActiveResultSets=True;";
    }
}
