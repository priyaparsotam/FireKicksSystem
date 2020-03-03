using FireKicksClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnOrderProcessing : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
        //AnOrderProcessing = (clsOrderProcessing)Session["AnOrderProcessing"];
        Response.Write(AnOrderProcessing.OrderID);
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
        AnOrderProcessing.OrderID = Convert.ToInt32(txtOrderID.Text);
        AnOrderProcessing.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        AnOrderProcessing.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        AnOrderProcessing.TrainerDescription = txtTrainerDescription.Text;
        AnOrderProcessing.TotalAmount = Convert.ToDouble(txtTotalAmount.Text);

        Session["AnOrderProcessing"] = AnOrderProcessing;
        Response.Redirect("OrderProcessingViewer.aspx");
    
    }
}