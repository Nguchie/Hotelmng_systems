Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Staff
    Dim connectionString As String = "server=localhost;port=3306;database=hotel management;uid=root;password=;"
    Dim connection As New MySqlConnection(connectionString)
    Dim selectedStaffId As Integer = 0 ' Variable to store the selected staff ID

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStaff()
    End Sub

    Private Sub LoadStaff()
        Try
            connection.Open()
            Dim query As String = "SELECT staff_id, staff_phone, staff_gender, staff_password FROM staff"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim staffTable As New DataTable()
            adapter.Fill(staffTable)

            ' Hash the passwords in the DataTable before binding to DataGridView
            HashPasswords(staffTable)

            DataGridView1.DataSource = staffTable
        Catch ex As Exception
            MessageBox.Show("Error loading staff: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub HashPasswords(table As DataTable)
        For Each row As DataRow In table.Rows
            Dim password As String = row("staff_password").ToString()
            row("staff_password") = HashPassword(password)
        Next
    End Sub

    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For Each b As Byte In hashedBytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    ' Add other event handlers and methods as before
End Class
