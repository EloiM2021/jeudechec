Public Class Form1
    Dim whatobject As Object
    Dim actualposition As Integer
    Dim posX As Integer
    Dim posY As Integer
    Dim posX_toreach As Integer
    Dim posY_toreach As Integer
    Dim bp, wp, bR, bN, bB, bQ, bK, wR, wN, wB, wQ, wK As String

    Dim pb As New PictureBox
    Dim PieceSelect As String
    Dim cibleX As Integer
    Dim cibleY As Integer
    Dim cibleCase As String
    Dim board(,) As String =
        {{"bR", "bN", "bB", "bQ", "bK", "bB", "bN", "bR"},
        {"bp", "bp", "bp", "bp", "bp", "bp", "bp", "bp"},
        {"__", "__", "__", "__", "__", "__", "__", "__"},
        {"__", "__", "__", "__", "__", "__", "__", "__"},
        {"__", "__", "__", "__", "__", "__", "__", "__"},
        {"__", "__", "__", "__", "__", "__", "__", "__"},
        {"__", "__", "__", "__", "__", "__", "__", "__"},
        {"wp", "wp", "wp", "wp", "wp", "wp", "wp", "wp"},
        {"wR", "wN", "wB", "wQ", "wK", "wB", "wN", "wR"}}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 1080
        Me.Width = 1920
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        'jeudechec.My.Resources.wp
        lbl_attaque.Text = "Attaque en:"
    End Sub

    Private Function test_positions()
        Select Case whatobject
            Case 1
                If whatobject = bp Or wp Then
                    If cibleX = posX + 1 Or posX - 1 And cibleY = posY + 1 Or posY - 1 Then

                    Else
                        MsgBox("position demandée impossible")
                    End If
                End If

            Case 2
                If whatobject = bN Or wN Then
                    If cibleX = posX + 1 Or posX - 1 And cibleY = posY + 3 Or posY - 3 OrElse cibleX = posX + 3 Or posX - 3 And cibleY = posY + 1 Or posY - 1 Then

                    Else
                        MsgBox("position demandée impossible")
                    End If
                End If
            Case 3
                If whatobject = bR Or wR Then
                    If cibleX = posX + 10 Or posX - 10 And cibleY = posY OrElse cibleX = posX And cibleY = posY + 10 Or posY - 10 Then

                    Else
                        MsgBox("position demandée impossible")
                    End If
                End If
            Case 4
                If whatobject = wB Or bB Then
                    If cibleX = posX + 1 And cibleY = posY + 1 Or cibleX = posX - 1 And cibleY = posY - 1 Then

                    Else
                        MsgBox("position demandée impossible")
                    End If
                End If
                    Case 5

            Case 6

        End Select
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_valider.Click

        posX = edt_attaquantX.Text
        posY = edt_attaquantY.Text
        PieceSelect = board(posX, posY)

        cibleX = edt_cibleX.Text
        cibleY = edt_cibleY.Text
        cibleCase = board(cibleX, cibleY)

    End Sub
    Private Function Affichage()

    End Function
End Class

