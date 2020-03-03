using System;
using FireKicksClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FireKicksTesting
{
    [TestClass]
    public class tstOrderProcessing
    {



        [TestMethod]
        public void InstanceOk()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            Assert.IsNotNull(AnOrderProcessing);
        }

        [TestMethod]
        public void OrderID()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            int TestData = 1;
            AnOrderProcessing.OrderID = TestData;
            Assert.AreEqual(AnOrderProcessing.OrderID, TestData);
        }

        [TestMethod]
        public void CustomerID()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            int TestData = 1;
            AnOrderProcessing.CustomerID = TestData;
            Assert.AreEqual(AnOrderProcessing.CustomerID, TestData);
        }

        [TestMethod]
        public void OrderDate()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            DateTime TestData = DateTime.Now.Date;
            AnOrderProcessing.OrderDate = TestData;
            Assert.AreEqual(AnOrderProcessing.OrderDate, TestData);
        }
        [TestMethod]
        public void TrainerDescription()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            string TestData = "Nike";
            AnOrderProcessing.TrainerDescription = TestData;
            Assert.AreEqual(AnOrderProcessing.TrainerDescription, TestData);
        }

        [TestMethod]
        public void TotalAmount()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            double TestData = 10.99;
            AnOrderProcessing.TotalAmount = TestData;
            Assert.AreEqual(AnOrderProcessing.TotalAmount, TestData);
        }

        [TestMethod]
        public void Dispatched()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            Boolean TestData = true;
            AnOrderProcessing.Dispatched = TestData;
            Assert.AreEqual(AnOrderProcessing.Dispatched, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            Boolean Found = false;
            Int32 OrderID = 3;
            Found = AnOrderProcessing.Find(OrderID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = AnOrderProcessing.Find(OrderID);
            if (AnOrderProcessing.OrderID !=3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = AnOrderProcessing.Find(OrderID);
            if (AnOrderProcessing.CustomerID != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = AnOrderProcessing.Find(OrderID);
            if (AnOrderProcessing.OrderDate != Convert.ToDateTime("03/03/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTrainerDescriptionFound()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = AnOrderProcessing.Find(OrderID);
            if (AnOrderProcessing.TrainerDescription != "Adidas")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestTotalAmountFound()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = AnOrderProcessing.Find(OrderID);
            if (AnOrderProcessing.TotalAmount != 70.00)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDispatchedFound()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = AnOrderProcessing.Find(OrderID);
            if (AnOrderProcessing.Dispatched != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }        
    }


