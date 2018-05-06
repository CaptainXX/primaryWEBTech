Imports XJY
Partial Class homework_lx4_2
    Inherits System.Web.UI.Page
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Try
            If TextBox1.Text = "" Then
                Label1.Text = "请输入学号"
            ElseIf Len(TextBox1.Text) <> 6 Then
                Label1.Text = "学号应为6位"
            End If
            If TextBox2.Text = "" Then
                Label2.Text = "请输入姓名"
            End If
            If TextBox3.Text <> Button2.Text Then
                Label3.Text = "验证码错误，请重新输入"
            End If
        Catch ex As Exception
            Label1.Text = "请合法输入"
            Label2.Text = "请合法输入"
            Label3.Text = "请合法输入"
        End Try
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Button2.Text = MyRandString(6)
        End If
    End Sub
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Text = MyRandString(6)
    End Sub
    Protected Sub btncode_Click(sender As Object, e As EventArgs) Handles btncode.Click
        If lbcode.Text <> "" Then
            lbcode.Text = ""
            Return
        End If
        lbcode.Text = "<xmp>"
        Dim add As String = HttpRuntime.AppDomainAppPath.ToString()
        lbcode.Text += MyFileReader(add + "\homework\lx4-2.aspx.vb")
        lbcode.Text += "</xmp>"
    End Sub
End Class
