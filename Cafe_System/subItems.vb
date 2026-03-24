Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class subItems
    Dim price As Decimal
    Private Sub subItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTitle.Text = tabItems.purpose

        LoadCategories()

        If tabItems.purpose = "Item Info" Then
            txtIName.Text = tabItems.itemName
            txtIDesc.Text = tabItems.itemDesc
            cmbCategory.SelectedValue = tabItems.itemCategory
            txtUPrice.Text = tabItems.unitPrice
            txtUnit.Text = tabItems.unit
        ElseIf tabItems.purpose = "Create New Item" Then
            txtIName.Text = ""
            txtIDesc.Text = ""
            txtUPrice.Text = ""
            txtUnit.Text = ""
            cmbCategory.SelectedIndex = 0
        End If

        Me.BeginInvoke(Sub()
                           Me.ActiveControl = Nothing
                       End Sub)

    End Sub


    Private Function ValidateInputs() As Boolean

        Dim namePattern As String = "^[A-Za-z0-9\s]+$"
        Dim descPattern As String = "^[A-Za-z0-9\s\.,]+$"
        Dim pricePattern As String = "^\d+(\.\d{1,2})?$"
        Dim unitPattern As String = "^[A-Za-z\s]+$"

        If Not Regex.IsMatch(txtIName.Text, namePattern) Then
            MessageBox.Show("Item name is invalid.")
            txtIName.Focus()
            Return False
        End If

        If Not Regex.IsMatch(txtIDesc.Text, descPattern) Then
            MessageBox.Show("Item description contains invalid characters.")
            txtIDesc.Focus()
            Return False
        End If



        If Not Decimal.TryParse(txtUPrice.Text, price) Then
            MessageBox.Show("Price must be a valid number.")
            txtUPrice.Focus()
            Return False
        End If

        If price <= 0D Then
            MessageBox.Show("Price must be greater than 0.")
            txtUPrice.Focus()
            Return False
        End If

        If Not Regex.IsMatch(txtUnit.Text, unitPattern) Then
            MessageBox.Show("Unit must contain letters only.")
            txtUnit.Focus()
            Return False
        End If

        Return True

    End Function


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim result As DialogResult

        If tabItems.purpose = "Item Info" Then
            result = MessageBox.Show("Update this item?", "Confirm", MessageBoxButtons.YesNo)

        ElseIf tabItems.purpose = "Create New Item" Then
            result = MessageBox.Show("Create this item?", "Confirm", MessageBoxButtons.YesNo)
        End If

        If result = DialogResult.No Then Exit Sub
        If Not ValidateInputs() Then Exit Sub


        If tabItems.purpose = "Item Info" Then

            Dim sql As String =
                "UPDATE ItemsTbl SET ItemName=?, ItemDesc=?, ItemCategory=?, UnitPrice=?, Unit=? WHERE ItemID=?"

            Using cmd As New OleDbCommand(sql, oledbCnn)
                cmd.Parameters.AddWithValue("?", txtIName.Text)
                cmd.Parameters.AddWithValue("?", txtIDesc.Text)
                cmd.Parameters.AddWithValue("?", cmbCategory.SelectedValue)
                cmd.Parameters.AddWithValue("?", price)
                cmd.Parameters.AddWithValue("?", txtUnit.Text)
                cmd.Parameters.AddWithValue("?", tabItems.itemId)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Item updated successfully!")

        ElseIf tabItems.purpose = "Create New Item" Then

            Dim sql As String =
                "INSERT INTO ItemsTbl (ItemName, ItemDesc, ItemCategory, UnitPrice, Unit, ItemStatus) VALUES (?, ?, ?, ?, ?, ?)"

            Using cmd As New OleDbCommand(sql, oledbCnn)
                cmd.Parameters.AddWithValue("?", txtIName.Text)
                cmd.Parameters.AddWithValue("?", txtIDesc.Text)
                cmd.Parameters.AddWithValue("?", cmbCategory.SelectedValue)
                cmd.Parameters.AddWithValue("?", price)
                cmd.Parameters.AddWithValue("?", txtUnit.Text)
                cmd.Parameters.AddWithValue("?", 1)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Item created successfully!")

        End If

        Me.Close()
    End Sub

    Private Sub LoadCategories()

        Dim dt As New DataTable()

        Dim sql As String = "SELECT CategoryID, CatName FROM CategoriesTbl"

        Using da As New OleDbDataAdapter(sql, oledbCnn)
            da.Fill(dt)
        End Using

        cmbCategory.DataSource = dt
        cmbCategory.DisplayMember = "CatName"
        cmbCategory.ValueMember = "CategoryID"

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