Imports System.Data.OleDb

Public Class SuaSach
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub SuaSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load      
       BuilderTable.BindingTable(Form1.dgvsach,pnsuasach)     
       
    End Sub

         Function kiemtra() As string
        dim kq = ""
        Dim HopLe As Boolean
        HopLe = txttensach.Text <>""
         If not HopLe Then
             kq = kq & "tên sách không được trống"+ vbCrLf
         End If
        HopLe = txtdongia.Text <> ""
         if Not HopLe then 
             kq = kq & "đơn giá không được trống"+ vbCrLf
         End If
        HopLe = txttacgia.Text<>""
         if not HopLe Then
             kq = kq & "tên tác giả không được trống"+ vbCrLf
         End If
        HopLe = txttheloai.Text <>""
         if Not HopLe Then
             kq = kq & "thể loại không được trống" + vbCrLf
         End If
        Return kq
    End Function

    public dim mnq as bindingsource = new bindingsource()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        
        if txttensach.Text<>"" AND txttheloai.Text<>"" AND txttacgia.Text <>"" AND txtdongia.Text<>"" Then
        dim BangKhachHang As New DataTable
        dim chuoiketnoi as string = "Provider=SQLOLEDB.1;Data Source=DESKTOP-1H502LM;Integrated Security=SSPI;Initial Catalog=QUAN_LY_NHA_SACH"
        dim query as String = "SELECT* FROM SACH"
        dim conn as OleDbConnection = New OleDbConnection(chuoiketnoi)
        conn.Open()
        dim ad1 as OleDbDataAdapter = New OleDbDataAdapter(query,conn)
        ad1.Fill(BangKhachHang)
        conn.close()

 
        For Each o As DataRow In BangKhachHang.Rows
             For Each o1 As DataColumn In BangKhachHang.Columns
                dim tencot as String = o1.ColumnName
                    if (txtmasach.Text = o(tencot).ToString()) Then
                    o("TENSACH") = txttensach.Text 
                    o("THELOAI")=txttheloai.Text
                    o("TACGIA")=txttacgia.Text
                    o("DONGIA")=txtdongia.Text                    
                 End If
                 Exit For
            Next
        Next
      
          conn.Open()
        dim ad2 as OleDbDataAdapter= new OleDbDataAdapter(query,conn)
         dim add as New OleDbCommandBuilder(ad2)
        ad2.Update(BangKhachHang)       
        Form1.dgvsach.DataSource = mnq
        mnq.DataSource=BangKhachHang
        conn.Close()                         
        me.Close()
        Else    
            MessageBox.Show(kiemtra())
        End If
        
        'dim abc as String = ""
        '   For Each o1 As DataRow In BangKhachHang.Rows
        '         For Each o As DataColumn In BangKhachHang.Columns
        '                 dim tencot as String = o.ColumnName
        '                abc &= tencot & " " & o1(tencot) & vbCrLf
        '          Next
        ' abc &=vbCrLf

        'Next
        'MessageBox.Show(abc)     

    End Sub
End Class