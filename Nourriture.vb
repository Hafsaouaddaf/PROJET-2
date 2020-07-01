Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Nourriture
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Nourriture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strconN = "Data Source=DESKTOP-CCQJNK1; Initial Catalog=H_I_2 ;Integrated Security=True"
        strN = "select * from Produit where genre = 'Nourriture' "
        conN = New SqlConnection
        conN.ConnectionString = strconN
        conN.Open()
        comN = New SqlCommand(strN)
        odaN = New SqlDataAdapter(comN)
        comN.Connection = conN
        odaN.Fill(OdsN, "Produit")
        OdtN = OdsN.Tables("Produit")
        objetDatarN = OdsN.Tables("Produit").Rows(RowNumN)
        TextBox1.Text = objetDatarN.Item("Désignation")
        TextBox1.ReadOnly = True
        TextBox2.Text = objetDatarN.Item("Desription")
        TextBox2.ReadOnly = True
        TextBox3.Text = objetDatarN.Item("Prix_unitaire_euro")
        TextBox3.ReadOnly = True
        TextBox5.Text = objetDatarN.Item("nombre_disponible")
        TextBox5.ReadOnly = True
        TextBox6.Text = objetDatarN.Item("Référence")
        TextBox6.ReadOnly = True
        TextBox4.ReadOnly = False
        TextBox8.ReadOnly = True
    End Sub

    Private Sub Premier_Click(sender As Object, e As EventArgs) Handles Premier.Click
        RowNumN = 0
        TextBox1.Text = OdtN.Rows(RowNumN).Item("Désignation")
        TextBox2.Text = OdtN.Rows(RowNumN).Item("Desription")
        TextBox3.Text = OdtN.Rows(RowNumN).Item("Prix_unitaire_euro")
        TextBox5.Text = OdtN.Rows(RowNumN).Item("nombre_disponible")
    End Sub

    Private Sub suivant_Click(sender As Object, e As EventArgs) Handles suivant.Click
        RowNumN = RowNumN + 1
        TextBox1.Text = OdtN.Rows(RowNumN).Item("Désignation")
        TextBox2.Text = OdtN.Rows(RowNumN).Item("Desription")
        TextBox3.Text = OdtN.Rows(RowNumN).Item("Prix_unitaire_euro")
        TextBox5.Text = OdtN.Rows(RowNumN).Item("nombre_disponible")
    End Sub

    Private Sub precedant_Click(sender As Object, e As EventArgs) Handles precedant.Click
        RowNumN = RowNumN - 1
        TextBox1.Text = OdtN.Rows(RowNumN).Item("Désignation")
        TextBox2.Text = OdtN.Rows(RowNumN).Item("Desription")
        TextBox3.Text = OdtN.Rows(RowNumN).Item("Prix_unitaire_euro")
        TextBox5.Text = OdtN.Rows(RowNumN).Item("nombre_disponible")
    End Sub

    Private Sub dernier_Click(sender As Object, e As EventArgs) Handles dernier.Click
        RowNumN = OdtN.Rows.Count() - 1
        TextBox1.Text = OdtN.Rows(RowNumN).Item("Désignation")
        TextBox2.Text = OdtN.Rows(RowNumN).Item("Desription")
        TextBox3.Text = OdtN.Rows(RowNumN).Item("Prix_unitaire_euro")
        TextBox5.Text = OdtN.Rows(RowNumN).Item("nombre_disponible")
    End Sub
    'Montant
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Montant As Integer
        Montant = Val(TextBox3.Text) * Val(TextBox4.Text)
        TextBox8.Text = Montant
    End Sub
    'Recettes
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Recettes.Show()
    End Sub

    Private Sub AjouterAMonPanier_Click(sender As Object, e As EventArgs) Handles AjouterAMonPanier.Click
        Panier.ListBox1.Items.Add(" Vous avez commendé " & TextBox4.Text & " de " & TextBox1.Text & " . Le montant total est: " & TextBox8.Text)
    End Sub
End Class