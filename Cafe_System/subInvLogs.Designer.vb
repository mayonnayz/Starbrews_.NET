<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subInvLogs
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
        lstDates = New ListBox()
        DataGridView1 = New DataGridView()
        lblTitle = New Label()
        lblBarista = New Label()
        lblSuper = New Label()
        lblDate = New Label()
        lblTransac = New Label()
        datePicker = New DateTimePicker()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lstDates
        ' 
        lstDates.Font = New Font("Consolas", 9F)
        lstDates.FormattingEnabled = True
        lstDates.ItemHeight = 14
        lstDates.Location = New Point(9, 92)
        lstDates.Name = "lstDates"
        lstDates.Size = New Size(153, 508)
        lstDates.TabIndex = 0
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
        DataGridView1.Location = New Point(168, 60)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.Size = New Size(642, 542)
        DataGridView1.TabIndex = 10
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(9, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(272, 28)
        lblTitle.TabIndex = 16
        lblTitle.Text = "Store Inventory Logs"
        ' 
        ' lblBarista
        ' 
        lblBarista.AutoSize = True
        lblBarista.BackColor = Color.Transparent
        lblBarista.Font = New Font("Consolas", 9F)
        lblBarista.Location = New Point(292, 13)
        lblBarista.Name = "lblBarista"
        lblBarista.Size = New Size(70, 14)
        lblBarista.TabIndex = 17
        lblBarista.Text = "Barista: "
        ' 
        ' lblSuper
        ' 
        lblSuper.AutoSize = True
        lblSuper.BackColor = Color.Transparent
        lblSuper.Font = New Font("Consolas", 9F)
        lblSuper.Location = New Point(292, 34)
        lblSuper.Name = "lblSuper"
        lblSuper.Size = New Size(91, 14)
        lblSuper.TabIndex = 18
        lblSuper.Text = "Supervisor: "
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.BackColor = Color.Transparent
        lblDate.Font = New Font("Consolas", 9F)
        lblDate.Location = New Point(563, 13)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(77, 14)
        lblDate.TabIndex = 19
        lblDate.Text = "Date/Time:"
        ' 
        ' lblTransac
        ' 
        lblTransac.AutoSize = True
        lblTransac.BackColor = Color.Transparent
        lblTransac.Font = New Font("Consolas", 9F)
        lblTransac.Location = New Point(563, 34)
        lblTransac.Name = "lblTransac"
        lblTransac.Size = New Size(112, 14)
        lblTransac.TabIndex = 20
        lblTransac.Text = "Transaction ID:"
        ' 
        ' datePicker
        ' 
        datePicker.CalendarFont = New Font("Consolas", 9F)
        datePicker.Location = New Point(9, 61)
        datePicker.Name = "datePicker"
        datePicker.Size = New Size(153, 23)
        datePicker.TabIndex = 21
        ' 
        ' subInvLogs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.mainPanelBg
        ClientSize = New Size(820, 614)
        Controls.Add(datePicker)
        Controls.Add(lblTransac)
        Controls.Add(lblDate)
        Controls.Add(lblSuper)
        Controls.Add(lblBarista)
        Controls.Add(lblTitle)
        Controls.Add(DataGridView1)
        Controls.Add(lstDates)
        MaximizeBox = False
        MinimizeBox = False
        Name = "subInvLogs"
        StartPosition = FormStartPosition.CenterScreen
        Text = "subInvLogs"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstDates As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblBarista As Label
    Friend WithEvents lblSuper As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTransac As Label
    Friend WithEvents datePicker As DateTimePicker
End Class
