<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.PassLabel = New System.Windows.Forms.Label()
        Me.PassTextBox = New System.Windows.Forms.TextBox()
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginButton
        '
        Me.LoginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.Location = New System.Drawing.Point(237, 206)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(87, 37)
        Me.LoginButton.TabIndex = 0
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(392, 206)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(87, 37)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'UserLabel
        '
        Me.UserLabel.AutoSize = True
        Me.UserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLabel.Location = New System.Drawing.Point(192, 33)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(89, 20)
        Me.UserLabel.TabIndex = 2
        Me.UserLabel.Text = "User Name"
        '
        'PassLabel
        '
        Me.PassLabel.AutoSize = True
        Me.PassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassLabel.Location = New System.Drawing.Point(192, 104)
        Me.PassLabel.Name = "PassLabel"
        Me.PassLabel.Size = New System.Drawing.Size(78, 20)
        Me.PassLabel.TabIndex = 3
        Me.PassLabel.Text = "Password"
        '
        'PassTextBox
        '
        Me.PassTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassTextBox.Location = New System.Drawing.Point(295, 104)
        Me.PassTextBox.Name = "PassTextBox"
        Me.PassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassTextBox.Size = New System.Drawing.Size(184, 26)
        Me.PassTextBox.TabIndex = 4
        '
        'UserTextBox
        '
        Me.UserTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserTextBox.Location = New System.Drawing.Point(295, 33)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.Size = New System.Drawing.Size(184, 26)
        Me.UserTextBox.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(174, 171)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 287)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.UserTextBox)
        Me.Controls.Add(Me.PassTextBox)
        Me.Controls.Add(Me.PassLabel)
        Me.Controls.Add(Me.UserLabel)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Name = "LoginForm"
        Me.Text = "Login Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents UserLabel As Label
    Friend WithEvents PassLabel As Label
    Friend WithEvents PassTextBox As TextBox
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
