Imports System.Data.SqlClient

Public Class Admin
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If PasswordTb.Text = "" Then
            MsgBox("Enter password")
        Else
            If PasswordTb.Text = "admin1234" Then
                Me.Hide()
                Dim log = New products1
                log.Show()
            Else
                MsgBox("Wrong Password")
            End If
        End If
    End Sub
End Class