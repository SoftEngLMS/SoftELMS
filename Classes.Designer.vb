<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Classes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Classes))
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ButtonDel = New System.Windows.Forms.Button()
        Me.TextBoxDel = New System.Windows.Forms.TextBox()
        Me.LabelDel = New System.Windows.Forms.Label()
        Me.LabelCourseName = New System.Windows.Forms.Label()
        Me.labelSemester = New System.Windows.Forms.Label()
        Me.LabelFaculty = New System.Windows.Forms.Label()
        Me.LabelCourseId = New System.Windows.Forms.Label()
        Me.LabelEnd = New System.Windows.Forms.Label()
        Me.LabelStart = New System.Windows.Forms.Label()
        Me.LabelCredits = New System.Windows.Forms.Label()
        Me.TextBoxCourseName = New System.Windows.Forms.TextBox()
        Me.TextBoxCredits = New System.Windows.Forms.TextBox()
        Me.TextBoxSemester = New System.Windows.Forms.TextBox()
        Me.AddCourse = New System.Windows.Forms.Button()
        Me.TextBoxEndDate = New System.Windows.Forms.TextBox()
        Me.TextBoxStartDate = New System.Windows.Forms.TextBox()
        Me.TextBoxFacultyId = New System.Windows.Forms.TextBox()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.DataGridViewSearch = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridViewSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Location = New System.Drawing.Point(14, 15)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(83, 24)
        Me.cmdAdd.TabIndex = 0
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdRemove
        '
        Me.cmdRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemove.Location = New System.Drawing.Point(14, 45)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(83, 23)
        Me.cmdRemove.TabIndex = 1
        Me.cmdRemove.Text = "Remove"
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(12, 22)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(120, 20)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.Text = "Class Options"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SplitContainer1.BackgroundImage = CType(resources.GetObject("SplitContainer1.BackgroundImage"), System.Drawing.Image)
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 58)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackgroundImage = CType(resources.GetObject("SplitContainer1.Panel1.BackgroundImage"), System.Drawing.Image)
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonDel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxDel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelDel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdAdd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdRemove)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImage = CType(resources.GetObject("SplitContainer1.Panel2.BackgroundImage"), System.Drawing.Image)
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelCourseName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.labelSemester)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelFaculty)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelCourseId)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelEnd)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelStart)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelCredits)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxCourseName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxCredits)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxSemester)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AddCourse)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxEndDate)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxStartDate)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxFacultyId)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BackBtn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridViewSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdReset)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdSearch)
        Me.SplitContainer1.Size = New System.Drawing.Size(886, 408)
        Me.SplitContainer1.SplitterDistance = 143
        Me.SplitContainer1.TabIndex = 3
        '
        'ButtonDel
        '
        Me.ButtonDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDel.Location = New System.Drawing.Point(3, 228)
        Me.ButtonDel.Name = "ButtonDel"
        Me.ButtonDel.Size = New System.Drawing.Size(131, 23)
        Me.ButtonDel.TabIndex = 13
        Me.ButtonDel.Text = "Delete Course"
        Me.ButtonDel.UseVisualStyleBackColor = True
        Me.ButtonDel.Visible = False
        '
        'TextBoxDel
        '
        Me.TextBoxDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDel.Location = New System.Drawing.Point(1, 186)
        Me.TextBoxDel.Name = "TextBoxDel"
        Me.TextBoxDel.Size = New System.Drawing.Size(131, 21)
        Me.TextBoxDel.TabIndex = 12
        Me.TextBoxDel.Visible = False
        '
        'LabelDel
        '
        Me.LabelDel.AutoSize = True
        Me.LabelDel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDel.Location = New System.Drawing.Point(-2, 153)
        Me.LabelDel.Name = "LabelDel"
        Me.LabelDel.Size = New System.Drawing.Size(134, 17)
        Me.LabelDel.TabIndex = 11
        Me.LabelDel.Text = "Enter Id to delete"
        Me.LabelDel.Visible = False
        '
        'LabelCourseName
        '
        Me.LabelCourseName.AutoSize = True
        Me.LabelCourseName.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelCourseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCourseName.Location = New System.Drawing.Point(21, 45)
        Me.LabelCourseName.Name = "LabelCourseName"
        Me.LabelCourseName.Size = New System.Drawing.Size(98, 17)
        Me.LabelCourseName.TabIndex = 63
        Me.LabelCourseName.Text = "Course Name "
        Me.LabelCourseName.Visible = False
        '
        'labelSemester
        '
        Me.labelSemester.AutoSize = True
        Me.labelSemester.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.labelSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSemester.Location = New System.Drawing.Point(21, 94)
        Me.labelSemester.Name = "labelSemester"
        Me.labelSemester.Size = New System.Drawing.Size(68, 17)
        Me.labelSemester.TabIndex = 62
        Me.labelSemester.Text = "Semester"
        Me.labelSemester.Visible = False
        '
        'LabelFaculty
        '
        Me.LabelFaculty.AutoSize = True
        Me.LabelFaculty.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelFaculty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFaculty.Location = New System.Drawing.Point(21, 121)
        Me.LabelFaculty.Name = "LabelFaculty"
        Me.LabelFaculty.Size = New System.Drawing.Size(64, 17)
        Me.LabelFaculty.TabIndex = 61
        Me.LabelFaculty.Text = "FacultyId"
        Me.LabelFaculty.Visible = False
        '
        'LabelCourseId
        '
        Me.LabelCourseId.AutoSize = True
        Me.LabelCourseId.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelCourseId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCourseId.Location = New System.Drawing.Point(21, 15)
        Me.LabelCourseId.Name = "LabelCourseId"
        Me.LabelCourseId.Size = New System.Drawing.Size(110, 17)
        Me.LabelCourseId.TabIndex = 60
        Me.LabelCourseId.Text = "Enter Course Id "
        '
        'LabelEnd
        '
        Me.LabelEnd.AutoSize = True
        Me.LabelEnd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEnd.Location = New System.Drawing.Point(21, 172)
        Me.LabelEnd.Name = "LabelEnd"
        Me.LabelEnd.Size = New System.Drawing.Size(69, 17)
        Me.LabelEnd.TabIndex = 58
        Me.LabelEnd.Text = "End date "
        Me.LabelEnd.Visible = False
        '
        'LabelStart
        '
        Me.LabelStart.AutoSize = True
        Me.LabelStart.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStart.Location = New System.Drawing.Point(21, 147)
        Me.LabelStart.Name = "LabelStart"
        Me.LabelStart.Size = New System.Drawing.Size(74, 17)
        Me.LabelStart.TabIndex = 57
        Me.LabelStart.Text = "Start date "
        Me.LabelStart.Visible = False
        '
        'LabelCredits
        '
        Me.LabelCredits.AutoSize = True
        Me.LabelCredits.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelCredits.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCredits.Location = New System.Drawing.Point(21, 71)
        Me.LabelCredits.Name = "LabelCredits"
        Me.LabelCredits.Size = New System.Drawing.Size(52, 17)
        Me.LabelCredits.TabIndex = 56
        Me.LabelCredits.Text = "Credits"
        Me.LabelCredits.Visible = False
        '
        'TextBoxCourseName
        '
        Me.TextBoxCourseName.Location = New System.Drawing.Point(224, 44)
        Me.TextBoxCourseName.Name = "TextBoxCourseName"
        Me.TextBoxCourseName.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxCourseName.TabIndex = 55
        Me.TextBoxCourseName.Visible = False
        '
        'TextBoxCredits
        '
        Me.TextBoxCredits.Location = New System.Drawing.Point(224, 69)
        Me.TextBoxCredits.Name = "TextBoxCredits"
        Me.TextBoxCredits.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxCredits.TabIndex = 54
        Me.TextBoxCredits.Visible = False
        '
        'TextBoxSemester
        '
        Me.TextBoxSemester.Location = New System.Drawing.Point(224, 93)
        Me.TextBoxSemester.Name = "TextBoxSemester"
        Me.TextBoxSemester.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxSemester.TabIndex = 53
        Me.TextBoxSemester.Visible = False
        '
        'AddCourse
        '
        Me.AddCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddCourse.Location = New System.Drawing.Point(434, 171)
        Me.AddCourse.Name = "AddCourse"
        Me.AddCourse.Size = New System.Drawing.Size(109, 23)
        Me.AddCourse.TabIndex = 49
        Me.AddCourse.Text = "Add Course"
        Me.AddCourse.UseVisualStyleBackColor = True
        Me.AddCourse.Visible = False
        '
        'TextBoxEndDate
        '
        Me.TextBoxEndDate.Location = New System.Drawing.Point(224, 171)
        Me.TextBoxEndDate.Name = "TextBoxEndDate"
        Me.TextBoxEndDate.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxEndDate.TabIndex = 45
        Me.TextBoxEndDate.Visible = False
        '
        'TextBoxStartDate
        '
        Me.TextBoxStartDate.Location = New System.Drawing.Point(224, 145)
        Me.TextBoxStartDate.Name = "TextBoxStartDate"
        Me.TextBoxStartDate.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxStartDate.TabIndex = 44
        Me.TextBoxStartDate.Visible = False
        '
        'TextBoxFacultyId
        '
        Me.TextBoxFacultyId.Location = New System.Drawing.Point(224, 119)
        Me.TextBoxFacultyId.Name = "TextBoxFacultyId"
        Me.TextBoxFacultyId.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxFacultyId.TabIndex = 43
        Me.TextBoxFacultyId.Visible = False
        '
        'BackBtn
        '
        Me.BackBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.Location = New System.Drawing.Point(640, 78)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(83, 23)
        Me.BackBtn.TabIndex = 42
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'DataGridViewSearch
        '
        Me.DataGridViewSearch.AllowUserToAddRows = False
        Me.DataGridViewSearch.AllowUserToDeleteRows = False
        Me.DataGridViewSearch.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridViewSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSearch.Location = New System.Drawing.Point(3, 200)
        Me.DataGridViewSearch.Name = "DataGridViewSearch"
        Me.DataGridViewSearch.Size = New System.Drawing.Size(729, 198)
        Me.DataGridViewSearch.TabIndex = 41
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(224, 15)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(157, 20)
        Me.txtSearch.TabIndex = 40
        '
        'cmdReset
        '
        Me.cmdReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.Location = New System.Drawing.Point(640, 41)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(83, 23)
        Me.cmdReset.TabIndex = 39
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Location = New System.Drawing.Point(640, 12)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(83, 23)
        Me.cmdSearch.TabIndex = 38
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(823, 472)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "Logout"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Classes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(910, 507)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.lblMessage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Classes"
        Me.Text = "Classes"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridViewSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdRemove As Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents cmdExit As Button
    Friend WithEvents TextBoxCourseName As TextBox
    Friend WithEvents TextBoxCredits As TextBox
    Friend WithEvents TextBoxSemester As TextBox
    Friend WithEvents AddCourse As Button
    Friend WithEvents TextBoxEndDate As TextBox
    Friend WithEvents TextBoxStartDate As TextBox
    Friend WithEvents TextBoxFacultyId As TextBox
    Friend WithEvents BackBtn As Button
    Friend WithEvents DataGridViewSearch As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmdReset As Button
    Friend WithEvents cmdSearch As Button
    Friend WithEvents LabelCourseName As Label
    Friend WithEvents labelSemester As Label
    Friend WithEvents LabelFaculty As Label
    Friend WithEvents LabelCourseId As Label
    Friend WithEvents LabelEnd As Label
    Friend WithEvents LabelStart As Label
    Friend WithEvents LabelCredits As Label
    Friend WithEvents ButtonDel As Button
    Friend WithEvents TextBoxDel As TextBox
    Friend WithEvents LabelDel As Label
End Class
