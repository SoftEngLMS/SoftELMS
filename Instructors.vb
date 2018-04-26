Public Class instructorsForm

    Dim db As New northwindDataContext

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
        Administrator.Close()
        LoginForm.Show()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim search = From s In db.FacultyTables
                     Where s.FacultyId = txtSearch.Text
                     Select s.FacultyId, s.ProfName, s.ProfLastname, s.Email, s.PhoneNumber

        DataGridViewSearch.DataSource = search

    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click

        LabelProfname.Visible = False
        LabelProfLastname.Visible = False
        LabelEmail.Visible = False
        LabelPhoneNum.Visible = False
        LabelUserId.Visible = False

        TextBoxProfname.Visible = False
        TextBoxProfLastname.Visible = False
        TextBoxEmail.Visible = False
        TextBoxPhoneNum.Visible = False
        TextBoxUserId.Visible = False

        LabelDel.Visible = False
        TextBoxDel.Visible = False
        ButtonDel.Visible = False

        AddProf.Visible = False

        txtSearch.Clear()
        TextBoxProfname.Clear()
        TextBoxProfLastname.Clear()
        TextBoxEmail.Clear()
        TextBoxPhoneNum.Clear()
        TextBoxUserId.Clear()
        TextBoxDel.Clear()

        DataGridViewSearch.Columns.Clear()

        txtSearch.Focus()
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim AdminHome As New Administrator
        Me.Close()
        AdminHome.Show()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        LabelProfname.Visible = True
        LabelProfLastname.Visible = True
        LabelEmail.Visible = True
        LabelPhoneNum.Visible = True
        LabelUserId.Visible = True

        TextBoxProfname.Visible = True
        TextBoxProfLastname.Visible = True
        TextBoxEmail.Visible = True
        TextBoxPhoneNum.Visible = True
        TextBoxUserId.Visible = True

        AddProf.Visible = True
    End Sub

    Private Sub AddProf_Click(sender As Object, e As EventArgs) Handles AddProf.Click
        Dim strTest, uName As String
        Dim strArray() As String

        Dim addProf As New FacultyTable With {
        .FacultyId = txtSearch.Text,
        .ProfName = TextBoxProfname.Text,
        .ProfLastname = TextBoxProfLastname.Text,
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

        db.FacultyTables.InsertOnSubmit(addProf)
        db.UserTables.InsertOnSubmit(addUser)
        db.SubmitChanges()

        Dim update = From up In db.FacultyTables
                     Select up.FacultyId, up.ProfName, up.ProfLastname, up.Email, up.PhoneNumber, up.UserId

        DataGridViewSearch.DataSource = update

    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        LabelDel.Visible = True
        TextBoxDel.Visible = True
        ButtonDel.Visible = True

        Dim faculty = From f In db.FacultyTables
                      Select f.FacultyId, f.ProfName, f.ProfLastname, f.Email, f.PhoneNumber, f.UserId

        DataGridViewSearch.DataSource = faculty

    End Sub

    Private Sub ButtonDel_Click(sender As Object, e As EventArgs) Handles ButtonDel.Click
        Dim deleteProf = (From f In db.FacultyTables
                          Where f.FacultyId = TextBoxDel.Text).ToList()(0)

        Dim deleteUser = (From u In db.UserTables
                          Where u.UserId = TextBoxDel.Text).ToList()(0)

        db.FacultyTables.DeleteOnSubmit(deleteProf)
        db.UserTables.DeleteOnSubmit(deleteUser)
        db.SubmitChanges()

        Dim faculty = From f In db.FacultyTables
                      Select f.FacultyId, f.ProfName, f.ProfLastname, f.Email, f.PhoneNumber, f.UserId

        DataGridViewSearch.DataSource = faculty

    End Sub
End Class


