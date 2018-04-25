
<%@ Page Language="VB" AutoEventWireup="false" CodeFile="lx1-1.aspx.vb" Inherits="lx1_1" %>

<!DOCTYPE html>
<!--这是一行注释-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>我的第一个网页</title>
    <style type="text/css">
        .auto-style1 {
            width: 1441px;
            height: 1080px;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Hello World</div>
        <asp:Button ID="Btn1" runat="server" Text="Surprise!" />
        <br />
        <p>
            <asp:Label ID="lbl_page" runat="server" Text="What hides?"></asp:Label>
            <asp:Label ID="lb2_page" runat="server" Text="What hides?"></asp:Label>
        </p>
        <a href ="lx1-2.aspx">Page2</a>
        <a href ="TB.Text">1</a>
        <p>
            <asp:TextBox ID="TB1" runat="server" Width="185px"></asp:TextBox>
        </p>
        <p>
        <asp:Button ID="Btn2" runat="server" Text="OK" Height="27px" />
        </p>
        <asp:Button ID="Button1" runat="server" Text="Img" />
        <br />
        <div>
            <a href ="wy.html">望岳</a>
        </div>
        
    </form>
    
</body>
</html>
