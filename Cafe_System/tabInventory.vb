Public Class tabInventory
    Public Shared purpose As String
    Private Sub tabInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = "Date: " & DateTime.Now.ToString("MM/dd/yyyy")
        lblDate2.Text = "Date: " & DateTime.Now.ToString("MM/dd/yyyy")

        If Form1.UserLvl = 3 Then
            btnStockIn.Visible = False
            btnStockOut.Visible = False
        ElseIf Form1.UserLvl = 2 Then
            btnClosingCount.Visible = False
        End If
    End Sub


    Private Sub btnClosingCount_Click(sender As Object, e As EventArgs) Handles btnClosingCount.Click
        Dim subCls As New subClosing()
        subCls.ShowDialog()
    End Sub

    Private Sub btnStockIn_Click(sender As Object, e As EventArgs) Handles btnStockIn.Click
        purpose = "STOCK IN"
        Dim subStk As New subStockRoom()
        subStk.ShowDialog()
    End Sub

    Private Sub btnStockOut_Click(sender As Object, e As EventArgs) Handles btnStockOut.Click
        purpose = "STOCK OUT"
        Dim subStk As New subStockRoom()
        subStk.ShowDialog()
    End Sub

    Private Sub btnHistoryStock_Click(sender As Object, e As EventArgs) Handles btnHistoryStock.Click
        purpose = "Stock Room Logs"
        Dim subInv As New subInvLogs()
        subInv.ShowDialog()
    End Sub

    Private Sub btnHistoryStore_Click(sender As Object, e As EventArgs) Handles btnHistoryStore.Click
        purpose = "Store Inventory Logs"
        Dim subInv As New subInvLogs()
        subInv.ShowDialog()
    End Sub
End Class
