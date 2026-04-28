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
        Label4 = New Label()
        btnRequest = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(10, 9)
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
        btnCancel.Location = New Point(652, 33)
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
        DataGridView1.Location = New Point(11, 60)
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
        DataGridView1.TabIndex = 19
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.BackColor = Color.Transparent
        lblDate.Font = New Font("Consolas", 9F)
        lblDate.Location = New Point(326, 37)
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
        lblReqBy.Location = New Point(326, 16)
        lblReqBy.Name = "lblReqBy"
        lblReqBy.Size = New Size(105, 14)
        lblReqBy.TabIndex = 20
        lblReqBy.Text = "Requested by: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Consolas", 7.5F)
        Label4.Location = New Point(15, 38)
        Label4.Name = "Label4"
        Label4.Size = New Size(290, 12)
        Label4.TabIndex = 22
        Label4.Text = "*Input 0 in the Quantity field if the item is not needed."
        ' 
        ' btnRequest
        ' 
        btnRequest.BackColor = Color.FromArgb(CByte(84), CByte(122), CByte(70))
        btnRequest.FlatAppearance.BorderSize = 0
        btnRequest.FlatStyle = FlatStyle.Popup
        btnRequest.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnRequest.ForeColor = SystemColors.ButtonHighlight
        btnRequest.Location = New Point(652, 7)
        btnRequest.Name = "btnRequest"
        btnRequest.Size = New Size(152, 22)
        btnRequest.TabIndex = 23
        btnRequest.Text = "CREATE REQUEST"
        btnRequest.UseVisualStyleBackColor = False
        ' 
        ' subCreateReq
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.mainPanelBg
        ClientSize = New Size(820, 614)
        Controls.Add(btnRequest)
        Controls.Add(Label4)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRequest As Button
End Class
