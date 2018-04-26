<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administrator))
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.cmdClasses = New System.Windows.Forms.Button()
        Me.cmdStudents = New System.Windows.Forms.Button()
        Me.cmdInstructors = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(423, 295)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(89, 23)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.Color.White
        Me.MonthCalendar1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.MonthCalendar1.Location = New System.Drawing.Point(285, 33)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 3
        Me.MonthCalendar1.TitleForeColor = System.Drawing.SystemColors.ActiveCaption
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(32, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.BackColor = System.Drawing.SystemColors.Info
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(29, 180)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(104, 15)
        Me.lblMessage.TabIndex = 6
        Me.lblMessage.Text = "Access Options"
        '
        'cmdClasses
        '
        Me.cmdClasses.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdClasses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClasses.Location = New System.Drawing.Point(32, 295)
        Me.cmdClasses.Name = "cmdClasses"
        Me.cmdClasses.Size = New System.Drawing.Size(148, 23)
        Me.cmdClasses.TabIndex = 7
        Me.cmdClasses.Text = "Academic Classes"
        Me.cmdClasses.UseVisualStyleBackColor = False
        '
        'cmdStudents
        '
        Me.cmdStudents.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStudents.Location = New System.Drawing.Point(32, 256)
        Me.cmdStudents.Name = "cmdStudents"
        Me.cmdStudents.Size = New System.Drawing.Size(148, 23)
        Me.cmdStudents.TabIndex = 8
        Me.cmdStudents.Text = "Students"
        Me.cmdStudents.UseVisualStyleBackColor = False
        '
        'cmdInstructors
        '
        Me.cmdInstructors.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdInstructors.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInstructors.Location = New System.Drawing.Point(32, 214)
        Me.cmdInstructors.Name = "cmdInstructors"
        Me.cmdInstructors.Size = New System.Drawing.Size(148, 23)
        Me.cmdInstructors.TabIndex = 9
        Me.cmdInstructors.Text = "Instructors"
        Me.cmdInstructors.UseVisualStyleBackColor = False
        '
        'Administrator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(531, 334)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdInstructors)
        Me.Controls.Add(Me.cmdStudents)
        Me.Controls.Add(Me.cmdClasses)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.cmdExit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "Administrator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator Account"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdExit As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents cmdClasses As Button
    Friend WithEvents cmdStudents As Button
    Friend WithEvents cmdInstructors As Button
End Class
