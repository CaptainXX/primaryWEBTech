Imports Microsoft.VisualBasic

Public Class XJY
    Private para1 As Integer


    Shared Function Myrandstr() As String  '产生一个随机的字母
        Dim i As Single = 0
        Dim NumTemp As Integer
        Dim dic As String = "1234568790qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM"
        Randomize(Timer)
        NumTemp = Int(Rnd() * 62)
        Return dic(NumTemp)
    End Function

    Shared Function Mydotsplit(ByVal str As String) As String '输入文件名字符串，返回后缀字符串
        Dim N() As String = {}
        N = Split(str, ".")
        Array.Reverse(N)
        Return N(0)
    End Function

End Class
