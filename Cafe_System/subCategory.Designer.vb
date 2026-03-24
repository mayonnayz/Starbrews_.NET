<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subCategory
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
        DataGridView1 = New DataGridView()
        lblTitle = New Label()
        btnArchives = New Button()
        btnAddAccount = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(89), CByte(82), CByte(71))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 55)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(776, 383)
        DataGridView1.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.ButtonFace
        lblTitle.Location = New Point(12, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(246, 52)
        lblTitle.TabIndex = 12
        lblTitle.Text = "Item Categories"
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnArchives
        ' 
        btnArchives.BackColor = Color.FromArgb(CByte(135), CByte(125), CByte(107))
        btnArchives.FlatAppearance.BorderSize = 0
        btnArchives.FlatStyle = FlatStyle.Popup
        btnArchives.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnArchives.ForeColor = SystemColors.ActiveCaptionText
        btnArchives.Location = New Point(571, 30)
        btnArchives.Name = "btnArchives"
        btnArchives.Size = New Size(217, 22)
        btnArchives.TabIndex = 14
        btnArchives.Text = "VIEW ARCHIVED CATEGORIES"
        btnArchives.UseVisualStyleBackColor = False
        ' 
        ' btnAddAccount
        ' 
        btnAddAccount.BackColor = Color.FromArgb(CByte(165), CByte(161), CByte(141))
        btnAddAccount.FlatAppearance.BorderSize = 0
        btnAddAccount.FlatStyle = FlatStyle.Popup
        btnAddAccount.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnAddAccount.ForeColor = SystemColors.ActiveCaptionText
        btnAddAccount.Location = New Point(440, 30)
        btnAddAccount.Name = "btnAddAccount"
        btnAddAccount.Size = New Size(125, 22)
        btnAddAccount.TabIndex = 13
        btnAddAccount.Text = "ADD CATEGORY"
        btnAddAccount.UseVisualStyleBackColor = False
        ' 
        ' subCategory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.subModbg
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(btnArchives)
        Controls.Add(btnAddAccount)
        Controls.Add(lblTitle)
        Controls.Add(DataGridView1)
        DoubleBuffered = True
        MaximizeBox = False
        MinimizeBox = False
        Name = "subCategory"
        Text = "subCategory"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnArchives As Button
    Friend WithEvents btnAddAccount As Button
End Class
