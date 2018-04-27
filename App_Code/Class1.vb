Imports Microsoft.VisualBasic

Public Class XJY
    Private para1 As Integer


    Shared Function Mysquart(ByVal n As Integer) As Integer
        Return n * n
    End Function

    Shared Function Myrandstr() As String
        Dim i As Single = 0
        Dim NumTemp As Integer
        Dim dic As String = "1234568790qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM"
        Randomize(Timer)
        NumTemp = Int(Rnd() * 62)
        Return dic(NumTemp)
    End Function



End Class
