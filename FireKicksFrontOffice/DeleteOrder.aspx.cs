﻿using FireKicksClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteOrder : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderProcessingCollection OrderBook = new clsOrderProcessingCollection();
        OrderBook.ThisOrderProcessing.Find(OrderID);
        OrderBook.Delete();
        Response.Redirect("OrderProcessingList.aspx");

    }
}