<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nourriture
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nourriture))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.dernier = New System.Windows.Forms.Button()
        Me.Premier = New System.Windows.Forms.Button()
        Me.suivant = New System.Windows.Forms.Button()
        Me.Quantité = New System.Windows.Forms.Label()
        Me.precedant = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelCommande = New System.Windows.Forms.Panel()
        Me.AjouterAMonPanier = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelFormProduits = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelCommande.SuspendLayout()
        Me.PanelFormProduits.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(428, 356)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 81
        Me.Button2.Text = "Montant"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(511, 356)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(98, 20)
        Me.TextBox8.TabIndex = 80
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(184, 312)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(66, 20)
        Me.TextBox6.TabIndex = 79
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(78, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Référence"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button4.Location = New System.Drawing.Point(0, 487)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(709, 27)
        Me.Button4.TabIndex = 77
        Me.Button4.Text = "Voir nos recettes "
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(184, 380)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(66, 24)
        Me.TextBox4.TabIndex = 70
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dernier
        '
        Me.dernier.Location = New System.Drawing.Point(431, 441)
        Me.dernier.Name = "dernier"
        Me.dernier.Size = New System.Drawing.Size(77, 23)
        Me.dernier.TabIndex = 76
        Me.dernier.Text = "dernier"
        Me.dernier.UseVisualStyleBackColor = True
        '
        'Premier
        '
        Me.Premier.Location = New System.Drawing.Point(184, 441)
        Me.Premier.Name = "Premier"
        Me.Premier.Size = New System.Drawing.Size(77, 23)
        Me.Premier.TabIndex = 75
        Me.Premier.Text = "Premier"
        Me.Premier.UseVisualStyleBackColor = True
        '
        'suivant
        '
        Me.suivant.Location = New System.Drawing.Point(265, 441)
        Me.suivant.Name = "suivant"
        Me.suivant.Size = New System.Drawing.Size(77, 23)
        Me.suivant.TabIndex = 74
        Me.suivant.Text = "suivant "
        Me.suivant.UseVisualStyleBackColor = True
        '
        'Quantité
        '
        Me.Quantité.AutoSize = True
        Me.Quantité.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantité.Location = New System.Drawing.Point(78, 389)
        Me.Quantité.Name = "Quantité"
        Me.Quantité.Size = New System.Drawing.Size(53, 15)
        Me.Quantité.TabIndex = 62
        Me.Quantité.Text = "Quantité"
        '
        'precedant
        '
        Me.precedant.Location = New System.Drawing.Point(348, 441)
        Me.precedant.Name = "precedant"
        Me.precedant.Size = New System.Drawing.Size(77, 23)
        Me.precedant.TabIndex = 73
        Me.precedant.Text = "precedant"
        Me.precedant.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(184, 340)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(66, 20)
        Me.TextBox5.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(78, 347)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Nombre disponible "
        '
        'PanelCommande
        '
        Me.PanelCommande.BackColor = System.Drawing.Color.PaleTurquoise
        Me.PanelCommande.Controls.Add(Me.AjouterAMonPanier)
        Me.PanelCommande.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelCommande.Location = New System.Drawing.Point(0, 514)
        Me.PanelCommande.Name = "PanelCommande"
        Me.PanelCommande.Size = New System.Drawing.Size(709, 46)
        Me.PanelCommande.TabIndex = 69
        '
        'AjouterAMonPanier
        '
        Me.AjouterAMonPanier.BackColor = System.Drawing.Color.MistyRose
        Me.AjouterAMonPanier.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AjouterAMonPanier.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AjouterAMonPanier.Location = New System.Drawing.Point(0, 0)
        Me.AjouterAMonPanier.Name = "AjouterAMonPanier"
        Me.AjouterAMonPanier.Size = New System.Drawing.Size(709, 46)
        Me.AjouterAMonPanier.TabIndex = 5
        Me.AjouterAMonPanier.Text = "Ajouter à mon panier"
        Me.AjouterAMonPanier.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(511, 312)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(98, 20)
        Me.TextBox3.TabIndex = 68
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(184, 187)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(425, 104)
        Me.TextBox2.TabIndex = 67
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(184, 161)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(425, 20)
        Me.TextBox1.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(425, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Prix unitaire en €"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Désignation"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft MHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(214, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 42)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Offrez à votre chien le plaisir de manger" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nourriture fraiche • Prêt à servir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelFormProduits
        '
        Me.PanelFormProduits.BackColor = System.Drawing.Color.Crimson
        Me.PanelFormProduits.Controls.Add(Me.Panel2)
        Me.PanelFormProduits.Controls.Add(Me.Button1)
        Me.PanelFormProduits.Controls.Add(Me.Label1)
        Me.PanelFormProduits.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFormProduits.Location = New System.Drawing.Point(0, 0)
        Me.PanelFormProduits.Name = "PanelFormProduits"
        Me.PanelFormProduits.Size = New System.Drawing.Size(709, 75)
        Me.PanelFormProduits.TabIndex = 82
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Location = New System.Drawing.Point(336, 75)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(310, 460)
        Me.Panel2.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(687, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 20)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(273, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nourriture"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Nourriture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 560)
        Me.Controls.Add(Me.PanelFormProduits)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.dernier)
        Me.Controls.Add(Me.Premier)
        Me.Controls.Add(Me.suivant)
        Me.Controls.Add(Me.Quantité)
        Me.Controls.Add(Me.precedant)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PanelCommande)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Nourriture"
        Me.Text = "Nourriture"
        Me.PanelCommande.ResumeLayout(False)
        Me.PanelFormProduits.ResumeLayout(False)
        Me.PanelFormProduits.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents dernier As Button
    Friend WithEvents Premier As Button
    Friend WithEvents suivant As Button
    Friend WithEvents Quantité As Label
    Friend WithEvents precedant As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PanelCommande As Panel
    Friend WithEvents AjouterAMonPanier As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelFormProduits As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
