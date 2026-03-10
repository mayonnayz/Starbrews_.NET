Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = Form1.FirstName & " " & Form1.LastName
        If Form1.UserLvl = 0 Then ''Superadmin
            lblPosition.Text = "Superadmin"
        ElseIf Form1.UserLvl = 1 Then ''Store Manager
            lblPosition.Text = "Store Manager"
            btnAccounts.Visible = False
        ElseIf Form1.UserLvl = 2 Then ''Shift Supervisor
            lblPosition.Text = "Shift Supervisor"
            btnAccounts.Visible = False
        ElseIf Form1.UserLvl = 3 Then ''Barista
            lblPosition.Text = "Barista"
            btnAccounts.Visible = False
            btnOrderReq.Visible = False
        End If
        LoadUserControl(New tabDashboard())
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Form1.UserId = 0
            Form1.UserLvl = 3
            Form1.FirstName = ""
            Form1.LastName = ""

            Form1.Show()
            Me.Close()
        End If
    End Sub
    Private Sub LoadUserControl(tab As UserControl)
        pnlContent.Controls.Clear()
        tab.Dock = DockStyle.Fill
        pnlContent.Controls.Add(tab)
        tab.BringToFront()

        'Dim tb As tabDashboard = TryCast(tab, tabDashboard)
        'If tb IsNot Nothing Then
        '    AddHandler tb.SwitchTabRequested, AddressOf SwitchTab
        'End If
    End Sub
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        LoadUserControl(New tabDashboard())
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        LoadUserControl(New tabInventory())
    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        LoadUserControl(New tabItems())
    End Sub

    Private Sub btnOrderReq_Click(sender As Object, e As EventArgs) Handles btnOrderReq.Click
        LoadUserControl(New tabOrderRequests())
    End Sub

    Private Sub btnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click
        LoadUserControl(New tabAccounts())
    End Sub
    Private Sub btnDashboard_MouseEnter(sender As Object, e As EventArgs) Handles btnDashboard.MouseEnter
        btnDashboard.BackColor = Color.DarkOliveGreen
    End Sub
    Private Sub btnDashboard_MouseLeave(sender As Object, e As EventArgs) Handles btnDashboard.MouseLeave
        btnDashboard.BackColor = Color.Transparent
    End Sub
    Private Sub btnInventory_MouseEnter(sender As Object, e As EventArgs) Handles btnInventory.MouseEnter
        btnInventory.BackColor = Color.DarkOliveGreen
    End Sub
    Private Sub btnInventory_MouseLeave(sender As Object, e As EventArgs) Handles btnInventory.MouseLeave
        btnInventory.BackColor = Color.Transparent
    End Sub
    Private Sub btnItems_MouseEnter(sender As Object, e As EventArgs) Handles btnItems.MouseEnter
        btnItems.BackColor = Color.DarkOliveGreen
    End Sub
    Private Sub btnItems_MouseLeave(sender As Object, e As EventArgs) Handles btnItems.MouseLeave
        btnItems.BackColor = Color.Transparent
    End Sub
    Private Sub btnAccounts_MouseEnter(sender As Object, e As EventArgs) Handles btnAccounts.MouseEnter
        btnAccounts.BackColor = Color.DarkOliveGreen
    End Sub
    Private Sub btnAccounts_MouseLeave(sender As Object, e As EventArgs) Handles btnAccounts.MouseLeave
        btnAccounts.BackColor = Color.Transparent
    End Sub
    Private Sub btnOrderReq_MouseEnter(sender As Object, e As EventArgs) Handles btnOrderReq.MouseEnter
        btnOrderReq.BackColor = Color.DarkOliveGreen

    End Sub
    Private Sub btnOrderReq_MouseLeave(sender As Object, e As EventArgs) Handles btnOrderReq.MouseLeave
        btnOrderReq.BackColor = Color.Transparent
    End Sub
    Private Sub btnLogOut_MouseEnter(sender As Object, e As EventArgs) Handles btnLogOut.MouseEnter
        btnLogOut.BackColor = Color.DarkOliveGreen

    End Sub
    Private Sub btnLogOut_MouseLeave(sender As Object, e As EventArgs) Handles btnLogOut.MouseLeave
        btnLogOut.BackColor = Color.Transparent
    End Sub

End Class