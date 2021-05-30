Public Class Form1
    Dim posX As Integer
    Dim posY As Integer
    Dim cibleX As Integer
    Dim cibleY As Integer
    Dim PieceSelect As String


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
    Dim save(,) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_retour.Enabled = False
        save = board
        lbl_selection.Text = "Selection"
        lbl_plateau.Text = "Plateau:"
        btn_retour.Text = "Retour"
        lbl_attaque.Text = "Attaque en:"
        btn_valider.Text = "valider"
        lbl_x.Text = "X"
        lbl_y.Text = "Y"
        lbl_xbis.Text = "X"
        lbl_ybis.Text = "Y"
        edt_attaquantX.MaxLength = 1
        edt_attaquantY.MaxLength = 1
        edt_cibleX.MaxLength = 1
        edt_cibleY.MaxLength = 1
        lbl_erreur.Text = ("Remplissez tous les champs")
        lbl_erreur.Hide()
        lbl_tableau.ResetText()
        lbl_x0123.Text = ("0     1     2     3     4     5     6     7")
        lbl_y0123.Text = ("")
        For i = 0 To 7
            lbl_y0123.Text = lbl_y0123.Text + vbCr + CStr(i)
        Next

        For i = 0 To 7

            For j = 0 To 7
                If j = 0 Then
                    lbl_tableau.Text = lbl_tableau.Text + vbCr + board(i, j) + "  "
                Else
                    lbl_tableau.Text = lbl_tableau.Text + board(i, j) + "  "
                End If
            Next
        Next

    End Sub

    Private Function test_positions(PosArg As String) As String
        Select Case PosArg

            Case "bp"
                If cibleX = posX And cibleY = posY + 1 Then
                    Affichage()
                ElseIf (cibleX = posX - 1 And cibleY = posY + 1) Or (cibleX = posX + 1 And cibleY = posY + 1) Then
                    If cibleCase = "wR" Or cibleCase = "wN" Or cibleCase = "wB" Or cibleCase = "wQ" Or cibleCase = "wK" Or cibleCase = "wp" Then
                        Affichage()
                    Else
                        erreur()
                    End If
                ElseIf posY = 1 And cibleY = 3 And posX = cibleX Then
                    Affichage()
                Else
                    erreur()
                End If


            Case "bN", "wN"
                If cibleX = posX + 1 And cibleY = posY + 3 Or cibleX = posX - 1 And cibleY = posY + 3 Or cibleX = posX + 1 And cibleY = posY - 3 Or cibleX = posX + 1 And cibleY = posY - 3 OrElse cibleX = posX + 3 And cibleY = posY + 1 Or cibleX = posX - 3 And cibleY = posY + 1 Or cibleY = posY - 1 Then
                    Affichage()
                Else
                    erreur()
                End If

            Case "bR", "wR"
                If cibleX = posX + 1 And cibleY = posY Or cibleX = posX + 2 And cibleY = posY Or cibleX = posX + 3 And cibleY = posY Or cibleX = posX + 4 And cibleY = posY Or cibleX = posX + 5 And cibleY = posY Or cibleX = posX + 6 And cibleY = posY Or cibleX = posX + 7 And cibleY = posY Or cibleX = posX And cibleY = posY + 1 Or cibleX = posX And cibleY = posY + 2 Or cibleX = posX And cibleY = posY + 3 Or cibleX = posX And cibleY = posY + 4 Or cibleX = posX And cibleY = posY + 5 Or cibleX = posX And cibleY = posY + 6 Or cibleX = posX And cibleY = posY + 7 Or cibleX = posX - 1 And cibleY = posY Or cibleX = posX - 2 And cibleY = posY Or cibleX = posX - 3 And cibleY = posY Or cibleX = posX - 4 And cibleY = posY Or cibleX = posX - 5 And cibleY = posY Or cibleX = posX - 6 And cibleY = posY Or cibleX = posX - 7 And cibleY = posY Or cibleX = posX And cibleY = posY - 1 Or cibleX = posX And cibleY = posY - 2 Or cibleX = posX And cibleY = posY - 3 Or cibleX = posX And cibleY = posY - 4 Or cibleX = posX And cibleY = posY - 5 Or cibleX = posX And cibleY = posY - 6 Or cibleX = posX And cibleY = posY - 7 Then
                    Affichage()
                Else
                    erreur()
                End If


            Case "wB", "bB"
                If cibleX = posX + 1 And cibleY = posY + 1 Or cibleX = posX - 1 And cibleY = posY - 1 Or cibleX = posX + 1 And cibleY = posY - 1 Or cibleX = posX - 1 And cibleY = posY + 1 Or cibleX = posX + 2 And cibleY = posY + 2 Or cibleX = posX - 2 And cibleY = posY - 2 Or cibleX = posX + 2 And cibleY = posY - 2 Or cibleX = posX - 2 And cibleY = posY + 2 Or cibleX = posX + 3 And cibleY = posY + 3 Or cibleX = posX - 3 And cibleY = posY - 3 Or cibleX = posX + 3 And cibleY = posY - 3 Or cibleX = posX - 3 And cibleY = posY + 3 Or cibleX = posX + 4 And cibleY = posY + 4 Or cibleX = posX - 4 And cibleY = posY - 4 Or cibleX = posX + 4 And cibleY = posY - 4 Or cibleX = posX - 4 And cibleY = posY + 4 Or cibleX = posX + 5 And cibleY = posY + 5 Or cibleX = posX - 5 And cibleY = posY - 5 Or cibleX = posX + 5 And cibleY = posY - 5 Or cibleX = posX - 5 And cibleY = posY + 5 Or cibleX = posX + 6 And cibleY = posY + 6 Or cibleX = posX - 6 And cibleY = posY - 6 Or cibleX = posX + 6 And cibleY = posY - 6 Or cibleX = posX - 6 And cibleY = posY + 6 Or cibleX = posX + 7 And cibleY = posY + 7 Or cibleX = posX - 7 And cibleY = posY - 7 Or cibleX = posX + 7 And cibleY = posY - 7 Or cibleX = posX - 7 And cibleY = posY + 7 Then
                    Affichage()
                Else
                    erreur()
                End If

            Case "wp"
                If cibleX = posX And cibleY = posY - 1 Then
                    Affichage()
                ElseIf (cibleX = posX + 1 And cibleY = posY - 1) Or (cibleX = posX - 1 And cibleY = posY - 1) Then
                    If cibleCase = "bR" Or cibleCase = "bN" Or cibleCase = "bB" Or cibleCase = "bQ" Or cibleCase = "bK" Or cibleCase = "bp" Then
                        Affichage()
                    Else
                        erreur()
                    End If
                ElseIf posY = 7 And cibleY = 5 And posX = cibleX Then
                    Affichage()
                Else
                    erreur()
                End If

            Case "bQ", "wQ"
                If cibleX = posX + 1 And cibleY = posY + 1 Or cibleX = posX - 1 And cibleY = posY - 1 Or cibleX = posX + 1 And cibleY = posY - 1 Or cibleX = posX - 1 And cibleY = posY + 1 Or cibleX = posX + 2 And cibleY = posY + 2 Or cibleX = posX - 2 And cibleY = posY - 2 Or cibleX = posX + 2 And cibleY = posY - 2 Or cibleX = posX - 2 And cibleY = posY + 2 Or cibleX = posX + 3 And cibleY = posY + 3 Or cibleX = posX - 3 And cibleY = posY - 3 Or cibleX = posX + 3 And cibleY = posY - 3 Or cibleX = posX - 3 And cibleY = posY + 3 Or cibleX = posX + 4 And cibleY = posY + 4 Or cibleX = posX - 4 And cibleY = posY - 4 Or cibleX = posX + 4 And cibleY = posY - 4 Or cibleX = posX - 4 And cibleY = posY + 4 Or cibleX = posX + 5 And cibleY = posY + 5 Or cibleX = posX - 5 And cibleY = posY - 5 Or cibleX = posX + 5 And cibleY = posY - 5 Or cibleX = posX - 5 And cibleY = posY + 5 Or cibleX = posX + 6 And cibleY = posY + 6 Or cibleX = posX - 6 And cibleY = posY - 6 Or cibleX = posX + 6 And cibleY = posY - 6 Or cibleX = posX - 6 And cibleY = posY + 6 Or cibleX = posX + 7 And cibleY = posY + 7 Or cibleX = posX - 7 And cibleY = posY - 7 Or cibleX = posX + 7 And cibleY = posY - 7 Or cibleX = posX - 7 And cibleY = posY + 7 Or cibleX = posX + 1 And cibleY = posY Or cibleX = posX + 2 And cibleY = posY Or cibleX = posX + 3 And cibleY = posY Or cibleX = posX + 4 And cibleY = posY Or cibleX = posX + 5 And cibleY = posY Or cibleX = posX + 6 And cibleY = posY Or cibleX = posX + 7 And cibleY = posY Or cibleX = posX And cibleY = posY + 1 Or cibleX = posX And cibleY = posY + 2 Or cibleX = posX And cibleY = posY + 3 Or cibleX = posX And cibleY = posY + 4 Or cibleX = posX And cibleY = posY + 5 Or cibleX = posX And cibleY = posY + 6 Or cibleX = posX And cibleY = posY + 7 Or cibleX = posX - 1 And cibleY = posY Or cibleX = posX - 2 And cibleY = posY Or cibleX = posX - 3 And cibleY = posY Or cibleX = posX - 4 And cibleY = posY Or cibleX = posX - 5 And cibleY = posY Or cibleX = posX - 6 And cibleY = posY Or cibleX = posX - 7 And cibleY = posY Or cibleX = posX And cibleY = posY - 1 Or cibleX = posX And cibleY = posY - 2 Or cibleX = posX And cibleY = posY - 3 Or cibleX = posX And cibleY = posY - 4 Or cibleX = posX And cibleY = posY - 5 Or cibleX = posX And cibleY = posY - 6 Or cibleX = posX And cibleY = posY - 7 Then
                    Affichage()
                Else
                    erreur()
                End If

            Case "bK", "wK"
                If cibleX = posX + 1 And cibleY = posY + 1 Or cibleX = posX - 1 And cibleY = posY - 1 Or cibleX = posX + 1 And cibleY = posY - 1 Or cibleX = posX - 1 And cibleY = posY + 1 Or cibleX = posX + 1 And cibleY = posY Or cibleX = posX And cibleY = posY + 1 Then
                    Affichage()
                Else
                    erreur()
                End If
            Case "___"
                erreur()
        End Select
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        If edt_attaquantX.Text = Nothing Or edt_attaquantY.Text = Nothing Or edt_cibleX.Text = Nothing Or edt_cibleY.Text = Nothing Then
            lbl_erreur.Show()
            Exit Sub
        Else
            btn_retour.Enabled = True
            lbl_erreur.Hide()
            posX = edt_attaquantX.Text
            posY = edt_attaquantY.Text
            cibleX = edt_cibleX.Text
            cibleY = edt_cibleY.Text

            PieceSelect = board(posY, posX)
            retourpiece = PieceSelect
            cibleCase = board(cibleY, cibleX)
            retourcible = cibleCase
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
            test_positions(PieceSelect)
        End If

    End Sub
    Private Function Affichage()
        lbl_tableau.ResetText()
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
        Return 0
    End Function

    Private Function KeyBlocker(e As KeyPressEventArgs)

        If (e.KeyChar >= Chr(48) And e.KeyChar <= Chr(55)) Then
            Exit Function

        ElseIf e.KeyChar = Chr(8) Then

            Exit Function
        Else
            e.Handled = True
        End If
        Return 0
    End Function
    Private Sub edt_attaquantX_KeyPress(sender As Object, e As KeyPressEventArgs) Handles edt_attaquantX.KeyPress
        KeyBlocker(e)
    End Sub

    Private Sub edt_attaquantY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles edt_attaquantY.KeyPress
        KeyBlocker(e)
    End Sub

    Private Sub edt_cibleX_KeyPress(sender As Object, e As KeyPressEventArgs) Handles edt_cibleX.KeyPress
        KeyBlocker(e)
    End Sub

    Private Sub edt_cibleY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles edt_cibleY.KeyPress
        KeyBlocker(e)
    End Sub
    Private Function erreur()
        MessageBox.Show("position demandée impossible")
        edt_attaquantX.Text = ""
        edt_attaquantY.Text = ""
        edt_cibleX.Text = ""
        edt_cibleY.Text = ""
    End Function

    Private Sub btn_retour_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        lbl_tableau.Text = ""
        edt_attaquantX.Text = ""
        edt_attaquantY.Text = ""
        edt_cibleX.Text = ""
        edt_cibleY.Text = ""

        board(posY, posX) = PieceSelect
        board(cibleY, cibleX) = cibleCase
        For i = 0 To 7

            For j = 0 To 7
                If j = 0 Then
                    lbl_tableau.Text = lbl_tableau.Text + vbCr + board(i, j) + "  "
                Else
                    lbl_tableau.Text = lbl_tableau.Text + board(i, j) + "  "
                End If
            Next
        Next
    End Sub

End Class

