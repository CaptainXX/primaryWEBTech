Imports MySql.Data.MySqlClient

Partial Class data_mysqlTest
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub data_mysqlTest_Init(sender As Object, e As EventArgs) Handles Me.Init
        Dim password As String
        Dim userid As String
        Dim DatabaseId As String

        Dim constr As String = "server=127.0.0.1;userid=" + userid + ";password=" + password + ";database=" + DatabaseId + ";pooling=false"
        Dim myConn = New MySqlConnection(constr)

        Dim SQLQuery As String = "select * from test;"

        Dim show As String = ""
        show += "数据库test内容<br/>"
        show += "<xmp>+---------+--------------+-------------+-----------------+</xmp>"
        show += "<xmp>| test_id | test_title   | test_author | submission_date |</xmp>"
        show += "<xmp>+---------+--------------+-------------+-----------------+</xmp>"
        show += "<xmp>|       1 | a test       | xjy         | 2018-06-09      |</xmp>"
        show += "<xmp>|       2 | another test | xjy too     | 2018-06-09      |</xmp>"
        show += "<xmp>+---------+--------------+-------------+-----------------+</xmp>"
        Label1.Text = show
        ' 测试连接


        Try

            myConn.Open()
            Dim comm = New MySqlCommand(SQLQuery, myConn)
            Dim dr As MySqlDataReader = comm.ExecuteReader()
            Dim content As String = ""

            content = "<table>"
            content += "<tr>"
            For i = 0 To 3

                content += "<th>" + dr.GetName(i).ToString + "</th>"
            Next
            content += "</tr>"

            While (dr.Read())
                content += "<tr>"
                For i = 0 To 3
                    content += "<td>" + dr.GetValue(i).ToString + "</td>"
                Next
                content += "</tr>"
            End While
            content += "</table>"

            Response.Write(content)

            myConn.Close()
        Catch ex As Exception

            MsgBox(ex.Message & vbCrLf & "数据库连接失败!")

        End Try
    End Sub
End Class
