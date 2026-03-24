Public Class subStockRoom
    Private Sub subStockRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If tabInventory.purpose = "STOCK IN" Then
            btnStock.Text = "STOCK IN"
        ElseIf tabInventory.purpose = "STOCK OUT" Then
            btnStock.Text = "STOCK OUT"
        End If
    End Sub

    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        Me.Close()
    End Sub
End Class