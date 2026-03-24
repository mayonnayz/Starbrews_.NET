<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tabAccounts
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
        dgridAccounts = New DataGridView()
        btnAddAccount = New Button()
        Label1 = New Label()
        btnArchives = New Button()
        txtSearch = New TextBox()
        btnSearch = New Button()
        cmbSearch = New ComboBox()
        CType(dgridAccounts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgridAccounts
        ' 
        dgridAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgridAccounts.BackgroundColor = Color.FromArgb(CByte(89), CByte(82), CByte(71))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Consolas", 10F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgridAccounts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgridAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(80), CByte(82), CByte(71))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgridAccounts.DefaultCellStyle = DataGridViewCellStyle2
        dgridAccounts.Location = New Point(21, 81)
        dgridAccounts.Name = "dgridAccounts"
        dgridAccounts.Size = New Size(809, 541)
        dgridAccounts.TabIndex = 0
        ' 
        ' btnAddAccount
        ' 
        btnAddAccount.BackColor = Color.FromArgb(CByte(165), CByte(161), CByte(141))
        btnAddAccount.FlatAppearance.BorderSize = 0
        btnAddAccount.FlatStyle = FlatStyle.Popup
        btnAddAccount.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnAddAccount.ForeColor = SystemColors.ButtonHighlight
        btnAddAccount.Location = New Point(492, 48)
        btnAddAccount.Name = "btnAddAccount"
        btnAddAccount.Size = New Size(125, 22)
        btnAddAccount.TabIndex = 1
        btnAddAccount.Text = "ADD ACCOUNT"
        btnAddAccount.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(13, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 28)
        Label1.TabIndex = 2
        Label1.Text = "Accounts"
        ' 
        ' btnArchives
        ' 
        btnArchives.BackColor = Color.FromArgb(CByte(135), CByte(125), CByte(107))
        btnArchives.FlatAppearance.BorderSize = 0
        btnArchives.FlatStyle = FlatStyle.Popup
        btnArchives.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnArchives.ForeColor = SystemColors.ButtonHighlight
        btnArchives.Location = New Point(623, 48)
        btnArchives.Name = "btnArchives"
        btnArchives.Size = New Size(207, 22)
        btnArchives.TabIndex = 5
        btnArchives.Text = "VIEW ARCHIVED ACCOUNTS"
        btnArchives.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Consolas", 9F)
        txtSearch.Location = New Point(21, 48)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(171, 22)
        txtSearch.TabIndex = 6
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(165), CByte(161), CByte(141))
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Popup
        btnSearch.Font = New Font("Microsoft Sans Serif", 9F)
        btnSearch.ForeColor = SystemColors.ButtonHighlight
        btnSearch.Location = New Point(338, 48)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(30, 22)
        btnSearch.TabIndex = 7
        btnSearch.Text = "🔍︎"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' cmbSearch
        ' 
        cmbSearch.Font = New Font("Consolas", 9F)
        cmbSearch.FormattingEnabled = True
        cmbSearch.Items.AddRange(New Object() {"All", "Barista", "Shift Supervisor", "Store Manager", "Super Admin"})
        cmbSearch.Location = New Point(196, 48)
        cmbSearch.Name = "cmbSearch"
        cmbSearch.Size = New Size(138, 22)
        cmbSearch.TabIndex = 8
        ' 
        ' tabAccounts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        BackgroundImage = My.Resources.Resources.mainPanelBg
        Controls.Add(cmbSearch)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(btnArchives)
        Controls.Add(Label1)
        Controls.Add(btnAddAccount)
        Controls.Add(dgridAccounts)
        Name = "tabAccounts"
        Size = New Size(852, 646)
        CType(dgridAccounts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgridAccounts As DataGridView
    Friend WithEvents btnAddAccount As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnArchives As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents cmbSearch As ComboBox

End Class
