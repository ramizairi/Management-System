Imports System.Data.SqlClient
Public Class login
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hlinu\Documents\PullsShopVb0b.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As SqlCommand
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If UNameTb.Text = "" Or PasswordTb.Text = "" Then
            MsgBox("Enter username and password")
        Else
            con.Open()
            Dim query = "select * from UserTbl where name='" & UNameTb.Text & "' and  password='" & PasswordTb.Text & "'"
            cmd = New SqlCommand(query, con)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            sda.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Worng username or password")
            Else

                Dim bill = New UserInterface
                bill.UserName = UNameTb.Text
                bill.Show()
                Me.Hide()
            End If
            con.Close()
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Dim log = New Admin
        log.Show()
    End Sub
End Class