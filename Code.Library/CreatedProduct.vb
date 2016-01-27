Public Class CreatedProduct
    Private _price As Decimal
    Private _type As String

    Public Property Type() As String
        Get
            Return _type
        End Get
        Set(ByVal value As String)
            _type = value
        End Set
    End Property

    Public Property Price() As Decimal
        Get
            Return _price
        End Get
        Set(ByVal value As Decimal)
            _price = value
        End Set
    End Property

    Private _numberOfBugs As Integer
    Public Property NumberOfBugs() As Integer
        Get
            Return _numberOfBugs
        End Get
        Set(ByVal value As Integer)
            _numberOfBugs = value
        End Set
    End Property

    Public Sub New(ByVal type As String, numberOfBugs As Integer, ByVal price As Decimal)
        _type = type
        _numberOfBugs = numberOfBugs
        _price = Price
    End Sub
End Class
