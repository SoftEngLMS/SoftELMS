Public Class Administrator
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub


    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub cmdInstructors_Click(sender As Object, e As EventArgs) Handles cmdInstructors.Click
        Call instructorOptions()

    End Sub

    Private Sub cmdClasses_Click(sender As Object, e As EventArgs) Handles cmdClasses.Click
        Call classOptions()
    End Sub

    Private Sub classOptions()
        Classes.Text = "Classes"
        Classes.lblMessage.Text = "Add, Remove, Swap and Search for Classes."
        Classes.Show()
        Me.Close()

    End Sub

    Private Sub instructorOptions()
        instructorsForm.Text = "Instructors"
        instructorsForm.lblMessage.Text = "Add, Remove, Swap and Search for Instructors."
        instructorsForm.Show()
        Me.Close()
    End Sub

    Private Sub studentoptions()
        studentsForm.Text = "Students"
        studentsForm.lblMessage.Text = "Add, Remove, Swap and Search for Students."
        studentsForm.Show()
        Me.Close()
    End Sub

    Private Sub cmdStudents_Click(sender As Object, e As EventArgs) Handles cmdStudents.Click
        Call studentoptions()
    End Sub
End Class
