Imports System.Data.OleDb

Public Class SuaThongTinKhachHang
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click  
     KhachHangvb.Show()
     me.Close()
    End Sub

    Public Dim temp as Arraylist
    Private Sub SuaThongTinKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtmakhachhang.Text=temp(0)
        txthotenkhachhang.Text=temp(1)
        txtdiachi.Text=temp(2)
        txtdienthoai.Text=temp(3)
        txtemail.Text=temp(4)
         txttongsotienno.Text=temp(5)
    End Sub

    Public dim xyz as BindingSource = New BindingSource()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dim BangKhachHang As New DataTable
        dim chuoiketnoi as string = "Provider=SQLOLEDB.1;Data Source=DESKTOP-1H502LM;Integrated Security=SSPI;Initial Catalog=QUAN_LY_NHA_SACH"
        dim query as String = "SELECT* FROM KHACHHANG"
        dim conn as OleDbConnection = New OleDbConnection(chuoiketnoi)
        conn.Open()
        dim ad1 as OleDbDataAdapter = New OleDbDataAdapter(query,conn)
        ad1.Fill(BangKhachHang)
        conn.close()

 
        For Each o As DataRow In BangKhachHang.Rows
             For Each o1 As DataColumn In BangKhachHang.Columns
                dim tencot as String = o1.ColumnName
                    if (txtmakhachhang.Text = o(tencot).ToString()) Then
                    o("HOTENKHACHHANG") = txthotenkhachhang.Text 
                    o("DIACHI")=txtdiachi.Text
                    o("DIENTHOAI")=txtdienthoai.Text
                    o("EMAIL")=txtemail.Text
                    o("TONGSOTIENNO")=txttongsotienno.Text 
                 End If
                 Exit For
            Next
        Next
      
          conn.Open()
        dim ad2 as OleDbDataAdapter= new OleDbDataAdapter(query,conn)
         dim add as New OleDbCommandBuilder(ad2)
        ad2.Update(BangKhachHang)
        
        KhachHangvb.dgvkhachhang.DataSource= xyz
        xyz.DataSource = BangKhachHang
        conn.Close()

        'dim abc as String = ""
        '   For Each o1 As DataRow In BangKhachHang.Rows
        '         For Each o As DataColumn In BangKhachHang.Columns
        '                 dim tencot as String = o.ColumnName
        '                abc &= tencot & " " & o1(tencot) & vbCrLf
        '          Next
        ' abc &=vbCrLf

        'Next
        'MessageBox.Show(abc)     
        KhachHangvb.Show()         
        me.Close()
         BuilderTable.ClearDataOnForm(khachhangvb.Panel2)  
    End Sub
End Class