<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tabInventory
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
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        btnHistoryStore = New Button()
        DataGridView1 = New DataGridView()
        ItemID = New DataGridViewTextBoxColumn()
        ItemName = New DataGridViewTextBoxColumn()
        Quantity = New DataGridViewTextBoxColumn()
        Category = New DataGridViewTextBoxColumn()
        Price = New DataGridViewTextBoxColumn()
        btnClosingCount = New Button()
        lblDate = New Label()
        TabPage2 = New TabPage()
        btnStockIn = New Button()
        Label1 = New Label()
        btnStockOut = New Button()
        btnHistoryStock = New Button()
        DataGridView2 = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Font = New Font("Lucida Sans Unicode", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(1, 1)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(852, 646)
        TabControl1.TabIndex = 7
        ' 
        ' TabPage1
        ' 
        TabPage1.BackgroundImage = My.Resources.Resources.mainPanelBg
        TabPage1.Controls.Add(btnHistoryStore)
        TabPage1.Controls.Add(DataGridView1)
        TabPage1.Controls.Add(btnClosingCount)
        TabPage1.Controls.Add(lblDate)
        TabPage1.Font = New Font("Segoe UI", 9F)
        TabPage1.Location = New Point(4, 32)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(844, 610)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Store Inventory"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnHistoryStore
        ' 
        btnHistoryStore.BackColor = Color.FromArgb(CByte(165), CByte(161), CByte(141))
        btnHistoryStore.FlatAppearance.BorderSize = 0
        btnHistoryStore.FlatStyle = FlatStyle.Popup
        btnHistoryStore.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnHistoryStore.ForeColor = SystemColors.ButtonHighlight
        btnHistoryStore.Location = New Point(724, 562)
        btnHistoryStore.Name = "btnHistoryStore"
        btnHistoryStore.Size = New Size(102, 23)
        btnHistoryStore.TabIndex = 12
        btnHistoryStore.Text = "VIEW LOGS"
        btnHistoryStore.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(89), CByte(82), CByte(71))
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = SystemColors.Control
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle7.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ItemID, ItemName, Quantity, Category, Price})
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = SystemColors.Window
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle8.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(80), CByte(82), CByte(71))
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        DataGridView1.Location = New Point(17, 60)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = SystemColors.Control
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle9.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        DataGridView1.Size = New Size(809, 493)
        DataGridView1.TabIndex = 8
        ' 
        ' ItemID
        ' 
        ItemID.HeaderText = "Item ID"
        ItemID.Name = "ItemID"
        ' 
        ' ItemName
        ' 
        ItemName.HeaderText = "Item Name"
        ItemName.Name = "ItemName"
        ' 
        ' Quantity
        ' 
        Quantity.HeaderText = "Quantity"
        Quantity.Name = "Quantity"
        ' 
        ' Category
        ' 
        Category.HeaderText = "Category"
        Category.Name = "Category"
        ' 
        ' Price
        ' 
        Price.HeaderText = "Price"
        Price.Name = "Price"
        ' 
        ' btnClosingCount
        ' 
        btnClosingCount.BackColor = Color.FromArgb(CByte(135), CByte(125), CByte(107))
        btnClosingCount.FlatAppearance.BorderSize = 0
        btnClosingCount.FlatStyle = FlatStyle.Popup
        btnClosingCount.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnClosingCount.ForeColor = SystemColors.ButtonHighlight
        btnClosingCount.Location = New Point(641, 31)
        btnClosingCount.Name = "btnClosingCount"
        btnClosingCount.Size = New Size(185, 23)
        btnClosingCount.TabIndex = 9
        btnClosingCount.Text = "ENTER CLOSING INVENTORY"
        btnClosingCount.UseVisualStyleBackColor = False
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.BackColor = Color.Transparent
        lblDate.Location = New Point(17, 9)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(37, 15)
        lblDate.TabIndex = 10
        lblDate.Text = "Date: "
        ' 
        ' TabPage2
        ' 
        TabPage2.BackgroundImage = My.Resources.Resources.mainPanelBg
        TabPage2.Controls.Add(btnStockIn)
        TabPage2.Controls.Add(Label1)
        TabPage2.Controls.Add(btnStockOut)
        TabPage2.Controls.Add(btnHistoryStock)
        TabPage2.Controls.Add(DataGridView2)
        TabPage2.Font = New Font("Segoe UI", 9F)
        TabPage2.Location = New Point(4, 32)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(844, 610)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Stock Room Inventory"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnStockIn
        ' 
        btnStockIn.BackColor = Color.FromArgb(CByte(135), CByte(125), CByte(107))
        btnStockIn.FlatAppearance.BorderSize = 0
        btnStockIn.FlatStyle = FlatStyle.Popup
        btnStockIn.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnStockIn.ForeColor = SystemColors.ButtonHighlight
        btnStockIn.Location = New Point(616, 31)
        btnStockIn.Name = "btnStockIn"
        btnStockIn.Size = New Size(102, 23)
        btnStockIn.TabIndex = 14
        btnStockIn.Text = "STOCK IN"
        btnStockIn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Location = New Point(17, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 15)
        Label1.TabIndex = 11
        Label1.Text = "Date: "
        ' 
        ' btnStockOut
        ' 
        btnStockOut.BackColor = Color.FromArgb(CByte(135), CByte(125), CByte(107))
        btnStockOut.FlatAppearance.BorderSize = 0
        btnStockOut.FlatStyle = FlatStyle.Popup
        btnStockOut.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnStockOut.ForeColor = SystemColors.ButtonHighlight
        btnStockOut.Location = New Point(724, 31)
        btnStockOut.Name = "btnStockOut"
        btnStockOut.Size = New Size(102, 23)
        btnStockOut.TabIndex = 10
        btnStockOut.Text = "STOCK OUT"
        btnStockOut.UseVisualStyleBackColor = False
        ' 
        ' btnHistoryStock
        ' 
        btnHistoryStock.BackColor = Color.FromArgb(CByte(165), CByte(161), CByte(141))
        btnHistoryStock.FlatAppearance.BorderSize = 0
        btnHistoryStock.FlatStyle = FlatStyle.Popup
        btnHistoryStock.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnHistoryStock.ForeColor = SystemColors.ButtonHighlight
        btnHistoryStock.Location = New Point(724, 562)
        btnHistoryStock.Name = "btnHistoryStock"
        btnHistoryStock.Size = New Size(102, 23)
        btnHistoryStock.TabIndex = 13
        btnHistoryStock.Text = "VIEW LOGS"
        btnHistoryStock.UseVisualStyleBackColor = False
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.BackgroundColor = Color.FromArgb(CByte(89), CByte(82), CByte(71))
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = SystemColors.Control
        DataGridViewCellStyle10.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle10.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = DataGridViewTriState.True
        DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5})
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = SystemColors.Window
        DataGridViewCellStyle11.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle11.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.False
        DataGridView2.DefaultCellStyle = DataGridViewCellStyle11
        DataGridView2.Location = New Point(17, 60)
        DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = SystemColors.Control
        DataGridViewCellStyle12.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle12.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True
        DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        DataGridView2.Size = New Size(809, 493)
        DataGridView2.TabIndex = 9
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "Item ID"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "Item Name"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.HeaderText = "Quantity"
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.HeaderText = "Category"
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        ' 
        ' DataGridViewTextBoxColumn5
        ' 
        DataGridViewTextBoxColumn5.HeaderText = "Price"
        DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        ' 
        ' tabInventory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.mainPanelBg
        Controls.Add(TabControl1)
        Name = "tabInventory"
        Size = New Size(852, 646)
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnHistoryStore As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ItemID As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents btnClosingCount As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnStockOut As Button
    Friend WithEvents btnHistoryStock As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents btnStockIn As Button

End Class
