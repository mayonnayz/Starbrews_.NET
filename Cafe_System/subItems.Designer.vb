<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subItems
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
        GroupBox2 = New GroupBox()
        Label6 = New Label()
        Label3 = New Label()
        txtUname = New TextBox()
        txtPass = New TextBox()
        cmbUlvl = New ComboBox()
        Label5 = New Label()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        Label1 = New Label()
        txtIDesc = New TextBox()
        txtIName = New TextBox()
        lblTitle = New Label()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
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
        btnCancel.Location = New Point(222, 367)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(123, 34)
        btnCancel.TabIndex = 24
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
        btnSubmit.Location = New Point(71, 367)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(123, 34)
        btnSubmit.TabIndex = 23
        btnSubmit.Text = "SUBMIT"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(txtUname)
        GroupBox2.Controls.Add(txtPass)
        GroupBox2.ForeColor = Color.Transparent
        GroupBox2.Location = New Point(35, 272)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(346, 60)
        GroupBox2.TabIndex = 22
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Consolas", 10F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.ButtonFace
        Label6.Location = New Point(211, 25)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 17)
        Label6.TabIndex = 8
        Label6.Text = "Unit:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Consolas", 10F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(6, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 17)
        Label3.TabIndex = 5
        Label3.Text = "Unit Price:"
        ' 
        ' txtUname
        ' 
        txtUname.Font = New Font("Consolas", 9F)
        txtUname.Location = New Point(103, 22)
        txtUname.Name = "txtUname"
        txtUname.Size = New Size(104, 22)
        txtUname.TabIndex = 4
        ' 
        ' txtPass
        ' 
        txtPass.Font = New Font("Consolas", 9F)
        txtPass.Location = New Point(261, 22)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(79, 22)
        txtPass.TabIndex = 6
        ' 
        ' cmbUlvl
        ' 
        cmbUlvl.Font = New Font("Consolas", 9F)
        cmbUlvl.FormattingEnabled = True
        cmbUlvl.Items.AddRange(New Object() {"Super Admin", "Store Manager", "Shift Supervisor", "Barista"})
        cmbUlvl.Location = New Point(120, 134)
        cmbUlvl.Name = "cmbUlvl"
        cmbUlvl.Size = New Size(217, 22)
        cmbUlvl.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(6, 135)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 19)
        Label5.TabIndex = 9
        Label5.Text = "Category:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtIDesc)
        GroupBox1.Controls.Add(cmbUlvl)
        GroupBox1.Controls.Add(txtIName)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.ForeColor = Color.Transparent
        GroupBox1.Location = New Point(35, 83)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(346, 170)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(6, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 19)
        Label2.TabIndex = 16
        Label2.Text = "Item Desc.:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(6, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 19)
        Label1.TabIndex = 14
        Label1.Text = "Item Name:"
        ' 
        ' txtIDesc
        ' 
        txtIDesc.Font = New Font("Consolas", 9F)
        txtIDesc.Location = New Point(120, 52)
        txtIDesc.Multiline = True
        txtIDesc.Name = "txtIDesc"
        txtIDesc.Size = New Size(217, 75)
        txtIDesc.TabIndex = 15
        ' 
        ' txtIName
        ' 
        txtIName.Font = New Font("Consolas", 9F)
        txtIName.Location = New Point(120, 22)
        txtIName.Name = "txtIName"
        txtIName.Size = New Size(217, 22)
        txtIName.TabIndex = 13
        txtIName.Text = "Zyann"
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
        lblTitle.TabIndex = 20
        lblTitle.Text = "Purpose"
        lblTitle.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' subItems
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.subModbg
        ClientSize = New Size(416, 426)
        Controls.Add(btnCancel)
        Controls.Add(btnSubmit)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(lblTitle)
        MaximizeBox = False
        MinimizeBox = False
        Name = "subItems"
        Text = "subItems"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUname As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents cmbUlvl As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIDesc As TextBox
    Friend WithEvents txtIName As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label6 As Label
End Class
