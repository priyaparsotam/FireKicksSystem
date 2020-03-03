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

        public bool Find(int orderID)
        {
            mOrderID = 3;
            mCustomerID = 3;
            mOrderDate = Convert.ToDateTime("03/03/2020");
            mTrainerDescription = "Adidas";
            mTotalAmount = 70.00;
            mDispatched = true;
            return true;
        }
    }
    
    
}