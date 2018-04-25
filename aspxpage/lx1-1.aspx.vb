
Partial Class lx1_1
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        lbl_page.Text = "My First Web Page" & Now & TB1.Text


    End Sub
    Protected Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        lbl_page.Text = "<a href=" + TB1.Text + ">" + TB1.Text + "</a>"
    End Sub
    Protected Sub Button1_Click1(sender As Object, e As EventArgs) Handles Button1.Click
        lbl_page.Text = "<img alt='Bluesky' width=" + "720" + "height=" + "540" + "class='auto-style1' src='BlueSky.jpg' />"
        lb2_page.Text = "<img alt='Bluesky' width= '720' height= '540' class='auto-style1' src='BlueSky.jpg' />"
    End Sub
End Class
