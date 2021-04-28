Public Class Form1
    Private Sub NombresPremiersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NombresPremiersToolStripMenuItem.Click
        Dim form As New Form1
        ' Passage de param
        form.ShowDialog()
        ToolStripStatusLabel1.Text = "toto"

    End Sub

    Private Sub ÀproposdeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÀproposdeToolStripMenuItem.Click, ToolStripButton.Click
        ToolStripStatusLabel1.Text = "A propos"
        MessageBox.Show("Formation VB.NET", "A propos", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click
        Dim res As Integer = OpenFileDialog1.ShowDialog()
        If res = DialogResult.OK Then
            Dim path As String = OpenFileDialog1.FileName
            ' Appeler SommeTotal de FileRepository
            ' Afficher le résultat dans un label

        End If
    End Sub
End Class
