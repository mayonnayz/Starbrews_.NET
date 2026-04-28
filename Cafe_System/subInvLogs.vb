Imports System.Data.OleDb
Imports System.Net.Security

Public Class subInvLogs
    Private Sub subInvLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If tabInventory.purpose = "Stock Room Logs" Then
            lblTitle.Text = "Stock Room Logs"
            LoadAllStockHistory()
        ElseIf tabInventory.purpose = "Store Inventory Logs" Then
            lblTitle.Text = "Store Inventory Logs"
            LoadAllClosingHistory()
        End If

    End Sub

    Sub LoadClosingHistory(selectedDate As Date)

        Dim dt As New DataTable()

        Dim sql As String = "
            SELECT 
                c.ClosingID,
                c.DateSubmitted,
                Format(DateSubmitted, 'yyyy-mm-dd hh:nn AM/PM') AS DisplayDate,
                a.FirstName & ' ' & a.LastName AS BaristaName
            FROM ClosingTbl c
            INNER JOIN AccountsTbl a ON c.BaristaID = a.AccountID
            WHERE DateValue(c.DateSubmitted) = ? 
            ORDER BY c.DateSubmitted DESC"

        Using cmd As New OleDbCommand(sql, oledbCnn)
            cmd.Parameters.Add("?", OleDbType.Date).Value = selectedDate.Date

            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        lstDates.DataSource = dt
        lstDates.DisplayMember = "DisplayDate"
        lstDates.ValueMember = "ClosingID"

    End Sub

    Sub LoadAllClosingHistory()

        Dim dt As New DataTable()

        Dim sql As String = "
    SELECT 
        c.ClosingID,
        c.DateSubmitted,
        a.FirstName & ' ' & a.LastName AS BaristaName
    FROM ClosingTbl c
    INNER JOIN AccountsTbl a ON c.BaristaID = a.AccountID
    ORDER BY c.DateSubmitted DESC"

        Using cmd As New OleDbCommand(sql, oledbCnn)
            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        lstDates.DataSource = dt
        lstDates.DisplayMember = "DateSubmitted"
        lstDates.ValueMember = "ClosingID"

    End Sub
    Sub LoadAllStockHistory()

        Dim dt As New DataTable()

        Dim sql As String =
    "SELECT 
        sm.StockMovementID,
        sm.DateSubmitted,
        a.FirstName & ' ' & a.LastName AS BaristaName,
        s.FirstName & ' ' & s.LastName AS SupervisorName,
        sm.MovementType
    FROM (StockMovementTbl sm
    INNER JOIN AccountsTbl a ON sm.BaristaID = a.AccountID)
    INNER JOIN AccountsTbl s ON sm.SupervisorID = s.AccountID
    ORDER BY sm.DateSubmitted DESC"

        Using cmd As New OleDbCommand(sql, oledbCnn)
            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        lstDates.DataSource = dt
        lstDates.DisplayMember = "DateSubmitted"
        lstDates.ValueMember = "StockMovementID"

    End Sub
    Sub LoadClosingDetails(closingID As Integer)

        Dim sql As String = "
        SELECT 
            c.ClosingID,
            c.DateSubmitted,
            b.FirstName & ' ' & b.LastName AS BaristaName,
            s.FirstName & ' ' & s.LastName AS SupervisorName
        FROM (ClosingTbl c
        INNER JOIN AccountsTbl b ON c.BaristaID = b.AccountID)
        INNER JOIN AccountsTbl s ON c.SupervisorID = s.AccountID
        WHERE c.ClosingID = ?"

        Using cmd As New OleDbCommand(sql, oledbCnn)
            cmd.Parameters.Add("?", OleDbType.Integer).Value = closingID

            Using reader = cmd.ExecuteReader()
                If reader.Read() Then

                    lblTransac.Text = "TransactionID: " & closingID
                    lblBarista.Text = "Barista: " & reader("BaristaName").ToString()
                    lblSuper.Text = "Supervisor: " & reader("SupervisorName").ToString()
                    lblDate.Text = "Date/Time: " & Convert.ToDateTime(reader("DateSubmitted"))

                End If
            End Using
        End Using

    End Sub

    Sub LoadStockDetails(stockMoveID As Integer)

        Dim sql As String =
            "SELECT 
                sm.StockMovementID,
                sm.DateSubmitted,
                sm.MovementType,
                b.FirstName & ' ' & b.LastName AS BaristaName,
                s.FirstName & ' ' & s.LastName AS SupervisorName
            FROM (StockMovementTbl sm
            INNER JOIN AccountsTbl b ON sm.BaristaID = b.AccountID)
            INNER JOIN AccountsTbl s ON sm.SupervisorID = s.AccountID
            WHERE sm.StockMovementID = ?"

        Using cmd As New OleDbCommand(sql, oledbCnn)
            cmd.Parameters.Add("?", OleDbType.Integer).Value = stockMoveID

            Using reader = cmd.ExecuteReader()
                If reader.Read() Then

                    lblTransac.Text = "TransactionID: " & stockMoveID
                    lblBarista.Text = "Barista: " & reader("BaristaName").ToString()
                    lblSuper.Text = "Supervisor: " & reader("SupervisorName").ToString()
                    lblDate.Text = "Date/Time: " & Convert.ToDateTime(reader("DateSubmitted"))
                    lblTitle.Text = reader("MovementType").ToString()

                End If
            End Using
        End Using

    End Sub

    Sub LoadClosingItems(closingID As Integer)

        Dim dt As New DataTable()

        Dim sql As String = "
        SELECT 
            i.ItemName,
            c.CatName AS Category,
            ci.ClosingQuantity,
            i.Unit
        FROM (ClosingItemsTbl ci
        INNER JOIN ItemsTbl i ON ci.ItemID = i.ItemID)
        INNER JOIN CategoriesTbl c ON i.ItemCategory = c.CategoryID
        WHERE ci.ClosingID = ?"

        Using cmd As New OleDbCommand(sql, oledbCnn)
            cmd.Parameters.Add("?", OleDbType.Integer).Value = closingID

            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        DataGridView1.DataSource = dt

    End Sub
    Sub LoadStockItems(stockMoveID As Integer)

        Dim dt As New DataTable()

        Dim sql As String =
    "SELECT 
        i.ItemName,
        c.CatName AS Category,
        smi.MoveQuantity,
        i.Unit
    FROM ((StockMoveItemsTbl smi
    INNER JOIN ItemsTbl i ON smi.StockItemID = i.ItemID)
    INNER JOIN CategoriesTbl c ON i.ItemCategory = c.CategoryID)
    WHERE smi.StockMoveID = ?"

        Using cmd As New OleDbCommand(sql, oledbCnn)
            cmd.Parameters.Add("?", OleDbType.Integer).Value = stockMoveID

            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        DataGridView1.DataSource = dt

    End Sub

    Private Sub datePicker_ValueChanged(sender As Object, e As EventArgs) Handles datePicker.ValueChanged
        LoadClosingHistory(datePicker.Value)
    End Sub

    Private Sub lstDates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDates.SelectedIndexChanged

        If lstDates.SelectedValue Is Nothing Then Exit Sub
        If TypeOf lstDates.SelectedValue Is DataRowView Then Exit Sub

        Dim id As Integer
        If Not Integer.TryParse(lstDates.SelectedValue.ToString(), id) Then Exit Sub

        If tabInventory.purpose = "Stock Room Logs" Then
            LoadStockDetails(id)
            LoadStockItems(id)
        Else
            LoadClosingDetails(id)
            LoadClosingItems(id)
        End If

    End Sub
End Class