<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subStockOutRoom
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
        btnStock = New Button()
        btnCancel = New Button()
        cmbBarista = New ComboBox()
        lblDate = New Label()
        lblSvisor = New Label()
        Label2 = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        btnRemove = New Button()
        btnAdd = New Button()
        lstItem = New ListBox()
        Label3 = New Label()
        Label4 = New Label()
        cmbCategory = New ComboBox()
        txtUnit = New TextBox()
        txtQuantity = New TextBox()
        Label5 = New Label()
        txtSearch = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnStock
        ' 
        btnStock.BackColor = Color.FromArgb(CByte(84), CByte(122), CByte(70))
        btnStock.FlatAppearance.BorderSize = 0
        btnStock.FlatStyle = FlatStyle.Popup
        btnStock.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnStock.ForeColor = SystemColors.ButtonHighlight
        btnStock.Location = New Point(727, 9)
        btnStock.Name = "btnStock"
        btnStock.Size = New Size(132, 22)
        btnStock.TabIndex = 37
        btnStock.Text = "STOCK OUT"
        btnStock.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(122), CByte(72), CByte(70))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Popup
        btnCancel.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnCancel.ForeColor = SystemColors.ButtonHighlight
        btnCancel.Location = New Point(865, 9)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(132, 22)
        btnCancel.TabIndex = 36
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' cmbBarista
        ' 
        cmbBarista.FormattingEnabled = True
        cmbBarista.Location = New Point(12, 63)
        cmbBarista.Name = "cmbBarista"
        cmbBarista.Size = New Size(181, 23)
        cmbBarista.TabIndex = 35
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.BackColor = Color.Transparent
        lblDate.Font = New Font("Consolas", 9F)
        lblDate.Location = New Point(14, 46)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(0, 14)
        lblDate.TabIndex = 34
        ' 
        ' lblSvisor
        ' 
        lblSvisor.AutoSize = True
        lblSvisor.BackColor = Color.Transparent
        lblSvisor.Font = New Font("Consolas", 9F)
        lblSvisor.Location = New Point(14, 94)
        lblSvisor.Name = "lblSvisor"
        lblSvisor.Size = New Size(126, 14)
        lblSvisor.TabIndex = 33
        lblSvisor.Text = "Shift Supervisor:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Consolas", 9F)
        Label2.Location = New Point(14, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 14)
        Label2.TabIndex = 32
        Label2.Text = "Barista: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(9, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(207, 28)
        Label1.TabIndex = 31
        Label1.Text = "Stock Inventory"
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
        DataGridView1.Location = New Point(204, 40)
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
        DataGridView1.TabIndex = 30
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = Color.FromArgb(CByte(122), CByte(72), CByte(70))
        btnRemove.FlatAppearance.BorderSize = 0
        btnRemove.FlatStyle = FlatStyle.Popup
        btnRemove.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnRemove.ForeColor = SystemColors.ButtonHighlight
        btnRemove.Location = New Point(24, 581)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(152, 22)
        btnRemove.TabIndex = 43
        btnRemove.Text = "REMOVE ITEM"
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(84), CByte(122), CByte(70))
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnAdd.ForeColor = SystemColors.ButtonHighlight
        btnAdd.Location = New Point(24, 555)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(152, 22)
        btnAdd.TabIndex = 42
        btnAdd.Text = "ADD ITEM"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' lstItem
        ' 
        lstItem.FormattingEnabled = True
        lstItem.ItemHeight = 15
        lstItem.Location = New Point(7, 250)
        lstItem.Name = "lstItem"
        lstItem.Size = New Size(186, 244)
        lstItem.TabIndex = 41
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Consolas", 9F)
        Label3.Location = New Point(10, 233)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 14)
        Label3.TabIndex = 40
        Label3.Text = "Item:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Consolas", 9F)
        Label4.Location = New Point(10, 183)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 14)
        Label4.TabIndex = 39
        Label4.Text = "Category:"
        ' 
        ' cmbCategory
        ' 
        cmbCategory.FormattingEnabled = True
        cmbCategory.Location = New Point(7, 200)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(186, 23)
        cmbCategory.TabIndex = 38
        ' 
        ' txtUnit
        ' 
        txtUnit.Location = New Point(103, 516)
        txtUnit.Name = "txtUnit"
        txtUnit.Size = New Size(90, 23)
        txtUnit.TabIndex = 46
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(7, 516)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(99, 23)
        txtQuantity.TabIndex = 45
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Consolas", 9F)
        Label5.Location = New Point(10, 499)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 14)
        Label5.TabIndex = 44
        Label5.Text = "Quantity:"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(7, 144)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(186, 23)
        txtSearch.TabIndex = 47
        ' 
        ' subStockOutRoom
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.mainPanelBg
        ClientSize = New Size(1009, 614)
        Controls.Add(txtSearch)
        Controls.Add(txtUnit)
        Controls.Add(txtQuantity)
        Controls.Add(Label5)
        Controls.Add(btnRemove)
        Controls.Add(btnAdd)
        Controls.Add(lstItem)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(cmbCategory)
        Controls.Add(btnStock)
        Controls.Add(btnCancel)
        Controls.Add(cmbBarista)
        Controls.Add(lblDate)
        Controls.Add(lblSvisor)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "subStockOutRoom"
        StartPosition = FormStartPosition.CenterScreen
        Text = "subStockOutRoom"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnStock As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents cmbBarista As ComboBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblSvisor As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lstItem As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSearch As TextBox
End Class
