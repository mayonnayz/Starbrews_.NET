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
        ItemName = New DataGridViewTextBoxColumn()
        Quantity = New DataGridViewTextBoxColumn()
        Category = New DataGridViewTextBoxColumn()
        Price = New DataGridViewTextBoxColumn()
        lblTitle = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        datePicker = New DateTimePicker()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lstDates
        ' 
        lstDates.Font = New Font("Consolas", 9F)
        lstDates.FormattingEnabled = True
        lstDates.ItemHeight = 14
        lstDates.Items.AddRange(New Object() {"09/20/2025 8:00 AM", "09/30/2025 8:00 PM"})
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ItemName, Quantity, Category, Price})
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
        lblTitle.Location = New Point(9, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(272, 28)
        lblTitle.TabIndex = 16
        lblTitle.Text = "Store Inventory Logs"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Consolas", 9F)
        Label2.Location = New Point(292, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 14)
        Label2.TabIndex = 17
        Label2.Text = "Barista: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Consolas", 9F)
        Label1.Location = New Point(292, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 14)
        Label1.TabIndex = 18
        Label1.Text = "Supervisor: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Consolas", 9F)
        Label3.Location = New Point(563, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 14)
        Label3.TabIndex = 19
        Label3.Text = "Date/Time:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Consolas", 9F)
        Label4.Location = New Point(563, 34)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 14)
        Label4.TabIndex = 20
        Label4.Text = "Transaction ID:"
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
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
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
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents datePicker As DateTimePicker
End Class
