<%@ Page Language="VB" AutoEventWireup="false" CodeFile="lx1-2.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Page2</title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            <asp:Label ID="Label1" runat="server" Text="列数："></asp:Label>
            <asp:TextBox ID="TB2" runat="server"></asp:TextBox>
            <br />
          
            <asp:Label ID="Label2" runat="server" Text="行数："></asp:Label>
            <asp:TextBox ID="TB3" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="内容："></asp:Label>
            <asp:TextBox ID="Key" runat="server"></asp:TextBox>
            <br />

            <p>
                <asp:Button ID="Button2" runat="server" Text="Table" />
            </p>
            <p>
                <asp:Label ID="Table" runat="server" Text=""></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
