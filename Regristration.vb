Public Class Regristration
    Dim db As New northwindDataContext

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

    Private Sub cbCSubSearch_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim schedule = From c In db.ClassroomTables, s In db.StudentTables, f In db.FacultyTables, cr In db.CourseTables
                       Where c.StudentId = 1001 And c.StudentId = s.StudentId And c.FacultyId = f.FacultyId And c.CourseId = cr.CourseId
                       Select c.StudentId, s.StudentName, s.StudentLastname, f.ProfName, f.ProfLastname, cr.CourseId, cr.CourseName

        DataGridViewSearch.DataSource = schedule
    End Sub

    Private Sub BtnShowClass_Click(sender As Object, e As EventArgs) Handles BtnShowClass.Click

        Dim show = From c In db.CourseTables, f In db.FacultyTables
                   Where c.FacultyId = f.FacultyId
                   Select c.CourseId, c.CourseName, f.ProfName, f.ProfLastname, c.Credits, c.StartDate, c.EndDate

        DataGridViewAD.DataSource = show

    End Sub

    Private Sub btnAddClass_Click(sender As Object, e As EventArgs) Handles btnAddClass.Click
        Dim addCrs As New ClassroomTable With {
            .ClassId = 17,
            .CourseId = txtCourseID.Text, '3003
            .StudentId = 1001,
            .FacultyId = 2005
        }

        db.ClassroomTables.InsertOnSubmit(addCrs)
        db.SubmitChanges()

        txtCourseID.Clear()
        txtCourseID.Focus()

    End Sub

    Private Sub btnRemoveClass_Click(sender As Object, e As EventArgs) Handles btnRemoveClass.Click
        Dim deleteCrs = (From cl In db.ClassroomTables
                         Where cl.ClassId = 17).ToList()(0)

        db.ClassroomTables.DeleteOnSubmit(deleteCrs)
        db.SubmitChanges()

        txtCourseID.Clear()
        txtCourseID.Focus()
    End Sub

    Private Sub Regristration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class