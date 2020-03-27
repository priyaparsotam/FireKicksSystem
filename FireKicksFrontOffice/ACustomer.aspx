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
            <asp:Button ID="FindButton" runat="server" OnClick="FindButton_Click" style="z-index: 1; left: 367px; top: 186px; position: absolute; height: 26px;" Text="Find" />
        </p>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 69px; top: 373px; position: absolute" Text="Customer D.O.B"></asp:Label>
        <asp:TextBox ID="txtCustomerDob" runat="server" style="z-index: 1; top: 367px; position: absolute; left: 197px"></asp:TextBox>
        <asp:CheckBox ID="chkReceiveMail" runat="server" style="z-index: 1; left: 72px; top: 468px; position: absolute; height: 17px;" />
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 68px; top: 424px; position: absolute" Text="Customer Address"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="CancelButton" runat="server" OnClick="CancelButton_Click" style="z-index: 1; left: 252px; top: 501px; position: absolute; height: 25px; width: 62px" Text="Cancel" />
        <asp:Button ID="OkButton" runat="server" OnClick="OkButton_Click" style="z-index: 1; left: 140px; top: 503px; position: absolute; width: 31px;" Text="Ok" />
        <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; left: 199px; top: 420px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 254px; top: 466px; position: absolute" Text="lblError"></asp:Label>
    </form>
</body>
</html>
