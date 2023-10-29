Public Class register
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click

        Dim form1 As New Login()
        form1.Show()
        Me.Close()

    End Sub
End Class