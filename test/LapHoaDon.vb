Public Class LapHoaDon
    
      Dim ReadOnly abc as BindingSource = New BindingSource()
    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        Form1.Show()
         me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        me.Hide()
        TraCuuSach.ShowDialog()
        me.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) 
        me.Hide()
        TimKiemKhachHang.ShowDialog()
        me.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) 

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) 

    End Sub



    Private Sub LapHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim Table as New DataTable
        'Dim query as String = "SELECT KHACHHANG.HOTENKHACHHANG , KHACHHANG.MAKHACHHANG , KHACHHANG.DIACHI , KHACHHANG.TONGSOTIENNO , SACH.TENSACH , SACH.MASACH , SACH.SOLUONG , CHITIETHOADON.SOLUONGBAN, HOADON.NGAYLAPHOADON FROM KHACHHANG,HOADON,CHITIETHOADON,SACH WHERE KHACHHANG.MAKHACHHANG=HOADON.MAKHACHHANG AND CHITIETHOADON.MAHOADON=HOADON.MAHOADON AND CHITIETHOADON.MASACH=SACH.MASACH"
       ' Table = DataProvider.ExecuteQuery(query)
       ' UpdateDG(Table)
            End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TraCuuSach.Show()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        TimKiemKhachHang.Show()
    End Sub

    Function kiemtraquydinh() As String
        dim kq As string =""
        If txtmasach.Text=""Then
            kq &= "Bạn chưa đưa ra thông tin Sách cần bán" + vbCrLf
        End If
        if txtmakhachhang.Text=""then
            kq & = "Bạn chưa đưa ra thông tin khách hàng mua sách"+ vbCrLf
        End If
        if txtsoluongban.Text="" then           
            kq &= "Bạn chưa nhập số lượng sách bán"+ vbCrLf
        End If
        Return kq
    End Function


     Dim MAKHACHHANG as string="" ' trong một phiếu hóa đơn chỉ được lập cho một mã khách hàng duy nhất
    Private Sub btadd_Click(sender As Object, e As EventArgs) Handles btadd.Click
       
        If not (txtmakhachhang.Text= "") And  not (txtmasach.Text="") AND not (txtsoluongban.Text="") Then
        Dim item = new ListViewitem(txthotenkhachhang.Text)
        item.SubItems.Add(txttensach.Text)
        item.SubItems.Add(txtsoluongban.Text)
            if ListView1.Items.Count<=0 Then
                item.SubItems.Add(txtmakhachhang.Text)
                item.SubItems.Add(txtmasach.Text)
                item.SubItems.Add(txtdongia.Text)
                ListView1.Items.Add(item)
                MAKHACHHANG=txtmakhachhang.Text
                Else if txtmakhachhang.Text <> MAKHACHHANG Then  
                MessageBox.Show("Một hóa đơn chỉ được lập cho một khách hàng")
              Else 
                item.SubItems.Add(txtmakhachhang.Text)
                item.SubItems.Add(txtmasach.Text)   
                item.SubItems.Add(txtdongia.Text)
                ListView1.Items.Add(item)
            End IF
      
        ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView1.Columns.Item(1).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
       ListView1.Columns.Item(3).Width = 0
        ListView1.Columns.Item(4).Width = 0        
 '            ListView1.Columns.Item(5).Width = 0    
            Else 
             MessageBox.Show(kiemtraquydinh())
        End If


    End Sub

    Private Sub btremove_Click(sender As Object, e As EventArgs) Handles btremove.Click
          For Each o As ListViewItem In ListView1.Items
            If o.Selected then
                o.Remove()
            End If
        Next
    End Sub

    Private Sub btexit_Click(sender As Object, e As EventArgs) Handles btexit.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btlaphoadon_Click(sender As Object, e As EventArgs) Handles btlaphoadon.Click

             dim table as New DataTable
        table = DataProvider.ExecuteQuery("EXEC USP_AUTOHOADON")
        Dim MAHOADON as String = table.Rows(0)(0)
        Dim MACHITIETHOADON as String
        dim str as string
        dim splitmasachvasoluongnhap() as String
        If ListView1.Items.Count <= 0 Then
            MessageBox.Show("Bạn chưa thêm bất kì cuốn sách nào")
        Else
            BuilderTable.updatetableintoSQL("HOADON",
                                            New Object() {MAHOADON, MAKHACHHANG ,format(dtngaylaphoadon.value, "yyyy-MM-dd")})
            For Each o As ListViewItem In ListView1.Items
                table = DataProvider.ExecuteQuery("EXEC USP_AUTOMACHITIETHOADON")
                MACHITIETHOADON = table.Rows(0)(0)               
                BuilderTable.updatetableintoSQL("CHITIETHOADON",
                                                New Object() _
                                                   {MACHITiETHOADON, MAHOADON, o.SubItems(4).Text,o.SubItems(2).Text})
               DataProvider.ExecuteQuery("EXEC USP_UPDATESOLUNOGSACHKHIBAN @MASACH = " + "'"+ o.SubItems(4).Text+"'" +" , "+ "@SOLUONGBAN = " + o.SubItems(2).Text)
          '      DataProvider.ExecuteQueryWithData("EXEC  USP_UPDATESOTIENNOCUAKHACHHANGSAUKHILAPHOADON @MAKHACHHANG , @SOTIEN",
           '                                       New Object() _
            '                                         { o.SubItems(3).Text,
             '                                         int32.parse(o.SubItems(5).Text)*int32.parse(o.SubItems(2).Text)})
                DataProvider.ExecuteQuery("EXEC  USP_UPDATESOTIENNOCUAKHACHHANGSAUKHILAPHOADON @MAKHACHHANG =" + "'" + o.SubItems(3).Text + "'" +" , "+ "@SOTIEN = " +  (int32.parse(o.SubItems(5).Text)* int32.parse(o.SubItems(2).Text)).ToString())
            Next
            ListView1.Items.Clear()
            MessageBox.Show("đã tạo thành công hóa đơn")

        End If
    


    End Sub
End Class