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
        Dim anneeNaissance As Integer = -1
        While anneeNaissance <> 0
            Console.Write("Saisir votre année de naissance : ")
            anneeNaissance = Console.ReadLine()
            Dim age As Integer = anneeNow - anneeNaissance
            Console.WriteLine("Vous avez " & age & " ans")
            PrintClasseAge(age)
        End While

        For i = 100 To 0 Step -2
            'Exit for
        Next

        Dim result = Add(2, 3)

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

    Sub PrintClasseAge(age As Integer)
        If age Mod 2 = 0 Then
            Console.WriteLine("Age pair")
        Else
            Console.WriteLine("Age impair")
        End If
        If age < 1 Then
            Console.WriteLine("Nourisson")
        ElseIf age < 12 Then
            Console.WriteLine("Enfant")
        ElseIf age < 18 Then
            Console.WriteLine("Adolescent")
        ElseIf age < 60 Then
            Console.WriteLine("Adulte")
        ElseIf age < 100 Then
            Console.WriteLine("Retraité")
        Else
            Console.WriteLine("Centenaire")
        End If
    End Sub

    Function Add(i As Integer, j As Integer)
        Dim k = i + j
        Return k
    End Function

End Module
