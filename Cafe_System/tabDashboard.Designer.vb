<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tabDashboard
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
        Label4 = New Label()
        Label3 = New Label()
        dtEnd = New DateTimePicker()
        btnSearchDate = New Button()
        btnAll = New Button()
        dtStart = New DateTimePicker()
        lblDate = New Label()
        Label1 = New Label()
        dgridFast = New DataGridView()
        dgridSlow = New DataGridView()
        btnPrint = New Button()
        Label2 = New Label()
        Label5 = New Label()
        CType(dgridFast, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgridSlow, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Consolas", 8F)
        Label4.Location = New Point(173, 78)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 13)
        Label4.TabIndex = 28
        Label4.Text = "End Date Range:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Consolas", 8F)
        Label3.Location = New Point(20, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 13)
        Label3.TabIndex = 27
        Label3.Text = "Start Date Range:"
        ' 
        ' dtEnd
        ' 
        dtEnd.CustomFormat = "MMM dd, yyyy"
        dtEnd.Format = DateTimePickerFormat.Custom
        dtEnd.Location = New Point(173, 92)
        dtEnd.Name = "dtEnd"
        dtEnd.Size = New Size(148, 23)
        dtEnd.TabIndex = 26
        ' 
        ' btnSearchDate
        ' 
        btnSearchDate.BackColor = Color.FromArgb(CByte(196), CByte(188), CByte(171))
        btnSearchDate.FlatAppearance.BorderSize = 0
        btnSearchDate.FlatStyle = FlatStyle.Popup
        btnSearchDate.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnSearchDate.ForeColor = SystemColors.ButtonHighlight
        btnSearchDate.Location = New Point(328, 92)
        btnSearchDate.Name = "btnSearchDate"
        btnSearchDate.Size = New Size(38, 23)
        btnSearchDate.TabIndex = 25
        btnSearchDate.Text = "🔍︎"
        btnSearchDate.UseVisualStyleBackColor = False
        ' 
        ' btnAll
        ' 
        btnAll.BackColor = Color.FromArgb(CByte(196), CByte(188), CByte(171))
        btnAll.FlatAppearance.BorderSize = 0
        btnAll.FlatStyle = FlatStyle.Popup
        btnAll.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnAll.ForeColor = SystemColors.ButtonHighlight
        btnAll.Location = New Point(371, 92)
        btnAll.Name = "btnAll"
        btnAll.Size = New Size(55, 23)
        btnAll.TabIndex = 24
        btnAll.Text = "ALL"
        btnAll.UseVisualStyleBackColor = False
        ' 
        ' dtStart
        ' 
        dtStart.CustomFormat = "MMM dd, yyyy"
        dtStart.Format = DateTimePickerFormat.Custom
        dtStart.Location = New Point(20, 92)
        dtStart.Name = "dtStart"
        dtStart.Size = New Size(148, 23)
        dtStart.TabIndex = 23
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.BackColor = Color.Transparent
        lblDate.Font = New Font("Segoe UI", 10F)
        lblDate.Location = New Point(19, 48)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(45, 19)
        lblDate.TabIndex = 29
        lblDate.Text = "Date: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(13, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(427, 28)
        Label1.TabIndex = 30
        Label1.Text = "Starbrews Inventory Performance"
        ' 
        ' dgridFast
        ' 
        dgridFast.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgridFast.BackgroundColor = Color.FromArgb(CByte(89), CByte(82), CByte(71))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgridFast.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgridFast.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(80), CByte(82), CByte(71))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgridFast.DefaultCellStyle = DataGridViewCellStyle2
        dgridFast.Location = New Point(13, 162)
        dgridFast.Name = "dgridFast"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgridFast.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgridFast.Size = New Size(409, 471)
        dgridFast.TabIndex = 31
        ' 
        ' dgridSlow
        ' 
        dgridSlow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgridSlow.BackgroundColor = Color.FromArgb(CByte(89), CByte(82), CByte(71))
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgridSlow.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgridSlow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(80), CByte(82), CByte(71))
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgridSlow.DefaultCellStyle = DataGridViewCellStyle5
        dgridSlow.Location = New Point(428, 162)
        dgridSlow.Name = "dgridSlow"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgridSlow.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgridSlow.Size = New Size(409, 471)
        dgridSlow.TabIndex = 32
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.FromArgb(CByte(200), CByte(200), CByte(180))
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnPrint.Location = New Point(694, 92)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(143, 23)
        btnPrint.TabIndex = 33
        btnPrint.Text = "PRINT SUMMARY"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Consolas", 14F, FontStyle.Bold)
        Label2.Location = New Point(71, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(250, 22)
        Label2.TabIndex = 34
        Label2.Text = "Top 10 Fast Moving Items"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Consolas", 14F, FontStyle.Bold)
        Label5.Location = New Point(499, 137)
        Label5.Name = "Label5"
        Label5.Size = New Size(250, 22)
        Label5.TabIndex = 35
        Label5.Text = "Top 10 Slow Moving Items"
        ' 
        ' tabDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RosyBrown
        BackgroundImage = My.Resources.Resources.mainPanelBg
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(btnPrint)
        Controls.Add(dgridSlow)
        Controls.Add(dgridFast)
        Controls.Add(Label1)
        Controls.Add(lblDate)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(dtEnd)
        Controls.Add(btnSearchDate)
        Controls.Add(btnAll)
        Controls.Add(dtStart)
        Name = "tabDashboard"
        Size = New Size(852, 646)
        CType(dgridFast, ComponentModel.ISupportInitialize).EndInit()
        CType(dgridSlow, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtEnd As DateTimePicker
    Friend WithEvents btnSearchDate As Button
    Friend WithEvents btnAll As Button
    Friend WithEvents dtStart As DateTimePicker
    Friend WithEvents lblDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgridFast As DataGridView
    Friend WithEvents dgridSlow As DataGridView
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label

End Class
