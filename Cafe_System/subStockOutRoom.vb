Imports System.Data.OleDb

Public Class subStockOutRoom
    Private Sub subStockOutRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblSvisor.Text = "Supervisor: " & vbCrLf & Form1.FirstName & " " & Form1.LastName
        btnStock.Text = "STOCK OUT"

        LockControls()
        LoadCategories()
        SetupGrid()
        LoadBarista()

    End Sub

    Private Sub LoadItems()

        If cmbCategory.SelectedIndex = -1 Then Exit Sub
        If cmbCategory.SelectedValue Is Nothing Then Exit Sub
        If TypeOf cmbCategory.SelectedValue Is DataRowView Then Exit Sub
        If IsDBNull(cmbCategory.SelectedValue) Then Exit Sub

        Dim dt As New DataTable()

        Dim sql As String =
    "SELECT ItemID, ItemName 
     FROM ItemsTbl 
     WHERE ItemStatus = 1 
     AND ItemCategory = ?
     AND ItemName LIKE ?"

        Using cmd As New OleDbCommand(sql, oledbCnn)

            cmd.Parameters.Add("?", OleDbType.Integer).Value =
        Convert.ToInt32(cmbCategory.SelectedValue)

            cmd.Parameters.Add("?", OleDbType.VarWChar).Value =
        "%" & txtSearch.Text.Trim & "%"

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

    Private Sub LockControls()

        lstItem.Enabled = False
        btnAdd.Enabled = False
        btnRemove.Enabled = False

        txtQuantity.ReadOnly = True
        txtUnit.ReadOnly = True

    End Sub

    Private Sub LoadCategories()

        Dim dt As New DataTable()

        Dim sql As String = "SELECT CategoryID, CatName FROM CategoriesTbl"

        Using da As New OleDbDataAdapter(sql, oledbCnn)
            da.Fill(dt)
        End Using

        cmbCategory.DataSource = dt
        cmbCategory.DisplayMember = "CatName"
        cmbCategory.ValueMember = "CategoryID"

        cmbCategory.SelectedIndex = -1
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList

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
        If Not IsNumeric(lstItem.SelectedValue) Then Exit Sub

        Dim itemID As Integer = Convert.ToInt32(lstItem.SelectedValue)

        Dim sql As String =
    "SELECT i.Unit, s.CurrentQuantity
     FROM ItemsTbl i
     INNER JOIN StockRoomTbl s ON i.ItemID = s.ItemID
     WHERE i.ItemID = ?"

        Using cmd As New OleDbCommand(sql, oledbCnn)
            cmd.Parameters.Add("?", OleDbType.Integer).Value = itemID

            Using reader = cmd.ExecuteReader()
                If reader.Read() Then
                    txtUnit.Text = reader("Unit").ToString()
                    txtQuantity.Text = reader("CurrentQuantity").ToString()
                Else
                    txtUnit.Clear()
                    txtQuantity.Text = "0"
                End If
            End Using
        End Using

        txtQuantity.ReadOnly = True

        ValidateControls()

    End Sub

    Private Sub ValidateControls()

        btnAdd.Enabled =
        cmbCategory.SelectedIndex <> -1 AndAlso
        lstItem.SelectedIndex <> -1 AndAlso
        txtQuantity.Text.Trim <> "" AndAlso
        Val(txtQuantity.Text) > 0

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

        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False

        DataGridView1.Columns.Add("ItemID", "ItemID")
        DataGridView1.Columns.Add("ItemName", "Item")

        DataGridView1.Columns.Add("CurrentQty", "Current Qty")
        DataGridView1.Columns.Add("Unit", "Unit")
        DataGridView1.Columns.Add("ItemPrice", "Price")

        Dim colQty As New DataGridViewTextBoxColumn()
        colQty.Name = "MoveQty"
        colQty.HeaderText = "Stock Out Qty"
        colQty.DefaultCellStyle.NullValue = ""
        DataGridView1.Columns.Add(colQty)

        DataGridView1.Columns("ItemID").Visible = False

        DataGridView1.Columns("ItemName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        DataGridView1.Columns("CurrentQty").Width = 90
        DataGridView1.Columns("Unit").Width = 60
        DataGridView1.Columns("ItemPrice").Width = 80
        DataGridView1.Columns("MoveQty").Width = 110

        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.ReadOnly = True
        Next

        DataGridView1.Columns("MoveQty").ReadOnly = False

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If lstItem.SelectedValue Is Nothing Then Exit Sub

        Dim itemID As Integer = Convert.ToInt32(lstItem.SelectedValue)
        Dim currentQty As Integer = Convert.ToInt32(txtQuantity.Text)

        For Each row As DataGridViewRow In DataGridView1.Rows

            If row.IsNewRow Then Continue For

            If Convert.ToInt32(row.Cells("ItemID").Value) = itemID Then

                MessageBox.Show("Item already added.", "Duplicate Item",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Exit Sub

            End If

        Next

        DataGridView1.Rows.Add(
        itemID,
        lstItem.Text,
        currentQty,
        txtUnit.Text,
        GetItemPrice(itemID),
        ""
    )

        btnAdd.Enabled = False

    End Sub
    Private Function GetItemPrice(itemID As Integer) As Decimal

        Dim sql As String = "SELECT UnitPrice FROM ItemsTbl WHERE ItemID = ?"

        Using cmd As New OleDbCommand(sql, oledbCnn)
            cmd.Parameters.Add("?", OleDbType.Integer).Value = itemID

            Dim result = cmd.ExecuteScalar()

            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Return Convert.ToDecimal(result)
            End If
        End Using

        Return 0D

    End Function
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

        If cmbBarista.SelectedValue Is Nothing OrElse IsDBNull(cmbBarista.SelectedValue) Then
            MessageBox.Show("Please select a barista.")
            Exit Sub
        End If

        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("Please add at least one item.")
            Exit Sub
        End If

        For Each row As DataGridViewRow In DataGridView1.Rows

            If row.IsNewRow Then Continue For

            Dim currentQty As Integer = Convert.ToInt32(row.Cells("CurrentQty").Value)

            Dim moveObj = row.Cells("MoveQty").Value

            If moveObj Is Nothing OrElse moveObj.ToString().Trim = "" Then
                MessageBox.Show("Stock out quantity cannot be blank for item: " &
                            row.Cells("ItemName").Value.ToString())
                Exit Sub
            End If

            Dim moveQty As Integer

            If Not Integer.TryParse(moveObj.ToString(), moveQty) Then
                MessageBox.Show("Invalid quantity input for item: " &
                            row.Cells("ItemName").Value.ToString())
                Exit Sub
            End If

            If moveQty <= 0 Then
                MessageBox.Show("Quantity must be greater than 0 for item: " &
                            row.Cells("ItemName").Value.ToString())
                Exit Sub
            End If

            If moveQty > currentQty Then
                MessageBox.Show("Not enough stock for item: " &
                            row.Cells("ItemName").Value.ToString())
                Exit Sub
            End If

        Next

        Dim confirm = MessageBox.Show(
        "Confirm stock transaction?",
        "Confirm",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        If confirm <> DialogResult.Yes Then Exit Sub

        Dim stockMoveID As Integer

        Dim sqlMove As String =
        "INSERT INTO StockMovementTbl 
        (SupervisorID, BaristaID, MovementType, DateSubmitted, OrderReqID)
        VALUES (?, ?, ?, ?, ?)"

        Using cmd As New OleDbCommand(sqlMove, oledbCnn)

            cmd.Parameters.Add("?", OleDbType.Integer).Value = Form1.UserId
            cmd.Parameters.Add("?", OleDbType.Integer).Value = Convert.ToInt32(cmbBarista.SelectedValue)
            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = "STOCK OUT"
            cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now
            cmd.Parameters.Add("?", OleDbType.Integer).Value = DBNull.Value

            cmd.ExecuteNonQuery()

        End Using

        Using cmd As New OleDbCommand("SELECT @@IDENTITY", oledbCnn)
            stockMoveID = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        For Each row As DataGridViewRow In DataGridView1.Rows

            If row.IsNewRow Then Continue For

            Dim itemID As Integer = Convert.ToInt32(row.Cells("ItemID").Value)
            Dim currentQty As Integer = Convert.ToInt32(row.Cells("CurrentQty").Value)
            Dim moveQty As Integer = Convert.ToInt32(row.Cells("MoveQty").Value)

            Dim newQty As Integer = currentQty - moveQty

            Dim sqlUpdate As String =
            "UPDATE StockRoomTbl 
             SET CurrentQuantity = ? 
             WHERE ItemID = ?"

            Using cmdUpdate As New OleDbCommand(sqlUpdate, oledbCnn)

                cmdUpdate.Parameters.Add("?", OleDbType.Integer).Value = newQty
                cmdUpdate.Parameters.Add("?", OleDbType.Integer).Value = itemID

                cmdUpdate.ExecuteNonQuery()

            End Using

            Dim sqlItems As String =
            "UPDATE ItemsTbl 
             SET Quantity = Quantity + ? 
             WHERE ItemID = ?"

            Using cmdItems As New OleDbCommand(sqlItems, oledbCnn)

                cmdItems.Parameters.Add("?", OleDbType.Integer).Value = moveQty
                cmdItems.Parameters.Add("?", OleDbType.Integer).Value = itemID

                cmdItems.ExecuteNonQuery()

            End Using

            Dim sqlDetail As String =
            "INSERT INTO StockMoveItemsTbl 
            (StockItemID, StockMoveID, MoveQuantity)
            VALUES (?, ?, ?)"

            Using cmdDetail As New OleDbCommand(sqlDetail, oledbCnn)

                cmdDetail.Parameters.Add("?", OleDbType.Integer).Value = itemID
                cmdDetail.Parameters.Add("?", OleDbType.Integer).Value = stockMoveID
                cmdDetail.Parameters.Add("?", OleDbType.Integer).Value = moveQty

                cmdDetail.ExecuteNonQuery()

            End Using

        Next

        MessageBox.Show("Stock transaction completed!")
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As String
        result = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If DataGridView1.SelectedRows.Count = 0 Then Exit Sub

        If MessageBox.Show("Remove this item?", "Confirm",
        MessageBoxButtons.YesNo) = DialogResult.Yes Then

            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))

        End If

    End Sub

    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing

        If DataGridView1.CurrentCell Is Nothing Then Exit Sub

        If DataGridView1.Columns(DataGridView1.CurrentCell.ColumnIndex).Name = "MoveQty" Then

            Dim tb As TextBox = TryCast(e.Control, TextBox)

            If tb IsNot Nothing Then
                RemoveHandler tb.KeyPress, AddressOf Quantity_KeyPress
                AddHandler tb.KeyPress, AddressOf Quantity_KeyPress
            End If

        End If

    End Sub

    Private Sub Quantity_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged

        btnRemove.Enabled = DataGridView1.SelectedRows.Count > 0

    End Sub

End Class