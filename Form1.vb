Public Class Form1

    Dim pb As New PictureBox
    Dim PieceSelect As String
    Dim cibleX As Integer
    Dim cibleY As Integer
    Dim cibleCase As String
    Dim posX As Integer
    Dim posY As Integer
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
        lbl_tableau.ResetText()
        posX = edt_attaquantX.Text
        posY = edt_attaquantY.Text
        PieceSelect = board(posX, posY)

        cibleX = edt_cibleX.Text
        cibleY = edt_cibleY.Text
        cibleCase = board(cibleX, cibleY)
        Affichage()
    End Sub
    Private Function Affichage()
        board(posX, posY) = "__"
        board(cibleX, cibleY) = PieceSelect
        For i = 0 To 7

            For j = 0 To 7
                If j = 0 Then
                    lbl_tableau.Text = lbl_tableau.Text + vbCr + board(i, j)
                Else
                    lbl_tableau.Text = lbl_tableau.Text + board(i, j)
                    'ajouter espace 
                End If
            Next
        Next
        Return 0
    End Function
End Class

