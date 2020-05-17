using FireKicksClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace FireKicksClasses { 
    public class clsCustomer
    {
        //private data member for ReceiveMail property
        private Boolean mReceiveMail;
        //public property for the Receive Mail
        public bool ReceiveMail
        {
            get
            {
                //return the private data
                return mReceiveMail;
            }
            set
            {
                //set the private data
                mReceiveMail = value;
            }
        }

        //private data member for CustomerDOB property
        private DateTime mCustomerDOB;
        //public property for the customer D.O.B
        public DateTime CustomerDOB
        {
            get
            {
                //return the private data
                return mCustomerDOB;
            }

            set
            {
                //set the private data
                mCustomerDOB = value;
            }
        }

        //private data member for the CustomerAddress property
        private String mCustomerAddress;
        //public property for the customer address
        public string CustomerAddress
        {
            get
            {
                //return the private data
                return mCustomerAddress;
            }
            set
            {
                //set the private data
                mCustomerAddress = value;
            }
        }

        //private data member for the CustomerName property
        private String mCustomerName;
        //public property for the customer name
        public string CustomerName
        {
            get
            {
                //return the private data
                return mCustomerName;

            }
            set
            {
                //set the private data
                mCustomerName = value;
            }
        }

        //private data member for the CustomerEmail property
        private String mCustomerEmail;
        //public property for the customer email
        public string CustomerEmail
        {
            get
            {
                //return the private data
                return mCustomerEmail;
            }
            set
            {
                //set the private data
                mCustomerEmail = value;
            }
        }

        //private data member for the CustomerPassword property
        private String mCustomerPassword;
        //public property for the customer password
        public string CustomerPassword
        {
            get
            {
                //return the private data
                return mCustomerPassword;
            }
            set
            {
                //set the private data
                mCustomerPassword = value;
            }
        }

        //private data member for the CustomerID property
        private Int32 mCustomerID;
        //public property for the customer id
        public Int32 CustomerID
        {
            get
            {
                //return the private data
                return mCustomerID;
            }
            set
            {
                //set the private data
                mCustomerID = value;
            }

        }

        public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found(there should either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerPassword = Convert.ToString(DB.DataTable.Rows[0]["CustomerPassword"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mCustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDOB"]);
                mReceiveMail = Convert.ToBoolean(DB.DataTable.Rows[0]["ReceiveMail"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        //function for the public validation method
        public string Valid(string CustomerName, 
                            string CustomerEmail, 
                            string CustomerPassword, 
                            string CustomerAddress, 
                            DateTime CustomerDOB)
        {
            return "";
        }

        public string Valid(string customerName, string customerEmail, string customerPassword, string customerAddress, string customerDOB)
        {
            //create a string variable to store the error
            String Error= "";
            DateTime DateTemp;
            //if the customerName is blank
            if (customerName.Length==0)
            {
                Error = Error + "The Customer Name may not be blank : ";
            }
            //if the customerName is more than 51 characters
            if (customerName.Length > 51)
            {
                Error = Error + "The Customer must be less than 51 characters : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(customerDOB);
                if (DateTemp > DateTime.Now.Date.AddYears(-18))
                {
                    Error = Error + "You are too young , must be age 18 : ";
                }
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    //record the error
                    Error = Error + "The date cannot be less than 100 years : ";
                }

            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }

            //if the customerEmail is blank
            if (customerEmail.Length == 0)
            {
                //record the error
                Error = Error + "The email may not be blank : ";
            }
            //if the customerEmail is more than 50 characters
            if (customerEmail.Length > 50)
            {
                //record the error
                Error = Error + "The email must be less than 50 characters : ";
            }

            //if the customerPassword is empty
            if (customerPassword.Length == 0)
            {
                //record the error
                Error = Error + "The password may not be blank : ";
            }
            //if the customerPassword is too long
            if (customerPassword.Length > 50)
            {
                //record the error
                Error = Error + "The password must be less than 50 characters : ";
            }
            //if the customerAddress is empty
            if (customerAddress.Length == 0)
            {
                //record the error
                Error = Error + "The address may not be blank : ";
            }
            //if the customerAddress is too long
            if (customerAddress.Length > 50)
            {
                //record the error
                Error = Error + "The address must be less than 50 characters : ";
            }


            return Error;

        }
    }
}