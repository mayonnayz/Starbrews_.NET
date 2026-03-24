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
        Label1 = New Label()
        btnAddItem = New Button()
        btnArchiveItem = New Button()
        btnEditItem = New Button()
        ctrItems = New TabControl()
        TabPage1 = New TabPage()
        dgridSpring = New DataGridView()
        ItemNo = New DataGridViewTextBoxColumn()
        ItemName = New DataGridViewTextBoxColumn()
        ItemDescription = New DataGridViewTextBoxColumn()
        TabPage2 = New TabPage()
        dgridSummer = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        TabPage3 = New TabPage()
        dgridFall = New DataGridView()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn()
        TabPage4 = New TabPage()
        dgridWinter = New DataGridView()
        DataGridViewTextBoxColumn7 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn8 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn9 = New DataGridViewTextBoxColumn()
        ComboBox1 = New ComboBox()
        ctrItems.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(dgridSpring, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(dgridSummer, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(dgridFall, ComponentModel.ISupportInitialize).BeginInit()
        TabPage4.SuspendLayout()
        CType(dgridWinter, ComponentModel.ISupportInitialize).BeginInit()
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
        btnAddItem.BackColor = Color.Wheat
        btnAddItem.FlatAppearance.BorderSize = 0
        btnAddItem.FlatStyle = FlatStyle.Popup
        btnAddItem.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddItem.Location = New Point(507, 608)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(103, 23)
        btnAddItem.TabIndex = 5
        btnAddItem.Text = "ADD ITEM"
        btnAddItem.UseVisualStyleBackColor = False
        ' 
        ' btnArchiveItem
        ' 
        btnArchiveItem.BackColor = Color.Wheat
        btnArchiveItem.FlatAppearance.BorderSize = 0
        btnArchiveItem.FlatStyle = FlatStyle.Popup
        btnArchiveItem.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnArchiveItem.Location = New Point(732, 609)
        btnArchiveItem.Name = "btnArchiveItem"
        btnArchiveItem.Size = New Size(103, 23)
        btnArchiveItem.TabIndex = 6
        btnArchiveItem.Text = "ARCHIVE ITEM"
        btnArchiveItem.UseVisualStyleBackColor = False
        ' 
        ' btnEditItem
        ' 
        btnEditItem.BackColor = Color.Wheat
        btnEditItem.FlatAppearance.BorderSize = 0
        btnEditItem.FlatStyle = FlatStyle.Popup
        btnEditItem.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnEditItem.Location = New Point(619, 609)
        btnEditItem.Name = "btnEditItem"
        btnEditItem.Size = New Size(103, 23)
        btnEditItem.TabIndex = 7
        btnEditItem.Text = "EDIT ITEM"
        btnEditItem.UseVisualStyleBackColor = False
        ' 
        ' ctrItems
        ' 
        ctrItems.Controls.Add(TabPage1)
        ctrItems.Controls.Add(TabPage2)
        ctrItems.Controls.Add(TabPage3)
        ctrItems.Controls.Add(TabPage4)
        ctrItems.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ctrItems.Location = New Point(13, 59)
        ctrItems.Name = "ctrItems"
        ctrItems.SelectedIndex = 0
        ctrItems.Size = New Size(826, 542)
        ctrItems.TabIndex = 8
        ' 
        ' TabPage1
        ' 
        TabPage1.BackgroundImage = My.Resources.Resources.sidePanelBg
        TabPage1.Controls.Add(dgridSpring)
        TabPage1.Location = New Point(4, 25)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(818, 513)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Spring"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' dgridSpring
        ' 
        dgridSpring.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgridSpring.BackgroundColor = Color.PapayaWhip
        dgridSpring.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgridSpring.Columns.AddRange(New DataGridViewColumn() {ItemNo, ItemName, ItemDescription})
        dgridSpring.GridColor = Color.Black
        dgridSpring.Location = New Point(6, 6)
        dgridSpring.Name = "dgridSpring"
        dgridSpring.Size = New Size(806, 500)
        dgridSpring.TabIndex = 0
        ' 
        ' ItemNo
        ' 
        ItemNo.HeaderText = "Item No."
        ItemNo.Name = "ItemNo"
        ' 
        ' ItemName
        ' 
        ItemName.HeaderText = "Item Name"
        ItemName.Name = "ItemName"
        ' 
        ' ItemDescription
        ' 
        ItemDescription.HeaderText = "Item Description"
        ItemDescription.Name = "ItemDescription"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackgroundImage = My.Resources.Resources.sidePanelBg
        TabPage2.Controls.Add(dgridSummer)
        TabPage2.Location = New Point(4, 25)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(818, 513)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Summer"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' dgridSummer
        ' 
        dgridSummer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgridSummer.BackgroundColor = Color.PapayaWhip
        dgridSummer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgridSummer.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3})
        dgridSummer.GridColor = Color.Black
        dgridSummer.Location = New Point(6, 6)
        dgridSummer.Name = "dgridSummer"
        dgridSummer.Size = New Size(806, 500)
        dgridSummer.TabIndex = 1
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "Item No."
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "Item Name"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.HeaderText = "Item Description"
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackgroundImage = My.Resources.Resources.sidePanelBg
        TabPage3.Controls.Add(dgridFall)
        TabPage3.Location = New Point(4, 25)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(818, 513)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Fall"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' dgridFall
        ' 
        dgridFall.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgridFall.BackgroundColor = Color.PapayaWhip
        dgridFall.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgridFall.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn6})
        dgridFall.GridColor = Color.Black
        dgridFall.Location = New Point(6, 6)
        dgridFall.Name = "dgridFall"
        dgridFall.Size = New Size(806, 500)
        dgridFall.TabIndex = 1
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.HeaderText = "Item No."
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        ' 
        ' DataGridViewTextBoxColumn5
        ' 
        DataGridViewTextBoxColumn5.HeaderText = "Item Name"
        DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        ' 
        ' DataGridViewTextBoxColumn6
        ' 
        DataGridViewTextBoxColumn6.HeaderText = "Item Description"
        DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        ' 
        ' TabPage4
        ' 
        TabPage4.BackgroundImage = My.Resources.Resources.sidePanelBg
        TabPage4.Controls.Add(dgridWinter)
        TabPage4.Location = New Point(4, 25)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(818, 513)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Winter (Holiday)"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' dgridWinter
        ' 
        dgridWinter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgridWinter.BackgroundColor = Color.PapayaWhip
        dgridWinter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgridWinter.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn7, DataGridViewTextBoxColumn8, DataGridViewTextBoxColumn9})
        dgridWinter.GridColor = Color.Black
        dgridWinter.Location = New Point(6, 6)
        dgridWinter.Name = "dgridWinter"
        dgridWinter.Size = New Size(806, 500)
        dgridWinter.TabIndex = 1
        ' 
        ' DataGridViewTextBoxColumn7
        ' 
        DataGridViewTextBoxColumn7.HeaderText = "Item No."
        DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        ' 
        ' DataGridViewTextBoxColumn8
        ' 
        DataGridViewTextBoxColumn8.HeaderText = "Item Name"
        DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        ' 
        ' DataGridViewTextBoxColumn9
        ' 
        DataGridViewTextBoxColumn9.HeaderText = "Item Description"
        DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(670, 50)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(169, 23)
        ComboBox1.TabIndex = 2
        ' 
        ' tabItems
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.mainPanelBg
        Controls.Add(ComboBox1)
        Controls.Add(btnAddItem)
        Controls.Add(ctrItems)
        Controls.Add(btnEditItem)
        Controls.Add(btnArchiveItem)
        Controls.Add(Label1)
        Name = "tabItems"
        Size = New Size(852, 646)
        ctrItems.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        CType(dgridSpring, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        CType(dgridSummer, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        CType(dgridFall, ComponentModel.ISupportInitialize).EndInit()
        TabPage4.ResumeLayout(False)
        CType(dgridWinter, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnArchiveItem As Button
    Friend WithEvents btnEditItem As Button
    Friend WithEvents ctrItems As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents dgridSpring As DataGridView
    Friend WithEvents ItemNo As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents ItemDescription As DataGridViewTextBoxColumn
    Friend WithEvents dgridSummer As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents dgridFall As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents dgridWinter As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox

End Class
