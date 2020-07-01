<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.ButtContact = New System.Windows.Forms.Button()
        Me.PanelAd = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtChien = New System.Windows.Forms.Button()
        Me.ButtAdoption = New System.Windows.Forms.Button()
        Me.PanelProduitMenu = New System.Windows.Forms.Panel()
        Me.ButtMonPanier = New System.Windows.Forms.Button()
        Me.ButtAccessoires = New System.Windows.Forms.Button()
        Me.ButtNourriture = New System.Windows.Forms.Button()
        Me.ButtProduits = New System.Windows.Forms.Button()
        Me.PanelPicture = New System.Windows.Forms.Panel()
        Me.Acueill = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AboutUS = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelMenu.SuspendLayout()
        Me.PanelAd.SuspendLayout()
        Me.PanelProduitMenu.SuspendLayout()
        Me.PanelPicture.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AboutUS.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.MistyRose
        Me.PanelMenu.Controls.Add(Me.ButtContact)
        Me.PanelMenu.Controls.Add(Me.PanelAd)
        Me.PanelMenu.Controls.Add(Me.ButtAdoption)
        Me.PanelMenu.Controls.Add(Me.PanelProduitMenu)
        Me.PanelMenu.Controls.Add(Me.ButtProduits)
        Me.PanelMenu.Controls.Add(Me.PanelPicture)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(154, 560)
        Me.PanelMenu.TabIndex = 15
        '
        'ButtContact
        '
        Me.ButtContact.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtContact.FlatAppearance.BorderSize = 0
        Me.ButtContact.Location = New System.Drawing.Point(0, 482)
        Me.ButtContact.Name = "ButtContact"
        Me.ButtContact.Size = New System.Drawing.Size(154, 60)
        Me.ButtContact.TabIndex = 9
        Me.ButtContact.Text = "Contact"
        Me.ButtContact.UseVisualStyleBackColor = True
        '
        'PanelAd
        '
        Me.PanelAd.Controls.Add(Me.Button2)
        Me.PanelAd.Controls.Add(Me.ButtChien)
        Me.PanelAd.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAd.Location = New System.Drawing.Point(0, 372)
        Me.PanelAd.Name = "PanelAd"
        Me.PanelAd.Size = New System.Drawing.Size(154, 110)
        Me.PanelAd.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(0, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 36)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Confirmer l'adoption"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ButtChien
        '
        Me.ButtChien.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtChien.FlatAppearance.BorderSize = 0
        Me.ButtChien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtChien.Location = New System.Drawing.Point(0, 0)
        Me.ButtChien.Name = "ButtChien"
        Me.ButtChien.Size = New System.Drawing.Size(154, 39)
        Me.ButtChien.TabIndex = 0
        Me.ButtChien.Text = "Chiens"
        Me.ButtChien.UseVisualStyleBackColor = True
        '
        'ButtAdoption
        '
        Me.ButtAdoption.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtAdoption.FlatAppearance.BorderSize = 0
        Me.ButtAdoption.Location = New System.Drawing.Point(0, 312)
        Me.ButtAdoption.Name = "ButtAdoption"
        Me.ButtAdoption.Size = New System.Drawing.Size(154, 60)
        Me.ButtAdoption.TabIndex = 7
        Me.ButtAdoption.Text = "Adoption"
        Me.ButtAdoption.UseVisualStyleBackColor = True
        '
        'PanelProduitMenu
        '
        Me.PanelProduitMenu.Controls.Add(Me.ButtMonPanier)
        Me.PanelProduitMenu.Controls.Add(Me.ButtAccessoires)
        Me.PanelProduitMenu.Controls.Add(Me.ButtNourriture)
        Me.PanelProduitMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelProduitMenu.Location = New System.Drawing.Point(0, 181)
        Me.PanelProduitMenu.Name = "PanelProduitMenu"
        Me.PanelProduitMenu.Size = New System.Drawing.Size(154, 131)
        Me.PanelProduitMenu.TabIndex = 2
        '
        'ButtMonPanier
        '
        Me.ButtMonPanier.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtMonPanier.FlatAppearance.BorderSize = 0
        Me.ButtMonPanier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtMonPanier.Location = New System.Drawing.Point(0, 68)
        Me.ButtMonPanier.Name = "ButtMonPanier"
        Me.ButtMonPanier.Size = New System.Drawing.Size(154, 27)
        Me.ButtMonPanier.TabIndex = 2
        Me.ButtMonPanier.Text = "Mon Panier"
        Me.ButtMonPanier.UseVisualStyleBackColor = True
        '
        'ButtAccessoires
        '
        Me.ButtAccessoires.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtAccessoires.FlatAppearance.BorderSize = 0
        Me.ButtAccessoires.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtAccessoires.Location = New System.Drawing.Point(0, 33)
        Me.ButtAccessoires.Name = "ButtAccessoires"
        Me.ButtAccessoires.Size = New System.Drawing.Size(154, 35)
        Me.ButtAccessoires.TabIndex = 1
        Me.ButtAccessoires.Text = "Accessoires "
        Me.ButtAccessoires.UseVisualStyleBackColor = True
        '
        'ButtNourriture
        '
        Me.ButtNourriture.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtNourriture.FlatAppearance.BorderSize = 0
        Me.ButtNourriture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtNourriture.Location = New System.Drawing.Point(0, 0)
        Me.ButtNourriture.Name = "ButtNourriture"
        Me.ButtNourriture.Size = New System.Drawing.Size(154, 33)
        Me.ButtNourriture.TabIndex = 0
        Me.ButtNourriture.Text = "Nourriture "
        Me.ButtNourriture.UseVisualStyleBackColor = True
        '
        'ButtProduits
        '
        Me.ButtProduits.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtProduits.FlatAppearance.BorderSize = 0
        Me.ButtProduits.Location = New System.Drawing.Point(0, 121)
        Me.ButtProduits.Name = "ButtProduits"
        Me.ButtProduits.Size = New System.Drawing.Size(154, 60)
        Me.ButtProduits.TabIndex = 1
        Me.ButtProduits.Text = "Produits"
        Me.ButtProduits.UseVisualStyleBackColor = True
        '
        'PanelPicture
        '
        Me.PanelPicture.Controls.Add(Me.Acueill)
        Me.PanelPicture.Controls.Add(Me.PictureBox1)
        Me.PanelPicture.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelPicture.Location = New System.Drawing.Point(0, 0)
        Me.PanelPicture.Name = "PanelPicture"
        Me.PanelPicture.Size = New System.Drawing.Size(154, 121)
        Me.PanelPicture.TabIndex = 0
        '
        'Acueill
        '
        Me.Acueill.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Acueill.FlatAppearance.BorderSize = 0
        Me.Acueill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson
        Me.Acueill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson
        Me.Acueill.Location = New System.Drawing.Point(0, 65)
        Me.Acueill.Name = "Acueill"
        Me.Acueill.Size = New System.Drawing.Size(154, 56)
        Me.Acueill.TabIndex = 1
        Me.Acueill.Text = "Acueill"
        Me.Acueill.UseVisualStyleBackColor = True
        Me.Acueill.UseWaitCursor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.UseWaitCursor = True
        '
        'AboutUS
        '
        Me.AboutUS.BackgroundImage = CType(resources.GetObject("AboutUS.BackgroundImage"), System.Drawing.Image)
        Me.AboutUS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AboutUS.Controls.Add(Me.Label2)
        Me.AboutUS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AboutUS.Location = New System.Drawing.Point(154, 0)
        Me.AboutUS.Name = "AboutUS"
        Me.AboutUS.Size = New System.Drawing.Size(709, 560)
        Me.AboutUS.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Lavender
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(-6, 354)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(719, 156)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 560)
        Me.Controls.Add(Me.AboutUS)
        Me.Controls.Add(Me.PanelMenu)
        Me.DoubleBuffered = True
        Me.Name = "Accueil"
        Me.Text = "Accueil"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelAd.ResumeLayout(False)
        Me.PanelProduitMenu.ResumeLayout(False)
        Me.PanelPicture.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AboutUS.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents ButtContact As Button
    Friend WithEvents PanelAd As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents ButtChien As Button
    Friend WithEvents ButtAdoption As Button
    Friend WithEvents PanelProduitMenu As Panel
    Friend WithEvents ButtMonPanier As Button
    Friend WithEvents ButtAccessoires As Button
    Friend WithEvents ButtNourriture As Button
    Friend WithEvents ButtProduits As Button
    Friend WithEvents PanelPicture As Panel
    Friend WithEvents Acueill As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AboutUS As Panel
    Friend WithEvents Label2 As Label
End Class
