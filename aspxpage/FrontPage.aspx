<%@ Page Language="VB" AutoEventWireup="false" CodeFile="FrontPage.aspx.vb" Inherits="表格" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Life happens. Foods save.</title>
    <style type="text/css"></style>
    <link href="/css/mycss.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div id="container">
    <div id="head">
        <h1>Captain Xu</h1>
        <h3><a href="/index.html">首页</a></h3>
        <ul>
            <li><a href="/html/BaiduMap.html" target="Frame">黑名单地图</a></li>
            <li><a href="/html/WhiteMap.html" target="Frame">推荐地图</a></li>
            <li><a href="/html/Author.html">作者信息</a></li>
            <li><a href="/html/homework.html">作业</a></li>
        </ul>
    </div>
    <div id="main">
        <div id="left">
            <h2>Recent:</h2>
            <iframe id="iframe1" name="Frame" src="/html/BlackMap.html" style="width:100%; height:75%;border:none;"></iframe>
        </div>
        <div id="right">
            <a href="https://4m3.tongji.edu.cn" target="_blank">四毛三</a>
        </div>
    </div>
    <div id="footer">
        <div id="footer_links">
            <p>
                推荐链接
                <a href="https://github.com/" target="_blank">GitHub</a>
                <a href="https://www.zhihu.com/" target="_blank">知乎</a>
                <a href="https://weibo.com/" target="_blank">微博</a>
                <a href="https://github.com/" target="_blank">GitHub</a>
                <a href="https://www.zhihu.com/" target="_blank">知乎</a>
                <a href="https://weibo.com/" target="_blank">微博</a>
                <a href="https://github.com/" target="_blank">GitHub</a>
                <a href="https://www.zhihu.com/" target="_blank">知乎</a>
                <a href="https://weibo.com/" target="_blank">微博</a>
            </p>
            <p>&copy; Xu Junyi</p>
        </div>
    </div>
    </div>
</body>
</html>
