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
        Me.btn_affichage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_valider
        '
        Me.btn_valider.Location = New System.Drawing.Point(57, 113)
        Me.btn_valider.Name = "btn_valider"
        Me.btn_valider.Size = New System.Drawing.Size(87, 42)
        Me.btn_valider.TabIndex = 0
        Me.btn_valider.Text = "Button1"
        Me.btn_valider.UseVisualStyleBackColor = True
        '
        'lbl_attaque
        '
        Me.lbl_attaque.AutoSize = True
        Me.lbl_attaque.Location = New System.Drawing.Point(251, 127)
        Me.lbl_attaque.Name = "lbl_attaque"
        Me.lbl_attaque.Size = New System.Drawing.Size(41, 15)
        Me.lbl_attaque.TabIndex = 1
        Me.lbl_attaque.Text = "Label1"
        '
        'edt_attaquantX
        '
        Me.edt_attaquantX.Location = New System.Drawing.Point(221, 90)
        Me.edt_attaquantX.Name = "edt_attaquantX"
        Me.edt_attaquantX.Size = New System.Drawing.Size(100, 23)
        Me.edt_attaquantX.TabIndex = 2
        '
        'edt_cibleX
        '
        Me.edt_cibleX.Location = New System.Drawing.Point(221, 155)
        Me.edt_cibleX.Name = "edt_cibleX"
        Me.edt_cibleX.Size = New System.Drawing.Size(100, 23)
        Me.edt_cibleX.TabIndex = 4
        '
        'edt_attaquantY
        '
        Me.edt_attaquantY.Location = New System.Drawing.Point(374, 90)
        Me.edt_attaquantY.Name = "edt_attaquantY"
        Me.edt_attaquantY.Size = New System.Drawing.Size(100, 23)
        Me.edt_attaquantY.TabIndex = 3
        '
        'edt_cibleY
        '
        Me.edt_cibleY.Location = New System.Drawing.Point(374, 155)
        Me.edt_cibleY.Name = "edt_cibleY"
        Me.edt_cibleY.Size = New System.Drawing.Size(100, 23)
        Me.edt_cibleY.TabIndex = 5
        '
        'lbl_tableau
        '
        Me.lbl_tableau.AutoSize = True
        Me.lbl_tableau.Location = New System.Drawing.Point(329, 222)
        Me.lbl_tableau.Name = "lbl_tableau"
        Me.lbl_tableau.Size = New System.Drawing.Size(41, 15)
        Me.lbl_tableau.TabIndex = 6
        Me.lbl_tableau.Text = "Label1"
        '
        'lbl_x
        '
        Me.lbl_x.AutoSize = True
        Me.lbl_x.Location = New System.Drawing.Point(251, 72)
        Me.lbl_x.Name = "lbl_x"
        Me.lbl_x.Size = New System.Drawing.Size(38, 15)
        Me.lbl_x.TabIndex = 7
        Me.lbl_x.Text = "label3"
        '
        'lbl_y
        '
        Me.lbl_y.AutoSize = True
        Me.lbl_y.Location = New System.Drawing.Point(403, 72)
        Me.lbl_y.Name = "lbl_y"
        Me.lbl_y.Size = New System.Drawing.Size(41, 15)
        Me.lbl_y.TabIndex = 8
        Me.lbl_y.Text = "Label2"
        '
        'btn_affichage
        '
        Me.btn_affichage.Location = New System.Drawing.Point(120, 243)
        Me.btn_affichage.Name = "btn_affichage"
        Me.btn_affichage.Size = New System.Drawing.Size(101, 66)
        Me.btn_affichage.TabIndex = 9
        Me.btn_affichage.Text = "Button1"
        Me.btn_affichage.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 665)
        Me.Controls.Add(Me.btn_affichage)
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
    Friend WithEvents btn_affichage As Button
End Class
