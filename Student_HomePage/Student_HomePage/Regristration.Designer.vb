<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Regristration
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
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCourseNum = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.listClasses = New System.Windows.Forms.ListBox()
        Me.btnClassSearch = New System.Windows.Forms.Button()
        Me.cbCSubSearch = New System.Windows.Forms.ComboBox()
        Me.cbSorseID = New System.Windows.Forms.ComboBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.lblCourseID = New System.Windows.Forms.Label()
        Me.txtCourseID = New System.Windows.Forms.TextBox()
        Me.btnAddClass = New System.Windows.Forms.Button()
        Me.btnConfirmClass = New System.Windows.Forms.Button()
        Me.btnRemoveClass = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(715, 12)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(91, 36)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(836, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 36)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Logout"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCourseNum
        '
        Me.lblCourseNum.AutoSize = True
        Me.lblCourseNum.Location = New System.Drawing.Point(253, 44)
        Me.lblCourseNum.Name = "lblCourseNum"
        Me.lblCourseNum.Size = New System.Drawing.Size(86, 13)
        Me.lblCourseNum.TabIndex = 3
        Me.lblCourseNum.Text = "Course Number: "
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(12, 44)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(49, 13)
        Me.lblSubject.TabIndex = 4
        Me.lblSubject.Text = "Subject: "
        '
        'listClasses
        '
        Me.listClasses.FormattingEnabled = True
        Me.listClasses.Location = New System.Drawing.Point(15, 84)
        Me.listClasses.Name = "listClasses"
        Me.listClasses.Size = New System.Drawing.Size(866, 134)
        Me.listClasses.TabIndex = 7
        '
        'btnClassSearch
        '
        Me.btnClassSearch.Location = New System.Drawing.Point(508, 30)
        Me.btnClassSearch.Name = "btnClassSearch"
        Me.btnClassSearch.Size = New System.Drawing.Size(100, 30)
        Me.btnClassSearch.TabIndex = 8
        Me.btnClassSearch.Text = "Search"
        Me.btnClassSearch.UseVisualStyleBackColor = True
        '
        'cbCSubSearch
        '
        Me.cbCSubSearch.FormattingEnabled = True
        Me.cbCSubSearch.Location = New System.Drawing.Point(98, 36)
        Me.cbCSubSearch.Name = "cbCSubSearch"
        Me.cbCSubSearch.Size = New System.Drawing.Size(121, 21)
        Me.cbCSubSearch.TabIndex = 9
        '
        'cbSorseID
        '
        Me.cbSorseID.FormattingEnabled = True
        Me.cbSorseID.Location = New System.Drawing.Point(346, 36)
        Me.cbSorseID.Name = "cbSorseID"
        Me.cbSorseID.Size = New System.Drawing.Size(121, 21)
        Me.cbSorseID.TabIndex = 10
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(15, 286)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(866, 109)
        Me.CheckedListBox1.TabIndex = 11
        '
        'lblCourseID
        '
        Me.lblCourseID.AutoSize = True
        Me.lblCourseID.Location = New System.Drawing.Point(12, 246)
        Me.lblCourseID.Name = "lblCourseID"
        Me.lblCourseID.Size = New System.Drawing.Size(57, 13)
        Me.lblCourseID.TabIndex = 12
        Me.lblCourseID.Text = "Course ID:"
        '
        'txtCourseID
        '
        Me.txtCourseID.Location = New System.Drawing.Point(98, 243)
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.Size = New System.Drawing.Size(100, 20)
        Me.txtCourseID.TabIndex = 13
        '
        'btnAddClass
        '
        Me.btnAddClass.Location = New System.Drawing.Point(232, 241)
        Me.btnAddClass.Name = "btnAddClass"
        Me.btnAddClass.Size = New System.Drawing.Size(78, 23)
        Me.btnAddClass.TabIndex = 14
        Me.btnAddClass.Text = "Add Class"
        Me.btnAddClass.UseVisualStyleBackColor = True
        '
        'btnConfirmClass
        '
        Me.btnConfirmClass.Location = New System.Drawing.Point(806, 406)
        Me.btnConfirmClass.Name = "btnConfirmClass"
        Me.btnConfirmClass.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmClass.TabIndex = 15
        Me.btnConfirmClass.Text = "Confirm Classes"
        Me.btnConfirmClass.UseVisualStyleBackColor = True
        '
        'btnRemoveClass
        '
        Me.btnRemoveClass.Location = New System.Drawing.Point(329, 241)
        Me.btnRemoveClass.Name = "btnRemoveClass"
        Me.btnRemoveClass.Size = New System.Drawing.Size(86, 23)
        Me.btnRemoveClass.TabIndex = 16
        Me.btnRemoveClass.Text = "Remove Class"
        Me.btnRemoveClass.UseVisualStyleBackColor = True
        '
        'Regristration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 441)
        Me.Controls.Add(Me.btnRemoveClass)
        Me.Controls.Add(Me.btnConfirmClass)
        Me.Controls.Add(Me.btnAddClass)
        Me.Controls.Add(Me.txtCourseID)
        Me.Controls.Add(Me.lblCourseID)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.cbSorseID)
        Me.Controls.Add(Me.cbCSubSearch)
        Me.Controls.Add(Me.btnClassSearch)
        Me.Controls.Add(Me.listClasses)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.lblCourseNum)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHome)
        Me.Name = "Regristration"
        Me.Text = "Regristration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCourseNum As Label
    Friend WithEvents lblSubject As Label
    Friend WithEvents listClasses As ListBox
    Friend WithEvents btnClassSearch As Button
    Friend WithEvents cbCSubSearch As ComboBox
    Friend WithEvents cbSorseID As ComboBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents lblCourseID As Label
    Friend WithEvents txtCourseID As TextBox
    Friend WithEvents btnAddClass As Button
    Friend WithEvents btnConfirmClass As Button
    Friend WithEvents btnRemoveClass As Button
End Class
