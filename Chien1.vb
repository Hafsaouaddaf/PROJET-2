﻿Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Chien1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        hideSubMenu()
        switchPanel(Chien2)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        hideSubMenu()
        switchPanel(Chien)
    End Sub

    Private Sub hideSubMenu()
        Accueil.PanelProduitMenu.Visible = False
        Accueil.PanelAd.Visible = False
    End Sub
    Sub switchPanel(ByVal panel As Form)
        Accueil.AboutUS.Controls.Clear()
        panel.TopLevel = False
        Accueil.AboutUS.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Chien1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubMenu()
        strconC = "Data Source=DESKTOP-CCQJNK1; Initial Catalog=H_I_2;Integrated Security=True"
        strC = "select * from Chien where handicapé = 'Oui'"
        conC = New SqlConnection
        conC.ConnectionString = strconC
        conC.Open()
        comC = New SqlCommand(strC)
        odaC = New SqlDataAdapter(comC)
        comC.Connection = conC
        odaC.Fill(OdsC, "Chien")
        OdtC = OdsC.Tables("Chien")
        objetDatarC = OdsC.Tables("Chien").Rows(RowNumC)
        TextBox4.Text = OdsC.Tables("Chien").Rows(3).Item("Num_vaccin")
        TextBox1.Text = OdsC.Tables("Chien").Rows(3).Item("Race")
        TextBox3.Text = OdsC.Tables("Chien").Rows(3).Item("age")
        Label4.Text = " Sexe: " & OdsC.Tables("Chien").Rows(3).Item("sexe")
        TextBox5.Text = OdsC.Tables("Chien").Rows(4).Item("Num_vaccin")
        TextBox2.Text = OdsC.Tables("Chien").Rows(4).Item("Race")
        TextBox6.Text = OdsC.Tables("Chien").Rows(4).Item("age")
        Label9.Text = " Sexe: " & OdsC.Tables("Chien").Rows(4).Item("sexe")
        CH3.TextBox1 = OdsC.Tables("Chien").Rows(3).Item("commentaire")
        CH4.TextBox1 = OdsC.Tables("Chien").Rows(4).Item("commentaire")

        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True
        TextBox5.ReadOnly = True
        TextBox6.ReadOnly = True

        strconA = "Data Source=DESKTOP-CCQJNK1; Initial Catalog=H_I_2;Integrated Security=True"
        strA = "select * from Adopteur"
        conA = New SqlConnection
        conA.ConnectionString = strconA
        conA.Open()
        comA = New SqlCommand(strA)
        odaA = New SqlDataAdapter(comA)
        comA.Connection = conA
        odaA.Fill(OdsA, "Adopteur")
        OdtA = OdsA.Tables("Adopteur")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RowNumA = OdtA.Rows.Count + 1
        objetDatarA = OdsA.Tables("Adopteur").Rows.Add(RowNumA)
        objetDatarA("ID_adopteur") = Accueil1.TextBox1.Text
        objetDatarA("nomA") = Accueil1.TextBox2.Text
        objetDatarA("prénomA") = Accueil1.TextBox3.Text
        objetDatarA("mail") = Accueil1.TextBox4.Text
        objetDatarA("adresse") = Accueil1.TextBox5.Text
        objetDatarA("Num_Vaccin") = TextBox4.Text
        builderA = New SqlCommandBuilder(odaA)
        odaA.Update(OdsA, "Adopteur")
        OdsA.Clear()
        odaA.Fill(OdsA, "Adopteur")
        OdtA = OdsA.Tables("Adopteur")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        RowNumA = OdtA.Rows.Count + 1
        objetDatarA = OdsA.Tables("Adopteur").Rows.Add(RowNumA)
        objetDatarA("ID_adopteur") = Accueil1.TextBox1.Text
        objetDatarA("nomA") = Accueil1.TextBox2.Text
        objetDatarA("prénomA") = Accueil1.TextBox3.Text
        objetDatarA("mail") = Accueil1.TextBox4.Text
        objetDatarA("adresse") = Accueil1.TextBox5.Text
        objetDatarA("Num_Vaccin") = TextBox5.Text
        builderA = New SqlCommandBuilder(odaA)
        odaA.Update(OdsA, "Adopteur")
        OdsA.Clear()
        odaA.Fill(OdsA, "Adopteur")
        OdtA = OdsA.Tables("Adopteur")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CH3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CH4.Show()
    End Sub
End Class