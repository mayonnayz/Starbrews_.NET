Public Class subCreateReq

    Private Sub subCreateReq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblReqBy.Text = "Requested by: " & Form1.FirstName & " " & Form1.LastName
        lblDate.Text = "Date: " & DateTime.Now
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As String
        result = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


End Class