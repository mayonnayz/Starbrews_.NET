<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subStoLogs
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
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        btnAllIn = New Button()
        lstIn = New ListBox()
        dtIn = New DateTimePicker()
        lblTransacIn = New Label()
        dgridIn = New DataGridView()
        lblDateIn = New Label()
        lblSuperIn = New Label()
        lblBaristaIn = New Label()
        TabPage2 = New TabPage()
        btnAllOut = New Button()
        lstOut = New ListBox()
        dgridOut = New DataGridView()
        dtOut = New DateTimePicker()
        lblBaristaOut = New Label()
        lblTransacOut = New Label()
        lblSuperOut = New Label()
        lblDateOut = New Label()
        TabPage3 = New TabPage()
        lblStatus = New Label()
        dgridDisc = New DataGridView()
        lstDisc = New ListBox()
        btnAllDisc = New Button()
        btnPrint = New Button()
        Label4 = New Label()
        btnReorder = New Button()
        dtEnd = New DateTimePicker()
        dtStart = New DateTimePicker()
        Label3 = New Label()
        btnSearch = New Button()
        lblBaristaDisc = New Label()
        lblTransacDisc = New Label()
        lblSuperDisc = New Label()
        lblDateDisc = New Label()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(dgridIn, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(dgridOut, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(dgridDisc, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Font = New Font("Lucida Sans Unicode", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(12, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(796, 590)
        TabControl1.TabIndex = 8
        ' 
        ' TabPage1
        ' 
        TabPage1.BackgroundImage = My.Resources.Resources.mainPanelBg
        TabPage1.Controls.Add(btnAllIn)
        TabPage1.Controls.Add(lstIn)
        TabPage1.Controls.Add(dtIn)
        TabPage1.Controls.Add(lblTransacIn)
        TabPage1.Controls.Add(dgridIn)
        TabPage1.Controls.Add(lblDateIn)
        TabPage1.Controls.Add(lblSuperIn)
        TabPage1.Controls.Add(lblBaristaIn)
        TabPage1.Font = New Font("Segoe UI", 9F)
        TabPage1.Location = New Point(4, 32)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(788, 554)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Stock In"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnAllIn
        ' 
        btnAllIn.BackColor = Color.FromArgb(CByte(196), CByte(188), CByte(171))
        btnAllIn.FlatAppearance.BorderSize = 0
        btnAllIn.FlatStyle = FlatStyle.Popup
        btnAllIn.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnAllIn.ForeColor = SystemColors.ActiveCaptionText
        btnAllIn.Location = New Point(109, 51)
        btnAllIn.Name = "btnAllIn"
        btnAllIn.Size = New Size(42, 23)
        btnAllIn.TabIndex = 47
        btnAllIn.Text = "ALL"
        btnAllIn.UseVisualStyleBackColor = False
        ' 
        ' lstIn
        ' 
        lstIn.FormattingEnabled = True
        lstIn.ItemHeight = 15
        lstIn.Location = New Point(5, 80)
        lstIn.Name = "lstIn"
        lstIn.Size = New Size(146, 469)
        lstIn.TabIndex = 26
        ' 
        ' dtIn
        ' 
        dtIn.CustomFormat = "MMM dd, yyyy"
        dtIn.Format = DateTimePickerFormat.Custom
        dtIn.Location = New Point(6, 51)
        dtIn.Name = "dtIn"
        dtIn.Size = New Size(97, 23)
        dtIn.TabIndex = 25
        ' 
        ' lblTransacIn
        ' 
        lblTransacIn.AutoSize = True
        lblTransacIn.BackColor = Color.Transparent
        lblTransacIn.Font = New Font("Consolas", 9F)
        lblTransacIn.Location = New Point(428, 30)
        lblTransacIn.Name = "lblTransacIn"
        lblTransacIn.Size = New Size(112, 14)
        lblTransacIn.TabIndex = 24
        lblTransacIn.Text = "Transaction ID:"
        ' 
        ' dgridIn
        ' 
        dgridIn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgridIn.BackgroundColor = Color.FromArgb(CByte(89), CByte(82), CByte(71))
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = SystemColors.Control
        DataGridViewCellStyle10.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle10.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle10.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle10.WrapMode = DataGridViewTriState.True
        dgridIn.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        dgridIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = SystemColors.Window
        DataGridViewCellStyle11.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle11.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(CByte(80), CByte(82), CByte(71))
        DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.False
        dgridIn.DefaultCellStyle = DataGridViewCellStyle11
        dgridIn.Location = New Point(157, 52)
        dgridIn.Name = "dgridIn"
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = SystemColors.Control
        DataGridViewCellStyle12.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle12.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True
        dgridIn.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        dgridIn.Size = New Size(625, 497)
        dgridIn.TabIndex = 11
        ' 
        ' lblDateIn
        ' 
        lblDateIn.AutoSize = True
        lblDateIn.BackColor = Color.Transparent
        lblDateIn.Font = New Font("Consolas", 9F)
        lblDateIn.Location = New Point(428, 9)
        lblDateIn.Name = "lblDateIn"
        lblDateIn.Size = New Size(77, 14)
        lblDateIn.TabIndex = 23
        lblDateIn.Text = "Date/Time:"
        ' 
        ' lblSuperIn
        ' 
        lblSuperIn.AutoSize = True
        lblSuperIn.BackColor = Color.Transparent
        lblSuperIn.Font = New Font("Consolas", 9F)
        lblSuperIn.Location = New Point(157, 30)
        lblSuperIn.Name = "lblSuperIn"
        lblSuperIn.Size = New Size(91, 14)
        lblSuperIn.TabIndex = 22
        lblSuperIn.Text = "Supervisor: "
        ' 
        ' lblBaristaIn
        ' 
        lblBaristaIn.AutoSize = True
        lblBaristaIn.BackColor = Color.Transparent
        lblBaristaIn.Font = New Font("Consolas", 9F)
        lblBaristaIn.Location = New Point(157, 9)
        lblBaristaIn.Name = "lblBaristaIn"
        lblBaristaIn.Size = New Size(70, 14)
        lblBaristaIn.TabIndex = 21
        lblBaristaIn.Text = "Barista: "
        ' 
        ' TabPage2
        ' 
        TabPage2.BackgroundImage = My.Resources.Resources.mainPanelBg
        TabPage2.Controls.Add(btnAllOut)
        TabPage2.Controls.Add(lstOut)
        TabPage2.Controls.Add(dgridOut)
        TabPage2.Controls.Add(dtOut)
        TabPage2.Controls.Add(lblBaristaOut)
        TabPage2.Controls.Add(lblTransacOut)
        TabPage2.Controls.Add(lblSuperOut)
        TabPage2.Controls.Add(lblDateOut)
        TabPage2.Font = New Font("Segoe UI", 9F)
        TabPage2.Location = New Point(4, 32)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(788, 554)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Stock Out"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnAllOut
        ' 
        btnAllOut.BackColor = Color.FromArgb(CByte(196), CByte(188), CByte(171))
        btnAllOut.FlatAppearance.BorderSize = 0
        btnAllOut.FlatStyle = FlatStyle.Popup
        btnAllOut.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnAllOut.ForeColor = SystemColors.ActiveCaptionText
        btnAllOut.Location = New Point(109, 52)
        btnAllOut.Name = "btnAllOut"
        btnAllOut.Size = New Size(42, 23)
        btnAllOut.TabIndex = 48
        btnAllOut.Text = "ALL"
        btnAllOut.UseVisualStyleBackColor = False
        ' 
        ' lstOut
        ' 
        lstOut.FormattingEnabled = True
        lstOut.ItemHeight = 15
        lstOut.Location = New Point(5, 80)
        lstOut.Name = "lstOut"
        lstOut.Size = New Size(146, 469)
        lstOut.TabIndex = 33
        ' 
        ' dgridOut
        ' 
        dgridOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgridOut.BackgroundColor = Color.FromArgb(CByte(89), CByte(82), CByte(71))
        DataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = SystemColors.Control
        DataGridViewCellStyle13.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle13.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle13.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle13.WrapMode = DataGridViewTriState.True
        dgridOut.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        dgridOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = SystemColors.Window
        DataGridViewCellStyle14.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle14.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(CByte(80), CByte(82), CByte(71))
        DataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = DataGridViewTriState.False
        dgridOut.DefaultCellStyle = DataGridViewCellStyle14
        dgridOut.Location = New Point(157, 52)
        dgridOut.Name = "dgridOut"
        DataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = SystemColors.Control
        DataGridViewCellStyle15.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle15.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = DataGridViewTriState.True
        dgridOut.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        dgridOut.Size = New Size(625, 497)
        dgridOut.TabIndex = 27
        ' 
        ' dtOut
        ' 
        dtOut.CustomFormat = "MMM dd, yyyy"
        dtOut.Format = DateTimePickerFormat.Custom
        dtOut.Location = New Point(6, 51)
        dtOut.Name = "dtOut"
        dtOut.Size = New Size(97, 23)
        dtOut.TabIndex = 32
        ' 
        ' lblBaristaOut
        ' 
        lblBaristaOut.AutoSize = True
        lblBaristaOut.BackColor = Color.Transparent
        lblBaristaOut.Font = New Font("Consolas", 9F)
        lblBaristaOut.Location = New Point(157, 9)
        lblBaristaOut.Name = "lblBaristaOut"
        lblBaristaOut.Size = New Size(70, 14)
        lblBaristaOut.TabIndex = 28
        lblBaristaOut.Text = "Barista: "
        ' 
        ' lblTransacOut
        ' 
        lblTransacOut.AutoSize = True
        lblTransacOut.BackColor = Color.Transparent
        lblTransacOut.Font = New Font("Consolas", 9F)
        lblTransacOut.Location = New Point(428, 30)
        lblTransacOut.Name = "lblTransacOut"
        lblTransacOut.Size = New Size(112, 14)
        lblTransacOut.TabIndex = 31
        lblTransacOut.Text = "Transaction ID:"
        ' 
        ' lblSuperOut
        ' 
        lblSuperOut.AutoSize = True
        lblSuperOut.BackColor = Color.Transparent
        lblSuperOut.Font = New Font("Consolas", 9F)
        lblSuperOut.Location = New Point(157, 30)
        lblSuperOut.Name = "lblSuperOut"
        lblSuperOut.Size = New Size(91, 14)
        lblSuperOut.TabIndex = 29
        lblSuperOut.Text = "Supervisor: "
        ' 
        ' lblDateOut
        ' 
        lblDateOut.AutoSize = True
        lblDateOut.BackColor = Color.Transparent
        lblDateOut.Font = New Font("Consolas", 9F)
        lblDateOut.Location = New Point(428, 9)
        lblDateOut.Name = "lblDateOut"
        lblDateOut.Size = New Size(77, 14)
        lblDateOut.TabIndex = 30
        lblDateOut.Text = "Date/Time:"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackgroundImage = My.Resources.Resources.mainPanelBg
        TabPage3.Controls.Add(lblStatus)
        TabPage3.Controls.Add(dgridDisc)
        TabPage3.Controls.Add(lstDisc)
        TabPage3.Controls.Add(btnAllDisc)
        TabPage3.Controls.Add(btnPrint)
        TabPage3.Controls.Add(Label4)
        TabPage3.Controls.Add(btnReorder)
        TabPage3.Controls.Add(dtEnd)
        TabPage3.Controls.Add(dtStart)
        TabPage3.Controls.Add(Label3)
        TabPage3.Controls.Add(btnSearch)
        TabPage3.Location = New Point(4, 32)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(788, 554)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Discrepancies"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.BackColor = Color.Transparent
        lblStatus.Font = New Font("Consolas", 9F)
        lblStatus.Location = New Point(697, 10)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(56, 14)
        lblStatus.TabIndex = 39
        lblStatus.Text = "Status:"
        ' 
        ' dgridDisc
        ' 
        dgridDisc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgridDisc.BackgroundColor = Color.FromArgb(CByte(89), CByte(82), CByte(71))
        DataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = SystemColors.Control
        DataGridViewCellStyle16.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle16.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle16.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle16.WrapMode = DataGridViewTriState.True
        dgridDisc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        dgridDisc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = SystemColors.Window
        DataGridViewCellStyle17.Font = New Font("Consolas", 9F)
        DataGridViewCellStyle17.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle17.SelectionBackColor = Color.FromArgb(CByte(80), CByte(82), CByte(71))
        DataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = DataGridViewTriState.False
        dgridDisc.DefaultCellStyle = DataGridViewCellStyle17
        dgridDisc.Location = New Point(157, 50)
        dgridDisc.Name = "dgridDisc"
        DataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = SystemColors.Control
        DataGridViewCellStyle18.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle18.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = DataGridViewTriState.True
        dgridDisc.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        dgridDisc.Size = New Size(625, 497)
        dgridDisc.TabIndex = 47
        ' 
        ' lstDisc
        ' 
        lstDisc.Font = New Font("Segoe UI", 9F)
        lstDisc.FormattingEnabled = True
        lstDisc.ItemHeight = 15
        lstDisc.Location = New Point(6, 194)
        lstDisc.Name = "lstDisc"
        lstDisc.Size = New Size(146, 349)
        lstDisc.TabIndex = 39
        ' 
        ' btnAllDisc
        ' 
        btnAllDisc.BackColor = Color.FromArgb(CByte(196), CByte(188), CByte(171))
        btnAllDisc.FlatAppearance.BorderSize = 0
        btnAllDisc.FlatStyle = FlatStyle.Popup
        btnAllDisc.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnAllDisc.ForeColor = SystemColors.ActiveCaptionText
        btnAllDisc.Location = New Point(82, 159)
        btnAllDisc.Name = "btnAllDisc"
        btnAllDisc.Size = New Size(70, 23)
        btnAllDisc.TabIndex = 46
        btnAllDisc.Text = "ALL"
        btnAllDisc.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.FromArgb(CByte(200), CByte(200), CByte(180))
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnPrint.Location = New Point(8, 6)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(143, 23)
        btnPrint.TabIndex = 1
        btnPrint.Text = "PRINT SUMMARY"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Consolas", 8F)
        Label4.Location = New Point(6, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 13)
        Label4.TabIndex = 45
        Label4.Text = "End Date Range:"
        ' 
        ' btnReorder
        ' 
        btnReorder.BackColor = Color.FromArgb(CByte(196), CByte(188), CByte(171))
        btnReorder.FlatStyle = FlatStyle.Flat
        btnReorder.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnReorder.Location = New Point(8, 32)
        btnReorder.Name = "btnReorder"
        btnReorder.Size = New Size(143, 23)
        btnReorder.TabIndex = 0
        btnReorder.Text = "REORDER"
        btnReorder.UseVisualStyleBackColor = False
        ' 
        ' dtEnd
        ' 
        dtEnd.CustomFormat = "MMM dd, yyyy"
        dtEnd.Font = New Font("Segoe UI", 9F)
        dtEnd.Format = DateTimePickerFormat.Custom
        dtEnd.Location = New Point(6, 128)
        dtEnd.Name = "dtEnd"
        dtEnd.Size = New Size(145, 23)
        dtEnd.TabIndex = 44
        ' 
        ' dtStart
        ' 
        dtStart.CustomFormat = "MMM dd, yyyy"
        dtStart.Font = New Font("Segoe UI", 9F)
        dtStart.Format = DateTimePickerFormat.Custom
        dtStart.Location = New Point(6, 84)
        dtStart.Name = "dtStart"
        dtStart.Size = New Size(146, 23)
        dtStart.TabIndex = 41
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Consolas", 8F)
        Label3.Location = New Point(6, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 13)
        Label3.TabIndex = 43
        Label3.Text = "Start Date Range:"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(196), CByte(188), CByte(171))
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Popup
        btnSearch.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnSearch.ForeColor = SystemColors.ActiveCaptionText
        btnSearch.Location = New Point(6, 159)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(70, 23)
        btnSearch.TabIndex = 42
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' lblBaristaDisc
        ' 
        lblBaristaDisc.AutoSize = True
        lblBaristaDisc.BackColor = Color.Transparent
        lblBaristaDisc.Font = New Font("Consolas", 9F)
        lblBaristaDisc.Location = New Point(174, 54)
        lblBaristaDisc.Name = "lblBaristaDisc"
        lblBaristaDisc.Size = New Size(70, 14)
        lblBaristaDisc.TabIndex = 35
        lblBaristaDisc.Text = "Barista: "
        ' 
        ' lblTransacDisc
        ' 
        lblTransacDisc.AutoSize = True
        lblTransacDisc.BackColor = Color.Transparent
        lblTransacDisc.Font = New Font("Consolas", 9F)
        lblTransacDisc.Location = New Point(434, 75)
        lblTransacDisc.Name = "lblTransacDisc"
        lblTransacDisc.Size = New Size(112, 14)
        lblTransacDisc.TabIndex = 38
        lblTransacDisc.Text = "Transaction ID:"
        ' 
        ' lblSuperDisc
        ' 
        lblSuperDisc.AutoSize = True
        lblSuperDisc.BackColor = Color.Transparent
        lblSuperDisc.Font = New Font("Consolas", 9F)
        lblSuperDisc.Location = New Point(174, 75)
        lblSuperDisc.Name = "lblSuperDisc"
        lblSuperDisc.Size = New Size(91, 14)
        lblSuperDisc.TabIndex = 36
        lblSuperDisc.Text = "Supervisor: "
        ' 
        ' lblDateDisc
        ' 
        lblDateDisc.AutoSize = True
        lblDateDisc.BackColor = Color.Transparent
        lblDateDisc.Font = New Font("Consolas", 9F)
        lblDateDisc.Location = New Point(434, 54)
        lblDateDisc.Name = "lblDateDisc"
        lblDateDisc.Size = New Size(77, 14)
        lblDateDisc.TabIndex = 37
        lblDateDisc.Text = "Date/Time:"
        ' 
        ' subStoLogs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.mainPanelBg
        ClientSize = New Size(820, 614)
        Controls.Add(lblBaristaDisc)
        Controls.Add(lblTransacDisc)
        Controls.Add(lblSuperDisc)
        Controls.Add(lblDateDisc)
        Controls.Add(TabControl1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "subStoLogs"
        StartPosition = FormStartPosition.CenterScreen
        Text = "subStoLogs"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(dgridIn, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(dgridOut, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(dgridDisc, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgridIn As DataGridView
    Friend WithEvents lblTransacIn As Label
    Friend WithEvents lblDateIn As Label
    Friend WithEvents lblSuperIn As Label
    Friend WithEvents lblBaristaIn As Label
    Friend WithEvents lstIn As ListBox
    Friend WithEvents dtIn As DateTimePicker
    Friend WithEvents lstOut As ListBox
    Friend WithEvents dgridOut As DataGridView
    Friend WithEvents dtOut As DateTimePicker
    Friend WithEvents lblBaristaOut As Label
    Friend WithEvents lblTransacOut As Label
    Friend WithEvents lblSuperOut As Label
    Friend WithEvents lblDateOut As Label
    Friend WithEvents btnReorder As Button
    Friend WithEvents lblBaristaDisc As Label
    Friend WithEvents lblTransacDisc As Label
    Friend WithEvents lblSuperDisc As Label
    Friend WithEvents lblDateDisc As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents lstDisc As ListBox
    Friend WithEvents btnAllDisc As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dtEnd As DateTimePicker
    Friend WithEvents dtStart As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAllIn As Button
    Friend WithEvents btnAllOut As Button
    Friend WithEvents dgridDisc As DataGridView
    Friend WithEvents lblStatus As Label
End Class
