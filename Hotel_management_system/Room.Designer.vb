<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Room
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Room))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.rm_reset = New System.Windows.Forms.Button()
        Me.rm_delete = New System.Windows.Forms.Button()
        Me.rm_edit = New System.Windows.Forms.Button()
        Me.rm_add = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_reset = New System.Windows.Forms.TextBox()
        Me.rm_phone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Combo_rmstatus = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Combo_number = New System.Windows.Forms.ComboBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Combo_number)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.rm_reset)
        Me.Panel1.Controls.Add(Me.rm_delete)
        Me.Panel1.Controls.Add(Me.rm_edit)
        Me.Panel1.Controls.Add(Me.rm_add)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.txt_reset)
        Me.Panel1.Controls.Add(Me.rm_phone)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Combo_rmstatus)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(97, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(624, 506)
        Me.Panel1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(77, 322)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(446, 184)
        Me.DataGridView1.TabIndex = 24
        '
        'rm_reset
        '
        Me.rm_reset.BackColor = System.Drawing.SystemColors.HotTrack
        Me.rm_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rm_reset.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rm_reset.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.rm_reset.Location = New System.Drawing.Point(308, 190)
        Me.rm_reset.Margin = New System.Windows.Forms.Padding(2)
        Me.rm_reset.Name = "rm_reset"
        Me.rm_reset.Size = New System.Drawing.Size(77, 61)
        Me.rm_reset.TabIndex = 23
        Me.rm_reset.Text = "Reset"
        Me.rm_reset.UseVisualStyleBackColor = False
        '
        'rm_delete
        '
        Me.rm_delete.BackColor = System.Drawing.SystemColors.HotTrack
        Me.rm_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rm_delete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rm_delete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.rm_delete.Location = New System.Drawing.Point(224, 189)
        Me.rm_delete.Margin = New System.Windows.Forms.Padding(2)
        Me.rm_delete.Name = "rm_delete"
        Me.rm_delete.Size = New System.Drawing.Size(81, 61)
        Me.rm_delete.TabIndex = 22
        Me.rm_delete.Text = "Delete"
        Me.rm_delete.UseVisualStyleBackColor = False
        '
        'rm_edit
        '
        Me.rm_edit.BackColor = System.Drawing.SystemColors.HotTrack
        Me.rm_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rm_edit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rm_edit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.rm_edit.Location = New System.Drawing.Point(131, 189)
        Me.rm_edit.Margin = New System.Windows.Forms.Padding(2)
        Me.rm_edit.Name = "rm_edit"
        Me.rm_edit.Size = New System.Drawing.Size(85, 61)
        Me.rm_edit.TabIndex = 21
        Me.rm_edit.Text = "Edit"
        Me.rm_edit.UseVisualStyleBackColor = False
        '
        'rm_add
        '
        Me.rm_add.BackColor = System.Drawing.SystemColors.HotTrack
        Me.rm_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rm_add.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rm_add.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.rm_add.Location = New System.Drawing.Point(40, 189)
        Me.rm_add.Margin = New System.Windows.Forms.Padding(2)
        Me.rm_add.Name = "rm_add"
        Me.rm_add.Size = New System.Drawing.Size(80, 61)
        Me.rm_add.TabIndex = 20
        Me.rm_add.Text = "Add"
        Me.rm_add.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(578, 211)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'txt_reset
        '
        Me.txt_reset.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_reset.Location = New System.Drawing.Point(406, 208)
        Me.txt_reset.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_reset.Name = "txt_reset"
        Me.txt_reset.Size = New System.Drawing.Size(154, 26)
        Me.txt_reset.TabIndex = 18
        '
        'rm_phone
        '
        Me.rm_phone.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rm_phone.Location = New System.Drawing.Point(177, 113)
        Me.rm_phone.Margin = New System.Windows.Forms.Padding(2)
        Me.rm_phone.Name = "rm_phone"
        Me.rm_phone.Size = New System.Drawing.Size(115, 26)
        Me.rm_phone.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label5.Location = New System.Drawing.Point(174, 93)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 18)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Room Phone"
        '
        'Combo_rmstatus
        '
        Me.Combo_rmstatus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Combo_rmstatus.FormattingEnabled = True
        Me.Combo_rmstatus.Items.AddRange(New Object() {"Booked", "Free"})
        Me.Combo_rmstatus.Location = New System.Drawing.Point(307, 112)
        Me.Combo_rmstatus.Margin = New System.Windows.Forms.Padding(2)
        Me.Combo_rmstatus.Name = "Combo_rmstatus"
        Me.Combo_rmstatus.Size = New System.Drawing.Size(121, 26)
        Me.Combo_rmstatus.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label3.Location = New System.Drawing.Point(312, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Room Status"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(265, 44)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(158, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SOUNDSLEEP HOTEL"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(8, 189)
        Me.Button7.Margin = New System.Windows.Forms.Padding(2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 27)
        Me.Button7.TabIndex = 32
        Me.Button7.Text = "Reservation"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(8, 162)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 31
        Me.Button6.Text = "Client"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(8, 129)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 22)
        Me.Button5.TabIndex = 30
        Me.Button5.Text = "STAFF"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(4, 50)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 22)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Rooms"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label2.Location = New System.Drawing.Point(28, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Room Number"
        '
        'Combo_number
        '
        Me.Combo_number.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Combo_number.FormattingEnabled = True
        Me.Combo_number.Items.AddRange(New Object() {"201", "202", "203", "204", "205", "206"})
        Me.Combo_number.Location = New System.Drawing.Point(28, 112)
        Me.Combo_number.Margin = New System.Windows.Forms.Padding(2)
        Me.Combo_number.Name = "Combo_number"
        Me.Combo_number.Size = New System.Drawing.Size(121, 26)
        Me.Combo_number.TabIndex = 26
        '
        'Column1
        '
        Me.Column1.HeaderText = "room_id"
        Me.Column1.Name = "Column1"
        '
        'Column4
        '
        Me.Column4.HeaderText = "room_number"
        Me.Column4.Name = "Column4"
        '
        'Column2
        '
        Me.Column2.HeaderText = "room_phone"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "room status"
        Me.Column3.Name = "Column3"
        '
        'Room
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(721, 506)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Room"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents rm_reset As Button
    Friend WithEvents rm_delete As Button
    Friend WithEvents rm_edit As Button
    Friend WithEvents rm_add As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txt_reset As TextBox
    Friend WithEvents rm_phone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Combo_rmstatus As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Combo_number As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
