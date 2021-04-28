Public Class Form1

    Dim filename As String = ""
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

    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripButton.Click
        Dim res As Integer = OpenFileDialog1.ShowDialog()
        If res = DialogResult.OK Then
            Dim path As String = OpenFileDialog1.FileName
            Dim nb As Double = FormationVBNET.FileRepository.Somme(path)
            Label1.Text = nb
        End If
    End Sub

    Private Sub EnregistrersousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrersousToolStripMenuItem.Click
        Dim res As Integer = SaveFileDialog1.ShowDialog()
        If res = DialogResult.OK Then
            filename = SaveFileDialog1.FileName
            FormationVBNET.Save(filename, Label1.Text)
        End If
    End Sub

    Private Sub EnregistrerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerToolStripMenuItem.Click, EnregistrerToolStripButton.Click
        If filename = "" Then
            EnregistrersousToolStripMenuItem_Click(sender, e)
        Else
            FormationVBNET.Save(filename, Label1.Text)
        End If

    End Sub

    Private Sub OuvrirToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Fichiers Excel (*.xlsx)|*.xlsx"
        Dim res As Integer = OpenFileDialog1.ShowDialog()
        If res = DialogResult.OK Then
            Dim path As String = OpenFileDialog1.FileName
            Dim range = FormationVBNET.Excel(path)
            Label1.Text = range.Cells(1, 1).Value2
        End If
    End Sub
End Class
