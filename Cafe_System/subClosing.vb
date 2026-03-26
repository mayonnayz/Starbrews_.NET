Imports System.Data.OleDb

Public Class subClosing
    Private Sub subClosing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBarista.Text = "Barista: " & Form1.FirstName & " " & Form1.LastName
        lblDate.Text = "Date: " & DateTime.Now

        LoadSupervisor()
    End Sub

    Private Sub LoadSupervisor()
        Try
            Dim sql As String = "SELECT AccountID, FirstName & ' ' & LastName AS FName FROM AccountsTbl WHERE Status = 1 AND UserLvl = 2"

            Using cmd As New OleDbCommand(sql, oledbCnn)
                Using adapter As New OleDbDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    Dim newRow As DataRow = dt.NewRow()
                    newRow("AccountID") = DBNull.Value
                    dt.Rows.InsertAt(newRow, 0)

                    cmbSupervisor.DataSource = dt
                    cmbSupervisor.DisplayMember = "FName"
                    cmbSupervisor.ValueMember = "AccountID"

                    cmbSupervisor.SelectedIndex = 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading accounts: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As String
        result = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class