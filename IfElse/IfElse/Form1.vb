Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click

        Dim num1, num2 As Double

        'if user didn't type the number, elinate him
        If Not (IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text)) Then
            MessageBox.Show("Error: please type a number")
            Return
        End If

        num1 = CDbl(txtFirstNum.Text)
        num2 = CDbl(txtSecondNum.Text)

        'if user didn't type positive number, elinate him
        If num1 < 0 Or num2 < 0 Then
            MessageBox.Show("Error: Please type a positive number")
        End If

        'sterile area
        If num1 > num2 Then
            txtResult.Text = "The larger number is" & num1
        ElseIf num1 < num2 Then
            txtResult.Text = "The larger number is" & num2
        Else : txtResult.Text = "They are equal"
        End If






    End Sub
End Class
