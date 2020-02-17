using System;
using FireKicksClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FireKicksTesting
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock AnStock = new clsStock();
            Assert.IsNotNull(AnStock);
        }
    }
}
