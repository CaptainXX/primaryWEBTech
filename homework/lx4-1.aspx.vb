Imports XJY
Partial Class homework_lx4_1
    Inherits System.Web.UI.Page
    Sub cy()
        Dim y As Single
        For y = 1970 To Now.Year
            DDL1.Items.Add(New ListItem(y, y))
        Next
    End Sub
    Sub cm()
        Dim m As Single
        For m = 1 To 12
            DDL2.Items.Add(New ListItem(m, m))
        Next
    End Sub
    Sub cd()
        Dim d As Single
        Dim S() As Integer = {4, 6, 9, 11}
        Try
            For d = 1 To 31
                DDL3.Items.Add(New ListItem(d, d))
            Next
            If Int(DDL1.SelectedItem.Text) Mod 4 = 0 And Int(DDL2.SelectedItem.Text) = 2 Then
                For d = 30 To 31
                    DDL3.Items.Remove(item:=d)
                Next
            ElseIf Int(DDL2.SelectedItem.Text) = 2 Then
                For d = 29 To 31
                    DDL3.Items.Remove(item:=d)
                Next
            End If

            For Each x In S
                If Int(DDL2.SelectedItem.Text) = x Then
                    DDL3.Items.Remove(item:=31)
                End If
            Next
        Catch
            Label1.Text = "错误重现"
        End Try
    End Sub
    Protected Sub Today_Click(sender As Object, e As EventArgs) Handles Today.Click
        Dim y As String = Now.Year
        Dim m As String = Now.Month
        Dim d As String = Now.Day
        DDL1.SelectedItem.Text = y
        DDL2.SelectedItem.Text = m
        DDL3.SelectedItem.Text = d
    End Sub
    Protected Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click
        Try
            Label1.Text = "您选择的日期是：" + DDL1.SelectedItem.Text + "年" + DDL2.SelectedItem.Text + "月" + DDL3.SelectedItem.Text + "日"
        Catch
            Label1.Text = "请正确选择日期！"
        End Try
    End Sub
    Protected Sub DDL1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DDL1.SelectedIndexChanged
        cy()
    End Sub
    Protected Sub DDL2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DDL2.SelectedIndexChanged
        cm()
    End Sub
    Protected Sub DDL3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DDL3.SelectedIndexChanged
        cd()
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            cy()
            cm()
            cd()
        End If
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = "<xmp>"
        Dim add As String = HttpRuntime.AppDomainAppPath.ToString()
        Label2.Text += MyFileReader(add + "\homework\lx4-1.aspx.vb")
        Label2.Text += "</xmp>"
    End Sub
End Class
