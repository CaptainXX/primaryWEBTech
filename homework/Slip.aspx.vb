Imports System.Array
Imports System.String
Imports XJY
Partial Class aspxpage_Slip
    Inherits System.Web.UI.Page
    Protected Sub Split_Click(sender As Object, e As EventArgs) Handles Split.Click
        Dim Input As String = InputStr.Text
        Dim Bar As String = TrennenBar.Text
        Dim Sto(10) As String
        Dim i As Single = 0
        Dim j As Single = 0
        If Input = "" Then
            Output.Text = "请输入字符串！"
            Return
        End If
        If Bar = "" Then
            Output.Text = "请输入分隔符!"
            Return
        End If
        For i = 0 To Len(Input) - 1
            If Input(i) <> Bar Then
                Sto(j) += Input(i)
            Else
                j += 1
            End If
        Next
        Output.Text = ""
        For i = 0 To j
            Output.Text += Sto(i) + "<br/>"
        Next
    End Sub
    Protected Sub Rank_Click(sender As Object, e As EventArgs) Handles Rank.Click
        Dim Input As String = InputStr.Text
        Dim Bar As String = TrennenBar.Text
        Dim Sto(11) As String
        Dim i As Single = 0
        Dim j As Single = 0
        If Input = "" Then
            Output.Text = "请输入字符串！"
            Return
        End If
        If Bar = "" Then
            Output.Text = "请输入分隔符!"
            Return
        End If
        For i = 0 To Len(Input) - 1
            If Input(i) <> Bar Then
                Sto(j) += Input(i)
            Else
                j += 1
            End If
        Next
        Dim tmp As Single = 0
        Dim counts As Single = j
        Output.Text = ""
        Dim SSto(11) As Single
        For i = 0 To j
            SSto(i) = CInt(Sto(i))
        Next
        Sort(SSto)
        For i = 0 To 11
            If SSto(i) <> 0 Then
                Output.Text += Str(SSto(i)) + " "
            End If
        Next
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Label1.Text <> "" Then
            Label1.Text = ""
            Return
        End If
        Label1.Text = "<xmp>"
        Dim add As String = HttpRuntime.AppDomainAppPath.ToString()
        Label1.Text += MyFileReader(add + "\homework\Slip.aspx.vb")
        Label1.Text += "</xmp>"
    End Sub
End Class

