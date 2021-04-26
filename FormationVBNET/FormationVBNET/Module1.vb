Module Module1

    Sub Main()
        Console.WriteLine("Hello World!")
        Dim myFloat As Single = 3.99
        Dim var As Integer = myFloat
        Console.WriteLine(var)
        var = var + 1
        Console.WriteLine(var)
        Dim s1 As String = "Visual"
        Dim s2 As String = "Basic"
        Dim s3 As String = s1 + " " + s2
        Console.WriteLine(s3)
        Console.Write("Saisir une data: ")
        Dim input As Integer = Console.ReadLine()

        Console.WriteLine(input + 1)
        Console.ReadKey()

        'TP1
        'Saisir une année
        'DateTime.Now().Year va donner l'année actuelle
        'Afficher l'age de la personne


    End Sub

End Module
