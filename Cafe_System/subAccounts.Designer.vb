<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subAccounts
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
        Label3 = New Label()
        txtUname = New TextBox()
        Label4 = New Label()
        txtPass = New TextBox()
        Label5 = New Label()
        cmbUlvl = New ComboBox()
        lblTitle = New Label()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        Label1 = New Label()
        txtLName = New TextBox()
        txtFName = New TextBox()
        GroupBox2 = New GroupBox()
        btnSubmit = New Button()
        btnCancel = New Button()
        GroupBox3 = New GroupBox()
        Label9 = New Label()
        txtAddress = New TextBox()
        Label6 = New Label()
        txtEmail = New TextBox()
        txtContact = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        DateTimePicker1 = New DateTimePicker()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(6, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 19)
        Label3.TabIndex = 5
        Label3.Text = "Username :"
        ' 
        ' txtUname
        ' 
        txtUname.Font = New Font("Consolas", 9F)
        txtUname.Location = New Point(138, 17)
        txtUname.Name = "txtUname"
        txtUname.Size = New Size(199, 22)
        txtUname.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(6, 64)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 19)
        Label4.TabIndex = 7
        Label4.Text = "Password :"
        ' 
        ' txtPass
        ' 
        txtPass.Font = New Font("Consolas", 9F)
        txtPass.Location = New Point(138, 62)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(199, 22)
        txtPass.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(6, 112)
        Label5.Name = "Label5"
        Label5.Size = New Size(117, 19)
        Label5.TabIndex = 9
        Label5.Text = "User Level :"
        ' 
        ' cmbUlvl
        ' 
        cmbUlvl.DropDownStyle = ComboBoxStyle.DropDownList
        cmbUlvl.Font = New Font("Consolas", 9F)
        cmbUlvl.FormattingEnabled = True
        cmbUlvl.Items.AddRange(New Object() {"Super Admin", "Store Manager", "Shift Supervisor", "Barista"})
        cmbUlvl.Location = New Point(138, 109)
        cmbUlvl.Name = "cmbUlvl"
        cmbUlvl.Size = New Size(199, 22)
        cmbUlvl.TabIndex = 10
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.Transparent
        lblTitle.Dock = DockStyle.Top
        lblTitle.Font = New Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.ButtonFace
        lblTitle.Location = New Point(0, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(416, 52)
        lblTitle.TabIndex = 11
        lblTitle.Text = "Purpose"
        lblTitle.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtLName)
        GroupBox1.Controls.Add(txtFName)
        GroupBox1.Font = New Font("Consolas", 9F)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(35, 72)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(346, 94)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Employee Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(6, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 19)
        Label2.TabIndex = 16
        Label2.Text = "Last Name :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(6, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 19)
        Label1.TabIndex = 14
        Label1.Text = "First Name :"
        ' 
        ' txtLName
        ' 
        txtLName.Font = New Font("Consolas", 9F)
        txtLName.Location = New Point(138, 58)
        txtLName.Name = "txtLName"
        txtLName.Size = New Size(199, 22)
        txtLName.TabIndex = 15
        ' 
        ' txtFName
        ' 
        txtFName.Font = New Font("Consolas", 9F)
        txtFName.Location = New Point(138, 17)
        txtFName.Name = "txtFName"
        txtFName.Size = New Size(199, 22)
        txtFName.TabIndex = 13
        txtFName.Text = "Zyann"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(txtUname)
        GroupBox2.Controls.Add(txtPass)
        GroupBox2.Controls.Add(cmbUlvl)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Font = New Font("Consolas", 9F)
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(35, 187)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(346, 147)
        GroupBox2.TabIndex = 17
        GroupBox2.TabStop = False
        GroupBox2.Text = "Account Information"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.Transparent
        btnSubmit.BackgroundImage = My.Resources.Resources.btngeneral
        btnSubmit.BackgroundImageLayout = ImageLayout.Stretch
        btnSubmit.FlatAppearance.BorderSize = 0
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Font = New Font("Cascadia Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.ForeColor = SystemColors.ControlText
        btnSubmit.Location = New Point(72, 590)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(123, 34)
        btnSubmit.TabIndex = 18
        btnSubmit.Text = "SUBMIT"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Transparent
        btnCancel.BackgroundImage = My.Resources.Resources.btngeneral
        btnCancel.BackgroundImageLayout = ImageLayout.Stretch
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Cascadia Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(223, 590)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(123, 34)
        btnCancel.TabIndex = 19
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.Transparent
        GroupBox3.Controls.Add(DateTimePicker1)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(txtAddress)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(txtEmail)
        GroupBox3.Controls.Add(txtContact)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Font = New Font("Consolas", 9F)
        GroupBox3.ForeColor = Color.White
        GroupBox3.Location = New Point(35, 364)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(346, 193)
        GroupBox3.TabIndex = 18
        GroupBox3.TabStop = False
        GroupBox3.Text = "Personal Information"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ButtonFace
        Label9.Location = New Point(6, 159)
        Label9.Name = "Label9"
        Label9.Size = New Size(99, 19)
        Label9.TabIndex = 11
        Label9.Text = "Birthday :"
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Consolas", 9F)
        txtAddress.Location = New Point(138, 80)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(199, 70)
        txtAddress.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonFace
        Label6.Location = New Point(6, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 19)
        Label6.TabIndex = 5
        Label6.Text = "Email :"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Consolas", 9F)
        txtEmail.Location = New Point(138, 17)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(199, 22)
        txtEmail.TabIndex = 4
        ' 
        ' txtContact
        ' 
        txtContact.Font = New Font("Consolas", 9F)
        txtContact.Location = New Point(138, 48)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(199, 22)
        txtContact.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ButtonFace
        Label7.Location = New Point(6, 50)
        Label7.Name = "Label7"
        Label7.Size = New Size(126, 19)
        Label7.TabIndex = 7
        Label7.Text = "Contact No. :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ButtonFace
        Label8.Location = New Point(6, 79)
        Label8.Name = "Label8"
        Label8.Size = New Size(90, 19)
        Label8.TabIndex = 9
        Label8.Text = "Address :"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(137, 159)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 22)
        DateTimePicker1.TabIndex = 12
        ' 
        ' subAccounts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.subModbg
        ClientSize = New Size(416, 643)
        Controls.Add(GroupBox3)
        Controls.Add(btnCancel)
        Controls.Add(btnSubmit)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(lblTitle)
        Name = "subAccounts"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Account"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbUlvl As ComboBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
