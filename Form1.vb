Public Class Form1
    Dim pionblanc As pion = New pion({3, 2}, "blanc")
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
