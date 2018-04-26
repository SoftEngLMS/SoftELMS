Public Class StudHome
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub StudInfo_Click(sender As Object, e As EventArgs) Handles StudInfo.Click
        Dim studInfo As New StuInfo
        Me.Close()
        studInfo.Show()
    End Sub

    Private Sub Schedule_Click(sender As Object, e As EventArgs) Handles Schedule.Click
        Dim schedule As New Schedule
        Me.Close()
        schedule.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim registration As New Regristration
        Me.Close()
        registration.Show()
    End Sub

End Class