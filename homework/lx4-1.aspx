<%@ Page Language="VB" AutoEventWireup="false" CodeFile="lx4-1.aspx.vb" Inherits="homework_lx4_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>请选择年月日：</p>
            <p>
                
                <asp:DropDownList ID="DDL1" runat="server" AutoPostBack="True">
                </asp:DropDownList>年
                <asp:DropDownList ID="DDL2" runat="server" AutoPostBack="True">                  
                </asp:DropDownList>月
                <asp:DropDownList ID="DDL3" runat="server">
                </asp:DropDownList>日
            </p>
            <p>

                <asp:Button ID="Today" runat="server" Text="今天" />
                <asp:Button ID="Confirm" runat="server" Text="确定" />

            </p>
            <p>

                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

            </p>
            <p>
                <asp:Button ID="Button1" runat="server" Text="代码" />
                <br />
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
