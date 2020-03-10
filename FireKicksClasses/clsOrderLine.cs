using System;

namespace FireKicksClasses
{
    public class clsOrderLine
    {
        private Int32 mOrderLineID;
        public int OrderLineID
        {
            get
            {
                return mOrderLineID;
            }
            set
            {
                mOrderLineID = value;
            }
        }

        private Int32 mOrderID;
        public int OrderID
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

        private Int32 mProductID;
        public int ProductID
        {
            get
            {
                return mProductID;
            }
            set
            {
                mProductID = value;
            }
        }

        private Int32 mQuantity;
        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }



        public bool Find(int orderLineID)
        {
            mOrderLineID = 1;
            mOrderID = 1;
            mProductID = 121;
            mQuantity = 4;
            return true;
        }
}
}