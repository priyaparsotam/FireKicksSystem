using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FireKicksClasses;

namespace FireKicksTesting
{
    [TestClass]
    public class tstOrderProcessingCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderProcessingCollection AllOrders = new clsOrderProcessingCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderProcessingListOK()
        {
            clsOrderProcessingCollection AllOrders = new clsOrderProcessingCollection();
            List<clsOrderProcessing> TestList = new List<clsOrderProcessing>();
            clsOrderProcessing TestItem = new clsOrderProcessing();
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TrainerDescription = "some Description";
            TestItem.TotalAmount = 50;
            TestItem.Dispatched = true;
            TestList.Add(TestItem);
            AllOrders.OrderProcessingList = TestList;
            Assert.AreEqual(AllOrders.OrderProcessingList, TestList);
        }

       /* [TestMethod]
        public void CountOrderOK()
        {
            clsOrderProcessingCollection AllOrders = new clsOrderProcessingCollection();
            Int32 SomeCount = 2;
            AllOrders.Count = SomeCount;
            Assert.AreEqual(AllOrders.Count, SomeCount);
        }*/

        [TestMethod]
        public void ThisOrderOK()
        {
            clsOrderProcessingCollection AllOrders = new clsOrderProcessingCollection();
            clsOrderProcessing TestOrderProcessing = new clsOrderProcessing();
            TestOrderProcessing.OrderID = 1;
            TestOrderProcessing.CustomerID = 1;
            TestOrderProcessing.OrderDate = DateTime.Now.Date;
            TestOrderProcessing.TrainerDescription = "some Description";
            TestOrderProcessing.TotalAmount = 50;
            TestOrderProcessing.Dispatched = true;
            AllOrders.ThisOrderProcessing = TestOrderProcessing;
            Assert.AreEqual(AllOrders.ThisOrderProcessing, TestOrderProcessing);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderProcessingCollection AllOrders = new clsOrderProcessingCollection();
            List<clsOrderProcessing> TestList = new List<clsOrderProcessing>();
            clsOrderProcessing TestItem = new clsOrderProcessing();
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TrainerDescription = "some Description";
            TestItem.TotalAmount = 50;
            TestItem.Dispatched = true;
            TestList.Add(TestItem);
            AllOrders.OrderProcessingList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        /*[TestMethod]
        public void TwoRecordsPresentOK()
        {
            clsOrderProcessingCollection AllOrders = new clsOrderProcessingCollection();
            Assert.AreEqual(AllOrders.Count, 2);
        }*/
    }
}
