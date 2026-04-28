Imports System.Data.OleDb

Public Class tabItems
    Dim dt As New DataTable()
    Dim sql As String
    Dim status As Integer = 1

    Public Shared purpose As String
    Public Shared itemId As Integer
    Public Shared itemName As String
    Public Shared itemDesc As String
    Public Shared itemCategory As Integer
    Public Shared unitPrice As Decimal
    Public Shared unit As String
    Private Sub tabItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        status = 1

        btnViewArch.Text = "VIEW ARCHIVED ITEMS"
        btnAddItem.Visible = True

        dgridItems.ReadOnly = True
        dgridItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgridItems.MultiSelect = False

        LoadItems()
        LoadCategories()

        cmbCategory.Text = "All"

        If Form1.UserLvl = 3 Or Form1.UserLvl = 2 Then
            btnAddItem.Visible = False
            btnViewArch.Visible = False
        End If

    End Sub
    Sub LoadItems()

        dt.Clear()
        dgridItems.DataSource = Nothing
        dgridItems.Columns.Clear()

        sql = "SELECT i.ItemID, i.ItemName, i.ItemDesc, c.CatName AS Category, " &
          "i.UnitPrice, i.Unit, i.ItemCategory " &
          "FROM ItemsTbl i " &
          "INNER JOIN CategoriesTbl c " &
          "ON i.ItemCategory = c.CategoryID " &
          "WHERE i.ItemStatus = " & status

        Using da As New OleDbDataAdapter(sql, oledbCnn)
            da.Fill(dt)
        End Using

        dgridItems.DataSource = dt

        dgridItems.AllowUserToAddRows = False
        dgridItems.RowHeadersVisible = False

        dgridItems.EnableHeadersVisualStyles = False
        dgridItems.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 214, 200)
        dgridItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgridItems.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        SetupGrid()
        AddButtonColumns()
        dgridItems.Refresh()


        If dgridItems.Columns.Contains("colView") Then
            dgridItems.Columns("colView").Visible = (status = 1 AndAlso Not (Form1.UserLvl = 2 Or Form1.UserLvl = 3))
        End If

        If dgridItems.Columns.Contains("colArchive") Then
            dgridItems.Columns("colArchive").Visible = Not (Form1.UserLvl = 2 Or Form1.UserLvl = 3)
        End If


        Me.BeginInvoke(Sub()
                           dgridItems.ClearSelection()
                           dgridItems.CurrentCell = Nothing
                       End Sub)

        If dgridItems.Columns.Contains("colArchive") Then

            Dim btnArchive As DataGridViewButtonColumn =
        CType(dgridItems.Columns("colArchive"), DataGridViewButtonColumn)

            btnArchive.UseColumnTextForButtonValue = True

            If status = 1 Then
                btnArchive.HeaderText = "Archive"
                btnArchive.Text = "ARCHIVE"
            Else
                btnArchive.HeaderText = "Restore"
                btnArchive.Text = "RESTORE"
            End If

        End If

        If dgridItems.Columns.Contains("colView") Then

            Dim btnView As DataGridViewButtonColumn =
        CType(dgridItems.Columns("colView"), DataGridViewButtonColumn)

            btnView.UseColumnTextForButtonValue = True
            btnView.Text = "VIEW"

        End If

    End Sub
    Sub LoadCategories()

        Dim dtCat As New DataTable()

        sql = "SELECT CategoryID, CatName FROM CategoriesTbl"

        Using da As New OleDbDataAdapter(sql, oledbCnn)
            da.Fill(dtCat)
        End Using

        Dim allRow As DataRow = dtCat.NewRow()
        allRow("CategoryID") = 0
        allRow("CatName") = "All"
        dtCat.Rows.InsertAt(allRow, 0)

        cmbCategory.DataSource = dtCat
        cmbCategory.DisplayMember = "CatName"
        cmbCategory.ValueMember = "CategoryID"

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        dt.Clear()

        sql = "SELECT i.ItemID, i.ItemName, i.ItemDesc, c.CatName AS Category, " &
              "i.UnitPrice, i.Unit, i.ItemCategory " &
              "FROM ItemsTbl i " &
              "INNER JOIN CategoriesTbl c ON i.ItemCategory = c.CategoryID " &
              "WHERE i.ItemStatus = " & status &
              " AND i.ItemName LIKE ?"

        If cmbCategory.SelectedValue IsNot Nothing AndAlso CInt(cmbCategory.SelectedValue) <> 0 Then
            sql &= " AND i.ItemCategory = ?"
        End If


        Using da As New OleDbDataAdapter(sql, oledbCnn)

            da.SelectCommand.Parameters.AddWithValue("?", "%" & txtIName.Text & "%")

            If cmbCategory.SelectedValue IsNot Nothing AndAlso CInt(cmbCategory.SelectedValue) <> 0 Then
                da.SelectCommand.Parameters.AddWithValue("?", cmbCategory.SelectedValue)
            End If

            da.Fill(dt)

        End Using

        dgridItems.DataSource = dt

    End Sub
    Private Sub dgridItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgridItems.CellContentClick
        If Form1.UserLvl = 2 Or Form1.UserLvl = 3 Then
            Exit Sub
        End If

        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgridItems.Rows(e.RowIndex)

        ' VIEW
        If dgridItems.Columns(e.ColumnIndex).Name = "colView" Then

            Dim subItm As New subItems()

            purpose = "Item Info"

            itemId = Convert.ToInt32(row.Cells("ItemID").Value)
            itemName = row.Cells("ItemName").Value.ToString()
            itemDesc = row.Cells("ItemDesc").Value.ToString()
            itemCategory = Convert.ToInt32(row.Cells("ItemCategory").Value)
            unitPrice = Convert.ToDecimal(row.Cells("UnitPrice").Value)
            unit = row.Cells("Unit").Value.ToString()

            subItm.ShowDialog()
            LoadItems()

        End If

        ' ARCHIVE / RESTORE
        If dgridItems.Columns(e.ColumnIndex).Name = "colArchive" Then

            Dim result = MessageBox.Show("Proceed?", "Item", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then

                Dim sql As String

                If status = 1 Then
                    sql = "UPDATE ItemsTbl SET ItemStatus = 0 WHERE ItemID = ?"
                Else
                    sql = "UPDATE ItemsTbl SET ItemStatus = 1 WHERE ItemID = ?"
                End If

                Using cmd As New OleDbCommand(sql, oledbCnn)
                    cmd.Parameters.AddWithValue("?", Convert.ToInt32(row.Cells("ItemID").Value))
                    cmd.ExecuteNonQuery()
                End Using

                LoadItems()

            End If

        End If

    End Sub
    Sub AddButtonColumns()

        Dim hideButtons As Boolean =
        (Form1.UserLvl = 2 Or Form1.UserLvl = 3)

        If Not dgridItems.Columns.Contains("colView") Then

            Dim btnView As New DataGridViewButtonColumn()
            btnView.Name = "colView"
            btnView.HeaderText = "View"
            btnView.Text = "VIEW"
            btnView.UseColumnTextForButtonValue = True

            btnView.FlatStyle = FlatStyle.Flat

            btnView.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#a5a18d")
            btnView.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#808271")
            btnView.DefaultCellStyle.ForeColor = Color.White
            btnView.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

            btnView.Visible = Not hideButtons

            dgridItems.Columns.Add(btnView)

        End If

        If Not dgridItems.Columns.Contains("colArchive") Then

            Dim btnArchive As New DataGridViewButtonColumn()
            btnArchive.Name = "colArchive"
            btnArchive.HeaderText = "Archive"
            btnArchive.Text = "ARCHIVE"
            btnArchive.UseColumnTextForButtonValue = True

            btnArchive.FlatStyle = FlatStyle.Flat

            btnArchive.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#a5a18d")
            btnArchive.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#808271")
            btnArchive.DefaultCellStyle.ForeColor = Color.White
            btnArchive.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

            btnArchive.Visible = Not hideButtons

            dgridItems.Columns.Add(btnArchive)

        End If

    End Sub
    Sub SetupGrid()

        If dgridItems.DataSource Is Nothing Then Exit Sub

        For Each col As DataGridViewColumn In dgridItems.Columns
            col.Visible = False
        Next

        If dgridItems.Columns.Contains("ItemName") Then dgridItems.Columns("ItemName").Visible = True
        If dgridItems.Columns.Contains("ItemDesc") Then dgridItems.Columns("ItemDesc").Visible = True
        If dgridItems.Columns.Contains("Category") Then dgridItems.Columns("Category").Visible = True

        dgridItems.Columns("ItemName").HeaderText = "Name"
        dgridItems.Columns("ItemDesc").HeaderText = "Description"
        dgridItems.Columns("Category").HeaderText = "Category"

        If dgridItems.Columns.Contains("colView") Then dgridItems.Columns("colView").Visible = True
        If dgridItems.Columns.Contains("colArchive") Then dgridItems.Columns("colArchive").Visible = True

        dgridItems.EnableHeadersVisualStyles = False
        dgridItems.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

    End Sub
    Private Sub btnViewArch_Click(sender As Object, e As EventArgs) Handles btnViewArch.Click

        If btnViewArch.Text = "VIEW ARCHIVED ITEMS" Then
            status = 0
            btnViewArch.Text = "VIEW ACTIVE ITEMS"
            btnAddItem.Visible = False
        Else
            status = 1
            btnViewArch.Text = "VIEW ARCHIVED ITEMS"
            btnAddItem.Visible = True
        End If

        LoadItems()

    End Sub
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim subItm As New subItems()

        purpose = "Create New Item"

        subItm.ShowDialog()
        LoadItems()
    End Sub

    Private Sub btnCategories_Click(sender As Object, e As EventArgs) Handles btnCategories.Click
        Dim subCat As New subCategory()

        subCat.ShowDialog()

        LoadItems()
        LoadCategories()
    End Sub
End Class
