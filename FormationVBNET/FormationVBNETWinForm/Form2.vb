Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text As String = TextBox1.Text
        TextBox2.Text = "Coucou " & text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Location = New System.Drawing.Point(Button2.Location.X + 10, Button2.Location.Y)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button2.Visible = Not Button2.Visible
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length > 0 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As Integer = MessageBox.Show("Coucou", "Titre", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then

        ElseIf result = DialogResult.Abort Then

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim result As Integer = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            TextBox3.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim result As Integer = ColorDialog1.ShowDialog()
        If result = DialogResult.OK Then
            Me.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim form As New Form1
        form.monInput = "valeur depuis form2"
        form.ShowDialog()
        Dim res As String = form.monOutput
        ' D'une fenetre tu affiche ta fenetre des nombre premiers
        ' PAr défaut il affiche un nombre que tu as envoé depuis la fenetre hôte
        ' Quand tu close la fenetre des nombre premier tu récupère le résultat True False
    End Sub

    ' Grisser le bouton calculer par défaut (enable)
    ' Dégriser le bouton si les 2 Textbox sont remplis
    ' Calculer a puissance b (Math.Pow) et l'afficher

End Class