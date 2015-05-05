using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Model
{
    public enum SortOrder
    {
        asc = 1,
        desc = 2
    }

    public enum SearchOperator
    {
        equal,
        notequal,
        lessthan,
        lessthanequal,
        greaterthan,
        greaterthanequal,
        like
    }

    public enum SearchField
    {
        design,
        category,
        collection,
        color,
        size,
        qty,
        barcode
    }

    public class InventoryConstants
    {
        public static readonly int PAGING_SIZE_5 = 5;
        public static readonly int PAGING_SIZE_10 = 10;
        public static readonly int PAGING_SIZE_20 = 20;
        public static readonly string DEFAULT_PASSWORD = "Ims@Password1";
        public static readonly string INVALID_USERNAME_PASSWORD = "Invalid ID or password.";
        public const string ROLE_ADMIN = "admin";
        public const string ROLE_RETAILER = "retailer";
    }
}