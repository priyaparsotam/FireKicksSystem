<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 24px; top: 346px; position: absolute; height: 26px" Text="Add" />
            <asp:ListBox ID="lstCustomerList" runat="server" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 312px; width: 341px"></asp:ListBox>
        </div>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 83px; position: absolute; top: 347px; right: 140px" Text="Delete" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 33px; top: 388px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 167px; top: 347px; position: absolute" Text="Edit" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 66px; top: 449px; position: absolute; right: 1136px" Text="Enter a name"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 231px; top: 448px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 138px; top: 504px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 307px; top: 504px; position: absolute" Text="Clear" />
    </form>
</body>
</html>
