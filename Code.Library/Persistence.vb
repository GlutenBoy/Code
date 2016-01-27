Imports System.Data

Public Class Persistence
    Private _connection As SQLite.SQLiteConnection
    Private _command As SQLite.SQLiteCommand
    Private _db As SQLite.SQLiteDataAdapter

    Public Sub New()
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


End Class
