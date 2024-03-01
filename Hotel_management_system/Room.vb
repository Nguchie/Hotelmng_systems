Imports MySql.Data.MySqlClient

Public Class Room
    Dim connectionString As String = "server=localhost;port=3306;database=hotel management;uid=root;password=;"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub Room_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRooms()
    End Sub

    Private Sub LoadRooms()
        Try
            connection.Open()
            Dim query As String = "SELECT room_id, room_number, room_phone, room_status FROM rooms"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim roomTable As New DataTable()
            adapter.Fill(roomTable)
            DataGridView1.DataSource = roomTable
        Catch ex As Exception
            MessageBox.Show("Error loading rooms: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub rm_add_Click(sender As Object, e As EventArgs) Handles rm_add.Click
        Dim roomNumber As String = Combo_number.Text
        Dim roomPhone As String = rm_phone.Text
        Dim roomStatus As String = Combo_rmstatus.Text

        Try
            connection.Open()
            Dim query As String = "INSERT INTO rooms (room_number, room_phone, room_status) VALUES (@room_number, @room_phone, @room_status)"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@room_number", roomNumber)
            cmd.Parameters.AddWithValue("@room_phone", roomPhone)
            cmd.Parameters.AddWithValue("@room_status", roomStatus)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Room added successfully.")
            LoadRooms() ' Refresh DataGridView after adding a room
        Catch ex As Exception
            MessageBox.Show("Error adding room: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub rm_edit_Click(sender As Object, e As EventArgs) Handles rm_edit.Click
        Dim selectedRow As DataGridViewRow = DataGridView1.CurrentRow
        If selectedRow Is Nothing Then
            MessageBox.Show("Please select a room to edit.")
            Exit Sub
        End If

        Dim roomId As Integer = Convert.ToInt32(selectedRow.Cells("room_id").Value)
        Dim roomNumber As String = Combo_number.Text
        Dim roomPhone As String = rm_phone.Text
        Dim roomStatus As String = Combo_rmstatus.Text

        Try
            connection.Open()
            Dim query As String = "UPDATE rooms SET room_number = @room_number, room_phone = @room_phone, room_status = @room_status WHERE room_id = @room_id"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@room_number", roomNumber)
            cmd.Parameters.AddWithValue("@room_phone", roomPhone)
            cmd.Parameters.AddWithValue("@room_status", roomStatus)
            cmd.Parameters.AddWithValue("@room_id", roomId)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Room updated successfully.")
            LoadRooms() ' Refresh DataGridView after updating a room
        Catch ex As Exception
            MessageBox.Show("Error updating room: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub rm_delete_Click(sender As Object, e As EventArgs) Handles rm_delete.Click
        Dim selectedRow As DataGridViewRow = DataGridView1.CurrentRow
        If selectedRow Is Nothing Then
            MessageBox.Show("Please select a room to delete.")
            Exit Sub
        End If

        Dim roomId As Integer = Convert.ToInt32(selectedRow.Cells("room_id").Value)

        Try
            connection.Open()
            Dim query As String = "DELETE FROM rooms WHERE room_id = @room_id"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@room_id", roomId)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Room deleted successfully.")
            LoadRooms() ' Refresh DataGridView after deleting a room
        Catch ex As Exception
            MessageBox.Show("Error deleting room: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Staff.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Reservation.Show()
    End Sub
End Class
