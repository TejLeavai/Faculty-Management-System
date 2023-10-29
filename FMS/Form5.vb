Public Class Form5
    Private changesMade As Boolean = False
    Private Sub ReturnToHomePage()
        ' Code to return to the home page goes here.
        ' For example, you can close the current form and open the home page form.
        Dim homeForm As Form3()
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub SaveAndReturnToHomePage()
        Try
            ' Save changes here (replace with your own logic).
            ' This is where you'd perform any necessary data saving or processing.
            ' If there's an exception during the saving process, the catch block will be executed.
            ' If no exception is thrown, the code after the try-catch block will be executed.

            ' Assuming changes are successfully saved, ask the user for confirmation.
            Dim result As DialogResult = MessageBox.Show("Changes have been saved. Return to home page?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' If the user clicks "Yes," return to the home page.
                ReturnToHomePage()
            Else
                ' If the user clicks "No," do nothing or continue with the current page.
            End If
        Catch ex As Exception
            ' Handle any exceptions that occurred during the saving process.
            MessageBox.Show("An error occurred while saving changes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' You can choose to log the error or take other appropriate actions.
        End Try
    End Sub

    ' Example: Call this function when you want to save changes and return to the home page.
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        SaveAndReturnToHomePage()
    End Sub

End Class

