Imports System.Data.OleDb

Public Class DataProvider

  

    Private Shared ReadOnly _
        ConnectionStr as string =
            "Provider=SQLOLEDB.1;Data Source=DESKTOP-1H502LM;Integrated Security=SSPI;Initial Catalog=QUAN_LY_NHA_SACH"

    Public Shared Function ExecuteQuery(Query As String) As DataTable
        dim Table As New DataTable
        dim Connection = New OleDbConnection(ConnectionStr)
        Connection.Open()
        dim adapter = New OleDbDataAdapter(query, Connection)
        adapter.Fill(Table)
        Connection.Close()
        Return Table
    End Function

        Public Shared Function updatetable(Query As String,ByVal table As DataTable) As DataTable
        
        dim Connection = New OleDbConnection(ConnectionStr)
        Connection.Open()
        dim adapter = New OleDbDataAdapter(query, Connection)        
         dim add as New OleDbCommandBuilder(adapter)
       adapter.Update(table)
        Connection.Close()
        Return Table
    End Function

    Public Shared Function ExecuteQueryWithData(Query As String, Parameter() As Object) As DataTable
        dim Connection = New OleDbConnection(ConnectionStr)
        dim Table As New DataTable

        Connection.Open()
        Dim command as new OleDbCommand()

        dim splitquery() as String = Query.Split(" ")
        dim i = 0
        For Each o As String In splitquery
            If o.Contains("USP_") Then
                command.CommandText = o
                command.Connection = Connection
                command.CommandType = CommandType.StoredProcedure
            ELSE If o.Contains("@") Then
                command.Parameters.AddWithValue(o, Parameter(i))
                i = i + 1
            End If
        Next
        Command.ExecuteNonQuery()

        dim adapter = New OleDbDataAdapter(command)
        adapter.Fill(Table)
        Connection.Close()


        Return Table
    End Function

    Public Shared Function ExecuteQueryWithDataReturnInt(Query As String, Parameter() As Object) As Integer
        dim Index = 0
        dim Connection = New OleDbConnection(ConnectionStr)
        Connection.Open()
        Dim command as new OleDbCommand()
        dim splitquery() as String = Query.Split(" ")
        dim i = 0
        For Each o As String In splitquery
            If o.Contains("USP_") Then
                command.CommandText = o
                command.Connection = Connection
                command.CommandType = CommandType.StoredProcedure
            ELSE If o.Contains("@") Then
                command.Parameters.AddWithValue(o, Parameter(i))
                i = i + 1
            End If
        Next
        Index = Command.ExecuteNonQuery()
        Connection.Close()
        Return Index
    End Function
End Class
