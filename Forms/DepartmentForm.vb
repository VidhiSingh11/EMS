Imports System.Data.SqlClient

Public Class DepartmentForm
    Private Sub DepartmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDepartments()
    End Sub

    Private Sub LoadDepartments()
        Dim query As String = "SELECT * FROM Departments"
        Using conn = ConnectDB()
            Dim cmd As New SqlCommand(query, conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim dt As New DataTable()
            dt.Load(reader)
            dgvDepartments.DataSource = dt
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim query As String = "INSERT INTO Departments (DepartmentName) VALUES (@DepartmentName)"
        Using conn = ConnectDB()
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@DepartmentName", txtDepartmentName.Text)
            cmd.ExecuteNonQuery()
        End Using
        LoadDepartments()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim query As String = "DELETE FROM Departments WHERE DepartmentID = @DepartmentID"
        Using conn = ConnectDB()
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@DepartmentID", dgvDepartments.SelectedRows(0).Cells("DepartmentID").Value)
            cmd.ExecuteNonQuery()
        End Using
        LoadDepartments()
    End Sub
End Class
