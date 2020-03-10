<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrderProcessing.aspx.cs" Inherits="AnOrderProcessing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        OrderID<asp:TextBox ID="txtOrderID" runat="server" style="margin-left: 36px" Width="201px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <br />
        CustomerID<asp:TextBox ID="txtCustomerID" runat="server" style="margin-left: 13px" Width="204px" OnTextChanged="TxtCustomerID_TextChanged"></asp:TextBox>
        <br />
        OrderDate<asp:TextBox ID="txtOrderDate" runat="server" OnTextChanged="T_TextChanged" style="margin-left: 24px" Width="200px"></asp:TextBox>
        <br />
        TrainerDescription <asp:TextBox ID="txtTrainerDescription" runat="server" style="margin-left: 19px" Width="254px"></asp:TextBox>
        <br />
        TotalAmount
        <asp:TextBox ID="txtTotalAmount" runat="server" style="margin-left: 20px" Width="222px"></asp:TextBox>
        <br />
&nbsp;<asp:CheckBox ID="chkbxDispatched" runat="server" Text="Dispatched" />
        <br />
        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
