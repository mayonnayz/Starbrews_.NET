Imports System.Data.OleDb

Public Class subCreateReq

    Private Sub subCreateReq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList

        lblReqBy.Text = "Requested by: " & vbCrLf & Form1.FirstName & " " & Form1.LastName

        lblDate.Text = "Date: " & vbCrLf & DateTime.Now

        LockControls()

        LoadCategories()

        SetupGrid()

    End Sub

    Private Sub LockControls()

        lstItem.Enabled = False
        cmbSupplier.Enabled = False
        txtQuantity.Enabled = False
        txtPrice.Enabled = False
        btnAdd.Enabled = False
        btnRemove.Enabled = False

        txtUnit.ReadOnly = True
        txtPrice.ReadOnly = True
    End Sub

    Private Sub LoadItems()

        If cmbCategory.SelectedValue Is Nothing Then Exit Sub
        If TypeOf cmbCategory.SelectedValue Is DataRowView Then Exit Sub

        Dim dt As New DataTable()

        Dim sql As String =
        "SELECT ItemID, ItemName
         FROM ItemsTbl
         WHERE ItemStatus = 1
         AND ItemCategory = ?
         AND ItemName LIKE ?"

        Using cmd As New OleDbCommand(sql, oledbCnn)

            cmd.Parameters.AddWithValue("?", cmbCategory.SelectedValue)

            cmd.Parameters.AddWithValue("?", "%" & txtSearch.Text.Trim & "%")

            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using

        End Using

        lstItem.DataSource = dt
        lstItem.DisplayMember = "ItemName"
        lstItem.ValueMember = "ItemID"

        lstItem.Enabled = True
        lstItem.ClearSelected()

    End Sub

    Private Sub LoadCategories()

        Dim dt As New DataTable()

        Dim sql As String =
        "SELECT CategoryID, CatName FROM CategoriesTbl"

        Using da As New OleDbDataAdapter(sql, oledbCnn)
            da.Fill(dt)
        End Using

        cmbCategory.DataSource = dt
        cmbCategory.DisplayMember = "CatName"
        cmbCategory.ValueMember = "CategoryID"

        cmbCategory.SelectedIndex = -1

    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged

        LoadItems()

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        LoadItems()

    End Sub

    Private Sub lstItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstItem.SelectedIndexChanged

        If lstItem.SelectedValue Is Nothing Then Exit Sub
        If TypeOf lstItem.SelectedValue Is DataRowView Then Exit Sub

        Dim sqlUnit =
        "SELECT Unit, UnitPrice
         FROM ItemsTbl
         WHERE ItemID = ?"

        Using cmd As New OleDbCommand(sqlUnit, oledbCnn)

            cmd.Parameters.AddWithValue("?", lstItem.SelectedValue)

            Using reader = cmd.ExecuteReader

                If reader.Read Then
                    txtUnit.Text = reader("Unit").ToString
                    txtPrice.Text = "$" & Convert.ToDecimal(reader("UnitPrice")).ToString("0.00")
                End If

            End Using

        End Using

        Dim dt As New DataTable

        Dim sqlSupp =
        "SELECT SupplierID, SupplierName
         FROM SupplierTbl
         WHERE SupplierStatus = 1
         AND SupplierCategory = ?"

        Using cmd As New OleDbCommand(sqlSupp, oledbCnn)

            cmd.Parameters.AddWithValue("?", cmbCategory.SelectedValue)

            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using

        End Using

        cmbSupplier.DataSource = dt
        cmbSupplier.DisplayMember = "SupplierName"
        cmbSupplier.ValueMember = "SupplierID"

        cmbSupplier.Enabled = True
        txtQuantity.Enabled = True

    End Sub

    Private Sub SetupGrid()

        DataGridView1.Columns.Clear()

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowHeadersVisible = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 214, 200)
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridView1.Columns.Add("ItemID", "ItemID")
        DataGridView1.Columns.Add("ItemName", "Item")
        DataGridView1.Columns.Add("SupplierID", "SupplierID")
        DataGridView1.Columns.Add("SupplierName", "Supplier")
        DataGridView1.Columns.Add("Quantity", "Quantity")
        DataGridView1.Columns.Add("Unit", "Unit")
        DataGridView1.Columns.Add("UnitPrice", "UnitPrice")

        DataGridView1.Columns("ItemID").Visible = False
        DataGridView1.Columns("SupplierID").Visible = False

        DataGridView1.Columns("ItemName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        DataGridView1.Columns("SupplierName").HeaderText = "Supplier"
        DataGridView1.Columns("SupplierName").Width = 250

        DataGridView1.Columns("Quantity").Width = 70
        DataGridView1.Columns("Unit").Width = 60
        DataGridView1.Columns("UnitPrice").Width = 80

        DataGridView1.Columns("UnitPrice").DefaultCellStyle.Format = "C2"

        DataGridView1.Columns("Quantity").ReadOnly = False

        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False

    End Sub

    Private Sub ValidateAddButton()

        btnAdd.Enabled =
        cmbCategory.SelectedIndex <> -1 AndAlso
        lstItem.SelectedIndex <> -1 AndAlso
        cmbSupplier.SelectedIndex <> -1 AndAlso
        txtQuantity.Text.Trim <> ""

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim qty As Integer

        If Not Integer.TryParse(txtQuantity.Text, qty) Then
            MessageBox.Show("Please enter a valid quantity.")
            Exit Sub
        End If

        If qty <= 0 Then
            MessageBox.Show("Quantity must be greater than zero.")
            txtQuantity.Focus()
            Exit Sub
        End If

        Dim itemID As Integer = Convert.ToInt32(lstItem.SelectedValue)
        Dim supplierID As Integer = Convert.ToInt32(cmbSupplier.SelectedValue)

        For Each row As DataGridViewRow In DataGridView1.Rows

            If row.IsNewRow Then Continue For

            Dim existingItemID As Integer = Convert.ToInt32(row.Cells("ItemID").Value)
            Dim existingSupplierID As Integer = Convert.ToInt32(row.Cells("SupplierID").Value)

            If existingItemID = itemID AndAlso existingSupplierID = supplierID Then

                Dim existingQty As Integer = Convert.ToInt32(row.Cells("Quantity").Value)

                row.Cells("Quantity").Value = existingQty + qty

                txtQuantity.Clear()
                btnAdd.Enabled = False

                Exit Sub

            End If

        Next

        DataGridView1.Rows.Add(
        itemID,
        lstItem.Text,
        supplierID,
        cmbSupplier.Text,
        qty,
        txtUnit.Text,
        txtPrice.Text
    )

        txtQuantity.Clear()
        btnAdd.Enabled = False

    End Sub

    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        btnRequest.Enabled = False
        Try
            Dim totalValidQty = 0

            For Each row As DataGridViewRow In DataGridView1.Rows

                If row.IsNewRow Then Continue For

                Dim qty As Integer = 0
                If row.Cells("Quantity").Value IsNot Nothing Then
                    Integer.TryParse(row.Cells("Quantity").Value.ToString(), qty)
                End If

                totalValidQty += qty

            Next

            If totalValidQty = 0 Then
                MessageBox.Show("Cannot submit request. All quantities are zero.", "Invalid Request", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            Dim orderReqID As Integer

            Dim sqlHeader =
            "INSERT INTO OrderReqTbl (RequestedBy, DateRequested, ReviewedBy, DateReviewed, Status, OrderStatus)
         VALUES (?, ?, NULL, NULL, ?, ?)"

            Using cmd As New OleDbCommand(sqlHeader, oledbCnn)
                cmd.Parameters.Add("?", OleDbType.Integer).Value = Form1.UserId
                cmd.Parameters.Add("?", OleDbType.Date).Value = Date.Now
                cmd.Parameters.Add("?", OleDbType.VarWChar).Value = "Pending"
                cmd.Parameters.Add("?", OleDbType.Integer).Value = 0
                cmd.ExecuteNonQuery()
            End Using

            Using cmd As New OleDbCommand("SELECT @@IDENTITY", oledbCnn)
                orderReqID = Convert.ToInt32(cmd.ExecuteScalar)
            End Using

            For Each row As DataGridViewRow In DataGridView1.Rows

                If row.IsNewRow Then Continue For

                Dim qty As Integer
                If Not Integer.TryParse(row.Cells("Quantity").Value?.ToString, qty) Then Continue For
                If qty <= 0 Then Continue For

                Dim itemID = Convert.ToInt32(row.Cells("ItemID").Value)

                If row.Cells("SupplierID").Value Is Nothing Then
                    MessageBox.Show("Select supplier for item: " & row.Cells("ItemName").Value.ToString)
                    Exit Sub
                End If

                Dim supplierID = Convert.ToInt32(row.Cells("SupplierID").Value)

                Dim sqlItem =
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
            Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If Not IsDisposed Then
                btnRequest.Enabled = True
            End If
        End Try


    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso
       Not Char.IsDigit(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As String
        result = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If DataGridView1.CurrentRow Is Nothing Then Exit Sub

        Dim result = MessageBox.Show(
        "Are you sure you want to remove this item?",
        "Remove Item",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        End If

    End Sub

    Private Sub Qty_KeyPress(sender As Object, e As KeyPressEventArgs)

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub


    Private Sub cmbSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSupplier.SelectedIndexChanged
        ValidateAddButton()
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        ValidateAddButton()
    End Sub

    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing

        If DataGridView1.CurrentCell Is Nothing Then Exit Sub

        If DataGridView1.CurrentCell.ColumnIndex = DataGridView1.Columns("Quantity").Index Then

            Dim tb As TextBox = TryCast(e.Control, TextBox)
            If tb Is Nothing Then Exit Sub

            RemoveHandler tb.KeyPress, AddressOf Qty_KeyPress
            AddHandler tb.KeyPress, AddressOf Qty_KeyPress

        End If

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged

        btnRemove.Enabled =
            DataGridView1.SelectedRows.Count > 0

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub
End Class