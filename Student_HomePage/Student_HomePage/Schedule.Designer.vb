<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Schedule
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
        Me.lblShowStuID = New System.Windows.Forms.Label()
        Me.lblShowName = New System.Windows.Forms.Label()
        Me.lblStuID = New System.Windows.Forms.Label()
        Me.lblStuName = New System.Windows.Forms.Label()
        Me.listbSchedule = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(204, 12)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(285, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Logout"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblShowStuID
        '
        Me.lblShowStuID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShowStuID.Location = New System.Drawing.Point(108, 102)
        Me.lblShowStuID.Name = "lblShowStuID"
        Me.lblShowStuID.Size = New System.Drawing.Size(100, 23)
        Me.lblShowStuID.TabIndex = 17
        Me.lblShowStuID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblShowStuID.UseMnemonic = False
        '
        'lblShowName
        '
        Me.lblShowName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShowName.Location = New System.Drawing.Point(108, 59)
        Me.lblShowName.Name = "lblShowName"
        Me.lblShowName.Size = New System.Drawing.Size(100, 23)
        Me.lblShowName.TabIndex = 16
        Me.lblShowName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblShowName.UseMnemonic = False
        '
        'lblStuID
        '
        Me.lblStuID.AutoSize = True
        Me.lblStuID.Location = New System.Drawing.Point(12, 102)
        Me.lblStuID.Name = "lblStuID"
        Me.lblStuID.Size = New System.Drawing.Size(61, 13)
        Me.lblStuID.TabIndex = 13
        Me.lblStuID.Text = "Student ID:"
        '
        'lblStuName
        '
        Me.lblStuName.AutoSize = True
        Me.lblStuName.Location = New System.Drawing.Point(12, 64)
        Me.lblStuName.Name = "lblStuName"
        Me.lblStuName.Size = New System.Drawing.Size(78, 13)
        Me.lblStuName.TabIndex = 12
        Me.lblStuName.Text = "Student Name:"
        '
        'listbSchedule
        '
        Me.listbSchedule.FormattingEnabled = True
        Me.listbSchedule.Location = New System.Drawing.Point(12, 139)
        Me.listbSchedule.Name = "listbSchedule"
        Me.listbSchedule.Size = New System.Drawing.Size(327, 277)
        Me.listbSchedule.TabIndex = 18
        '
        'Schedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 427)
        Me.Controls.Add(Me.listbSchedule)
        Me.Controls.Add(Me.lblShowStuID)
        Me.Controls.Add(Me.lblShowName)
        Me.Controls.Add(Me.lblStuID)
        Me.Controls.Add(Me.lblStuName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHome)
        Me.Name = "Schedule"
        Me.Text = "Schedule"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblShowStuID As Label
    Friend WithEvents lblShowName As Label
    Friend WithEvents lblStuID As Label
    Friend WithEvents lblStuName As Label
    Friend WithEvents listbSchedule As ListBox
End Class
