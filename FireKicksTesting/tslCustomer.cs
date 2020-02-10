using System;
using FireKicksClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FireKicksTesting
{
    [TestClass]
    public class tslCustomer
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsCustomer acustomer = new clsCustomer();
            Assert.IsNotNull(acustomer);

        }
    }
}
