Imports System.Data.SqlClient
Public Class dashboard
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hlinu\Documents\PullsShopVb0b.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub countpulls()
        Dim PullNum As Integer
        con.Open()
        Dim Sql = "select COUNT(*) from PullTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(Sql, con)
        PullNum = cmd.ExecuteScalar
        PullsLbl.Text = PullNum
        con.Close()
    End Sub
    Private Sub countusers()
        Dim UserNum As Integer
        con.Open()
        Dim Sql = "select COUNT(*) from UserTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(Sql, con)
        UserNum = cmd.ExecuteScalar
        UsersLbl.Text = UserNum
        con.Close()
    End Sub
    Private Sub sumamount()
        Dim Amount As Integer
        con.Open()
        Dim Sql = "select Sum(Amount) from BillTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(Sql, con)
        Amount = cmd.ExecuteScalar
        AmountLbl.Text = Convert.ToString(Amount) + "dt"
        con.Close()
    End Sub
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        countpulls()
        countusers()
        sumamount()
    End Sub

    Private Sub AmountLbl_Click(sender As Object, e As EventArgs) Handles AmountLbl.Click

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Obj = New products1()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim Obj = New users()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim Obj = New login()
        Obj.Show()
        Me.Hide()
    End Sub
End Class