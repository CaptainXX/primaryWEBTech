
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Unnamed1_Click(sender As Object, e As EventArgs) Handles confirm.Click
        Session("id") = stuid.Text
        Session("name") = name.Text
        Session("sex") = RadioButtonList1.SelectedItem.Text
        Session("clsid") = DropDownList1.SelectedItem.Text
        Server.Transfer("lx5-2.html")
    End Sub
End Class
