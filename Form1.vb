Public Class Form1
    Dim board(,) As String =
        {{"bR", "bN", "bB", "bQ", "bK", "bB", "bN", "bR"},
        {"bp", "bp", "bp", "bp", "bp", "bp", "bp", "bp"},
        {"__", "__", "__", "__", "__", "__", "__", "__"},
        {"__", "__", "__", "__", "__", "__", "__", "__"},
        {"__", "__", "__", "__", "__", "__", "__", "__"},
        {"__", "__", "__", "__", "__", "__", "__", "__"},
        {"wp", "wp", "wp", "wp", "wp", "wp", "wp", "wp"},
        {"wR", "wN", "wB", "wQ", "wK", "wB", "wK", "wR"}}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 1080
        Me.Width = 1920
        tbl_tableau.Width = 900
        tbl_tableau.Height = 900
        tbl_tableau.RowCount = 8
        tbl_tableau.ColumnCount = 8
        tbl_tableau.BackgroundImage = jeudechec.My.Resources.echecdamier
        tbl_tableau.Top = 70
        tbl_tableau.Left = 510
        tbl_tableau.BackgroundImageLayout = ImageLayout.Stretch

    End Sub

    Public Class pion
        Public position As Integer()
        Public deplacement As Integer()
        Public couleur As String

        Public Sub New(pos As Integer(), col As String)
            position = pos
            couleur = col
        End Sub

        Public Sub SetPosition(pos As Integer())
            position = pos
        End Sub

        Public Function GetPosition() As Integer()
            Return position
        End Function

        Public Sub SetCouleur(col As String)
            couleur = col
        End Sub

        Public Function GetCouleur() As String
            Return couleur
        End Function



    End Class
End Class
