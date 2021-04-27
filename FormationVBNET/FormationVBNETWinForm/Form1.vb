Public Class Form1

    Public monInput As String
    Public monOutput As String

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        ' Créer une Form avec un menu
        ' Mettre une toolbar
        ' Mettre un split container
        ' Mettre à gauche une listbox
        ' MEttre un split container horizontal à droite
        ' Dans le panel en haut à droite mettre 2 textobxs, 1 bouton et 3 labels
        ' Créer un outils qui saisit 2 chiffres puis en appuyant sur le bouton affiche la puissance de l'un par l'autre


    End Sub

    Private Sub SplitContainer2_Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = monInput
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        monOutput = "Valeur depuis form1"
        Me.Close()
    End Sub
End Class
