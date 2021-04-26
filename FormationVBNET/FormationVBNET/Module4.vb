Module Module4

    Sub Main()
        Dim tab1(6) As String
        tab1(0) = "lundi"
        tab1(1) = "mardi"

        Dim r As New Random()

        Dim tab2(999999) As Integer
        Console.WriteLine(tab2.Length)
        Dim i = 0
        For i = 0 To tab2.Length - 1
            tab2(i) = r.Next(1000)
        Next
        'For i = 0 To tab2.Length - 1
        '    Console.WriteLine(tab2(i))
        'Next
        'For Each nb In tab2
        '    Console.WriteLine(nb)
        'Next

        Dim somme As Integer = 0
        For Each nb In tab2
            somme = somme + nb
        Next
        Dim moyenne As Single = somme / tab2.Length
        Console.WriteLine(moyenne)

        Console.ReadKey()

        ' TP
        ' Créer un tableau avec 10 entiers et codé en dur les 10 valeurs
        ' tab(0) = 2
        ' tab(1) = 8
        ' Afficher le contenu du tableau depuis un sub
        ' Créer la fonction qui renvoie la somme des éléments du tableau
        ' Créer la fonction qui renvoie la moyenne des éléments du tableau
        ' Créer la sub qui pour chaque nombre affiche s'il est pair ou non
        ' Créer la sub qui pour chaque nombre affiche s'il est premier ou non
        ' Créer un tableau de 1000 éléments aléatoires
        ' Rejouer les fonctions et sub


    End Sub

End Module
