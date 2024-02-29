Imports MySql.Data.MySqlClient

Public Class Reservation
    Dim connectionString As String = "server=localhost;port=3306;database=hotel management;uid=root;password=;"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClients()
        LoadFreeRooms()
        LoadReservations()
    End Sub

    Private Sub LoadClients()
        Try
            connection.Open()
            Dim query As String = "SELECT client_id, client_name FROM clients"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim clientTable As New DataTable()
            adapter.Fill(clientTable)
            Combo_id.DataSource = clientTable
            Combo_id.DisplayMember = "client_id"
        Catch ex As Exception
            MessageBox.Show("Error loading clients: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub LoadFreeRooms()
        Try
            connection.Open()
            Dim query As String = "SELECT room_number FROM rooms WHERE room_status = 'free'"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim roomTable As New DataTable()
            adapter.Fill(roomTable)
            Combo_rmnumber.DataSource = roomTable
            Combo_rmnumber.DisplayMember = "room_number"
        Catch ex As Exception
            MessageBox.Show("Error loading free rooms: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub LoadReservations()
        Try
            connection.Open()
            Dim query As String = "SELECT client_id, client_name, room_number, date_in, date_out FROM reservation"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim reservationTable As New DataTable()
            adapter.Fill(reservationTable)
            DataGridView1.DataSource = reservationTable
        Catch ex As Exception
            MessageBox.Show("Error loading reservations: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub combo_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_id.SelectedIndexChanged
        Dim selectedClientId As Integer = Convert.ToInt32(Combo_id.SelectedValue)

        Try
            connection.Open()
            Dim query As String = "SELECT client_name FROM clients WHERE client_id = @client_id"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@client_id", selectedClientId)
            Dim clientName As String = Convert.ToString(cmd.ExecuteScalar())
            client_name.Text = clientName
        Catch ex As Exception
            MessageBox.Show("Error retrieving client name: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub rs_add_Click(sender As Object, e As EventArgs) Handles rs_add.Click
        Dim selectedClientId As Integer = Convert.ToInt32(Combo_id.SelectedValue)
        Dim selectedRoomNumber As String = Combo_rmnumber.SelectedValue.ToString()
        Dim dateIn As Date = DateTimePicker1.Value
        Dim dateOut As Date = DateTimePicker2.Value

        Try
            connection.Open()
            Dim query As String = "INSERT INTO reservation (client_id, room_number, date_in, date_out) VALUES (@client_id, @room_number, @date_in, @date_out)"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@client_id", selectedClientId)
            cmd.Parameters.AddWithValue("@room_number", selectedRoomNumber)
            cmd.Parameters.AddWithValue("@date_in", dateIn)
            cmd.Parameters.AddWithValue("@date_out", dateOut)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Reservation added successfully.")
            LoadReservations() ' Refresh DataGridView after adding a reservation
        Catch ex As Exception
            MessageBox.Show("Error adding reservation: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Staff.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Room.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Client.Show()
        Me.Close()
    End Sub
End Class
