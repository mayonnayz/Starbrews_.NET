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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgridCategories = New DataGridView()
        lblTitle = New Label()
        btnViewArch = New Button()
        btnAddCategory = New Button()
        btnSearch = New Button()
        txtCatName = New TextBox()
        CType(dgridCategories, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgridCategories
        ' 
        dgridCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgridCategories.BackgroundColor = Color.FromArgb(CByte(89), CByte(82), CByte(71))
        dgridCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(80), CByte(82), CByte(71))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgridCategories.DefaultCellStyle = DataGridViewCellStyle1
        dgridCategories.Location = New Point(12, 66)
        dgridCategories.Name = "dgridCategories"
        dgridCategories.Size = New Size(776, 383)
        dgridCategories.TabIndex = 0
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
        ' btnViewArch
        ' 
        btnViewArch.BackColor = Color.FromArgb(CByte(135), CByte(125), CByte(107))
        btnViewArch.FlatAppearance.BorderSize = 0
        btnViewArch.FlatStyle = FlatStyle.Popup
        btnViewArch.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnViewArch.ForeColor = SystemColors.ActiveCaptionText
        btnViewArch.Location = New Point(571, 7)
        btnViewArch.Name = "btnViewArch"
        btnViewArch.Size = New Size(217, 22)
        btnViewArch.TabIndex = 14
        btnViewArch.Text = "VIEW ARCHIVED CATEGORIES"
        btnViewArch.UseVisualStyleBackColor = False
        ' 
        ' btnAddCategory
        ' 
        btnAddCategory.BackColor = Color.FromArgb(CByte(165), CByte(161), CByte(141))
        btnAddCategory.FlatAppearance.BorderSize = 0
        btnAddCategory.FlatStyle = FlatStyle.Popup
        btnAddCategory.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnAddCategory.ForeColor = SystemColors.ActiveCaptionText
        btnAddCategory.Location = New Point(425, 7)
        btnAddCategory.Name = "btnAddCategory"
        btnAddCategory.Size = New Size(140, 22)
        btnAddCategory.TabIndex = 13
        btnAddCategory.Text = "ADD CATEGORY"
        btnAddCategory.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(172), CByte(155), CByte(120))
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Popup
        btnSearch.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = SystemColors.ActiveCaptionText
        btnSearch.Location = New Point(757, 36)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(30, 22)
        btnSearch.TabIndex = 19
        btnSearch.Text = "🔍︎"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtCatName
        ' 
        txtCatName.Location = New Point(571, 36)
        txtCatName.Name = "txtCatName"
        txtCatName.Size = New Size(180, 23)
        txtCatName.TabIndex = 18
        ' 
        ' subCategory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.subModbg
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 461)
        Controls.Add(btnSearch)
        Controls.Add(txtCatName)
        Controls.Add(btnViewArch)
        Controls.Add(btnAddCategory)
        Controls.Add(lblTitle)
        Controls.Add(dgridCategories)
        DoubleBuffered = True
        MaximizeBox = False
        MinimizeBox = False
        Name = "subCategory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "subCategory"
        CType(dgridCategories, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgridCategories As DataGridView
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnViewArch As Button
    Friend WithEvents btnAddCategory As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtCatName As TextBox
End Class
