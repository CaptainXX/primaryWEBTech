﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="chatlogin.aspx.vb" Inherits="chatlogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>聊天室</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="box-shadow: 10px 10px 10px -5px #888888; margin:auto; top:0; bottom:0; left:0; right:0; text-align:center; border:3px solid #000; border-radius:10px; width:300px; height:230px; position:absolute;">
        <br />
        <table>
            <tr>
                <td colspan="2" style="text-align: center">
                    聊天室</td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    现在共有<asp:Label ID="lblrs" runat="server" Text="0"></asp:Label>人在线</td>
            </tr>
            <tr>
                <td style="width: 82px">
                    用户名：</td>
                <td style="width: 234px">
                    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtname"
                        ErrorMessage="必须输入用户名！">*</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 82px">
                    密码：</td>
                <td style="width: 234px">
                    <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpass"
                        ErrorMessage="必须输入4位密码！" SetFocusOnError="True">*</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="btnlogin" runat="server" Text="登录"/>
                    <asp:Button ID="Button1" runat="server" Text="退出" CausesValidation="False" /></td>
            </tr>
        </table>
    
    </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <br />
        <asp:Label ID="lblerror" runat="server" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
