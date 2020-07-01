Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Accessoire
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Accessoire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strconAcc = "Data Source=DESKTOP-CCQJNK1; Initial Catalog=H_I_2;Integrated Security=True"
        strAcc = "select * from Produit where genre='Accessoires'"
        conAcc = New SqlConnection
        conAcc.ConnectionString = strconAcc
        conAcc.Open()
        comAcc = New SqlCommand(strAcc)
        odaAcc = New SqlDataAdapter(comAcc)
        comAcc.Connection = conAcc
        odaAcc.Fill(OdsAcc, "Produit")
        OdtAcc = OdsAcc.Tables("Produit")
        objetDatarAcc = OdsAcc.Tables("Produit").Rows(RowNumAcc)
        TextBox5.Text = OdsAcc.Tables("Produit").Rows(0).Item("Désignation")
        TextBox9.Text = OdsAcc.Tables("Produit").Rows(0).Item("Prix_unitaire_euro")
        TextBox6.Text = OdsAcc.Tables("Produit").Rows(1).Item("Désignation")
        TextBox10.Text = OdsAcc.Tables("Produit").Rows(1).Item("Prix_unitaire_euro")
        TextBox7.Text = OdsAcc.Tables("Produit").Rows(2).Item("Désignation")
        TextBox11.Text = OdsAcc.Tables("Produit").Rows(2).Item("Prix_unitaire_euro")
        TextBox8.Text = OdsAcc.Tables("Produit").Rows(3).Item("Désignation")
        TextBox13.Text = OdsAcc.Tables("Produit").Rows(3).Item("Prix_unitaire_euro")

        P09.TextBox1.Text = OdsAcc.Tables("Produit").Rows(0).Item("Desription")
        P09.TextBox1.ReadOnly = True
        P10.TextBox1.Text = OdsAcc.Tables("Produit").Rows(1).Item("Desription")
        P10.TextBox1.ReadOnly = True
        P11.TextBox1.Text = OdsAcc.Tables("Produit").Rows(2).Item("Desription")
        P11.TextBox1.ReadOnly = True
        P12.TextBox1.Text = OdsAcc.Tables("Produit").Rows(3).Item("Desription")
        P12.TextBox1.ReadOnly = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        P09.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        P10.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        P11.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        P12.Show()
    End Sub

    Private Sub ValiderMaCommande_Click(sender As Object, e As EventArgs) Handles ValiderMaCommande.Click
        If CheckBox1.Checked = True Then
            Panier.ListBox2.Items.Add(" Vous avez commendé " & TextBox5.Text & " Avec un montant de " & TextBox9.Text)
        End If
        If CheckBox2.Checked = True Then
            Panier.ListBox2.Items.Add(" Vous avez commendé " & TextBox6.Text & " Avec un montant de " & TextBox10.Text)
        End If
        If CheckBox3.Checked = True Then
            Panier.ListBox2.Items.Add(" Vous avez commendé " & TextBox7.Text & " Avec un montant de " & TextBox11.Text)
        End If
        If CheckBox4.Checked = True Then
            Panier.ListBox2.Items.Add(" Vous avez commendé " & TextBox8.Text & "Avec un montant de " & TextBox13.Text)
        End If
    End Sub
End Class