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


        Dim i As Integer = 0
        Dim j As Integer = 32
        While i < 10
            Console.WriteLine(i)
            i = i + 1
        End While
        Console.ReadKey()


        'TP1
        'Saisir une année
        'DateTime.Now().Year va donner l'année actuelle
        'Afficher l'age de la personne

        'TP2
        'Afficher si nourisson (<1 an) enfant(<12 ans) adolescent (18) adulte (60) retraite (100) centenaire > 100
        'Afficher si ton age est pair (3 mod 2 => 1) (4 mod 2 => 0)
        'Mettre la saisie dans une boucle qui se termine quand on saisie 0

    End Sub

End Module
