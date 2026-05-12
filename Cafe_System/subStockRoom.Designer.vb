<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subStockRoom
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        cmbBarista = New ComboBox()
        lblDate = New Label()
        lblSvisor = New Label()
        Label2 = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        btnStock = New Button()
        btnCancel = New Button()
        Label3 = New Label()
        btnSearch = New Button()
        dtStart = New DateTimePicker()
        Label4 = New Label()
        dtEnd = New DateTimePicker()
        btnAll = New Button()
        ListBox1 = New ListBox()
        Label5 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbBarista
        ' 
        cmbBarista.FormattingEnabled = True
        cmbBarista.Location = New Point(14, 55)
        cmbBarista.Name = "cmbBarista"
        cmbBarista.Size = New Size(187, 23)
        cmbBarista.TabIndex = 26
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.BackColor = Color.Transparent
        lblDate.Font = New Font("Consolas", 9F)
        lblDate.Location = New Point(14, 40)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(0, 14)
        lblDate.TabIndex = 25
        ' 
        ' lblSvisor
        ' 
        lblSvisor.AutoSize = True
        lblSvisor.BackColor = Color.Transparent
        lblSvisor.Font = New Font("Consolas", 9F)
        lblSvisor.Location = New Point(14, 86)
        lblSvisor.Name = "lblSvisor"
        lblSvisor.Size = New Size(126, 14)
        lblSvisor.TabIndex = 24
        lblSvisor.Text = "Shift Supervisor:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Consolas", 9F)
        Label2.Location = New Point(12, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 14)
        Label2.TabIndex = 23
        Label2.Text = "Barista: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(207, 28)
        Label1.TabIndex = 22
        Label1.Text = "Stock Inventory"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(89), CByte(82), CByte(71))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(80), CByte(82), CByte(71))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(220, 40)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.Size = New Size(781, 553)
        DataGridView1.TabIndex = 20
        ' 
        ' btnStock
        ' 
        btnStock.BackColor = Color.FromArgb(CByte(84), CByte(122), CByte(70))
        btnStock.FlatAppearance.BorderSize = 0
        btnStock.FlatStyle = FlatStyle.Popup
        btnStock.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnStock.ForeColor = SystemColors.ButtonHighlight
        btnStock.Location = New Point(731, 11)
        btnStock.Name = "btnStock"
        btnStock.Size = New Size(132, 22)
        btnStock.TabIndex = 28
        btnStock.Text = "STOCK IN"
        btnStock.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(122), CByte(72), CByte(70))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Popup
        btnCancel.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnCancel.ForeColor = SystemColors.ButtonHighlight
        btnCancel.Location = New Point(869, 12)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(132, 22)
        btnCancel.TabIndex = 27
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Consolas", 8F)
        Label3.Location = New Point(14, 141)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 13)
        Label3.TabIndex = 31
        Label3.Text = "Start Date Range:"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(196), CByte(188), CByte(171))
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Popup
        btnSearch.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnSearch.ForeColor = SystemColors.ActiveCaptionText
        btnSearch.Location = New Point(14, 230)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(87, 23)
        btnSearch.TabIndex = 30
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' dtStart
        ' 
        dtStart.CustomFormat = "MMM dd, yyyy"
        dtStart.Format = DateTimePickerFormat.Custom
        dtStart.Location = New Point(14, 155)
        dtStart.Name = "dtStart"
        dtStart.Size = New Size(187, 23)
        dtStart.TabIndex = 29
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Consolas", 8F)
        Label4.Location = New Point(14, 187)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 13)
        Label4.TabIndex = 33
        Label4.Text = "End Date Range:"
        ' 
        ' dtEnd
        ' 
        dtEnd.CustomFormat = "MMM dd, yyyy"
        dtEnd.Format = DateTimePickerFormat.Custom
        dtEnd.Location = New Point(14, 201)
        dtEnd.Name = "dtEnd"
        dtEnd.Size = New Size(187, 23)
        dtEnd.TabIndex = 32
        ' 
        ' btnAll
        ' 
        btnAll.BackColor = Color.FromArgb(CByte(196), CByte(188), CByte(171))
        btnAll.FlatAppearance.BorderSize = 0
        btnAll.FlatStyle = FlatStyle.Popup
        btnAll.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnAll.ForeColor = SystemColors.ActiveCaptionText
        btnAll.Location = New Point(114, 230)
        btnAll.Name = "btnAll"
        btnAll.Size = New Size(87, 23)
        btnAll.TabIndex = 34
        btnAll.Text = "ALL"
        btnAll.UseVisualStyleBackColor = False
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(14, 259)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(187, 334)
        ListBox1.TabIndex = 36
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Consolas", 9F)
        Label5.Location = New Point(220, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(119, 14)
        Label5.TabIndex = 37
        Label5.Text = "Date Requested: "
        ' 
        ' subStockRoom
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.mainPanelBg
        ClientSize = New Size(1013, 607)
        Controls.Add(Label5)
        Controls.Add(ListBox1)
        Controls.Add(btnAll)
        Controls.Add(Label4)
        Controls.Add(dtEnd)
        Controls.Add(Label3)
        Controls.Add(btnSearch)
        Controls.Add(dtStart)
        Controls.Add(btnStock)
        Controls.Add(btnCancel)
        Controls.Add(cmbBarista)
        Controls.Add(lblDate)
        Controls.Add(lblSvisor)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "subStockRoom"
        StartPosition = FormStartPosition.CenterScreen
        Text = "subStockRoom"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbBarista As ComboBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblSvisor As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnStock As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents dtStart As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtEnd As DateTimePicker
    Friend WithEvents btnAll As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label5 As Label
End Class
