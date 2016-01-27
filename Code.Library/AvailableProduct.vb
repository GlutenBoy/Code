Public Class AvailableProduct
    Private _type As String
    Private _LoC As Long
    Private _maxPrice As Decimal
    Private _startBug As Integer
    Private _numberOfBugs As Integer

    Public Property Type() As String
        Get
            Return _type
        End Get
        Set(ByVal value As String)
            _type = value
        End Set
    End Property

    Public Property LoC() As Long
        Get
            Return _LoC
        End Get
        Set(ByVal value As Long)
            _LoC = value
        End Set
    End Property

    Public Property MaxPrice() As Decimal
        Get
            Return _maxPrice
        End Get
        Set(ByVal value As Decimal)
            _maxPrice = value
        End Set
    End Property

    Public Sub New(type As String, loc As Long, maxPrice As Decimal)
        _type = type
        _LoC = loc
        _maxPrice = maxPrice
    End Sub
End Class
