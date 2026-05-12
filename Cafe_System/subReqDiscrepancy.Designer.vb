<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subReqDiscrepancy
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        txtPrice = New TextBox()
        Label5 = New Label()
        txtUnit = New TextBox()
        txtQuantity = New TextBox()
        Label4 = New Label()
        btnRemove = New Button()
        Label3 = New Label()
        cmbSupplier = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        btnCreate = New Button()
        lblDate = New Label()
        lblReqBy = New Label()
        DataGridView1 = New DataGridView()
        btnCancel = New Button()
        lblTitle = New Label()
        txtCategory = New TextBox()
        txtName = New TextBox()
        GroupBox1 = New GroupBox()
        lblTransac = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(60, 217)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(133, 23)
        txtPrice.TabIndex = 56
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Consolas", 9F)
        Label5.Location = New Point(10, 221)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 14)
        Label5.TabIndex = 55
        Label5.Text = "Price:"
        ' 
        ' txtUnit
        ' 
        txtUnit.Location = New Point(103, 183)
        txtUnit.Name = "txtUnit"
        txtUnit.Size = New Size(90, 23)
        txtUnit.TabIndex = 54
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(7, 183)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(99, 23)
        txtQuantity.TabIndex = 53
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Consolas", 9F)
        Label4.Location = New Point(10, 166)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 14)
        Label4.TabIndex = 52
        Label4.Text = "Quantity:"
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = Color.FromArgb(CByte(122), CByte(72), CByte(70))
        btnRemove.FlatAppearance.BorderSize = 0
        btnRemove.FlatStyle = FlatStyle.Popup
        btnRemove.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnRemove.ForeColor = SystemColors.ButtonHighlight
        btnRemove.Location = New Point(27, 575)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(152, 22)
        btnRemove.TabIndex = 51
        btnRemove.Text = "REMOVE ITEM"
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Consolas", 9F)
        Label3.Location = New Point(11, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 14)
        Label3.TabIndex = 48
        Label3.Text = "Supplier:"
        ' 
        ' cmbSupplier
        ' 
        cmbSupplier.FormattingEnabled = True
        cmbSupplier.Location = New Point(8, 130)
        cmbSupplier.Name = "cmbSupplier"
        cmbSupplier.Size = New Size(186, 23)
        cmbSupplier.TabIndex = 47
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Consolas", 9F)
        Label2.Location = New Point(11, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 14)
        Label2.TabIndex = 46
        Label2.Text = "Item:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Consolas", 9F)
        Label1.Location = New Point(11, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 14)
        Label1.TabIndex = 45
        Label1.Text = "Category:"
        ' 
        ' btnCreate
        ' 
        btnCreate.BackColor = Color.FromArgb(CByte(84), CByte(122), CByte(70))
        btnCreate.FlatAppearance.BorderSize = 0
        btnCreate.FlatStyle = FlatStyle.Popup
        btnCreate.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnCreate.ForeColor = SystemColors.ButtonHighlight
        btnCreate.Location = New Point(688, 11)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(152, 22)
        btnCreate.TabIndex = 43
        btnCreate.Text = "CREATE REQUEST"
        btnCreate.UseVisualStyleBackColor = False
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.BackColor = Color.Transparent
        lblDate.Font = New Font("Consolas", 9F)
        lblDate.Location = New Point(13, 89)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(42, 14)
        lblDate.TabIndex = 42
        lblDate.Text = "Date:"
        ' 
        ' lblReqBy
        ' 
        lblReqBy.AutoSize = True
        lblReqBy.BackColor = Color.Transparent
        lblReqBy.Font = New Font("Consolas", 9F)
        lblReqBy.Location = New Point(13, 49)
        lblReqBy.Name = "lblReqBy"
        lblReqBy.Size = New Size(105, 14)
        lblReqBy.TabIndex = 41
        lblReqBy.Text = "Requested by: "
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(89), CByte(82), CByte(71))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText
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
        DataGridView1.Location = New Point(205, 43)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.Size = New Size(793, 563)
        DataGridView1.TabIndex = 40
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(122), CByte(72), CByte(70))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Popup
        btnCancel.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnCancel.ForeColor = SystemColors.ButtonHighlight
        btnCancel.Location = New Point(846, 11)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(152, 22)
        btnCancel.TabIndex = 39
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(10, 8)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(187, 28)
        lblTitle.TabIndex = 38
        lblTitle.Text = "Reorder Items"
        ' 
        ' txtCategory
        ' 
        txtCategory.Location = New Point(8, 36)
        txtCategory.Name = "txtCategory"
        txtCategory.Size = New Size(186, 23)
        txtCategory.TabIndex = 57
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(8, 81)
        txtName.Name = "txtName"
        txtName.Size = New Size(186, 23)
        txtName.TabIndex = 58
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImage = My.Resources.Resources.mainPanelBg
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(txtPrice)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtCategory)
        GroupBox1.Controls.Add(txtUnit)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtQuantity)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(cmbSupplier)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(1, 305)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 250)
        GroupBox1.TabIndex = 59
        GroupBox1.TabStop = False
        ' 
        ' lblTransac
        ' 
        lblTransac.AutoSize = True
        lblTransac.BackColor = Color.Transparent
        lblTransac.Font = New Font("Consolas", 9F)
        lblTransac.Location = New Point(13, 129)
        lblTransac.Name = "lblTransac"
        lblTransac.Size = New Size(112, 14)
        lblTransac.TabIndex = 60
        lblTransac.Text = "Transaction ID:"
        ' 
        ' subReqDiscrepancy
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.mainPanelBg
        ClientSize = New Size(1009, 614)
        Controls.Add(lblTransac)
        Controls.Add(GroupBox1)
        Controls.Add(btnRemove)
        Controls.Add(btnCreate)
        Controls.Add(lblDate)
        Controls.Add(lblReqBy)
        Controls.Add(DataGridView1)
        Controls.Add(btnCancel)
        Controls.Add(lblTitle)
        MaximizeBox = False
        MinimizeBox = False
        Name = "subReqDiscrepancy"
        StartPosition = FormStartPosition.CenterScreen
        Text = "subReqDiscrepancy"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents lblReqBy As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTransac As Label
End Class
