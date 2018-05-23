<%@ Page Language="VB" AutoEventWireup="false" CodeFile="lx7-2.aspx.vb" Inherits="homework_lx7_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="T1" runat="server" Width="50%"></asp:TextBox>
            <asp:TextBox ID="TextBox1" runat="server" Width="50%"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" Width="50%"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" Width="50%"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server" Width="50%"></asp:TextBox>
            <asp:TextBox ID="TextBox5" runat="server" Width="50%"></asp:TextBox>
            <asp:TextBox ID="TextBox6" runat="server" Width="50%"></asp:TextBox>
            <asp:TextBox ID="TextBox7" runat="server" Width="50%"></asp:TextBox>
            <asp:TextBox ID="TextBox8" runat="server" Width="50%"></asp:TextBox>
            <asp:TextBox ID="TextBox9" runat="server" Width="50%"></asp:TextBox>
            <asp:TextBox ID="TextBox10" runat="server" Width="50%"></asp:TextBox>
        </div>
    </form>
</body>
<script language="VB" runat="server">
    Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        T1.Text = MapPath("lx7-2.aspx")
        'Response.End() '停止该页面执行
        'Response.Redirect("https://www.baidu.com") ' 重定向，会在浏览器地址栏显示目标URL
        Response.Write("hello")
        TextBox1.Text = Request.FilePath()
        TextBox2.Text = Server.MachineName
        TextBox3.Text = Server.HtmlEncode("hello")
        TextBox4.Text = Server.UrlEncode("12e1lk w 12 9")
        'Server.Transfer("lx4-2.aspx") '重定向，不会在地址栏显示目标URL，可以在浏览器开发者工具查看
        Server.Execute("lx3-1.aspx") '加载其他网页，结束后加载当前网页
        TextBox5.Text = Application.Count

    End Sub
</script>
</html>
