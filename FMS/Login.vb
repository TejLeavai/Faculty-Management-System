Imports System.Diagnostics.Eventing
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReg.Click

        Dim form2 As New register()
        form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Username_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub BtnExit_Click_1(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()

    End Sub
End Class
