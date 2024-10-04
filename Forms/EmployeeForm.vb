Imports System.Data.SqlClient

Public Class EmployeeForm
    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployees()
    End Sub

    Private Sub LoadEmployees()
        Dim query As String = "SELECT * FROM Employees"
        Using conn = ConnectDB()
            Dim cmd As New SqlCommand(query, conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim dt As New DataTable()
            dt.Load(reader)
            dgvEmployees.DataSource = dt
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim query As String = "INSERT INTO Employees (FirstName, LastName, Email, Department) VALUES (@FirstName, @LastName, @Email, @Department)"
        Using conn = ConnectDB()
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@Department", txtDepartment.Text)
            cmd.ExecuteNonQuery()
        End Using
        LoadEmployees()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim query As String = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID"
        Using conn = ConnectDB()
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@EmployeeID", dgvEmployees.SelectedRows(0).Cells("EmployeeID").Value)
            cmd.ExecuteNonQuery()
        End Using
        LoadEmployees()
    End Sub
End Class
