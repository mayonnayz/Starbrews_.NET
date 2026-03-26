<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tabItems
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        btnAddItem = New Button()
        dgridItems = New DataGridView()
        cmbCategory = New ComboBox()
        btnViewArch = New Button()
        txtIName = New TextBox()
        btnSearch = New Button()
        btnCategories = New Button()
        CType(dgridItems, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(13, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 28)
        Label1.TabIndex = 3
        Label1.Text = "Items"
        ' 
        ' btnAddItem
        ' 
        btnAddItem.BackColor = Color.FromArgb(CByte(172), CByte(155), CByte(120))
        btnAddItem.FlatAppearance.BorderSize = 0
        btnAddItem.FlatStyle = FlatStyle.Popup
        btnAddItem.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddItem.ForeColor = SystemColors.Control
        btnAddItem.Location = New Point(551, 614)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(103, 23)
        btnAddItem.TabIndex = 5
        btnAddItem.Text = "ADD ITEM"
        btnAddItem.UseVisualStyleBackColor = False
        ' 
        ' dgridItems
        ' 
        dgridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgridItems.BackgroundColor = Color.FromArgb(CByte(89), CByte(82), CByte(71))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgridItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgridItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(80), CByte(82), CByte(71))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgridItems.DefaultCellStyle = DataGridViewCellStyle2
        dgridItems.GridColor = Color.Black
        dgridItems.Location = New Point(13, 78)
        dgridItems.Name = "dgridItems"
        dgridItems.Size = New Size(826, 530)
        dgridItems.TabIndex = 0
        ' 
        ' cmbCategory
        ' 
        cmbCategory.FormattingEnabled = True
        cmbCategory.Location = New Point(177, 48)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(162, 23)
        cmbCategory.TabIndex = 2
        ' 
        ' btnViewArch
        ' 
        btnViewArch.BackColor = Color.FromArgb(CByte(135), CByte(125), CByte(107))
        btnViewArch.FlatAppearance.BorderSize = 0
        btnViewArch.FlatStyle = FlatStyle.Popup
        btnViewArch.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnViewArch.ForeColor = SystemColors.ButtonHighlight
        btnViewArch.Location = New Point(660, 614)
        btnViewArch.Name = "btnViewArch"
        btnViewArch.Size = New Size(175, 23)
        btnViewArch.TabIndex = 14
        btnViewArch.Text = "VIEW ARCHIVED ITEMS"
        btnViewArch.UseVisualStyleBackColor = False
        ' 
        ' txtIName
        ' 
        txtIName.Location = New Point(13, 48)
        txtIName.Name = "txtIName"
        txtIName.Size = New Size(158, 23)
        txtIName.TabIndex = 15
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(172), CByte(155), CByte(120))
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Popup
        btnSearch.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = SystemColors.Control
        btnSearch.Location = New Point(345, 49)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(30, 22)
        btnSearch.TabIndex = 16
        btnSearch.Text = "🔍︎"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnCategories
        ' 
        btnCategories.BackColor = Color.FromArgb(CByte(172), CByte(155), CByte(120))
        btnCategories.FlatAppearance.BorderSize = 0
        btnCategories.FlatStyle = FlatStyle.Popup
        btnCategories.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCategories.ForeColor = SystemColors.Control
        btnCategories.Location = New Point(732, 49)
        btnCategories.Name = "btnCategories"
        btnCategories.Size = New Size(103, 23)
        btnCategories.TabIndex = 17
        btnCategories.Text = "CATEGORIES"
        btnCategories.UseVisualStyleBackColor = False
        ' 
        ' tabItems
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.mainPanelBg
        Controls.Add(btnCategories)
        Controls.Add(btnSearch)
        Controls.Add(txtIName)
        Controls.Add(btnViewArch)
        Controls.Add(dgridItems)
        Controls.Add(cmbCategory)
        Controls.Add(btnAddItem)
        Controls.Add(Label1)
        Name = "tabItems"
        Size = New Size(852, 646)
        CType(dgridItems, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddItem As Button
    Friend WithEvents dgridItems As DataGridView
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents btnViewArch As Button
    Friend WithEvents txtIName As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnCategories As Button

End Class
