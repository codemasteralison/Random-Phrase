Public Class Form1


    Private Sub btnNewWord_Click(sender As Object, e As EventArgs) Handles btnNewWord.Click
        ' Determine whether the word contains five letters.

        If txtWord.Text.Trim.ToUpper Like "[A-Z][A-Z][A-Z][A-Z][A-Z]" Then
            grpWord.Enabled = False
            grpLetter.Enabled = True
            lblResult.Text = "-----"
            txtLetter.Focus()
        Else
            MessageBox.Show("Please enter 5 letters.", "Guess the Word Game",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnTryLetter_Click(sender As Object, e As EventArgs) Handles btnTryLetter.Click
        ' Determine whether player 2 has guessed the word.

        Dim strWord As String
        Dim strLetter As String
        Dim strResult As String

        strWord = txtWord.Text.Trim.ToUpper
        strLetter = txtLetter.Text.Trim.ToUpper
        strResult = lblResult.Text

        If strWord.Contains(strLetter) Then
            ' Replace the hyphen(s) in strResult.

            ' Display the contents of strResult.

            ' Determine whether strResult contains any hyphens.

            ' Else
            MessageBox.Show("Try again!", "Guess the Word Game",
                 MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        txtLetter.Text = String.Empty
    End Sub

    Private Sub txtWord_Enter(sender As Object, e As EventArgs) Handles txtWord.Enter
        txtWord.SelectAll()
    End Sub

    Private Sub txtLetter_Enter(sender As Object, e As EventArgs) Handles txtLetter.Enter
        txtLetter.SelectAll()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sr As New System.IO.StreamReader("C:\Users\avaughan2527\Documents\wheel.txt")
        Dim sr2 As New System.IO.StreamReader("C:\Users\avaughan2527\Documents\wheel.txt")
        Dim index As Integer = 0
        Dim currentline As Integer = 0
        Dim random As Integer = 0
        Do Until sr.EndOfStream = True
            sr.ReadLine()
            index += 1
        Loop

        Randomize()
        random = Rnd() * index
        Do Until currentline = random
            Label2.Text = sr2.readline
            currentline += 1
        Loop
    End Sub
End Class
