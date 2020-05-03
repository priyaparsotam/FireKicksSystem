using FireKicksClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLineList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     if (IsPostBack == false)
        {
            DisplayOrderLine();
        }

    }

    void DisplayOrderLine()
    {
        FireKicksClasses.clsOrderLineCollection OrderLine = new FireKicksClasses.clsOrderLineCollection();
        lstOrderLineList.DataSource = OrderLine.OrderLineList;
        lstOrderLineList.DataValueField = "OrderLineID";
        lstOrderLineList.DataValueField = "OrderID";
        lstOrderLineList.DataBind();
    }

        protected void lstOrderLineList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderLineID"] = -1;
        Response.Redirect("AnOrderLine.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderLineID;
        if (lstOrderLineList.SelectedIndex != -1)
        {
            OrderLineID = Convert.ToInt32(lstOrderLineList.SelectedValue);
            Session["OrderLineID"] = OrderLineID;
            Response.Redirect("DeleteOrderLine.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderLineID;
        if (lstOrderLineList.SelectedIndex != -1)
        {
            OrderLineID = Convert.ToInt32(lstOrderLineList.SelectedValue);
            Session["OrderLineID"] = OrderLineID;
            Response.Redirect("AnOrderLine.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderLineCollection OrderLine = new clsOrderLineCollection();
        OrderLine.ReportbyOrderID(txtFilter.Text);
        lstOrderLineList.DataSource = OrderLine.OrderLineList;
        lstOrderLineList.DataValueField = "OrderLineID";
        lstOrderLineList.DataTextField = "OrderID";
        lstOrderLineList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderLineCollection OrderLine = new clsOrderLineCollection();
        OrderLine.ReportbyOrderID("");
        txtFilter.Text = "";
        lstOrderLineList.DataSource = OrderLine.OrderLineList;
        lstOrderLineList.DataValueField = "OrderLineID";
        lstOrderLineList.DataTextField = "OrderID";
        lstOrderLineList.DataBind();
    }
}