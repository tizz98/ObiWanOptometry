Public Interface ReceiptItem
    Function validate() As Boolean
    Function getSubtotal() As Decimal
    Function getReceiptOutput() As String
End Interface