Public Class tabItems
    Private Sub tabItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.UserLvl = 3 Then
            btnAddItem.Visible = False
            btnArchiveItem.Visible = False
            btnEditItem.Visible = False
        End If

    End Sub
End Class
