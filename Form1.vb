Public Class Form1
    Dim pionblanc As pion = New pion()
    Dim pb As New PictureBox
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
        Label2.Text = "bonjour"
        pb.BackgroundImage = jeudechec.My.Resources.wp
        pionblanc.imagepion = jeudechec.My.Resources.echecdamier
        Me.Height = 1080
        Me.Width = 1920
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        tbl_tableau.Width = 900
        tbl_tableau.Height = 900
        tbl_tableau.RowCount = 8
        tbl_tableau.ColumnCount = 8
        'tbl_tableau.BackgroundImage = jeudechec.My.Resources.echecdamier
        tbl_tableau.BackgroundImageLayout = ImageLayout.Stretch
        tbl_tableau.Top = 70
        tbl_tableau.Left = 510
        tbl_tableau.Controls.Add(Label2, 2, 2)
        tbl_tableau.ForeColor = Color.Blue
        'tbl_tableau.BackColor = Color.Blue
    End Sub
End Class


Public Class pion
    Public imagepion As Image
    Public movementspion As Integer

    Public Sub pion_load(pion As Object, e As EventArgs)
        imagepion = jeudechec.My.Resources.wp
        pion.tab
    End Sub
End Class
