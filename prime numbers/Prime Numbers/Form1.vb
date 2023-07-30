Public Class txtresult
    Private Sub btnprime_Click(sender As Object, e As EventArgs) Handles btnprime.Click
        ' Get the input numbers from the text boxes
        Dim startNum As Integer = Integer.Parse(txtnum1.Text)
        Dim endNum As Integer = Integer.Parse(txtnum2.Text)

        ' Validate input numbers
        If startNum <= 1 Or endNum <= 1 Then
            MessageBox.Show("Please enter positive integers greater than 1.")
            Return
        End If

        If startNum > endNum Then
            MessageBox.Show("Start number must be less than or equal to end number.")
            Return
        End If

        ' Print prime numbers between the input numbers
        For i As Integer = startNum To endNum
            If IsPrime(i) Then
                txtresults.AppendText(i.ToString() & vbCrLf)
            End If
        Next
    End Sub

    ' Function to check if a number is prime
    Private Function IsPrime(num As Integer) As Boolean
        If num = 2 Then
            Return True
        End If

        If num < 2 OrElse num Mod 2 = 0 Then
            Return False
        End If

        Dim limit As Integer = Math.Sqrt(num)
        For i As Integer = 3 To limit Step 2
            If num Mod i = 0 Then
                Return False
            End If
        Next

        Return True
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtresults.TextChanged

    End Sub

    Private Sub txtresult_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
