Public Class Form1

    Dim pb As New PictureBox
    Dim board(,) As String =
        {{"bR", "bN", "bB", "bQ", "bK", "bB", "bN", "bR"},
        {"bp", "bp", "bp", "bp", "bp", "bp", "bp", "bp"},
        {"__", "__", "__", "__", "__", "__", "__", "__"},
        {"__", "__", "__", "__", "__", "__", "__", "__"},
        {"__", "_", "__", "__", "__", "__", "__", "__"},
        {"__", "__", "_", "__", "__", "__", "__", "__"},
        {"wp", "wp", "wp", "wp", "wp", "wp", "wp", "wp"},
        {"wR", "wN", "wB", "wQ", "wK", "wB", "wK", "wR"}}

    'rien : 0
    'pion : 1
    'cavalier : 2
    'tour : 3
    'fou: 4
    'dame : 5
    'roi : 6

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.Height = 1080
        'Me.Width = 1920
        'Me.FormBorderStyle = FormBorderStyle.FixedSingle

        'edt_tableau.Text = board

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_valider.Click

    End Sub
End Class
' vérifier quel numéro sur la case 
'ensuite switch case 
