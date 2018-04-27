<%@ Page Language="VB" AutoEventWireup="false" CodeFile="lx4-1-2.aspx.vb" Inherits="homework_lx4_1_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../css/mycss.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>用户登陆</p>
            <div style="float:left">
                <p>用户名：</p>
                <p>密码：</p>
                <p>验证码(区分大小写)：</p>
                <p><asp:Button ID="btn" runat ="server" Text="确定" /></p>
            </div>
            <div style="left">
                <p>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </p>
                <p>
                    <asp:TextBox ID="TextBox1" runat="server" TextMode ="Password"></asp:TextBox>
                </p>
                <p> 
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:Label ID="Label1" runat ="server"></asp:Label>
                    <asp:Button ID="btn2" runat="server" Text="换一张" CssClass="btnclass" />
                </p>
                <p>
                    <asp:Label ID="Label2" runat ="server"></asp:Label>
                </p>
            </div>
        </div>
    </form>
</body>
</html>
