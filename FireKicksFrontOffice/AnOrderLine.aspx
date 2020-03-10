<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrderLine.aspx.cs" Inherits="AnOrderLine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            OrderLineID
            <asp:TextBox ID="txtOrderLineID" runat="server"></asp:TextBox>
            <br />
            OrderID <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
            <br />
            ProductID
            <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
            <br />
            Quantity
            <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnOk" runat="server" Text="Ok" OnClick="btnOk_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
