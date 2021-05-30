<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_valider = New System.Windows.Forms.Button()
        Me.lbl_attaque = New System.Windows.Forms.Label()
        Me.edt_attaquantX = New System.Windows.Forms.TextBox()
        Me.edt_cibleX = New System.Windows.Forms.TextBox()
        Me.edt_attaquantY = New System.Windows.Forms.TextBox()
        Me.edt_cibleY = New System.Windows.Forms.TextBox()
        Me.lbl_tableau = New System.Windows.Forms.Label()
        Me.lbl_x = New System.Windows.Forms.Label()
        Me.lbl_y = New System.Windows.Forms.Label()
        Me.lbl_erreur = New System.Windows.Forms.Label()
        Me.btn_retour = New System.Windows.Forms.Button()
        Me.lbl_xbis = New System.Windows.Forms.Label()
        Me.lbl_ybis = New System.Windows.Forms.Label()
        Me.lbl_plateau = New System.Windows.Forms.Label()
        Me.lbl_selection = New System.Windows.Forms.Label()
        Me.lbl_y0123 = New System.Windows.Forms.Label()
        Me.lbl_x0123 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_valider
        '
        Me.btn_valider.Location = New System.Drawing.Point(92, 88)
        Me.btn_valider.Name = "btn_valider"
        Me.btn_valider.Size = New System.Drawing.Size(87, 43)
        Me.btn_valider.TabIndex = 0
        Me.btn_valider.Text = "Button1"
        Me.btn_valider.UseVisualStyleBackColor = True
        '
        'lbl_attaque
        '
        Me.lbl_attaque.AutoSize = True
        Me.lbl_attaque.Location = New System.Drawing.Point(304, 102)
        Me.lbl_attaque.Name = "lbl_attaque"
        Me.lbl_attaque.Size = New System.Drawing.Size(41, 15)
        Me.lbl_attaque.TabIndex = 1
        Me.lbl_attaque.Text = "Label1"
        '
        'edt_attaquantX
        '
        Me.edt_attaquantX.Location = New System.Drawing.Point(243, 99)
        Me.edt_attaquantX.Name = "edt_attaquantX"
        Me.edt_attaquantX.Size = New System.Drawing.Size(25, 23)
        Me.edt_attaquantX.TabIndex = 2
        '
        'edt_cibleX
        '
        Me.edt_cibleX.Location = New System.Drawing.Point(351, 99)
        Me.edt_cibleX.Name = "edt_cibleX"
        Me.edt_cibleX.Size = New System.Drawing.Size(25, 23)
        Me.edt_cibleX.TabIndex = 4
        '
        'edt_attaquantY
        '
        Me.edt_attaquantY.Location = New System.Drawing.Point(274, 99)
        Me.edt_attaquantY.Name = "edt_attaquantY"
        Me.edt_attaquantY.Size = New System.Drawing.Size(25, 23)
        Me.edt_attaquantY.TabIndex = 3
        '
        'edt_cibleY
        '
        Me.edt_cibleY.Location = New System.Drawing.Point(382, 99)
        Me.edt_cibleY.Name = "edt_cibleY"
        Me.edt_cibleY.Size = New System.Drawing.Size(25, 23)
        Me.edt_cibleY.TabIndex = 5
        '
        'lbl_tableau
        '
        Me.lbl_tableau.AutoSize = True
        Me.lbl_tableau.Location = New System.Drawing.Point(523, 62)
        Me.lbl_tableau.Name = "lbl_tableau"
        Me.lbl_tableau.Size = New System.Drawing.Size(41, 15)
        Me.lbl_tableau.TabIndex = 6
        Me.lbl_tableau.Text = "Label1"
        '
        'lbl_x
        '
        Me.lbl_x.AutoSize = True
        Me.lbl_x.Location = New System.Drawing.Point(243, 77)
        Me.lbl_x.Name = "lbl_x"
        Me.lbl_x.Size = New System.Drawing.Size(38, 15)
        Me.lbl_x.TabIndex = 7
        Me.lbl_x.Text = "label3"
        '
        'lbl_y
        '
        Me.lbl_y.AutoSize = True
        Me.lbl_y.Location = New System.Drawing.Point(274, 77)
        Me.lbl_y.Name = "lbl_y"
        Me.lbl_y.Size = New System.Drawing.Size(41, 15)
        Me.lbl_y.TabIndex = 8
        Me.lbl_y.Text = "Label2"
        '
        'lbl_erreur
        '
        Me.lbl_erreur.AutoSize = True
        Me.lbl_erreur.Cursor = System.Windows.Forms.Cursors.No
        Me.lbl_erreur.Location = New System.Drawing.Point(107, 163)
        Me.lbl_erreur.Name = "lbl_erreur"
        Me.lbl_erreur.Size = New System.Drawing.Size(38, 15)
        Me.lbl_erreur.TabIndex = 10
        Me.lbl_erreur.Text = "label4"
        '
        'btn_retour
        '
        Me.btn_retour.Location = New System.Drawing.Point(289, 163)
        Me.btn_retour.Name = "btn_retour"
        Me.btn_retour.Size = New System.Drawing.Size(87, 23)
        Me.btn_retour.TabIndex = 11
        Me.btn_retour.Text = "Button1"
        Me.btn_retour.UseVisualStyleBackColor = True
        '
        'lbl_xbis
        '
        Me.lbl_xbis.AutoSize = True
        Me.lbl_xbis.Location = New System.Drawing.Point(351, 77)
        Me.lbl_xbis.Name = "lbl_xbis"
        Me.lbl_xbis.Size = New System.Drawing.Size(41, 15)
        Me.lbl_xbis.TabIndex = 12
        Me.lbl_xbis.Text = "Label2"
        '
        'lbl_ybis
        '
        Me.lbl_ybis.AutoSize = True
        Me.lbl_ybis.Location = New System.Drawing.Point(382, 77)
        Me.lbl_ybis.Name = "lbl_ybis"
        Me.lbl_ybis.Size = New System.Drawing.Size(41, 15)
        Me.lbl_ybis.TabIndex = 13
        Me.lbl_ybis.Text = "Label2"
        '
        'lbl_plateau
        '
        Me.lbl_plateau.AutoSize = True
        Me.lbl_plateau.Location = New System.Drawing.Point(523, 35)
        Me.lbl_plateau.Name = "lbl_plateau"
        Me.lbl_plateau.Size = New System.Drawing.Size(41, 15)
        Me.lbl_plateau.TabIndex = 14
        Me.lbl_plateau.Text = "Label2"
        '
        'lbl_selection
        '
        Me.lbl_selection.AutoSize = True
        Me.lbl_selection.Location = New System.Drawing.Point(185, 107)
        Me.lbl_selection.Name = "lbl_selection"
        Me.lbl_selection.Size = New System.Drawing.Size(41, 15)
        Me.lbl_selection.TabIndex = 15
        Me.lbl_selection.Text = "Label2"
        '
        'lbl_y0123
        '
        Me.lbl_y0123.AutoSize = True
        Me.lbl_y0123.Location = New System.Drawing.Point(495, 62)
        Me.lbl_y0123.Name = "lbl_y0123"
        Me.lbl_y0123.Size = New System.Drawing.Size(41, 15)
        Me.lbl_y0123.TabIndex = 16
        Me.lbl_y0123.Text = "Label2"
        '
        'lbl_x0123
        '
        Me.lbl_x0123.AutoSize = True
        Me.lbl_x0123.Location = New System.Drawing.Point(523, 50)
        Me.lbl_x0123.Name = "lbl_x0123"
        Me.lbl_x0123.Size = New System.Drawing.Size(41, 15)
        Me.lbl_x0123.TabIndex = 17
        Me.lbl_x0123.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 272)
        Me.Controls.Add(Me.lbl_x0123)
        Me.Controls.Add(Me.lbl_y0123)
        Me.Controls.Add(Me.lbl_selection)
        Me.Controls.Add(Me.lbl_plateau)
        Me.Controls.Add(Me.lbl_ybis)
        Me.Controls.Add(Me.lbl_xbis)
        Me.Controls.Add(Me.btn_retour)
        Me.Controls.Add(Me.lbl_erreur)
        Me.Controls.Add(Me.lbl_y)
        Me.Controls.Add(Me.lbl_x)
        Me.Controls.Add(Me.lbl_tableau)
        Me.Controls.Add(Me.edt_cibleY)
        Me.Controls.Add(Me.edt_attaquantY)
        Me.Controls.Add(Me.edt_cibleX)
        Me.Controls.Add(Me.edt_attaquantX)
        Me.Controls.Add(Me.lbl_attaque)
        Me.Controls.Add(Me.btn_valider)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_valider As Button
    Friend WithEvents lbl_attaque As Label
    Friend WithEvents edt_attaquantX As TextBox
    Friend WithEvents edt_cibleX As TextBox
    Friend WithEvents edt_attaquantY As TextBox
    Friend WithEvents edt_cibleY As TextBox
    Friend WithEvents lbl_tableau As Label
    Friend WithEvents lbl_x As Label
    Friend WithEvents lbl_y As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_erreur As Label
    Friend WithEvents btn_retour As Button
    Friend WithEvents lbl_xbis As Label
    Friend WithEvents lbl_ybis As Label
    Friend WithEvents lbl_plateau As Label
    Friend WithEvents lbl_selection As Label
    Friend WithEvents lbl_y0123 As Label
    Friend WithEvents lbl_x0123 As Label
End Class
