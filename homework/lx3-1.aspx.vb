Imports XJY
Partial Class homework_lx3_1
    Inherits System.Web.UI.Page
    Protected Sub Nine_Click(sender As Object, e As EventArgs) Handles Nine.Click
        Dim i As Single, j As Single
        Nine_Table.Text += "<table>"
        For i = 1 To 9
            Nine_Table.Text += "<tr>"
            For j = 1 To i
                Nine_Table.Text += "<td>" + Str(i) + " *" + Str(j) + "=" + Str(i * j) + "</td>"
            Next
            Nine_Table.Text += "</tr>"
        Next
        Nine_Table.Text += "</table>"
    End Sub
    Protected Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Label1.Text = "<xmp>"
        Dim add As String = System.Environment.CurrentDirectory
        Label1.Text += MyFileReader("D:\1tongji\1计算机\WEB技术基础\primaryWEBTech\homework\lx3-1.aspx.vb")
        Label1.Text += "</xmp>"
        Label1.Text = add
    End Sub
End Class
