Imports System.Windows.Forms

Public Class Splash
    Inherits Form

    Private WithEvents ProgressBar2 As ProgressBar ' Declare ProgressBar2
    Private WithEvents Timer1 As Timer

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize ProgressBar2 programmatically
        ProgressBar2 = New ProgressBar With {
            .Minimum = 0,
            .Maximum = 100,
            .Size = New Size(200, 20),
            .Location = New Point((Me.Width - .Width) \ 2, (Me.Height - .Height) \ 2),
            .Visible = True
        }
        Me.Controls.Add(ProgressBar2) ' Add ProgressBar2 to the form's controls

        ' Initialize and start the timer
        Timer1 = New Timer With {
            .Interval = 50
        }
        AddHandler Timer1.Tick, AddressOf Timer1_Tick
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        ' Increment the progress bar value
        ProgressBar2.Increment(1)
        If ProgressBar2.Value >= ProgressBar2.Maximum Then
            Timer1.Stop()
            Dim mainForm As New Client() ' Assuming Staff is a form you want to show next
            mainForm.Show()
            Me.Hide()
        End If
    End Sub
End Class
