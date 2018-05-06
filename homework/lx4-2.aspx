<%@ Page Language="VB" AutoEventWireup="false" CodeFile="lx4-2.aspx.vb" Inherits="homework_lx4_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
            @font-face{
                src:url("../fonts/Ubuntu-M.ttf");
                font-family: Ubuntu-M;
            }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>第一步：输入个人信息：</h3>
            <ul style="list-style: none;">
                <li>学  号： <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </li>
                <li>姓  名： <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                </li>
                <li>验证码：<asp:TextBox ID="TextBox3" runat="server" style="font-family: Ubuntu-M, 'Courier New', Courier, monospace"></asp:TextBox>
                    <asp:Button ID="Button2" runat="server" Text="" />
                    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                </li>
                <li>专  业：
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>德语</asp:ListItem>
                        <asp:ListItem>统计学</asp:ListItem>
                        <asp:ListItem>计算机玄学与艺术</asp:ListItem>
                        <asp:ListItem>应用物理</asp:ListItem>
                    </asp:DropDownList>
                </li>
                <li>
                    <asp:Button ID="Button1" runat="server" Text="下一步" />
                </li>
            </ul>
        </div>
    </form>
</body>
</html>
