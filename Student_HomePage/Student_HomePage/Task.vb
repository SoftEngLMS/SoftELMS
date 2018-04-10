Public Class Task
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim FrmHome As New Form2  'this creates a from that connects to the Home page
        Me.Close() 'Hide the current form
        FrmHome.Show() 'show the home page  form
    End Sub

End Class