<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 37px; top: 350px; position: absolute; height: 38px; margin-right: 0px;" Text="Add" />
            <asp:ListBox ID="lstCustomerList" runat="server" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 312px; width: 341px; bottom: 361px;"></asp:ListBox>
        </div>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 95px; position: absolute; top: 350px; right: 1616px; height: 39px;" Text="Delete" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 528px; position: absolute"></asp:Label>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 179px; top: 349px; position: absolute; height: 39px; width: 86px; right: 1531px;" Text="Edit" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 59px; top: 423px; position: absolute" Text="Enter a name"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 210px; top: 420px; position: absolute; height: 35px; width: 169px;"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 138px; top: 479px; position: absolute; height: 35px; width: 82px; right: 1576px;" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 222px; top: 478px; position: absolute; height: 35px; width: 82px;" Text="Clear" />
    </form>
</body>
</html>
