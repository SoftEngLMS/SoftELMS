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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblCourseID = New System.Windows.Forms.Label()
        Me.txtCourseID = New System.Windows.Forms.TextBox()
        Me.btnAddClass = New System.Windows.Forms.Button()
        Me.btnRemoveClass = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewSearch = New System.Windows.Forms.DataGridView()
        Me.DataGridViewAD = New System.Windows.Forms.DataGridView()
        Me.BtnShowClass = New System.Windows.Forms.Button()
        CType(Me.DataGridViewSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewAD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(739, 11)
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
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(642, 12)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(91, 36)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
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
        'btnRemoveClass
        '
        Me.btnRemoveClass.Location = New System.Drawing.Point(329, 241)
        Me.btnRemoveClass.Name = "btnRemoveClass"
        Me.btnRemoveClass.Size = New System.Drawing.Size(86, 23)
        Me.btnRemoveClass.TabIndex = 16
        Me.btnRemoveClass.Text = "Remove Class"
        Me.btnRemoveClass.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Current Schedule"
        '
        'DataGridViewSearch
        '
        Me.DataGridViewSearch.AllowUserToAddRows = False
        Me.DataGridViewSearch.AllowUserToDeleteRows = False
        Me.DataGridViewSearch.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridViewSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSearch.Location = New System.Drawing.Point(12, 83)
        Me.DataGridViewSearch.Name = "DataGridViewSearch"
        Me.DataGridViewSearch.Size = New System.Drawing.Size(869, 136)
        Me.DataGridViewSearch.TabIndex = 21
        '
        'DataGridViewAD
        '
        Me.DataGridViewAD.AllowUserToAddRows = False
        Me.DataGridViewAD.AllowUserToDeleteRows = False
        Me.DataGridViewAD.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridViewAD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAD.Location = New System.Drawing.Point(12, 269)
        Me.DataGridViewAD.Name = "DataGridViewAD"
        Me.DataGridViewAD.Size = New System.Drawing.Size(869, 136)
        Me.DataGridViewAD.TabIndex = 22
        '
        'BtnShowClass
        '
        Me.BtnShowClass.Location = New System.Drawing.Point(434, 240)
        Me.BtnShowClass.Name = "BtnShowClass"
        Me.BtnShowClass.Size = New System.Drawing.Size(86, 23)
        Me.BtnShowClass.TabIndex = 23
        Me.BtnShowClass.Text = "Show classes"
        Me.BtnShowClass.UseVisualStyleBackColor = True
        '
        'Regristration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(927, 447)
        Me.Controls.Add(Me.BtnShowClass)
        Me.Controls.Add(Me.DataGridViewAD)
        Me.Controls.Add(Me.DataGridViewSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRemoveClass)
        Me.Controls.Add(Me.btnAddClass)
        Me.Controls.Add(Me.txtCourseID)
        Me.Controls.Add(Me.lblCourseID)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHome)
        Me.Name = "Regristration"
        Me.Text = "Regristration"
        CType(Me.DataGridViewSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewAD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblCourseID As Label
    Friend WithEvents txtCourseID As TextBox
    Friend WithEvents btnAddClass As Button
    Friend WithEvents btnRemoveClass As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewSearch As DataGridView
    Friend WithEvents DataGridViewAD As DataGridView
    Friend WithEvents BtnShowClass As Button
End Class
