Imports System.Data.OleDb
Imports System.Resources

Public Class Form1
    Public Shared UserId, UserLvl As Integer
    Public Shared FirstName, LastName As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        OpenConnection()
        accountsSet()

        txtPassword.UseSystemPasswordChar = False
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Credentials Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        sql = "SELECT * FROM AccountsTbl WHERE StrComp([Username], ?, 0) = 0 AND StrComp([Password], ?, 0) = 0 AND Status = 1"

        Using cmd As New OleDbCommand(sql, oledbCnn)
            cmd.Parameters.AddWithValue("?", username)
            cmd.Parameters.AddWithValue("?", password)

            Using reader As OleDbDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    UserId = Convert.ToInt32(reader("AccountId"))
                    UserLvl = Convert.ToInt32(reader("UserLvl"))
                    FirstName = reader("FirstName").ToString()
                    LastName = reader("LastName").ToString()

                    txtUsername.Clear()
                    txtPassword.Clear()

                    Dim dashboard As New Dashboard()
                    dashboard.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid login credentials. Check username and password (case-sensitive).", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub
    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked Then
            txtPassword.UseSystemPasswordChar = True
        Else
            txtPassword.UseSystemPasswordChar = False
        End If
    End Sub
    Private Sub btnLogin_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter
        btnLogin.BackgroundImage = My.Resources.loginbtnhover
        btnLogin.BackgroundImageLayout = ImageLayout.Zoom
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnLogin.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnLogin.BackColor = Color.Transparent
        btnLogin.BackgroundImageLayout = ImageLayout.Zoom
    End Sub
    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        btnLogin.BackgroundImage = My.Resources.loginbtn
        btnLogin.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class
