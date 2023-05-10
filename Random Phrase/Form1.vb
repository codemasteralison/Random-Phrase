


Public Class Form1
    Dim strWord As String

    Private Sub btnNewWord_Click(sender As Object, e As EventArgs)
        ' Determine whether the word contains five letters.

        'If txtWord.Text.Trim.ToUpper Like "[A-Z][A-Z][A-Z][A-Z][A-Z]" Then
        '    grpWord.Enabled = False
        '    grpLetter.Enabled = True
        '    lblResult.Text = "-----"
        '    txtLetter.Focus()
        'Else
        '    MessageBox.Show("Please enter 5 letters.", "Guess the Word Game",
        '                    MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sr As New System.IO.StreamReader("C:\Users\avaughan2527\Documents\wheel.txt")
        Dim sr2 As New System.IO.StreamReader("C:\Users\avaughan2527\Documents\wheel.txt")
        Dim index As Integer = 0
        Dim currentline As Integer = 0
        Dim random As Integer = 5

        Do Until sr.EndOfStream = True
            sr.ReadLine()
            index += 1
        Loop

        Randomize()
        random = Rnd() * index
        Do Until currentline = random
            strWord = sr2.ReadLine
            currentline += 1
        Loop
        lblResult.Text = ""
        If strWord Like " " Then
            strWord.Replace(" ", "")

        End If

        For i As Integer = 1 To Len(strWord.TrimEnd)
            If strWord = " " Then

            End If
            lblResult.Text += "-" + " "
        Next
    End Sub
    Private Sub btnTryLetter_Click(sender As Object, e As EventArgs) Handles btnTryLetter.Click
        ' Determine whether player 2 has guessed the word.

        Dim strLetter As String
        Dim strResult As String

        strLetter = txtLetter.Text.Trim
        strResult = lblResult.Text

        'MsgBox(strLetter & strWord & strResult)

        Label2.Text = strWord
        If strWord.Contains(strLetter) Then
            ' Replace the hyphen(s) in strResult.
            For intIndex As Integer = 0 To strWord.Length - 1
                If strWord(intIndex) = strLetter Then
                    strResult = strResult.Remove(intIndex * 2, 1)
                    strResult = strResult.Insert(intIndex * 2, strLetter)
                End If
            Next intIndex
            ' Display the contents of strResult.
            lblResult.Text = strResult

            ' Determine whether strResult contains any hyphens.
            If strResult.Contains("-") = False Then
                MessageBox.Show("You guessed it: " & strWord,
"Guess the Word Game",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
                grpLetter.Enabled = False
                lblResult.Text = String.Empty
                Label2.Focus()
            End If
        Else
            MessageBox.Show("Try again!", "Guess the Word Game",
                 MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        txtLetter.Text = String.Empty
    End Sub

    Private Sub txtLetter_Enter(sender As Object, e As EventArgs) Handles txtLetter.Enter
        txtLetter.SelectAll()
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        Dim strA As String
        Dim strLetter As String
        Dim strResult As String

        strLetter = txtLetter.Text.Trim
        strResult = lblResult.Text.ToUpper

        strA = "A"
        btnA.Enabled = False
        If lblResult.Text.Contains(strA) Then
            For intIndex As Integer = 0 To strResult.Length - 1
                If strResult(intIndex) = strA Then

                    strLetter = strLetter.Insert(intIndex, strA)
                    strLetter = strLetter.Remove(intIndex + 1, 1)
                    strResult = strResult.Insert(intIndex, strA)
                    strResult = strResult.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = strResult

        Label2.Text = strWord
        If strWord.Contains(strA) Then
            ' Replace the hyphen(s) in strResult.
            For intIndex As Integer = 0 To strWord.Length - 1
                If strWord(intIndex) = strLetter Then
                    strResult = strResult.Remove(intIndex * 2, 1)
                    strResult = strResult.Insert(intIndex * 2, strLetter)
                End If
            Next intIndex
            ' Display the contents of strResult.
            lblResult.Text = strResult

            If strResult.Contains("-") = False Then
                MessageBox.Show("You guessed it: " & strWord,
"Guess the Word Game",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
                grpLetter.Enabled = False
                lblResult.Text = String.Empty
                Label2.Focus()
            End If
        Else
            MessageBox.Show("Try again!", "Guess the Word Game",
             MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        txtLetter.Text = String.Empty
        MsgBox(strWord & " " & strA)
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        Dim strB As String
        Dim strLetter As String
        Dim strResult As String

        strLetter = txtLetter.Text.Trim
        strResult = lblResult.Text

        strB = "B"
        btnB.Enabled = False
        If lblResult.Text.Contains(strB) Then
            For intIndex As Integer = 0 To strResult.Length - 1
                If strResult(intIndex) = strB Then

                    strLetter = strLetter.Insert(intIndex, strB)
                    strLetter = strLetter.Remove(intIndex + 1, 1)
                    strResult = strResult.Insert(intIndex, strB)
                    strResult = strResult.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = strResult
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        Dim strC As String
        Dim strLetter As String
        Dim strResult As String

        strLetter = txtLetter.Text.Trim
        strResult = lblResult.Text

        strC = "C"
        btnC.Enabled = False
        If lblResult.Text.Contains(strC) Then
            For intIndex As Integer = 0 To strResult.Length - 1
                If strResult(intIndex) = strC Then

                    strLetter = strLetter.Insert(intIndex, strC)
                    strLetter = strLetter.Remove(intIndex + 1, 1)
                    strResult = strResult.Insert(intIndex, strC)
                    strResult = strResult.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = strResult
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        Dim strD As String
        Dim strLetter As String
        Dim strResult As String

        strLetter = txtLetter.Text.Trim
        strResult = lblResult.Text

        strD = "D"
        btnD.Enabled = False
        If lblResult.Text.Contains(strD) Then
            For intIndex As Integer = 0 To strResult.Length - 1
                If strResult(intIndex) = strD Then

                    strLetter = strLetter.Insert(intIndex, strD)
                    strLetter = strLetter.Remove(intIndex + 1, 1)
                    strResult = strResult.Insert(intIndex, strD)
                    strResult = strResult.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = strResult
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        Dim strE As String
        Dim strLetter As String
        Dim strResult As String

        strLetter = txtLetter.Text.Trim
        strResult = lblResult.Text

        strE = "E"
        btnE.Enabled = False
        If lblResult.Text.Contains(strE) Then
            For intIndex As Integer = 0 To strResult.Length - 1
                If strResult(intIndex) = strE Then

                    strLetter = strLetter.Insert(intIndex, strE)
                    strLetter = strLetter.Remove(intIndex + 1, 1)
                    strResult = strResult.Insert(intIndex, strE)
                    strResult = strResult.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = strResult

        Label2.Text = strWord
        If strWord.Contains(strE) Then
            ' Replace the hyphen(s) in strResult.
            For intIndex As Integer = 0 To strWord.Length - 1
                If strWord(intIndex) = strLetter Then
                    strResult = strResult.Remove(intIndex * 2, 1)
                    strResult = strResult.Insert(intIndex * 2, strLetter)
                End If
            Next intIndex
            ' Display the contents of strResult.
            lblResult.Text = strResult

            If strResult.Contains("-") = False Then
                MessageBox.Show("You guessed it: " & strWord,
"Guess the Word Game",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
                grpLetter.Enabled = False
                lblResult.Text = String.Empty
                Label2.Focus()
            End If
        Else
            MessageBox.Show("Try again!", "Guess the Word Game",
             MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        txtLetter.Text = String.Empty


    End Sub
End Class
