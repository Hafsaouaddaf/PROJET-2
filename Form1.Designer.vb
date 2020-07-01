<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ButtonCommencer = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(112, 512)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(560, 11)
        Me.ProgressBar1.TabIndex = 0
        '
        'ButtonCommencer
        '
        Me.ButtonCommencer.BackColor = System.Drawing.Color.MintCream
        Me.ButtonCommencer.BackgroundImage = CType(resources.GetObject("ButtonCommencer.BackgroundImage"), System.Drawing.Image)
        Me.ButtonCommencer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonCommencer.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.ButtonCommencer.FlatAppearance.BorderSize = 0
        Me.ButtonCommencer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCommencer.ForeColor = System.Drawing.Color.Snow
        Me.ButtonCommencer.Location = New System.Drawing.Point(280, 397)
        Me.ButtonCommencer.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCommencer.Name = "ButtonCommencer"
        Me.ButtonCommencer.Size = New System.Drawing.Size(241, 110)
        Me.ButtonCommencer.TabIndex = 9
        Me.ButtonCommencer.UseVisualStyleBackColor = False
        Me.ButtonCommencer.UseWaitCursor = True
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 535)
        Me.Controls.Add(Me.ButtonCommencer)
        Me.Controls.Add(Me.ProgressBar1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ButtonCommencer As Button
    Friend WithEvents Timer1 As Timer
End Class
