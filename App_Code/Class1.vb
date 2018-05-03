﻿Imports Microsoft.VisualBasic
Imports System.IO

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

    Shared Function MyFileReader(ByVal add As String) As String ' 输入文件名（包括绝对地址），返回字符串形式的文件内容
        Dim Reader As StreamReader '声明一个StreamReader对象
        Dim filecont As String '声明一个变量保存读出的内容
        Dim content As String = ""
        Reader = File.OpenText(add) '打开文件赋值到StreamReader对象
        Do '按行循环读取文件内容
            filecont = Reader.ReadLine()
            content += filecont + vbCrLf
        Loop Until filecont = ""
        Reader.Close() '关闭StreamReader对象
        Return content
    End Function

End Class
