Public Class Classes

    Dim db As New northwindDataContext

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
        Administrator.Close()
        LoginForm.Show()
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim AdminHome As New Administrator
        Me.Close()
        AdminHome.Show()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        LabelCourseName.Visible = True
        LabelCredits.Visible = True
        labelSemester.Visible = True
        LabelFaculty.Visible = True
        LabelStart.Visible = True
        LabelEnd.Visible = True

        TextBoxCourseName.Visible = True
        TextBoxCredits.Visible = True
        TextBoxSemester.Visible = True
        TextBoxFacultyId.Visible = True
        TextBoxStartDate.Visible = True
        TextBoxEndDate.Visible = True

        AddCourse.Visible = True
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim search = From c In db.CourseTables, f In db.FacultyTables
                     Where c.CourseId = txtSearch.Text And c.FacultyId = f.FacultyId
                     Select c.CourseId, c.CourseName, c.Credits, c.FacultyId, f.ProfName, f.ProfLastname, c.StartDate, c.EndDate

        DataGridViewSearch.DataSource = search
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        LabelCourseName.Visible = False
        LabelCredits.Visible = False
        labelSemester.Visible = False
        LabelFaculty.Visible = False
        LabelStart.Visible = False
        LabelEnd.Visible = False

        TextBoxCourseName.Visible = False
        TextBoxCredits.Visible = False
        TextBoxSemester.Visible = False
        TextBoxFacultyId.Visible = False
        TextBoxStartDate.Visible = False
        TextBoxEndDate.Visible = False

        LabelDel.Visible = False
        TextBoxDel.Visible = False
        ButtonDel.Visible = False

        AddCourse.Visible = False

        txtSearch.Clear()
        TextBoxCourseName.Clear()
        TextBoxCredits.Clear()
        TextBoxSemester.Clear()
        TextBoxFacultyId.Clear()
        TextBoxStartDate.Clear()
        TextBoxEndDate.Clear()
        TextBoxDel.Clear()

        DataGridViewSearch.Columns.Clear()

        txtSearch.Focus()
    End Sub

    Private Sub AddCourse_Click(sender As Object, e As EventArgs) Handles AddCourse.Click
        Dim addCourse As New CourseTable With {
       .CourseId = txtSearch.Text,
       .CourseName = TextBoxCourseName.Text,
       .Credits = TextBoxCredits.Text,
       .Semester = TextBoxSemester.Text,
       .FacultyId = TextBoxFacultyId.Text,
       .StartDate = TextBoxStartDate.Text,
       .EndDate = TextBoxEndDate.Text
       }

        db.CourseTables.InsertOnSubmit(addCourse)
        db.SubmitChanges()

        Dim search = From c In db.CourseTables, f In db.FacultyTables
                     Where c.FacultyId = f.FacultyId
                     Select c.CourseId, c.CourseName, c.Credits, c.FacultyId, f.ProfName, f.ProfLastname, c.StartDate, c.EndDate

        DataGridViewSearch.DataSource = search
    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        LabelDel.Visible = True
        TextBoxDel.Visible = True
        ButtonDel.Visible = True

        Dim search = From c In db.CourseTables, f In db.FacultyTables
                     Where c.FacultyId = f.FacultyId
                     Select c.CourseId, c.CourseName, c.Credits, c.FacultyId, f.ProfName, f.ProfLastname, c.StartDate, c.EndDate

        DataGridViewSearch.DataSource = search
    End Sub

    Private Sub ButtonDel_Click(sender As Object, e As EventArgs) Handles ButtonDel.Click
        Dim deleteCourse = (From c In db.CourseTables
                            Where c.CourseId = TextBoxDel.Text).ToList()(0)

        db.CourseTables.DeleteOnSubmit(deleteCourse)
        db.SubmitChanges()

        Dim search = From c In db.CourseTables, f In db.FacultyTables
                     Where c.FacultyId = f.FacultyId
                     Select c.CourseId, c.CourseName, c.Credits, c.FacultyId, f.ProfName, f.ProfLastname, c.StartDate, c.EndDate

        DataGridViewSearch.DataSource = search
    End Sub
End Class