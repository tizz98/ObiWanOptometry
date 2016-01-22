Imports ObiWanOptometry

Public Class Client
    Implements ReceiptItem

    Public name As String
    Public hasEyeExam As Boolean
    Public glasses As New Glasses
    Public contacts As New Contacts

    Private Function validate() As Boolean Implements ReceiptItem.validate
        Throw New NotImplementedException()
    End Function

    Private Function getSubtotal() As Decimal Implements ReceiptItem.getSubtotal
        Throw New NotImplementedException()
    End Function

    Public Function getReceiptOutput() As String Implements ReceiptItem.getReceiptOutput
        Throw New NotImplementedException()
    End Function
End Class
