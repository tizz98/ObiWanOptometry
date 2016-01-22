Public Class Glasses
    Inherits ReceiptFormatter
    Implements ReceiptItem

    Public lensMaterial As lensMaterialType
    Public hasAntiScratch As Boolean
    Public hasTintedLens As Boolean
    Public hasCompHdLens As Boolean
    Public hasRolledLensEdges As Boolean
    Public hasPhotosensitiveLens As Boolean
    Public hasProgressiveLens As Boolean

    Private Const LENS_MATERIAL_FORMAT_STR = "{0} Lens/Frame"

    Private Const PLASTIC_LENS_STR As String = "Plastic"
    Private Const PLASTIC_LENS_COST As Decimal = 175.0

    Private Const GLASS_LENS_STR As String = "Glass"
    Private Const GLASS_LENS_COST As Decimal = 225.0

    Private Const ANTI_SCRATCH_STR As String = "Anti-Scratch Coating"
    Private Const ANTI_SCRATCH_COST As Decimal = 50.0

    Private Const TINTED_STR As String = "Tinted Lenses"
    Private Const TINTED_COST As Decimal = 50.0

    Private Const COMP_STRAIN_HD_STR As String = "Computer Strain HD Lens"
    Private Const COMP_STRAIN_HD_COST As Decimal = 50.0

    Private Const ROLLED_LENS_EDGE_STR As String = "Rolled Lens Edge"
    Private Const ROLLED_LENS_EDGE_COST As Decimal = 50.0

    Private Const PHOTOSENSITIVE_LENS_STR As String = "Photosensitive Lens"
    Private Const PHOTOSENSITIVE_LENS_COST As Decimal = 50.0

    Private Const PROGRESSIVE_LENS_STR As String = "Progressive Lens"
    Private Const PROGRESSIVE_LEN_COST As Decimal = 50.0

    ' Overrides ReceiptFormatter verboseName
    Protected Overrides Property verboseName As String = "Glasses"

    Public Function validate() As Boolean Implements ReceiptItem.validate
        Return validateLensMaterial()
    End Function

    Private Function validateLensMaterial() As Boolean
        Return lensMaterialType.IsDefined(GetType(lensMaterialType), Me.lensMaterial)
    End Function

    Private Function getSubtotal() As Decimal Implements ReceiptItem.getSubtotal
        Dim subtotal As Decimal = getLensCost()

        If hasAntiScratch Then
            subtotal += ANTI_SCRATCH_COST
        End If

        If hasTintedLens Then
            subtotal += TINTED_COST
        End If

        If hasCompHdLens Then
            subtotal += COMP_STRAIN_HD_COST
        End If

        If hasRolledLensEdges Then
            subtotal += ROLLED_LENS_EDGE_COST
        End If

        If hasPhotosensitiveLens Then
            subtotal += PHOTOSENSITIVE_LENS_COST
        End If

        If hasProgressiveLens Then
            subtotal += PHOTOSENSITIVE_LENS_COST
        End If

        Return subtotal
    End Function

    Public Function getReceiptOutput() As String Implements ReceiptItem.getReceiptOutput
        Dim returnString As String = Me.getOrderHeaderLine() & vbCrLf & getLensMaterialReceiptLine() & vbCrLf

        If hasAntiScratch Then
            returnString &= getAntiScratchReceiptLine() & vbCrLf
        End If

        If hasTintedLens Then
            returnString &= getTintedLensReceiptLine() & vbCrLf
        End If

        If hasCompHdLens Then
            returnString &= getCompHdLensReceiptLine() & vbCrLf
        End If

        If hasRolledLensEdges Then
            returnString &= getRolledLensReceiptLine() & vbCrLf
        End If

        If hasPhotosensitiveLens Then
            returnString &= getPhotosensitiveLensReceiptLine() & vbCrLf
        End If

        If hasProgressiveLens Then
            returnString &= getProgressiveLensReceiptLine() & vbCrLf
        End If

        returnString &= getDividerLine() & vbCrLf & getSubtotalLine(getSubtotal()) & vbCrLf

        Return returnString
    End Function

    Private Function getLensMaterialReceiptLine() As String
        Return getSubItemLineFormatted(getReadableLensType(), getLensCost())
    End Function

    Private Function getAntiScratchReceiptLine() As String
        Return getSubItemLineFormatted(ANTI_SCRATCH_STR, ANTI_SCRATCH_COST)
    End Function

    Private Function getTintedLensReceiptLine() As String
        Return getSubItemLineFormatted(TINTED_STR, TINTED_COST)
    End Function

    Private Function getCompHdLensReceiptLine() As String
        Return getSubItemLineFormatted(COMP_STRAIN_HD_STR, COMP_STRAIN_HD_COST)
    End Function

    Private Function getRolledLensReceiptLine() As String
        Return getSubItemLineFormatted(ROLLED_LENS_EDGE_STR, ROLLED_LENS_EDGE_COST)
    End Function

    Private Function getPhotosensitiveLensReceiptLine() As String
        Return getSubItemLineFormatted(PHOTOSENSITIVE_LENS_STR, PHOTOSENSITIVE_LENS_COST)
    End Function

    Private Function getProgressiveLensReceiptLine() As String
        Return getSubItemLineFormatted(PROGRESSIVE_LENS_STR, PROGRESSIVE_LEN_COST)
    End Function

    Public Enum lensMaterialType
        Plastic
        Glass
    End Enum

    Private Function getReadableLensType() As String
        Select Case Me.lensMaterial
            Case lensMaterialType.Plastic
                Return String.Format(LENS_MATERIAL_FORMAT_STR, PLASTIC_LENS_STR)
            Case lensMaterialType.Glass
                Return String.Format(LENS_MATERIAL_FORMAT_STR, GLASS_LENS_STR)
            Case Else
                Return Nothing
        End Select
    End Function

    Private Function getLensCost() As Decimal
        Select Case Me.lensMaterial
            Case lensMaterialType.Plastic
                Return PLASTIC_LENS_COST
            Case lensMaterialType.Glass
                Return GLASS_LENS_COST
            Case Else
                Return 0.0
        End Select
    End Function
End Class
