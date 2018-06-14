Imports System.String
Imports MySql.Data.MySqlClient
Imports XJY

Partial Class chatlogin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Application("user_online") Is Nothing Then
            lblrs.Text = 0
        Else
            lblrs.Text = CInt(Application("user_online"))
        End If
        txtname.Focus()
    End Sub

    Protected Sub btnlogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim i As Integer
        Dim userid As String = "root"
        Dim pwd As String = "*"
        Dim dbid As String = "user"
        Dim query As String = "select user_name,user_pwd from user;"
        Dim name As String = ""
        Dim pass As String = ""
        Dim conn As MySqlConnection = DatabaseConnect(userid, pwd, dbid)
        Dim dr As MySqlDataReader = QueryExecute(conn, query)


        'Dim Content As String = ""
        'While (dr.Read())
        '    For i = 0 To 1
        '        Content += dr.GetValue(i).ToString + "<br />"
        '    Next
        'End While

        'Response.Write(Content)

        Try
            While (dr.Read())

                name = dr.GetString("user_name")
                pass = dr.GetString("user_pwd")
                If txtname.Text = name And txtpass.Text = pass Then
                    conn.Close()
                    Session("se_name") = name
                    Server.Transfer("../chatpic/chat.aspx")
                End If
            End While
            lblerror.Text = "用户名或密码错！"
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message + " 查询错误！")
        End Try

        'For i = 0 To 2
        '    If Compare(txtname.Text, bluser(i, 0), False) = 0 And Compare(txtpass.Text, bluser(i, 1), False) = 0 Then
        '        Session("se_name") = bluser(i, 0)
        '        Response.Redirect("../chatpic/chat.aspx")

        '    End If
        'Next

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Response.Redirect("../html/README.html")
    End Sub
End Class
