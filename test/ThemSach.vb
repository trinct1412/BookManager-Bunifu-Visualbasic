Imports System.Data.OleDb

Public Class ThemSach
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bthuy.Click
        Form1.Show()
        me.Hide()
    End Sub

    Public dim mnq as BindingSource = new BindingSource()

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

    Private Sub btthem_Click(sender As Object, e As EventArgs) Handles btthem.Click

        if txttensach.Text<>"" AND txttheloai.Text<>"" AND txttacgia.Text <>"" AND txtdongia.Text<>"" Then
             dim table As NEW DataTable
        dim chuoiketnoi =
                "Provider=SQLOLEDB.1;Data Source=DESKTOP-1H502LM;Integrated Security=SSPI;Initial Catalog=QUAN_LY_NHA_SACH"
          dim query = "SELECT* FROM SACH"
          dim conn = New OleDbConnection(chuoiketnoi)

          conn.Open()

         dim ad1 = New OleDbDataAdapter(query, conn)
           ad1.Fill(table)

         conn.close()   

           dim xyz as DataRow = table.NewRow()
           table.Rows.Add(xyz)
           xyz("MASACH") = txtmasach.Text
           xyz("TENSACH") = txttensach.Text
           xyz("THELOAI") = txttheloai.Text
          xyz("TACGIA") = txttacgia.Text
          xyz("DONGIA") = txtdongia.Text
          xyz("SOLUONG") = 0
       '  dim abc as String = ""
        '  For Each o1 As DataRow In BangNhanVien.Rows
         '      For Each o As DataColumn In BangNhanVien.Columns
          '          dim tencot as String = o.ColumnName
           '          abc &= tencot & " " & o1(tencot) & vbCrLf
            ' Next
        '    abc &=vbCrLf 
        ' Next
        '  MessageBox.Show(abc)

        conn.Open()
         dim ad2 = new OleDbDataAdapter(query, conn)
         dim add as New OleDbCommandBuilder(ad2)
         ad2.Update(table)
         Form1.dgvsach.DataSource = mnq
        mnq.DataSource=table
          conn.Close()
          BuilderTable.ClearDataOnForm(Panel1) 
        Else 
            MessageBox.Show(kiemtra())
        End If

       
    End Sub

    Private Sub btxoahet_Click(sender As Object, e As EventArgs) Handles btxoahet.Click
    BuilderTable.ClearDataOnForm(Panel1)
    End Sub

    Private Sub ThemSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dim table as New DataTable
        table = DataProvider.ExecuteQuery("USP_AUTOMASACH")
        txtmasach.Text = table.Rows(0)(0)
        txtdongia.Text = 0
    End Sub
End Class