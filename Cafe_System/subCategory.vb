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


        dgridCategories.ReadOnly = True
        dgridCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgridCategories.MultiSelect = False

        LoadCategories()

        If Form1.UserLvl = 3 Or Form1.UserLvl = 2 Then
            btnAddCategory.Visible = False
        End If

    End Sub

    Sub LoadCategories()

        dt.Clear()
        dgridCategories.DataSource = Nothing
        dgridCategories.Columns.Clear()

        sql = "SELECT CategoryID, CatName, CatDesc FROM CategoriesTbl"

        Using da As New OleDbDataAdapter(sql, oledbCnn)
            da.Fill(dt)
        End Using

        dgridCategories.DataSource = dt
        dgridCategories.AllowUserToAddRows = False
        dgridCategories.RowHeadersVisible = False

        dgridCategories.EnableHeadersVisualStyles = False
        dgridCategories.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 214, 200)
        dgridCategories.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgridCategories.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        SetupGrid()
        AddButtonColumns()

        If dgridCategories.Columns.Contains("colView") Then
            dgridCategories.Columns("colView").Visible = (status = 1 AndAlso Not (Form1.UserLvl = 2 Or Form1.UserLvl = 3))
        End If


        Me.BeginInvoke(Sub()
                           dgridCategories.ClearSelection()
                           dgridCategories.CurrentCell = Nothing
                       End Sub)


        If dgridCategories.Columns.Contains("colView") Then

            Dim btnView As DataGridViewButtonColumn =
                CType(dgridCategories.Columns("colView"), DataGridViewButtonColumn)

            btnView.UseColumnTextForButtonValue = True
            btnView.Text = "VIEW"

        End If

    End Sub



    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        dt.Clear()

        sql = "SELECT CategoryID, CatName, CatDesc FROM CategoriesTbl WHERE CatName LIKE ?"

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


        dgridCategories.EnableHeadersVisualStyles = False
        dgridCategories.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

    End Sub


    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click

        Dim subCat As New subCat()

        purpose = "Create Category"

        subCat.ShowDialog()
        LoadCategories()

    End Sub

End Class