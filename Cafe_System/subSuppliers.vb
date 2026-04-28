Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class subSuppliers

    Private Sub subSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()

        If tabOrderRequests.purpose = "Edit Supplier" Then
            lblTitle.Text = tabOrderRequests.purpose
            LoadSupplierDetails()
        ElseIf tabOrderRequests.purpose = "Add New Supplier" Then
            lblTitle.Text = tabOrderRequests.purpose

            txtSName.Clear()
            txtContact.Clear()
            txtEmail.Clear()
            txtAddress.Clear()

            If cmbCategory.DataSource IsNot Nothing AndAlso cmbCategory.Items.Count > 0 Then
                cmbCategory.SelectedIndex = 0
            End If
        End If

    End Sub
    Private Sub LoadSupplierDetails()
        LoadCategories()
        Try
            Dim sql As String = "SELECT s.*, c.CatName FROM SupplierTbl s INNER JOIN CategoriesTbl c ON s.SupplierCategory = c.CategoryID WHERE s.SupplierID = ?"
            Using cmd As New OleDbCommand(sql, oledbCnn)
                cmd.Parameters.AddWithValue("?", tabOrderRequests.suppID)

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtSName.Text = reader("SupplierName").ToString()
                        txtContact.Text = reader("ContactNo").ToString()
                        txtEmail.Text = reader("Email").ToString()
                        txtAddress.Text = reader("Address").ToString()
                        cmbCategory.SelectedValue = Convert.ToInt32(reader("SupplierCategory"))
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading supplier details: " & ex.Message)
        End Try
    End Sub


    Private Function ValidateInputs() As Boolean
        Dim namePattern As String = "^[A-Za-z\s]+$"
        Dim contactPattern As String = "^\d+$"
        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Dim addressPattern As String = "^[A-Za-z0-9\s,\.]+$"
        Dim userPassPattern As String = "^\S+$"

        If Not Regex.IsMatch(txtSName.Text, namePattern) Then
            MessageBox.Show("Supplier name must contain letters only.")
            txtSName.Focus()
            Return False
        End If

        If Not Regex.IsMatch(txtContact.Text, contactPattern) Then
            MessageBox.Show("Contact number must contain digits only (no letters or decimals).")
            txtContact.Focus()
            Return False
        End If

        If Not Regex.IsMatch(txtEmail.Text, emailPattern) Then
            MessageBox.Show("Please enter a valid email address.")
            txtEmail.Focus()
            Return False
        End If

        If Not Regex.IsMatch(txtAddress.Text, addressPattern) Then
            MessageBox.Show("Address must contain letters and numbers only.")
            txtAddress.Focus()
            Return False
        End If

        Return True
    End Function
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim result As String = ""
        If tabOrderRequests.purpose = "Edit Supplier" Then
            result = MessageBox.Show("Are you sure you want to submit changes?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        ElseIf tabOrderRequests.purpose = "Add New Supplier" Then
            result = MessageBox.Show("Are you sure you want to add supplier?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End If

        If result = DialogResult.Yes Then
            If Not ValidateInputs() Then Exit Sub

            If tabOrderRequests.purpose = "Edit Supplier" Then
                Dim sql As String = "UPDATE SupplierTbl SET SupplierName = ?, [ContactNo] = ?, [Email] = ?, [Address] = ?, SupplierCategory = ? WHERE SupplierID = ?"

                Using cmd As New OleDbCommand(sql, oledbCnn)
                    cmd.Parameters.AddWithValue("?", txtSName.Text)
                    cmd.Parameters.AddWithValue("?", txtContact.Text)
                    cmd.Parameters.AddWithValue("?", txtEmail.Text)
                    cmd.Parameters.AddWithValue("?", txtAddress.Text)
                    cmd.Parameters.AddWithValue("?", cmbCategory.SelectedValue)
                    cmd.Parameters.AddWithValue("?", tabOrderRequests.suppID)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Supplier updated successfully!")
            ElseIf tabOrderRequests.purpose = "Add New Supplier" Then
                Dim sql As String = "INSERT INTO SupplierTbl (SupplierName, ContactNo, Email, Address, SupplierCategory, SupplierStatus) VALUES (?, ?, ?, ?, ?, ?)"

                Using cmd As New OleDbCommand(sql, oledbCnn)
                    cmd.Parameters.AddWithValue("?", txtSName.Text)
                    cmd.Parameters.AddWithValue("?", txtContact.Text)
                    cmd.Parameters.AddWithValue("?", txtEmail.Text)
                    cmd.Parameters.AddWithValue("?", txtAddress.Text)
                    cmd.Parameters.AddWithValue("?", cmbCategory.SelectedValue)
                    cmd.Parameters.AddWithValue("?", "1")
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Supplier created successfully!")

            End If
            Me.Close()
        End If
    End Sub

    Private Sub LoadCategories()
        Dim sql As String = "SELECT CategoryID, CatName FROM CategoriesTbl"

        Dim dt As New DataTable()

        Using cmd As New OleDbCommand(sql, oledbCnn)
            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        cmbCategory.DataSource = dt
        cmbCategory.DisplayMember = "CatName"
        cmbCategory.ValueMember = "CategoryID"
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