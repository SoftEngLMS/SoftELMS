<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class instructorsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(instructorsForm))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ButtonDel = New System.Windows.Forms.Button()
        Me.TextBoxDel = New System.Windows.Forms.TextBox()
        Me.LabelDel = New System.Windows.Forms.Label()
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.AddProf = New System.Windows.Forms.Button()
        Me.LabelUserId = New System.Windows.Forms.Label()
        Me.LabelPhoneNum = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelProfLastname = New System.Windows.Forms.Label()
        Me.LabelProfname = New System.Windows.Forms.Label()
        Me.TextBoxUserId = New System.Windows.Forms.TextBox()
        Me.TextBoxPhoneNum = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxProfLastname = New System.Windows.Forms.TextBox()
        Me.TextBoxProfname = New System.Windows.Forms.TextBox()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.DataGridViewSearch = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridViewSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackgroundImage = CType(resources.GetObject("SplitContainer1.BackgroundImage"), System.Drawing.Image)
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 12)
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.AddProf)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelUserId)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelPhoneNum)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelEmail)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelProfLastname)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelProfname)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxUserId)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxPhoneNum)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxEmail)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxProfLastname)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxProfname)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BackBtn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridViewSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdReset)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdSearch)
        Me.SplitContainer1.Size = New System.Drawing.Size(876, 286)
        Me.SplitContainer1.SplitterDistance = 159
        Me.SplitContainer1.TabIndex = 2
        '
        'ButtonDel
        '
        Me.ButtonDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDel.Location = New System.Drawing.Point(28, 166)
        Me.ButtonDel.Name = "ButtonDel"
        Me.ButtonDel.Size = New System.Drawing.Size(90, 23)
        Me.ButtonDel.TabIndex = 7
        Me.ButtonDel.Text = "Delete Prof"
        Me.ButtonDel.UseVisualStyleBackColor = True
        Me.ButtonDel.Visible = False
        '
        'TextBoxDel
        '
        Me.TextBoxDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDel.Location = New System.Drawing.Point(14, 123)
        Me.TextBoxDel.Name = "TextBoxDel"
        Me.TextBoxDel.Size = New System.Drawing.Size(131, 21)
        Me.TextBoxDel.TabIndex = 6
        Me.TextBoxDel.Visible = False
        '
        'LabelDel
        '
        Me.LabelDel.AutoSize = True
        Me.LabelDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDel.Location = New System.Drawing.Point(11, 90)
        Me.LabelDel.Name = "LabelDel"
        Me.LabelDel.Size = New System.Drawing.Size(134, 17)
        Me.LabelDel.TabIndex = 5
        Me.LabelDel.Text = "Enter Id to delete"
        Me.LabelDel.Visible = False
        '
        'cmdRemove
        '
        Me.cmdRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemove.Location = New System.Drawing.Point(28, 33)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(90, 24)
        Me.cmdRemove.TabIndex = 4
        Me.cmdRemove.Text = "Remove"
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Location = New System.Drawing.Point(28, 3)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(90, 24)
        Me.cmdAdd.TabIndex = 3
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'AddProf
        '
        Me.AddProf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddProf.Location = New System.Drawing.Point(405, 135)
        Me.AddProf.Name = "AddProf"
        Me.AddProf.Size = New System.Drawing.Size(109, 23)
        Me.AddProf.TabIndex = 19
        Me.AddProf.Text = "Add Professor"
        Me.AddProf.UseVisualStyleBackColor = True
        Me.AddProf.Visible = False
        '
        'LabelUserId
        '
        Me.LabelUserId.AutoSize = True
        Me.LabelUserId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUserId.Location = New System.Drawing.Point(11, 139)
        Me.LabelUserId.Name = "LabelUserId"
        Me.LabelUserId.Size = New System.Drawing.Size(53, 17)
        Me.LabelUserId.TabIndex = 18
        Me.LabelUserId.Text = "User Id"
        Me.LabelUserId.Visible = False
        '
        'LabelPhoneNum
        '
        Me.LabelPhoneNum.AutoSize = True
        Me.LabelPhoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPhoneNum.Location = New System.Drawing.Point(11, 113)
        Me.LabelPhoneNum.Name = "LabelPhoneNum"
        Me.LabelPhoneNum.Size = New System.Drawing.Size(105, 17)
        Me.LabelPhoneNum.TabIndex = 17
        Me.LabelPhoneNum.Text = "Phone number "
        Me.LabelPhoneNum.Visible = False
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.Location = New System.Drawing.Point(11, 87)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(42, 17)
        Me.LabelEmail.TabIndex = 16
        Me.LabelEmail.Text = "Email"
        Me.LabelEmail.Visible = False
        '
        'LabelProfLastname
        '
        Me.LabelProfLastname.AutoSize = True
        Me.LabelProfLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProfLastname.Location = New System.Drawing.Point(11, 61)
        Me.LabelProfLastname.Name = "LabelProfLastname"
        Me.LabelProfLastname.Size = New System.Drawing.Size(175, 17)
        Me.LabelProfLastname.TabIndex = 15
        Me.LabelProfLastname.Text = "Emter Professor last name"
        Me.LabelProfLastname.Visible = False
        '
        'LabelProfname
        '
        Me.LabelProfname.AutoSize = True
        Me.LabelProfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProfname.Location = New System.Drawing.Point(11, 35)
        Me.LabelProfname.Name = "LabelProfname"
        Me.LabelProfname.Size = New System.Drawing.Size(146, 17)
        Me.LabelProfname.TabIndex = 14
        Me.LabelProfname.Text = "Enter Professor name"
        Me.LabelProfname.Visible = False
        '
        'TextBoxUserId
        '
        Me.TextBoxUserId.Location = New System.Drawing.Point(225, 139)
        Me.TextBoxUserId.Name = "TextBoxUserId"
        Me.TextBoxUserId.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxUserId.TabIndex = 13
        Me.TextBoxUserId.Visible = False
        '
        'TextBoxPhoneNum
        '
        Me.TextBoxPhoneNum.Location = New System.Drawing.Point(225, 113)
        Me.TextBoxPhoneNum.Name = "TextBoxPhoneNum"
        Me.TextBoxPhoneNum.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxPhoneNum.TabIndex = 12
        Me.TextBoxPhoneNum.Visible = False
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(225, 87)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxEmail.TabIndex = 11
        Me.TextBoxEmail.Visible = False
        '
        'TextBoxProfLastname
        '
        Me.TextBoxProfLastname.Location = New System.Drawing.Point(225, 61)
        Me.TextBoxProfLastname.Name = "TextBoxProfLastname"
        Me.TextBoxProfLastname.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxProfLastname.TabIndex = 10
        Me.TextBoxProfLastname.Visible = False
        '
        'TextBoxProfname
        '
        Me.TextBoxProfname.Location = New System.Drawing.Point(225, 35)
        Me.TextBoxProfname.Name = "TextBoxProfname"
        Me.TextBoxProfname.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxProfname.TabIndex = 9
        Me.TextBoxProfname.Visible = False
        '
        'BackBtn
        '
        Me.BackBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.Location = New System.Drawing.Point(623, 71)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(83, 23)
        Me.BackBtn.TabIndex = 8
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
        Me.DataGridViewSearch.Location = New System.Drawing.Point(7, 166)
        Me.DataGridViewSearch.Name = "DataGridViewSearch"
        Me.DataGridViewSearch.Size = New System.Drawing.Size(612, 113)
        Me.DataGridViewSearch.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Search Professor by Id"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(225, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(157, 23)
        Me.txtSearch.TabIndex = 5
        '
        'cmdReset
        '
        Me.cmdReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.Location = New System.Drawing.Point(623, 42)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(83, 23)
        Me.cmdReset.TabIndex = 4
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Location = New System.Drawing.Point(623, 12)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(83, 23)
        Me.cmdSearch.TabIndex = 3
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(813, 304)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Text = "Logout "
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(24, 307)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(71, 20)
        Me.lblMessage.TabIndex = 6
        Me.lblMessage.Text = "Options"
        '
        'instructorsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(900, 336)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "instructorsForm"
        Me.Text = "Instructors"
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
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents cmdRemove As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmdReset As Button
    Friend WithEvents cmdSearch As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewSearch As DataGridView
    Friend WithEvents lblMessage As Label
    Friend WithEvents BackBtn As Button
    Friend WithEvents TextBoxUserId As TextBox
    Friend WithEvents TextBoxPhoneNum As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxProfLastname As TextBox
    Friend WithEvents TextBoxProfname As TextBox
    Friend WithEvents LabelUserId As Label
    Friend WithEvents LabelPhoneNum As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelProfLastname As Label
    Friend WithEvents LabelProfname As Label
    Friend WithEvents AddProf As Button
    Friend WithEvents TextBoxDel As TextBox
    Friend WithEvents LabelDel As Label
    Friend WithEvents ButtonDel As Button
End Class
