Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Panier
    'Num_Facture = Num_commande
    Private Sub Panier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        strconCl = "Data Source=DESKTOP-CCQJNK1; Initial Catalog=H_I_2 ;Integrated Security=True"
        strCl = "select * from Client"
        conCl = New SqlConnection
        conCl.ConnectionString = strconCl
        conCl.Open()
        comCl = New SqlCommand(strCl)
        odaCl = New SqlDataAdapter(comCl)
        comCl.Connection = conCl
        odaCl.Fill(OdsCl, "Client")
        OdtCl = OdsCl.Tables("Client")

        strconP = "Data Source=DESKTOP-CCQJNK1; Initial Catalog=H_I_2 ;Integrated Security=True"
        strP = "select Num_Commande, Commande.ID_Client from Commande, Client where Commande.ID_Client=Client.ID_Client"
        conP = New SqlConnection
        conP.ConnectionString = strconP
        conP.Open()
        comP = New SqlCommand(strP)
        odaP = New SqlDataAdapter(comP)
        comP.Connection = conP
        odaP.Fill(OdsP, "Commande")
        OdtP = OdsP.Tables("Commande")

        strconP2 = "Data Source=DESKTOP-CCQJNK1; Initial Catalog=H_I_2 ;Integrated Security=True"
        strP2 = "select * from Contient"
        conP2 = New SqlConnection
        conP2.ConnectionString = strconP2
        conP2.Open()
        comP2 = New SqlCommand(strP2)
        odaP2 = New SqlDataAdapter(comP2)
        comP2.Connection = conP2
        odaP2.Fill(OdsP2, "Contient")
        OdtP2 = OdsP2.Tables("Contient")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Montant_Total_Click(sender As Object, e As EventArgs) Handles Montant_Total.Click
        Dim Montant_total As Double
        Montant_total = Val(Nourriture.TextBox8.Text)
        If Accessoire.CheckBox1.Checked = True Then
            Montant_total = Montant_total + Val(Nourriture.TextBox8.Text) + Val(Accessoire.TextBox9.Text)
        End If
        If Accessoire.CheckBox2.Checked = True Then
            Montant_total = Montant_total + Val(Nourriture.TextBox8.Text) + Val(Accessoire.TextBox10.Text)
        End If
        If Accessoire.CheckBox3.Checked = True Then
            Montant_total = Montant_total + Val(Nourriture.TextBox8.Text) + Val(Accessoire.TextBox11.Text)
        End If
        If Accessoire.CheckBox4.Checked = True Then
            Montant_total = Montant_total + Val(Nourriture.TextBox8.Text) + Val(Accessoire.TextBox13.Text)
        End If
        TextBox6.Text = Montant_total
    End Sub
    'Confirmer la commande dans la table Contient
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RowNumCl = OdtCl.Rows.Count + 1
        objetDatarCl = OdsCl.Tables("Client").Rows.Add(RowNumCl)
        objetDatarCl("ID_Client") = "C" & Accueil1.TextBox1.Text
        objetDatarCl("nomC") = Accueil1.TextBox2.Text
        objetDatarCl("prénomC") = Accueil1.TextBox3.Text
        objetDatarCl("mail") = Accueil1.TextBox4.Text
        objetDatarCl("adresse") = Accueil1.TextBox5.Text
        builderCl = New SqlCommandBuilder(odaCl)
        odaCl.Update(OdsCl, "Client")
        OdsCl.Clear()
        odaCl.Fill(OdsCl, "Client")
        OdtCl = OdsCl.Tables("Client")

        'objetDatarN = OdsN.Tables("Contient").Rows.Add(RowNumP)
        'objetDatarAcc = OdsAcc.Tables("Contient").Rows.Add(RowNumAcc)
        If Accessoire.CheckBox1.Checked = True Then
            RowNumP = OdtP.Rows.Count + 1
            objetDatarP = OdsP.Tables("Commande").Rows.Add(RowNumP)
            'objetDatarAcc("Référence") = Accessoire.TextBox5.Text
            objetDatarP("Num_commande") = Accueil1.TextBox1.Text & Nourriture.TextBox4.Text & Accessoire.TextBox5.Text
        End If
        If Accessoire.CheckBox2.Checked = True Then
            RowNumP = OdtP.Rows.Count + 1
            objetDatarP = OdsP.Tables("Commande").Rows.Add(RowNumP)
            'objetDatarAcc("Référence") = Accessoire.TextBox6.Text
            objetDatarP("Num_commande") = Accueil1.TextBox1.Text & Nourriture.TextBox4.Text & Accessoire.TextBox6.Text
        End If
        If Accessoire.CheckBox3.Checked = True Then
            RowNumP = OdtP.Rows.Count + 1
            objetDatarP = OdsP.Tables("Commande").Rows.Add(RowNumP)
            'objetDatarAcc("Référence") = Accessoire.TextBox7.Text
            objetDatarP("Num_commande") = Accueil1.TextBox1.Text & Nourriture.TextBox4.Text & Accessoire.TextBox7.Text
        End If
        If Accessoire.CheckBox4.Checked = True Then
            RowNumP = OdtP.Rows.Count + 1
            objetDatarP = OdsP.Tables("Commande").Rows.Add(RowNumP)
            'objetDatarAcc("Référence") = Accessoire.TextBox8.Text
            objetDatarP("Num_commande") = Accueil1.TextBox1.Text & Nourriture.TextBox4.Text & Accessoire.TextBox8.Text
        End If
        RowNumP = OdtP.Rows.Count + 1
        objetDatarP = OdsP.Tables("Commande").Rows.Add(RowNumP)
        objetDatarP("ID_Client") = "C" & Accueil1.TextBox1.Text
        builderP = New SqlCommandBuilder(odaP)
        odaP.Update(OdsP, "Commande")
        OdsP.Clear()
        odaP.Fill(OdsP, "Commande")
        OdtP = OdsP.Tables("Commande")


        RowNumP2 = OdtP2.Rows.Count + 1
        objetDatarP2 = OdsP2.Tables("Contient").Rows.Add(RowNumP2)
        'objetDatarN = OdsN.Tables("Contient").Rows.Add(RowNumP)
        'objetDatarAcc = OdsAcc.Tables("Contient").Rows.Add(RowNumAcc)
        objetDatarN("Référence") = Nourriture.TextBox6.Text
        If Accessoire.CheckBox1.Checked = True Then
            RowNumP2 = OdtP2.Rows.Count + 1
            RowNumAcc = OdtAcc.Rows.Count + 1
            objetDatarP2 = OdsP2.Tables("Contient").Rows.Add(RowNumP2)
            objetDatarAcc = OdsAcc.Tables("Contient").Rows.Add(RowNumAcc)
            objetDatarAcc("Référence") = Accessoire.TextBox1.Text
            objetDatarP2("Num_commande") = Accueil1.TextBox1.Text & Nourriture.TextBox4.Text & Accessoire.TextBox5.Text
        End If
        If Accessoire.CheckBox2.Checked = True Then
            RowNumP2 = OdtP2.Rows.Count + 1
            RowNumAcc = OdtAcc.Rows.Count + 1
            objetDatarP2 = OdsP2.Tables("Contient").Rows.Add(RowNumP2)
            objetDatarAcc = OdsAcc.Tables("Contient").Rows.Add(RowNumAcc)
            objetDatarAcc("Référence") = Accessoire.TextBox2.Text
            objetDatarP2("Num_commande") = Accueil1.TextBox1.Text & Nourriture.TextBox4.Text & Accessoire.TextBox6.Text
        End If
        If Accessoire.CheckBox3.Checked = True Then
            RowNumP2 = OdtP2.Rows.Count + 1
            RowNumAcc = OdtAcc.Rows.Count + 1
            objetDatarP2 = OdsP2.Tables("Contient").Rows.Add(RowNumP2)
            objetDatarAcc = OdsAcc.Tables("Contient").Rows.Add(RowNumAcc)
            objetDatarAcc("Référence") = Accessoire.TextBox3.Text
            objetDatarP2("Num_commande") = Accueil1.TextBox1.Text & Nourriture.TextBox4.Text & Accessoire.TextBox7.Text
        End If
        If Accessoire.CheckBox4.Checked = True Then
            RowNumP2 = OdtP2.Rows.Count + 1
            RowNumAcc = OdtAcc.Rows.Count + 1
            objetDatarP2 = OdsP2.Tables("Contient").Rows.Add(RowNumP2)
            objetDatarAcc = OdsAcc.Tables("Contient").Rows.Add(RowNumAcc)
            objetDatarAcc("Référence") = Accessoire.TextBox4.Text
            objetDatarP2("Num_commande") = Accueil1.TextBox1.Text & Nourriture.TextBox4.Text & Accessoire.TextBox8.Text
        End If
        objetDatarP2("Montant_Total") = TextBox6.Text
        builderP2 = New SqlCommandBuilder(odaP2)
        odaP2.Update(OdsP2, "Contient")
        OdsP2.Clear()
        odaP2.Fill(OdsP2, "Contient")
        OdtP2 = OdsP2.Tables("Contient")

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class