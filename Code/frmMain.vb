Imports Code.Library
Public Class frmMain
    Private _persistence As New Persistence
    Private WithEvents _core As New Core("1")

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim test As List(Of Dictionary(Of String, String))

        'test = _persistence.GetData("SELECT * FROM Core")

        'For Each row As Dictionary(Of String, String) In test
        '    Me.TextBox1.Text &= "-- ROW" & vbNewLine
        '    For Each fieldValue As String In row.Values
        '        Me.TextBox1.Text &= fieldValue & vbNewLine
        '    Next
        'Next

        Me.LoadAvailableProductList()
        Me.lvwCreatedProduct.Items.Clear()
    End Sub

    Private Sub LoadAvailableProductList()
        Dim newListViewItem As ListViewItem

        Me.lvwAvailableProducts.Items.Clear()

        For Each aProd As AvailableProduct In _core.AvailableProducts
            newListViewItem = New ListViewItem(aProd.Type)
            newListViewItem.Tag = aProd.Type

            newListViewItem.SubItems.Add(aProd.LoC)
            newListViewItem.SubItems.Add(aProd.MaxPrice.ToString("C2"))

            Me.lvwAvailableProducts.Items.Add(newListViewItem)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCodeLine.Click
        _core.CodeLoC()
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        _core.FillData()
        MsgBox(_core.LinesOfCode)
    End Sub

    Private Sub _core_LoCChanged() Handles _core.LoCChanged
        Me.lblLoCNumber.Text = _core.LinesOfCode.ToString
    End Sub

    Private Sub btnCreateProduct_Click(sender As Object, e As EventArgs) Handles btnCreateProduct.Click
        Dim aProd As AvailableProduct

        If Me.lvwAvailableProducts.SelectedItems.Count = 1 Then
            aProd = _core.GetAvailableProduct(Me.lvwAvailableProducts.SelectedItems(0).Tag)

            If aProd IsNot Nothing Then
                _core.CreateProduct(aProd)
            End If
        End If
    End Sub

    Private Sub _core_MoneyChanged() Handles _core.MoneyChanged
        Me.lblMoneyAmount.Text = _core.Money.ToString("C2")
    End Sub

    Private Sub _core_ProductCreated(productCreated As CreatedProduct) Handles _core.ProductCreated
        Dim newListViewItem As ListViewItem

        newListViewItem = New ListViewItem(productCreated.Type)
        newListViewItem.Tag = productCreated

        newListViewItem.SubItems.Add(productCreated.NumberOfBugs)
        newListViewItem.SubItems.Add(productCreated.Price.ToString("C2"))

        Me.lvwCreatedProduct.Items.Add(newListViewItem)
    End Sub

    Private Sub btnSellProduct_Click(sender As Object, e As EventArgs) Handles btnSellProduct.Click
        Dim productToSell As CreatedProduct

        If Me.lvwCreatedProduct.SelectedItems.Count = 1 Then
            productToSell = CType(Me.lvwCreatedProduct.SelectedItems(0).Tag, CreatedProduct)
            If productToSell IsNot Nothing Then
                If _core.SellProduct(productToSell) Then
                    Me.lvwCreatedProduct.Items.Remove(Me.lvwCreatedProduct.SelectedItems(0))
                End If
            End If
        End If
    End Sub
End Class
