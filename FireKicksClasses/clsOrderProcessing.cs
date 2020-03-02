using System;

namespace FireKicksClasses
{
    public class clsOrderProcessing
    {
       
        public bool Dispatched { get; set; }
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
    }
}