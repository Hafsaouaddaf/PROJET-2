Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Accueil.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ButtonCommencer_Click(sender As Object, e As EventArgs) Handles ButtonCommencer.Click
        MsgBox(" Veuillez patienter ... ")
        Timer1.Start()
    End Sub
End Class
