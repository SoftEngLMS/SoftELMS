Public Class studentsForm

    Dim db As New northwindDataContext

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
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
        labelStudname.Visible = True
        LabelStudLastname.Visible = True
        labelClassif.Visible = True
        LabelGender.Visible = True
        LabelEmail.Visible = True
        LabelPhoneNum.Visible = True
        LabelUserId.Visible = True

        TextBoxStudName.Visible = True
        TextBoxStudLastName.Visible = True
        TextBoxClassif.Visible = True
        TextBoxGender.Visible = True
        TextBoxEmail.Visible = True
        TextBoxPhoneNum.Visible = True
        TextBoxUserId.Visible = True

        AddStud.Visible = True
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click

        Dim search = From s In db.StudentTables
                     Where s.StudentId = txtSearch.Text
                     Select s.StudentId, s.StudentName, s.StudentLastname, s.Classification, s.Gender, s.Email, s.PhoneNumber

        DataGridViewSearch.DataSource = search

    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        labelStudname.Visible = False
        LabelStudLastname.Visible = False
        labelClassif.Visible = False
        LabelGender.Visible = False
        LabelEmail.Visible = False
        LabelPhoneNum.Visible = False
        LabelUserId.Visible = False

        TextBoxStudName.Visible = False
        TextBoxStudLastName.Visible = False
        TextBoxClassif.Visible = False
        TextBoxGender.Visible = False
        TextBoxEmail.Visible = False
        TextBoxPhoneNum.Visible = False
        TextBoxUserId.Visible = False

        LabelDel.Visible = False
        TextBoxDel.Visible = False
        ButtonDel.Visible = False

        AddStud.Visible = False

        txtSearch.Clear()
        TextBoxStudName.Clear()
        TextBoxStudLastName.Clear()
        TextBoxClassif.Clear()
        TextBoxGender.Clear()
        TextBoxEmail.Clear()
        TextBoxPhoneNum.Clear()
        TextBoxUserId.Clear()
        TextBoxDel.Clear()

        DataGridViewSearch.Columns.Clear()

        txtSearch.Focus()
    End Sub

    Private Sub AddStud_Click(sender As Object, e As EventArgs) Handles AddStud.Click
        Dim strTest, uName As String
        Dim strArray() As String

        Dim addStud As New StudentTable With {
        .StudentId = txtSearch.Text,
        .StudentName = TextBoxStudName.Text,
        .StudentLastname = TextBoxStudLastName.Text,
        .Classification = TextBoxClassif.Text,
        .Gender = TextBoxGender.Text,
        .Email = TextBoxEmail.Text,
        .PhoneNumber = TextBoxPhoneNum.Text,
        .UserId = TextBoxUserId.Text
        }

        strTest = TextBoxEmail.Text
        strArray = Split(strTest, "@")
        uName = strArray(0)

        Dim addUser As New UserTable With {
        .UserId = txtSearch.Text,
        .Username = uName,
        .Password = txtSearch.Text,
        .Role = "Professor"
        }

        db.StudentTables.InsertOnSubmit(addStud)
        db.UserTables.InsertOnSubmit(addUser)
        db.SubmitChanges()

        Dim update = From up In db.StudentTables
                     Select up.StudentId, up.StudentName, up.StudentLastname, up.Classification, up.Gender, up.Email, up.PhoneNumber, up.UserId

        DataGridViewSearch.DataSource = update
    End Sub

    Private Sub ButtonDel_Click(sender As Object, e As EventArgs) Handles ButtonDel.Click
        Dim deleteStud = (From s In db.StudentTables
                          Where s.StudentId = TextBoxDel.Text).ToList()(0)

        Dim deleteUser = (From u In db.UserTables
                          Where u.UserId = TextBoxDel.Text).ToList()(0)

        db.StudentTables.DeleteOnSubmit(deleteStud)
        db.UserTables.DeleteOnSubmit(deleteUser)
        db.SubmitChanges()

        Dim student = From s In db.StudentTables
                      Select s.StudentId, s.StudentName, s.StudentLastname, s.Classification, s.Gender, s.Email, s.PhoneNumber, s.UserId

        DataGridViewSearch.DataSource = student
    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        LabelDel.Visible = True
        TextBoxDel.Visible = True
        ButtonDel.Visible = True

        Dim student = From s In db.StudentTables
                      Select s.StudentId, s.StudentName, s.StudentLastname, s.Classification, s.Gender, s.Email, s.PhoneNumber, s.UserId

        DataGridViewSearch.DataSource = student
    End Sub
End Class