Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class subCat

    Private Sub subCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTitle.Text = subCategory.purpose

        If subCategory.purpose = "Category Info" Then

            txtCName.Text = subCategory.catName
            txtDesc.Text = subCategory.catDesc

            txtCName.ReadOnly = False
            txtDesc.ReadOnly = False

        ElseIf subCategory.purpose = "Create Category" Then

            txtCName.Text = ""
            txtDesc.Text = ""

        End If

        Me.BeginInvoke(Sub()
                           Me.ActiveControl = Nothing
                       End Sub)

    End Sub

    Private Function ValidateInputs() As Boolean

        Dim namePattern As String = "^[A-Za-z0-9\s]+$"
        Dim descPattern As String = "^[A-Za-z0-9\s\.,]+$"

        If Not Regex.IsMatch(txtCName.Text, namePattern) Then
            MessageBox.Show("Category name is invalid.")
            txtCName.Focus()
            Return False
        End If

        If txtCName.Text.Trim = "" Then
            MessageBox.Show("Category name is required.")
            txtCName.Focus()
            Return False
        End If

        If Not Regex.IsMatch(txtDesc.Text, descPattern) Then
            MessageBox.Show("Category description contains invalid characters.")
            txtDesc.Focus()
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

    Private Sub txtCName_Leave(sender As Object, e As EventArgs) Handles txtCName.Leave
        txtCName.Text = ToProperCase(txtCName.Text)
    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim result As DialogResult

        If subCategory.purpose = "Create Category" Then
            result = MessageBox.Show("Create this category?", "Confirm", MessageBoxButtons.YesNo)
        Else
            result = MessageBox.Show("Update this category?", "Confirm", MessageBoxButtons.YesNo)
        End If

        If result = DialogResult.No Then Exit Sub
        If Not ValidateInputs() Then Exit Sub

        ' UPDATE 
        If subCategory.purpose = "Category Info" Then

            Dim sql As String =
                "UPDATE CategoriesTbl SET CatName=?, CatDesc=? WHERE CategoryID=?"

            Using cmd As New OleDbCommand(sql, oledbCnn)
                cmd.Parameters.AddWithValue("?", txtCName.Text)
                cmd.Parameters.AddWithValue("?", txtDesc.Text)
                cmd.Parameters.AddWithValue("?", subCategory.categoryId)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Category updated successfully!")

            ' INSERT
        ElseIf subCategory.purpose = "Create Category" Then

            Dim sql As String =
                "INSERT INTO CategoriesTbl (CatName, CatDesc, CatStatus) VALUES (?, ?, 1)"

            Using cmd As New OleDbCommand(sql, oledbCnn)
                cmd.Parameters.AddWithValue("?", txtCName.Text)
                cmd.Parameters.AddWithValue("?", txtDesc.Text)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Category created successfully!")

        End If

        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        If MessageBox.Show("Cancel?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
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