Public Class Form1
    Dim whatobject As String
    Dim actualposition As Integer
    Dim posX As Integer
    Dim posY As Integer
    Dim posX_toreach As Integer
    Dim posY_toreach As Integer
    Dim max_cibleX As Integer
    Dim max_cibleY As Integer
    Dim cibleX As Integer
    Dim cibleY As Integer

    Dim pb As New PictureBox

    Dim PieceSelect As String

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_x.Click

    End Sub


    Dim cibleCase As String
    Dim board(,) As String =
        {{"bR", "bN", "bB", "bQ", "bK", "bB", "bN", "bR"},
        {"bp", "bp", "bp", "bp", "bp", "bp", "bp", "bp"},
        {"___", "___", "___", "___", "___", "___", "___", "___"},
        {"___", "___", "___", "___", "___", "___", "___", "___"},
        {"___", "___", "___", "___", "___", "___", "___", "___"},
        {"___", "___", "___", "___", "___", "___", "___", "___"},
        {"wp", "wp", "wp", "wp", "wp", "wp", "wp", "wp"},
        {"wR", "wN", "wB", "wQ", "wK", "wB", "wN", "wR"}}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_attaque.Text = "Attaque en:"
        btn_valider.Text = "valider"
        lbl_x.Text = "X"
        lbl_y.Text = "y"

    End Sub

    Private Function test_positions(i As String)
        Select Case i
            Case "bp"
                If cibleX = posX And cibleY = posY + 1 Then
                    Affichage()
                Else
                    MessageBox.Show("position demandée impossible")
                End If

            Case "bN" Or "wN"
                If cibleX = posX + 1 Or cibleX = posX - 1 And cibleY = posY + 3 Or cibleY = posY - 3 OrElse cibleX = posX + 3 Or cibleX = posX - 3 And cibleY = posY + 1 Or cibleY = posY - 1 Then
                    Affichage()
                Else
                    MessageBox.Show("position demandée impossible")
                End If
            Case "bR" Or "wR"
                tour()
            Case "wB" Or "bB"
                If cibleX = posX + 1 And cibleY = posY + 1 Or cibleX = posX - 1 And cibleY = posY - 1 Then
                    Affichage()
                Else
                    MessageBox.Show("position demandée impossible")
                End If
            Case "wp"
                If cibleX = posX + 1 And cibleY = posY Then
                    Affichage()
                Else
                    MessageBox.Show("position demandée impossible")
                End If
            Case "bQ" Or "wQ"
                If cibleX Then

                End If

            Case "bK" Or "wK"
                If cibleX = posX - 1 Or cibleX = posX + 1 Or cibleY = posY - 1 Or cibleY = posY + 1 Or cibleX = posX - 1 And cibleY = posY - 1 Or cibleX = posX - 1 And cibleY = posY + 1 Or cibleX = posX + 1 And cibleY = posY + 1 Or cibleX = posX + 1 And cibleY = posY - 1 Then
                    Affichage()
                Else
                    MessageBox.Show("position demandée impossible")
                End If
                If cibleX = posX - 1 Or cibleX = posX + 1 Or cibleY = posY - 1 Or cibleY = posY + 1 Or cibleX = posX - 1 And cibleY = posY - 1 Or cibleX = posX - 1 And cibleY = posY + 1 Then


                End If

        End Select
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        lbl_tableau.ResetText()

        posX = edt_attaquantX.Text
        posY = edt_attaquantY.Text
        cibleX = edt_cibleX.Text
        cibleY = edt_cibleY.Text

        PieceSelect = board(posY, posX)
        cibleCase = board(cibleY, cibleX)

        MessageBox.Show(PieceSelect)

        test_positions(PieceSelect)
        'verification de coup non fraticide
        If PieceSelect = "bR" Or PieceSelect = "bN" Or PieceSelect = "bB" Or PieceSelect = "bQ" Or PieceSelect = "bK" Or PieceSelect = "bp" Then
            If cibleCase = "wR" Or cibleCase = "wN" Or cibleCase = "wB" Or cibleCase = "wQ" Or cibleCase = "wK" Or cibleCase = "___" Or cibleCase = "wp" Then
            Else
                MessageBox.Show("Coup invalide car fraticide")
                Exit Sub
            End If
        ElseIf PieceSelect = "wR" Or PieceSelect = "wN" Or PieceSelect = "wB" Or PieceSelect = "wQ" Or PieceSelect = "wK" Or PieceSelect = "wp" Then

            If cibleCase = "bR" Or cibleCase = "bN" Or cibleCase = "bB" Or cibleCase = "bQ" Or cibleCase = "bK" Or cibleCase = "bp" Or cibleCase = "___" Then
            Else
                MessageBox.Show("Coup invalide car fraticide")
                Exit Sub
            End If
        End If

        Affichage()

    End Sub
    Private Function Affichage()
        board(posY, posX) = "___"
        board(cibleY, cibleX) = PieceSelect
        For i = 0 To 7

            For j = 0 To 7
                If j = 0 Then
                    lbl_tableau.Text = lbl_tableau.Text + vbCr + board(i, j) + "  "
                Else
                    lbl_tableau.Text = lbl_tableau.Text + board(i, j) + "  "
                End If
            Next
        Next
        'MessageBox.Show(PieceSelect)
        Return 0
    End Function
    Private Function tour()
        If posX = 0 Then
            max_cibleX = 7
        ElseIf posX = 7 Then
            max_cibleX = 0
        End If

        If cibleX > max_cibleX Or cibleX < 0 Then
            MessageBox.Show("ce déplacement est impossible")
        End If

        If posY = 0 Then
            max_cibleY = 7
        ElseIf posY = 7 Then
            max_cibleY = 0
        End If

        If cibleY > max_cibleY Or cibleY < 0 Then
            MessageBox.Show("ce déplacement est impossible")
        End If
    End Function

    Private Function reine()
        If posX = 0 Then
            max_cibleX = 7
        ElseIf posX = 7 Then
            max_cibleX = 0
        End If

        If cibleX > max_cibleX Or cibleX < 0 Then
            MessageBox.Show("ce déplacement est impossible")
        End If

        If posY = 0 Then
            max_cibleY = 7
        ElseIf posY = 7 Then
            max_cibleY = 0
        End If

        If cibleY > max_cibleY Or cibleY < 0 Then
            MessageBox.Show("ce déplacement est impossible")
        End If
    End Function

    Private Function fou()
        If posY = 0 Or posY = 7 Then
            max_cibleY = 7 And max_cibleY = 0
        End If
    End Function
End Class

