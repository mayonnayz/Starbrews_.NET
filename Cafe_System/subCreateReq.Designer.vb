<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subCreateReq
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblTitle = New Label()
        btnCancel = New Button()
        DataGridView1 = New DataGridView()
        lblDate = New Label()
        lblReqBy = New Label()
        btnRequest = New Button()
        cmbCategory = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnAdd = New Button()
        btnRemove = New Button()
        Label4 = New Label()
        txtQuantity = New TextBox()
        txtUnit = New TextBox()
        txtPrice = New TextBox()
        Label5 = New Label()
        cmbSupplier = New ComboBox()
        lstItem = New ListBox()
        txtSearch = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(9, 5)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(278, 28)
        lblTitle.TabIndex = 17
        lblTitle.Text = "Create Stock Request"
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(122), CByte(72), CByte(70))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Popup
        btnCancel.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnCancel.ForeColor = SystemColors.ButtonHighlight
        btnCancel.Location = New Point(845, 8)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(152, 22)
        btnCancel.TabIndex = 18
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(89), CByte(82), CByte(71))
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(80), CByte(82), CByte(71))
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        DataGridView1.Location = New Point(204, 40)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DataGridView1.Size = New Size(793, 563)
        DataGridView1.TabIndex = 19
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.BackColor = Color.Transparent
        lblDate.Font = New Font("Consolas", 9F)
        lblDate.Location = New Point(12, 76)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(42, 14)
        lblDate.TabIndex = 21
        lblDate.Text = "Date:"
        ' 
        ' lblReqBy
        ' 
        lblReqBy.AutoSize = True
        lblReqBy.BackColor = Color.Transparent
        lblReqBy.Font = New Font("Consolas", 9F)
        lblReqBy.Location = New Point(12, 40)
        lblReqBy.Name = "lblReqBy"
        lblReqBy.Size = New Size(105, 14)
        lblReqBy.TabIndex = 20
        lblReqBy.Text = "Requested by: "
        ' 
        ' btnRequest
        ' 
        btnRequest.BackColor = Color.FromArgb(CByte(84), CByte(122), CByte(70))
        btnRequest.FlatAppearance.BorderSize = 0
        btnRequest.FlatStyle = FlatStyle.Popup
        btnRequest.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnRequest.ForeColor = SystemColors.ButtonHighlight
        btnRequest.Location = New Point(687, 8)
        btnRequest.Name = "btnRequest"
        btnRequest.Size = New Size(152, 22)
        btnRequest.TabIndex = 23
        btnRequest.Text = "CREATE REQUEST"
        btnRequest.UseVisualStyleBackColor = False
        ' 
        ' cmbCategory
        ' 
        cmbCategory.FormattingEnabled = True
        cmbCategory.Location = New Point(9, 161)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(186, 23)
        cmbCategory.TabIndex = 24
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Consolas", 9F)
        Label1.Location = New Point(12, 144)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 14)
        Label1.TabIndex = 25
        Label1.Text = "Category:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Consolas", 9F)
        Label2.Location = New Point(12, 189)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 14)
        Label2.TabIndex = 27
        Label2.Text = "Item:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Consolas", 9F)
        Label3.Location = New Point(12, 427)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 14)
        Label3.TabIndex = 29
        Label3.Text = "Supplier:"
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(84), CByte(122), CByte(70))
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnAdd.ForeColor = SystemColors.ButtonHighlight
        btnAdd.Location = New Point(26, 555)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(152, 22)
        btnAdd.TabIndex = 31
        btnAdd.Text = "ADD ITEM"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = Color.FromArgb(CByte(122), CByte(72), CByte(70))
        btnRemove.FlatAppearance.BorderSize = 0
        btnRemove.FlatStyle = FlatStyle.Popup
        btnRemove.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnRemove.ForeColor = SystemColors.ButtonHighlight
        btnRemove.Location = New Point(26, 581)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(152, 22)
        btnRemove.TabIndex = 32
        btnRemove.Text = "REMOVE ITEM"
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Consolas", 9F)
        Label4.Location = New Point(12, 475)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 14)
        Label4.TabIndex = 33
        Label4.Text = "Quantity:"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(9, 492)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(99, 23)
        txtQuantity.TabIndex = 34
        ' 
        ' txtUnit
        ' 
        txtUnit.Location = New Point(105, 492)
        txtUnit.Name = "txtUnit"
        txtUnit.Size = New Size(90, 23)
        txtUnit.TabIndex = 35
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(62, 526)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(133, 23)
        txtPrice.TabIndex = 37
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Consolas", 9F)
        Label5.Location = New Point(12, 530)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 14)
        Label5.TabIndex = 36
        Label5.Text = "Price:"
        ' 
        ' cmbSupplier
        ' 
        cmbSupplier.FormattingEnabled = True
        cmbSupplier.Location = New Point(9, 444)
        cmbSupplier.Name = "cmbSupplier"
        cmbSupplier.Size = New Size(186, 23)
        cmbSupplier.TabIndex = 28
        ' 
        ' lstItem
        ' 
        lstItem.FormattingEnabled = True
        lstItem.ItemHeight = 15
        lstItem.Location = New Point(9, 206)
        lstItem.Name = "lstItem"
        lstItem.Size = New Size(186, 214)
        lstItem.TabIndex = 30
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(9, 118)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(186, 23)
        txtSearch.TabIndex = 38
        ' 
        ' subCreateReq
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.mainPanelBg
        ClientSize = New Size(1009, 614)
        Controls.Add(txtSearch)
        Controls.Add(txtPrice)
        Controls.Add(Label5)
        Controls.Add(txtUnit)
        Controls.Add(txtQuantity)
        Controls.Add(Label4)
        Controls.Add(btnRemove)
        Controls.Add(btnAdd)
        Controls.Add(lstItem)
        Controls.Add(Label3)
        Controls.Add(cmbSupplier)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmbCategory)
        Controls.Add(btnRequest)
        Controls.Add(lblDate)
        Controls.Add(lblReqBy)
        Controls.Add(DataGridView1)
        Controls.Add(btnCancel)
        Controls.Add(lblTitle)
        MaximizeBox = False
        MinimizeBox = False
        Name = "subCreateReq"
        StartPosition = FormStartPosition.CenterScreen
        Text = "subCreateReq"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblDate As Label
    Friend WithEvents lblReqBy As Label
    Friend WithEvents btnRequest As Button
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents lstItem As ListBox
    Friend WithEvents txtSearch As TextBox
End Class
