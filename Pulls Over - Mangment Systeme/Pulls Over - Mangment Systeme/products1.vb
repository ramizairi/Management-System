Imports System.Data.SqlClient

Public Class products1
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hlinu\Documents\PullsShopVb0b.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub populate()
        con.Open()
        Dim query = " select * from PullTbl "
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        PullsDGV.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub Filter()
        con.Open()
        Dim query = " select * from PullTbl where Mark='" & Filtredcap.SelectedItem.ToString() & "' "
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        PullsDGV.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub Reset()
        RefTab.Text = ""
        SizeCb.SelectedIndex = -1
        CatCb.SelectedIndex = -1
        QuantityTb.Text = ""
        PriceeTb.Text = ""
        key = 0
    End Sub
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If RefTab.Text = "" Or SizeCb.SelectedIndex = -1 Or QuantityTb.Text = "" Or CatCb.SelectedIndex = -1 Or PriceeTb.Text = "" Then
            MsgBox("Missing information")
        Else
            con.Open()
            Dim query As String
            query = "insert into PullTbl values('" & RefTab.Text & "','" & SizeCb.SelectedItem.ToString & "','" & CatCb.SelectedItem.ToString & "','" & QuantityTb.Text & "','" & PriceeTb.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Saved Successfully")
            con.Close()
            populate()
            Reset()
        End If

    End Sub
    Dim key = 0
    Private Sub PullsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles PullsDGV.CellMouseClick
        Dim row As DataGridViewRow = PullsDGV.Rows(e.RowIndex)
        RefTab.Text = row.Cells(1).Value.ToString
        SizeCb.SelectedItem = row.Cells(2).Value.ToString
        CatCb.SelectedItem = row.Cells(2).Value.ToString
        QuantityTb.Text = row.Cells(3).Value.ToString
        PriceeTb.Text = row.Cells(4).Value.ToString
        If RefTab.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub products1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If key = 0 Then
            MsgBox("Select the item that you want to delet")
        Else
            con.Open()
            Dim query As String
            query = "Delete from PullTbl where Bld = " & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Deleted Successfully")
            con.Close()
            populate()
            Reset()
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If RefTab.Text = "" Or SizeCb.SelectedIndex = -1 Or QuantityTb.Text = "" Or CatCb.SelectedIndex = -1 Or PriceeTb.Text = "" Then
            MsgBox("Missing information")
        Else
            con.Open()
            Dim query As String
            query = "Update PullTbl set Reference='" & RefTab.Text & "','" & SizeCb.SelectedItem.ToString & "','" & CatCb.SelectedItem.ToString & "','" & QuantityTb.Text & "','" & PriceeTb.Text & "' where Bld=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Updated Successfully")
            con.Close()
            populate()
            Reset()
        End If
    End Sub

    Private Sub FiltredBtn_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Filtredcap.SelectionChangeCommitted
        Filter()
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        populate()
    End Sub

    Private Sub PullsDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PullsDGV.CellContentClick

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim Obj = New users()
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

    Private Sub RefTab_TextChanged(sender As Object, e As EventArgs) Handles RefTab.TextChanged

    End Sub
End Class