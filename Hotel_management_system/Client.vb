Imports MySql.Data.MySqlClient

Public Class Client
    Dim connectionString As String = "server=localhost;port=3306;database=hotel management;uid=root;password=;"
    Dim connection As New MySqlConnection(connectionString)
    Dim i As Integer
    Dim dr As MySqlDataReader
    Dim key As Integer = 0 ' Variable to store the selected client ID

    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVLoad()
    End Sub

    Public Sub DGVLoad()
        DataGridView1.Rows.Clear()
        Try
            connection.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM clients", connection)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("client_id"), dr.Item("client_name"), dr.Item("client_gender"), dr.Item("client_age"), dr.Item("client_phone_no"), dr.Item("client_country"))
            End While
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If Not dr Is Nothing Then
                dr.Close()
            End If
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub cl_add_Click(sender As Object, e As EventArgs) Handles cl_add.Click
        SaveClient()
        DGVLoad()
        ClearInputs()
    End Sub

    Public Sub SaveClient()
        Try
            connection.Open()
            Dim cmd As New MySqlCommand("INSERT INTO clients (client_name, client_gender, client_age, client_phone_no, client_country) VALUES (@client_name, @client_gender, @client_age, @client_phone_no, @client_country)", connection)
            cmd.Parameters.AddWithValue("@client_name", cl_name.Text)
            cmd.Parameters.AddWithValue("@client_gender", Combo_cl_gender.Text)
            cmd.Parameters.AddWithValue("@client_age", cl_age.Text)
            cmd.Parameters.AddWithValue("@client_phone_no", cl_phone.Text)
            cmd.Parameters.AddWithValue("@client_country", Combo_country.Text)

            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Record saved successfully", "Client Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Save failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        cl_name.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        Combo_cl_gender.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        cl_age.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        cl_phone.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        Combo_country.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()

        ' Set the key variable to the selected client ID
        key = Convert.ToInt32(DataGridView1.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub cl_delete_Click(sender As Object, e As EventArgs) Handles cl_delete.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            Try
                connection.Open()
                Dim Query As String
                Query = "Delete from clients where client_id=" & key & ""
                Dim cmd As MySqlCommand
                cmd = New MySqlCommand(Query, connection)
                cmd.ExecuteNonQuery()
                MsgBox("Client Deleted succesfully")
                connection.Close()

                DGVLoad()
                ClearInputs()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ClearInputs()
        cl_name.Clear()
        cl_age.Clear()
        cl_phone.Clear()
    End Sub

    Private Sub cl_edit_Click(sender As Object, e As EventArgs) Handles cl_edit.Click
        If key = 0 Then
            MsgBox("Missing Selection")
        Else
            Try
                connection.Open()
                Dim Query As String
                Query = "UPDATE clients SET client_name=@client_name, client_gender=@client_gender, client_age=@client_age, client_phone_no=@client_phone_no, client_country=@client_country WHERE client_id=@client_id"
                Dim cmd As MySqlCommand
                cmd = New MySqlCommand(Query, connection)
                cmd.Parameters.AddWithValue("@client_name", cl_name.Text)
                cmd.Parameters.AddWithValue("@client_gender", Combo_cl_gender.Text)
                cmd.Parameters.AddWithValue("@client_age", cl_age.Text)
                cmd.Parameters.AddWithValue("@client_phone_no", cl_phone.Text)
                cmd.Parameters.AddWithValue("@client_country", Combo_country.Text)
                cmd.Parameters.AddWithValue("@client_id", key)

                cmd.ExecuteNonQuery()
                MsgBox("Client Updated successfully")
                connection.Close()

                DGVLoad()
                ClearInputs()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cl_reset_Click(sender As Object, e As EventArgs) Handles cl_reset.Click
        ClearInputs()
        DataGridView1.ClearSelection()
        key = 0 ' Reset the key variable
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Room.Show()
    End Sub
End Class
