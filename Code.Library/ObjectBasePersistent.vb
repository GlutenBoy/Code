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

    'Users can call New() but this will generate a Guid as 
    Public Sub New()
        Me.New(New Guid().ToString)
    End Sub

    Public Sub New(ByVal id As String)
        _id = id
        _connection = New SQLite.SQLiteConnection("Data Source=Code.db;Version=3;New=False;Compress=True;")
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
        'Dim status As Boolean = False

        '_connection.Open()
        '_command = _connection.CreateCommand()
        '_command.CommandText = query
        '_command.ExecuteNonQuery()
        '_connection.Close()

        'Return status
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
End Class
