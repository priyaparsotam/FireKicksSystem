using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainerClasses;

namespace TrainerTesting
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void ReceiveMailPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean TestData = true;
            ACustomer.ReceiveMail = TestData;
            Assert.AreEqual(ACustomer.ReceiveMail, TestData);
        }

        [TestMethod]
        public void CustomerDOBPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.CustomerDOB = TestData;
            Assert.AreEqual(ACustomer.CustomerDOB, TestData);
        }

        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "19";
            ACustomer.CustomerAddress = TestData;
            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }

        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "p";
            ACustomer.CustomerName = TestData;
            Assert.AreEqual(ACustomer.CustomerName, TestData);
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Y";
            ACustomer.CustomerEmail = TestData;
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void CustomerPasswordPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Y";
            ACustomer.CustomerPassword = TestData;
            Assert.AreEqual(ACustomer.CustomerPassword, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Int32 TestData = 1;
            ACustomer.CustomerID = TestData;
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerDOBFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerDOB != Convert.ToDateTime("2/5/1999"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerName != "Ignatius")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerEmail != "stupid@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerAddress != "19")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPasswordFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerPassword != "123")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReceiveMailFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.ReceiveMail != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}

