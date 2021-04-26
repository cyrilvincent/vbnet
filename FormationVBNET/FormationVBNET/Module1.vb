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
        Dim anneeNow As Integer = DateTime.Now.Year
        Console.Write("Saisir votre année de naissance : ")
        Dim anneeNaissance As Integer = Console.ReadLine()
        Dim age As Integer = anneeNow - anneeNaissance
        Console.WriteLine("Vous avez " & age & " ans")
        Console.ReadKey()

        'TP1
        'Saisir une année
        'DateTime.Now().Year va donner l'année actuelle
        'Afficher l'age de la personne


    End Sub

End Module
