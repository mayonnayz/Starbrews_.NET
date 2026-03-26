Imports System.Data.OleDb
Imports Microsoft.VisualBasic.ApplicationServices

Public Class tabAccounts
    Dim dt As New DataTable()
    Dim sql As String
    Dim status As Integer
    Public Shared purpose, fname, lname, uname, pass As String
    Public Shared userlvl, accId As Integer

    Private Sub tabAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        status = 1
        btnArchives.Text = "VIEW ARCHIVED ACCOUNTS"
        btnAddAccount.Visible = True

        dgridAccounts.ReadOnly = True
        dgridAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgridAccounts.MultiSelect = False

        LoadAccounts()
        cmbSearch.Text = "All"
    End Sub

    Sub LoadAccounts()
        dt.Clear()
        sql = "SELECT AccountID, FirstName, LastName, Username, [Password], UserLvl FROM AccountsTbl WHERE Status = " & status

        Using da As New OleDbDataAdapter(sql, oledbCnn)
            da.Fill(dt)
        End Using

        dgridAccounts.DataSource = dt
        dgridAccounts.AllowUserToAddRows = False

        SetupGrid()
        AddButtonColumns()

        If status = 0 Then
            If dgridAccounts.Columns.Contains("colView") Then
                dgridAccounts.Columns("colView").Visible = False
            End If
        Else
            If dgridAccounts.Columns.Contains("colView") Then
                dgridAccounts.Columns("colView").Visible = True
            End If
        End If

        dgridAccounts.EnableHeadersVisualStyles = False

        CType(dgridAccounts.Columns("colView"), DataGridViewButtonColumn).FlatStyle = FlatStyle.Flat
        CType(dgridAccounts.Columns("colArchive"), DataGridViewButtonColumn).FlatStyle = FlatStyle.Flat

        Dim btnCol As DataGridViewButtonColumn = CType(dgridAccounts.Columns("colArchive"), DataGridViewButtonColumn)

        If status = 1 Then
            btnCol.HeaderText = "Archive"
            btnCol.Text = "ARCHIVE"
        Else
            btnCol.HeaderText = "Restore"
            btnCol.Text = "RESTORE"
        End If

        Me.BeginInvoke(Sub()
                           dgridAccounts.ClearSelection()
                           dgridAccounts.CurrentCell = Nothing
                       End Sub)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim userlvl As Integer = -1
        dt.Clear()

        If cmbSearch.Text = "Super Admin" Then
            userlvl = 0
        ElseIf cmbSearch.Text = "Store Manager" Then
            userlvl = 1
        ElseIf cmbSearch.Text = "Shift Supervisor" Then
            userlvl = 2
        ElseIf cmbSearch.Text = "Barista" Then
            userlvl = 3
        End If

        If txtSearch.Text.Trim = "" Then
            If userlvl = -1 Then
                sql = "SELECT AccountID, FirstName, LastName, Username, [Password], UserLvl FROM AccountsTbl WHERE Status = " & status
                Using da As New OleDbDataAdapter(sql, oledbCnn)
                    da.Fill(dt)
                End Using
            Else
                sql = "SELECT AccountID, FirstName, LastName, Username, [Password], UserLvl FROM AccountsTbl WHERE UserLvl = ? AND Status = " & status
                Using da As New OleDbDataAdapter(sql, oledbCnn)
                    da.SelectCommand.Parameters.AddWithValue("?", userlvl)
                    da.Fill(dt)
                End Using
            End If

        Else
            If userlvl = -1 Then
                sql = "SELECT AccountID, FirstName, LastName, Username, [Password], UserLvl FROM AccountsTbl WHERE (FirstName LIKE ? OR LastName LIKE ?) AND Status = " & status
                Using da As New OleDbDataAdapter(sql, oledbCnn)
                    da.SelectCommand.Parameters.AddWithValue("?", "%" & txtSearch.Text & "%")
                    da.SelectCommand.Parameters.AddWithValue("?", "%" & txtSearch.Text & "%")
                    da.Fill(dt)
                End Using
            Else
                sql = "SELECT AccountID, FirstName, LastName, Username, [Password], UserLvl FROM AccountsTbl 
                   WHERE (FirstName LIKE ? OR LastName LIKE ?) AND UserLvl = ? AND Status = " & status
                Using da As New OleDbDataAdapter(sql, oledbCnn)
                    da.SelectCommand.Parameters.AddWithValue("?", "%" & txtSearch.Text & "%")
                    da.SelectCommand.Parameters.AddWithValue("?", "%" & txtSearch.Text & "%")
                    da.SelectCommand.Parameters.AddWithValue("?", userlvl)
                    da.Fill(dt)
                End Using
            End If
        End If

        dgridAccounts.DataSource = dt
    End Sub

    Private Sub btnAddAccount_Click(sender As Object, e As EventArgs) Handles btnAddAccount.Click
        Dim subAcc As New subAccounts()

        purpose = "Create New Account"

        subAcc.ShowDialog()
        LoadAccounts()
    End Sub
    Private Sub dgridAccounts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgridAccounts.CellContentClick

        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgridAccounts.Rows(e.RowIndex)

        ' VIEW BUTTON
        If dgridAccounts.Columns(e.ColumnIndex).Name = "colView" Then

            Dim subAcc As New subAccounts()

            purpose = "Account Info"

            accId = Convert.ToInt32(row.Cells("AccountID").Value)
            fname = row.Cells("FirstName").Value.ToString()
            lname = row.Cells("LastName").Value.ToString()
            uname = row.Cells("Username").Value.ToString()
            pass = row.Cells("Password").Value.ToString()
            userlvl = Convert.ToInt32(row.Cells("UserLvl").Value)

            subAcc.ShowDialog()
            dt.Clear()
            LoadAccounts()

        End If

        ' ARCHIVE / RESTORE BUTTON
        If dgridAccounts.Columns(e.ColumnIndex).Name = "colArchive" Then

            Dim lvl As Integer = Convert.ToInt32(row.Cells("UserLvl").Value)

            If lvl = 0 Then
                MessageBox.Show("Super Admin accounts cannot be archived.")
                Exit Sub
            End If

            Dim result As String
            Dim dialogue As String = ""

            If status = 1 Then
                dialogue = "Are you sure you want to delete this account? (it will be stored in the archived accounts)"
            ElseIf status = 0 Then
                dialogue = "Are you sure you want to restore this account?"
            End If

            result = MessageBox.Show(dialogue, "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then

                If status = 1 Then
                    Dim sql As String = "UPDATE AccountsTbl SET Status = 0 WHERE AccountId = ?"

                    Using cmd As New OleDbCommand(sql, oledbCnn)
                        cmd.Parameters.AddWithValue("?", Convert.ToInt32(row.Cells("AccountID").Value))
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Account archived!")

                ElseIf status = 0 Then
                    Dim sql As String = "UPDATE AccountsTbl SET Status = 1 WHERE AccountId = ?"

                    Using cmd As New OleDbCommand(sql, oledbCnn)
                        cmd.Parameters.AddWithValue("?", Convert.ToInt32(row.Cells("AccountID").Value))
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Account restored!")
                End If
                LoadAccounts()
            End If
        End If
    End Sub


    Sub SetupGrid()
        For Each col As DataGridViewColumn In dgridAccounts.Columns
            If TypeOf col IsNot DataGridViewButtonColumn Then
                col.Visible = False
            End If
        Next

        dgridAccounts.Columns("FirstName").Visible = True
        dgridAccounts.Columns("LastName").Visible = True
        dgridAccounts.Columns("UserLvl").Visible = True

        dgridAccounts.Columns("FirstName").HeaderText = "First Name"
        dgridAccounts.Columns("LastName").HeaderText = "Last Name"
        dgridAccounts.Columns("UserLvl").HeaderText = "User Level"
    End Sub

    Sub AddButtonColumns()
        If Not dgridAccounts.Columns.Contains("colView") Then
            Dim btnView As New DataGridViewButtonColumn()
            btnView.Name = "colView"
            btnView.HeaderText = "View"
            btnView.Text = "VIEW"
            btnView.UseColumnTextForButtonValue = True

            btnView.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#a5a18d")
            btnView.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#808271")
            btnView.DefaultCellStyle.ForeColor = Color.White
            btnView.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

            dgridAccounts.Columns.Add(btnView)
        End If

        If Not dgridAccounts.Columns.Contains("colArchive") Then
            Dim btnArchive As New DataGridViewButtonColumn()
            btnArchive.Name = "colArchive"
            btnArchive.HeaderText = "Archive"
            btnArchive.Text = "ARCHIVE"
            btnArchive.UseColumnTextForButtonValue = True

            btnArchive.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#a5a18d")
            btnArchive.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#808271")
            btnArchive.DefaultCellStyle.ForeColor = Color.White
            btnArchive.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

            dgridAccounts.Columns.Add(btnArchive)
        End If
    End Sub

    Private Sub dgridAccounts_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgridAccounts.CellFormatting
        If dgridAccounts.Columns(e.ColumnIndex).Name = "UserLvl" AndAlso e.Value IsNot Nothing Then
            Select Case Convert.ToInt32(e.Value)
                Case 0
                    e.Value = "Super Admin"
                Case 1
                    e.Value = "Store Manager"
                Case 2
                    e.Value = "Shift Supervisor"
                Case 3
                    e.Value = "Barista"
            End Select

            e.FormattingApplied = True
        End If

        If dgridAccounts.Columns(e.ColumnIndex).Name = "colArchive" AndAlso e.RowIndex >= 0 Then

            Dim lvl As Integer = Convert.ToInt32(dgridAccounts.Rows(e.RowIndex).Cells("UserLvl").Value)

            If lvl = 0 Then
                e.CellStyle.BackColor = Color.LightGray
                e.CellStyle.ForeColor = Color.DarkGray
                e.Value = "LOCKED"
                e.FormattingApplied = True
            End If

        End If
    End Sub

    Private Sub btnArchives_Click(sender As Object, e As EventArgs) Handles btnArchives.Click
        If btnArchives.Text = "VIEW ARCHIVED ACCOUNTS" Then
            dt.Clear()
            btnArchives.Text = "VIEW ACTIVE ACCOUNTS"
            btnAddAccount.Visible = False
            status = 0
            LoadAccounts()
        ElseIf btnArchives.Text = "VIEW ACTIVE ACCOUNTS" Then
            dt.Clear()
            btnArchives.Text = "VIEW ARCHIVED ACCOUNTS"
            btnAddAccount.Visible = True
            status = 1
            LoadAccounts()
        End If
    End Sub

End Class
