Imports System.Data.OleDb

Module Module1
    Dim connectionString As String
    Public oledbCnn As OleDbConnection

    Public oledbAdapterAccounts As OleDbDataAdapter
    Public accountsDataSet As New DataSet
    Public drow, drow2 As DataRow

    Public sql As String

    Public Function OpenConnection() As Boolean

        connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\zyann\Documents\.Net\CafeDBase.accdb"
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


    'Public Sub BuilderConn(ByVal b As OleDbDataAdapter)
    '    Dim builder As New OleDbCommandBuilder(b)
    '    builder.GetUpdateCommand()
    '    builder.ConflictOption = ConflictOption.OverwriteChanges
    'End Sub

    'Public Sub updateTable(ByVal a As OleDbDataAdapter, ByVal d As DataSet, ByVal t As String, ByVal m As String)
    '    BuilderConn(a)
    '    a.Update(d, t)
    '    MessageBox.Show(m, "Information")
    'End Sub

End Module
