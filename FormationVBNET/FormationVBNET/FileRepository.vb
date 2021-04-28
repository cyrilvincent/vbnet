Imports System.IO

Public Module FileRepository

    Sub Main()
        Load("C:\Users\conta\CVC\Formation\dotNet\VB.NET\gitvbnet\FormationVBNET\FormationVBNETWinForm2\data.txt")
        Console.ReadKey()
    End Sub

    Public Function Load(path As String)
        Dim reader As New StreamReader(path)
        Dim row As String = ""
        While Not row Is Nothing
            row = reader.ReadLine()
            If Not row Is Nothing Then
                Console.WriteLine(row)
                Dim tab() As String = row.Split(" ")
                For Each word In tab
                    Console.WriteLine("Mot: " & word)
                Next
            End If

        End While
        Return 0
    End Function

    Public Function Somme(path As String)
        Dim reader As New StreamReader(path)
        Dim row As String = ""
        Dim res As Double = 0
        While Not row Is Nothing
            row = reader.ReadLine()
            If Not row Is Nothing AndAlso row.Trim() <> "" Then
                Dim tab() As String = row.Split(";")
                For Each word In tab
                    word.Replace(".", ",")
                    Dim nb As Double = word
                    res += nb
                Next
            End If

        End While
        Return res
    End Function

    Sub Save(path As String, content As String)
        Dim writer As New StreamWriter(path)
        writer.WriteLine(content)
        writer.Close()
    End Sub

    ' TP
    ' S'inspirer de load pour faire la fonction displayFile qui affiche le contenu de data2.txt en séparant les chiffres par des |
    ' 1|3|5|7| ...
    ' Faire la fonction sumRows qui affiche la somme des éléments de chaque ligne
    ' 16
    ' Faire la fonction sumTotal qui somme tout et retourne

End Module
