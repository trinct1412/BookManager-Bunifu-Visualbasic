Imports System.Data.OleDb

Public Class XoaSach
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub XoaSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuilderTable.BindingTable(Form1.dgvsach,pnxoasach)            
    End Sub


    Public Dim mnq as BindingSource=New BindingSource()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
         Dim bangkhachhan As new DataTable
        dim chuoiketnoi as string = "Provider=SQLOLEDB.1;Data Source=DESKTOP-1H502LM;Integrated Security=SSPI;Initial Catalog=QUAN_LY_NHA_SACH"
        dim query as String = "DELETE FROM SACH WHERE MASACH = '" + txtmasach.Text +"'"
        dim conn as OleDbConnection = New OleDbConnection(chuoiketnoi)
        conn.Open()
        dim ad As New OleDbCommand(query,conn)
        ad.ExecuteNonQuery()
        dim query2 as String ="SELECT* FROM SACH"
        dim ad2 as New OleDbDataAdapter(query2,conn)
        ad2.Fill(bangkhachhan)
        Form1.dgvsach.DataSource = mnq
        mnq.DataSource=bangkhachhan
        conn.Close()
        me.Close()
    End Sub
End Class