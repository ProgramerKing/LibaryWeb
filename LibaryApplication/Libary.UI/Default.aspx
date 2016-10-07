<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Libary.UI.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>书籍编号</td>
            <td>书籍名称</td>
            <td>数据作者</td>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <td><%# Eval("Id") %></td>
                <td><%# Eval("Title") %></td>
                <td><%# Eval("Author") %></td>
            </tr>
            </ItemTemplate>

        </asp:Repeater>
    </table>
    </div>
    </form>
</body>
</html>
