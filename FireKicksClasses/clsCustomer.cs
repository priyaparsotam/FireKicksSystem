using FireKicksClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace FireKicksClasses { 
    public class clsCustomer
    {
        
        private Boolean mReceiveMail;
        public bool ReceiveMail
        {
            get
            {
                return mReceiveMail;
            }
            set
            {
                mReceiveMail = value;
            }
        }
        private DateTime mCustomerDOB;
        public DateTime CustomerDOB
        {
            get
            {
                return mCustomerDOB;
            }

            set
            {
                mCustomerDOB = value;
            }
        }

        private String mCustomerAddress;
        public string CustomerAddress
        {
            get
            {
                return mCustomerAddress;
            }
            set
            {
                mCustomerAddress = value;
            }
        }

        private String mCustomerName;
        public string CustomerName
        {
            get
            {
                return mCustomerName;

            }
            set
            {
                mCustomerName = value;
            }
        }

        private String mCustomerEmail;
        public string CustomerEmail
        {
            get
            {
                return mCustomerEmail;
            }
            set
            {
                mCustomerEmail = value;
            }
        }

        private String mCustomerPassword;
        public string CustomerPassword
        {
            get
            {
                return mCustomerPassword;
            }
            set
            {
                mCustomerPassword = value;
            }
        }

        //CustomerID private member variable
        private Int32 mCustomerID;
        public Int32 CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }

        }
        public bool Find(int CustomerID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", CustomerID);
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            if (DB.Count == 1)
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerPassword = Convert.ToString(DB.DataTable.Rows[0]["CustomerPassword"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mCustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDOB"]);
                mReceiveMail = Convert.ToBoolean(DB.DataTable.Rows[0]["ReceiveMail"]);

                return true;
            }
            else
            {
                return false;
            }
        }

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
            String Error= "";
            DateTime DateTemp;
            if (customerName.Length==0)
            {
                Error = Error + "The Customer Name may not be blank : ";
            }
            if (customerName.Length > 51)
            {
                Error = Error + "The Customer must be less than 51 characters : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(customerDOB);
                //if (DateTemp < DateTime.Now.Date)
                //{
                //    Error = Error + "The date cannot be in the past : ";
                //}
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date";
            }
            if (customerEmail.Length == 0)
            {
                //record the error
                Error = Error + "The email may not be blank : ";
            }
            //if the street is too long
            if (customerEmail.Length > 50)
            {
                //record the error
                Error = Error + "The email must be less than 50 characters : ";
            }
            if (customerPassword.Length == 0)
            {
                //record the error
                Error = Error + "The password may not be blank : ";
            }
            //if the town is too long
            if (customerPassword.Length > 50)
            {
                //record the error
                Error = Error + "The password must be less than 50 characters : ";
            }
            if (customerAddress.Length == 0)
            {
                //record the error
                Error = Error + "The address may not be blank : ";
            }
            //if the town is too long
            if (customerAddress.Length > 50)
            {
                //record the error
                Error = Error + "The address must be less than 50 characters : ";
            }


            return Error;

        }
    }
}