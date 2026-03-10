<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tabOrderRequests
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
        DataGridView1 = New DataGridView()
        ListBox1 = New ListBox()
        Label2 = New Label()
        btnAddSupplier = New Button()
        btnArchiveSupplier = New Button()
        btnEditSupplier = New Button()
        btnCreateRequest = New Button()
        btnViewRequest = New Button()
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
        Label1.Size = New Size(205, 28)
        Label1.TabIndex = 4
        Label1.Text = "Order Requests"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ScrollBar
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(13, 93)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(510, 493)
        DataGridView1.TabIndex = 5
        ' 
        ' ListBox1
        ' 
        ListBox1.BorderStyle = BorderStyle.FixedSingle
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(529, 92)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(308, 497)
        ListBox1.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(529, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(272, 28)
        Label2.TabIndex = 7
        Label2.Text = "Supplier Information"
        ' 
        ' btnAddSupplier
        ' 
        btnAddSupplier.BackColor = Color.DarkKhaki
        btnAddSupplier.FlatAppearance.BorderSize = 0
        btnAddSupplier.FlatStyle = FlatStyle.Flat
        btnAddSupplier.Location = New Point(734, 63)
        btnAddSupplier.Name = "btnAddSupplier"
        btnAddSupplier.Size = New Size(103, 23)
        btnAddSupplier.TabIndex = 8
        btnAddSupplier.Text = "Add Supplier"
        btnAddSupplier.UseVisualStyleBackColor = False
        ' 
        ' btnArchiveSupplier
        ' 
        btnArchiveSupplier.BackColor = Color.DarkKhaki
        btnArchiveSupplier.FlatAppearance.BorderSize = 0
        btnArchiveSupplier.FlatStyle = FlatStyle.Flat
        btnArchiveSupplier.Location = New Point(734, 601)
        btnArchiveSupplier.Name = "btnArchiveSupplier"
        btnArchiveSupplier.Size = New Size(103, 23)
        btnArchiveSupplier.TabIndex = 9
        btnArchiveSupplier.Text = "Archive Supplier"
        btnArchiveSupplier.UseVisualStyleBackColor = False
        ' 
        ' btnEditSupplier
        ' 
        btnEditSupplier.BackColor = Color.DarkKhaki
        btnEditSupplier.FlatAppearance.BorderSize = 0
        btnEditSupplier.FlatStyle = FlatStyle.Flat
        btnEditSupplier.Location = New Point(612, 601)
        btnEditSupplier.Name = "btnEditSupplier"
        btnEditSupplier.Size = New Size(103, 23)
        btnEditSupplier.TabIndex = 10
        btnEditSupplier.Text = "Edit Supplier"
        btnEditSupplier.UseVisualStyleBackColor = False
        ' 
        ' btnCreateRequest
        ' 
        btnCreateRequest.BackColor = Color.DarkKhaki
        btnCreateRequest.FlatAppearance.BorderSize = 0
        btnCreateRequest.FlatStyle = FlatStyle.Flat
        btnCreateRequest.Location = New Point(15, 60)
        btnCreateRequest.Name = "btnCreateRequest"
        btnCreateRequest.Size = New Size(141, 23)
        btnCreateRequest.TabIndex = 11
        btnCreateRequest.Text = "Create Order Request"
        btnCreateRequest.UseVisualStyleBackColor = False
        ' 
        ' btnViewRequest
        ' 
        btnViewRequest.BackColor = Color.DarkKhaki
        btnViewRequest.FlatAppearance.BorderSize = 0
        btnViewRequest.FlatStyle = FlatStyle.Flat
        btnViewRequest.Location = New Point(13, 601)
        btnViewRequest.Name = "btnViewRequest"
        btnViewRequest.Size = New Size(141, 23)
        btnViewRequest.TabIndex = 12
        btnViewRequest.Text = "View Order Request"
        btnViewRequest.UseVisualStyleBackColor = False
        ' 
        ' tabOrderRequests
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.mainPanelBg
        Controls.Add(btnViewRequest)
        Controls.Add(btnCreateRequest)
        Controls.Add(btnEditSupplier)
        Controls.Add(btnArchiveSupplier)
        Controls.Add(btnAddSupplier)
        Controls.Add(Label2)
        Controls.Add(ListBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Name = "tabOrderRequests"
        Size = New Size(852, 646)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddSupplier As Button
    Friend WithEvents btnArchiveSupplier As Button
    Friend WithEvents btnEditSupplier As Button
    Friend WithEvents btnCreateRequest As Button
    Friend WithEvents btnViewRequest As Button

End Class
