Imports System.Data.OleDb
Imports System.Runtime.Remoting.Messaging

Public Class BuilderTable
    Public Shared Sub ExportRowOnForm(row As DataRow, TH As Panel)
        For Each o As Control In TH.Controls
            Dim colum As String = o.Name.Replace("txt", "")
            colum = colum.ToUpper()
            If TypeOf o Is TextBox Then
                Dim THTextBox As TextBox = o
                THTextBox.Text = row(colum)
            End If
        Next
    End Sub

    Public Shared Function ExportRowToString(table As DataTable) As string
        dim abc = ""
        For Each o As datarow In table.Rows
            For Each o1 As DataColumn In table.Columns
                abc &= o1.ToString() & " : " & o(o1) & vbCrLf
            Next
        Next
        return abc
    End Function

    Public Shared Sub ClearDataOnForm(TH As Panel)
        For Each o As Control In TH.Controls
            Dim colum As String = o.Name.Replace("txt", "")
            colum = colum.ToUpper()
            If TypeOf o Is TextBox Then
                Dim THTextBox As TextBox = o
                THTextBox.Text = ""
            End If           
        Next
    End Sub

    Public Shared Sub ImportRowOnForm(row As DataRow, TH As Panel)
        For Each o As Control In TH.Controls
            Dim colum As String = o.Name.Replace("txt", "")
            colum = colum.ToUpper()
            If TypeOf o Is TextBox Then
                Dim THTextBox As TextBox = o
                row(colum) = THTextBox.Text
            End If
        Next
    End Sub
    
    Public Shared Sub BindingTable( ByVal DataGV As DataGridView,TH As Panel )
            For Each o As Control In TH.Controls
            Dim colum As String = o.Name.Replace("txt", "")
            colum = colum.ToUpper()
            If TypeOf o Is TextBox Then
               Dim THTextBox As TextBox = o
                THTextBox.DataBindings.clear()
               THTextBox.DataBindings.Add("Text",DataGV.DataSource,colum,False,DataSourceUpdateMode.Never)         
            End If
        Next
    End Sub

    Public Shared Function updatetableintoSQL(ByVal tenbang As String ,Parameter() As Object) As DataTable
        dim Table As NEW DataTable
        Dim query = "SELECT * FROM "+ tenbang.ToUpper()
        Table = DataProvider.ExecuteQuery(query)

        
           dim xyz as DataRow = Table.NewRow()
           Table.Rows.Add(xyz)
           dim index as Integer = 0
        For Each o As DataColumn In Table.Columns
            xyz(o.ColumnName) = Parameter(index)
            index=index+1
        Next
       
        Table = DataProvider.updatetable(query,Table)
        Return Table
    End Function

End Class
