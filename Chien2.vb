Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Chien2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
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
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        hideSubMenu()
        switchPanel(Chien1)
    End Sub
    Private Sub Chien2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TextBox4.Text = OdsC.Tables("Chien").Rows(5).Item("Num_vaccin")
        TextBox1.Text = OdsC.Tables("Chien").Rows(5).Item("Race")
        TextBox3.Text = OdsC.Tables("Chien").Rows(5).Item("age")
        Label4.Text = " Sexe: " & OdsC.Tables("Chien").Rows(5).Item("sexe")
        CH5.TextBox1 = OdsC.Tables("Chien").Rows(5).Item("commentaire")
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True
        TextBox5.ReadOnly = True
        TextBox6.ReadOnly = True
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        strconC2 = "Data Source=DESKTOP-CCQJNK1; Initial Catalog=H_I_2;Integrated Security=True"
        strC2 = "select * from Chien where handicapé = 'Non'"
        conC2 = New SqlConnection
        conC2.ConnectionString = strconC2
        conC2.Open()
        comC2 = New SqlCommand(strC2)
        odaC2 = New SqlDataAdapter(comC2)
        comC2.Connection = conC2
        odaC2.Fill(OdsC2, "Chien")
        OdtC2 = OdsC2.Tables("Chien")
        objetDatarC2 = OdsC2.Tables("Chien").Rows(RowNumC2)
        TextBox5.Text = objetDatarC2.Item("Num_vaccin")
        TextBox6.Text = objetDatarC2.Item("Race")
        TextBox2.Text = objetDatarC2.Item("age")
        Label4.Text = " Sexe: " & OdsC2.Tables("Chien").Rows(RowNumC2).Item("sexe")

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

    Private Sub Premier_Click(sender As Object, e As EventArgs) Handles Premier.Click
        RowNumC2 = 0
        OdtC2 = OdsC2.Tables("Chien")
        objetDatarC2 = OdsC.Tables("Chien").Rows(RowNumC2)
        TextBox5.Text = objetDatarC2.Item("Num_vaccin")
        TextBox6.Text = objetDatarC2.Item("Race")
        TextBox2.Text = objetDatarC2.Item("age")
        Label9.Text = " Sexe: " & objetDatarC2.Item("sexe")
    End Sub

    Private Sub Suivant_Click(sender As Object, e As EventArgs) Handles Suivant.Click
        RowNumC2 = RowNumC2 + 1
        OdtC2 = OdsC2.Tables("Chien")
        objetDatarC2 = OdsC.Tables("Chien").Rows(RowNumC2)
        TextBox5.Text = objetDatarC2.Item("Num_vaccin")
        TextBox6.Text = objetDatarC2.Item("Race")
        TextBox2.Text = objetDatarC2.Item("age")
        Label9.Text = " Sexe: " & objetDatarC2.Item("sexe")
    End Sub

    Private Sub Precedant_Click(sender As Object, e As EventArgs) Handles Precedant.Click
        RowNumC2 = RowNumC2 - 1
        OdtC2 = OdsC2.Tables("Chien")
        objetDatarC2 = OdsC.Tables("Chien").Rows(RowNumC2)
        TextBox5.Text = objetDatarC2.Item("Num_vaccin")
        TextBox6.Text = objetDatarC2.Item("Race")
        TextBox2.Text = objetDatarC2.Item("age")
        Label9.Text = " Sexe: " & objetDatarC2.Item("sexe")
    End Sub

    Private Sub Dernier_Click(sender As Object, e As EventArgs) Handles Dernier.Click
        RowNumC2 = OdtC2.Rows.Count() - 1
        OdtC2 = OdsC2.Tables("Chien")
        objetDatarC2 = OdsC.Tables("Chien").Rows(RowNumC2)
        TextBox5.Text = objetDatarC2.Item("Num_vaccin")
        TextBox6.Text = objetDatarC2.Item("Race")
        TextBox2.Text = objetDatarC2.Item("age")
        Label9.Text = " Sexe: " & objetDatarC2.Item("sexe")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CH5.Show()
    End Sub
End Class