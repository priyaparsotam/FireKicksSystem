using FireKicksClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnOrderProcessing : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            if (OrderID != -1)
            {
                DisplayOrders();
            }
        }
    }

    //clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
    //AnOrderProcessing = (clsOrderProcessing)Session["AnOrderProcessing"];
    //Response.Write(AnOrderProcessing.OrderID);
    void DisplayOrders()
    {
        clsOrderProcessingCollection OrderBook = new clsOrderProcessingCollection();
        OrderBook.ThisOrderProcessing.Find(OrderID);
        txtOrderID.Text = OrderBook.ThisOrderProcessing.OrderID.ToString();
        txtCustomerID.Text = OrderBook.ThisOrderProcessing.CustomerID.ToString();
        txtOrderDate.Text = OrderBook.ThisOrderProcessing.OrderDate.ToString();
        txtTrainerDescription.Text = OrderBook.ThisOrderProcessing.TrainerDescription;
        txtTotalAmount.Text = OrderBook.ThisOrderProcessing.TotalAmount.ToString();
        chkbxDispatched.Text = OrderBook.ThisOrderProcessing.Dispatched.ToString();
    }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void T_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TxtCustomerID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();

        string CustomerID = txtCustomerID.Text;
        string OrderDate = txtOrderDate.Text;
        string TrainerDescription = txtTrainerDescription.Text;
        string TotalAmount = txtTotalAmount.Text;

        string Error = "";
        Error = AnOrderProcessing.Valid(CustomerID, OrderDate, TrainerDescription, TotalAmount);
        if (Error == "")
        {
            AnOrderProcessing.OrderID = Convert.ToInt32(txtOrderID.Text);
            AnOrderProcessing.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            AnOrderProcessing.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
            AnOrderProcessing.TrainerDescription = txtTrainerDescription.Text;
            AnOrderProcessing.TotalAmount = Convert.ToDouble(txtTotalAmount.Text);
            clsOrderProcessingCollection OrderProcessingList = new clsOrderProcessingCollection();

            if (OrderID == -1)
            {
                OrderProcessingList.ThisOrderProcessing = AnOrderProcessing;
                OrderProcessingList.Add();
            }
            else
            {
                OrderProcessingList.ThisOrderProcessing.Find(OrderID);
                OrderProcessingList.ThisOrderProcessing = AnOrderProcessing;
                OrderProcessingList.Update();
            }

            Response.Redirect("OrderProcessingList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
        Int32 OrderID;
        Boolean Found = false;
        OrderID = Convert.ToInt32(txtOrderID.Text);
        Found = AnOrderProcessing.Find(OrderID);

        if (Found == true)
        {
            txtCustomerID.Text = Convert.ToString(AnOrderProcessing.CustomerID);
            txtOrderDate.Text = AnOrderProcessing.OrderDate.ToString();
            txtTrainerDescription.Text = Convert.ToString(AnOrderProcessing.TrainerDescription);
            txtTotalAmount.Text = Convert.ToString(AnOrderProcessing.TotalAmount);
           

}
    }
}