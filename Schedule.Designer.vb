<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Schedule
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
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblShowStuID = New System.Windows.Forms.Label()
        Me.lblShowName = New System.Windows.Forms.Label()
        Me.lblStuID = New System.Windows.Forms.Label()
        Me.lblStuName = New System.Windows.Forms.Label()
        Me.DataGridViewSearch = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(600, 12)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(681, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Logout"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblShowStuID
        '
        Me.lblShowStuID.AutoSize = True
        Me.lblShowStuID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShowStuID.Location = New System.Drawing.Point(108, 102)
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
        Me.lblShowName.Location = New System.Drawing.Point(108, 59)
        Me.lblShowName.Name = "lblShowName"
        Me.lblShowName.Size = New System.Drawing.Size(2, 15)
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
        'DataGridViewSearch
        '
        Me.DataGridViewSearch.AllowUserToAddRows = False
        Me.DataGridViewSearch.AllowUserToDeleteRows = False
        Me.DataGridViewSearch.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridViewSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSearch.Location = New System.Drawing.Point(12, 160)
        Me.DataGridViewSearch.Name = "DataGridViewSearch"
        Me.DataGridViewSearch.Size = New System.Drawing.Size(744, 199)
        Me.DataGridViewSearch.TabIndex = 21
        '
        'Schedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(768, 385)
        Me.Controls.Add(Me.DataGridViewSearch)
        Me.Controls.Add(Me.lblShowStuID)
        Me.Controls.Add(Me.lblShowName)
        Me.Controls.Add(Me.lblStuID)
        Me.Controls.Add(Me.lblStuName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHome)
        Me.Name = "Schedule"
        Me.Text = "Schedule"
        CType(Me.DataGridViewSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblShowStuID As Label
    Friend WithEvents lblShowName As Label
    Friend WithEvents lblStuID As Label
    Friend WithEvents lblStuName As Label
    Friend WithEvents DataGridViewSearch As DataGridView
End Class
