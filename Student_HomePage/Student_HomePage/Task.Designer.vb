<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Task
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
        Me.lblTaskName = New System.Windows.Forms.Label()
        Me.lblTaskDiscript = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.txtTaskInput = New System.Windows.Forms.TextBox()
        Me.btnTSubmit = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTaskName
        '
        Me.lblTaskName.AutoSize = True
        Me.lblTaskName.Location = New System.Drawing.Point(12, 27)
        Me.lblTaskName.Name = "lblTaskName"
        Me.lblTaskName.Size = New System.Drawing.Size(62, 13)
        Me.lblTaskName.TabIndex = 0
        Me.lblTaskName.Text = "Task Name"
        '
        'lblTaskDiscript
        '
        Me.lblTaskDiscript.AutoSize = True
        Me.lblTaskDiscript.Location = New System.Drawing.Point(12, 61)
        Me.lblTaskDiscript.Name = "lblTaskDiscript"
        Me.lblTaskDiscript.Size = New System.Drawing.Size(83, 13)
        Me.lblTaskDiscript.TabIndex = 1
        Me.lblTaskDiscript.Text = "Task Discription"
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(12, 101)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(36, 13)
        Me.lblGrade.TabIndex = 2
        Me.lblGrade.Text = "Grade"
        '
        'txtTaskInput
        '
        Me.txtTaskInput.Location = New System.Drawing.Point(15, 140)
        Me.txtTaskInput.Multiline = True
        Me.txtTaskInput.Name = "txtTaskInput"
        Me.txtTaskInput.Size = New System.Drawing.Size(650, 100)
        Me.txtTaskInput.TabIndex = 3
        Me.txtTaskInput.Text = "Input"
        '
        'btnTSubmit
        '
        Me.btnTSubmit.Location = New System.Drawing.Point(587, 246)
        Me.btnTSubmit.Name = "btnTSubmit"
        Me.btnTSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnTSubmit.TabIndex = 4
        Me.btnTSubmit.Text = "Submit"
        Me.btnTSubmit.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(587, 17)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 6
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Task
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 281)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnTSubmit)
        Me.Controls.Add(Me.txtTaskInput)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.lblTaskDiscript)
        Me.Controls.Add(Me.lblTaskName)
        Me.Name = "Task"
        Me.Text = "Task"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTaskName As Label
    Friend WithEvents lblTaskDiscript As Label
    Friend WithEvents lblGrade As Label
    Friend WithEvents txtTaskInput As TextBox
    Friend WithEvents btnTSubmit As Button
    Friend WithEvents btnHome As Button
End Class
