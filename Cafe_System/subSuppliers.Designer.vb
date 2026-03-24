<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subSuppliers
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
        btnCancel = New Button()
        btnSubmit = New Button()
        GroupBox1 = New GroupBox()
        cmbCategory = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        txtSName = New TextBox()
        lblTitle = New Label()
        GroupBox2 = New GroupBox()
        Label5 = New Label()
        txtAddress = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        txtEmail = New TextBox()
        txtContact = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Transparent
        btnCancel.BackgroundImage = My.Resources.Resources.btngeneral
        btnCancel.BackgroundImageLayout = ImageLayout.Stretch
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Cascadia Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(280, 395)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(123, 34)
        btnCancel.TabIndex = 23
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
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
        btnSubmit.Location = New Point(129, 395)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(123, 34)
        btnSubmit.TabIndex = 22
        btnSubmit.Text = "SUBMIT"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(cmbCategory)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtSName)
        GroupBox1.ForeColor = Color.Transparent
        GroupBox1.Location = New Point(35, 95)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(449, 94)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' cmbCategory
        ' 
        cmbCategory.Font = New Font("Consolas", 9F)
        cmbCategory.FormattingEnabled = True
        cmbCategory.Location = New Point(183, 57)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(258, 22)
        cmbCategory.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(6, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 19)
        Label2.TabIndex = 16
        Label2.Text = "Supplier Category:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(6, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 19)
        Label1.TabIndex = 14
        Label1.Text = "Supplier Name:"
        ' 
        ' txtSName
        ' 
        txtSName.Font = New Font("Consolas", 9F)
        txtSName.Location = New Point(183, 20)
        txtSName.Name = "txtSName"
        txtSName.Size = New Size(258, 22)
        txtSName.TabIndex = 13
        txtSName.Text = "Zyann"
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.Transparent
        lblTitle.Dock = DockStyle.Top
        lblTitle.Font = New Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.ButtonFace
        lblTitle.Location = New Point(0, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(523, 62)
        lblTitle.TabIndex = 20
        lblTitle.Text = "Purpose"
        lblTitle.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(txtAddress)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(txtEmail)
        GroupBox2.Controls.Add(txtContact)
        GroupBox2.ForeColor = Color.Transparent
        GroupBox2.Location = New Point(35, 210)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(449, 166)
        GroupBox2.TabIndex = 22
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(6, 99)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 19)
        Label5.TabIndex = 18
        Label5.Text = "Address:"
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Consolas", 9F)
        txtAddress.Location = New Point(183, 96)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(258, 55)
        txtAddress.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(6, 60)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 19)
        Label3.TabIndex = 16
        Label3.Text = "Email:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(6, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 19)
        Label4.TabIndex = 14
        Label4.Text = "Contact No.:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Consolas", 9F)
        txtEmail.Location = New Point(183, 57)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(258, 22)
        txtEmail.TabIndex = 15
        ' 
        ' txtContact
        ' 
        txtContact.Font = New Font("Consolas", 9F)
        txtContact.Location = New Point(183, 19)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(258, 22)
        txtContact.TabIndex = 13
        txtContact.Text = "Zyann"
        ' 
        ' subSuppliers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.subModbg
        ClientSize = New Size(523, 450)
        Controls.Add(GroupBox2)
        Controls.Add(btnCancel)
        Controls.Add(btnSubmit)
        Controls.Add(GroupBox1)
        Controls.Add(lblTitle)
        MaximizeBox = False
        MinimizeBox = False
        Name = "subSuppliers"
        StartPosition = FormStartPosition.CenterParent
        Text = "Suppliers"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSName As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents cmbCategory As ComboBox
End Class
