Public Class Form1
    ' Create the variables
    Dim arraynumber(9) As Integer
    Dim i As Integer
    Dim Data As String

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exit my program
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear list box 
        lstInputValues.Items.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIntegers.Click
        'display words (input values) 
        lstInputValues.Items.Add("Input Values")

        ' define 10 values in list box
        For i = 0 To 9
            ' Enter 10 values
            Data = InputBox("Enter Your 10 Values Please ", "Enter 10 Numbers")

            If IsNumeric(Data) Then
                arraynumber(i) = CInt(Data)
                'display list box
                lstInputValues.Items.Add(arraynumber(i))
            Else
                i = i - 1
                'If you don't enter enough 10 numbers then
                MessageBox.Show("You Should Enter Enough 10 Values Please")
            End If
        Next

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' create variables and define variables
        Dim Maximum As Integer = arraynumber(0)
        Dim Minimum As Integer = arraynumber(0)

        'Find maximum and minimum 
        For i = 0 To 9
            'define maximum 
            If (arraynumber(i) > Maximum) Then
                Maximum = arraynumber(i)
            End If
            'difine minimum
            If (arraynumber(i) < Minimum) Then
                Minimum = arraynumber(i)
            End If

            'display output list box 
            lblOutput.Text = ("The biggest value is " & Maximum & " and the smallest value is " & Minimum)
        Next
    End Sub
End Class
