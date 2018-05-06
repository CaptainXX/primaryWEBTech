<%@ Page Language="VB" AutoEventWireup="false" CodeFile="lx4-3.aspx.vb" Inherits="homework_lx4_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../css/mycss.css" rel="stylesheet" />
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
            <asp:Panel ID="Pnl1" runat="server">
                <h3>第一步：输入个人信息：</h3>
                <ul style="list-style: none;">
                    <li>学  号： <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                    </li>
                    <li>姓  名： <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                    </li>
                    <li>验证码：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        <asp:Button ID="Button2" runat="server" Text="" style="font-family: Ubuntu-M, 'Courier New', Courier, monospace"/>
                        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
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
            </asp:Panel>
            <asp:Panel ID="Pnl2" runat="server" BorderStyle="None">
                <h3>第二步：选择上传的作业</h3>
                <table style="text-align: left">
                    <tr>
                        <th>实验编号</th>
                        <th>每章实验题号（压缩文件名规定：学号-实验题号 eg: 123456-lx1-1.zip）</th>
                    </tr>
                    <tr>
                        <td>1</td>
                        <td>
                            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Hw" Checked="True" Text="ASP.NET网站的建立和网页的基本操作" />
                        </td>
                    </tr>
                    <tr>
                        <td>2</td>
                        <td>
                            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Hw" Text="HTML网页的编写与调试"/>
                        </td>
                    </tr>
                    <tr>
                        <td>3</td>
                        <td>
                            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="Hw" Text="ASP.NET程序设计基础"/>
                        </td>
                    </tr>
                    <tr>
                        <td>4</td>
                        <td>
                            <asp:RadioButton ID="RadioButton4" runat="server" GroupName="Hw" Text="WEB服务器基本控件的设置和使用"/>
                        </td>
                    </tr>
                    <tr>
                        <td>5</td>
                        <td>
                            <asp:RadioButton ID="RadioButton5" runat="server" GroupName="Hw" Text="内部对象的设计和使用"/>
                        </td>
                    </tr>
                    <tr>
                        <td>选择文件</td>
                        <td>
                            <p>
                                <asp:FileUpload ID="FileUpload1" runat="server" />
                                <asp:Button ID="Fbtn" runat="server" Text="完成" />
                                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                            </p>
                            
                            <p>*当本文件名和你已上传的文件重名时将覆盖原有文件！</p>
                            <p>*文件最大为5M</p>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <asp:Panel ID="Pnl3" runat="server">
                <p>上传成功！</p>
                    <asp:Button ID="Button3" runat="server" Text="返回，继续上传" />
                <p>
                    <asp:Button ID="btncode" runat="server" Text="代码" />
                    <br />
                    <asp:Label ID="lbcode" runat="server" Text=""></asp:Label>
                </p>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
