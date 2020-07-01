Public Class Recettes
    Dim Vote = 0
    Private Sub Recettes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label23.Visible = False
        Label24.Visible = False
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True
        TextBox5.ReadOnly = True
        TextBox6.ReadOnly = True
        TextBox7.ReadOnly = True
        TextBox8.ReadOnly = True
        TextBox9.ReadOnly = True
        TextBox10.ReadOnly = True
        TextBox11.ReadOnly = True
        TextBox12.ReadOnly = True
        TextBox13.ReadOnly = True
        TextBox14.ReadOnly = True
        TextBox15.ReadOnly = True
        TextBox16.ReadOnly = True
        TextBox17.ReadOnly = True
        TextBox18.ReadOnly = True
    End Sub
    Sub AjoutVote()
        Vote = Vote + 1
        ProgressBar1.Maximum = Vote
        ProgressBar2.Maximum = Vote
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            AjoutVote()
            ProgressBar1.Value = ProgressBar1.Value + 1
            Label23.Text = " Votes : " & ProgressBar1.Value
            Label23.Visible = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            AjoutVote()
            ProgressBar2.Value = ProgressBar2.Value + 1
            Label24.Text = " Votes : " & ProgressBar2.Value
            Label24.Visible = True
        End If
    End Sub
End Class