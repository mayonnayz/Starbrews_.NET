Imports System.Data.OleDb

Public Class subStockRoom
    Private selectedOrderID As Integer = 0

    Private Sub subStockRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSvisor.Text = "Supervisor: " & vbCrLf & Form1.FirstName & " " & Form1.LastName


        LoadOrders()
        LoadBarista()

        If ListBox1.Items.Count > 0 Then
            ListBox1.SelectedIndex = 0
        End If
    End Sub
    Sub LoadOrders(Optional startDate As Date? = Nothing,
               Optional endDate As Date? = Nothing)

        Dim dt As New DataTable()

        Dim sql As String =
        "SELECT OrderReqID, DateRequested
         FROM OrderReqTbl
         WHERE Status = 'Approved'
         AND OrderStatus = 1"

        If startDate.HasValue AndAlso endDate.HasValue Then
            sql &= " AND DateRequested >= ? AND DateRequested < ?"
        End If

        sql &= " ORDER BY OrderReqID DESC"

        Using cmd As New OleDbCommand(sql, oledbCnn)

            If startDate.HasValue AndAlso endDate.HasValue Then

                cmd.Parameters.AddWithValue("?", startDate.Value.Date)

                cmd.Parameters.AddWithValue("?", endDate.Value.Date.AddDays(1))

            End If

            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using

        End Using

        ListBox1.DataSource = dt
        ListBox1.DisplayMember = "OrderReqID"
        ListBox1.ValueMember = "OrderReqID"

        selectedOrderID = 0
        DataGridView1.DataSource = Nothing
    End Sub

    Sub LoadItems()
        Dim dt As New DataTable()

        DataGridView1.DataSource = Nothing
        DataGridView1.Columns.Clear()

        If selectedOrderID > 0 Then

            Dim sql As String =
            "SELECT 
                i.ItemID,
                i.ItemName,
                c.CatName AS Category,
                ori.Quantity AS RequestedQty,
                i.Unit
            FROM ((ReqItemsTbl ori
            INNER JOIN ItemsTbl i ON ori.ItemID = i.ItemID)
            INNER JOIN CategoriesTbl c ON i.ItemCategory = c.CategoryID)
            WHERE ori.OrderReqID = ?"

            Using cmd As New OleDbCommand(sql, oledbCnn)
                cmd.Parameters.Add("?", OleDbType.Integer).Value = selectedOrderID

                Using da As New OleDbDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            dt.Columns.Add("ReceivedQty", GetType(Integer))

            DataGridView1.DataSource = dt

            DataGridView1.AllowUserToAddRows = False
            DataGridView1.Columns("ItemID").Visible = False

            DataGridView1.Columns("RequestedQty").ReadOnly = True
            DataGridView1.Columns("ReceivedQty").ReadOnly = False

            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Else

            Dim sql As String =
            "SELECT 
                i.ItemID,
                i.ItemName,
                c.CatName AS Category,
                s.CurrentQuantity AS CurrentQty,
                i.Unit,
                i.UnitPrice
            FROM (ItemsTbl i
            INNER JOIN CategoriesTbl c ON i.ItemCategory = c.CategoryID)
            INNER JOIN StockRoomTbl s ON i.ItemID = s.ItemID
            WHERE i.ItemStatus = 1"

            Using da As New OleDbDataAdapter(sql, oledbCnn)
                da.Fill(dt)
            End Using

            dt.Columns.Add("MoveQty", GetType(Integer))
            DataGridView1.DataSource = dt

            DataGridView1.AllowUserToAddRows = False
            DataGridView1.Columns("ItemID").Visible = False

            DataGridView1.Columns("ItemName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            DataGridView1.Columns("CurrentQty").Width = 80
            DataGridView1.Columns("Unit").Width = 60
            DataGridView1.Columns("UnitPrice").Width = 80
            DataGridView1.Columns("UnitPrice").DefaultCellStyle.Format = "C2"

            For Each col As DataGridViewColumn In DataGridView1.Columns
                col.ReadOnly = True
            Next

            DataGridView1.Columns("MoveQty").ReadOnly = False
            DataGridView1.Columns("MoveQty").HeaderText = "Quantity"
        End If

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

        If cmbBarista.SelectedValue Is Nothing OrElse IsDBNull(cmbBarista.SelectedValue) Then
            MessageBox.Show("Please select a barista.")
            Exit Sub
        End If


        If selectedOrderID = 0 Then
            MessageBox.Show("Please select an order.")
            Exit Sub
        End If

        Dim checkSql As String =
            "SELECT Status FROM OrderReqTbl WHERE OrderReqID = ?"

        Dim statusObj As Object

        Using cmd As New OleDbCommand(checkSql, oledbCnn)
            cmd.Parameters.Add("?", OleDbType.Integer).Value = selectedOrderID
            statusObj = cmd.ExecuteScalar()
        End Using

        If statusObj Is Nothing OrElse IsDBNull(statusObj) Then
            MessageBox.Show("Invalid order selected.")
            Exit Sub
        End If

        If statusObj.ToString() <> "Approved" Then
            MessageBox.Show("This order is not approved.")
            Exit Sub
        End If

        For Each row As DataGridViewRow In DataGridView1.Rows

            If row.IsNewRow Then Continue For

            If row.Cells("ReceivedQty").Value Is Nothing OrElse
       row.Cells("ReceivedQty").Value.ToString().Trim = "" Then

                row.Cells("ReceivedQty").Value = 0

            End If

            Dim receivedQty As Integer

            If Not Integer.TryParse(row.Cells("ReceivedQty").Value.ToString(), receivedQty) Then
                MessageBox.Show("Invalid received quantity.")
                Exit Sub
            End If

            If receivedQty < 0 Then
                MessageBox.Show("Received quantity cannot be negative.")
                Exit Sub
            End If

        Next

        If MessageBox.Show(
    "Confirm stock transaction?",
    "Confirm",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question) <> DialogResult.Yes Then

            Exit Sub

        End If

        Dim stockMoveID As Integer

        Dim sqlMove As String =
            "INSERT INTO StockMovementTbl 
            (SupervisorID, BaristaID, MovementType, DateSubmitted, OrderReqID, DiscStatus)
            VALUES (?, ?, ?, ?, ?, ?)"

        Using cmd As New OleDbCommand(sqlMove, oledbCnn)

            cmd.Parameters.Add("?", OleDbType.Integer).Value = Form1.UserId
            cmd.Parameters.Add("?", OleDbType.Integer).Value = Convert.ToInt32(cmbBarista.SelectedValue)
            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = "STOCK IN"
            cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now

            cmd.Parameters.Add("?", OleDbType.Integer).Value = Convert.ToInt32(selectedOrderID)

            cmd.Parameters.Add("?", OleDbType.Integer).Value = 0

            cmd.ExecuteNonQuery()
        End Using

        Using cmd As New OleDbCommand("SELECT @@IDENTITY", oledbCnn)
            stockMoveID = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Dim hasPositiveDiscrepancy As Boolean = False
        Dim hasNegativeDiscrepancy As Boolean = False

        For Each row As DataGridViewRow In DataGridView1.Rows

            If row.IsNewRow Then Continue For

            Dim itemID As Integer = Convert.ToInt32(row.Cells("ItemID").Value)


            Dim receivedQty As Integer
            If Not Integer.TryParse(row.Cells("ReceivedQty").Value?.ToString(), receivedQty) Then
                MessageBox.Show("Invalid received quantity.")
                Exit Sub
            End If

            Dim requestedQty As Integer = Convert.ToInt32(row.Cells("RequestedQty").Value)

            Dim currentQty As Integer = 0

            Dim getSql As String =
                "SELECT CurrentQuantity FROM StockRoomTbl WHERE ItemID = ?"

            Using cmdGet As New OleDbCommand(getSql, oledbCnn)
                cmdGet.Parameters.Add("?", OleDbType.Integer).Value = itemID
                Dim result = cmdGet.ExecuteScalar()

                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    currentQty = Convert.ToInt32(result)
                End If
            End Using

            Dim newQty As Integer = currentQty + receivedQty
            Dim discrepancy As Integer = requestedQty - receivedQty

            If discrepancy > 0 Then
                hasPositiveDiscrepancy = True
            ElseIf discrepancy < 0 Then
                hasNegativeDiscrepancy = True
            End If

            Dim updateSql As String =
                "UPDATE StockRoomTbl SET CurrentQuantity = ? WHERE ItemID = ?"

            Using cmdUpdate As New OleDbCommand(updateSql, oledbCnn)
                cmdUpdate.Parameters.Add("?", OleDbType.Integer).Value = newQty
                cmdUpdate.Parameters.Add("?", OleDbType.Integer).Value = itemID
                cmdUpdate.ExecuteNonQuery()
            End Using

            Dim detailSql As String =
                "INSERT INTO StockMoveItemsTbl 
                    (StockItemID, StockMoveID, RequestedQuantity, ReceivedQuantity, Discrepancy)
                    VALUES (?, ?, ?, ?, ?)"

            Using cmdDetail As New OleDbCommand(detailSql, oledbCnn)
                cmdDetail.Parameters.Add("?", OleDbType.Integer).Value = itemID
                cmdDetail.Parameters.Add("?", OleDbType.Integer).Value = stockMoveID
                cmdDetail.Parameters.Add("?", OleDbType.Integer).Value = requestedQty
                cmdDetail.Parameters.Add("?", OleDbType.Integer).Value = receivedQty
                cmdDetail.Parameters.Add("?", OleDbType.Integer).Value = discrepancy
                cmdDetail.ExecuteNonQuery()
            End Using


        Next

        Dim discStatus As Integer = 0

        If hasPositiveDiscrepancy Then

            discStatus = 1

        ElseIf hasNegativeDiscrepancy Then

            discStatus = 2

        End If

        Dim discSql As String =
        "UPDATE StockMovementTbl
         SET DiscStatus = ?
         WHERE StockMovementID = ?"

        Using cmdDisc As New OleDbCommand(discSql, oledbCnn)

            cmdDisc.Parameters.Add("?", OleDbType.Integer).Value = discStatus
            cmdDisc.Parameters.Add("?", OleDbType.Integer).Value = stockMoveID

            cmdDisc.ExecuteNonQuery()

        End Using


        Dim updateOrder As String =
                "UPDATE OrderReqTbl SET OrderStatus = 2 WHERE OrderReqID = ?"

            Using cmd As New OleDbCommand(updateOrder, oledbCnn)
                cmd.Parameters.Add("?", OleDbType.Integer).Value = selectedOrderID
                cmd.ExecuteNonQuery()
            End Using


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

    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing

        If DataGridView1.CurrentCell Is Nothing Then Exit Sub

        If (DataGridView1.Columns.Contains("MoveQty") AndAlso
        DataGridView1.CurrentCell.ColumnIndex = DataGridView1.Columns("MoveQty").Index) _
    OrElse
       (DataGridView1.Columns.Contains("ReceivedQty") AndAlso
        DataGridView1.CurrentCell.ColumnIndex = DataGridView1.Columns("ReceivedQty").Index) Then

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

    Private Sub ListBox1_Format(sender As Object, e As ListControlConvertEventArgs) Handles ListBox1.Format

        Dim orderID As Integer = Convert.ToInt32(e.ListItem("OrderReqID"))
        Dim dateRequested As Date = Convert.ToDateTime(e.ListItem("DateRequested"))

        e.Value = "Order No. " & orderID &
              " - " &
              dateRequested.ToString("MM/dd/yyyy")

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        If ListBox1.SelectedValue Is Nothing Then Exit Sub

        If TypeOf ListBox1.SelectedValue Is DataRowView Then Exit Sub

        selectedOrderID = Convert.ToInt32(ListBox1.SelectedValue)

        Dim sql As String =
        "SELECT DateRequested
         FROM OrderReqTbl
         WHERE OrderReqID = ?"

        Using cmd As New OleDbCommand(sql, oledbCnn)

            cmd.Parameters.Add("?", OleDbType.Integer).Value = selectedOrderID

            Dim result = cmd.ExecuteScalar()

            If result IsNot Nothing AndAlso Not IsDBNull(result) Then

                Dim reqDate As Date = Convert.ToDateTime(result)

                Label5.Text = "Date Requested: " &
                          reqDate.ToString("MM/dd/yyyy hh:mm tt")

            Else

                Label5.Text = "Date Requested:"

            End If

        End Using

        LoadItems()

    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadOrders(dtStart.Value.Date, dtEnd.Value.Date)
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        LoadOrders()
    End Sub

    Private Sub dtStart_ValueChanged(sender As Object, e As EventArgs) Handles dtStart.ValueChanged
        dtEnd.MinDate = dtStart.Value.Date
    End Sub

    Private Sub dtEnd_ValueChanged(sender As Object, e As EventArgs) Handles dtEnd.ValueChanged
        dtStart.MaxDate = dtEnd.Value.Date
    End Sub
End Class