Imports System.Reflection

Public MustInherit Class ObjectBasePersistent(Of t)
    Private _connection As SQLite.SQLiteConnection
    Private _command As SQLite.SQLiteCommand
    Private _db As SQLite.SQLiteDataAdapter

    Private _id As String
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    'Users can call New() but this will generate a Guid as the id
    Public Sub New()
        Me.New(New Guid().ToString)
    End Sub

    Public Sub New(ByVal id As String)
        _id = id
        _connection = New SQLite.SQLiteConnection(Config.GetConnectionString())
    End Sub

    Public Sub ExecuteQuery(ByVal query As String)
        _connection.Open()
        _command = _connection.CreateCommand()
        _command.CommandText = query
        _command.ExecuteNonQuery()
        _connection.Close()
    End Sub

    Public Function GetData(ByVal query As String) As List(Of Dictionary(Of String, String))
        Dim returnData As New List(Of Dictionary(Of String, String))
        Dim dataReader As SQLite.SQLiteDataReader

        _connection.Open()

        _command = _connection.CreateCommand()
        _command.CommandText = query
        dataReader = _command.ExecuteReader()

        If dataReader.HasRows Then
            While dataReader.Read()
                Dim row As New Dictionary(Of String, String)

                For i = 0 To dataReader.FieldCount - 1
                    Select Case dataReader.GetFieldType(i)
                        Case GetType(Integer)
                            row.Add(dataReader.GetName(i), dataReader.GetInt32(i).ToString)
                        Case GetType(Long)
                            row.Add(dataReader.GetName(i), dataReader.GetInt64(i).ToString)
                        Case GetType(String)
                            row.Add(dataReader.GetName(i), dataReader.GetString(i))
                    End Select
                Next

                returnData.Add(row)
            End While
        End If

        dataReader.Close()
        _connection.Close()

        Return returnData
    End Function

    Public Function FillData() As Boolean
        Dim status As Boolean = False
        Dim dataReader As SQLite.SQLiteDataReader

        _connection.Open()
        _command = _connection.CreateCommand()
        _command.CommandText = GetFillQueryText()
        dataReader = _command.ExecuteReader()

        If dataReader.HasRows Then
            dataReader.Read()
            For Each propInfo As PropertyInfo In GetType(t).GetProperties
                Select Case propInfo.PropertyType
                    Case GetType(Integer)
                        propInfo.SetValue(Me, CInt(dataReader(propInfo.Name)))
                    Case GetType(Long)
                        propInfo.SetValue(Me, CLng(dataReader(propInfo.Name)))
                    Case GetType(String)
                        propInfo.SetValue(Me, CStr(dataReader(propInfo.Name)))
                End Select
            Next

            status = True
        Else
            status = False
        End If

        dataReader.Close()
        _connection.Close()

        Return status
    End Function

    Public Function SaveData() As Boolean
        Dim status As Boolean = False

        _connection.Open()
        _command = _connection.CreateCommand()
        _command.CommandText = GetSaveQueryText()
        If _command.ExecuteNonQuery() = 1 Then
            status = True
        Else
            status = False
        End If
        _connection.Close()

        Return status
    End Function

    Private Function GetFillQueryText() As String
        Dim queryText As String
        Dim fieldsText As String = ""

        queryText = "SELECT "

        For Each propInfo As PropertyInfo In GetType(t).GetProperties
            fieldsText &= IIf(fieldsText <> "", ", ", "")
            fieldsText &= propInfo.Name
        Next

        queryText &= fieldsText & " FROM " & GetType(t).Name & " WHERE Id = '" & _id & "'"

        Return queryText
    End Function

    Private Function GetSaveQueryText() As String
        'UPDATE Child SET FirstName = 'Boom', LastName = 'Bam' WHERE Id = 'test';
        'INSERT OR IGNORE INTO Child (Id, FirstName, LastName) VALUES ('test', 'Loom', 'Valm');

        Dim queryText As String
        Dim fieldsText As String = ""

        queryText = "UPDATE " & GetType(t).Name & " SET "

        For Each propInfo As PropertyInfo In GetType(t).GetProperties
            fieldsText &= IIf(fieldsText <> "", ", ", "")
            fieldsText &= propInfo.Name & " = "

            Select Case propInfo.PropertyType
                Case GetType(Integer)
                    fieldsText &= propInfo.GetValue(Me).ToString
                Case GetType(Long)
                    fieldsText &= propInfo.GetValue(Me).ToString
                Case GetType(String)
                    fieldsText &= "'" & propInfo.GetValue(Me).ToString & "'"
            End Select
        Next

        queryText &= fieldsText
        queryText &= " WHERE Id = '" & Me.Id & "';"

        'INSERT OR IGNORE
        queryText &= "INSERT OR IGNORE INTO " & GetType(t).Name & " ("

        fieldsText = ""
        For Each propInfo As PropertyInfo In GetType(t).GetProperties
            fieldsText &= IIf(fieldsText <> "", ", ", "")
            fieldsText &= propInfo.Name
        Next

        queryText &= fieldsText & ") VALUES ("

        fieldsText = ""
        For Each propInfo As PropertyInfo In GetType(t).GetProperties
            fieldsText &= IIf(fieldsText <> "", ", ", "")
            Select Case propInfo.PropertyType
                Case GetType(Integer)
                    fieldsText &= propInfo.GetValue(Me).ToString
                Case GetType(Long)
                    fieldsText &= propInfo.GetValue(Me).ToString
                Case GetType(String)
                    fieldsText &= "'" & propInfo.GetValue(Me).ToString & "'"
            End Select
        Next

        queryText &= fieldsText & ");"

        Return queryText
    End Function

End Class
