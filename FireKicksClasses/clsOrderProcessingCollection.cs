using System;
using System.Collections.Generic;

namespace FireKicksClasses
{
    public class clsOrderProcessingCollection
    {
        List<clsOrderProcessing> mOrderProcessingList = new List<clsOrderProcessing>();
        clsOrderProcessing mThisOrderProcessing = new clsOrderProcessing();

        public List<clsOrderProcessing> OrderProcessingList
        {
            get
            {
                return mOrderProcessingList;
            }
            set
            {
                mOrderProcessingList = value;
            }
        }


        public int Count
        {
            get
            {
                return mOrderProcessingList.Count;
            }
            set
            {
                //blank
            }
        }
        public clsOrderProcessing ThisOrderProcessing
        {
            get
            {
                return mThisOrderProcessing;
            }
            set
            {
                mThisOrderProcessing = value;
            }
        }

        public clsOrderProcessingCollection()
        {

            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrderProcessing_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
                AnOrderProcessing.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrderProcessing.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrderProcessing.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrderProcessing.TrainerDescription = Convert.ToString(DB.DataTable.Rows[Index]["TrainerDescription"]);
                AnOrderProcessing.TotalAmount = Convert.ToDouble(DB.DataTable.Rows[Index]["TotalAmount"]);
                AnOrderProcessing.Dispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["Dispatched"]);
                mOrderProcessingList.Add(AnOrderProcessing);
                Index++;
            }



         
           /* clsOrderProcessing TestItem = new clsOrderProcessing();
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TrainerDescription = "some Description";
            TestItem.TotalAmount = 50;
            TestItem.Dispatched = true;
            mOrderProcessingList.Add(TestItem);

            TestItem = new clsOrderProcessing();
            TestItem.OrderID = 2;
            TestItem.CustomerID = 2;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TrainerDescription = "another Description";
            TestItem.TotalAmount = 90;
            TestItem.Dispatched = true;
            mOrderProcessingList.Add(TestItem);*/
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisOrderProcessing.CustomerID);
            DB.AddParameter("@OrderDate", mThisOrderProcessing.OrderDate);
            DB.AddParameter("@TrainerDescription", mThisOrderProcessing.TrainerDescription);
            DB.AddParameter("@TotalAmount", mThisOrderProcessing.TotalAmount);
            DB.AddParameter("@Dispatched", mThisOrderProcessing.Dispatched);
            return DB.Execute("sproc_tblOrderProcessing_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrderProcessing.OrderID);
            DB.Execute("sproc_tblOrderProcessing_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrderProcessing.OrderID);
            DB.AddParameter("@CustomerID", mThisOrderProcessing.CustomerID);
            DB.AddParameter("@OrderDate", mThisOrderProcessing.OrderDate);
            DB.AddParameter("@TrainerDescription", mThisOrderProcessing.TrainerDescription);
            DB.AddParameter("@TotalAmount", mThisOrderProcessing.TotalAmount);
            DB.AddParameter("@Dispatched", mThisOrderProcessing.Dispatched);
            DB.Execute("sproc_tblOrderProcessing_Update");
        }
        }
    }
}