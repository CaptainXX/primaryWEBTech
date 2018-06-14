<%@ Page Language="VB" AutoEventWireup="false" CodeFile="chat.aspx.vb" Inherits="chat" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
		<iframe name="message" src="chatshow.aspx" width="40%" height="720px" scrolling="auto" frameborder="0" style="float:left;"></iframe>
        <iframe name="say" src="chatsend.aspx" width="60%" height="720px" scrolling="auto" frameborder="0" style="float:left;"></iframe>
</body>
</html>
