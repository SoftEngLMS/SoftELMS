<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StuInfo
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
        Me.lbStuClassification = New System.Windows.Forms.Label()
        Me.lblShowStuEmail = New System.Windows.Forms.Label()
        Me.lblShowStuID = New System.Windows.Forms.Label()
        Me.lblShowName = New System.Windows.Forms.Label()
        Me.lblStuClass = New System.Windows.Forms.Label()
        Me.lblStuEmail = New System.Windows.Forms.Label()
        Me.lblStuID = New System.Windows.Forms.Label()
        Me.lblStuName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(278, 12)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(278, 41)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Logout"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lbStuClassification
        '
        Me.lbStuClassification.AutoSize = True
        Me.lbStuClassification.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbStuClassification.Location = New System.Drawing.Point(109, 169)
        Me.lbStuClassification.Name = "lbStuClassification"
        Me.lbStuClassification.Size = New System.Drawing.Size(2, 15)
        Me.lbStuClassification.TabIndex = 19
        Me.lbStuClassification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbStuClassification.UseMnemonic = False
        '
        'lblShowStuEmail
        '
        Me.lblShowStuEmail.AutoSize = True
        Me.lblShowStuEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShowStuEmail.Location = New System.Drawing.Point(109, 132)
        Me.lblShowStuEmail.Name = "lblShowStuEmail"
        Me.lblShowStuEmail.Size = New System.Drawing.Size(2, 15)
        Me.lblShowStuEmail.TabIndex = 18
        Me.lblShowStuEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblShowStuEmail.UseMnemonic = False
        '
        'lblShowStuID
        '
        Me.lblShowStuID.AutoSize = True
        Me.lblShowStuID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShowStuID.Location = New System.Drawing.Point(109, 98)
        Me.lblShowStuID.Name = "lblShowStuID"
        Me.lblShowStuID.Size = New System.Drawing.Size(2, 15)
        Me.lblShowStuID.TabIndex = 17
        Me.lblShowStuID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblShowStuID.UseMnemonic = False
        '
        'lblShowName
        '
        Me.lblShowName.AutoSize = True
        Me.lblShowName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShowName.Location = New System.Drawing.Point(109, 61)
        Me.lblShowName.Name = "lblShowName"
        Me.lblShowName.Size = New System.Drawing.Size(2, 15)
        Me.lblShowName.TabIndex = 16
        Me.lblShowName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblShowName.UseMnemonic = False
        '
        'lblStuClass
        '
        Me.lblStuClass.AutoSize = True
        Me.lblStuClass.Location = New System.Drawing.Point(12, 169)
        Me.lblStuClass.Name = "lblStuClass"
        Me.lblStuClass.Size = New System.Drawing.Size(74, 13)
        Me.lblStuClass.TabIndex = 15
        Me.lblStuClass.Text = "Classification: "
        '
        'lblStuEmail
        '
        Me.lblStuEmail.AutoSize = True
        Me.lblStuEmail.Location = New System.Drawing.Point(15, 132)
        Me.lblStuEmail.Name = "lblStuEmail"
        Me.lblStuEmail.Size = New System.Drawing.Size(75, 13)
        Me.lblStuEmail.TabIndex = 14
        Me.lblStuEmail.Text = "Student Email:"
        '
        'lblStuID
        '
        Me.lblStuID.AutoSize = True
        Me.lblStuID.Location = New System.Drawing.Point(12, 98)
        Me.lblStuID.Name = "lblStuID"
        Me.lblStuID.Size = New System.Drawing.Size(61, 13)
        Me.lblStuID.TabIndex = 13
        Me.lblStuID.Text = "Student ID:"
        '
        'lblStuName
        '
        Me.lblStuName.AutoSize = True
        Me.lblStuName.Location = New System.Drawing.Point(12, 61)
        Me.lblStuName.Name = "lblStuName"
        Me.lblStuName.Size = New System.Drawing.Size(78, 13)
        Me.lblStuName.TabIndex = 12
        Me.lblStuName.Text = "Student Name:"
        '
        'StuInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(364, 239)
        Me.Controls.Add(Me.lbStuClassification)
        Me.Controls.Add(Me.lblShowStuEmail)
        Me.Controls.Add(Me.lblShowStuID)
        Me.Controls.Add(Me.lblShowName)
        Me.Controls.Add(Me.lblStuClass)
        Me.Controls.Add(Me.lblStuEmail)
        Me.Controls.Add(Me.lblStuID)
        Me.Controls.Add(Me.lblStuName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHome)
        Me.Name = "StuInfo"
        Me.Text = "StuInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbStuClassification As Label
    Friend WithEvents lblShowStuEmail As Label
    Friend WithEvents lblShowStuID As Label
    Friend WithEvents lblShowName As Label
    Friend WithEvents lblStuClass As Label
    Friend WithEvents lblStuEmail As Label
    Friend WithEvents lblStuID As Label
    Friend WithEvents lblStuName As Label
End Class
