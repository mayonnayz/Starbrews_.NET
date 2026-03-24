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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        btnHistoryStore.BackColor = Color.Linen
        btnHistoryStore.FlatAppearance.BorderSize = 0
        btnHistoryStore.FlatStyle = FlatStyle.Popup
        btnHistoryStore.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
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
        DataGridView1.BackgroundColor = Color.SeaShell
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ItemID, ItemName, Quantity, Category, Price})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(17, 60)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
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
        btnClosingCount.BackColor = Color.Linen
        btnClosingCount.FlatAppearance.BorderSize = 0
        btnClosingCount.FlatStyle = FlatStyle.Popup
        btnClosingCount.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
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
        btnStockIn.BackColor = Color.Linen
        btnStockIn.FlatAppearance.BorderSize = 0
        btnStockIn.FlatStyle = FlatStyle.Popup
        btnStockIn.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
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
        btnStockOut.BackColor = Color.Linen
        btnStockOut.FlatAppearance.BorderSize = 0
        btnStockOut.FlatStyle = FlatStyle.Popup
        btnStockOut.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnStockOut.Location = New Point(724, 31)
        btnStockOut.Name = "btnStockOut"
        btnStockOut.Size = New Size(102, 23)
        btnStockOut.TabIndex = 10
        btnStockOut.Text = "STOCK OUT"
        btnStockOut.UseVisualStyleBackColor = False
        ' 
        ' btnHistoryStock
        ' 
        btnHistoryStock.BackColor = Color.Linen
        btnHistoryStock.FlatAppearance.BorderSize = 0
        btnHistoryStock.FlatStyle = FlatStyle.Popup
        btnHistoryStock.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
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
        DataGridView2.BackgroundColor = Color.SeaShell
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        DataGridView2.DefaultCellStyle = DataGridViewCellStyle5
        DataGridView2.Location = New Point(17, 60)
        DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
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
