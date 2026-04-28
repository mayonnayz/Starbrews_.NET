Imports System.Data.OleDb
Imports System.Globalization

Public Class tabInventory
    Public Shared purpose As String
    Private Sub tabInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = "Date: " & DateTime.Now.ToString("MM/dd/yyyy")
        lblDate2.Text = "Date: " & DateTime.Now.ToString("MM/dd/yyyy")

        If Form1.UserLvl = 3 Then
            btnStockIn.Visible = False
            btnStockOut.Visible = False
        ElseIf Form1.UserLvl = 2 Then
            btnClosingCount.Visible = False
        End If

        If OpenConnection() Then
            LoadItems()
        End If
    End Sub


    Sub LoadItems()
        Dim dtItems, dtStock As New DataTable()
        Dim sql As String = ""

        sql = "SELECT i.ItemName, c.CatName AS Category, i.Quantity, i.Unit, " &
          "i.UnitPrice " &
          "FROM ItemsTbl i " &
          "INNER JOIN CategoriesTbl c ON i.ItemCategory = c.CategoryID WHERE ItemStatus = 1"

        Using da As New OleDbDataAdapter(sql, oledbCnn)
            da.Fill(dtItems)
        End Using

        DataGridView1.DataSource = dtItems
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowHeadersVisible = False

        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 214, 200)
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridView1.Columns("UnitPrice").DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US")
        DataGridView1.Columns("UnitPrice").DefaultCellStyle.Format = "C2"
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        DataGridView1.Columns("Category").Width = 160
        DataGridView1.Columns("Quantity").Width = 80
        DataGridView1.Columns("Unit").Width = 60
        DataGridView1.Columns("UnitPrice").Width = 80
        DataGridView1.Columns("ItemName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.ReadOnly = True
        Next

        sql = "SELECT i.ItemName, c.CatName AS Category, s.CurrentQuantity AS Quantity, i.Unit, i.UnitPrice " &
          "FROM (ItemsTbl i " &
          "INNER JOIN CategoriesTbl c ON i.ItemCategory = c.CategoryID) " &
          "INNER JOIN StockRoomTbl s ON i.ItemID = s.ItemID " &
          "WHERE i.ItemStatus = 1"

        Using daa As New OleDbDataAdapter(sql, oledbCnn)
            daa.Fill(dtStock)
        End Using

        DataGridView2.DataSource = dtStock

        DataGridView2.AllowUserToAddRows = False
        DataGridView2.RowHeadersVisible = False

        DataGridView2.EnableHeadersVisualStyles = False
        DataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 214, 200)
        DataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        DataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridView2.Columns("UnitPrice").DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US")
        DataGridView2.Columns("UnitPrice").DefaultCellStyle.Format = "C2"
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        DataGridView2.Columns("Category").Width = 160
        DataGridView2.Columns("Quantity").Width = 80
        DataGridView2.Columns("Unit").Width = 60
        DataGridView2.Columns("UnitPrice").Width = 80
        DataGridView2.Columns("ItemName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        For Each col As DataGridViewColumn In DataGridView2.Columns
            col.ReadOnly = True
        Next

    End Sub

    Private Sub btnClosingCount_Click(sender As Object, e As EventArgs) Handles btnClosingCount.Click
        Dim subCls As New subClosing()
        subCls.ShowDialog()
        LoadItems()
    End Sub

    Private Sub btnStockIn_Click(sender As Object, e As EventArgs) Handles btnStockIn.Click
        purpose = "STOCK IN"
        Dim subStk As New subStockRoom()
        subStk.ShowDialog()
        LoadItems()
    End Sub

    Private Sub btnStockOut_Click(sender As Object, e As EventArgs) Handles btnStockOut.Click
        purpose = "STOCK OUT"
        Dim subStk As New subStockRoom()
        subStk.ShowDialog()
        LoadItems()
    End Sub

    Private Sub btnHistoryStock_Click(sender As Object, e As EventArgs) Handles btnHistoryStock.Click
        purpose = "Stock Room Logs"
        Dim subInv As New subInvLogs()
        subInv.ShowDialog()
    End Sub

    Private Sub btnHistoryStore_Click(sender As Object, e As EventArgs) Handles btnHistoryStore.Click
        purpose = "Store Inventory Logs"
        Dim subInv As New subInvLogs()
        subInv.ShowDialog()
    End Sub


End Class
