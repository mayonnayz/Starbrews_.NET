Imports System.Data.OleDb

Module Module1
    Dim connectionString As String
    Public oledbCnn As OleDbConnection

    Public oledbAdapterAccounts As OleDbDataAdapter
    Public accountsDataSet As New DataSet
    Public drow, drow2 As DataRow

    Public sql As String

    Public Function OpenConnection() As Boolean

        connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\zyann\Documents\.Net\Starbrews\Starbrews_.NET\CafeDBase.accdb"
        oledbCnn = New OleDbConnection(connectionString)

        Try
            oledbCnn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End Try
        Return True

    End Function

    Public Sub accountsSet()
        sql = "Select * from AccountsTbl"
        oledbAdapterAccounts = New OleDbDataAdapter(sql, oledbCnn)
        oledbAdapterAccounts.Fill(accountsDataSet, "AccountsTbl")
    End Sub



End Module
