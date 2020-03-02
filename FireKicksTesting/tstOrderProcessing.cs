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
        public void OrderIDPropertyOK()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            int TestData = 1;
            AnOrderProcessing.OrderID = TestData;
            Assert.AreEqual(AnOrderProcessing.OrderID, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            int TestData = 1;
            AnOrderProcessing.CustomerID = TestData;
            Assert.AreEqual(AnOrderProcessing.CustomerID, TestData);
        }


        [TestMethod]
        public void DispatchedPropertyOk()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            Boolean TestData = true;
            AnOrderProcessing.Dispatched = TestData;
            Assert.AreEqual(AnOrderProcessing.Dispatched, TestData);

        }
    }
}
