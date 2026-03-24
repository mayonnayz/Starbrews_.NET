Public Class tabInventory
    Private Sub tabInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = "Date: " & DateTime.Now.ToString("MM/dd/yyyy")

        If Form1.UserLvl = 3 Then
            btnStockIn.Visible = False
            btnStockOut.Visible = False
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub btnHistoryStock_Click(sender As Object, e As EventArgs) Handles btnHistoryStock.Click

    End Sub

    Private Sub btnStockOut_Click(sender As Object, e As EventArgs) Handles btnStockOut.Click

    End Sub
End Class
