<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteCustomer.aspx.cs" Inherits="DeleteCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 99px">
            Are you sure you want to delete this record?<br />
            <br />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 20px; top: 70px; position: absolute; height: 34px; width: 61px;" Text="Yes" />
        </div>
        <p>
            <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 88px; top: 70px; position: absolute; height: 34px; width: 61px; bottom: 584px;" Text="No" OnClick="btnNo_Click" />
        </p>
    </form>
</body>
</html>
