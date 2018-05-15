Imports XJY

Partial Class homework_lx4_3
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""

        Try
            If TextBox1.Text = "" Then
                Label2.Text = "请输入学号"
                Return
            ElseIf Len(TextBox1.Text) <> 6 Then
                Label2.Text = "学号应为6位"
                Return
            End If

            If TextBox2.Text = "" Then
                Label3.Text = "请输入姓名"
                Return
            End If

            If TextBox3.Text <> Button2.Text Then
                Label4.Text = "验证码错误，请重新输入"
                Return
            End If

            Pnl1.Visible = False
            Pnl2.Visible = True

        Catch ex As Exception
            Label2.Text = "请合法输入"
            Label3.Text = "请合法输入"
            Label4.Text = "请合法输入"
        End Try

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            Button2.Text = MyRandString(6)
            Pnl1.Visible = True
            Pnl2.Visible = False
            Pnl3.Visible = False
        End If

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Text = MyRandString(6)
    End Sub
    Protected Sub Fbtn_Click(sender As Object, e As EventArgs) Handles Fbtn.Click
        Dim FTail As String = Mydotsplit(FileUpload1.FileName)
        Dim FilePath As String = "/data/" + FileUpload1.FileName

        If Not FileUpload1.HasFile Then ' 检查是否选择文件
            Label1.Text = "请选择文件！"
            Return
        ElseIf FileUpload1.FileContent.Length > 5242880 Then ' 检查文件大小
            Label1.Text = "文件过大！"
            Return
        ElseIf FTail <> "zip" And FTail <> "rar" And FTail <> "7z" Then ' 检查文件类型
            Label1.Text = "请确定文件格式为：zip、rar、7z"
            Return
        End If
        FileUpload1.SaveAs(MapPath(FilePath))
        Pnl2.Visible = False
        Pnl3.Visible = True
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Pnl2.Visible = True
        Pnl3.Visible = False
    End Sub

    Protected Sub btncode_Click(sender As Object, e As EventArgs) Handles btncode.Click
        If lbcode.Text <> "" Then
            lbcode.Text = ""
            Return
        End If
        Dim add As String = HttpRuntime.AppDomainAppPath.ToString()
        lbcode.Text += MyFileReader(add + "\homework\lx4-2.aspx.vb")
    End Sub
End Class
