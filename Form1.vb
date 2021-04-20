Public Class Form1
    Dim whatobject As Object
    Dim pionblanc1 As pion = New pion({0, 1}, "blanc")
    Dim pionnoir1 As pion = New pion({0, 6}, "noir")

    'test guthub




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
        Label2.Text = "bonjour"
        pb.BackgroundImage = jeudechec.My.Resources.wp
        Me.Height = 1080
        Me.Width = 1920
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        tbl_tableau.Width = 900
        tbl_tableau.Height = 900
        tbl_tableau.RowCount = 8
        tbl_tableau.ColumnCount = 8
        tbl_tableau.BackgroundImageLayout = ImageLayout.Stretch
        tbl_tableau.Top = 70
        tbl_tableau.Left = 510
        tbl_tableau.Controls.Add(Label2, 2, 2)
        tbl_tableau.ForeColor = Color.Blue


        Case 5

        Case 6

        End Select
        End Function

End Class
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

Public Class cavalier
    Public deplacement As Integer()
    Public couleur As String

    Public Sub New(col As String)
        couleur = col
    End Sub
    Public Sub SetCouleur(col As String)
        couleur = col
    End Sub
    Public Function Getcouleur() As String
        Return couleur
    End Function
End Class

Public Class tour
    Public deplacement As Integer()
    Public couleur As String

    Public Sub New(col As String)
        couleur = col
    End Sub
    Public Sub SetCouleur(col As String)
        couleur = col
    End Sub
    Public Function Getcouleur() As String
        Return couleur
    End Function
End Class

Public Class fou
    Public deplacement As Integer()
    Public couleur As String

    Public Sub New(col As String)
        couleur = col
    End Sub
    Public Sub SetCouleur(col As String)
        couleur = col
    End Sub
    Public Function Getcouleur() As String
        Return couleur
    End Function
End Class

Public Class dame
    Public deplacement As Integer()
    Public couleur As String

End Class
End Class
