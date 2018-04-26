<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentsForm))
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ButtonDel = New System.Windows.Forms.Button()
        Me.TextBoxDel = New System.Windows.Forms.TextBox()
        Me.LabelDel = New System.Windows.Forms.Label()
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.TextBoxStudName = New System.Windows.Forms.TextBox()
        Me.TextBoxStudLastName = New System.Windows.Forms.TextBox()
        Me.TextBoxClassif = New System.Windows.Forms.TextBox()
        Me.labelStudname = New System.Windows.Forms.Label()
        Me.labelClassif = New System.Windows.Forms.Label()
        Me.LabelGender = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddStud = New System.Windows.Forms.Button()
        Me.LabelUserId = New System.Windows.Forms.Label()
        Me.LabelPhoneNum = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelStudLastname = New System.Windows.Forms.Label()
        Me.TextBoxUserId = New System.Windows.Forms.TextBox()
        Me.TextBoxPhoneNum = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxGender = New System.Windows.Forms.TextBox()
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
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(12, 23)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(140, 20)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "Student Options"
        '
        'SplitContainer1
        '
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdRemove)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdAdd)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImage = CType(resources.GetObject("SplitContainer1.Panel2.BackgroundImage"), System.Drawing.Image)
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxStudName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxStudLastName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxClassif)
        Me.SplitContainer1.Panel2.Controls.Add(Me.labelStudname)
        Me.SplitContainer1.Panel2.Controls.Add(Me.labelClassif)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelGender)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AddStud)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelUserId)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelPhoneNum)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelEmail)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelStudLastname)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxUserId)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxPhoneNum)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxEmail)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxGender)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BackBtn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridViewSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdReset)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdSearch)
        Me.SplitContainer1.Size = New System.Drawing.Size(878, 364)
        Me.SplitContainer1.SplitterDistance = 152
        Me.SplitContainer1.TabIndex = 1
        '
        'ButtonDel
        '
        Me.ButtonDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDel.Location = New System.Drawing.Point(24, 207)
        Me.ButtonDel.Name = "ButtonDel"
        Me.ButtonDel.Size = New System.Drawing.Size(90, 23)
        Me.ButtonDel.TabIndex = 10
        Me.ButtonDel.Text = "Delete Stud"
        Me.ButtonDel.UseVisualStyleBackColor = True
        Me.ButtonDel.Visible = False
        '
        'TextBoxDel
        '
        Me.TextBoxDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDel.Location = New System.Drawing.Point(10, 164)
        Me.TextBoxDel.Name = "TextBoxDel"
        Me.TextBoxDel.Size = New System.Drawing.Size(131, 21)
        Me.TextBoxDel.TabIndex = 9
        Me.TextBoxDel.Visible = False
        '
        'LabelDel
        '
        Me.LabelDel.AutoSize = True
        Me.LabelDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDel.Location = New System.Drawing.Point(7, 131)
        Me.LabelDel.Name = "LabelDel"
        Me.LabelDel.Size = New System.Drawing.Size(134, 17)
        Me.LabelDel.TabIndex = 8
        Me.LabelDel.Text = "Enter Id to delete"
        Me.LabelDel.Visible = False
        '
        'cmdRemove
        '
        Me.cmdRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemove.Location = New System.Drawing.Point(24, 42)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(90, 24)
        Me.cmdRemove.TabIndex = 4
        Me.cmdRemove.Text = "Remove"
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Location = New System.Drawing.Point(24, 12)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(90, 24)
        Me.cmdAdd.TabIndex = 3
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'TextBoxStudName
        '
        Me.TextBoxStudName.Location = New System.Drawing.Point(206, 42)
        Me.TextBoxStudName.Name = "TextBoxStudName"
        Me.TextBoxStudName.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxStudName.TabIndex = 37
        Me.TextBoxStudName.Visible = False
        '
        'TextBoxStudLastName
        '
        Me.TextBoxStudLastName.Location = New System.Drawing.Point(206, 67)
        Me.TextBoxStudLastName.Name = "TextBoxStudLastName"
        Me.TextBoxStudLastName.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxStudLastName.TabIndex = 36
        Me.TextBoxStudLastName.Visible = False
        '
        'TextBoxClassif
        '
        Me.TextBoxClassif.Location = New System.Drawing.Point(206, 91)
        Me.TextBoxClassif.Name = "TextBoxClassif"
        Me.TextBoxClassif.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxClassif.TabIndex = 35
        Me.TextBoxClassif.Visible = False
        '
        'labelStudname
        '
        Me.labelStudname.AutoSize = True
        Me.labelStudname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelStudname.Location = New System.Drawing.Point(3, 42)
        Me.labelStudname.Name = "labelStudname"
        Me.labelStudname.Size = New System.Drawing.Size(138, 17)
        Me.labelStudname.TabIndex = 34
        Me.labelStudname.Text = "Enter Student name "
        Me.labelStudname.Visible = False
        '
        'labelClassif
        '
        Me.labelClassif.AutoSize = True
        Me.labelClassif.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelClassif.Location = New System.Drawing.Point(3, 91)
        Me.labelClassif.Name = "labelClassif"
        Me.labelClassif.Size = New System.Drawing.Size(90, 17)
        Me.labelClassif.TabIndex = 33
        Me.labelClassif.Text = "Classification"
        Me.labelClassif.Visible = False
        '
        'LabelGender
        '
        Me.LabelGender.AutoSize = True
        Me.LabelGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGender.Location = New System.Drawing.Point(3, 118)
        Me.LabelGender.Name = "LabelGender"
        Me.LabelGender.Size = New System.Drawing.Size(56, 17)
        Me.LabelGender.TabIndex = 32
        Me.LabelGender.Text = "Gender"
        Me.LabelGender.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 17)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Enter Student Id "
        '
        'AddStud
        '
        Me.AddStud.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStud.Location = New System.Drawing.Point(416, 190)
        Me.AddStud.Name = "AddStud"
        Me.AddStud.Size = New System.Drawing.Size(109, 23)
        Me.AddStud.TabIndex = 30
        Me.AddStud.Text = "Add Student"
        Me.AddStud.UseVisualStyleBackColor = True
        Me.AddStud.Visible = False
        '
        'LabelUserId
        '
        Me.LabelUserId.AutoSize = True
        Me.LabelUserId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUserId.Location = New System.Drawing.Point(3, 196)
        Me.LabelUserId.Name = "LabelUserId"
        Me.LabelUserId.Size = New System.Drawing.Size(53, 17)
        Me.LabelUserId.TabIndex = 29
        Me.LabelUserId.Text = "User Id"
        Me.LabelUserId.Visible = False
        '
        'LabelPhoneNum
        '
        Me.LabelPhoneNum.AutoSize = True
        Me.LabelPhoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPhoneNum.Location = New System.Drawing.Point(3, 169)
        Me.LabelPhoneNum.Name = "LabelPhoneNum"
        Me.LabelPhoneNum.Size = New System.Drawing.Size(105, 17)
        Me.LabelPhoneNum.TabIndex = 28
        Me.LabelPhoneNum.Text = "Phone number "
        Me.LabelPhoneNum.Visible = False
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.Location = New System.Drawing.Point(3, 144)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(42, 17)
        Me.LabelEmail.TabIndex = 27
        Me.LabelEmail.Text = "Email"
        Me.LabelEmail.Visible = False
        '
        'LabelStudLastname
        '
        Me.LabelStudLastname.AutoSize = True
        Me.LabelStudLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStudLastname.Location = New System.Drawing.Point(3, 68)
        Me.LabelStudLastname.Name = "LabelStudLastname"
        Me.LabelStudLastname.Size = New System.Drawing.Size(163, 17)
        Me.LabelStudLastname.TabIndex = 26
        Me.LabelStudLastname.Text = "Emter Student last name"
        Me.LabelStudLastname.Visible = False
        '
        'TextBoxUserId
        '
        Me.TextBoxUserId.Location = New System.Drawing.Point(206, 195)
        Me.TextBoxUserId.Name = "TextBoxUserId"
        Me.TextBoxUserId.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxUserId.TabIndex = 25
        Me.TextBoxUserId.Visible = False
        '
        'TextBoxPhoneNum
        '
        Me.TextBoxPhoneNum.Location = New System.Drawing.Point(206, 169)
        Me.TextBoxPhoneNum.Name = "TextBoxPhoneNum"
        Me.TextBoxPhoneNum.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxPhoneNum.TabIndex = 24
        Me.TextBoxPhoneNum.Visible = False
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(206, 143)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxEmail.TabIndex = 23
        Me.TextBoxEmail.Visible = False
        '
        'TextBoxGender
        '
        Me.TextBoxGender.Location = New System.Drawing.Point(206, 117)
        Me.TextBoxGender.Name = "TextBoxGender"
        Me.TextBoxGender.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxGender.TabIndex = 22
        Me.TextBoxGender.Visible = False
        '
        'BackBtn
        '
        Me.BackBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.Location = New System.Drawing.Point(622, 82)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(83, 23)
        Me.BackBtn.TabIndex = 21
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
        Me.DataGridViewSearch.Location = New System.Drawing.Point(6, 221)
        Me.DataGridViewSearch.Name = "DataGridViewSearch"
        Me.DataGridViewSearch.Size = New System.Drawing.Size(699, 136)
        Me.DataGridViewSearch.TabIndex = 20
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(206, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(157, 20)
        Me.txtSearch.TabIndex = 5
        '
        'cmdReset
        '
        Me.cmdReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.Location = New System.Drawing.Point(622, 41)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(83, 23)
        Me.cmdReset.TabIndex = 4
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Location = New System.Drawing.Point(622, 3)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(83, 23)
        Me.cmdSearch.TabIndex = 3
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(812, 428)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(78, 30)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "Logout"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'studentsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(902, 470)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.lblMessage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "studentsForm"
        Me.Text = "Students"
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

    Friend WithEvents lblMessage As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdReset As Button
    Friend WithEvents cmdSearch As Button
    Friend WithEvents cmdRemove As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents AddStud As Button
    Friend WithEvents LabelUserId As Label
    Friend WithEvents LabelPhoneNum As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelStudLastname As Label
    Friend WithEvents TextBoxUserId As TextBox
    Friend WithEvents TextBoxPhoneNum As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxGender As TextBox
    Friend WithEvents BackBtn As Button
    Friend WithEvents DataGridViewSearch As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents labelStudname As Label
    Friend WithEvents labelClassif As Label
    Friend WithEvents LabelGender As Label
    Friend WithEvents TextBoxStudName As TextBox
    Friend WithEvents TextBoxStudLastName As TextBox
    Friend WithEvents TextBoxClassif As TextBox
    Friend WithEvents ButtonDel As Button
    Friend WithEvents TextBoxDel As TextBox
    Friend WithEvents LabelDel As Label
End Class
