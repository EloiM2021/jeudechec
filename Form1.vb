Public Class Form1
    Dim whatobject As Object
    Dim actualposition As Integer
    Dim posX As Integer
    Dim posY As Integer
    Dim posX_toreach As Integer
    Dim posY_toreach As Integer
    Dim bp, wp, bR, bN, bB, bQ, bK, wR, wN, wB, wQ, wK As String

    Dim pb As New PictureBox
    Dim board(,) As String =
        {{"bR", "bN", "bB", "bQ", "bK", "bB", "bN", "bR"},
        {"bp", "bp", "bp", "bp", "bp", "bp", "bp", "bp"},
        {"__", "__", "__", "__", "__", "__", "__", "__"},
        {"__", "__", "__", "__", "__", "__", "__", "__"},
        {"__", "_", "__", "__", "__", "__", "__", "__"},
        {"__", "__", "__", "__", "__", "__", "__", "__"},
        {"wp", "wp", "wp", "wp", "wp", "wp", "wp", "wp"},
        {"wR", "wN", "wB", "wQ", "wK", "wB", "wN", "wR"}}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 1080
        Me.Width = 1920
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        'jeudechec.My.Resources.wp

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
                    If  Then

                    End If

                End If
            Case 3

            Case 4

            Case 5

            Case 6

        End Select
    End Function

End Class

