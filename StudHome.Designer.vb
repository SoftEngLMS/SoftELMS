<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudHome))
        Me.StudInfo = New System.Windows.Forms.Button()
        Me.Schedule = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBoxUHD = New System.Windows.Forms.PictureBox()
        Me.ButtonExit = New System.Windows.Forms.Button()
        CType(Me.PictureBoxUHD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudInfo
        '
        Me.StudInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudInfo.Location = New System.Drawing.Point(191, 208)
        Me.StudInfo.Name = "StudInfo"
        Me.StudInfo.Size = New System.Drawing.Size(156, 23)
        Me.StudInfo.TabIndex = 0
        Me.StudInfo.Text = "Student Information"
        Me.StudInfo.UseVisualStyleBackColor = True
        '
        'Schedule
        '
        Me.Schedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Schedule.Location = New System.Drawing.Point(225, 237)
        Me.Schedule.Name = "Schedule"
        Me.Schedule.Size = New System.Drawing.Size(75, 23)
        Me.Schedule.TabIndex = 1
        Me.Schedule.Text = "Schedule"
        Me.Schedule.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(208, 266)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Registration"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBoxUHD
        '
        Me.PictureBoxUHD.Image = CType(resources.GetObject("PictureBoxUHD.Image"), System.Drawing.Image)
        Me.PictureBoxUHD.InitialImage = CType(resources.GetObject("PictureBoxUHD.InitialImage"), System.Drawing.Image)
        Me.PictureBoxUHD.Location = New System.Drawing.Point(45, 12)
        Me.PictureBoxUHD.Name = "PictureBoxUHD"
        Me.PictureBoxUHD.Size = New System.Drawing.Size(474, 189)
        Me.PictureBoxUHD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBoxUHD.TabIndex = 3
        Me.PictureBoxUHD.TabStop = False
        '
        'ButtonExit
        '
        Me.ButtonExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.Location = New System.Drawing.Point(468, 317)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExit.TabIndex = 4
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'StudHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(555, 352)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.PictureBoxUHD)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Schedule)
        Me.Controls.Add(Me.StudInfo)
        Me.Name = "StudHome"
        Me.Text = "Student "
        CType(Me.PictureBoxUHD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudInfo As Button
    Friend WithEvents Schedule As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBoxUHD As PictureBox
    Friend WithEvents ButtonExit As Button
End Class
