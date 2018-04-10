Public Class Form2
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim FrmHome As New Form1  'this creates a from that connects to the Home page
        Me.Close() 'Hide the current form
        FrmHome.Show() 'show the home page  form
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'close the program
        Form1.Close() 'to exit the homepage as well
    End Sub

    Private Sub btnTasks1_Click(sender As Object, e As EventArgs) Handles btnTasks1.Click
        Me.Close()
        Task.Show()
    End Sub
End Class