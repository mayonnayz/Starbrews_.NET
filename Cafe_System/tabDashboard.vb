Imports System.Data.OleDb
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class tabDashboard
    Private _isFiltered As Boolean = False

    Private Sub tabDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = "Date: " & DateTime.Now.ToString("MM/dd/yyyy")

        LoadFastMovingItems()
        LoadSlowMovingItems()

        If Form1.UserLvl = 3 Or Form1.UserLvl = 2 Then
            btnPrint.Visible = False
        End If


    End Sub

    Private Sub LoadFastMovingItems(
    Optional startDate As Date? = Nothing,
    Optional endDate As Date? = Nothing)

        Dim dt As New DataTable()

        Dim sql As String =
        "SELECT TOP 10
            q.ItemID,
            i.ItemName,
            SUM(q.ClosingQty)   AS ClosingQty,
            SUM(q.StockMoveQty) AS StockMoveQty,
            SUM(q.ClosingQty) + SUM(q.StockMoveQty) AS TotalUsed
        FROM
        (
            SELECT
                ci.ItemID,
                ci.QuantityUsed  AS ClosingQty,
                0                AS StockMoveQty,
                c.DateSubmitted  AS TransDate
            FROM ClosingItemsTbl ci
            INNER JOIN ClosingTbl c ON ci.ClosingID = c.ClosingID

            UNION ALL

            SELECT
                smi.StockItemID  AS ItemID,
                0                AS ClosingQty,
                smi.MoveQuantity AS StockMoveQty,
                sm.DateSubmitted AS TransDate
            FROM StockMoveItemsTbl smi
            INNER JOIN StockMovementTbl sm ON smi.StockMoveID = sm.StockMovementID
            WHERE sm.MovementType = 'STOCK OUT'
        ) AS q
        INNER JOIN ItemsTbl i ON q.ItemID = i.ItemID"

        If startDate.HasValue AndAlso endDate.HasValue Then
            sql &= "
            WHERE DateValue(q.TransDate) BETWEEN ? AND ?"
        End If

        sql &= "
            GROUP BY
                q.ItemID,
                i.ItemName
            ORDER BY
                SUM(q.ClosingQty) + SUM(q.StockMoveQty) DESC"

        Using cmd As New OleDbCommand(sql, oledbCnn)

            If startDate.HasValue AndAlso endDate.HasValue Then
                cmd.Parameters.Add("?", OleDbType.Date).Value = startDate.Value.Date
                cmd.Parameters.Add("?", OleDbType.Date).Value = endDate.Value.Date
            End If

            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using

        End Using

        dt.Columns.Add("Rank", GetType(Integer))

        For i As Integer = 0 To dt.Rows.Count - 1
            dt.Rows(i)("Rank") = i + 1
        Next

        dt.Columns("Rank").SetOrdinal(0)
        dgridFast.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgridFast.RowTemplate.Height = 44.8

        dgridFast.DataSource = dt


        dgridFast.AllowUserToAddRows = False
        dgridFast.ReadOnly = True
        dgridFast.RowHeadersVisible = False

        dgridFast.EnableHeadersVisualStyles = False
        dgridFast.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 214, 200)
        dgridFast.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgridFast.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgridFast.ClearSelection()
        dgridFast.CurrentCell = Nothing
        dgridFast.DefaultCellStyle.SelectionBackColor = dgridFast.DefaultCellStyle.BackColor
        dgridFast.DefaultCellStyle.SelectionForeColor = dgridFast.DefaultCellStyle.ForeColor

        dgridFast.Columns("Rank").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgridFast.Columns("Rank").Width = 30
        dgridFast.Columns("TotalUsed").Width = 50

        If dgridFast.Columns.Contains("ItemID") Then
            dgridFast.Columns("ItemID").Visible = False
        End If

    End Sub

    Private Sub LoadSlowMovingItems(
    Optional startDate As Date? = Nothing,
    Optional endDate As Date? = Nothing)

        Dim dt As New DataTable()

        Dim sql As String =
        "SELECT TOP 10
            q.ItemID,
            i.ItemName,
            SUM(q.ClosingQty)   AS ClosingQty,
            SUM(q.StockMoveQty) AS StockMoveQty,
            SUM(q.ClosingQty) + SUM(q.StockMoveQty) AS TotalUsed
        FROM
        (
            SELECT
                ci.ItemID,
                ci.QuantityUsed  AS ClosingQty,
                0                AS StockMoveQty,
                c.DateSubmitted  AS TransDate
            FROM ClosingItemsTbl ci
            INNER JOIN ClosingTbl c ON ci.ClosingID = c.ClosingID

            UNION ALL

            SELECT
                smi.StockItemID  AS ItemID,
                0                AS ClosingQty,
                smi.MoveQuantity AS StockMoveQty,
                sm.DateSubmitted AS TransDate
            FROM StockMoveItemsTbl smi
            INNER JOIN StockMovementTbl sm ON smi.StockMoveID = sm.StockMovementID
            WHERE sm.MovementType = 'STOCK OUT'
        ) AS q
        INNER JOIN ItemsTbl i ON q.ItemID = i.ItemID"


        If startDate.HasValue AndAlso endDate.HasValue Then
            sql &= "
            WHERE DateValue(q.TransDate) BETWEEN ? AND ?"
        End If

        sql &= "
            GROUP BY
                q.ItemID,
                i.ItemName
            ORDER BY
                SUM(q.ClosingQty) + SUM(q.StockMoveQty) ASC"

        Using cmd As New OleDbCommand(sql, oledbCnn)

            If startDate.HasValue AndAlso endDate.HasValue Then
                cmd.Parameters.Add("?", OleDbType.Date).Value = startDate.Value.Date
                cmd.Parameters.Add("?", OleDbType.Date).Value = endDate.Value.Date
            End If

            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using

        End Using

        dt.Columns.Add("Rank", GetType(Integer))

        For i As Integer = 0 To dt.Rows.Count - 1
            dt.Rows(i)("Rank") = i + 1
        Next

        dt.Columns("Rank").SetOrdinal(0)

        dgridSlow.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgridSlow.RowTemplate.Height = 44.8

        dgridSlow.DataSource = dt

        dgridSlow.AllowUserToAddRows = False
        dgridSlow.ReadOnly = True
        dgridSlow.RowHeadersVisible = False

        dgridSlow.EnableHeadersVisualStyles = False
        dgridSlow.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 214, 200)
        dgridSlow.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgridSlow.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgridSlow.ClearSelection()
        dgridSlow.CurrentCell = Nothing
        dgridSlow.DefaultCellStyle.SelectionBackColor = dgridSlow.DefaultCellStyle.BackColor
        dgridSlow.DefaultCellStyle.SelectionForeColor = dgridSlow.DefaultCellStyle.ForeColor

        dgridSlow.Columns("Rank").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgridSlow.Columns("Rank").Width = 30
        dgridSlow.Columns("TotalUsed").Width = 50

        If dgridSlow.Columns.Contains("ItemID") Then
            dgridSlow.Columns("ItemID").Visible = False
        End If

    End Sub



    Private Sub btnSearchDate_Click(sender As Object, e As EventArgs) Handles btnSearchDate.Click
        _isFiltered = True
        LoadFastMovingItems(dtStart.Value, dtEnd.Value)
        LoadSlowMovingItems(dtStart.Value, dtEnd.Value)
    End Sub


    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        _isFiltered = False
        LoadFastMovingItems()
        LoadSlowMovingItems()
    End Sub

    Private Sub dgridFast_SelectionChanged(
    sender As Object,
    e As EventArgs) Handles dgridFast.SelectionChanged

        dgridFast.ClearSelection()
        dgridFast.CurrentCell = Nothing

    End Sub

    Private Sub dgridSlow_SelectionChanged(
    sender As Object,
    e As EventArgs) Handles dgridSlow.SelectionChanged

        dgridSlow.ClearSelection()
        dgridSlow.CurrentCell = Nothing

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim fastDt As DataTable = CType(dgridFast.DataSource, DataTable)
        Dim slowDt As DataTable = CType(dgridSlow.DataSource, DataTable)

        Dim folder As String = Path.Combine(Application.StartupPath, "Reports")
        If Not Directory.Exists(folder) Then
            Directory.CreateDirectory(folder)
        End If

        Dim save As New SaveFileDialog()
        save.Filter = "PDF File|*.pdf"
        save.InitialDirectory = folder
        save.FileName = "Starbrews_Report_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".pdf"

        If save.ShowDialog() = DialogResult.OK Then
            ExportToPDF(save.FileName, fastDt, slowDt)
            MessageBox.Show("PDF Exported Successfully")
        End If

    End Sub



    Private Sub ExportToPDF(path As String, fastDt As DataTable, slowDt As DataTable)
        Dim name As String = Form1.FirstName & " " & Form1.LastName

        Dim doc As New Document(PageSize.A4, 36, 36, 36, 36)
        PdfWriter.GetInstance(doc, New FileStream(path, FileMode.Create))
        doc.Open()

        Dim baseFont As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED)
        Dim baseFontBold As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED)

        Dim titleFont As New iTextSharp.text.Font(baseFontBold, 18, iTextSharp.text.Font.BOLD, New BaseColor(40, 40, 40))
        Dim subFont As New iTextSharp.text.Font(baseFont, 9, iTextSharp.text.Font.NORMAL, New BaseColor(80, 80, 80))
        Dim sectionFont As New iTextSharp.text.Font(baseFontBold, 11, iTextSharp.text.Font.BOLD, New BaseColor(255, 255, 255))

        Dim headerTbl As New PdfPTable(2)
        headerTbl.WidthPercentage = 100
        headerTbl.SetWidths(New Single() {3.0F, 1.0F})
        headerTbl.SpacingAfter = 10

        Dim leftCell As New PdfPCell()
        leftCell.Border = PdfPCell.NO_BORDER
        leftCell.PaddingBottom = 8

        Dim companyPara As New Paragraph("STARBREWS INC.", titleFont)
        leftCell.AddElement(companyPara)
        leftCell.AddElement(New Paragraph("Printed By: " & name, subFont))
        leftCell.AddElement(New Paragraph("Date: " & DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"), subFont))

        Dim dateRange As String
        If _isFiltered Then
            dateRange = "Period: " & dtStart.Value.ToString("MM/dd/yyyy") & " - " & dtEnd.Value.ToString("MM/dd/yyyy")
        Else
            dateRange = "Period: All"
        End If
        leftCell.AddElement(New Paragraph(dateRange, subFont))
        headerTbl.AddCell(leftCell)

        Dim rightCell As New PdfPCell()
        rightCell.Border = PdfPCell.NO_BORDER
        rightCell.HorizontalAlignment = Element.ALIGN_RIGHT
        rightCell.VerticalAlignment = Element.ALIGN_MIDDLE

        Dim logoBitmap As System.Drawing.Bitmap = My.Resources.logo_dark
        Using ms As New MemoryStream()
            logoBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            Dim img As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(ms.ToArray())
            img.ScaleToFit(140, 140)
            img.Alignment = Element.ALIGN_RIGHT
            rightCell.AddElement(img)
        End Using
        headerTbl.AddCell(rightCell)
        doc.Add(headerTbl)

        Dim line As New iTextSharp.text.pdf.draw.LineSeparator(1.0F, 100.0F, New BaseColor(180, 160, 130), Element.ALIGN_CENTER, -2)
        doc.Add(New Chunk(line))
        doc.Add(New Paragraph(" "))

        doc.Add(CreateSectionHeader("TOP 10 FAST MOVING ITEMS", sectionFont))
        doc.Add(New Paragraph(" "))
        doc.Add(CreatePDFTable(fastDt, baseFontBold, baseFont))

        doc.Add(New Paragraph(" "))

        doc.Add(CreateSectionHeader("TOP 10 SLOW MOVING ITEMS", sectionFont))
        doc.Add(New Paragraph(" "))
        doc.Add(CreatePDFTable(slowDt, baseFontBold, baseFont))

        doc.Close()
    End Sub

    Private Function CreateSectionHeader(title As String, titleFont As iTextSharp.text.Font) As PdfPTable
        Dim tbl As New PdfPTable(1)
        tbl.WidthPercentage = 100
        tbl.SpacingAfter = 4

        Dim cell As New PdfPCell(New Phrase(title, titleFont))
        cell.BackgroundColor = New BaseColor(90, 75, 55)
        cell.Border = PdfPCell.NO_BORDER
        cell.Padding = 6
        tbl.AddCell(cell)
        Return tbl
    End Function

    Private Function CreatePDFTable(dt As DataTable,
                                 boldFont As BaseFont,
                                 normalFont As BaseFont) As PdfPTable

        Dim visibleCols = dt.Columns.Cast(Of DataColumn)().
        Where(Function(c) Not c.ColumnName.Equals("ItemID", StringComparison.OrdinalIgnoreCase)).
        ToList()

        Dim table As New PdfPTable(visibleCols.Count)
        table.WidthPercentage = 100
        table.SpacingAfter = 6

        Dim widths As Single() = New Single(visibleCols.Count - 1) {}

        For i As Integer = 0 To visibleCols.Count - 1
            Dim colName = visibleCols(i).ColumnName.ToLower()

            If colName = "rank" Then
                widths(i) = 0.9F
            ElseIf colName.Contains("name") Then
                widths(i) = 3.5F
            Else
                widths(i) = 1.5F
            End If
        Next
        table.SetWidths(widths)

        Dim hFont As New iTextSharp.text.Font(boldFont, 9, iTextSharp.text.Font.BOLD, New BaseColor(40, 40, 40))
        For Each col In visibleCols
            Dim cell As New PdfPCell(New Phrase(col.ColumnName, hFont))
            cell.BackgroundColor = New BaseColor(220, 214, 200)
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            cell.Padding = 5
            cell.Border = PdfPCell.BOX
            cell.BorderColor = New BaseColor(180, 160, 130)
            table.AddCell(cell)
        Next

        Dim dFont As New iTextSharp.text.Font(normalFont, 9, iTextSharp.text.Font.NORMAL, New BaseColor(40, 40, 40))
        Dim rowIndex As Integer = 0
        For Each row As DataRow In dt.Rows
            Dim isAlt As Boolean = (rowIndex Mod 2 = 1)

            For Each col In visibleCols
                Dim cell As New PdfPCell(New Phrase(row(col).ToString(), dFont))
                cell.BackgroundColor = If(isAlt, New BaseColor(245, 242, 236), BaseColor.WHITE)
                cell.Padding = 5
                cell.Border = PdfPCell.BOX
                cell.BorderColor = New BaseColor(200, 190, 175)

                Dim colName = col.ColumnName.ToLower()
                If colName = "rank" OrElse Not colName.Contains("name") Then
                    cell.HorizontalAlignment = Element.ALIGN_CENTER
                Else
                    cell.HorizontalAlignment = Element.ALIGN_LEFT
                End If

                table.AddCell(cell)
            Next

            rowIndex += 1
        Next

        Return table
    End Function
End Class
