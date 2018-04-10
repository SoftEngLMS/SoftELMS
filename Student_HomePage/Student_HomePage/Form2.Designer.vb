<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblClassName = New System.Windows.Forms.Label()
        Me.lblTxtBook = New System.Windows.Forms.Label()
        Me.lblCurrentGrade = New System.Windows.Forms.Label()
        Me.gbTasks = New System.Windows.Forms.GroupBox()
        Me.btnTasks1 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.gbTasks.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblClassName
        '
        Me.lblClassName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassName.Location = New System.Drawing.Point(12, 9)
        Me.lblClassName.Name = "lblClassName"
        Me.lblClassName.Size = New System.Drawing.Size(158, 63)
        Me.lblClassName.TabIndex = 0
        Me.lblClassName.Text = "Class Name"
        '
        'lblTxtBook
        '
        Me.lblTxtBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTxtBook.Location = New System.Drawing.Point(14, 59)
        Me.lblTxtBook.Name = "lblTxtBook"
        Me.lblTxtBook.Size = New System.Drawing.Size(373, 40)
        Me.lblTxtBook.TabIndex = 1
        Me.lblTxtBook.Text = "TextBook"
        '
        'lblCurrentGrade
        '
        Me.lblCurrentGrade.AutoSize = True
        Me.lblCurrentGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentGrade.Location = New System.Drawing.Point(14, 99)
        Me.lblCurrentGrade.Name = "lblCurrentGrade"
        Me.lblCurrentGrade.Size = New System.Drawing.Size(148, 25)
        Me.lblCurrentGrade.TabIndex = 2
        Me.lblCurrentGrade.Text = "Current Grade"
        '
        'gbTasks
        '
        Me.gbTasks.Controls.Add(Me.btnTasks1)
        Me.gbTasks.Location = New System.Drawing.Point(17, 152)
        Me.gbTasks.Name = "gbTasks"
        Me.gbTasks.Size = New System.Drawing.Size(671, 141)
        Me.gbTasks.TabIndex = 3
        Me.gbTasks.TabStop = False
        Me.gbTasks.Text = "Tasks"
        '
        'btnTasks1
        '
        Me.btnTasks1.Location = New System.Drawing.Point(6, 19)
        Me.btnTasks1.Name = "btnTasks1"
        Me.btnTasks1.Size = New System.Drawing.Size(75, 23)
        Me.btnTasks1.TabIndex = 0
        Me.btnTasks1.Text = "Task 1"
        Me.btnTasks1.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(613, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Logout"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(532, 12)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 4
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 321)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.gbTasks)
        Me.Controls.Add(Me.lblCurrentGrade)
        Me.Controls.Add(Me.lblTxtBook)
        Me.Controls.Add(Me.lblClassName)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.gbTasks.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblClassName As Label
    Friend WithEvents lblTxtBook As Label
    Friend WithEvents lblCurrentGrade As Label
    Friend WithEvents gbTasks As GroupBox
    Friend WithEvents btnTasks1 As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnHome As Button
End Class
