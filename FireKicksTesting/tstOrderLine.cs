using System;
using FireKicksClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FireKicksTesting
{
    [TestClass]
    public class tstOrderLine
    {
        string OrderLineID = "1";
        string OrderID = "1";
        string ProductID = "121";
        string Quantity = "4";

        [TestMethod]
        public void InstanceOk()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Assert.IsNotNull(AnOrderLine);
        }

        [TestMethod]
        public void OrderLineIDOk()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.OrderLineID = TestData;
            Assert.AreEqual(AnOrderLine.OrderLineID, TestData);
        }

        [TestMethod]
        public void OrderIDOk()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.OrderID = TestData;
            Assert.AreEqual(AnOrderLine.OrderID, TestData);
        }

        [TestMethod]
        public void ProductIDOk()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.ProductID = TestData;
            Assert.AreEqual(AnOrderLine.ProductID, TestData);
        }

        [TestMethod]
        public void QuantityOk()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.Quantity = TestData;
            Assert.AreEqual(AnOrderLine.Quantity, TestData);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Int32 OrderLineID = 1;
            Found = AnOrderLine.Find(OrderLineID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderLineIDFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderLineID = 1;
            Found = AnOrderLine.Find(OrderLineID);
            if (AnOrderLine.OrderLineID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderLineID = 1;
            Found = AnOrderLine.Find(OrderLineID);
            if (AnOrderLine.OrderID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductIDFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderLineID = 1;
            Found = AnOrderLine.Find(OrderLineID);
            if (AnOrderLine.ProductID != 121)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderLineID = 1;
            Found = AnOrderLine.Find(OrderLineID);
            if (AnOrderLine.Quantity != 4)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMinLessOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "";
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMin()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "1";
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderIDMinPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "11";
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderIDMaxLessOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "11111";
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderIDMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "111111";
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMid()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "111";
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMaxPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "1111111";
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDExtremeMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "";
            OrderID = OrderID.PadRight(500, '1');
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMinLessOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string ProductID = "";
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMin()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string ProductID = "1";
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ProductIDMinPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string ProductID = "11";
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ProductIDMaxLessOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string ProductID = "11111";
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ProductIDMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string ProductID = "111111";
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMid()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string ProductID = "111";
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMaxPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string ProductID = "1111111";
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDExtremeMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string ProductID = "";
            ProductID = ProductID.PadRight(500, '1');
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void QuantityMinLessOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "";
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "1";
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void QuantityMinPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "11";
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void QuantityMaxLessOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "11111";
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void QuantityMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "111111";
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "111";
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "1111111";
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "";
            Quantity = Quantity.PadRight(500, '1');
            Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
            Assert.AreNotEqual(Error, "");
        }

    }
}
