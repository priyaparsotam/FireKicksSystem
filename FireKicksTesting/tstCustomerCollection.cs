using FireKicksClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FireKicksTesting
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomer);

        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Shin Yi";
            TestItem.CustomerEmail = "shinyi0408@gmail.com";
            TestItem.CustomerPassword = "123";
            TestItem.CustomerAddress = "19";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllCustomer.CustomerList = TestList;
            Assert.AreEqual(AllCustomer.CustomerList, TestList);


        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            Int32 SomeCount = 3;
            AllCustomer.Count = SomeCount;
            Assert.AreEqual(AllCustomer.Count, SomeCount);
        }
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.CustomerID = 1;
            TestCustomer.CustomerName = "Shin Yi";
            TestCustomer.CustomerEmail = "shinyi0408@gmail.com";
            TestCustomer.CustomerPassword = "123";
            TestCustomer.CustomerAddress = "19";
            TestCustomer.CustomerDOB = DateTime.Now.Date;
            AllCustomer.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Shin Yi";
            TestItem.CustomerEmail = "shinyi0408@gmail.com";
            TestItem.CustomerPassword = "123";
            TestItem.CustomerAddress = "19";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllCustomer.CustomerList = TestList;
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            Assert.AreEqual(AllCustomer.Count, 2);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Shin Yi";
            TestItem.CustomerEmail = "shinyi0408@gmail.com";
            TestItem.CustomerPassword = "123";
            TestItem.CustomerAddress = "19";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.ReceiveMail = true;
            AllCustomer.ThisCustomer = TestItem;
            PrimaryKey = AllCustomer.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Shin Yi";
            TestItem.CustomerEmail = "shinyi0408@gmail.com";
            TestItem.CustomerPassword = "123";
            TestItem.CustomerAddress = "19";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.ReceiveMail = true;
            AllCustomer.ThisCustomer = TestItem;
            PrimaryKey = AllCustomer.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            AllCustomer.Delete();
            Boolean Found = AllCustomer.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Shin Yi";
            TestItem.CustomerEmail = "shinyi0408@gmail.com";
            TestItem.CustomerPassword = "123";
            TestItem.CustomerAddress = "19";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.ReceiveMail = true;
            AllCustomer.ThisCustomer = TestItem;
            PrimaryKey = AllCustomer.Add();
            TestItem.CustomerID = PrimaryKey;
            TestItem.CustomerID = 2;
            TestItem.CustomerName = "Shin Yi";
            TestItem.CustomerEmail = "qwer0408@gmail.com";
            TestItem.CustomerPassword = "3";
            TestItem.CustomerAddress = "123";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.ReceiveMail = false;
            AllCustomer.ThisCustomer = TestItem;
            AllCustomer.Update();
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void FilterMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            FilteredCustomer.Filter("");
            Assert.AreEqual(AllCustomer.Count, FilteredCustomer.Count);
        }

        [TestMethod]
        public void FilterNoneFound()
        {
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            FilteredCustomer.Filter("xxx xxx");
            Assert.AreEqual(0, FilteredCustomer.Count);
        }
    }
}


