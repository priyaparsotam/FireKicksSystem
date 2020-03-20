﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingList.aspx.cs" Inherits="OrderProcessingList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 638px; width: 1484px;">
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderProcessingList" runat="server" Height="375px" OnSelectedIndexChanged="lstOrderProcessingList_SelectedIndexChanged" Width="381px" style="margin-top: 68px"></asp:ListBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        &nbsp;&nbsp;
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <br />
            Enter Trainer Description&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </div>
    </form>
</body>
</html>