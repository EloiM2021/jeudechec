Public Class Form1

    Dim pb As New PictureBox
    Dim PieceSelect As String
    Dim cibleX As Integer
    Dim cibleY As Integer
    Dim cibleCase As String
    Dim posX As Integer
    Dim posY As String
    Dim board(,) As String =
        {{"bR", "bN", "bB", "bQ", "bK", "bB", "bN", "bR"},
        {"bp", "bp", "bp", "bp", "bp", "bp", "bp", "bp"},
        {"__", "__", "__", "__", "__", "__", "__", "__"},
        {"__", "__", "__", "__", "__", "__", "__", "__"},
        {"__", "__", "__", "__", "__", "__", "__", "__"},
        {"__", "__", "__", "__", "__", "__", "__", "__"},
        {"wp", "wp", "wp", "wp", "wp", "wp", "wp", "wp"},
        {"wR", "wN", "wB", "wQ", "wK", "wB", "wN", "wR"}}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_attaque.Text = "Attaque en:"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_valider.Click

        posX = edt_attaquantX.Text
        posY = edt_attaquantY.Text
        PieceSelect = board(posX, posY)

        cibleX = edt_cibleX.Text
        cibleY = edt_cibleY.Text
        cibleCase = board(cibleX, cibleY)

    End Sub
    Private Function Affichage()
        board
    End Function
End Class

