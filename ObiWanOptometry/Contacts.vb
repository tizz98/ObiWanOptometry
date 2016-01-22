'------------------------------------------------------------
'-                  File Name: Contacts.vb                  -
'-                 Part of Project: Assign2                 -
'------------------------------------------------------------
'-                Written By: Elijah Wilson                 -
'-                  Written On: 01/22/2016                  -
'------------------------------------------------------------
'- File Purpose:                                            -
'-                                                          -
'- This file contains the Client class.                     -
'------------------------------------------------------------
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

    '------------------------------------------------------------
    '-                 Function Name: validate                  -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns whether or not the contacts object -
    '- is valid.                                                -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Boolean - Whether or not the contacts object is valid.   -
    '------------------------------------------------------------
    Public Function validate() As Boolean Implements ReceiptItem.validate
        Return validateWear() And validateLensColor()
    End Function

    '------------------------------------------------------------
    '-               Function Name: validateWear                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns whether or not the selected wear   -
    '- choice is valid.                                         -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- isValid - Holds whether or not the wear choice is valid  -
    '-           and is eventually returned.                    -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Boolean - Whether or not the selected wear choice is     -
    '-           valid                                          -
    '------------------------------------------------------------
    Private Function validateWear() As Boolean
        Dim isValid As Boolean = contactWearType.IsDefined(GetType(contactWearType), Me.wear)

        If Not isValid Then
            MessageBox.Show("Please choose a valid contact wear.")
        End If

        Return isValid
    End Function

    '------------------------------------------------------------
    '-             Function Name: validateLensColor             -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns whether or not the selected lens   -
    '- color choice is valid.                                   -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- isValid - Holds whether or not the lens color choice is  -
    '-           valid and is eventually returned               -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Boolean - Whether or not the selected lens color choice  -
    '-           is valid                                       -
    '------------------------------------------------------------
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

    '------------------------------------------------------------
    '-                Function Name: getSubtotal                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns the subtotal of the contacts based -
    '- on what options are selected.                            -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- subtotal - Accruing subtotal based on which options are  -
    '-            selected for the contacts                     -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Decimal - Subtotal of the contacts with the options      -
    '-           selected                                       -
    '------------------------------------------------------------
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

    '------------------------------------------------------------
    '-             Function Name: getReceiptOutput              -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns a string that will be used and     -
    '- displayed on the receipt for contacts.                   -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- returnString - The string to be returned based on what   -
    '-                options for the contacts are selected     -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - What will be used and displayed on the receipt  -
    '------------------------------------------------------------
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

    '------------------------------------------------------------
    '-            Function Name: getWearReceiptLine             -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns a sub item line formatted based on -
    '- the wear selected and the cost of the wear.              -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - Contact wear information to be used on the      -
    '-          receipt                                         -
    '------------------------------------------------------------
    Private Function getWearReceiptLine() As String
        Return getSubItemLineFormatted(getReadableWear(), getWearCost())
    End Function

    '------------------------------------------------------------
    '-         Function Name: getColoredLensReceiptLine         -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns a sub item line formatted based on -
    '- the lens color selected and the cost of the lens color.  -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - Contact lens color information to be used on    -
    '-          the receipt                                     -
    '------------------------------------------------------------
    Private Function getColoredLensReceiptLine() As String
        Return getSubItemLineFormatted(String.Format("{0} ({1})", COLORED_LENS_STR, getReadableLensColor()), COLORED_LENS_COST)
    End Function

    '------------------------------------------------------------
    '-    Function Name: getReplacementInsuranceReceiptLine     -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns a sub item line formatted based on -
    '- the cost of replacement insurance.                       -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - Contact replacement insurance information to be -
    '-          used on the receipt                             -
    '------------------------------------------------------------
    Private Function getReplacementInsuranceReceiptLine() As String
        Return getSubItemLineFormatted(REPLACEMENT_INSURANCE_STR, REPLACEMENT_INSURANCE_COST)
    End Function

    '------------------------------------------------------------
    '-      Function Name: getCleaningSuppliesReceiptLine       -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns a sub item line formatted based on -
    '- the cost of cleaning supplies.                           -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - Contact cleaning supplies information to be     -
    '-          used on the receipt                             -
    '------------------------------------------------------------
    Private Function getCleaningSuppliesReceiptLine() As String
        Return getSubItemLineFormatted(CLEANING_SUPPLIES_STR, CLEANING_SUPPLIES_COST)
    End Function

    '------------------------------------------------------------
    '-           Function Name: getReadableLensColor            -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns a readable string based on the     -
    '- lens color selected.                                     -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - A readable string based on the lens color       -
    '------------------------------------------------------------
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

    '------------------------------------------------------------
    '-              Function Name: getReadableWear              -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns a readable string based on the     -
    '- wear selected.                                           -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - A readable string based on the wear type        -
    '------------------------------------------------------------
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

    '------------------------------------------------------------
    '-                Function Name: getWearCost                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns the cost of the wear based on      -
    '- which wear is selected                                   -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Decimal - The cost of the wear based on which wear is    -
    '-           selected                                       -
    '------------------------------------------------------------
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

    '------------------------------------------------------------
    '-        Function Name: getLensColorTypeFromString         -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns the contactLensType based on the   -
    '- string passed into the function.                         -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- lensColor - The lens color being queried                 -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- contactLensColorType - The contactLensColorType based on -
    '-                        the lensColor input               -
    '------------------------------------------------------------
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
