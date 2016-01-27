Imports Persistence.Library
Public Class Child
    Inherits ObjectBasePersistent(Of Child)

    Private _firtName As String
    Public Property FirstName() As String
        Get
            Return _firtName
        End Get
        Set(ByVal value As String)
            _firtName = value
        End Set
    End Property

    Private _lastName As String
    Public Property LastName() As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            _lastName = value
        End Set
    End Property

    Private _age As Integer
    Public Property Age() As Integer
        Get
            Return _age
        End Get
        Set(ByVal value As Integer)
            _age = value
        End Set
    End Property


    Public Sub New(ByVal firstName As String, ByVal lastName As String)
        MyBase.New(firstName & lastName)

        _firtName = firstName
        _lastName = lastName
        _age = 0
    End Sub
End Class
