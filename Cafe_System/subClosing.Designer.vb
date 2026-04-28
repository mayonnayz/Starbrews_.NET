<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subClosing
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
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        lblBarista = New Label()
        Label3 = New Label()
        lblDate = New Label()
        cmbSupervisor = New ComboBox()
        btnCreate = New Button()
        btnCancel = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        DataGridView1.Location = New Point(11, 58)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.Size = New Size(798, 542)
        DataGridView1.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(11, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(234, 28)
        Label1.TabIndex = 15
        Label1.Text = "Closing Inventory"
        ' 
        ' lblBarista
        ' 
        lblBarista.AutoSize = True
        lblBarista.BackColor = Color.Transparent
        lblBarista.Font = New Font("Consolas", 9F)
        lblBarista.Location = New Point(251, 9)
        lblBarista.Name = "lblBarista"
        lblBarista.Size = New Size(70, 14)
        lblBarista.TabIndex = 16
        lblBarista.Text = "Barista: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Consolas", 9F)
        Label3.Location = New Point(251, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 14)
        Label3.TabIndex = 17
        Label3.Text = "Shift Supervisor:"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.BackColor = Color.Transparent
        lblDate.Font = New Font("Consolas", 9F)
        lblDate.Location = New Point(15, 36)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(42, 14)
        lblDate.TabIndex = 18
        lblDate.Text = "Date:"
        ' 
        ' cmbSupervisor
        ' 
        cmbSupervisor.FormattingEnabled = True
        cmbSupervisor.Location = New Point(379, 25)
        cmbSupervisor.Name = "cmbSupervisor"
        cmbSupervisor.Size = New Size(166, 23)
        cmbSupervisor.TabIndex = 19
        ' 
        ' btnCreate
        ' 
        btnCreate.BackColor = Color.FromArgb(CByte(84), CByte(122), CByte(70))
        btnCreate.FlatAppearance.BorderSize = 0
        btnCreate.FlatStyle = FlatStyle.Popup
        btnCreate.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnCreate.ForeColor = SystemColors.ButtonHighlight
        btnCreate.Location = New Point(656, 5)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(152, 22)
        btnCreate.TabIndex = 25
        btnCreate.Text = "SUBMIT COUNT"
        btnCreate.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(122), CByte(72), CByte(70))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Popup
        btnCancel.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnCancel.ForeColor = SystemColors.ButtonHighlight
        btnCancel.Location = New Point(656, 31)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(152, 22)
        btnCancel.TabIndex = 24
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' subClosing
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.mainPanelBg
        ClientSize = New Size(820, 614)
        Controls.Add(btnCreate)
        Controls.Add(btnCancel)
        Controls.Add(cmbSupervisor)
        Controls.Add(lblDate)
        Controls.Add(Label3)
        Controls.Add(lblBarista)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "subClosing"
        StartPosition = FormStartPosition.CenterScreen
        Text = "subClosing"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblBarista As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents cmbSupervisor As ComboBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnCancel As Button
End Class
