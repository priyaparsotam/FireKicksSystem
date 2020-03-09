using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainerClasses;

public partial class ACustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        ACustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");
    }

   
}