Imports System.Data.OleDb

Public Class subStockRoom
    Private Sub subStockRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSvisor.Text = "Supervisor: " & Form1.FirstName & " " & Form1.LastName
        lblDate.Text = "Date: " & DateTime.Now

        If tabInventory.purpose = "STOCK IN" Then
            btnStock.Text = "STOCK IN"
        ElseIf tabInventory.purpose = "STOCK OUT" Then
            btnStock.Text = "STOCK OUT"
        End If

        LoadBarista()
    End Sub

    Private Sub LoadBarista()
        Try
            Dim sql As String = "SELECT AccountID, FirstName & ' ' & LastName AS FName FROM AccountsTbl WHERE Status = 1 AND UserLvl = 3"

            Using cmd As New OleDbCommand(sql, oledbCnn)
                Using adapter As New OleDbDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    Dim newRow As DataRow = dt.NewRow()
                    newRow("AccountID") = DBNull.Value
                    dt.Rows.InsertAt(newRow, 0)

                    cmbBarista.DataSource = dt
                    cmbBarista.DisplayMember = "FName"
                    cmbBarista.ValueMember = "AccountID"

                    cmbBarista.SelectedIndex = 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading accounts: " & ex.Message)
        End Try
    End Sub

    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As String
        result = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class