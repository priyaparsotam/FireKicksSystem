using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderProcessingList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
    }
    void DisplayOrders()
    {
        FireKicksClasses.clsOrderProcessingCollection Orders = new FireKicksClasses.clsOrderProcessingCollection();
        lstOrderProcessingList.DataSource = Orders.OrderProcessingList;
        lstOrderProcessingList.DataValueField = "OrderID";
        lstOrderProcessingList.DataTextField = "TotalAmount";
        lstOrderProcessingList.DataBind();
    }

    protected void lstOrderProcessingList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}