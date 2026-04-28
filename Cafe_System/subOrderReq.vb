Imports System.Data.OleDb

Public Class subOrderReq
    Public OrderReqID As Integer

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As String
        result = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Sub LoadRequestDetails()

        Dim sql As String =
        "SELECT 
            o.OrderReqID,
            o.DateRequested,
            o.Status,
            a.FirstName & ' ' & a.LastName AS RequestedBy
         FROM OrderReqTbl o
         INNER JOIN AccountsTbl a ON o.RequestedBy = a.AccountID
         WHERE o.OrderReqID = ?"

        Using cmd As New OleDbCommand(sql, oledbCnn)
            cmd.Parameters.AddWithValue("?", OrderReqID)

            Using reader = cmd.ExecuteReader()
                If reader.Read() Then
                    lblTransac.Text = "Transaction ID: " & OrderReqID
                    lblReq.Text = "Requested by: " & reader("RequestedBy").ToString()
                    lblDate.Text = "Date: " & Convert.ToDateTime(reader("DateRequested")).ToString("MM/dd/yyyy hh:mm tt")

                    Dim status As String = reader("Status").ToString()

                    If status <> "Pending" Then
                        btnApprove.Enabled = False
                        btnReject.Enabled = False
                    End If
                End If
            End Using
        End Using

    End Sub

    Sub LoadRequestItems()

        Dim dt As New DataTable()

        Dim sql As String =
        "SELECT 
            i.ItemName,
            s.SupplierName,
            r.Quantity,
            i.Unit,
            i.UnitPrice
         FROM ((ReqItemsTbl r
         INNER JOIN ItemsTbl i ON r.ItemID = i.ItemID)
         INNER JOIN SupplierTbl s ON r.SupplierID = s.SupplierID)
         WHERE r.OrderReqID = ?"

        Using cmd As New OleDbCommand(sql, oledbCnn)
            cmd.Parameters.Add("?", OleDbType.Integer).Value = OrderReqID

            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        DataGridView1.DataSource = dt
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowHeadersVisible = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 214, 200)
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridView1.Columns("ItemName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        DataGridView1.Columns("SupplierName").HeaderText = "Supplier"
        DataGridView1.Columns("SupplierName").Width = 250

        DataGridView1.Columns("Quantity").Width = 70
        DataGridView1.Columns("Unit").Width = 60
        DataGridView1.Columns("UnitPrice").Width = 80

        DataGridView1.Columns("UnitPrice").DefaultCellStyle.Format = "C2"

        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.ReadOnly = True
        Next

    End Sub

    Sub UpdateRequestStatus(status As String)

        Dim confirm = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo)
        If confirm <> DialogResult.Yes Then Exit Sub

        Dim sql As String =
        "UPDATE OrderReqTbl 
         SET Status = ?, 
             ReviewedBy = ?, 
             DateReviewed = ?
         WHERE OrderReqID = ?"

        Using cmd As New OleDbCommand(sql, oledbCnn)

            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = status
            cmd.Parameters.Add("?", OleDbType.Integer).Value = Form1.UserId
            cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now
            cmd.Parameters.Add("?", OleDbType.Integer).Value = OrderReqID

            cmd.ExecuteNonQuery()

        End Using

        MessageBox.Show("Request " & status & " successfully!")
        Me.Close()

    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        UpdateRequestStatus("Approved")
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        UpdateRequestStatus("Rejected")
    End Sub

    Private Sub subOrderReq_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Form1.UserLvl = 2 Then
            btnApprove.Visible = False
            btnReject.Visible = False
        End If


        LoadRequestDetails()
        LoadRequestItems()
    End Sub
End Class