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
        desc = 2,
<<<<<<< HEAD
		iammakingthreehere=3,
		anythingelse = 4,
		onemore = 5
=======
		anythingelse = 3,
		onemore = 4
>>>>>>> b863c1e444634a1e2115ba2f61e4f54259419cbb
    }

    public enum SearchOperator
    {
        equal,
        notequal,
        lessthan,
        lessthanequal,
        greaterthan,
        greaterthanequal,
        like,
		onegoeshere
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

    public enum TransactionType
    {
        ReceivingActiveToReceived = 1, // +
        ReceivingOnHoldToReceived = 2, // +
        SalesOrderNewToInProgress = 4, // -
        SalesOrderNewToComplete = 8, // -
        SalesOrderOnHoldToInProgress = 16, // -
        SalesOrderOnHoldToComplete = 32, // -
        SalesOrderInProgressToOnHold = 64, // +
        SalesOrderInProgressToCancelled = 128, // +
        PositiveAdjustment = 256, // +
        NegativeAdjustment = 512, // -
		AndOneMore = 1024
    }

    public enum SalesOrderState
    {
        New = 1, // Order created. No impact on inventory status
        OnHold = 2, // Order is on hold (might be due to missing inventory or other reason)
        InProcess = 4, // Inventory deducted and now order can be only cancelled
        // PaymentReceived = 8, // Currently this option is not honored
        Complete = 16, // Transaction completed and sealed. No changes can be done to same.
        Cancelled = 32 // Order is cancelled. Nothing can be done to order now.
    }

    public enum ReceivingEntryState
    {
        Active = 1,
        OnHold = 2,
        Cancelled = 4,
        Received = 8
    }

    public enum AdjustmentReasonCode
    {
        NewArrival = 1,
        Returns = 2,
        Damaged = 3,
        Promotion = 4,
        Lost = 5,
        Other = 0
    }

    public enum SourceType
    {
        Receiving = 1,
        SalesOrder = 2,
        Adjustment = 3
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