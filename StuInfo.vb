Imports System.Data.SqlClient

Public Class StuInfo

    Dim db As New northwindDataContext
    Dim dt As New DataTable()

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim FrmHome As New StudHome  'this creates a from that connects to the Home page
        Me.Close() 'Hide the current form
        FrmHome.Show() 'show the home page  form

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'Exit the program
        StudHome.Close() 'to exit the homepage as well
        LoginForm.Show()
    End Sub

    Private Sub StuInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection("Server = (localdb)\ProjectsV13; Database = MainLMS; Integrated Security = true")
        connection.Open()
        Dim sqlCmd As New SqlCommand("SELECT * from StudentTable WHERE StudentID = @username", connection)
        Dim sqlDa As New SqlDataAdapter(sqlCmd)

        sqlCmd.Parameters.AddWithValue("@username", 1001)
        sqlDa.Fill(dt)
        If dt.Rows.Count > 0 Then
            lblShowName.Text = dt.Rows(0)("StudentName").ToString
            lblShowStuID.Text = dt.Rows(0)("StudentId").ToString
            lbStuClassification.Text = dt.Rows(0)("Classification").ToString
            lblShowStuEmail.Text = dt.Rows(0)("Email").ToString
        End If
        connection.Close()


    End Sub
End Class
