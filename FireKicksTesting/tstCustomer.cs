using System;
using FireKicksClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FireKicksTesting
{
    [TestClass]
    public class tstCustomer
    {
        //create some test data to pass to the method
        string CustomerName = "Shin Yi";
        string CustomerEmail = "shinyi0408@gmail.com";
        string CustomerPassword = "123";
        string CustomerAddress = "19";
        string CustomerDOB = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void ReceiveMailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACustomer.ReceiveMail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.ReceiveMail, TestData);
        }

        [TestMethod]
        public void CustomerDOBPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.CustomerDOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerDOB, TestData);
        }

        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "19";
            //assign the data to the property
            ACustomer.CustomerAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }

        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "p";
            //assign the data to the property
            ACustomer.CustomerName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerName, TestData);
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Y";
            //assign the data to the property
            ACustomer.CustomerEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void CustomerPasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Y";
            //assign the data to the property
            ACustomer.CustomerPassword = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerPassword, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.CustomerID != 2)
            {
                OK = false;
            }
            //test to see that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerDOBFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerDOB != Convert.ToDateTime("16/5/2020"))
            {
                OK = false;
            }
            //test to see that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerName != "Shin Yi")
            {
                OK = false;
            }
            //test to see that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerEmail != "qwer0408@gmail.com")
            {
                OK = false;
            }
            //test to see that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerAddress != "123")
            {
                OK = false;
            }
            //test to see that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPasswordFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerPassword != "3")
            {
                OK = false;
            }
            //test to see that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReceiveMailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.ReceiveMail != true)
            {
                OK = false;
            }
            //test to see that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //Create some test data to pass the method
            string CustomerName = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameNoMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "a";
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "aa";
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "aaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameNoMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "aaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "aaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(100, 'a');
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDOBExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string CustomerDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDOBMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string CustomerDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDOBMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string CustomerDOB = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //[TestMethod]
        //public void CustomerDOBMinPlusOne()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomer ACustomer = new clsCustomer();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create a variable to store the test date data
        //    DateTime TestDate;
        //    //set the date totodays date
        //    TestDate = DateTime.Now.Date;
        //    //change the date to whatever the date is plus 1 day
        //    TestDate = TestDate.AddDays(1);
        //    //convert the date variable to a string variable
        //    string CustomerDOB = TestDate.ToString();
        //    //invoke the method
        //    Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}

        //[TestMethod]
        //public void CustomerDOBExtremeMax()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomer ACustomer = new clsCustomer();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create a variable to store the test date data
        //    DateTime TestDate;
        //    //set the date totodays date
        //    TestDate = DateTime.Now.Date;
        //    //change the date to whatever the date is plus 100 years
        //    TestDate = TestDate.AddYears(100);
        //    //convert the date variable to a string variable
        //    string CustomerDOB = TestDate.ToString();
        //    //invoke the method
        //    Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}

        [TestMethod]
        public void CustomerDOBInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "Shin Yi";
            string CustomerEmail = "shinyi0408@gmail.com";
            string CustomerPassword = "123";
            string CustomerAddress = "19";
            //set the CustomerDOB to a non date value
            string CustomerDOB = "this is not a date!";
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerEmail = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "a";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "aa";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "aaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "aaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            CustomerEmail = CustomerEmail.PadRight(51, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "aaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerPassword = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPassword = "a";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPassword = "aa";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPassword = "";
            CustomerPassword = CustomerPassword.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPassword = "";
            CustomerPassword = CustomerPassword.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerPassword = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPassword = "";
            CustomerPassword = CustomerPassword.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerAddress = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "a";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "aa";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(51, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


    }
}

