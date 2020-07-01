Public Class Accueil1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panier.TextBox1.Text = TextBox2.Text
        Panier.TextBox2.Text = TextBox3.Text
        Panier.TextBox3.Text = TextBox4.Text
        Panier.TextBox4.Text = TextBox1.Text
        Panier.TextBox5.Text = TextBox5.Text

        'Adoption.TextBox1.Text = TextBox1.Text
        'Adoption.TextBox2.Text = TextBox2.Text
        'Adoption.TextBox3.Text = TextBox3.Text
        'Adoption.TextBox4.Text = TextBox4.Text
        'Adoption.TextBox5.Text = TextBox5.Text

        If TextBox5.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MessageBox.Show("Champs obligatoires")

        Else
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
        End If
        Accueil.Show()
        Me.Hide()
    End Sub

    Private Sub Accueil1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class