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
        btnDeleteAccount.Text = "DELETE ACCOUNT"
        btnEditAccount.Visible = True
        btnAddAccount.Visible = True
        UpdateButtonState()

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

    Private Sub btnEditAccount_Click(sender As Object, e As EventArgs) Handles btnEditAccount.Click
        If dgridAccounts.CurrentRow IsNot Nothing Then

            Dim subAcc As New subAccounts()

            purpose = "Edit Account"

            accId = Convert.ToInt32(dgridAccounts.CurrentRow.Cells("AccountID").Value)
            fname = dgridAccounts.CurrentRow.Cells("FirstName").Value.ToString()
            lname = dgridAccounts.CurrentRow.Cells("LastName").Value.ToString()
            uname = dgridAccounts.CurrentRow.Cells("Username").Value.ToString()
            pass = dgridAccounts.CurrentRow.Cells("Password").Value.ToString()
            userlvl = Convert.ToInt32(dgridAccounts.CurrentRow.Cells("UserLvl").Value)

            subAcc.ShowDialog()
            dt.Clear()
            LoadAccounts()
        Else
            MessageBox.Show("Please select a row to edit.")
        End If
    End Sub

    Private Sub btnDeleteAccount_Click(sender As Object, e As EventArgs) Handles btnDeleteAccount.Click
        Dim result As String
        Dim dialogue As String = ""
        If status = 1 Then
            dialogue = "Are you sure you want to delete this account? (it will be stored in the archived accounts)"
        ElseIf status = 0 Then
            dialogue = "Are you sure you want to restore this account?"
        End If

        result = MessageBox.Show(dialogue, "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            If btnDeleteAccount.Text = "DELETE ACCOUNT" Then
                Dim sql As String = "UPDATE AccountsTbl SET Status = 0 WHERE AccountId = ?"

                Using cmd As New OleDbCommand(sql, oledbCnn)
                    cmd.Parameters.AddWithValue("?", Convert.ToInt32(dgridAccounts.CurrentRow.Cells("AccountID").Value))
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Account archived!")
                LoadAccounts()
            ElseIf btnDeleteAccount.Text = "RESTORE ACCOUNT" Then
                Dim sql As String = "UPDATE AccountsTbl SET Status = 1 WHERE AccountId = ?"

                Using cmd As New OleDbCommand(sql, oledbCnn)
                    cmd.Parameters.AddWithValue("?", Convert.ToInt32(dgridAccounts.CurrentRow.Cells("AccountID").Value))
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Account restored!")
                LoadAccounts()
            End If
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
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles dgridAccounts.SelectionChanged
        UpdateButtonState()
    End Sub

    Private Sub UpdateButtonState()
        If dgridAccounts.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = dgridAccounts.SelectedRows(0)
            Dim userLevel As Integer = Convert.ToInt32(selectedRow.Cells("UserLvl").Value)

            btnEditAccount.Enabled = True

            If userLevel = 0 Then
                btnDeleteAccount.Enabled = False
            Else
                btnDeleteAccount.Enabled = True
            End If

        Else
            btnEditAccount.Enabled = False
            btnDeleteAccount.Enabled = False
        End If
    End Sub

    Private Sub btnArchives_Click(sender As Object, e As EventArgs) Handles btnArchives.Click
        If btnArchives.Text = "VIEW ARCHIVED ACCOUNTS" Then
            dt.Clear()
            btnArchives.Text = "VIEW ACTIVE ACCOUNTS"
            btnDeleteAccount.Text = "RESTORE ACCOUNT"
            btnEditAccount.Visible = False
            btnAddAccount.Visible = False
            status = 0
            LoadAccounts()
        ElseIf btnArchives.Text = "VIEW ACTIVE ACCOUNTS" Then
            dt.Clear()
            btnArchives.Text = "VIEW ARCHIVED ACCOUNTS"
            btnDeleteAccount.Text = "DELETE ACCOUNT"
            btnEditAccount.Visible = True
            btnAddAccount.Visible = True
            status = 1
            LoadAccounts()
        End If
    End Sub
End Class
