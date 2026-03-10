<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Panel3 = New Panel()
        btnLogOut = New Button()
        lblPosition = New Label()
        lblName = New Label()
        btnAccounts = New Button()
        btnOrderReq = New Button()
        btnItems = New Button()
        btnInventory = New Button()
        btnDashboard = New Button()
        Panel4 = New Panel()
        pnlContent = New Panel()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = My.Resources.Resources.logo
        Panel3.BackgroundImageLayout = ImageLayout.Zoom
        Panel3.Location = New Point(3, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(267, 99)
        Panel3.TabIndex = 7
        ' 
        ' btnLogOut
        ' 
        btnLogOut.BackgroundImage = My.Resources.Resources.logoutbtn
        btnLogOut.BackgroundImageLayout = ImageLayout.Zoom
        btnLogOut.FlatAppearance.BorderSize = 0
        btnLogOut.FlatStyle = FlatStyle.Flat
        btnLogOut.Location = New Point(0, 593)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(270, 53)
        btnLogOut.TabIndex = 6
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' lblPosition
        ' 
        lblPosition.AutoSize = True
        lblPosition.Font = New Font("Sitka Text", 11.249999F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblPosition.ForeColor = SystemColors.ButtonHighlight
        lblPosition.Location = New Point(15, 128)
        lblPosition.Name = "lblPosition"
        lblPosition.Size = New Size(67, 21)
        lblPosition.TabIndex = 5
        lblPosition.Text = "Position"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.ForeColor = SystemColors.ButtonHighlight
        lblName.Location = New Point(13, 103)
        lblName.Name = "lblName"
        lblName.Size = New Size(179, 28)
        lblName.TabIndex = 4
        lblName.Text = "Christian Averilla"
        ' 
        ' btnAccounts
        ' 
        btnAccounts.BackgroundImage = My.Resources.Resources.accountsbtn
        btnAccounts.BackgroundImageLayout = ImageLayout.Zoom
        btnAccounts.FlatAppearance.BorderSize = 0
        btnAccounts.FlatStyle = FlatStyle.Flat
        btnAccounts.Location = New Point(0, 500)
        btnAccounts.Name = "btnAccounts"
        btnAccounts.Size = New Size(270, 73)
        btnAccounts.TabIndex = 2
        btnAccounts.UseVisualStyleBackColor = True
        ' 
        ' btnOrderReq
        ' 
        btnOrderReq.BackgroundImage = My.Resources.Resources.orderbtn
        btnOrderReq.BackgroundImageLayout = ImageLayout.Zoom
        btnOrderReq.FlatAppearance.BorderSize = 0
        btnOrderReq.FlatStyle = FlatStyle.Flat
        btnOrderReq.Location = New Point(0, 421)
        btnOrderReq.Name = "btnOrderReq"
        btnOrderReq.Size = New Size(270, 73)
        btnOrderReq.TabIndex = 3
        btnOrderReq.UseVisualStyleBackColor = True
        ' 
        ' btnItems
        ' 
        btnItems.BackgroundImage = My.Resources.Resources.itemsbtn
        btnItems.BackgroundImageLayout = ImageLayout.Zoom
        btnItems.FlatAppearance.BorderSize = 0
        btnItems.FlatStyle = FlatStyle.Flat
        btnItems.Location = New Point(0, 342)
        btnItems.Name = "btnItems"
        btnItems.Size = New Size(270, 73)
        btnItems.TabIndex = 2
        btnItems.UseVisualStyleBackColor = True
        ' 
        ' btnInventory
        ' 
        btnInventory.BackgroundImage = My.Resources.Resources.inventorybtn
        btnInventory.BackgroundImageLayout = ImageLayout.Zoom
        btnInventory.FlatAppearance.BorderSize = 0
        btnInventory.FlatStyle = FlatStyle.Flat
        btnInventory.Location = New Point(0, 263)
        btnInventory.Name = "btnInventory"
        btnInventory.Size = New Size(270, 73)
        btnInventory.TabIndex = 1
        btnInventory.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.Transparent
        btnDashboard.BackgroundImage = My.Resources.Resources.homebtn
        btnDashboard.BackgroundImageLayout = ImageLayout.Zoom
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Location = New Point(0, 184)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(270, 73)
        btnDashboard.TabIndex = 0
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.BackgroundImage = My.Resources.Resources.sidePanelBg
        Panel4.Controls.Add(Panel3)
        Panel4.Controls.Add(btnOrderReq)
        Panel4.Controls.Add(btnLogOut)
        Panel4.Controls.Add(btnDashboard)
        Panel4.Controls.Add(lblPosition)
        Panel4.Controls.Add(btnInventory)
        Panel4.Controls.Add(lblName)
        Panel4.Controls.Add(btnItems)
        Panel4.Controls.Add(btnAccounts)
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(270, 646)
        Panel4.TabIndex = 1
        ' 
        ' pnlContent
        ' 
        pnlContent.BackgroundImage = My.Resources.Resources.mainPanelBg
        pnlContent.Dock = DockStyle.Bottom
        pnlContent.Location = New Point(270, 0)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(852, 646)
        pnlContent.TabIndex = 2
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1122, 646)
        Controls.Add(pnlContent)
        Controls.Add(Panel4)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnDashboard As Button
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnAccounts As Button
    Friend WithEvents btnOrderReq As Button
    Friend WithEvents btnItems As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pnlContent As Panel
End Class
