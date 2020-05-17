﻿using FireKicksClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnOrderLine : System.Web.UI.Page
{
    Int32 OrderLineID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderLineID = Convert.ToInt32(Session["OrderLineID"]);
        if (IsPostBack == false)
        {
            if (OrderLineID != -1)
            {
                DisplayOrderLine();
            }
        }
    }
    void DisplayOrderLine()
    {
        clsOrderLineCollection OrderLineBook = new clsOrderLineCollection();
        OrderLineBook.ThisOrderLine.Find(OrderLineID);
        txtOrderLineID.Text = OrderLineBook.ThisOrderLine.OrderLineID.ToString();
        txtOrderID.Text = OrderLineBook.ThisOrderLine.OrderID.ToString();
        txtProductID.Text = OrderLineBook.ThisOrderLine.ProductID.ToString();
        txtQuantity.Text = OrderLineBook.ThisOrderLine.Quantity.ToString();
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsOrderLine AnOrderLine = new clsOrderLine();
        string OrderID = txtOrderID.Text;
        string ProductID = txtProductID.Text;
        string Quantity = txtQuantity.Text;
        string Error = "";
        Error = AnOrderLine.Valid(OrderID, ProductID, Quantity);
        if (Error == "")
        {
         
            AnOrderLine.OrderID = Convert.ToInt32(OrderID);
            AnOrderLine.ProductID = Convert.ToInt32(ProductID);
            AnOrderLine.Quantity = Convert.ToInt32(Quantity);
            clsOrderLineCollection OrderLineList = new clsOrderLineCollection();
            if (OrderLineID == -1)
            {
                OrderLineList.ThisOrderLine = AnOrderLine;
                OrderLineList.Add();
            }
            else
            {
                OrderLineList.ThisOrderLine.Find(OrderLineID);
                OrderLineList.ThisOrderLine = AnOrderLine;
                OrderLineList.Update();
            }
            Response.Redirect("OrderLineList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrderLine AnOrderLine = new clsOrderLine();
        Int32 OrderLineID;
        Boolean Found = false;
        OrderLineID = Convert.ToInt32(txtOrderLineID.Text);
        Found = AnOrderLine.Find(OrderLineID);
        if (Found == true)
        {
            txtOrderLineID.Text = Convert.ToString(AnOrderLine.OrderLineID);
            txtOrderID.Text = Convert.ToString(AnOrderLine.OrderID);
            txtProductID.Text = Convert.ToString(AnOrderLine.ProductID);
            txtQuantity.Text = Convert.ToString(AnOrderLine.Quantity);

        }
    }
}