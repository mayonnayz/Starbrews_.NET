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
        btnEditSupplier.Visible = True
        btnAddSupplier.Visible = True

        LoadCategories()
        UpdateSupplierButtons()
        LoadSuppliers(1)
    End Sub

    Private Sub LoadCategories()
        Try
            Dim sql As String = "SELECT CategoryID, CatName FROM CategoriesTbl WHERE CatStatus = 1"

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
        Dim sql As String = "SELECT SupplierID, SupplierName FROM SupplierTbl WHERE SupplierStatus = ?"

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
        Dim sql As String = "SELECT SupplierID, SupplierName FROM SupplierTbl WHERE SupplierStatus = ?"

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
            btnEditSupplier.Visible = True
            btnAddSupplier.Visible = True
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

            purpose = "View Supplier"
            suppID = Convert.ToInt32(lstSupplier.SelectedValue)

            subSup.ShowDialog()
            LoadSuppliers(1)
        Else
            MessageBox.Show("Please select a supplier to edit.")
        End If
    End Sub

    Private Sub btnViewRequest_Click(sender As Object, e As EventArgs) Handles btnViewRequest.Click
        Dim subView As New subOrderReq()

        subView.ShowDialog()
    End Sub

    Private Sub btnCreateRequest_Click(sender As Object, e As EventArgs) Handles btnCreateRequest.Click
        Dim subAdd As New subCreateReq()

        subAdd.ShowDialog()
    End Sub
End Class
