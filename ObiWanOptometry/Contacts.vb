Imports ObiWanOptometry

Public Class Contacts
    Implements ReceiptItem

    Public wear As contactWearType
    Public lensColor As contactLensColorType
    Public hasReplacementInsurance As Boolean
    Public hasCleaningSupplies As Boolean
    Public hasColoredLens As Boolean

    Private Const DAILY_WEAR_STR As String = "Daily Wear"
    Private Const DAILY_WEAR_COST As Decimal = 100.0

    Private Const EXT_WEAR_STR As String = "Extended Wear"
    Private Const EXT_WEAR_COST As Decimal = 150.0

    Private Const GAS_PERM_STR As String = "Gas Permeable"
    Private Const GAS_PERM_COST As Decimal = 200.0

    Private Const DARTHMAUL_RED_STR As String = "Darth Maul Red"
    Private Const C3P0_GOLD_STR As String = "C3P0 Gold"
    Private Const R2D2_BLUE_STR As String = "R2D2 Blue"
    Private Const YODA_GREEN_STR As String = "Yoda Green"

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
        Throw New NotImplementedException()
    End Function

    Public Function getSubtotal() As Decimal Implements ReceiptItem.getSubtotal
        Throw New NotImplementedException()
    End Function

    Public Function getReceiptOutput() As String Implements ReceiptItem.getReceiptOutput
        Throw New NotImplementedException()
    End Function

    Public Function isDailyWear() As Boolean
        Return Me.wear = contactWearType.DailyWear
    End Function

    Public Function isExtendedWear() As Boolean
        Return Me.wear = contactWearType.ExtendedWear
    End Function

    Public Function isGasPermeableWear() As Boolean
        Return Me.wear = contactWearType.GasPermeable
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
End Class
