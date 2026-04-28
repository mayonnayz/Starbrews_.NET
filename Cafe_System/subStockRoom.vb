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
        LoadItems()
    End Sub
    Sub LoadItems()

        Dim dt As New DataTable()

        Dim sql As String =
        "SELECT i.ItemID, i.ItemName, c.CatName AS Category, s.CurrentQuantity AS Quantity, i.Unit, i.UnitPrice " &
        "FROM (ItemsTbl i " &
        "INNER JOIN CategoriesTbl c ON i.ItemCategory = c.CategoryID) " &
        "INNER JOIN StockRoomTbl s ON i.ItemID = s.ItemID " &
        "WHERE i.ItemStatus = 1"

        Using da As New OleDbDataAdapter(sql, oledbCnn)
            da.Fill(dt)
        End Using

        dt.Columns.Add("MoveQty", GetType(Integer))

        DataGridView1.DataSource = dt

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.Columns("ItemID").Visible = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        DataGridView1.Columns("ItemName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns("Quantity").Width = 80
        DataGridView1.Columns("Unit").Width = 60
        DataGridView1.Columns("UnitPrice").Width = 80
        DataGridView1.Columns("UnitPrice").DefaultCellStyle.Format = "C2"

        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.ReadOnly = True
        Next

        DataGridView1.Columns("MoveQty").ReadOnly = False
        DataGridView1.Columns("MoveQty").HeaderText = "Quantity"

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

        Dim confirm = MessageBox.Show("Confirm stock transaction?", "Confirm", MessageBoxButtons.YesNo)
        If confirm <> DialogResult.Yes Then Exit Sub

        ' =========================
        ' 1. INSERT STOCK HEADER
        ' =========================
        Dim stockMoveID As Integer

        Dim sqlMove As String =
            "INSERT INTO StockMovementTbl (SupervisorID, BaristaID, MovementType, DateSubmitted)
         VALUES (?, ?, ?, ?)"

        Using cmd As New OleDbCommand(sqlMove, oledbCnn)

            cmd.Parameters.Add("?", OleDbType.Integer).Value = Form1.UserId
            cmd.Parameters.Add("?", OleDbType.Integer).Value = Convert.ToInt32(cmbBarista.SelectedValue)
            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = tabInventory.purpose
            cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now

            cmd.ExecuteNonQuery()
        End Using

        Using cmd As New OleDbCommand("SELECT @@IDENTITY", oledbCnn)
            stockMoveID = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.IsNewRow Then Continue For

            Dim itemID As Integer = Convert.ToInt32(row.Cells("ItemID").Value)
            Dim currentQty As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
            Dim moveQty As Integer

            If row.Cells("MoveQty").Value Is Nothing OrElse row.Cells("MoveQty").Value.ToString() = "" Then
                MessageBox.Show("Fill all quantities.")
                Exit Sub
            End If

            If Not Integer.TryParse(row.Cells("MoveQty").Value.ToString(), moveQty) Then
                MessageBox.Show("Invalid quantity input.")
                Exit Sub
            End If

            ' =========================
            ' VALIDATION FIXED
            ' =========================

            If moveQty < 0 Then
                MessageBox.Show("Quantity must not be negative.")
                Exit Sub
            End If

            If tabInventory.purpose = "STOCK IN" Then
                If moveQty < 1 Then
                    MessageBox.Show("Invalid stock in quantity.")
                    Exit Sub
                End If
            ElseIf tabInventory.purpose = "STOCK OUT" Then

                If moveQty < 0 Then
                    MessageBox.Show("Invalid quantity.")
                    Exit Sub
                End If

                If moveQty > currentQty Then
                    MessageBox.Show("Not enough stock in Stock Room.")
                    Exit Sub
                End If

                Dim sqlStockRoom As String = "UPDATE StockRoomTbl SET CurrentQuantity = CurrentQuantity - ? WHERE ItemID = ?"

                Using cmd As New OleDbCommand(sqlStockRoom, oledbCnn)
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = moveQty
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = itemID
                    cmd.ExecuteNonQuery()
                End Using

                Dim sqlItems As String = "UPDATE ItemsTbl SET Quantity = Quantity + ? WHERE ItemID = ?"

                Using cmd As New OleDbCommand(sqlItems, oledbCnn)
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = moveQty
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = itemID
                    cmd.ExecuteNonQuery()
                End Using


            End If
            Dim newQty As Integer

            If tabInventory.purpose = "STOCK IN" Then
                newQty = currentQty + moveQty

            Else
                newQty = currentQty - moveQty
            End If
            Dim sqlUpdate As String =
        "UPDATE StockRoomTbl SET CurrentQuantity = ? WHERE ItemID = ?"

            Using cmdUpdate As New OleDbCommand(sqlUpdate, oledbCnn)
                cmdUpdate.Parameters.Add("?", OleDbType.Integer).Value = newQty
                cmdUpdate.Parameters.Add("?", OleDbType.Integer).Value = itemID
                cmdUpdate.ExecuteNonQuery()
            End Using

            Dim sqlDetail As String =
        "INSERT INTO StockMoveItemsTbl (StockItemID, StockMoveID, MoveQuantity)
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

    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        If DataGridView1.CurrentCell.ColumnIndex = DataGridView1.Columns("MoveQty").Index Then
            Dim tb As TextBox = CType(e.Control, TextBox)
            RemoveHandler tb.KeyPress, AddressOf Quantity_KeyPress
            AddHandler tb.KeyPress, AddressOf Quantity_KeyPress
        End If
    End Sub

    Private Sub Quantity_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class