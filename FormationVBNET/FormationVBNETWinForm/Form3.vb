Public Class Form3

    Dim nb As Integer = New Random().Next(100)
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Deviner le chiffre
        ' Pour debuger afficher nb dans un label
        ' Textbox + Button + Label
        ' Tu saisis un chiffre entre 1 et 100
        ' Si saisis un chiffre trop grand tu affiches trop grand dans le label
        ' Inversement pour trop petit
        ' Gagne quand tu as deviner le chiffre, tu ecris GAGNER dans le label
        ' Declare un variable nbcoup = 0
        ' Chaque fois que tu joue tu incremente la variable
        ' Tu affiches le nombre de coup en cours dans un label
        ' Quand tu gagnes afficher dans une messagebox GAGNER en nbcoup
        ' Créer un bouton rejouer qui réinitialise nb avec un nouveau nombre et nbcoup à 0
        ' Créer une variable nbpartie et l'afficher
    End Sub
End Class