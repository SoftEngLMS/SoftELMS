Imports System.Data.SqlClient

Public Class LoginForm


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

        Dim connection As New SqlConnection("Server = (localdb)\ProjectsV13; Database = MainLMS; Integrated Security = true")
        Dim command As New SqlCommand("select * from UserTable where Username = @Username and Password = @password", connection)
        Dim db As New northwindDataContext

        command.Parameters.Add("@username", SqlDbType.VarChar).Value = UserTextBox.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = PassTextBox.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim UserTable As New DataTable()
        adapter.Fill(UserTable)

        If UserTable.Rows.Count() <= 0 Then

            MessageBox.Show("Username or Password is invalid")

        Else

            Dim sUsers = From user In db.UserTables
                         Where user.Username = UserTextBox.Text And user.Role = "Student"
                         Select user.Username, user.Role

            Dim pUsers = From user In db.UserTables
                         Where user.Username = UserTextBox.Text And user.Role = "Professor"
                         Select user.Username, user.Role

            Dim aUsers = From user In db.UserTables
                         Where user.Username = UserTextBox.Text And user.Role = "Admin"
                         Select user.Username, user.Role

            If sUsers.Count() = 1 Then
                MessageBox.Show("Student login succesfull")
                Dim Studhome As New StudHome()
                Me.Hide()
                Studhome.Show()

            ElseIf aUsers.Count() = 1 Then
                MessageBox.Show("Administrator login succesfull")
                Dim AdminForm As New Administrator()
                Me.Hide()
                AdminForm.Show()
            End If


        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class
