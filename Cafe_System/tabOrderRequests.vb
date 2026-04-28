Imports System.Data.OleDb
Imports System.Text

Public Class tabOrderRequests
    Dim dt As New DataTable()
    Dim suppStatus As New Integer
    Public Shared suppID As Integer
    Public Shared purpose As String
    Private Sub tabOrderRequests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.UserLvl = 2 Then
            btnAddSupplier.Visible = False
            btnArchiveSupplier.Visible = False
            btnEditSupplier.Visible = False
        End If
        btnViewArch.Text = "VIEW ARCHIVED"
        btnArchiveSupplier.Text = "ARCHIVE SUPPLIER"

        LoadCategories()
        UpdateSupplierButtons()
        LoadSuppliers(1)
        LoadOrders()
    End Sub

    Sub LoadOrders()

        Dim dt As New DataTable()

        Dim sql As String =
        "SELECT 
            o.OrderReqID AS [ID],
            o.DateRequested AS [Date Requested],
            a.FirstName & ' ' & a.LastName AS [Requested By],
            IIF(r.AccountID IS NULL, '', r.FirstName & ' ' & r.LastName) AS [Reviewed By],
            o.Status
         FROM (OrderReqTbl o
         INNER JOIN AccountsTbl a ON o.RequestedBy = a.AccountID)
         LEFT JOIN AccountsTbl r ON o.ReviewedBy = r.AccountID
         ORDER BY o.DateRequested DESC"

        Using da As New OleDbDataAdapter(sql, oledbCnn)
            da.Fill(dt)
        End Using

        DataGridView1.DataSource = dt

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowHeadersVisible = False

        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 214, 200)
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridView1.Columns("ID").Width = 30
        DataGridView1.Columns("Status").Width = 67

        DataGridView1.Columns("Date Requested").DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt"

        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.ReadOnly = True
        Next

    End Sub

    Private Sub LoadCategories()
        Try
            Dim sql As String = "SELECT CategoryID, CatName FROM CategoriesTbl"

            Using cmd As New OleDbCommand(sql, oledbCnn)
                Using adapter As New OleDbDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    Dim newRow As DataRow = dt.NewRow()
                    newRow("CategoryID") = DBNull.Value
                    newRow("CatName") = "All"
                    dt.Rows.InsertAt(newRow, 0)

                    cmbCategory.DataSource = dt
                    cmbCategory.DisplayMember = "CatName"
                    cmbCategory.ValueMember = "CategoryID"

                    cmbCategory.SelectedIndex = 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim dtSuppliers As New DataTable()
        Dim sql As String = "SELECT s.SupplierID, s.SupplierName " &
                    "FROM SupplierTbl s " &
                    "INNER JOIN CategoriesTbl c ON s.SupplierCategory = c.CategoryID " &
                    "WHERE s.SupplierStatus = ?"

        If txtSearch.Text.Trim <> "" Then
            sql &= " AND SupplierName LIKE ?"
        End If

        If cmbCategory.SelectedValue IsNot DBNull.Value Then
            sql &= " AND SupplierCategory = ?"
        End If

        Using cmd As New OleDbCommand(sql, oledbCnn)

            If btnViewArch.Text = "VIEW ARCHIVED" Then
                cmd.Parameters.AddWithValue("?", 1)
            Else
                cmd.Parameters.AddWithValue("?", 0)
            End If

            If txtSearch.Text.Trim <> "" Then
                cmd.Parameters.AddWithValue("?", "%" & txtSearch.Text & "%")
            End If

            If cmbCategory.SelectedValue IsNot DBNull.Value Then
                cmd.Parameters.AddWithValue("?", cmbCategory.SelectedValue)
            End If

            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dtSuppliers)
            End Using
        End Using

        lstSupplier.DataSource = dtSuppliers
        lstSupplier.DisplayMember = "SupplierName"
        lstSupplier.ValueMember = "SupplierID"
        lstSupplier.ClearSelected()

        UpdateSupplierButtons()
    End Sub

    Sub LoadSuppliers(suppStatus As Integer)
        dt.Clear()
        Dim dtSuppliers As New DataTable()
        Dim sql As String = ""

        sql = "SELECT s.SupplierID, s.SupplierName " &
          "FROM SupplierTbl s " &
          "INNER JOIN CategoriesTbl c ON s.SupplierCategory = c.CategoryID " &
          "WHERE s.SupplierStatus = ?"

        Using da As New OleDbDataAdapter(sql, oledbCnn)
            da.SelectCommand.Parameters.AddWithValue("?", suppStatus)
            da.Fill(dtSuppliers)
        End Using

        lstSupplier.DataSource = dtSuppliers
        lstSupplier.DisplayMember = "SupplierName"
        lstSupplier.ValueMember = "SupplierID"
        lstSupplier.ClearSelected()
        UpdateSupplierButtons()
    End Sub

    Private Sub lstSuppliers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSupplier.SelectedIndexChanged
        UpdateSupplierButtons()
    End Sub

    Private Sub UpdateSupplierButtons()
        If lstSupplier.SelectedIndex = -1 Then
            btnEditSupplier.Enabled = False
            btnArchiveSupplier.Enabled = False
        Else
            btnEditSupplier.Enabled = True
            btnArchiveSupplier.Enabled = True
        End If
    End Sub

    Private Sub btnViewArch_Click(sender As Object, e As EventArgs) Handles btnViewArch.Click
        If btnViewArch.Text = "VIEW ARCHIVED" Then
            dt.Clear()
            btnViewArch.Text = "VIEW ACTIVE"
            btnArchiveSupplier.Text = "RESTORE SUPPLIER"
            btnEditSupplier.Visible = False
            btnAddSupplier.Visible = False
            LoadSuppliers(0)
        ElseIf btnViewArch.Text = "VIEW ACTIVE" Then
            dt.Clear()
            btnViewArch.Text = "VIEW ARCHIVED"
            btnArchiveSupplier.Text = "ARCHIVE SUPPLIER"

            If Form1.UserLvl = 2 Then
                btnAddSupplier.Visible = False
                btnArchiveSupplier.Visible = False
                btnEditSupplier.Visible = False
            Else
                btnEditSupplier.Visible = True
                btnAddSupplier.Visible = True
            End If


            LoadSuppliers(1)
        End If
    End Sub

    Private Sub btnArchiveSupplier_Click(sender As Object, e As EventArgs) Handles btnArchiveSupplier.Click
        Dim result As String
        Dim dialogue As String = ""
        If btnArchiveSupplier.Text = "ARCHIVE SUPPLIER" Then
            dialogue = "Are you sure you want to archive this supplier? (it will be moved to archived suppliers)"
        ElseIf btnArchiveSupplier.Text = "RESTORE SUPPLIER" Then
            dialogue = "Are you sure you want to restore this supplier?"
        End If

        suppID = Convert.ToInt32(lstSupplier.SelectedValue)

        result = MessageBox.Show(dialogue, "Archive Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Dim sql As String

            If btnArchiveSupplier.Text = "ARCHIVE SUPPLIER" Then
                sql = "UPDATE SupplierTbl SET SupplierStatus = 0 WHERE SupplierID = ?"

                Using cmd As New OleDbCommand(sql, oledbCnn)
                    cmd.Parameters.AddWithValue("?", suppID)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Supplier archived!")
                LoadSuppliers(1)
            ElseIf btnArchiveSupplier.Text = "RESTORE SUPPLIER" Then
                sql = "UPDATE SupplierTbl SET SupplierStatus = 1 WHERE SupplierID = ?"

                Using cmd As New OleDbCommand(sql, oledbCnn)
                    cmd.Parameters.AddWithValue("?", suppID)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Supplier restored!")
                LoadSuppliers(0)
            End If
        End If

    End Sub

    Private Sub btnAddSupplier_Click(sender As Object, e As EventArgs) Handles btnAddSupplier.Click
        Dim subSup As New subSuppliers()

        purpose = "Add New Supplier"

        subSup.ShowDialog()
        LoadSuppliers(1)
    End Sub

    Private Sub btnEditSupplier_Click(sender As Object, e As EventArgs) Handles btnEditSupplier.Click
        If lstSupplier.SelectedIndex <> -1 Then

            Dim subSup As New subSuppliers()

            purpose = "Edit Supplier"
            suppID = Convert.ToInt32(lstSupplier.SelectedValue)

            subSup.ShowDialog()
            LoadSuppliers(1)
        Else
            MessageBox.Show("Please select a supplier to edit.")
        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting

        If DataGridView1.Columns(e.ColumnIndex).Name = "Status" Then

            If e.Value Is Nothing Then Exit Sub

            Select Case e.Value.ToString().ToLower()

                Case "pending"
                    e.CellStyle.BackColor = Color.FromArgb(255, 255, 204)
                    e.CellStyle.ForeColor = Color.Black

                Case "rejected"
                    e.CellStyle.BackColor = Color.FromArgb(255, 204, 204)
                    e.CellStyle.ForeColor = Color.Black

                Case "approved"
                    e.CellStyle.BackColor = Color.FromArgb(204, 255, 204)
                    e.CellStyle.ForeColor = Color.Black

            End Select

        End If

    End Sub

    Private Sub btnViewRequest_Click(sender As Object, e As EventArgs) Handles btnViewRequest.Click

        If DataGridView1.CurrentRow Is Nothing Then Exit Sub

        Dim reqID As Integer = Convert.ToInt32(DataGridView1.CurrentRow.Cells("ID").Value)

        Dim frm As New subOrderReq()
        frm.OrderReqID = reqID
        frm.ShowDialog()

        LoadOrders()

    End Sub

    Private Sub btnCreateRequest_Click(sender As Object, e As EventArgs) Handles btnCreateRequest.Click
        Dim subAdd As New subCreateReq()
        subAdd.ShowDialog()

        LoadOrders()
    End Sub

End Class
