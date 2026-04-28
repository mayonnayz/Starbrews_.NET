Imports System.Data.OleDb

Public Class subCreateReq

    Private Sub subCreateReq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblReqBy.Text = "Requested by: " & Form1.FirstName & " " & Form1.LastName
        lblDate.Text = "Date: " & DateTime.Now

        LoadItems()
    End Sub

    Sub LoadItems()

        Dim dt As New DataTable()

        Dim sql As String =
        "SELECT ItemID, ItemName, ItemCategory, Unit, UnitPrice
         FROM ItemsTbl
         WHERE ItemStatus = 1"

        Using da As New OleDbDataAdapter(sql, oledbCnn)
            da.Fill(dt)
        End Using

        dt.Columns.Add("RequestQty", GetType(Integer))

        DataGridView1.DataSource = dt

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowHeadersVisible = False

        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 214, 200)
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        DataGridView1.Columns("ItemID").Visible = False
        DataGridView1.Columns("ItemCategory").Visible = False

        DataGridView1.Columns("ItemName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns("Unit").Width = 60
        DataGridView1.Columns("UnitPrice").Width = 80
        DataGridView1.Columns("RequestQty").Width = 80

        DataGridView1.Columns("UnitPrice").DefaultCellStyle.Format = "C2"

        Dim colSupplier As New DataGridViewComboBoxColumn()
        colSupplier.Name = "Supplier"
        colSupplier.HeaderText = "Supplier"
        colSupplier.DisplayMember = "SupplierName"
        colSupplier.ValueMember = "SupplierID"
        colSupplier.Width = 250

        DataGridView1.Columns.Add(colSupplier)

        DataGridView1.Columns("ItemName").DisplayIndex = 0
        DataGridView1.Columns("Supplier").DisplayIndex = 1
        DataGridView1.Columns("RequestQty").DisplayIndex = 2
        DataGridView1.Columns("Unit").DisplayIndex = 3
        DataGridView1.Columns("UnitPrice").DisplayIndex = 4

        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.ReadOnly = True
        Next

        DataGridView1.Columns("RequestQty").ReadOnly = False
        DataGridView1.Columns("Supplier").ReadOnly = False

    End Sub

    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        btnRequest.Enabled = False
        Try
            Dim totalValidQty As Integer = 0

            For Each row As DataGridViewRow In DataGridView1.Rows

                If row.IsNewRow Then Continue For

                Dim qty As Integer = 0
                Integer.TryParse(row.Cells("RequestQty").Value?.ToString(), qty)

                totalValidQty += qty

            Next

            If totalValidQty = 0 Then
                MessageBox.Show("Cannot submit request. All quantities are zero.", "Invalid Request", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            ' =========================
            ' INSERT HEADER
            ' =========================
            Dim orderReqID As Integer

            Dim sqlHeader As String =
            "INSERT INTO OrderReqTbl (RequestedBy, DateRequested, ReviewedBy, DateReviewed, Status)
         VALUES (?, ?, NULL, NULL, ?)"

            Using cmd As New OleDbCommand(sqlHeader, oledbCnn)
                cmd.Parameters.AddWithValue("?", Form1.UserId)
                cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now
                cmd.Parameters.AddWithValue("?", "Pending")
                cmd.ExecuteNonQuery()
            End Using

            Using cmd As New OleDbCommand("SELECT @@IDENTITY", oledbCnn)
                orderReqID = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            ' =========================
            ' INSERT ITEMS
            ' =========================
            For Each row As DataGridViewRow In DataGridView1.Rows

                If row.IsNewRow Then Continue For

                Dim qty As Integer
                If Not Integer.TryParse(row.Cells("RequestQty").Value?.ToString(), qty) Then Continue For
                If qty <= 0 Then Continue For

                Dim itemID As Integer = Convert.ToInt32(row.Cells("ItemID").Value)

                If row.Cells("Supplier").Value Is Nothing Then
                    MessageBox.Show("Select supplier for item: " & row.Cells("ItemName").Value.ToString())
                    Exit Sub
                End If

                Dim supplierID As Integer = Convert.ToInt32(row.Cells("Supplier").Value)

                Dim sqlItem As String =
                "INSERT INTO ReqItemsTbl (OrderReqID, ItemID, Quantity, SupplierID) VALUES (?, ?, ?, ?)"

                Using cmd As New OleDbCommand(sqlItem, oledbCnn)
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = orderReqID
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = itemID
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = qty
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = supplierID
                    cmd.ExecuteNonQuery()
                End Using

            Next

            MessageBox.Show("Request submitted successfully!")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If Not Me.IsDisposed Then
                btnRequest.Enabled = True
            End If
        End Try


    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter

        If e.RowIndex < 0 Then Exit Sub
        If DataGridView1.Columns(e.ColumnIndex).Name <> "Supplier" Then Exit Sub

        Dim row = DataGridView1.Rows(e.RowIndex)
        Dim categoryID As Integer = Convert.ToInt32(row.Cells("ItemCategory").Value)

        Dim dtSuppliers As New DataTable()

        Dim sql As String = "SELECT SupplierID, SupplierName FROM SupplierTbl WHERE SupplierStatus = 1 AND SupplierCategory = ?"

        Using cmd As New OleDbCommand(sql, oledbCnn)
            cmd.Parameters.AddWithValue("?", categoryID)

            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dtSuppliers)
            End Using
        End Using

        Dim combo As DataGridViewComboBoxCell =
        CType(row.Cells("Supplier"), DataGridViewComboBoxCell)

        combo.DataSource = dtSuppliers
        combo.DisplayMember = "SupplierName"
        combo.ValueMember = "SupplierID"

    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged

        If e.RowIndex < 0 Then Exit Sub
        If DataGridView1.Columns(e.ColumnIndex).Name <> "RequestQty" Then Exit Sub

        Dim row = DataGridView1.Rows(e.RowIndex)

        Dim qty As Integer = 0
        Integer.TryParse(row.Cells("RequestQty").Value?.ToString(), qty)

        Dim supplierCell = CType(row.Cells("Supplier"), DataGridViewComboBoxCell)

        If qty <= 0 Then
            supplierCell.ReadOnly = True
            supplierCell.Value = Nothing
        Else
            supplierCell.ReadOnly = False
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As String
        result = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing

        If DataGridView1.CurrentCell.ColumnIndex = DataGridView1.Columns("RequestQty").Index Then
            Dim tb As TextBox = CType(e.Control, TextBox)
            RemoveHandler tb.KeyPress, AddressOf Qty_KeyPress
            AddHandler tb.KeyPress, AddressOf Qty_KeyPress
        End If

    End Sub

    Private Sub Qty_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class