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
        Response.Redirect("CustomerList.aspx");
    }

    protected void OkButton_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the customer name
        string CustomerName = txtCustomerName.Text;
        //capture the customer email
        string CustomerEmail = txtCustomerEmail.Text;
        //capture the customer password
        string CustomerPassword = txtCustomerPassword.Text;
        //capture the customer address
        string CustomerAddress = txtCustomerAddress.Text;
        //capture the customer dob
        string CustomerDOB = txtCustomerDob.Text;
        //validate the data
        string Error = "";
        Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerDOB);
        if (Error == "")
        {

            ACustomer.CustomerID = CustomerID;
            ACustomer.CustomerName = CustomerName;
            ACustomer.CustomerEmail = CustomerEmail;
            ACustomer.CustomerPassword = CustomerPassword;
            ACustomer.CustomerAddress = CustomerAddress;
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
            //display the error message
            lblError.Text = "There were problems with the data entered. "+ Error;
        }
    }

    protected void FindButton_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = ACustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
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