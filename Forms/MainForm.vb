Public Class MainForm
    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        Dim employeeForm As New EmployeeForm()
        employeeForm.Show()
    End Sub

    Private Sub btnDepartment_Click(sender As Object, e As EventArgs) Handles btnDepartment.Click
        Dim departmentForm As New DepartmentForm()
        departmentForm.Show()
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        Dim attendanceForm As New AttendanceForm()
        attendanceForm.Show()
    End Sub

    Private Sub btnPerformance_Click(sender As Object, e As EventArgs) Handles btnPerformance.Click
        Dim performanceForm As New PerformanceForm()
        performanceForm.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim reportForm As New ReportForm()
        reportForm.Show()
    End Sub
End Class
