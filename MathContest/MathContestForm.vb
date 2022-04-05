'Jamison Burton
'RCET0265
'Spring 2022
'Math Contest
'https://github.com/Reimonoe17/MathContest

Public Class MathContestForm

    Function RandomInteger() As Integer
        Randomize()
        Dim value As Integer = CInt(Int((10 * Rnd()) + 1))
        Return value 'Outputs a random value between 1 and 10
    End Function
    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged, SubtractRadioButton.CheckedChanged, MultiplyRadioButton.CheckedChanged, DivideRadioButton.CheckedChanged
        FirstNumberTextBox.Text = RandomInteger()
        SecondNumberTextBox.Text = RandomInteger()
        StudentAnswerTextBox.Enabled = True
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Function NameTextBox_Leave(sender As Object, e As EventArgs) Handles NameTextBox.Leave
        Dim valid As Boolean = False

        If NameTextBox.Text <> "" Then
            valid = True
        Else
            MsgBox("Please enter the student's name")
            NameTextBox.Focus()
        End If

        Return valid
    End Function

    Private Sub AgeTextBox_Leave(sender As Object, e As EventArgs) Handles AgeTextBox.Leave
        validateAge()
    End Sub
    Function validateAge() As Boolean
        Dim valid As Boolean = False
        Dim age As String

        If AgeTextBox.Text <> "" Then

            Try
                age = CInt(AgeTextBox.Text)
            Catch ex As Exception
                MsgBox("Age must be a number")
            End Try

            If age > 11 Or age < 7 Then
                MsgBox("Student is not eligeble to compete")
                AgeTextBox.Focus()
            Else
                valid = True
            End If

        End If

        Return valid
    End Function

    Private Sub GradeTextBox_Leave(sender As Object, e As EventArgs) Handles GradeTextBox.Leave
        validateGrade()
    End Sub
    Function validateGrade() As Boolean
        Dim valid As Boolean = False
        Dim grade As String

        If GradeTextBox.Text <> "" Then

            Try
                grade = CInt(GradeTextBox.Text)
            Catch ex As Exception
                MsgBox("Grade must be a number")
            End Try

            If grade > 4 Or grade < 1 Then
                MsgBox("Student is not eligeble to compete")
                GradeTextBox.Focus()
            Else
                valid = True
            End If

        End If
        Return valid
    End Function

    Private Sub StudentAnswerTextBox_TextChanged(sender As Object, e As EventArgs) Handles StudentAnswerTextBox.TextChanged
        If StudentAnswerTextBox.Text <> "" And NameTextBox.Text <> "" And validateAge() = True And validateGrade() = True Then
            SubmitButton.Enabled = True
            SummaryButton.Enabled = True
        Else
            SubmitButton.Enabled = False
            SummaryButton.Enabled = False
        End If
    End Sub
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim input As Integer = CInt(StudentAnswerTextBox.Text)

        If input = EnterAnswer() Then
            MsgBox("Correct!")
            Tally(True)
        ElseIf input <> EnterAnswer() Then
            MsgBox("Incorrect")
            Tally(False)
        End If
        FirstNumberTextBox.Text = RandomInteger()
        SecondNumberTextBox.Text = RandomInteger()
        StudentAnswerTextBox.Text = ""
        SummaryButton.Enabled = True

    End Sub
    Function EnterAnswer() As Integer
        Dim answer As Integer

        If AddRadioButton.Checked = True Then
            answer = CInt(FirstNumberTextBox.Text) + CInt(SecondNumberTextBox.Text)
        ElseIf SubtractRadioButton.Checked = True Then
            answer = CInt(FirstNumberTextBox.Text) - CInt(SecondNumberTextBox.Text)
        ElseIf MultiplyRadioButton.Checked = True Then
            answer = CInt(FirstNumberTextBox.Text) * CInt(SecondNumberTextBox.Text)
        ElseIf DivideRadioButton.Checked = True Then
            answer = CInt(FirstNumberTextBox.Text) / CInt(SecondNumberTextBox.Text)
        End If

        Return answer
    End Function
    Sub Tally(Optional input As Boolean = False, Optional clear As Boolean = False, Optional write As Boolean = False)
        Static results As Integer = 0
        Static total As Integer = 0

        If input = True Then
            total += 1
            results += 1
        Else
            total += 1
        End If

        If clear = True Then
            results = 0
            total = 0
        End If

        If write = True Then
            total -= 1
            If NameTextBox.Text = "" Then
                MsgBox("Please enter the Student's name")
            Else
                MsgBox(NameTextBox.Text & " got " & results & " answers correct out of a possible " & total)
            End If
        End If

    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Tally(, True,)
        NameTextBox.Text = ""
        AgeTextBox.Text = ""
        GradeTextBox.Text = ""
        StudentAnswerTextBox.Text = ""
        FirstNumberTextBox.Text = RandomInteger()
        SecondNumberTextBox.Text = RandomInteger()
        AddRadioButton.Checked = True
    End Sub
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        Tally(False, False, True)
    End Sub
End Class
