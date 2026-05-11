Imports System.Data.OleDb
Imports System.Globalization

Public Class subClosing
    Private Sub subClosing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBarista.Text = "Barista: " & Form1.FirstName & " " & Form1.LastName
        lblDate.Text = "Date: " & DateTime.Now

        LoadSupervisor()

        If OpenConnection() Then
            LoadItems()
        End If
    End Sub

    Sub LoadItems()
        Dim dtItems As New DataTable()
        Dim sql As String = ""

        sql = "SELECT i.ItemID, i.ItemName, c.CatName AS Category, i.Quantity, i.Unit, " &
          "i.UnitPrice " &
          "FROM ItemsTbl i " &
          "INNER JOIN CategoriesTbl c ON i.ItemCategory = c.CategoryID WHERE ItemStatus = 1 AND i.Quantity <> 0"

        Using da As New OleDbDataAdapter(sql, oledbCnn)
            da.Fill(dtItems)
        End Using

        dtItems.Columns.Add("ClosingQty", GetType(Integer))

        DataGridView1.DataSource = dtItems

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.Columns("ItemID").Visible = False
        DataGridView1.Columns("UnitPrice").DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US")
        DataGridView1.Columns("UnitPrice").DefaultCellStyle.Format = "C2"
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        DataGridView1.Columns("Quantity").Width = 80
        DataGridView1.Columns("Unit").Width = 60
        DataGridView1.Columns("UnitPrice").Width = 80
        DataGridView1.Columns("ItemName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.ReadOnly = True
        Next

        DataGridView1.Columns("ClosingQty").ReadOnly = False
        DataGridView1.Columns("ClosingQty").HeaderText = "Closing Qty"
        DataGridView1.Columns("ClosingQty").Width = 80
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        btnCreate.Enabled = False

        If cmbSupervisor.SelectedValue Is Nothing OrElse IsDBNull(cmbSupervisor.SelectedValue) Then
            MessageBox.Show("Please select a supervisor.")
            btnCreate.Enabled = True
            Exit Sub
        End If

        Dim result = MessageBox.Show("Are all quantities final?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result <> DialogResult.Yes Then
            btnCreate.Enabled = True
            Exit Sub
        End If

        ' =========================
        ' VALIDATION
        ' =========================
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.IsNewRow Then Continue For

            Dim originalQty As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
            Dim closingQty As Integer

            If row.Cells("ClosingQty").Value Is Nothing OrElse row.Cells("ClosingQty").Value.ToString() = "" Then
                MessageBox.Show("Please enter all closing quantities.")
                btnCreate.Enabled = True
                Exit Sub
            End If

            If Not Integer.TryParse(row.Cells("ClosingQty").Value.ToString(), closingQty) Then
                MessageBox.Show("Invalid quantity input.")
                btnCreate.Enabled = True
                Exit Sub
            End If

            If closingQty < 0 Then
                MessageBox.Show("Closing quantity cannot be negative.")
                btnCreate.Enabled = True
                Exit Sub
            End If

            If closingQty > originalQty Then
                MessageBox.Show("Closing quantity cannot exceed starting quantity.")
                btnCreate.Enabled = True
                Exit Sub
            End If
        Next

        ' =========================
        ' INSERT HEADER
        ' =========================
        Dim closingID As Integer

        Dim sqlClosing As String = "INSERT INTO ClosingTbl (BaristaID, SupervisorID, DateSubmitted) VALUES (?, ?, ?)"

        Using cmd As New OleDbCommand(sqlClosing, oledbCnn)
            cmd.Parameters.Add("?", OleDbType.Integer).Value = Convert.ToInt32(Form1.UserId)
            cmd.Parameters.Add("?", OleDbType.Integer).Value = Convert.ToInt32(cmbSupervisor.SelectedValue)
            cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now
            cmd.ExecuteNonQuery()
        End Using

        Using cmd As New OleDbCommand("SELECT @@IDENTITY", oledbCnn)
            closingID = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        ' =========================
        ' INSERT ITEMS + UPDATE STOCK
        ' =========================
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.IsNewRow Then Continue For

            Dim itemID As Integer = Convert.ToInt32(row.Cells("ItemID").Value)
            Dim originalQty As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
            Dim closingQty As Integer = Convert.ToInt32(row.Cells("ClosingQty").Value)

            ' ✅ COMPUTE USED
            Dim quantityUsed As Integer = originalQty - closingQty

            ' SAFETY CHECK
            If quantityUsed < 0 Then
                MessageBox.Show("Closing quantity cannot exceed starting quantity.")
                btnCreate.Enabled = True
                Exit Sub
            End If

            ' =========================
            ' INSERT LOG
            ' =========================
            Dim sqlItem As String = "
        INSERT INTO ClosingItemsTbl 
        (ItemID, StartingQuantity, ClosingQuantity, QuantityUsed, ClosingID) 
        VALUES (?, ?, ?, ?, ?)"

            Using cmd As New OleDbCommand(sqlItem, oledbCnn)
                cmd.Parameters.Add("?", OleDbType.Integer).Value = itemID
                cmd.Parameters.Add("?", OleDbType.Integer).Value = originalQty
                cmd.Parameters.Add("?", OleDbType.Integer).Value = closingQty
                cmd.Parameters.Add("?", OleDbType.Integer).Value = quantityUsed
                cmd.Parameters.Add("?", OleDbType.Integer).Value = closingID
                cmd.ExecuteNonQuery()
            End Using

            ' =========================
            ' UPDATE INVENTORY (FINAL COUNT)
            ' =========================
            Dim sqlUpdate As String = "UPDATE ItemsTbl SET Quantity = ? WHERE ItemID = ?"

            Using cmdUpdate As New OleDbCommand(sqlUpdate, oledbCnn)
                cmdUpdate.Parameters.Add("?", OleDbType.Integer).Value = closingQty
                cmdUpdate.Parameters.Add("?", OleDbType.Integer).Value = itemID
                cmdUpdate.ExecuteNonQuery()
            End Using

        Next

        MessageBox.Show("Closing successfully recorded!")
        Me.Close()

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
    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        If DataGridView1.CurrentCell.ColumnIndex = DataGridView1.Columns("ClosingQty").Index Then
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