<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnStudentInfo = New System.Windows.Forms.Button()
        Me.btnViewClasses = New System.Windows.Forms.Button()
        Me.btnAddClasses = New System.Windows.Forms.Button()
        Me.btnTranscript = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClass = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnStudentInfo)
        Me.GroupBox1.Controls.Add(Me.btnViewClasses)
        Me.GroupBox1.Controls.Add(Me.btnAddClasses)
        Me.GroupBox1.Controls.Add(Me.btnTranscript)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(199, 229)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tasks"
        '
        'btnStudentInfo
        '
        Me.btnStudentInfo.Location = New System.Drawing.Point(6, 184)
        Me.btnStudentInfo.Name = "btnStudentInfo"
        Me.btnStudentInfo.Size = New System.Drawing.Size(188, 39)
        Me.btnStudentInfo.TabIndex = 3
        Me.btnStudentInfo.Text = "Student Information"
        Me.btnStudentInfo.UseVisualStyleBackColor = True
        '
        'btnViewClasses
        '
        Me.btnViewClasses.Location = New System.Drawing.Point(5, 63)
        Me.btnViewClasses.Name = "btnViewClasses"
        Me.btnViewClasses.Size = New System.Drawing.Size(188, 43)
        Me.btnViewClasses.TabIndex = 1
        Me.btnViewClasses.Text = "View Classes"
        Me.btnViewClasses.UseVisualStyleBackColor = True
        '
        'btnAddClasses
        '
        Me.btnAddClasses.Location = New System.Drawing.Point(6, 19)
        Me.btnAddClasses.Name = "btnAddClasses"
        Me.btnAddClasses.Size = New System.Drawing.Size(188, 38)
        Me.btnAddClasses.TabIndex = 0
        Me.btnAddClasses.Text = "Add/Drop Classes"
        Me.btnAddClasses.UseVisualStyleBackColor = True
        '
        'btnTranscript
        '
        Me.btnTranscript.Location = New System.Drawing.Point(6, 138)
        Me.btnTranscript.Name = "btnTranscript"
        Me.btnTranscript.Size = New System.Drawing.Size(188, 40)
        Me.btnTranscript.TabIndex = 2
        Me.btnTranscript.Text = "View Transcript"
        Me.btnTranscript.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnClass)
        Me.GroupBox2.Location = New System.Drawing.Point(271, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(472, 229)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Courses"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(659, 259)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 48)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Logout"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClass
        '
        Me.btnClass.Location = New System.Drawing.Point(6, 19)
        Me.btnClass.Name = "btnClass"
        Me.btnClass.Size = New System.Drawing.Size(75, 23)
        Me.btnClass.TabIndex = 0
        Me.btnClass.Text = "Class 1"
        Me.btnClass.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 319)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Student Home"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnTranscript As Button
    Friend WithEvents btnStudentInfo As Button
    Friend WithEvents btnViewClasses As Button
    Friend WithEvents btnAddClasses As Button
    Friend WithEvents btnExit As Button

    Private Sub btnAddClasses_Click(sender As Object, e As EventArgs) Handles btnAddClasses.Click
        Dim FrmRegis As New Regristration 'this creates a from that connects to the form registration
        Me.Hide() 'Hide the current form
        FrmRegis.Show() 'show the regirstraion form
    End Sub

    Private Sub btnViewClasses_Click(sender As Object, e As EventArgs) Handles btnViewClasses.Click
        Dim FrmSched As New Schedule 'this creates a a from that connects to the form schedule
        Me.Hide() 'hides the current form
        FrmSched.Show() 'show the schedule form
    End Sub

    Private Sub btnTranscript_Click(sender As Object, e As EventArgs) Handles btnTranscript.Click
        Dim FrmTrans As New Transcript 'this creates a form that connect to the form transcript
        Me.Hide() 'hide the current form
        FrmTrans.Show() 'display the transcript form
    End Sub

    Private Sub btnStudentInfo_Click(sender As Object, e As EventArgs) Handles btnStudentInfo.Click
        Dim FrmStuInfo As New StuInfo 'this creates a form that connect to the form student info
        Me.Hide() 'Hide the current form
        FrmStuInfo.Show() 'display the student form
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'close the program
    End Sub

    Friend WithEvents btnClass As Button

    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnClass.Click
        Me.Hide() 'Hide this form
        Form2.Show() 'Display the Classroom
    End Sub
End Class
