Imports MySql.Data.MySqlClient

Public Class Login
    Dim connectionString As String = "server=localhost;port=3306;database=hotel management;uid=root;password=;"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim staffId As String = staff_id.Text
        Dim password As String = staff_password.Text

        If AuthenticateStaff(staffId, password) Then
            MessageBox.Show("Login successful")
            ' Proceed with staff operations
            ' For example: Open the Staff form
            Dim staffForm As New Staff()
            staffForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid staff ID or password")
        End If
    End Sub

    Private Function AuthenticateStaff(staffId As String, password As String) As Boolean
        Dim isAuthenticated As Boolean = False
        Try
            connection.Open()
            Dim query As String = "SELECT COUNT(*) FROM staff WHERE staff_id = @staff_id AND staff_password = @staff_password"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@staff_id", staffId)
            cmd.Parameters.AddWithValue("@staff_password", password)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                isAuthenticated = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error authenticating staff: " & ex.Message)
        Finally
            connection.Close()
        End Try
        Return isAuthenticated
    End Function

    Private Sub CheckBox_show_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_show.CheckedChanged
        If CheckBox_show.Checked Then
            staff_password.PasswordChar = ""
        Else
            staff_password.PasswordChar = "*"
        End If
    End Sub
End Class
