Public Module Config
    Private _connectionString As String

    Public Sub SetConnectionString(ByVal connectionString As String)
        _connectionString = connectionString
    End Sub

    Public Function GetConnectionString() As String
        Return _connectionString
    End Function
End Module
