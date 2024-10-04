Imports System.Data.SqlClient

Module Database
    Public conn As SqlConnection
    Public Function ConnectDB() As SqlConnection
        Dim connString As String = "Server=localhost;Database=EmployeeDB;Integrated Security=True;"
        conn = New SqlConnection(connString)
        Try
            conn.Open()
            Return conn
        Catch ex As Exception
            MsgBox("Database Connection Error: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub DisconnectDB()
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
End Module
