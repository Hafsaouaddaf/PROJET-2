Public Class Accueil
    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubMenu()
    End Sub
    Private Sub hideSubMenu()
        PanelProduitMenu.Visible = False
        PanelAd.Visible = False
    End Sub
    Private Sub showsubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub
    Sub switchPanel(ByVal panel As Form)
        AboutUS.Controls.Clear()
        panel.TopLevel = False
        AboutUS.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub Acueill_Click(sender As Object, e As EventArgs) Handles Acueill.Click
        hideSubMenu()
        switchPanel(Accueil1)
    End Sub
    Private Sub ButtProduits_Click(sender As Object, e As EventArgs) Handles ButtProduits.Click
        showsubmenu(PanelProduitMenu)
    End Sub
    Private Sub ButtAdoption_Click(sender As Object, e As EventArgs) Handles ButtAdoption.Click
        showsubmenu(PanelAd)
    End Sub

    Private Sub ButtNourriture_Click(sender As Object, e As EventArgs) Handles ButtNourriture.Click
        hideSubMenu()
        switchPanel(Nourriture)
    End Sub

    Private Sub ButtAccessoires_Click(sender As Object, e As EventArgs) Handles ButtAccessoires.Click
        hideSubMenu()
        switchPanel(Accessoire)
    End Sub

    Private Sub ButtMonPanier_Click(sender As Object, e As EventArgs) Handles ButtMonPanier.Click
        hideSubMenu()
        switchPanel(Panier)
    End Sub

    Private Sub ButtChien_Click(sender As Object, e As EventArgs) Handles ButtChien.Click
        hideSubMenu()
        switchPanel(Chien)
    End Sub

    'Private Sub ButtChien_Click(sender As Object, e As EventArgs) Handles ButtChien.Click
    '    hideSubMenu()
    '    switchPanel(Chien)
    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    hideSubMenu()
    '    switchPanel(Adoption)
    'End Sub
End Class