Imports XJY

Partial Class homework_lx4_1

    Inherits System.Web.UI.Page

    Sub cy() ' Create Year List
        Dim y As Single
        For y = Now.Year To 1970 Step -1
            DDL1.Items.Add(New ListItem(y, y))
        Next
    End Sub

    Sub cm() ' Create Month List
        Dim m As Single
        For m = 1 To 12
            DDL2.Items.Add(New ListItem(m, m))
        Next
    End Sub

    Sub cd() ' Create Date List
        Dim d As Single
        For d = 1 To 31
            DDL3.Items.Add(New ListItem(d, d))
        Next
    End Sub

    Protected Sub Today_Click(sender As Object, e As EventArgs) Handles Today.Click
        Dim y As String = Now.Year
        Dim m As String = Now.Month
        Dim d As String = Now.Day

        DDL1.Items.FindByValue(y).Selected = True
        DDL1.SelectedItem.Selected = False
        DDL2.Items.FindByValue(m).Selected = True
        DDL2.SelectedItem.Selected = False
        DDL3.Items.FindByValue(d).Selected = True
        DDL3.SelectedItem.Selected = False
    End Sub
    Protected Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click

        Try
            Label1.Text = "您选择的日期是：" + DDL1.SelectedItem.Text + "年" + DDL2.SelectedItem.Text + "月" + DDL3.SelectedItem.Text + "日"
        Catch
            Label1.Text = "请正确选择日期！"
        End Try

    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            cy()
            cm()
            cd()
        End If
    End Sub
    Protected Sub DDL2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DDL2.SelectedIndexChanged

        ' 若DateList中已做删除，则重新添加ListItem
        Try
            Dim it As ListItem = DDL3.Items.FindByValue("31")
            If it Is Nothing Then
                DDL3.Items.Clear()
                cd()
            End If
        Catch ex As Exception
            Label1.Text = "233"
        End Try

        ' 首先判断月份
        ' 1 3 5 7 8 10 12 月有31天，DateList不变
        ' 4 6 9 11 月有30天，在DateList中删除值为31的Item
        Dim Mo() As String = {"4"， "6", "9", "11"}
        For Each i In Mo
            If DDL2.SelectedItem.Value = i Then
                DDL3.Items.Remove(31)
            End If
        Next
        ' 闰年 2 月有29天，删除值为31 39 的ITem
        ' 平年 2 月有28天，删除值为31 30 29 的Item
        If DDL2.SelectedValue = "2" Then ' 先判断是否选择二月
            If Val(DDL1.SelectedValue) Mod 4 = 0 Then ' 是闰年
                DDL3.Items.Remove(31)
                DDL3.Items.Remove(30)
            Else ' 不是闰年，肯定是平年
                DDL3.Items.Remove(31)
                DDL3.Items.Remove(30)
                DDL3.Items.Remove(29)
            End If
        End If
    End Sub
    Protected Sub DDL1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DDL1.SelectedIndexChanged
        DDL2_SelectedIndexChanged(sender, e)
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Label1.Text <> "" Then
            Label1.Text = ""
            Return
        End If
        Label2.Text += MyFileReader(MapPath("lx4-1.aspx.vb"))
    End Sub
End Class
