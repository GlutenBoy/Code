<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Test Product", "99999", "1,000 $"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Test Product", "99999", "1,000 $"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Test Product", "99999", "1,000 $"}, -1)
        Me.btnCodeLine = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.lblLoC = New System.Windows.Forms.Label()
        Me.lblLoCNumber = New System.Windows.Forms.Label()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.lblMoneyAmount = New System.Windows.Forms.Label()
        Me.lvwAvailableProducts = New System.Windows.Forms.ListView()
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLoc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMaxPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblProductsAvailable = New System.Windows.Forms.Label()
        Me.btnCreateProduct = New System.Windows.Forms.Button()
        Me.lvwCreatedProduct = New System.Windows.Forms.ListView()
        Me.colTypeMade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBugs = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSellProduct = New System.Windows.Forms.Button()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.btnHire = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.colJobType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSalary = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colProductType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnCodeLine
        '
        Me.btnCodeLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCodeLine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCodeLine.Location = New System.Drawing.Point(12, 12)
        Me.btnCodeLine.Name = "btnCodeLine"
        Me.btnCodeLine.Size = New System.Drawing.Size(119, 39)
        Me.btnCodeLine.TabIndex = 0
        Me.btnCodeLine.Text = "Code 1 Line"
        Me.btnCodeLine.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnTest.Location = New System.Drawing.Point(27, 446)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(119, 39)
        Me.btnTest.TabIndex = 2
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'lblLoC
        '
        Me.lblLoC.AutoSize = True
        Me.lblLoC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblLoC.Location = New System.Drawing.Point(137, 34)
        Me.lblLoC.Name = "lblLoC"
        Me.lblLoC.Size = New System.Drawing.Size(41, 17)
        Me.lblLoC.TabIndex = 3
        Me.lblLoC.Text = "LoC:"
        '
        'lblLoCNumber
        '
        Me.lblLoCNumber.AutoSize = True
        Me.lblLoCNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoCNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblLoCNumber.Location = New System.Drawing.Point(202, 34)
        Me.lblLoCNumber.Name = "lblLoCNumber"
        Me.lblLoCNumber.Size = New System.Drawing.Size(17, 17)
        Me.lblLoCNumber.TabIndex = 4
        Me.lblLoCNumber.Text = "0"
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblMoney.Location = New System.Drawing.Point(137, 12)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(22, 17)
        Me.lblMoney.TabIndex = 5
        Me.lblMoney.Text = "$:"
        '
        'lblMoneyAmount
        '
        Me.lblMoneyAmount.AutoSize = True
        Me.lblMoneyAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoneyAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblMoneyAmount.Location = New System.Drawing.Point(202, 12)
        Me.lblMoneyAmount.Name = "lblMoneyAmount"
        Me.lblMoneyAmount.Size = New System.Drawing.Size(17, 17)
        Me.lblMoneyAmount.TabIndex = 6
        Me.lblMoneyAmount.Text = "0"
        '
        'lvwAvailableProducts
        '
        Me.lvwAvailableProducts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwAvailableProducts.BackColor = System.Drawing.Color.Black
        Me.lvwAvailableProducts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colName, Me.colLoc, Me.colMaxPrice})
        Me.lvwAvailableProducts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lvwAvailableProducts.FullRowSelect = True
        Me.lvwAvailableProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwAvailableProducts.HideSelection = False
        Me.lvwAvailableProducts.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lvwAvailableProducts.Location = New System.Drawing.Point(509, 29)
        Me.lvwAvailableProducts.MultiSelect = False
        Me.lvwAvailableProducts.Name = "lvwAvailableProducts"
        Me.lvwAvailableProducts.Size = New System.Drawing.Size(443, 97)
        Me.lvwAvailableProducts.TabIndex = 7
        Me.lvwAvailableProducts.UseCompatibleStateImageBehavior = False
        Me.lvwAvailableProducts.View = System.Windows.Forms.View.Details
        '
        'colName
        '
        Me.colName.Text = "Product Type"
        Me.colName.Width = 256
        '
        'colLoc
        '
        Me.colLoc.Text = "LoC"
        Me.colLoc.Width = 94
        '
        'colMaxPrice
        '
        Me.colMaxPrice.Text = "Max Price"
        Me.colMaxPrice.Width = 84
        '
        'lblProductsAvailable
        '
        Me.lblProductsAvailable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProductsAvailable.AutoSize = True
        Me.lblProductsAvailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductsAvailable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblProductsAvailable.Location = New System.Drawing.Point(506, 9)
        Me.lblProductsAvailable.Name = "lblProductsAvailable"
        Me.lblProductsAvailable.Size = New System.Drawing.Size(225, 17)
        Me.lblProductsAvailable.TabIndex = 8
        Me.lblProductsAvailable.Tag = ""
        Me.lblProductsAvailable.Text = "Product available to be coded"
        '
        'btnCreateProduct
        '
        Me.btnCreateProduct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCreateProduct.Location = New System.Drawing.Point(509, 132)
        Me.btnCreateProduct.Name = "btnCreateProduct"
        Me.btnCreateProduct.Size = New System.Drawing.Size(119, 39)
        Me.btnCreateProduct.TabIndex = 9
        Me.btnCreateProduct.Text = "Create Product"
        Me.btnCreateProduct.UseVisualStyleBackColor = True
        '
        'lvwCreatedProduct
        '
        Me.lvwCreatedProduct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwCreatedProduct.BackColor = System.Drawing.Color.Black
        Me.lvwCreatedProduct.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colTypeMade, Me.colBugs, Me.colPrice})
        Me.lvwCreatedProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lvwCreatedProduct.FullRowSelect = True
        Me.lvwCreatedProduct.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCreatedProduct.HideSelection = False
        Me.lvwCreatedProduct.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.lvwCreatedProduct.Location = New System.Drawing.Point(509, 177)
        Me.lvwCreatedProduct.MultiSelect = False
        Me.lvwCreatedProduct.Name = "lvwCreatedProduct"
        Me.lvwCreatedProduct.Size = New System.Drawing.Size(443, 159)
        Me.lvwCreatedProduct.TabIndex = 10
        Me.lvwCreatedProduct.UseCompatibleStateImageBehavior = False
        Me.lvwCreatedProduct.View = System.Windows.Forms.View.Details
        '
        'colTypeMade
        '
        Me.colTypeMade.Text = "Product Type"
        Me.colTypeMade.Width = 256
        '
        'colBugs
        '
        Me.colBugs.Text = "# of Bugs"
        Me.colBugs.Width = 94
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 84
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(137, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Bug %:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(202, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "0% to 100%"
        '
        'btnSellProduct
        '
        Me.btnSellProduct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSellProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSellProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSellProduct.Location = New System.Drawing.Point(509, 342)
        Me.btnSellProduct.Name = "btnSellProduct"
        Me.btnSellProduct.Size = New System.Drawing.Size(119, 39)
        Me.btnSellProduct.TabIndex = 13
        Me.btnSellProduct.Text = "Sell Product"
        Me.btnSellProduct.UseVisualStyleBackColor = True
        '
        'btnBuy
        '
        Me.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBuy.Location = New System.Drawing.Point(12, 59)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(119, 39)
        Me.btnBuy.TabIndex = 14
        Me.btnBuy.Text = "Buy Upgrade"
        Me.btnBuy.UseVisualStyleBackColor = True
        '
        'btnHire
        '
        Me.btnHire.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHire.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnHire.Location = New System.Drawing.Point(12, 132)
        Me.btnHire.Name = "btnHire"
        Me.btnHire.Size = New System.Drawing.Size(119, 39)
        Me.btnHire.TabIndex = 15
        Me.btnHire.Text = "Hire"
        Me.btnHire.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Black
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colJobType, Me.colSalary, Me.colProductType})
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem3})
        Me.ListView1.Location = New System.Drawing.Point(12, 177)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(491, 159)
        Me.ListView1.TabIndex = 16
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colJobType
        '
        Me.colJobType.Text = "Job Type"
        Me.colJobType.Width = 256
        '
        'colSalary
        '
        Me.colSalary.Text = "Salary"
        Me.colSalary.Width = 94
        '
        'colProductType
        '
        Me.colProductType.Text = "Product"
        Me.colProductType.Width = 84
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(964, 516)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnHire)
        Me.Controls.Add(Me.btnBuy)
        Me.Controls.Add(Me.btnSellProduct)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvwCreatedProduct)
        Me.Controls.Add(Me.btnCreateProduct)
        Me.Controls.Add(Me.lblProductsAvailable)
        Me.Controls.Add(Me.lvwAvailableProducts)
        Me.Controls.Add(Me.lblMoneyAmount)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.lblLoCNumber)
        Me.Controls.Add(Me.lblLoC)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.btnCodeLine)
        Me.Name = "frmMain"
        Me.Text = "Code"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCodeLine As System.Windows.Forms.Button
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents lblLoC As System.Windows.Forms.Label
    Friend WithEvents lblLoCNumber As System.Windows.Forms.Label
    Friend WithEvents lblMoney As System.Windows.Forms.Label
    Friend WithEvents lblMoneyAmount As System.Windows.Forms.Label
    Friend WithEvents lvwAvailableProducts As System.Windows.Forms.ListView
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colLoc As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMaxPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblProductsAvailable As System.Windows.Forms.Label
    Friend WithEvents btnCreateProduct As System.Windows.Forms.Button
    Friend WithEvents lvwCreatedProduct As System.Windows.Forms.ListView
    Friend WithEvents colTypeMade As System.Windows.Forms.ColumnHeader
    Friend WithEvents colBugs As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSellProduct As System.Windows.Forms.Button
    Friend WithEvents btnBuy As System.Windows.Forms.Button
    Friend WithEvents btnHire As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents colJobType As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSalary As System.Windows.Forms.ColumnHeader
    Friend WithEvents colProductType As System.Windows.Forms.ColumnHeader

End Class
