using System;
using FireKicksClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FireKicksTesting
{
    [TestClass]
    public class tstOrderProcessing
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            Assert.IsNotNull(AnOrderProcessing);
        
        }
    }
}
