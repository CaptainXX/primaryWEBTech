<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Slip.aspx.vb" Inherits="aspxpage_Slip" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>输入数值，以任意分隔符间隔：</p>
            <asp:TextBox ID="InputStr" runat="server"></asp:TextBox>
            <p>输入分隔符：</p>
            <asp:TextBox ID="TrennenBar" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Split" runat="server" Text="分割" />
            <asp:Button ID="Rank" runat="server" Text="排序" /> 
            <br />
            <asp:Label ID="Output" runat="server" Text=""></asp:Label>
            
        </div>
    </form>
</body>
</html>
