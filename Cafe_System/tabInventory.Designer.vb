<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tabInventory
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
        btnClosingCount = New Button()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        btnReceive = New Button()
        btnHistory = New Button()
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
        Label1.Size = New Size(130, 28)
        Label1.TabIndex = 1
        Label1.Text = "Inventory"
        ' 
        ' btnClosingCount
        ' 
        btnClosingCount.BackColor = Color.DarkKhaki
        btnClosingCount.FlatAppearance.BorderSize = 0
        btnClosingCount.FlatStyle = FlatStyle.Flat
        btnClosingCount.Location = New Point(675, 59)
        btnClosingCount.Name = "btnClosingCount"
        btnClosingCount.Size = New Size(156, 23)
        btnClosingCount.TabIndex = 3
        btnClosingCount.Text = "Enter Closing Inventory"
        btnClosingCount.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ScrollBar
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(22, 94)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(809, 493)
        DataGridView1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(22, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 15)
        Label2.TabIndex = 4
        Label2.Text = "Date: 03/11/2026"
        ' 
        ' btnReceive
        ' 
        btnReceive.BackColor = Color.DarkKhaki
        btnReceive.FlatAppearance.BorderSize = 0
        btnReceive.FlatStyle = FlatStyle.Flat
        btnReceive.Location = New Point(630, 605)
        btnReceive.Name = "btnReceive"
        btnReceive.Size = New Size(84, 23)
        btnReceive.TabIndex = 5
        btnReceive.Text = "Stock In"
        btnReceive.UseVisualStyleBackColor = False
        ' 
        ' btnHistory
        ' 
        btnHistory.BackColor = Color.DarkKhaki
        btnHistory.FlatAppearance.BorderSize = 0
        btnHistory.FlatStyle = FlatStyle.Flat
        btnHistory.Location = New Point(729, 605)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(102, 23)
        btnHistory.TabIndex = 6
        btnHistory.Text = "View  Logs"
        btnHistory.UseVisualStyleBackColor = False
        ' 
        ' tabInventory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.mainPanelBg
        Controls.Add(btnHistory)
        Controls.Add(btnReceive)
        Controls.Add(Label2)
        Controls.Add(btnClosingCount)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Name = "tabInventory"
        Size = New Size(852, 646)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnClosingCount As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnReceive As Button
    Friend WithEvents btnHistory As Button

End Class
