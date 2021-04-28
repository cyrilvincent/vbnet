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
End Class
