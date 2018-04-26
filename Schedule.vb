Imports System.Data.SqlClient

Public Class Schedule

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

    Private Sub Schedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connection As New SqlConnection("Server = (localdb)\ProjectsV13; Database = MainLMS; Integrated Security = true")
        connection.Open()
        Dim sqlCmd As New SqlCommand("SELECT * from StudentTable WHERE StudentID = @username", connection)
        Dim sqlDa As New SqlDataAdapter(sqlCmd)

        sqlCmd.Parameters.AddWithValue("@username", 1001)
        sqlDa.Fill(dt)
        If dt.Rows.Count > 0 Then
            lblShowName.Text = dt.Rows(0)("StudentName").ToString
            lblShowStuID.Text = dt.Rows(0)("StudentId").ToString
        End If
        connection.Close()

        Dim schedule = From c In db.ClassroomTables, s In db.StudentTables, f In db.FacultyTables, cr In db.CourseTables
                       Where c.StudentId = 1001 And c.StudentId = s.StudentId And c.FacultyId = f.FacultyId And c.CourseId = cr.CourseId
                       Select c.StudentId, s.StudentName, s.StudentLastname, f.ProfName, f.ProfLastname, cr.CourseId, cr.CourseName

        DataGridViewSearch.DataSource = schedule

    End Sub
End Class