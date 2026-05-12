Imports System.Data.OleDb
Imports System.IO
Imports System.Net.Security
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class subStoLogs
    Private _isDiscFiltered As Boolean = False
    Private Sub subStoLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnReorder.Enabled = False

        LoadAllStockInLogs()
        LoadAllStockOutLogs()
        LoadAllDiscrepancies()

        If Form1.UserLvl = 3 Then
            btnReorder.Visible = False
            btnPrint.Visible = False
        ElseIf Form1.UserLvl = 2 Then
            btnPrint.Visible = False
        End If
    End Sub

    ''========================
    ''STOCK IN
    ''========================
    Sub LoadAllStockInLogs()

        Dim dt As New DataTable()

        Dim sql As String =
        "SELECT 
        sm.StockMovementID,
        Format(sm.DateSubmitted, 'mmm-dd-yyyy hh:nn AM/PM') AS DisplayDate
    FROM StockMovementTbl sm
    WHERE sm.MovementType = 'STOCK IN'
    ORDER BY sm.DateSubmitted DESC"

        Using cmd As New OleDbCommand(sql, oledbCnn)
            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        lstIn.DataSource = dt
        lstIn.DisplayMember = "DisplayDate"
        lstIn.ValueMember = "StockMovementID"

    End Sub

    Sub LoadStockInByDate(selectedDate As Date)

        Dim dt As New DataTable()

        Dim sql As String =
        "SELECT 
        sm.StockMovementID,
        Format(sm.DateSubmitted, 'mmm-dd-yyyy hh:nn AM/PM') AS DisplayDate
    FROM StockMovementTbl sm
    WHERE sm.MovementType = 'STOCK IN'
    AND DateValue(sm.DateSubmitted) = ?
    ORDER BY sm.DateSubmitted DESC"

        Using cmd As New OleDbCommand(sql, oledbCnn)

            cmd.Parameters.Add("?", OleDbType.Date).Value = selectedDate.Date

            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using

        End Using

        lstIn.DataSource = dt
        lstIn.DisplayMember = "DisplayDate"
        lstIn.ValueMember = "StockMovementID"

    End Sub

    Sub LoadStockInDetails(stockMoveID As Integer)

        Dim sql As String =
        "SELECT 
        sm.StockMovementID,
        sm.DateSubmitted,
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

                    lblBaristaIn.Text = "Barista: " & reader("BaristaName").ToString()
                    lblSuperIn.Text = "Supervisor: " & reader("SupervisorName").ToString()
                    lblDateIn.Text = "Date/Time: " & reader("DateSubmitted").ToString()
                    lblTransacIn.Text = "Transaction ID: " & stockMoveID

                End If

            End Using

        End Using

    End Sub

    Sub LoadStockInItems(stockMoveID As Integer)

        Dim dt As New DataTable()

        Dim sql As String =
        "SELECT 
        i.ItemName,
        c.CatName AS Category,
        smi.RequestedQuantity,
        smi.ReceivedQuantity
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

        dgridIn.DataSource = dt

        dgridIn.EnableHeadersVisualStyles = False
        dgridIn.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 214, 200)
        dgridIn.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgridIn.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgridIn.AllowUserToAddRows = False
        dgridIn.RowHeadersVisible = False

    End Sub

    ''========================
    ''STOCK OUT
    ''========================

    Sub LoadAllStockOutLogs()

        Dim dt As New DataTable()

        Dim sql As String =
        "SELECT 
        sm.StockMovementID,
        Format(sm.DateSubmitted, 'mmm-dd-yyyy hh:nn AM/PM') AS DisplayDate
    FROM StockMovementTbl sm
    WHERE sm.MovementType = 'STOCK OUT'
    ORDER BY sm.DateSubmitted DESC"

        Using cmd As New OleDbCommand(sql, oledbCnn)

            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using

        End Using

        lstOut.DataSource = dt
        lstOut.DisplayMember = "DisplayDate"
        lstOut.ValueMember = "StockMovementID"

    End Sub

    Sub LoadStockOutByDate(selectedDate As Date)

        Dim dt As New DataTable()

        Dim sql As String =
        "SELECT 
        sm.StockMovementID,
        Format(sm.DateSubmitted, 'mmm-dd-yyyy hh:nn AM/PM') AS DisplayDate
    FROM StockMovementTbl sm
    WHERE sm.MovementType = 'STOCK OUT'
    AND DateValue(sm.DateSubmitted) = ?
    ORDER BY sm.DateSubmitted DESC"

        Using cmd As New OleDbCommand(sql, oledbCnn)

            cmd.Parameters.Add("?", OleDbType.Date).Value = selectedDate.Date

            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using

        End Using

        lstOut.DataSource = dt
        lstOut.DisplayMember = "DisplayDate"
        lstOut.ValueMember = "StockMovementID"

    End Sub

    Sub LoadStockOutItems(stockMoveID As Integer)

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

        dgridOut.DataSource = dt

        dgridOut.EnableHeadersVisualStyles = False
        dgridOut.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 214, 200)
        dgridOut.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgridOut.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgridOut.AllowUserToAddRows = False
        dgridOut.RowHeadersVisible = False

    End Sub

    Sub LoadStockOutDetails(stockMoveID As Integer)

        Dim sql As String =
    "SELECT 
        sm.StockMovementID,
        sm.DateSubmitted,
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

                    lblBaristaOut.Text = "Barista: " & reader("BaristaName").ToString()
                    lblSuperOut.Text = "Supervisor: " & reader("SupervisorName").ToString()
                    lblDateOut.Text = "Date/Time: " & reader("DateSubmitted").ToString()
                    lblTransacOut.Text = "Transaction ID: " & stockMoveID

                End If

            End Using

        End Using

    End Sub

    ''========================
    ''DISCREPANCIES
    ''========================

    Sub LoadAllDiscrepancies()

        Dim dt As New DataTable()

        Dim sql As String =
        "SELECT DISTINCT
            sm.StockMovementID,
            sm.DateSubmitted,
            Format(sm.DateSubmitted, 'mmm-dd-yyyy hh:nn AM/PM') AS DisplayDate
        FROM StockMovementTbl sm
        INNER JOIN StockMoveItemsTbl smi
        ON sm.StockMovementID = smi.StockMoveID
        WHERE smi.Discrepancy <> 0
        ORDER BY sm.DateSubmitted DESC"

        Using cmd As New OleDbCommand(sql, oledbCnn)

            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using

        End Using

        lstDisc.DataSource = dt
        lstDisc.DisplayMember = "DisplayDate"
        lstDisc.ValueMember = "StockMovementID"

    End Sub

    Sub LoadDiscrepanciesByDate(startDate As Date, endDate As Date)

        Dim dt As New DataTable()

        Dim sql As String =
        "SELECT DISTINCT
            sm.StockMovementID,
            sm.DateSubmitted,
            Format(sm.DateSubmitted, 'mmm-dd-yyyy hh:nn AM/PM') AS DisplayDate
        FROM StockMovementTbl sm
        INNER JOIN StockMoveItemsTbl smi
        ON sm.StockMovementID = smi.StockMoveID
        WHERE smi.Discrepancy <> 0
        AND DateValue(sm.DateSubmitted) BETWEEN ? AND ?
        ORDER BY sm.DateSubmitted DESC"

        Using cmd As New OleDbCommand(sql, oledbCnn)

            cmd.Parameters.Add("?", OleDbType.Date).Value = startDate.Date
            cmd.Parameters.Add("?", OleDbType.Date).Value = endDate.Date

            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using

        End Using

        lstDisc.DataSource = dt
        lstDisc.DisplayMember = "DisplayDate"
        lstDisc.ValueMember = "StockMovementID"

    End Sub

    Sub LoadDiscrepancyDetails(stockMoveID As Integer)

        Dim sql As String =
        "SELECT 
            sm.StockMovementID,
            sm.DateSubmitted,
            sm.DiscStatus,
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

                    lblBaristaDisc.Text = "Barista: " & reader("BaristaName").ToString()
                    lblSuperDisc.Text = "Supervisor: " & reader("SupervisorName").ToString()
                    lblDateDisc.Text = "Date/Time: " & reader("DateSubmitted").ToString()
                    lblTransacDisc.Text = "Transaction ID: " & stockMoveID

                    Dim discStatus As Integer = Val(reader("DiscStatus"))

                    Dim statusText As String = ""

                    If discStatus = 1 Then
                        statusText = "Unresolved"
                    ElseIf discStatus = 2 Then
                        statusText = "Resolved"
                    Else
                        statusText = "No Discrepancy"
                    End If

                    lblStatus.Text = "Status: " & vbCrLf & statusText

                End If

            End Using

        End Using

    End Sub

    Sub LoadDiscrepancyItems(stockMoveID As Integer)

        Dim dt As New DataTable()

        Dim sql As String =
        "SELECT 
            i.ItemName,
            c.CatName AS Category,
            smi.RequestedQuantity,
            smi.ReceivedQuantity,
            (smi.Discrepancy * -1) AS Discrepancy,
            i.Unit
        FROM ((StockMoveItemsTbl smi
        INNER JOIN ItemsTbl i ON smi.StockItemID = i.ItemID)
        INNER JOIN CategoriesTbl c ON i.ItemCategory = c.CategoryID)
        WHERE smi.StockMoveID = ?
        AND smi.Discrepancy <> 0"

        Using cmd As New OleDbCommand(sql, oledbCnn)

            cmd.Parameters.Add("?", OleDbType.Integer).Value = stockMoveID

            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using

        End Using

        dgridDisc.DataSource = dt

        dgridDisc.EnableHeadersVisualStyles = False
        dgridDisc.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 214, 200)
        dgridDisc.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgridDisc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgridDisc.AllowUserToAddRows = False
        dgridDisc.RowHeadersVisible = False

        btnReorder.Enabled = False

        Dim discStatus As Integer = 0

        Dim sqlStatus As String =
        "SELECT DiscStatus
         FROM StockMovementTbl
         WHERE StockMovementID = ?"

        Using cmdStatus As New OleDbCommand(sqlStatus, oledbCnn)

            cmdStatus.Parameters.Add("?", OleDbType.Integer).Value = stockMoveID

            Dim result = cmdStatus.ExecuteScalar()

            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                discStatus = Convert.ToInt32(result)
            End If

        End Using

        If discStatus = 1 Then

            For Each row As DataGridViewRow In dgridDisc.Rows

                If row.IsNewRow Then Continue For

                Dim disc As Integer = Val(row.Cells("Discrepancy").Value)

                If disc > 0 Then
                    btnReorder.Enabled = True
                    Exit For
                End If

            Next

        End If

    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim dt As DataTable = GetAllDiscrepancyItems()

        If dt.Rows.Count = 0 Then
            MessageBox.Show("No discrepancy items to print.")
            Exit Sub
        End If

        Dim folder As String = Path.Combine(Application.StartupPath, "Reports")
        If Not Directory.Exists(folder) Then
            Directory.CreateDirectory(folder)
        End If

        Dim save As New SaveFileDialog()
        save.Filter = "PDF File|*.pdf"
        save.InitialDirectory = folder
        save.FileName = "Discrepancy_Report_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".pdf"

        If save.ShowDialog() = DialogResult.OK Then
            ExportDiscrepancyToPDF(save.FileName, dt)
            MessageBox.Show("PDF Exported Successfully")
        End If

    End Sub

    Private Function GetAllDiscrepancyItems() As DataTable

        Dim dt As New DataTable()

        Dim sql As String =
    "SELECT
        sm.StockMovementID AS OrderReqID,
        i.ItemName,
        smi.RequestedQuantity,
        smi.ReceivedQuantity,
        (smi.Discrepancy * -1) AS Discrepancy,
        i.Unit
    FROM ((StockMovementTbl sm
    INNER JOIN StockMoveItemsTbl smi ON sm.StockMovementID = smi.StockMoveID)
    INNER JOIN ItemsTbl i ON smi.StockItemID = i.ItemID)
    WHERE smi.Discrepancy <> 0"

        If _isDiscFiltered Then
            sql &= " AND DateValue(sm.DateSubmitted) BETWEEN ? AND ?"
        End If

        sql &= " ORDER BY sm.DateSubmitted DESC, i.ItemName"

        Using cmd As New OleDbCommand(sql, oledbCnn)

            If _isDiscFiltered Then
                cmd.Parameters.Add("?", OleDbType.Date).Value = dtStart.Value.Date
                cmd.Parameters.Add("?", OleDbType.Date).Value = dtEnd.Value.Date
            End If

            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using

        End Using

        Return dt

    End Function

    Private Sub ExportDiscrepancyToPDF(path As String, dt As DataTable)
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
        leftCell.AddElement(New Paragraph("STARBREWS INC.", titleFont))
        leftCell.AddElement(New Paragraph("Printed By: " & name, subFont))
        leftCell.AddElement(New Paragraph("Date: " & DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"), subFont))

        Dim dateRange As String
        If _isDiscFiltered Then
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

        Dim secTbl As New PdfPTable(1)
        secTbl.WidthPercentage = 100
        secTbl.SpacingAfter = 4
        Dim secCell As New PdfPCell(New Phrase("DISCREPANCY REPORT", sectionFont))
        secCell.BackgroundColor = New BaseColor(90, 75, 55)
        secCell.Border = PdfPCell.NO_BORDER
        secCell.Padding = 6
        secTbl.AddCell(secCell)
        doc.Add(secTbl)
        doc.Add(New Paragraph(" "))

        Dim colNames As String() = {"OrderReqID", "ItemName", "RequestedQuantity", "ReceivedQuantity", "Discrepancy", "Unit"}
        Dim colWidths As Single() = {1.2F, 3.0F, 1.5F, 1.5F, 1.5F, 1.0F}

        Dim table As New PdfPTable(colNames.Length)
        table.WidthPercentage = 100
        table.SetWidths(colWidths)

        Dim hFont As New iTextSharp.text.Font(baseFontBold, 9, iTextSharp.text.Font.BOLD, New BaseColor(40, 40, 40))

        For Each colName In colNames
            Dim cell As New PdfPCell(New Phrase(colName, hFont))
            cell.BackgroundColor = New BaseColor(220, 214, 200)
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            cell.Padding = 5
            cell.Border = PdfPCell.BOX
            cell.BorderColor = New BaseColor(180, 160, 130)
            table.AddCell(cell)
        Next

        Dim dFont As New iTextSharp.text.Font(baseFont, 9, iTextSharp.text.Font.NORMAL, New BaseColor(40, 40, 40))
        Dim rowIndex As Integer = 0

        For Each row As DataRow In dt.Rows
            Dim isAlt As Boolean = (rowIndex Mod 2 = 1)

            For i As Integer = 0 To colNames.Length - 1
                Dim colName = colNames(i).ToLower()
                Dim cell As New PdfPCell(New Phrase(row(colNames(i)).ToString(), dFont))
                cell.BackgroundColor = If(isAlt, New BaseColor(245, 242, 236), BaseColor.WHITE)
                cell.Padding = 5
                cell.Border = PdfPCell.BOX
                cell.BorderColor = New BaseColor(200, 190, 175)

                If colName = "itemname" Then
                    cell.HorizontalAlignment = Element.ALIGN_LEFT
                Else
                    cell.HorizontalAlignment = Element.ALIGN_CENTER
                End If

                If colName = "discrepancy" Then
                    Dim discVal As Integer = 0
                    If Integer.TryParse(row(colNames(i)).ToString(), discVal) AndAlso discVal < 0 Then
                        cell.BackgroundColor = New BaseColor(255, 220, 220)
                    End If
                End If

                table.AddCell(cell)
            Next

            rowIndex += 1
        Next

        doc.Add(table)
        doc.Close()

    End Sub

    Private Sub dtIn_ValueChanged(sender As Object, e As EventArgs) Handles dtIn.ValueChanged
        LoadStockInByDate(dtIn.Value)
    End Sub

    Private Sub btnAllIn_Click(sender As Object, e As EventArgs) Handles btnAllIn.Click
        LoadAllStockInLogs()
    End Sub

    Private Sub lstIn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstIn.SelectedIndexChanged

        If lstIn.SelectedValue Is Nothing Then Exit Sub
        If TypeOf lstIn.SelectedValue Is DataRowView Then Exit Sub

        Dim id As Integer

        If Not Integer.TryParse(lstIn.SelectedValue.ToString(), id) Then Exit Sub

        LoadStockInDetails(id)
        LoadStockInItems(id)

    End Sub

    Private Sub dtOut_ValueChanged(sender As Object, e As EventArgs) Handles dtOut.ValueChanged
        LoadStockOutByDate(dtOut.Value)
    End Sub

    Private Sub btnAllOut_Click(sender As Object, e As EventArgs) Handles btnAllOut.Click
        LoadAllStockOutLogs()
    End Sub

    Private Sub lstOut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOut.SelectedIndexChanged

        If lstOut.SelectedValue Is Nothing Then Exit Sub
        If TypeOf lstOut.SelectedValue Is DataRowView Then Exit Sub

        Dim id As Integer

        If Not Integer.TryParse(lstOut.SelectedValue.ToString(), id) Then Exit Sub

        LoadStockOutDetails(id)
        LoadStockOutItems(id)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        _isDiscFiltered = True
        LoadDiscrepanciesByDate(dtStart.Value, dtEnd.Value)
    End Sub

    Private Sub btnAllDisc_Click(sender As Object, e As EventArgs) Handles btnAllDisc.Click
        _isDiscFiltered = False
        LoadAllDiscrepancies()
    End Sub

    Private Sub lstDisc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDisc.SelectedIndexChanged

        If lstDisc.SelectedValue Is Nothing Then Exit Sub
        If TypeOf lstDisc.SelectedValue Is DataRowView Then Exit Sub

        Dim id As Integer

        If Not Integer.TryParse(lstDisc.SelectedValue.ToString(), id) Then Exit Sub

        LoadDiscrepancyDetails(id)
        LoadDiscrepancyItems(id)

    End Sub

    Private Sub dtStart_ValueChanged(sender As Object, e As EventArgs) Handles dtStart.ValueChanged
        dtEnd.MinDate = dtStart.Value.Date
    End Sub

    Private Sub dtEnd_ValueChanged(sender As Object, e As EventArgs) Handles dtEnd.ValueChanged
        dtStart.MaxDate = dtEnd.Value.Date
    End Sub

    Private Sub btnReorder_Click(sender As Object, e As EventArgs) Handles btnReorder.Click

        If lstDisc.SelectedValue Is Nothing OrElse TypeOf lstDisc.SelectedValue Is DataRowView Then Exit Sub

        Dim stockMoveID As Integer
        If Not Integer.TryParse(lstDisc.SelectedValue.ToString(), stockMoveID) Then Exit Sub

        Dim disc As New subReqDiscrepancy(stockMoveID)
        disc.ShowDialog()

    End Sub
End Class