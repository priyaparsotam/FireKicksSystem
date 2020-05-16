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
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 89px; top: 187px; position: absolute; height: 27px; width: 145px;" Text="Customer ID"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 88px; top: 246px; position: absolute; height: 24px; width: 157px;" Text="Customer Name"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 89px; top: 291px; position: absolute; height: 28px; width: 188px;" Text="Customer Email"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 88px; top: 329px; position: absolute; height: 27px; width: 212px; bottom: 332px;" Text="Customer Password"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 315px; top: 185px; position: absolute; height: 27px; width: 190px;"></asp:TextBox>
        <asp:TextBox ID="txtCustomerEmail" runat="server" style="z-index: 1; left: 312px; top: 285px; position: absolute; height: 27px; width: 190px;"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 313px; top: 235px; position: absolute; width: 190px; height: 27px;"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtCustomerPassword" runat="server" style="z-index: 1; left: 313px; top: 326px; position: absolute; width: 190px; height: 27px;"></asp:TextBox>
        <p>
            <asp:Button ID="FindButton" runat="server" OnClick="FindButton_Click" style="z-index: 1; left: 544px; top: 179px; position: absolute; height: 31px; width: 82px;" Text="Find" />
        </p>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 69px; top: 373px; position: absolute; height: 28px; width: 190px; right: 1537px;" Text="Customer D.O.B"></asp:Label>
        <asp:TextBox ID="txtCustomerDob" runat="server" style="z-index: 1; top: 369px; position: absolute; left: 312px; width: 190px; height: 27px;"></asp:TextBox>
        <asp:CheckBox ID="chkReceiveMail" runat="server" style="z-index: 1; left: 72px; top: 481px; position: absolute; height: 17px;" Text="Receive Mail" />
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 68px; top: 424px; position: absolute" Text="Customer Address"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="CancelButton" runat="server" OnClick="CancelButton_Click" style="z-index: 1; left: 242px; top: 588px; position: absolute; height: 38px; width: 84px; right: 1470px;" Text="Cancel" />
        <asp:Button ID="OkButton" runat="server" OnClick="OkButton_Click" style="z-index: 1; left: 152px; top: 589px; position: absolute; width: 70px; height: 36px;" Text="Ok" />
        <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; left: 312px; top: 420px; position: absolute; width: 190px; height: 27px;"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 82px; top: 541px; position: absolute"></asp:Label>
    </form>
</body>
</html>
