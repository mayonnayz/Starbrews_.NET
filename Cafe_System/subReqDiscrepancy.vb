Imports System.Data.OleDb

Public Class subReqDiscrepancy

    Private stockMoveID As Integer

    Public Sub New(id As Integer)
        InitializeComponent()
        stockMoveID = id
    End Sub

    Private Sub subReqDiscrepancy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblReqBy.Text =
        "Requested By:" & vbCrLf &
        Form1.FirstName & " " & Form1.LastName

        lblDate.Text =
        "Date:" & vbCrLf &
        DateTime.Now.ToString("MMM-dd-yyyy hh:mm tt")

        lblTransac.Text =
        "Transaction ID: " & stockMoveID

        txtCategory.ReadOnly = True
        txtName.ReadOnly = True
        txtUnit.ReadOnly = True
        txtPrice.ReadOnly = True

        SetupGrid()

        LoadDiscrepancyItems()

    End Sub

    Private Sub SetupGrid()

        DataGridView1.Columns.Clear()

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.MultiSelect = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.RowHeadersVisible = False

        DataGridView1.ReadOnly = False

        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 214, 200)
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridView1.Columns.Add("ItemID", "ItemID")
        DataGridView1.Columns.Add("ItemName", "Item")
        DataGridView1.Columns.Add("Category", "Category")
        DataGridView1.Columns.Add("SupplierName", "Supplier")
        DataGridView1.Columns.Add("Discrepancy", "Discrepancy")
        DataGridView1.Columns.Add("Unit", "Unit")
        DataGridView1.Columns.Add("UnitPrice", "Price")
        DataGridView1.Columns.Add("RequestQty", "Request Qty")
        DataGridView1.Columns.Add("SupplierID", "SupplierID")

        DataGridView1.Columns("ItemID").Visible = False
        DataGridView1.Columns("SupplierID").Visible = False

        DataGridView1.Columns("UnitPrice").DefaultCellStyle.Format = "C2"

        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.ReadOnly = True
        Next

        DataGridView1.Columns("RequestQty").ReadOnly = False

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Private Sub LoadDiscrepancyItems()

        Dim dt As New DataTable()

        Dim sql As String =
        "SELECT 
            smi.StockItemID AS ItemID,
            i.ItemName,
            c.CatName AS Category,
            smi.SupplierID,
            s.SupplierName,
            smi.Discrepancy,
            i.Unit,
            i.UnitPrice
         FROM ((StockMoveItemsTbl smi
         INNER JOIN ItemsTbl i 
            ON smi.StockItemID = i.ItemID)
         INNER JOIN CategoriesTbl c 
            ON i.ItemCategory = c.CategoryID)
         INNER JOIN SupplierTbl s 
            ON smi.SupplierID = s.SupplierID
         WHERE smi.StockMoveID = ?
         AND smi.Discrepancy > 0"

        Using cmd As New OleDbCommand(sql, oledbCnn)
            cmd.Parameters.Add("?", OleDbType.Integer).Value = stockMoveID

            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        DataGridView1.Rows.Clear()

        For Each r As DataRow In dt.Rows

            DataGridView1.Rows.Add(
                r("ItemID"),
                r("ItemName").ToString(),
                r("Category").ToString(),
                r("SupplierName").ToString(),
                Convert.ToInt32(r("Discrepancy")),
                r("Unit").ToString(),
                r("UnitPrice"),
                Convert.ToInt32(r("Discrepancy")),
                Convert.ToInt32(r("SupplierID"))
            )

        Next

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged

        If DataGridView1.CurrentRow Is Nothing Then Exit Sub

        Dim row = DataGridView1.CurrentRow

        txtName.Text = row.Cells("ItemName").Value.ToString()
        txtCategory.Text = row.Cells("Category").Value.ToString()

        Dim qtyObj = row.Cells("RequestQty").Value

        If qtyObj IsNot Nothing Then
            txtQuantity.Text = qtyObj.ToString()
        Else
            txtQuantity.Text = "0"
        End If

        LoadSuppliers(row.Cells("Category").Value.ToString())
        LoadItemDetails(row.Cells("ItemID").Value)

    End Sub
    Private Sub LoadItemDetails(itemID As Integer)

        Dim sql As String =
    "SELECT Unit, UnitPrice
     FROM ItemsTbl
     WHERE ItemID = ?"

        Using cmd As New OleDbCommand(sql, oledbCnn)
            cmd.Parameters.Add("?", OleDbType.Integer).Value = itemID

            Using r = cmd.ExecuteReader()
                If r.Read() Then
                    txtUnit.Text = r("Unit").ToString()
                    txtPrice.Text = Convert.ToDecimal(r("UnitPrice")).ToString("0.00")
                End If
            End Using
        End Using

    End Sub
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit

        If e.RowIndex < 0 Then Exit Sub

        If DataGridView1.Columns(e.ColumnIndex).Name = "RequestQty" Then

            Dim val As Integer

            If Not Integer.TryParse(DataGridView1.Rows(e.RowIndex).Cells("RequestQty").Value, val) Then
                DataGridView1.Rows(e.RowIndex).Cells("RequestQty").Value = 0
            End If

        End If

        If e.ColumnIndex = DataGridView1.Columns("RequestQty").Index Then

            Dim val As Integer
            If Not Integer.TryParse(DataGridView1.Rows(e.RowIndex).Cells("RequestQty").Value?.ToString(), val) Then
                DataGridView1.Rows(e.RowIndex).Cells("RequestQty").Value = 0
            End If

            If val < 0 Then
                DataGridView1.Rows(e.RowIndex).Cells("RequestQty").Value = 0
            End If

        End If

    End Sub

    Private Sub LoadSuppliers(category As String)

        Dim dt As New DataTable()

        Dim sql As String =
        "SELECT SupplierID, SupplierName
         FROM SupplierTbl
         WHERE SupplierStatus = 1
         AND SupplierCategory =
         (
            SELECT CategoryID
            FROM CategoriesTbl
            WHERE CatName = ?
         )"

        Using cmd As New OleDbCommand(sql, oledbCnn)

            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = category

            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using

        End Using

        cmbSupplier.DataSource = dt
        cmbSupplier.DisplayMember = "SupplierName"
        cmbSupplier.ValueMember = "SupplierID"

    End Sub

    Private Sub ValidateCreateButton()

        If DataGridView1.Rows.Count = 0 Then
            btnCreate.Enabled = False
            Exit Sub
        End If

        For Each row As DataGridViewRow In DataGridView1.Rows

            If row.IsNewRow Then Continue For

            Dim qty As Integer

            If Not Integer.TryParse(row.Cells("RequestQty").Value?.ToString(), qty) Then
                btnCreate.Enabled = False
                Exit Sub
            End If

            If qty <= 0 Then
                btnCreate.Enabled = False
                Exit Sub
            End If

        Next

        btnCreate.Enabled = True

    End Sub

    Private Sub cmbSupplier_SelectedIndexChanged(
        sender As Object,
        e As EventArgs) Handles cmbSupplier.SelectedIndexChanged

        If DataGridView1.CurrentRow Is Nothing Then Exit Sub
        If cmbSupplier.SelectedValue Is Nothing Then Exit Sub
        If TypeOf cmbSupplier.SelectedValue Is DataRowView Then Exit Sub

        DataGridView1.CurrentRow.Cells("SupplierID").Value =
        cmbSupplier.SelectedValue

        DataGridView1.CurrentRow.Cells("SupplierName").Value =
        cmbSupplier.Text

    End Sub

    Private Sub txtQuantity_TextChanged(
        sender As Object,
        e As EventArgs) Handles txtQuantity.TextChanged

        If DataGridView1.CurrentRow Is Nothing Then Exit Sub

        Dim qty As Integer

        If Integer.TryParse(txtQuantity.Text, qty) Then

            DataGridView1.CurrentRow.Cells("RequestQty").Value = qty

        End If

    End Sub

    Private Sub btnRemove_Click(
        sender As Object,
        e As EventArgs) Handles btnRemove.Click

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

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        Dim hasValidItem As Boolean = False

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.IsNewRow Then Continue For

            Dim qty As Integer = Convert.ToInt32(row.Cells("RequestQty").Value)

            If qty > 0 Then
                hasValidItem = True
            End If
        Next

        If Not hasValidItem Then
            MessageBox.Show("Cannot create request. No valid quantities found.")
            Exit Sub
        End If

        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("No items to request.")
            Exit Sub
        End If

        Dim orderReqID As Integer

        Dim sqlHeader As String =
        "INSERT INTO OrderReqTbl
        (RequestedBy, DateRequested, ReviewedBy,
         DateReviewed, Status, OrderStatus)
         VALUES (?, ?, NULL, NULL, ?, ?)"

        Using cmd As New OleDbCommand(sqlHeader, oledbCnn)

            cmd.Parameters.Add("?", OleDbType.Integer).Value =
            Form1.UserId

            cmd.Parameters.Add("?", OleDbType.Date).Value =
            Date.Now

            cmd.Parameters.Add("?", OleDbType.VarWChar).Value =
            "Pending"

            cmd.Parameters.Add("?", OleDbType.Integer).Value = 0

            cmd.ExecuteNonQuery()

        End Using

        Using cmd As New OleDbCommand(
            "SELECT @@IDENTITY", oledbCnn)

            orderReqID =
            Convert.ToInt32(cmd.ExecuteScalar())

        End Using

        For Each row As DataGridViewRow In DataGridView1.Rows

            If row.IsNewRow Then Continue For

            Dim itemID As Integer =
            Convert.ToInt32(row.Cells("ItemID").Value)

            Dim qty As Integer =
            Convert.ToInt32(row.Cells("RequestQty").Value)

            Dim supplierID As Integer =
            Convert.ToInt32(row.Cells("SupplierID").Value)

            Dim sqlItem As String =
            "INSERT INTO ReqItemsTbl
            (OrderReqID, ItemID, Quantity, SupplierID)
             VALUES (?, ?, ?, ?)"

            Using cmd As New OleDbCommand(sqlItem, oledbCnn)

                cmd.Parameters.Add("?", OleDbType.Integer).Value = orderReqID

                cmd.Parameters.Add("?", OleDbType.Integer).Value = itemID

                cmd.Parameters.Add("?", OleDbType.Integer).Value = qty

                cmd.Parameters.Add("?", OleDbType.Integer).Value = supplierID

                cmd.ExecuteNonQuery()

            End Using

        Next

        Dim sqlUpdate As String =
        "UPDATE StockMovementTbl
         SET DiscStatus = 2
         WHERE StockMovementID = ?"

        Using cmd As New OleDbCommand(sqlUpdate, oledbCnn)

            cmd.Parameters.Add("?", OleDbType.Integer).Value =
            stockMoveID

            cmd.ExecuteNonQuery()

        End Using

        MessageBox.Show(
        "Discrepancy reorder request created successfully.")

        Me.Close()

    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        ValidateCreateButton()
    End Sub

    Private Sub DataGridView1_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved
        ValidateCreateButton()
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        ValidateCreateButton()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As String
        result = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class