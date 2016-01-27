Public Class Core
    Inherits ObjectBasePersistent(Of Core)

    Private _linesOfCode As Long
    Private _money As Decimal
    Private _minBugPercentage As Integer
    Private _maxBugPercentage As Integer
    Private _listProductAvailable As New List(Of AvailableProduct)
    Private _listProductMade As New List(Of CreatedProduct)

    Public Event LoCChanged()
    Public Event MoneyChanged()
    Public Event ProductCreated(productCreated As CreatedProduct)

    Public Property LinesOfCode() As Long
        Get
            Return _linesOfCode
        End Get
        Set(ByVal value As Long)
            _linesOfCode = value
        End Set
    End Property

    Public Property Money() As Decimal
        Get
            Return _money
        End Get
        Set(ByVal value As Decimal)
            _money = value
        End Set
    End Property


    Public Property MinBugPercentage() As Integer
        Get
            Return _minBugPercentage
        End Get
        Set(ByVal value As Integer)
            _minBugPercentage = value
        End Set
    End Property

    Public Property MaxBugPercentage() As Integer
        Get
            Return _maxBugPercentage
        End Get
        Set(ByVal value As Integer)
            _maxBugPercentage = value
        End Set
    End Property

    Public ReadOnly Property AvailableProducts() As List(Of AvailableProduct)
        Get
            Return _listProductAvailable
        End Get
    End Property

    Public ReadOnly Property MadeProducts() As List(Of CreatedProduct)
        Get
            Return _listProductMade
        End Get
    End Property

    Public Sub New(ByVal id As String)
        MyBase.New(id)

        Me.LoadListProductsAvailable()
    End Sub
    Private Sub LoadListProductsAvailable()
        _listProductAvailable.Add(New AvailableProduct("Batch File", 50, 5))
        _listProductAvailable.Add(New AvailableProduct("Bash Script", 100, 12))
        _listProductAvailable.Add(New AvailableProduct("Office Automation Script", 200, 30))
        _listProductAvailable.Add(New AvailableProduct("Windows Program", 500, 100))
    End Sub

    Public Function GetAvailableProduct(ByVal type As String) As AvailableProduct
        For Each ap As AvailableProduct In _listProductAvailable
            If ap.Type = type Then
                Return ap
            End If
        Next

        Return Nothing
    End Function


    Sub CodeLoC()
        _LinesOfCode += 1
        RaiseEvent LoCChanged()
    End Sub

    Public Sub CreateProduct(ByRef productAvailable As AvailableProduct)
        Dim bugPercentage As Decimal
        Dim pPrice As Decimal
        Dim numOfBugs As Integer
        Dim newCreatedProduct As CreatedProduct

        If _LinesOfCode >= productAvailable.LoC Then
            bugPercentage = Me.BugPercentage
            pPrice = productAvailable.MaxPrice - (productAvailable.MaxPrice * bugPercentage)
            numOfBugs = productAvailable.LoC * bugPercentage
            newCreatedProduct = New CreatedProduct(productAvailable.Type, numOfBugs, pPrice)
            _listProductMade.Add(newCreatedProduct)
            _LinesOfCode = _LinesOfCode - productAvailable.LoC

            RaiseEvent LoCChanged()
            RaiseEvent ProductCreated(newCreatedProduct)
        End If
    End Sub

    Public Function SellProduct(ByRef productToSell As CreatedProduct) As Boolean
        Dim sold As Boolean = False

        sold = _listProductMade.Remove(productToSell)

        If sold Then
            _money += productToSell.Price
            RaiseEvent MoneyChanged()
        End If

        Return sold
    End Function

    Private Function BugPercentage() As Decimal
        Return New Random().Next(0, 100) / 100
    End Function



End Class
