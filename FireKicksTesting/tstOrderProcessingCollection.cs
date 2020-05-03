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


        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderProcessingCollection AllOrders = new clsOrderProcessingCollection();
            clsOrderProcessing TestItem = new clsOrderProcessing();
            Int32 PrimaryKey = 0;
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TrainerDescription = "some Description";
            TestItem.TotalAmount = 50;
            TestItem.Dispatched = true;
            AllOrders.ThisOrderProcessing = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrders.ThisOrderProcessing.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrderProcessing, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderProcessingCollection AllOrders = new clsOrderProcessingCollection();
            clsOrderProcessing TestItem = new clsOrderProcessing();
            Int32 PrimaryKey = 0;
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TrainerDescription = "some Description";
            TestItem.TotalAmount = 50;
            TestItem.Dispatched = true;
            AllOrders.ThisOrderProcessing = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrders.ThisOrderProcessing.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrderProcessing.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderProcessingCollection AllOrders = new clsOrderProcessingCollection();
            clsOrderProcessing TestItem = new clsOrderProcessing();
            Int32 PrimaryKey = 0;
            TestItem.CustomerID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TrainerDescription = "some Description";
            TestItem.TotalAmount = 50;
            TestItem.Dispatched = true;
            AllOrders.ThisOrderProcessing = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            TestItem.CustomerID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TrainerDescription = "some Description";
            TestItem.TotalAmount = 50;
            TestItem.Dispatched = true;
            AllOrders.ThisOrderProcessing = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrderProcessing.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrderProcessing, TestItem);
        }

        [TestMethod]
        public void ReportByTrainerDescriptionOK()
        {
            clsOrderProcessingCollection AllOrders = new clsOrderProcessingCollection();
            clsOrderProcessingCollection FilteredOrders = new clsOrderProcessingCollection();
            FilteredOrders.ReportByTrainerDescription("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByTrainerDescriptionNoneFound()
        {
            clsOrderProcessingCollection FilteredOrders = new clsOrderProcessingCollection();
            FilteredOrders.ReportByTrainerDescription("xxx xxx");
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        /*[TestMethod]
        public void ReportByTrainerDescriptionTestDataFound()
        {
            clsOrderProcessingCollection FilteredOrders = new clsOrderProcessingCollection();
            Boolean OK = true;
            FilteredOrders.ReportByTrainerDescription("Converse");
            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrderProcessingList[0].OrderID != 6)
                {
                    OK = false;
                }
                if (FilteredOrders.OrderProcessingList[1].OrderID != 7)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
                Assert.IsTrue(OK);
            }*/
        
}
}
