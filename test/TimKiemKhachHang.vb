Imports System.Data.OleDb

Public Class TimKiemKhachHang
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        me.Close()
    End Sub

    Private Sub TimKiemKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                  
    End Sub


    dim abc as BindingSource=New BindingSource()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
              dim query as string="SELECT * FROM KHACHHANG WHERE "
     ' dim query as string = "SELECT * FROM SACH WHERE [dbo].[fuConvertToUnsign1](MASACH) LIKE '%' + [dbo].[fuConvertToUnsign1] ('MS') +'%'" 
       dim temp(6) as string
        dim index as Integer = 0
        If txtmakhachhang.Text = "" AND txthotenkhachhang.Text="" AND txtdiachi.Text="" AND txttongsotienno.Text="" AND txtdienthoai.Text="" AND txtemail.Text="" Then
            MessageBox.Show("mời bạn nhập dữ liệu để tìm kiếm sách ở 1 ô bất kì")
            Else
                For Each o As Control In pntimkiemthongtinkhachhang.Controls
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
            dgvtimthongtinkhachhang.DataSource=abc
            abc.DataSource=table
            If table.Rows.Count >=0 then
               BuilderTable.BindingTable(dgvtimthongtinkhachhang,pntimkiemthongtinkhachhang)
            End If      
        End If
    End Sub

    Private Sub btcleardata_Click(sender As Object, e As EventArgs) Handles btcleardata.Click
        BuilderTable.ClearDataOnForm(pntimkiemthongtinkhachhang)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If LapHoaDon.IsHandleCreated Then
            LapHoaDon.txthotenkhachhang.Text=txthotenkhachhang.Text
            LapHoaDon.txtdiachi.Text=txtdiachi.Text
            LapHoaDon.txtmakhachhang.Text=txtmakhachhang.Text
            LapHoaDon.txttongsotienno.Text=txttongsotienno.Text
        End If
    End Sub
End Class