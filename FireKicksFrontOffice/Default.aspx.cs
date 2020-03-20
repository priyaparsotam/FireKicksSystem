using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        //FireKicksClasses.clsCustomerCollection Customers = new FireKicksClasses.clsCustomerCollection();
        //lstCustomerList.DataSource = Customers.CustomerList;
        //lstCustomerList.DataValueField = "CustomerNo";
        //lstCustomerList.DataTextField = "CustomerName";
        //lstCustomerList.DataBind();
         


    }
}