using FireKicksClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnOrderLine : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsOrderLine AnOrderLine = new clsOrderLine();
        AnOrderLine.OrderLineID = Convert.ToInt32(txtOrderLineID.Text);
        AnOrderLine.OrderID = Convert.ToInt32(txtOrderID.Text);
        AnOrderLine.ProductID = Convert.ToInt32(txtProductID.Text);
        AnOrderLine.Quantity = Convert.ToInt32(txtQuantity.Text);
        Session["AnOrderLine"] = AnOrderLine;
        Response.Write("OrderLineViewer.aspx");
    }
}