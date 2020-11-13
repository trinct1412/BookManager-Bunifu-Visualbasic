Public Class TraCuuSach
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        me.Close()
    End Sub

    Private Sub TraCuuSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    dim abc as BindingSource=New BindingSource()
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
       dim query as string="SELECT * FROM SACH WHERE "
     ' dim query as string = "SELECT * FROM SACH WHERE [dbo].[fuConvertToUnsign1](MASACH) LIKE '%' + [dbo].[fuConvertToUnsign1] ('MS') +'%'" 
       dim temp(5) as string
        dim index as Integer = 0
        If txtmasach.Text = "" AND txtdongia.Text="" AND txttensach.Text="" AND txttacgia.Text="" AND txttheloai.Text="" Then
            MessageBox.Show("mời bạn nhập dữ liệu để tìm kiếm sách ở 1 ô bất kì")
            Else
                For Each o As Control In pntracuusach.Controls
                    If TypeOf o Is TextBox AND o.Text <>"" Then
                        Dim THTextBox As TextBox = o
                        temp(index) = "[dbo].[fuConvertToUnsign1](" + THTextBox.Name.Replace("txt","").ToUpper() + ") LIKE '%' + [dbo].[fuConvertToUnsign1] (" +"'"+THTextBox.Text +"'"+") +'%'"
                        index = index +1
                End If
                Next
                if index = 1 then
                query &= temp(index-1)
                Else
                    For i As Integer = 0 To index-1                       
                        If i = index-1 Then
                            query &= temp(i)
                        Else 
                        query &= temp(i) + " AND "
                        End If
                    Next
                End If      
            dim table as new DataTable
            table = DataProvider.ExecuteQuery(query)
            dgvtracuusach.DataSource=abc
            abc.DataSource=table
            If table.Rows.Count >=0 then
               BuilderTable.BindingTable(dgvtracuusach,pntracuusach)
            End If          
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        if LapHoaDon.IsHandleCreated Then
             LapHoaDon.txtmasach.Text = txtmasach.Text
             LapHoaDon.txtsoluong.Text = txtsoluong.Text
             LapHoaDon.txttensach.Text=txttensach.Text
            LapHoaDon.txtdongia.Text=txtdongia.Text
        End If
      
    End Sub

    Private Sub btclear_Click(sender As Object, e As EventArgs) Handles btclear.Click
        BuilderTable.ClearDataOnForm(pntracuusach)
    End Sub
End Class