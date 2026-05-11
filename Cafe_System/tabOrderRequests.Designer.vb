<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tabOrderRequests
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        lstSupplier = New ListBox()
        Label2 = New Label()
        btnAddSupplier = New Button()
        btnArchiveSupplier = New Button()
        btnEditSupplier = New Button()
        btnCreateRequest = New Button()
        btnViewRequest = New Button()
        btnViewArch = New Button()
        btnSearch = New Button()
        txtSearch = New TextBox()
        cmbCategory = New ComboBox()
        dtStart = New DateTimePicker()
        btnAll = New Button()
        btnSearchDate = New Button()
        dtEnd = New DateTimePicker()
        Label3 = New Label()
        Label4 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(13, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(205, 28)
        Label1.TabIndex = 4
        Label1.Text = "Order Requests"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(89), CByte(82), CByte(71))
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(80), CByte(82), CByte(71))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(13, 93)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(80), CByte(82), CByte(71))
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.Size = New Size(510, 493)
        DataGridView1.TabIndex = 5
        ' 
        ' lstSupplier
        ' 
        lstSupplier.BackColor = Color.FromArgb(CByte(196), CByte(188), CByte(171))
        lstSupplier.BorderStyle = BorderStyle.FixedSingle
        lstSupplier.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstSupplier.FormattingEnabled = True
        lstSupplier.ItemHeight = 18
        lstSupplier.Location = New Point(529, 92)
        lstSupplier.Name = "lstSupplier"
        lstSupplier.Size = New Size(308, 488)
        lstSupplier.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(529, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(272, 28)
        Label2.TabIndex = 7
        Label2.Text = "Supplier Information"
        ' 
        ' btnAddSupplier
        ' 
        btnAddSupplier.BackColor = Color.FromArgb(CByte(172), CByte(155), CByte(120))
        btnAddSupplier.FlatAppearance.BorderSize = 0
        btnAddSupplier.FlatStyle = FlatStyle.Popup
        btnAddSupplier.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnAddSupplier.ForeColor = SystemColors.ButtonHighlight
        btnAddSupplier.Location = New Point(529, 586)
        btnAddSupplier.Name = "btnAddSupplier"
        btnAddSupplier.Size = New Size(150, 23)
        btnAddSupplier.TabIndex = 8
        btnAddSupplier.Text = "ADD SUPPLIER"
        btnAddSupplier.UseVisualStyleBackColor = False
        ' 
        ' btnArchiveSupplier
        ' 
        btnArchiveSupplier.BackColor = Color.FromArgb(CByte(172), CByte(155), CByte(120))
        btnArchiveSupplier.FlatAppearance.BorderSize = 0
        btnArchiveSupplier.FlatStyle = FlatStyle.Popup
        btnArchiveSupplier.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnArchiveSupplier.ForeColor = SystemColors.ButtonHighlight
        btnArchiveSupplier.Location = New Point(687, 615)
        btnArchiveSupplier.Name = "btnArchiveSupplier"
        btnArchiveSupplier.Size = New Size(152, 23)
        btnArchiveSupplier.TabIndex = 9
        btnArchiveSupplier.Text = "RESTORE SUPPLIER"
        btnArchiveSupplier.UseVisualStyleBackColor = False
        ' 
        ' btnEditSupplier
        ' 
        btnEditSupplier.BackColor = Color.FromArgb(CByte(172), CByte(155), CByte(120))
        btnEditSupplier.FlatAppearance.BorderSize = 0
        btnEditSupplier.FlatStyle = FlatStyle.Popup
        btnEditSupplier.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnEditSupplier.ForeColor = SystemColors.ButtonHighlight
        btnEditSupplier.Location = New Point(687, 586)
        btnEditSupplier.Name = "btnEditSupplier"
        btnEditSupplier.Size = New Size(152, 23)
        btnEditSupplier.TabIndex = 10
        btnEditSupplier.Text = "EDIT SUPPLIER"
        btnEditSupplier.UseVisualStyleBackColor = False
        ' 
        ' btnCreateRequest
        ' 
        btnCreateRequest.BackColor = Color.FromArgb(CByte(165), CByte(161), CByte(141))
        btnCreateRequest.FlatAppearance.BorderSize = 0
        btnCreateRequest.FlatStyle = FlatStyle.Popup
        btnCreateRequest.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnCreateRequest.ForeColor = SystemColors.ButtonHighlight
        btnCreateRequest.Location = New Point(13, 592)
        btnCreateRequest.Name = "btnCreateRequest"
        btnCreateRequest.Size = New Size(205, 23)
        btnCreateRequest.TabIndex = 11
        btnCreateRequest.Text = "CREATE ORDER REQUEST"
        btnCreateRequest.UseVisualStyleBackColor = False
        ' 
        ' btnViewRequest
        ' 
        btnViewRequest.BackColor = Color.FromArgb(CByte(165), CByte(161), CByte(141))
        btnViewRequest.FlatAppearance.BorderSize = 0
        btnViewRequest.FlatStyle = FlatStyle.Popup
        btnViewRequest.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnViewRequest.ForeColor = SystemColors.ButtonHighlight
        btnViewRequest.Location = New Point(224, 592)
        btnViewRequest.Name = "btnViewRequest"
        btnViewRequest.Size = New Size(187, 23)
        btnViewRequest.TabIndex = 12
        btnViewRequest.Text = "VIEW ORDER REQUEST"
        btnViewRequest.UseVisualStyleBackColor = False
        ' 
        ' btnViewArch
        ' 
        btnViewArch.BackColor = Color.FromArgb(CByte(135), CByte(125), CByte(107))
        btnViewArch.FlatAppearance.BorderSize = 0
        btnViewArch.FlatStyle = FlatStyle.Popup
        btnViewArch.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnViewArch.ForeColor = SystemColors.ButtonHighlight
        btnViewArch.Location = New Point(529, 615)
        btnViewArch.Name = "btnViewArch"
        btnViewArch.Size = New Size(150, 23)
        btnViewArch.TabIndex = 13
        btnViewArch.Text = "VIEW ARCHIVED"
        btnViewArch.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(172), CByte(155), CByte(120))
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Popup
        btnSearch.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = SystemColors.ButtonHighlight
        btnSearch.Location = New Point(807, 63)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(30, 22)
        btnSearch.TabIndex = 15
        btnSearch.Text = "🔍︎"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Consolas", 9F)
        txtSearch.Location = New Point(529, 63)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(140, 22)
        txtSearch.TabIndex = 14
        ' 
        ' cmbCategory
        ' 
        cmbCategory.Font = New Font("Consolas", 9F)
        cmbCategory.FormattingEnabled = True
        cmbCategory.Location = New Point(669, 63)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(138, 22)
        cmbCategory.TabIndex = 16
        ' 
        ' dtStart
        ' 
        dtStart.CustomFormat = "MMM dd, yyyy"
        dtStart.Format = DateTimePickerFormat.Custom
        dtStart.Location = New Point(13, 59)
        dtStart.Name = "dtStart"
        dtStart.Size = New Size(148, 23)
        dtStart.TabIndex = 17
        ' 
        ' btnAll
        ' 
        btnAll.BackColor = Color.FromArgb(CByte(196), CByte(188), CByte(171))
        btnAll.FlatAppearance.BorderSize = 0
        btnAll.FlatStyle = FlatStyle.Popup
        btnAll.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnAll.ForeColor = SystemColors.ButtonHighlight
        btnAll.Location = New Point(377, 59)
        btnAll.Name = "btnAll"
        btnAll.Size = New Size(55, 23)
        btnAll.TabIndex = 18
        btnAll.Text = "ALL"
        btnAll.UseVisualStyleBackColor = False
        ' 
        ' btnSearchDate
        ' 
        btnSearchDate.BackColor = Color.FromArgb(CByte(196), CByte(188), CByte(171))
        btnSearchDate.FlatAppearance.BorderSize = 0
        btnSearchDate.FlatStyle = FlatStyle.Popup
        btnSearchDate.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnSearchDate.ForeColor = SystemColors.ButtonHighlight
        btnSearchDate.Location = New Point(321, 59)
        btnSearchDate.Name = "btnSearchDate"
        btnSearchDate.Size = New Size(38, 23)
        btnSearchDate.TabIndex = 19
        btnSearchDate.Text = "🔍︎"
        btnSearchDate.UseVisualStyleBackColor = False
        ' 
        ' dtEnd
        ' 
        dtEnd.CustomFormat = "MMM dd, yyyy"
        dtEnd.Format = DateTimePickerFormat.Custom
        dtEnd.Location = New Point(166, 59)
        dtEnd.Name = "dtEnd"
        dtEnd.Size = New Size(148, 23)
        dtEnd.TabIndex = 20
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Consolas", 8F)
        Label3.Location = New Point(13, 45)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 13)
        Label3.TabIndex = 21
        Label3.Text = "Start Date Range:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Consolas", 8F)
        Label4.Location = New Point(166, 45)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 13)
        Label4.TabIndex = 22
        Label4.Text = "End Date Range:"
        ' 
        ' tabOrderRequests
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.mainPanelBg
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(dtEnd)
        Controls.Add(btnSearchDate)
        Controls.Add(btnAll)
        Controls.Add(dtStart)
        Controls.Add(cmbCategory)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(btnViewArch)
        Controls.Add(btnViewRequest)
        Controls.Add(btnCreateRequest)
        Controls.Add(btnEditSupplier)
        Controls.Add(btnArchiveSupplier)
        Controls.Add(btnAddSupplier)
        Controls.Add(Label2)
        Controls.Add(lstSupplier)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Name = "tabOrderRequests"
        Size = New Size(852, 646)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lstSupplier As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddSupplier As Button
    Friend WithEvents btnArchiveSupplier As Button
    Friend WithEvents btnEditSupplier As Button
    Friend WithEvents btnCreateRequest As Button
    Friend WithEvents btnViewRequest As Button
    Friend WithEvents btnViewArch As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents dtStart As DateTimePicker
    Friend WithEvents btnAll As Button
    Friend WithEvents btnSearchDate As Button
    Friend WithEvents dtEnd As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
