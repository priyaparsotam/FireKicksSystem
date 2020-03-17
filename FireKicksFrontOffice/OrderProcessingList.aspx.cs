using FireKicksClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderProcessingList : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            if (OrderID != -1)
                {
                DisplayOrders();
            }
        }
    }
    void DisplayOrders()
    {
        /*clsOrderProcessingCollection OrderBook = new clsOrderProcessingCollection();
        OrderBook.ThisOrderProcessing.Find(OrderID);
        txtOrderID.Text = OrderBook.ThisOrderProcessing.OrderID.ToString();
        txtCustomerID.Text = OrderBook.ThisOrderProcessing.CustomerID;
        txtOrderDate.Text = OrderBook.ThisOrderProcessing.OrderDate.ToString();
        txtTrainerDescription.Text = OrderBook.ThisOrderProcessing.TrainerDescription.ToString;
        txtTotalAmount.Text = OrderBook.ThisOrderProcessing.TotalAmount;
        txtDispatched.Text = OrderBook.ThisOrderProcessing.Dispatched;*/

        /*lstOrderProcessingList.DataSource = Orders.OrderProcessingList;
        lstOrderProcessingList.DataValueField = "OrderID";
        lstOrderProcessingList.DataTextField = "TotalAmount";
        lstOrderProcessingList.DataBind();*/
    }

    protected void lstOrderProcessingList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = -1;
        Response.Redirect("AnOrderProcessing.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if (lstOrderProcessingList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrderProcessingList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("DeleteOrder.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if (lstOrderProcessingList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrderProcessingList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("AnOrderProcessing.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}