<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomerList" runat="server" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 312px; width: 341px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
