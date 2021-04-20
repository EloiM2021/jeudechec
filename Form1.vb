Public Class Form1
    Dim whatobject As Object
    Dim pionblanc1 As pion = New pion({0, 1}, "blanc")
    Dim pionnoir1 As pion = New pion({0, 6}, "noir")

    'test guthub



    Dim pb As New PictureBox
    Dim board(,) As Integer =
        {{3, 2, 4, 5, 6, 4, 2, 3},
        {1, 1, 1, 1, 1, 1, 1, 1},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {1, 1, 1, 1, 1, 1, 1, 1},
        {3, 2, 4, 5, 6, 4, 2, 3}}

    'rien : 0
    'pion : 1
    'cavalier : 2
    'tour : 3
    'fou: 4
    'dame : 5
    'roi : 6

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 1080
        Me.Width = 1920
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        'jeudechec.My.Resources.wp

    End Sub

    Private Function test_positions()
        Select Case whatobject
            Case 1
                If whatobject = pionblanc1 Then

                End If

            Case 2

            Case 3

            Case 4

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

Public Class roi
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