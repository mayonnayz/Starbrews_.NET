<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        chkShowPass = New CheckBox()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Sitka Subheading", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(55, 202)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(343, 40)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Sitka Subheading", 18F)
        txtPassword.Location = New Point(55, 293)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "•"c
        txtPassword.Size = New Size(343, 40)
        txtPassword.TabIndex = 2
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Transparent
        btnLogin.BackgroundImage = My.Resources.Resources.loginbtn
        btnLogin.BackgroundImageLayout = ImageLayout.Zoom
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Location = New Point(117, 401)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(213, 56)
        btnLogin.TabIndex = 3
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' chkShowPass
        ' 
        chkShowPass.AutoSize = True
        chkShowPass.BackColor = Color.Transparent
        chkShowPass.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkShowPass.ForeColor = SystemColors.ButtonHighlight
        chkShowPass.Location = New Point(281, 336)
        chkShowPass.Name = "chkShowPass"
        chkShowPass.Size = New Size(114, 19)
        chkShowPass.TabIndex = 4
        chkShowPass.Text = "Show Password"
        chkShowPass.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = My.Resources.Resources.loginbg
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(454, 546)
        Controls.Add(chkShowPass)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Starbrews Cafe - Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents chkShowPass As CheckBox

End Class
