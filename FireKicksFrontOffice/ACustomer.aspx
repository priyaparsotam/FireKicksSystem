<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnOK" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 165px; top: 505px; position: absolute; height: 25px; width: 33px;" Text="OK" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 88px; top: 188px; position: absolute" Text="CustomerID"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 71px; top: 232px; position: absolute" Text="CustomerName"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 77px; top: 272px; position: absolute" Text="CustomerEmail"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 55px; top: 325px; position: absolute" Text="CustomerPassword"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 199px; top: 187px; position: absolute; height: 22px;"></asp:TextBox>
        <asp:TextBox ID="txtCustomerEmail" runat="server" style="z-index: 1; left: 196px; top: 280px; position: absolute; height: 18px; width: 131px;"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 200px; top: 235px; position: absolute"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtCustomerPassword" runat="server" style="z-index: 1; left: 196px; top: 324px; position: absolute"></asp:TextBox>
        <p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 498px; position: absolute; right: 1123px; height: 26px;" Text="Cancel" OnClick="CancelButton_Click" />
        </p>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 69px; top: 373px; position: absolute" Text="Customer D.O.B"></asp:Label>
        <asp:TextBox ID="txtCustomerDob" runat="server" style="z-index: 1; top: 367px; position: absolute; left: 197px"></asp:TextBox>
        <asp:CheckBox ID="ReceiveMail" runat="server" style="z-index: 1; left: 438px; top: 445px; position: absolute" />
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 68px; top: 424px; position: absolute" Text="Customer Address"></asp:Label>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 214px; top: 502px; position: absolute" Text="cancel" />
    </form>
</body>
</html>
