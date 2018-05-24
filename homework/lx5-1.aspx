<%@ Page Language="VB" AutoEventWireup="false" CodeFile="lx5-1.aspx.vb" Inherits="_Default" %>

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
                <td>学号</td>
                <td><asp:TextBox runat="server" ID="stuid" ></asp:TextBox></td>
            </tr>
            <tr>
                <td>姓名</td>
                <td><asp:TextBox runat="server" ID="name" ></asp:TextBox></td>
            </tr>
            <tr>
                <td>性别</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True">男</asp:ListItem>
                        <asp:ListItem>女</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>班号</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>09001</asp:ListItem>
                        <asp:ListItem>09002</asp:ListItem>
                        <asp:ListItem>09003</asp:ListItem>
                        <asp:ListItem>09004</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <p style="text-align:center">
                        <asp:Button runat="server" ID="confirm" Text="确定" OnClick="Unnamed1_Click" />
                        <asp:Button runat="server" ID="reset" Text="重置" />
                    </p>
                </td>
            </tr>
        </table>
        
    
        </div>
    </form>
</body>
</html>
