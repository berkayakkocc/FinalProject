using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product Added";
        public static string ProductDeleted = "Product Deleted";
        public static string ProductUpdated= "Product Updated";
        public static string ProductNameInvalid= "Product Name Invalid";

        internal static string MaintenanceTime = "System Maintenance Time";

        internal static string ProductListed = "Products listed";

        public static string UnitPriceInvalid = "The product price cannot be less than zero";

        public static string ProductCountOfCategoryError = "The number of products has reached ten.";

        public static string ProductNameAlreadyExist = "Same product name available";

        public static string CategoryLimitExceded = "Category limit exceded";
    }
}
