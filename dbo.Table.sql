CREATE TABLE [dbo].[tblCustomer]
(
	[CustomerID] INT NOT NULL PRIMARY KEY, 
    [CustomerName] TEXT NULL, 
    [CustomerEmail] TEXT NULL, 
    [CustomerPassword] TEXT NULL, 
    [CustomerAddress] TEXT NULL, 
    [CustomerDOB] DATE NULL, 
    [ReveicerMail] BIT NULL
)
