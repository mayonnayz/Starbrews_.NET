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
        DataGridView1 = New DataGridView()
        btnArchiveItem = New Button()
        btnEditItem = New Button()
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
        Label1.Size = New Size(80, 28)
        Label1.TabIndex = 3
        Label1.Text = "Items"
        ' 
        ' btnAddItem
        ' 
        btnAddItem.BackColor = Color.DarkKhaki
        btnAddItem.FlatAppearance.BorderSize = 0
        btnAddItem.FlatStyle = FlatStyle.Flat
        btnAddItem.Location = New Point(728, 59)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(103, 23)
        btnAddItem.TabIndex = 5
        btnAddItem.Text = "Add Item"
        btnAddItem.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ScrollBar
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(22, 94)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(809, 493)
        DataGridView1.TabIndex = 4
        ' 
        ' btnArchiveItem
        ' 
        btnArchiveItem.BackColor = Color.DarkKhaki
        btnArchiveItem.FlatAppearance.BorderSize = 0
        btnArchiveItem.FlatStyle = FlatStyle.Flat
        btnArchiveItem.Location = New Point(728, 603)
        btnArchiveItem.Name = "btnArchiveItem"
        btnArchiveItem.Size = New Size(103, 23)
        btnArchiveItem.TabIndex = 6
        btnArchiveItem.Text = "Archive Item"
        btnArchiveItem.UseVisualStyleBackColor = False
        ' 
        ' btnEditItem
        ' 
        btnEditItem.BackColor = Color.DarkKhaki
        btnEditItem.FlatAppearance.BorderSize = 0
        btnEditItem.FlatStyle = FlatStyle.Flat
        btnEditItem.Location = New Point(593, 603)
        btnEditItem.Name = "btnEditItem"
        btnEditItem.Size = New Size(103, 23)
        btnEditItem.TabIndex = 7
        btnEditItem.Text = "Edit Item"
        btnEditItem.UseVisualStyleBackColor = False
        ' 
        ' tabItems
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.mainPanelBg
        Controls.Add(btnEditItem)
        Controls.Add(btnArchiveItem)
        Controls.Add(btnAddItem)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Name = "tabItems"
        Size = New Size(852, 646)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddItem As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnArchiveItem As Button
    Friend WithEvents btnEditItem As Button

End Class
