<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subOrderReq
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
        btnApprove = New Button()
        btnReject = New Button()
        DataGridView1 = New DataGridView()
        ItemName = New DataGridViewTextBoxColumn()
        Quantity = New DataGridViewTextBoxColumn()
        Category = New DataGridViewTextBoxColumn()
        Price = New DataGridViewTextBoxColumn()
        lblTitle = New Label()
        Label4 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        btnCancel = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnApprove
        ' 
        btnApprove.BackColor = Color.FromArgb(CByte(84), CByte(122), CByte(70))
        btnApprove.FlatAppearance.BorderSize = 0
        btnApprove.FlatStyle = FlatStyle.Popup
        btnApprove.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnApprove.ForeColor = SystemColors.ButtonHighlight
        btnApprove.Location = New Point(553, 9)
        btnApprove.Name = "btnApprove"
        btnApprove.Size = New Size(125, 22)
        btnApprove.TabIndex = 25
        btnApprove.Text = "APPROVE"
        btnApprove.UseVisualStyleBackColor = False
        ' 
        ' btnReject
        ' 
        btnReject.BackColor = Color.FromArgb(CByte(122), CByte(72), CByte(70))
        btnReject.FlatAppearance.BorderSize = 0
        btnReject.FlatStyle = FlatStyle.Popup
        btnReject.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnReject.ForeColor = SystemColors.ButtonHighlight
        btnReject.Location = New Point(553, 35)
        btnReject.Name = "btnReject"
        btnReject.Size = New Size(125, 22)
        btnReject.TabIndex = 24
        btnReject.Text = "REJECT"
        btnReject.UseVisualStyleBackColor = False
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ItemName, Quantity, Category, Price})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(80), CByte(82), CByte(71))
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        DataGridView1.Location = New Point(14, 62)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DataGridView1.Size = New Size(793, 542)
        DataGridView1.TabIndex = 27
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
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(13, 11)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(192, 28)
        lblTitle.TabIndex = 26
        lblTitle.Text = "Order Request"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Consolas", 9F)
        Label4.Location = New Point(17, 40)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 14)
        Label4.TabIndex = 30
        Label4.Text = "Transaction ID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Consolas", 9F)
        Label1.Location = New Point(249, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 14)
        Label1.TabIndex = 29
        Label1.Text = "Date:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Consolas", 9F)
        Label2.Location = New Point(249, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 14)
        Label2.TabIndex = 28
        Label2.Text = "Requested by: "
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(135), CByte(125), CByte(107))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Popup
        btnCancel.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnCancel.ForeColor = SystemColors.ButtonHighlight
        btnCancel.Location = New Point(682, 35)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(125, 22)
        btnCancel.TabIndex = 31
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' subOrderReq
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.mainPanelBg
        ClientSize = New Size(820, 614)
        Controls.Add(btnCancel)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(lblTitle)
        Controls.Add(btnApprove)
        Controls.Add(btnReject)
        MaximizeBox = False
        MinimizeBox = False
        Name = "subOrderReq"
        StartPosition = FormStartPosition.CenterScreen
        Text = "subOrderReq"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnApprove As Button
    Friend WithEvents btnReject As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
End Class
