Imports System.Data.OleDb

Public Class XoaThongTinKhachHang
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        me.close()
    End Sub

        Public Dim temp as Arraylist
    Private Sub XoaThongTinKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtmakhachhang.Text=temp(0)
        txthotenkhachhang.Text=temp(1)
        txtdiachi.Text=temp(2)
        txtdienthoai.Text=temp(3)
        txtemail.Text=temp(4)
         txttongsotienno.Text=temp(5)
    End Sub


    public dim xyz as BindingSource=New BindingSource()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
     
        Dim bangkhachhan As new DataTable
        dim chuoiketnoi as string = "Provider=SQLOLEDB.1;Data Source=DESKTOP-1H502LM;Integrated Security=SSPI;Initial Catalog=QUAN_LY_NHA_SACH"
        dim query as String = "DELETE FROM KHACHHANG WHERE MAKHACHHANG = '" + txtmakhachhang.Text +"'"
        dim conn as OleDbConnection = New OleDbConnection(chuoiketnoi)
        conn.Open()
        dim ad As New OleDbCommand(query,conn)
        ad.ExecuteNonQuery()
        dim query2 as String ="SELECT* FROM KHACHHANG"
        dim ad2 as New OleDbDataAdapter(query2,conn)
        ad2.Fill(bangkhachhan)
        KhachHangvb.dgvkhachhang.DataSource=xyz
        xyz.DataSource=bangkhachhan
        conn.Close()
        KhachHangvb.Show()
        me.Close()
        
         BuilderTable.ClearDataOnForm(khachhangvb.Panel2)  
    End Sub
    


End Class