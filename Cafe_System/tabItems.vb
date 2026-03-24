Public Class tabItems
    Private Sub tabItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.UserLvl = 3 Or Form1.UserLvl = 2 Then
            btnAddItem.Visible = False
            btnArchiveItem.Visible = False
            btnEditItem.Visible = False
        End If

    End Sub

    Private Sub dgridWinter_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgridWinter.CellContentClick

    End Sub
End Class
