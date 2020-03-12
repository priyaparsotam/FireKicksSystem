using System;
using FireKicksClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FireKicksTesting
{
    [TestClass]
    public class tstOrderProcessing { 
    
       
        string CustomerID = "1";
        string OrderDate = DateTime.Now.Date.ToString();
        string TrainerDescription = "Nike";
        string TotalAmount = "50";

        [TestMethod]
        public void InstanceOk()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            Assert.IsNotNull(AnOrderProcessing);
        }

        [TestMethod]
        public void OrderIDOk()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            int TestData = 1;
            AnOrderProcessing.OrderID = TestData;
            Assert.AreEqual(AnOrderProcessing.OrderID, TestData);
        }

        [TestMethod]
        public void CustomerIDOk()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            int TestData = 1;
            AnOrderProcessing.CustomerID = TestData;
            Assert.AreEqual(AnOrderProcessing.CustomerID, TestData);
        }

        [TestMethod]
        public void OrderDateOk()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            DateTime TestData = DateTime.Now.Date;
            AnOrderProcessing.OrderDate = TestData;
            Assert.AreEqual(AnOrderProcessing.OrderDate, TestData);
        }
        [TestMethod]
        public void TrainerDescriptionOk()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            string TestData = "Nike";
            AnOrderProcessing.TrainerDescription = TestData;
            Assert.AreEqual(AnOrderProcessing.TrainerDescription, TestData);
        }

        [TestMethod]
        public void TotalAmountOk()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            double TestData = 10.99;
            AnOrderProcessing.TotalAmount = TestData;
            Assert.AreEqual(AnOrderProcessing.TotalAmount, TestData);
        }

        [TestMethod]
        public void DispatchedOk()
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
            if (AnOrderProcessing.OrderDate != Convert.ToDateTime("04/03/2020"))
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

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string CustomerID = "";
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMin()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string CustomerID = "1";
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string CustomerID = "11";
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string CustomerID = "11111";
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMax()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string CustomerID = "111111";
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMid()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string CustomerID = "111";
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string CustomerID = "1111111";
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(500, '1');
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string OrderDate = TestDate.ToString();
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string OrderDate = TestDate.ToString();
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDate = TestDate.ToString();
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string OrderDate = TestDate.ToString();
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string OrderDate = TestDate.ToString();
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string OrderDate = "This is not a date!";
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TrainerDescriptionMinLessOne()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string TrainerDescription = "";
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TrainerDescriptionMin()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string TrainerDescription = "a";
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrainerDescriptionMinPlusOne()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string TrainerDescription = "aa";
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrainerDescriptionMaxLessOne()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string TrainerDescription = "";
            TrainerDescription = TrainerDescription.PadRight(49, 'a');
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrainerDescriptionMax()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string TrainerDescription = "";
            TrainerDescription = TrainerDescription.PadRight(50, 'a');
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrainerDescriptionMaxPlusOne()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string TrainerDescription = "";
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TrainerDescriptionMid()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string TrainerDescription = "";
            TrainerDescription = TrainerDescription.PadRight(25, 'a');
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMinLessOne()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string TotalAmount = "";
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMin()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string TotalAmount = "1";
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMinPlusOne()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string TotalAmount = "11";
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMaxLessOne()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string TotalAmount = "11111111";
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void TotalAmountMax()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string TotalAmount = "111111111";
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void TotalAmountMaxPlusOne()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string TotalAmount = "1111111111";
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void TotalAmountMid()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String Error = "";
            string TotalAmount = "1111";
            Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
            Assert.AreEqual(Error, "");
        }
    }
    }



