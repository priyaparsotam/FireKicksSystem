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
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Shin Yi Yap";
            TestItem.CustomerEmail = "shinyi0408@gmail.com";
            TestItem.CustomerPassword = "123";
            TestItem.CustomerAddress = "19";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.ReceiveMail = true;
            //set ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Shin Yi";
            TestItem.CustomerEmail = "shinyi0408@gmail.com";
            TestItem.CustomerPassword = "123";
            TestItem.CustomerAddress = "19";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.ReceiveMail = true;
            //set ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomer.Delete();
            //now find the record
            Boolean Found = AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            TestItem.CustomerID = 2;
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
        public void ReportByCustomerNameMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            FilteredCustomer.ReportByCustomerName("");
            Assert.AreEqual(AllCustomer.Count, FilteredCustomer.Count);
        }


        [TestMethod]
        public void ReportByCustomerNameNoneMethodOK()
        {
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            FilteredCustomer.ReportByCustomerName("xxx xxx");
            Assert.AreEqual(0, FilteredCustomer.Count);
        }

        [TestMethod]
        public void ReportByCustomerNameTestDataFound()
        {
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            Boolean OK = true;
            FilteredCustomer.ReportByCustomerName("Ignatius");
            if (FilteredCustomer.Count == 2)
            {
                if (FilteredCustomer.CustomerList[0].CustomerID != 51)
                {
                    OK = false;
                }
                if (FilteredCustomer.CustomerList[1].CustomerID != 154)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



    }
}


