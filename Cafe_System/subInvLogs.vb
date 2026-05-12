Imports System.Data.OleDb
Imports System.Net.Security

Public Class subInvLogs
    Private Sub subInvLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = "Store Inventory Logs"
        LoadAllClosingHistory()

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

        Dim sql As String = "SELECT 
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



    Sub LoadClosingItems(closingID As Integer)

        Dim dt As New DataTable()

        Dim sql As String = "
        SELECT 
            i.ItemName,
            c.CatName AS Category,
            ci.StartingQuantity,
            ci.ClosingQuantity,
            ci.QuantityUsed,
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
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowHeadersVisible = False

        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 214, 200)
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        DataGridView1.Columns("ItemName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        DataGridView1.Columns("StartingQuantity").HeaderText = "Starting Qty"
        DataGridView1.Columns("ClosingQuantity").HeaderText = "Closing Qty"
        DataGridView1.Columns("QuantityUsed").HeaderText = "Used Qty"
        DataGridView1.Columns("StartingQuantity").Width = 80
        DataGridView1.Columns("ClosingQuantity").Width = 80
        DataGridView1.Columns("QuantityUsed").Width = 80
        DataGridView1.Columns("Unit").Width = 70

        DataGridView1.Columns("ItemName").DisplayIndex = 0
        DataGridView1.Columns("Category").DisplayIndex = 1
        DataGridView1.Columns("StartingQuantity").DisplayIndex = 2
        DataGridView1.Columns("ClosingQuantity").DisplayIndex = 3
        DataGridView1.Columns("QuantityUsed").DisplayIndex = 4
        DataGridView1.Columns("Unit").DisplayIndex = 5

    End Sub




    Private Sub datePicker_ValueChanged(sender As Object, e As EventArgs) Handles datePicker.ValueChanged
        LoadClosingHistory(datePicker.Value)
    End Sub

    Private Sub lstDates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDates.SelectedIndexChanged

        If lstDates.SelectedValue Is Nothing Then Exit Sub
        If TypeOf lstDates.SelectedValue Is DataRowView Then Exit Sub

        Dim id As Integer
        If Not Integer.TryParse(lstDates.SelectedValue.ToString(), id) Then Exit Sub

        LoadClosingDetails(id)
        LoadClosingItems(id)

    End Sub
End Class