
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
End Class
