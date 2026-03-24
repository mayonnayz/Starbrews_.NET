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
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        ReqNo = New DataGridViewTextBoxColumn()
        Date_Requested = New DataGridViewTextBoxColumn()
        RequestedBy = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
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
        DataGridView1.BackgroundColor = Color.PapayaWhip
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ReqNo, Date_Requested, RequestedBy, Status})
        DataGridView1.Location = New Point(13, 93)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(510, 493)
        DataGridView1.TabIndex = 5
        ' 
        ' ReqNo
        ' 
        ReqNo.HeaderText = "Req. No."
        ReqNo.Name = "ReqNo"
        ' 
        ' Date_Requested
        ' 
        Date_Requested.HeaderText = "Date Requested"
        Date_Requested.Name = "Date_Requested"
        ' 
        ' RequestedBy
        ' 
        RequestedBy.HeaderText = "Requested by"
        RequestedBy.Name = "RequestedBy"
        ' 
        ' Status
        ' 
        Status.HeaderText = "Status"
        Status.Name = "Status"
        ' 
        ' lstSupplier
        ' 
        lstSupplier.BackColor = Color.Bisque
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
        btnAddSupplier.BackColor = Color.PeachPuff
        btnAddSupplier.FlatAppearance.BorderSize = 0
        btnAddSupplier.FlatStyle = FlatStyle.Popup
        btnAddSupplier.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnAddSupplier.Location = New Point(529, 586)
        btnAddSupplier.Name = "btnAddSupplier"
        btnAddSupplier.Size = New Size(150, 23)
        btnAddSupplier.TabIndex = 8
        btnAddSupplier.Text = "ADD SUPPLIER"
        btnAddSupplier.UseVisualStyleBackColor = False
        ' 
        ' btnArchiveSupplier
        ' 
        btnArchiveSupplier.BackColor = Color.PeachPuff
        btnArchiveSupplier.FlatAppearance.BorderSize = 0
        btnArchiveSupplier.FlatStyle = FlatStyle.Popup
        btnArchiveSupplier.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnArchiveSupplier.Location = New Point(687, 615)
        btnArchiveSupplier.Name = "btnArchiveSupplier"
        btnArchiveSupplier.Size = New Size(152, 23)
        btnArchiveSupplier.TabIndex = 9
        btnArchiveSupplier.Text = "RESTORE SUPPLIER"
        btnArchiveSupplier.UseVisualStyleBackColor = False
        ' 
        ' btnEditSupplier
        ' 
        btnEditSupplier.BackColor = Color.PeachPuff
        btnEditSupplier.FlatAppearance.BorderSize = 0
        btnEditSupplier.FlatStyle = FlatStyle.Popup
        btnEditSupplier.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnEditSupplier.Location = New Point(687, 586)
        btnEditSupplier.Name = "btnEditSupplier"
        btnEditSupplier.Size = New Size(152, 23)
        btnEditSupplier.TabIndex = 10
        btnEditSupplier.Text = "EDIT SUPPLIER"
        btnEditSupplier.UseVisualStyleBackColor = False
        ' 
        ' btnCreateRequest
        ' 
        btnCreateRequest.BackColor = Color.Wheat
        btnCreateRequest.FlatAppearance.BorderSize = 0
        btnCreateRequest.FlatStyle = FlatStyle.Popup
        btnCreateRequest.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnCreateRequest.Location = New Point(15, 60)
        btnCreateRequest.Name = "btnCreateRequest"
        btnCreateRequest.Size = New Size(167, 23)
        btnCreateRequest.TabIndex = 11
        btnCreateRequest.Text = "CREATE ORDER REQUEST"
        btnCreateRequest.UseVisualStyleBackColor = False
        ' 
        ' btnViewRequest
        ' 
        btnViewRequest.BackColor = Color.Wheat
        btnViewRequest.FlatAppearance.BorderSize = 0
        btnViewRequest.FlatStyle = FlatStyle.Popup
        btnViewRequest.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnViewRequest.Location = New Point(13, 601)
        btnViewRequest.Name = "btnViewRequest"
        btnViewRequest.Size = New Size(150, 23)
        btnViewRequest.TabIndex = 12
        btnViewRequest.Text = "VIEW ORDER REQUEST"
        btnViewRequest.UseVisualStyleBackColor = False
        ' 
        ' btnViewArch
        ' 
        btnViewArch.BackColor = Color.Peru
        btnViewArch.FlatAppearance.BorderSize = 0
        btnViewArch.FlatStyle = FlatStyle.Popup
        btnViewArch.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnViewArch.Location = New Point(529, 615)
        btnViewArch.Name = "btnViewArch"
        btnViewArch.Size = New Size(150, 23)
        btnViewArch.TabIndex = 13
        btnViewArch.Text = "VIEW ARCHIVED"
        btnViewArch.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.PeachPuff
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Popup
        btnSearch.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(773, 63)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(64, 22)
        btnSearch.TabIndex = 15
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Consolas", 9F)
        txtSearch.Location = New Point(529, 63)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(122, 22)
        txtSearch.TabIndex = 14
        ' 
        ' cmbCategory
        ' 
        cmbCategory.Font = New Font("Consolas", 9F)
        cmbCategory.FormattingEnabled = True
        cmbCategory.Location = New Point(651, 63)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(122, 22)
        cmbCategory.TabIndex = 16
        ' 
        ' tabOrderRequests
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.mainPanelBg
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
    Friend WithEvents ReqNo As DataGridViewTextBoxColumn
    Friend WithEvents Date_Requested As DataGridViewTextBoxColumn
    Friend WithEvents RequestedBy As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents btnViewArch As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbCategory As ComboBox

End Class
