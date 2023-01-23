Imports System.Data.SqlClient
Public Class users
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hlinu\Documents\PullsShopVb0b.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub populate()
        con.Open()
        Dim query = " select * from UserTbl "
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        UserDGV.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub Reset()
        UnameTb.Text = ""
        PhoneTb.Text = ""
        AddressTb.Text = ""
        PasswordTb.Text = ""
        key = 0
    End Sub
    Private Sub users_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If NameTxt.Text = "" Or PhoneTxt.Text = "" Or AddressTxt.Text = "" Or PasswordTxt.Text = "" Then
            MsgBox("Missing information")
        Else
            con.Open()
            Dim query As String
            query = "insert into UserTbl values('" & UnameTb.Text & "','" & PhoneTb.Text & "','" & AddressTb.Text & "','" & PasswordTb.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("User Saved Successfully")
            con.Close()
            populate()
            Reset()
        End If
    End Sub
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub
    Dim key = 0
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If key = 0 Then
            MsgBox("Select the user that you want to delet")
        Else
            con.Open()
            Dim query As String
            query = "Delete from UserTbl where Id = " & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("User Deleted Successfully")
            con.Close()
            populate()
            Reset()
        End If
    End Sub

    Private Sub UserDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles UserDGV.CellMouseClick
        Dim row As DataGridViewRow = UserDGV.Rows(e.RowIndex)
        UnameTb.Text = row.Cells(1).Value.ToString
        PhoneTb.Text = row.Cells(2).Value.ToString
        AddressTb.Text = row.Cells(3).Value.ToString
        PasswordTb.Text = row.Cells(4).Value.ToString
        If UnameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If NameTxt.Text = "" Or PhoneTxt.Text = "" Or AddressTxt.Text = "" Or PasswordTxt.Text = "" Then
            MsgBox("Missing information")
        Else
            con.Open()
            Dim query As String
            query = "Update UserTbl set name='" & UnameTb.Text & "',Phone='" & PhoneTb.Text & "',Address='" & AddressTb.Text & "',Password='" & PasswordTb.Text & "' where Id=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("User Updated Successfully")
            con.Close()
            populate()
            Reset()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Obj = New products1()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim Obj = New dashboard()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim Obj = New login()
        Obj.Show()
        Me.Hide()
    End Sub
End Class