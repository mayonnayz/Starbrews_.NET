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
        DataGridView1 = New DataGridView()
        btnAddAccount = New Button()
        Label1 = New Label()
        btnDeleteAccount = New Button()
        btnEditAccount = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ScrollBar
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(21, 81)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(809, 493)
        DataGridView1.TabIndex = 0
        ' 
        ' btnAddAccount
        ' 
        btnAddAccount.BackColor = Color.DarkKhaki
        btnAddAccount.FlatAppearance.BorderSize = 0
        btnAddAccount.FlatStyle = FlatStyle.Flat
        btnAddAccount.Location = New Point(722, 46)
        btnAddAccount.Name = "btnAddAccount"
        btnAddAccount.Size = New Size(108, 23)
        btnAddAccount.TabIndex = 1
        btnAddAccount.Text = "Add Account"
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
        btnDeleteAccount.BackColor = Color.DarkKhaki
        btnDeleteAccount.FlatAppearance.BorderSize = 0
        btnDeleteAccount.FlatStyle = FlatStyle.Flat
        btnDeleteAccount.Location = New Point(722, 599)
        btnDeleteAccount.Name = "btnDeleteAccount"
        btnDeleteAccount.Size = New Size(108, 23)
        btnDeleteAccount.TabIndex = 3
        btnDeleteAccount.Text = "Archive Account"
        btnDeleteAccount.UseVisualStyleBackColor = False
        ' 
        ' btnEditAccount
        ' 
        btnEditAccount.BackColor = Color.DarkKhaki
        btnEditAccount.FlatAppearance.BorderSize = 0
        btnEditAccount.FlatStyle = FlatStyle.Flat
        btnEditAccount.Location = New Point(602, 599)
        btnEditAccount.Name = "btnEditAccount"
        btnEditAccount.Size = New Size(108, 23)
        btnEditAccount.TabIndex = 4
        btnEditAccount.Text = "Edit Account"
        btnEditAccount.UseVisualStyleBackColor = False
        ' 
        ' tabAccounts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        BackgroundImage = My.Resources.Resources.mainPanelBg
        Controls.Add(btnEditAccount)
        Controls.Add(btnDeleteAccount)
        Controls.Add(Label1)
        Controls.Add(btnAddAccount)
        Controls.Add(DataGridView1)
        Name = "tabAccounts"
        Size = New Size(852, 646)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAddAccount As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDeleteAccount As Button
    Friend WithEvents btnEditAccount As Button

End Class
