Public Module Module4

    'Sub Main()
    '    Dim tab1(6) As String
    '    tab1(0) = "lundi"
    '    tab1(1) = "mardi"

    '    Dim r As New Random()

    '    Dim tab2(999999) As Integer
    '    Console.WriteLine(tab2.Length)
    '    Dim i = 0
    '    For i = 0 To tab2.Length - 1
    '        tab2(i) = r.Next(1000)
    '    Next
    '    'For i = 0 To tab2.Length - 1
    '    '    Console.WriteLine(tab2(i))
    '    'Next
    '    'For Each nb In tab2
    '    '    Console.WriteLine(nb)
    '    'Next

    '    Dim somme As Integer = 0
    '    For Each nb In tab2
    '        somme = somme + nb
    '    Next
    '    Dim moyenne As Single = somme / tab2.Length
    '    Console.WriteLine(moyenne)

    '    Try
    '        Dim nb1 As Integer = Console.ReadLine()
    '        Dim nb2 As Integer = Console.ReadLine()
    '        Dim res = nb1 / nb2
    '        Console.WriteLine(res)
    '    Catch ex As DivideByZeroException
    '        Console.WriteLine("Division par zéro")
    '    Catch ex As FormatException
    '        Console.WriteLine("Veuillez saisir un entier")
    '    Catch ex As Exception
    '        Console.WriteLine(ex.Message)
    '    End Try
    '    ' Faire une forme avec 2 inputs nb1 et nb2
    '    ' Faire la division nb1/nb2 + afficher le résultat
    '    ' Gérer les erreurs

    '    'FAIRE LES MENUS



    '    Console.ReadKey()

    '    ' TP
    '    ' Créer un tableau avec 10 entiers et codé en dur les 10 valeurs
    '    ' tab(0) = 2
    '    ' tab(1) = 8
    '    ' Afficher le contenu du tableau depuis un sub
    '    ' Créer la fonction qui renvoie la somme des éléments du tableau
    '    ' Créer la fonction qui renvoie la moyenne des éléments du tableau
    '    ' Créer la sub qui pour chaque nombre affiche s'il est pair ou non
    '    ' Créer la sub qui pour chaque nombre affiche s'il est premier ou non
    '    ' Créer un tableau de 1000 éléments aléatoires
    '    ' Rejouer les fonctions et sub

    '    'FAIRE LES MENUS


    'End Sub

    Public Function Add(i As Integer, j As Integer)
        Return i + j
    End Function

End Module
