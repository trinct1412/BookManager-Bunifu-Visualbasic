
Imports System.Data.OleDb
Imports System.Runtime.Remoting.Messaging

Public Class KhachHangvb

      Dim abc as BindingSource = New BindingSource()         

      private Sub UpdateDG(ByVal Table As  DataTable)
        dgvkhachhang.DataSource = abc
        abc.DataSource=Table
    End sub
    
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btadd.Click
          dim BangKhachHang As NEW DataTable
        dim chuoiketnoi =
                "Provider=SQLOLEDB.1;Data Source=DESKTOP-1H502LM;Integrated Security=SSPI;Initial Catalog=QUAN_LY_NHA_SACH"
          dim query = "SELECT* FROM KHACHHANG"
          dim conn = New OleDbConnection(chuoiketnoi)

          conn.Open()

         dim ad1 = New OleDbDataAdapter(query, conn)
           ad1.Fill(BangKhachHang)

         conn.close()

           dim xyz as DataRow = BangKhachHang.NewRow()
           BangKhachHang.Rows.Add(xyz)
           xyz("MAKHACHHANG") = txtmakhachhang.Text
           xyz("HOTENKHACHHANG") = txthotenkhachhang.Text
           xyz("DIACHI") = txtdiachi.Text
          xyz("DIENTHOAI") = txtdienthoai.Text
          xyz("EMAIL") = txtemail.Text
          xyz("TONGSOTIENNO") = txttongsotienno.Text

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
         ad2.Update(BangKhachHang)
         dgvkhachhang.DataSource = abc
        abc.DataSource=BangKhachHang
          conn.Close()
          BuilderTable.ClearDataOnForm(Panel2)  
        'dim Table As New DataTable
        'dim query as string = " UPDATE KHACHHANG SET HOTENKHACHHANG = 'TRI' WHERE MAKHACHHANG = '2' "
        'dim Connection as OleDbConnection = New OleDbConnection(chuoiketnoi)
        'dim adapter as OleDbDataAdapter = New OleDbDataAdapter()
        'Connection.Open()
        'adapter.UpdateCommand= new OleDbCommand(query,Connection)
        'adapter.Fill(Table)
        'Connection.Close()
        'UpdateDG(Table)

        ' dim abc As String = ""
         'MessageBox.Show(BuilderTable.TypeOfVar(abc))

       ' BuilderTable.BindingTable(xyz, Panel2,dgvkhachhang)
         
        
        'dim index as Integer
        'Dim abc As New DataTable
        'dim query as string = "EXEC  USP_SELECTKHACHHANG @HOTENKHACHHANG"
        'abc= DataProvider.ExecuteQueryWithData(query,New Object(){"b"})
        'UpdateDG(abc)
         'MessageBox.Show(index.ToString())

         
    End Sub

    Public dim listselect as new ArrayList
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btedit.Click
        listselect.Add(txtmakhachhang.Text)
        listselect.Add(txthotenkhachhang.Text)
        listselect.Add(txtdiachi.Text)
        listselect.Add(txtdienthoai.Text)
        listselect.Add(txtemail.Text)
        listselect.Add(txttongsotienno.Text)
        SuaThongTinKhachHang.temp = listselect
        SuaThongTinKhachHang.Show()
        listselect.Clear()
        SuaThongTinKhachHang.xyz = abc
         BuilderTable.ClearDataOnForm(Panel2)  
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btremove.Click
        'listselect.Add(DataGridView1.Rows(index).Cells(0).Value)
        'listselect.Add(DataGridView1.Rows(index).Cells(1).Value)
        'listselect.Add(DataGridView1.Rows(index).Cells(2).Value)
        'listselect.Add( DataGridView1.Rows(index).Cells(3).Value)
        'listselect.Add(DataGridView1.Rows(index).Cells(4).Value)
        'listselect.Add( DataGridView1.Rows(index).Cells(5).Value)

        listselect.Add(txtmakhachhang.Text)
        listselect.Add(txthotenkhachhang.Text)
        listselect.Add(txtdiachi.Text)
        listselect.Add(txtdienthoai.Text)
        listselect.Add(txtemail.Text)
        listselect.Add(txttongsotienno.Text)
        XoaThongTinKhachHang.temp = listselect
        XoaThongTinKhachHang.Show()
        listselect.Clear()
        XoaThongTinKhachHang.xyz = abc
        BuilderTable.ClearDataOnForm(Panel2)  
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btexit.Click
        
        me.close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
               dim query as string="SELECT * FROM KHACHHANG WHERE "
     ' dim query as string = "SELECT * FROM SACH WHERE [dbo].[fuConvertToUnsign1](MASACH) LIKE '%' + [dbo].[fuConvertToUnsign1] ('MS') +'%'" 
       dim temp(6) as string
        dim index as Integer = 0
        If txtmakhachhang.Text = "" AND txthotenkhachhang.Text="" AND txtdiachi.Text="" AND txttongsotienno.Text="" AND txtdienthoai.Text="" AND txtemail.Text="" Then
            MessageBox.Show("mời bạn nhập dữ liệu để tìm kiếm sách ở 1 ô bất kì")
            Else
                For Each o As Control In panel2.Controls
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
            dgvkhachhang.DataSource = abc
            abc.DataSource=table
        End If
    End Sub
    
    Private Sub KhachHangvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Dim Table as New DataTable
      Table = DataProvider.ExecuteQuery("SELECT * FROM KHACHHANG")                 
      UpdateDG(Table)        
      BuilderTable.BindingTable(dgvkhachhang,Panel2)
      BuilderTable.ClearDataOnForm(Panel2)
    End Sub

    'dim index() as Integer
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvkhachhang.CellContentClick            
     
        ' dim index as Integer = dgvkhachhang.CurrentRow.Index
        'dim index1 as Integer = 0
      '  index(0)=dgvkhachhang.CurrentRow.Index
        
     '   If index(0) <> index(1) Then
      '      MessageBox.Show("abc")
       ' End If

        '    txtmakhachhang.Text = dgvkhachhang.Rows(index).Cells(0).Value
         '   txthotenkhachhang.Text = dgvkhachhang.Rows(index).Cells(1).Value
          '  txtdiachi.Text = dgvkhachhang.Rows(index).Cells(2).Value
           ' txtdienthoai.Text = dgvkhachhang.Rows(index).Cells(3).Value
            'txtemail.Text = dgvkhachhang.Rows(index).Cells(4).Value
            'txtsotienno.Text = dgvkhachhang.Rows(index).Cells(5).Value

    End Sub

    Private Sub bthienthitatcakhachhang_Click(sender As Object, e As EventArgs) Handles bthienthitatcakhachhang.Click
        Dim Table as New DataTable
      Table = DataProvider.ExecuteQuery("SELECT * FROM KHACHHANG")                 
      UpdateDG(Table)     
    End Sub
End Class