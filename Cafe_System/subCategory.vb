Imports System.Data.OleDb

Public Class subCategory

    Dim dt As New DataTable()
    Dim sql As String
    Dim status As Integer = 1

    Public Shared purpose As String
    Public Shared categoryId As Integer
    Public Shared catName As String
    Public Shared catDesc As String

    Private Sub tabCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        status = 1

        If Form1.UserLvl = 3 Or Form1.UserLvl = 2 Then
            btnAddCategory.Visible = False
        End If

        btnViewArch.Text = "VIEW ARCHIVED CATEGORIES"

        dgridCategories.ReadOnly = True
        dgridCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgridCategories.MultiSelect = False

        LoadCategories()

        If Form1.UserLvl = 3 Or Form1.UserLvl = 2 Then
            btnAddCategory.Visible = False
            btnViewArch.Visible = False
        End If

    End Sub

    Sub LoadCategories()

        dt.Clear()
        dgridCategories.DataSource = Nothing
        dgridCategories.Columns.Clear()

        sql = "SELECT CategoryID, CatName, CatDesc FROM CategoriesTbl WHERE CatStatus = " & status

        Using da As New OleDbDataAdapter(sql, oledbCnn)
            da.Fill(dt)
        End Using

        dgridCategories.DataSource = dt
        dgridCategories.AllowUserToAddRows = False

        SetupGrid()
        AddButtonColumns()

        If dgridCategories.Columns.Contains("colView") Then
            dgridCategories.Columns("colView").Visible = (status = 1 AndAlso Not (Form1.UserLvl = 2 Or Form1.UserLvl = 3))
        End If

        If dgridCategories.Columns.Contains("colArchive") Then
            dgridCategories.Columns("colArchive").Visible = Not (Form1.UserLvl = 2 Or Form1.UserLvl = 3)
        End If

        Me.BeginInvoke(Sub()
                           dgridCategories.ClearSelection()
                           dgridCategories.CurrentCell = Nothing
                       End Sub)

        If dgridCategories.Columns.Contains("colArchive") Then

            Dim btnArchive As DataGridViewButtonColumn =
                CType(dgridCategories.Columns("colArchive"), DataGridViewButtonColumn)

            btnArchive.UseColumnTextForButtonValue = True

            If status = 1 Then
                btnArchive.HeaderText = "Archive"
                btnArchive.Text = "ARCHIVE"
            Else
                btnArchive.HeaderText = "Restore"
                btnArchive.Text = "RESTORE"
            End If

        End If

        If dgridCategories.Columns.Contains("colView") Then

            Dim btnView As DataGridViewButtonColumn =
                CType(dgridCategories.Columns("colView"), DataGridViewButtonColumn)

            btnView.UseColumnTextForButtonValue = True
            btnView.Text = "VIEW"

        End If

    End Sub



    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        dt.Clear()

        sql = "SELECT CategoryID, CatName, CatDesc FROM CategoriesTbl WHERE CatStatus = " & status &
          " AND CatName LIKE ?"

        Using da As New OleDbDataAdapter(sql, oledbCnn)
            da.SelectCommand.Parameters.AddWithValue("?", "%" & txtCatName.Text & "%")
            da.Fill(dt)
        End Using

        dgridCategories.DataSource = dt

        SetupGrid()
        AddButtonColumns()

        If dgridCategories.Columns.Contains("colView") Then
            dgridCategories.Columns("colView").Visible = (status = 1 AndAlso Not (Form1.UserLvl = 2 Or Form1.UserLvl = 3))
        End If

        If dgridCategories.Columns.Contains("colArchive") Then
            dgridCategories.Columns("colArchive").Visible = Not (Form1.UserLvl = 2 Or Form1.UserLvl = 3)
        End If

    End Sub

    Private Sub dgridCategories_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgridCategories.CellContentClick

        If Form1.UserLvl = 2 Or Form1.UserLvl = 3 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgridCategories.Rows(e.RowIndex)

        ' VIEW
        If dgridCategories.Columns(e.ColumnIndex).Name = "colView" Then
            If status = 0 Then Exit Sub

            Dim subCat As New subCat()

            purpose = "Category Info"

            categoryId = Convert.ToInt32(row.Cells("CategoryID").Value)
            catName = row.Cells("CatName").Value.ToString()
            catDesc = row.Cells("CatDesc").Value.ToString()

            subCat.ShowDialog()
            LoadCategories()

        End If

        ' ARCHIVE / RESTORE
        If dgridCategories.Columns(e.ColumnIndex).Name = "colArchive" Then

            Dim result = MessageBox.Show("Proceed?", "Category", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then

                Dim sql As String

                If status = 1 Then
                    sql = "UPDATE CategoriesTbl SET CatStatus = 0 WHERE CategoryID = ?"
                Else
                    sql = "UPDATE CategoriesTbl SET CatStatus = 1 WHERE CategoryID = ?"
                End If

                Using cmd As New OleDbCommand(sql, oledbCnn)
                    cmd.Parameters.AddWithValue("?", Convert.ToInt32(row.Cells("CategoryID").Value))
                    cmd.ExecuteNonQuery()
                End Using

                LoadCategories()

            End If

        End If

    End Sub

    Sub AddButtonColumns()

        Dim hideButtons As Boolean = (Form1.UserLvl = 2 Or Form1.UserLvl = 3)

        If Not dgridCategories.Columns.Contains("colView") Then

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

            dgridCategories.Columns.Add(btnView)

        End If

        If Not dgridCategories.Columns.Contains("colArchive") Then

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

            dgridCategories.Columns.Add(btnArchive)

        End If

    End Sub

    Sub SetupGrid()

        If dgridCategories.DataSource Is Nothing Then Exit Sub

        For Each col As DataGridViewColumn In dgridCategories.Columns
            col.Visible = False
        Next

        If dgridCategories.Columns.Contains("CatName") Then dgridCategories.Columns("CatName").Visible = True
        If dgridCategories.Columns.Contains("CatDesc") Then dgridCategories.Columns("CatDesc").Visible = True

        dgridCategories.Columns("CatName").HeaderText = "Category Name"
        dgridCategories.Columns("CatDesc").HeaderText = "Description"

        If dgridCategories.Columns.Contains("colView") Then
            dgridCategories.Columns("colView").Visible = (status = 1 AndAlso Not (Form1.UserLvl = 2 Or Form1.UserLvl = 3))
        End If

        If dgridCategories.Columns.Contains("colArchive") Then
            dgridCategories.Columns("colArchive").Visible = Not (Form1.UserLvl = 2 Or Form1.UserLvl = 3)
        End If

        dgridCategories.EnableHeadersVisualStyles = False
        dgridCategories.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

    End Sub

    Private Sub btnViewArch_Click(sender As Object, e As EventArgs) Handles btnViewArch.Click

        If btnViewArch.Text = "VIEW ARCHIVED CATEGORIES" Then
            status = 0
            btnViewArch.Text = "VIEW ACTIVE CATEGORIES"
            btnAddCategory.Visible = False
        Else
            status = 1
            btnViewArch.Text = "VIEW ARCHIVED CATEGORIES"
            btnAddCategory.Visible = True
        End If

        LoadCategories()

    End Sub

    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click

        Dim subCat As New subCat()

        purpose = "Create Category"

        subCat.ShowDialog()
        LoadCategories()

    End Sub

End Class