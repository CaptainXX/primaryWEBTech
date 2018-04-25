
Partial Class _Default
    Inherits System.Web.UI.Page
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim i As Integer = 0, j As Integer = 0, t1 As Integer = TB2.Text, t2 As Integer = TB3.Text, s As String = "", l As String
        While t1 > 0
            s = s & "<td>" & Key.Text & "</td>"
            t1 = t1 - 1
        End While
        l = "<tr>" & s & "</tr>"
        s = ""
        While t2 > 0
            s = s + l
            t2 = t2 - 1
        End While

    End Sub
End Class
