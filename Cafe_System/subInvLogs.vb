Imports System.Net.Security

Public Class subInvLogs
    Private Sub subInvLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If tabInventory.purpose = "Stock Room Logs" Then
            lblTitle.Text = "Stock Room Logs"
        ElseIf tabInventory.purpose = "Store Inventory Logs" Then
            lblTitle.Text = "Store Inventory Logs"
        End If
    End Sub
End Class