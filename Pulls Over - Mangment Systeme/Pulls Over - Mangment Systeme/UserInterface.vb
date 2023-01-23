Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows

Public Class UserInterface
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hlinu\Documents\PullsShopVb0b.mdf;Integrated Security=True;Connect Timeout=30")
    Public Property UserName As String
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

    Private Sub UserInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UnameLbl.Text = UserName
        populate()
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BillDGV.CellContentClick

    End Sub
    Dim key = 0, Stock = 0, i = 0, GrdTotal = 0
    Private Sub reset()
        key = 0
        QuantityTb.Text = ""
        PriceeTb.Text = ""
        ClientNameTb.Text = ""
        PNameTb.Text = ""
    End Sub
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        reset()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Pull-Over SHOP !", New Font("Century Gothic", 25), Brushes.MidnightBlue, 350, 70)
        e.Graphics.DrawString("_____________________", New Font("Century Gothic", 25), Brushes.MidnightBlue, 350, 70)
        e.Graphics.DrawString("_____________________", New Font("Century Gothic", 25), Brushes.MidnightBlue, 350, 70)

        e.Graphics.DrawString("<=====Your Bill=====>", New Font("Century Gothic", 16), Brushes.MidnightBlue, 300, 70)
        Dim bm As New Bitmap(Me.BillDGV.Width, Me.BillDGV.Height)
        BillDGV.DrawToBitmap(bm, New Rectangle(0, 0, Me.BillDGV.Width, Me.BillDGV.Height))
        e.Graphics.DrawImage(bm, 60, 120)
        e.Graphics.DrawString("Total Amount : " + GrdTotal.ToString, New Font("Century Gothic", 16), Brushes.MidnightBlue, 280, 500)
        e.Graphics.DrawString("Thanks, Come Back Again !", New Font("Century Gothic", 25), Brushes.MidnightBlue, 150, 580)
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub
    Private Sub AddBill()
        Try
            con.Open()
            Dim query As String
            query = "insert into BillTbl values('" & UnameLbl.Text & "','" & ClientNameTb.Text & "'," & GrdTotal & ")"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Bill Saved Successfully")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        AddBill()
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PNameTb_TextChanged(sender As Object, e As EventArgs) Handles PNameTb.TextChanged

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim Obj = New login()
        Obj.Show()
        Me.Hide()
    End Sub
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) 
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
            reset()
        End If
    End Sub

    Private Sub UnameLbl_Click(sender As Object, e As EventArgs) Handles UnameLbl.Click

    End Sub

    Private Sub update()
        Dim NewQuantity = Stock - Convert.ToInt32(QuantityTb.Text)
        con.Open()
        Dim query As String
        query = "Update PullTbl set Quantity=" & NewQuantity & " Where Bld =" & key & ""
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
        MsgBox("Item Updated Successfully")
        con.Close()
        populate()
    End Sub
    Private Sub AddToBillBtn_Click(sender As Object, e As EventArgs) Handles AddToBillBtn.Click
        If PriceeTb.Text = "" Or QuantityTb.Text = "" Then
            MsgBox("Enter the Quantity")
        ElseIf PNameTb.Text = "" Then
            MsgBox("Select The Pull")
        ElseIf Convert.ToInt32(QuantityTb.Text) > Stock Then
            MsgBox("Not Enough Stock")

        Else
            Dim rnum As Integer = BillDGV.Rows.Add()
            i = i + 1
            Dim total = Convert.ToInt32(QuantityTb.Text) * Convert.ToInt32(PriceeTb.Text)
            BillDGV.Rows.Item(rnum).Cells("Column1").Value = i
            BillDGV.Rows.Item(rnum).Cells("Column2").Value = PNameTb.Text
            BillDGV.Rows.Item(rnum).Cells("Column3").Value = PriceeTb.Text
            BillDGV.Rows.Item(rnum).Cells("Column4").Value = QuantityTb.Text
            BillDGV.Rows.Item(rnum).Cells("Column5").Value = total
            GrdTotal = GrdTotal + total
            Dim tot As String
            tot = Convert.ToString(GrdTotal) + " TND"
            TotalLbl.Text = tot
            update()
        End If
    End Sub

    Private Sub PullsDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PullsDGV.CellContentClick
        Dim row As DataGridViewRow = PullsDGV.Rows(e.RowIndex)
        PNameTb.Text = row.Cells(1).Value.ToString
        PriceeTb.Text = row.Cells(5).Value.ToString
        Stock = Convert.ToInt32(row.Cells(4).Value.ToString)
        If PNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
End Class