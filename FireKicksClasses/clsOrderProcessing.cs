using System;

namespace FireKicksClasses
{
    public class clsOrderProcessing
    {
        private Int32 mOrderID;
        public Int32 OrderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        }

        private Int32 mCustomerID;
        public Int32 CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }

        private DateTime mOrderDate;
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }

        private String mTrainerDescription;
        public String TrainerDescription
        {
            get
            {
                return mTrainerDescription;
            }
            set
            {
                mTrainerDescription = value;
            }
        }

        private Double mTotalAmount;
        public Double TotalAmount
        {
            get
            {
                return mTotalAmount;
            }
            set
            {
                mTotalAmount = value;
            }
        }
        private Boolean mDispatched;
        public Boolean Dispatched
        {
            get
            {
                return mDispatched;
            }
            set
            {
                mDispatched = value;
            }
        }

        public bool Find(int OrderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_tblOrderProcessing_FilterByOrderID");
            if(DB.Count ==1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mTrainerDescription = Convert.ToString(DB.DataTable.Rows[0]["TrainerDescription"]);
                mTotalAmount = Convert.ToInt32(DB.DataTable.Rows[0]["TotalAmount"]);
                mDispatched = Convert.ToBoolean(DB.DataTable.Rows[0]["Dispatched"]);
                return true;
            }
            else
            {
                return false;
            }

           
        }
    }
    
    
}