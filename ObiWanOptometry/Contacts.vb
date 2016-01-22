Public Class Contacts
    Inherits ReceiptFormatter
    Implements ReceiptItem

    Public wear As contactWearType
    Public lensColor As contactLensColorType
    Public hasReplacementInsurance As Boolean = False
    Public hasCleaningSupplies As Boolean = False
    Public hasColoredLens As Boolean = False

    Private Const DAILY_WEAR_STR As String = "Daily Wear"
    Private Const DAILY_WEAR_COST As Decimal = 100.0

    Private Const EXT_WEAR_STR As String = "Extended Wear"
    Private Const EXT_WEAR_COST As Decimal = 150.0

    Private Const GAS_PERM_STR As String = "Gas Permeable"
    Private Const GAS_PERM_COST As Decimal = 200.0

    Private Const COLORED_LENS_STR As String = "Colored Lens"
    Private Const DARTHMAUL_RED_STR As String = "Darth Maul Red"
    Private Const C3P0_GOLD_STR As String = "C3P0 Gold"
    Private Const R2D2_BLUE_STR As String = "R2D2 Blue"
    Private Const YODA_GREEN_STR As String = "Yoda Green"
    Public Shared COLOR_LIST As New List(Of String)(New String() {DARTHMAUL_RED_STR, C3P0_GOLD_STR, R2D2_BLUE_STR, YODA_GREEN_STR})
    Private Const COLORED_LENS_COST As Decimal = 75.0

    Private Const REPLACEMENT_INSURANCE_STR As String = "Replacement Insurance"
    Private Const REPLACEMENT_INSURANCE_COST As Decimal = 75.0

    Private Const CLEANING_SUPPLIES_STR As String = "Cleaning Supplies for One Year"
    Private Const CLEANING_SUPPLIES_COST As Decimal = 75.0

    ' Overrides ReceiptFormatter verboseName
    Protected Overrides Property verboseName As String = "Contacts"

    Public Enum contactWearType
        DailyWear
        ExtendedWear
        GasPermeable
    End Enum

    Public Enum contactLensColorType
        DarthMaul_Red
        C3P0_Gold
        R2D2_Blue
        Yoda_Green
    End Enum

    Public Function validate() As Boolean Implements ReceiptItem.validate
        Return validateWear() And validateLensColor()
    End Function

    Private Function validateWear() As Boolean
        Dim isValid As Boolean = contactWearType.IsDefined(GetType(contactWearType), Me.wear)

        If Not isValid Then
            MessageBox.Show("Please choose a valid contact wear.")
        End If

        Return isValid
    End Function

    Private Function validateLensColor() As Boolean
        Dim isValid As Boolean = False

        If Me.hasColoredLens Then
            isValid = Not IsNothing(Me.lensColor) AndAlso contactLensColorType.IsDefined(GetType(contactLensColorType), Me.lensColor)

            If Not isValid Then
                MessageBox.Show("Please choose a valid contact lens color.")
            End If
        Else
            isValid = True
        End If

        Return isValid
    End Function

    Public Function getSubtotal() As Decimal Implements ReceiptItem.getSubtotal
        Dim subtotal As Decimal = 0.0

        subtotal += getWearCost()

        If Me.hasReplacementInsurance Then
            subtotal += REPLACEMENT_INSURANCE_COST
        End If

        If Me.hasCleaningSupplies Then
            subtotal += CLEANING_SUPPLIES_COST
        End If

        If contactLensColorType.IsDefined(GetType(contactLensColorType), Me.lensColor) Then
            subtotal += COLORED_LENS_COST
        End If

        Return subtotal
    End Function

    Public Function getReceiptOutput() As String Implements ReceiptItem.getReceiptOutput
        Dim returnString As String = Me.getOrderHeaderLine() & vbCrLf & getWearReceiptLine() & vbCrLf

        If Me.hasColoredLens Then
            returnString &= getColoredLensReceiptLine() & vbCrLf
        End If

        If Me.hasReplacementInsurance Then
            returnString &= getReplacementInsuranceReceiptLine() & vbCrLf
        End If

        If Me.hasCleaningSupplies Then
            returnString &= getCleaningSuppliesReceiptLine() & vbCrLf
        End If

        returnString &= getDividerLine() & vbCrLf & getSubtotalLine(getSubtotal()) & vbCrLf

        Return returnString
    End Function

    Private Function getWearReceiptLine() As String
        Return getSubItemLineFormatted(getReadableWear(), getWearCost())
    End Function

    Private Function getColoredLensReceiptLine() As String
        Return getSubItemLineFormatted(String.Format("{0} ({1})", COLORED_LENS_STR, getReadableLensColor()), COLORED_LENS_COST)
    End Function

    Private Function getReplacementInsuranceReceiptLine() As String
        Return getSubItemLineFormatted(REPLACEMENT_INSURANCE_STR, REPLACEMENT_INSURANCE_COST)
    End Function

    Private Function getCleaningSuppliesReceiptLine() As String
        Return getSubItemLineFormatted(CLEANING_SUPPLIES_STR, CLEANING_SUPPLIES_COST)
    End Function

    Public Function getReadableLensColor() As String
        Select Case Me.lensColor
            Case contactLensColorType.C3P0_Gold
                Return C3P0_GOLD_STR
            Case contactLensColorType.DarthMaul_Red
                Return DARTHMAUL_RED_STR
            Case contactLensColorType.R2D2_Blue
                Return R2D2_BLUE_STR
            Case contactLensColorType.Yoda_Green
                Return YODA_GREEN_STR
            Case Else
                Return Nothing
        End Select
    End Function

    Public Function getReadableWear() As String
        Select Case Me.wear
            Case contactWearType.DailyWear
                Return DAILY_WEAR_STR
            Case contactWearType.ExtendedWear
                Return EXT_WEAR_STR
            Case contactWearType.GasPermeable
                Return GAS_PERM_STR
            Case Else
                Return Nothing
        End Select
    End Function

    Public Function getWearCost() As Decimal
        Select Case Me.wear
            Case contactWearType.DailyWear
                Return DAILY_WEAR_COST
            Case contactWearType.ExtendedWear
                Return EXT_WEAR_COST
            Case contactWearType.GasPermeable
                Return GAS_PERM_COST
            Case Else
                Return 0.0
        End Select
    End Function

    Public Function getLensColorTypeFromString(lensColor As String) As contactLensColorType
        Select Case lensColor
            Case DARTHMAUL_RED_STR
                Return contactLensColorType.DarthMaul_Red
            Case R2D2_BLUE_STR
                Return contactLensColorType.R2D2_Blue
            Case C3P0_GOLD_STR
                Return contactLensColorType.C3P0_Gold
            Case YODA_GREEN_STR
                Return contactLensColorType.Yoda_Green
            Case Else
                Return Nothing
        End Select
    End Function
End Class
