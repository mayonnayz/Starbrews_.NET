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
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgridAccounts = New DataGridView()
        btnAddAccount = New Button()
        Label1 = New Label()
        btnDeleteAccount = New Button()
        btnEditAccount = New Button()
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
        dgridAccounts.BackgroundColor = Color.PapayaWhip
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Control
        DataGridViewCellStyle5.Font = New Font("Consolas", 10F, FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = Color.SaddleBrown
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgridAccounts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgridAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Window
        DataGridViewCellStyle6.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle6.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = Color.SaddleBrown
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgridAccounts.DefaultCellStyle = DataGridViewCellStyle6
        dgridAccounts.Location = New Point(21, 81)
        dgridAccounts.Name = "dgridAccounts"
        dgridAccounts.Size = New Size(809, 512)
        dgridAccounts.TabIndex = 0
        ' 
        ' btnAddAccount
        ' 
        btnAddAccount.BackColor = Color.Wheat
        btnAddAccount.FlatAppearance.BorderSize = 0
        btnAddAccount.FlatStyle = FlatStyle.Popup
        btnAddAccount.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnAddAccount.Location = New Point(694, 48)
        btnAddAccount.Name = "btnAddAccount"
        btnAddAccount.Size = New Size(136, 22)
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
        ' btnDeleteAccount
        ' 
        btnDeleteAccount.BackColor = Color.Wheat
        btnDeleteAccount.FlatAppearance.BorderSize = 0
        btnDeleteAccount.FlatStyle = FlatStyle.Popup
        btnDeleteAccount.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnDeleteAccount.Location = New Point(678, 605)
        btnDeleteAccount.Name = "btnDeleteAccount"
        btnDeleteAccount.Size = New Size(152, 22)
        btnDeleteAccount.TabIndex = 3
        btnDeleteAccount.Text = "DELETE ACCOUNT"
        btnDeleteAccount.UseVisualStyleBackColor = False
        ' 
        ' btnEditAccount
        ' 
        btnEditAccount.BackColor = Color.Wheat
        btnEditAccount.FlatAppearance.BorderSize = 0
        btnEditAccount.FlatStyle = FlatStyle.Popup
        btnEditAccount.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnEditAccount.Location = New Point(553, 605)
        btnEditAccount.Name = "btnEditAccount"
        btnEditAccount.Size = New Size(119, 22)
        btnEditAccount.TabIndex = 4
        btnEditAccount.Text = "EDIT ACCOUNT"
        btnEditAccount.UseVisualStyleBackColor = False
        ' 
        ' btnArchives
        ' 
        btnArchives.BackColor = Color.Tan
        btnArchives.FlatAppearance.BorderSize = 0
        btnArchives.FlatStyle = FlatStyle.Popup
        btnArchives.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnArchives.Location = New Point(21, 605)
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
        btnSearch.BackColor = Color.Wheat
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Popup
        btnSearch.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnSearch.Location = New Point(342, 46)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(77, 22)
        btnSearch.TabIndex = 7
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' cmbSearch
        ' 
        cmbSearch.Font = New Font("Consolas", 9F)
        cmbSearch.FormattingEnabled = True
        cmbSearch.Items.AddRange(New Object() {"All", "Barista", "Shift Supervisor", "Store Manager", "Super Admin"})
        cmbSearch.Location = New Point(198, 47)
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
        Controls.Add(btnEditAccount)
        Controls.Add(btnDeleteAccount)
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
    Friend WithEvents btnDeleteAccount As Button
    Friend WithEvents btnEditAccount As Button
    Friend WithEvents btnArchives As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents cmbSearch As ComboBox

End Class
