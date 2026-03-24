<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subCat
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
        Label2 = New Label()
        Label1 = New Label()
        txtDesc = New TextBox()
        txtCName = New TextBox()
        lblTitle = New Label()
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
        btnCancel.Location = New Point(218, 221)
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
        btnSubmit.Location = New Point(67, 221)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(123, 34)
        btnSubmit.TabIndex = 23
        btnSubmit.Text = "SUBMIT"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtDesc)
        GroupBox1.Controls.Add(txtCName)
        GroupBox1.ForeColor = Color.Transparent
        GroupBox1.Location = New Point(35, 65)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(346, 139)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Consolas", 10F)
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(6, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 17)
        Label2.TabIndex = 16
        Label2.Text = "Description:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Consolas", 10F)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(6, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 17)
        Label1.TabIndex = 14
        Label1.Text = "Category Name :"
        ' 
        ' txtDesc
        ' 
        txtDesc.Font = New Font("Consolas", 9F)
        txtDesc.Location = New Point(138, 45)
        txtDesc.Multiline = True
        txtDesc.Name = "txtDesc"
        txtDesc.Size = New Size(199, 81)
        txtDesc.TabIndex = 15
        ' 
        ' txtCName
        ' 
        txtCName.Font = New Font("Consolas", 9F)
        txtCName.Location = New Point(138, 17)
        txtCName.Name = "txtCName"
        txtCName.Size = New Size(199, 22)
        txtCName.TabIndex = 13
        txtCName.Text = "Zyann"
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.Transparent
        lblTitle.Dock = DockStyle.Top
        lblTitle.Font = New Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.ButtonFace
        lblTitle.Location = New Point(0, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(417, 52)
        lblTitle.TabIndex = 20
        lblTitle.Text = "Purpose"
        lblTitle.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' subCat
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.subModbg
        ClientSize = New Size(417, 268)
        Controls.Add(btnCancel)
        Controls.Add(btnSubmit)
        Controls.Add(GroupBox1)
        Controls.Add(lblTitle)
        MaximizeBox = False
        MinimizeBox = False
        Name = "subCat"
        StartPosition = FormStartPosition.CenterScreen
        Text = "subCat"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtCName As TextBox
    Friend WithEvents lblTitle As Label
End Class
