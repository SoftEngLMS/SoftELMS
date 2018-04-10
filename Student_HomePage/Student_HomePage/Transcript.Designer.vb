<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transcript
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
        Me.lblStuName = New System.Windows.Forms.Label()
        Me.lblStuID = New System.Windows.Forms.Label()
        Me.lblStuEmail = New System.Windows.Forms.Label()
        Me.lblStuClass = New System.Windows.Forms.Label()
        Me.lblOverGPA = New System.Windows.Forms.Label()
        Me.listBClassGrade = New System.Windows.Forms.ListBox()
        Me.lblShowName = New System.Windows.Forms.Label()
        Me.lblShowStuID = New System.Windows.Forms.Label()
        Me.lblShowStuEmail = New System.Windows.Forms.Label()
        Me.lbStuClassification = New System.Windows.Forms.Label()
        Me.lblStuGPA = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(255, 12)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(343, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Logout"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblStuName
        '
        Me.lblStuName.AutoSize = True
        Me.lblStuName.Location = New System.Drawing.Point(25, 60)
        Me.lblStuName.Name = "lblStuName"
        Me.lblStuName.Size = New System.Drawing.Size(78, 13)
        Me.lblStuName.TabIndex = 2
        Me.lblStuName.Text = "Student Name:"
        '
        'lblStuID
        '
        Me.lblStuID.AutoSize = True
        Me.lblStuID.Location = New System.Drawing.Point(25, 90)
        Me.lblStuID.Name = "lblStuID"
        Me.lblStuID.Size = New System.Drawing.Size(61, 13)
        Me.lblStuID.TabIndex = 3
        Me.lblStuID.Text = "Student ID:"
        '
        'lblStuEmail
        '
        Me.lblStuEmail.AutoSize = True
        Me.lblStuEmail.Location = New System.Drawing.Point(25, 119)
        Me.lblStuEmail.Name = "lblStuEmail"
        Me.lblStuEmail.Size = New System.Drawing.Size(75, 13)
        Me.lblStuEmail.TabIndex = 4
        Me.lblStuEmail.Text = "Student Email:"
        '
        'lblStuClass
        '
        Me.lblStuClass.AutoSize = True
        Me.lblStuClass.Location = New System.Drawing.Point(25, 151)
        Me.lblStuClass.Name = "lblStuClass"
        Me.lblStuClass.Size = New System.Drawing.Size(74, 13)
        Me.lblStuClass.TabIndex = 5
        Me.lblStuClass.Text = "Classification: "
        '
        'lblOverGPA
        '
        Me.lblOverGPA.AutoSize = True
        Me.lblOverGPA.Location = New System.Drawing.Point(25, 184)
        Me.lblOverGPA.Name = "lblOverGPA"
        Me.lblOverGPA.Size = New System.Drawing.Size(68, 13)
        Me.lblOverGPA.TabIndex = 6
        Me.lblOverGPA.Text = "Overall GPA:"
        '
        'listBClassGrade
        '
        Me.listBClassGrade.FormattingEnabled = True
        Me.listBClassGrade.Location = New System.Drawing.Point(28, 223)
        Me.listBClassGrade.Name = "listBClassGrade"
        Me.listBClassGrade.Size = New System.Drawing.Size(390, 186)
        Me.listBClassGrade.TabIndex = 7
        '
        'lblShowName
        '
        Me.lblShowName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShowName.Location = New System.Drawing.Point(129, 60)
        Me.lblShowName.Name = "lblShowName"
        Me.lblShowName.Size = New System.Drawing.Size(100, 23)
        Me.lblShowName.TabIndex = 8
        Me.lblShowName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblShowName.UseMnemonic = False
        '
        'lblShowStuID
        '
        Me.lblShowStuID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShowStuID.Location = New System.Drawing.Point(129, 90)
        Me.lblShowStuID.Name = "lblShowStuID"
        Me.lblShowStuID.Size = New System.Drawing.Size(100, 23)
        Me.lblShowStuID.TabIndex = 9
        Me.lblShowStuID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblShowStuID.UseMnemonic = False
        '
        'lblShowStuEmail
        '
        Me.lblShowStuEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShowStuEmail.Location = New System.Drawing.Point(129, 119)
        Me.lblShowStuEmail.Name = "lblShowStuEmail"
        Me.lblShowStuEmail.Size = New System.Drawing.Size(100, 23)
        Me.lblShowStuEmail.TabIndex = 10
        Me.lblShowStuEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblShowStuEmail.UseMnemonic = False
        '
        'lbStuClassification
        '
        Me.lbStuClassification.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbStuClassification.Location = New System.Drawing.Point(129, 151)
        Me.lbStuClassification.Name = "lbStuClassification"
        Me.lbStuClassification.Size = New System.Drawing.Size(100, 23)
        Me.lbStuClassification.TabIndex = 11
        Me.lbStuClassification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbStuClassification.UseMnemonic = False
        '
        'lblStuGPA
        '
        Me.lblStuGPA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStuGPA.Location = New System.Drawing.Point(129, 179)
        Me.lblStuGPA.Name = "lblStuGPA"
        Me.lblStuGPA.Size = New System.Drawing.Size(100, 23)
        Me.lblStuGPA.TabIndex = 12
        Me.lblStuGPA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblStuGPA.UseMnemonic = False
        '
        'Transcript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 423)
        Me.Controls.Add(Me.lblStuGPA)
        Me.Controls.Add(Me.lbStuClassification)
        Me.Controls.Add(Me.lblShowStuEmail)
        Me.Controls.Add(Me.lblShowStuID)
        Me.Controls.Add(Me.lblShowName)
        Me.Controls.Add(Me.listBClassGrade)
        Me.Controls.Add(Me.lblOverGPA)
        Me.Controls.Add(Me.lblStuClass)
        Me.Controls.Add(Me.lblStuEmail)
        Me.Controls.Add(Me.lblStuID)
        Me.Controls.Add(Me.lblStuName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHome)
        Me.Name = "Transcript"
        Me.Text = "Transcript"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblStuName As Label
    Friend WithEvents lblStuID As Label
    Friend WithEvents lblStuEmail As Label
    Friend WithEvents lblStuClass As Label
    Friend WithEvents lblOverGPA As Label
    Friend WithEvents listBClassGrade As ListBox
    Friend WithEvents lblShowName As Label
    Friend WithEvents lblShowStuID As Label
    Friend WithEvents lblShowStuEmail As Label
    Friend WithEvents lbStuClassification As Label
    Friend WithEvents lblStuGPA As Label
End Class
