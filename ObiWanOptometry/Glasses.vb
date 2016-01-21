Imports ObiWanOptometry

Public Class Glasses
    Implements ReceiptItem

    Public lensMaterial As lensMaterialType
    Public hasAntiScratch As Boolean
    Public hasTintedLens As Boolean
    Public hasCompHdLens As Boolean
    Public hasRolledLensEdges As Boolean
    Public hasPhotosensitiveLens As Boolean
    Public hasProgressiveLens As Boolean

    Public Function isPlastic() As Boolean
        Return Me.lensMaterial = lensMaterialType.Plastic
    End Function

    Public Function isGlass() As Boolean
        Return Me.lensMaterial = lensMaterialType.Glass
    End Function

    Private Function validate() As Boolean Implements ReceiptItem.validate
        Throw New NotImplementedException()
    End Function

    Private Function getSubtotal() As Decimal Implements ReceiptItem.getSubtotal
        Throw New NotImplementedException()
    End Function

    Public Function getReceiptOutput() As String Implements ReceiptItem.getReceiptOutput
        Throw New NotImplementedException()
    End Function

    Public Enum lensMaterialType
        Plastic
        Glass
    End Enum
End Class
