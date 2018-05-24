
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Str As String = ""
        Dim age As String, name As String, sex As String, hobby As String, fach As String

        If Not Session("id") Is Nothing Then
            Str = "学生信息如下：<br />学号：" + Session("id").ToString + "<br />姓名：" + Session("name").ToString + "<br />性别：" + Session("sex") + "<br />班号：" + Session("clsid") + "<br />"
        End If
        age = Request.Form("age")
        name = Request.Form("name")
        sex = Request.Form("R1")
        hobby = Request.Form("c1")
        fach = Request.Form("fach")

        Str += name + "您好！<br />您的年龄是：" + age + "<br />性别是：" + sex + "<br />您的兴趣是：" + hobby + "<br />您的专业是：" + fach
        Response.Write(Str)
    End Sub
End Class
