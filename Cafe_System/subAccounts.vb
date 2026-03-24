Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class subAccounts
    Private Sub subAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = tabAccounts.purpose

        If (tabAccounts.userlvl <> 0) Or (tabAccounts.purpose = "Create New Account") Then
            cmbUlvl.Enabled = True
        Else
            cmbUlvl.Enabled = False
        End If

        If tabAccounts.purpose = "Account Info" Then
            txtFName.Text = tabAccounts.fname
            txtLName.Text = tabAccounts.lname
            txtUname.Text = tabAccounts.uname
            txtPass.Text = tabAccounts.pass
            cmbUlvl.SelectedIndex = tabAccounts.userlvl
        ElseIf tabAccounts.purpose = "Create New Account" Then
            txtFName.Text = ""
            txtLName.Text = ""
            txtUname.Text = ""
            txtPass.Text = ""
            cmbUlvl.SelectedIndex = 3
        End If

        Me.BeginInvoke(Sub()
                           Me.ActiveControl = Nothing
                       End Sub)
    End Sub

    Private Function ValidateInputs() As Boolean
        Dim namePattern As String = "^[A-Za-z\s]+$"

        Dim userPassPattern As String = "^\S+$"

        If Not Regex.IsMatch(txtFName.Text, namePattern) Then
            MessageBox.Show("First name must contain letters only (no numbers or special characters).")
            txtFName.Focus()
            Return False
        End If

        If Not Regex.IsMatch(txtLName.Text, namePattern) Then
            MessageBox.Show("Last name must contain letters only (no numbers or special characters).")
            txtLName.Focus()
            Return False
        End If

        If Not Regex.IsMatch(txtUname.Text, userPassPattern) Then
            MessageBox.Show("Username must not contain spaces.")
            txtUname.Focus()
            Return False
        End If

        If Not Regex.IsMatch(txtPass.Text, userPassPattern) Then
            MessageBox.Show("Password must not contain spaces.")
            txtPass.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function ToProperCase(input As String) As String
        Dim words() As String = input.Split(" "c)
        For i As Integer = 0 To words.Length - 1
            If words(i).Length > 0 Then
                words(i) = Char.ToUpper(words(i)(0)) & words(i).Substring(1).ToLower()
            End If
        Next
        Return String.Join(" ", words)
    End Function

    Private Sub txtFName_Leave(sender As Object, e As EventArgs) Handles txtFName.Leave
        txtFName.Text = ToProperCase(txtFName.Text)
    End Sub

    Private Sub txtLName_Leave(sender As Object, e As EventArgs) Handles txtLName.Leave
        txtLName.Text = ToProperCase(txtLName.Text)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim result As String = ""

        If tabAccounts.purpose = "Account Info" Then
            result = MessageBox.Show("Are you sure you want to submit changes?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        ElseIf tabAccounts.purpose = "Create New Account" Then
            result = MessageBox.Show("Are you sure you want to create account?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End If

        If result = DialogResult.Yes Then
            If Not ValidateInputs() Then Exit Sub

            If tabAccounts.purpose = "Edit Account" Then
                Dim sql As String = "UPDATE AccountsTbl SET FirstName = ?, LastName = ?, Username = ?, [Password] = ?, UserLvl = ? WHERE AccountId = ?"

                Using cmd As New OleDbCommand(sql, oledbCnn)
                    cmd.Parameters.AddWithValue("?", txtFName.Text)
                    cmd.Parameters.AddWithValue("?", txtLName.Text)
                    cmd.Parameters.AddWithValue("?", txtUname.Text)
                    cmd.Parameters.AddWithValue("?", txtPass.Text)
                    cmd.Parameters.AddWithValue("?", cmbUlvl.SelectedIndex)
                    cmd.Parameters.AddWithValue("?", tabAccounts.accId)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Account updated successfully!")
            ElseIf tabAccounts.purpose = "Create New Account" Then
                Dim sql As String = "INSERT INTO AccountsTbl (FirstName, LastName, Username, [Password], UserLvl, Status) VALUES (?, ?, ?, ?, ?, ?)"

                Using cmd As New OleDbCommand(sql, oledbCnn)
                    cmd.Parameters.AddWithValue("?", txtFName.Text)
                    cmd.Parameters.AddWithValue("?", txtLName.Text)
                    cmd.Parameters.AddWithValue("?", txtUname.Text)
                    cmd.Parameters.AddWithValue("?", txtPass.Text)
                    cmd.Parameters.AddWithValue("?", cmbUlvl.SelectedIndex)
                    cmd.Parameters.AddWithValue("?", "1")
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Account created successfully!")

            End If
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As String
        result = MessageBox.Show("Do you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSubmit_MouseEnter(sender As Object, e As EventArgs) Handles btnSubmit.MouseEnter
        btnSubmit.BackgroundImage = My.Resources.btngeneralhover
        btnSubmit.BackgroundImageLayout = ImageLayout.Zoom
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.FlatAppearance.BorderSize = 0
        btnSubmit.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnSubmit.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnSubmit.BackColor = Color.Transparent
        btnSubmit.BackgroundImageLayout = ImageLayout.Zoom
    End Sub
    Private Sub btnSubmit_MouseLeave(sender As Object, e As EventArgs) Handles btnSubmit.MouseLeave
        btnSubmit.BackgroundImage = My.Resources.btngeneral
        btnSubmit.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub btnCancel_MouseEnter(sender As Object, e As EventArgs) Handles btnCancel.MouseEnter
        btnCancel.BackgroundImage = My.Resources.btngeneralhover
        btnCancel.BackgroundImageLayout = ImageLayout.Zoom
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnCancel.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnCancel.BackColor = Color.Transparent
        btnCancel.BackgroundImageLayout = ImageLayout.Zoom
    End Sub
    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btnCancel.MouseLeave
        btnCancel.BackgroundImage = My.Resources.btngeneral
        btnCancel.BackgroundImageLayout = ImageLayout.Zoom
    End Sub


End Class