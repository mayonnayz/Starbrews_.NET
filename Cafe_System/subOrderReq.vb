Public Class subOrderReq


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As String
        result = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub subOrderReq_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Form1.UserLvl = 2 Then
            btnApprove.Visible = False
            btnReject.Visible = False
        End If
    End Sub
End Class