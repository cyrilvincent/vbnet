Module Module2

    Sub Main()
        ' TP3
        ' Saisir un entier
        ' Afficher s'il est pair ou impair
        ' Tout nombre n >= 2 est premier sauf s'il possède un diviseur entre 2 et n-1
        ' Pour 15 => Tester tous les diviseurs entre 2 et 14 (for) si un seul divise 15 => il n'est pas premier
        ' 15 mod 2 <> 0
        ' 15 mod 3 = 0 => non premier

        Console.Write("Saisir un nombre: ")
        Dim nb As Integer = Console.ReadLine()
        Dim div As Integer
        Dim res As Boolean = True
        For div = 2 To nb - 1
            If nb Mod div = 0 Then
                res = False
                Exit For
            End If
        Next
        If res = True Then
            Console.WriteLine("Premier")
        Else
            Console.WriteLine("Non Premier")
        End If
        Console.ReadKey()

    End Sub

End Module
