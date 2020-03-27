using FireKicksClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class ACustomer : System.Web.UI.Page
{
    Int32 CustomerID;

    protected void Button1_Click1(object sender, EventArgs e)
    {

    }

    protected void CancelButton_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        ACustomer.CustomerName = txtCustomerName.Text;
        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void OkButton_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        string CustomerName = txtCustomerName.Text;
        string CustomerEmail = txtCustomerEmail.Text;
        string CustomerPassword = txtCustomerPassword.Text;
        string CustomerAddress = txtCustomerAddress.Text;
        string CustomerDOB = txtCustomerDob.Text;
        string Error = "";
        Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
        if (Error == "")
        {
            ACustomer.CustomerID = CustomerID;
            ACustomer.CustomerName = txtCustomerName.Text;
            ACustomer.CustomerEmail = txtCustomerEmail.Text;
            ACustomer.CustomerPassword = txtCustomerPassword.Text;
            ACustomer.CustomerAddress = txtCustomerAddress.Text;
            ACustomer.CustomerDOB = Convert.ToDateTime(CustomerDOB);
            ACustomer.ReceiveMail = chkReceiveMail.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            if (CustomerID == -1)
            {
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerID);
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Update();
            }
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void FindButton_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        Int32 CustomerID;
        Boolean Found = false;
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        Found = ACustomer.Find(CustomerID);
        if (Found == true)
        {
            txtCustomerEmail.Text = ACustomer.CustomerEmail;
            txtCustomerName.Text = ACustomer.CustomerName;
            txtCustomerPassword.Text = ACustomer.CustomerPassword;
            txtCustomerDob.Text = ACustomer.CustomerDOB.ToString();
            txtCustomerAddress.Text = ACustomer.CustomerAddress;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            if (CustomerID != -1)
            {
                DisplayCustomer();
            }
        }
    }

     void DisplayCustomer()
     {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ThisCustomer.Find(CustomerID);
        txtCustomerID.Text = CustomerBook.ThisCustomer.CustomerID.ToString();
        txtCustomerName.Text = CustomerBook.ThisCustomer.CustomerName;
        txtCustomerEmail.Text = CustomerBook.ThisCustomer.CustomerEmail;
        txtCustomerPassword.Text = CustomerBook.ThisCustomer.CustomerPassword;
        txtCustomerAddress.Text = CustomerBook.ThisCustomer.CustomerAddress;
        txtCustomerDob.Text = CustomerBook.ThisCustomer.CustomerDOB.ToString();
        chkReceiveMail.Checked = CustomerBook.ThisCustomer.ReceiveMail;
     }
}