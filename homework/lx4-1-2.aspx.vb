﻿Imports XJY

Partial Class homework_lx4_1_2
    Inherits System.Web.UI.Page

    Sub xs()
        Label1.Text = ""
        Dim i As Integer
        For i = 1 To 4
            Label1.Text += Myrandstr()
        Next
    End Sub

    Protected Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        xs()
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            xs()
        End If

    End Sub
    Protected Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Label2.Text = ""
        Try
            If TextBox2.Text = "WEB" Then
                Label2.Text += "<style>#span {color:blue;}</style><span>用户名正确</span> <br/>"
            Else
                Label2.Text += "用户名出错<br/>"
            End If
            If TextBox1.Text = "2016" Then
                Label2.Text += "密码正确<br/>"
            Else
                Label2.Text += "密码错误<br/>"
            End If
            If TextBox3.Text = Label1.Text Then
                Label2.Text += "验证码正确<br/>"
            Else
                Label2.Text += "验证码错误<br/>"
            End If
        Catch ex As Exception
            Label2.Text = "alert(未知错误！)"
        End Try
    End Sub
    Protected Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Dim d As String = ""
        d = Mydotsplit(TextBox2.Text)
        Label1.Text = d
    End Sub
End Class
