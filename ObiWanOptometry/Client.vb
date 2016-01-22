'------------------------------------------------------------
'-                   File Name: Client.vb                   -
'-                 Part of Project: Assign2                 -
'------------------------------------------------------------
'-                Written By: Elijah Wilson                 -
'-                  Written On: 01/22/2016                  -
'------------------------------------------------------------
'- File Purpose:                                            -
'-                                                          -
'- This file contains the Client class.                     -
'------------------------------------------------------------
Public Class Client
    Inherits ReceiptFormatter
    Implements ReceiptItem

    Public name As String
    Public hasEyeExam As Boolean = False
    Public hasGlasses As Boolean = False
    Public hasContacts As Boolean = False
    Public glasses As Glasses
    Public contacts As Contacts

    Private Const EYE_EXAM_STR As String = "Examination:"
    Private Const EYE_EXAM_COST As Decimal = 100.0

    Private Const CLIENT_NAME_FORMAT_STR As String = "Client: {0}"

    ' Overrides ReceiptFormatter verboseName
    Protected Overrides Property verboseName As String = "Client"

    Private Const RECEIPT_SUBTOTAL_STR As String = "Receipt Subtotal"
    Private Const SALES_TAX_STR As String = "Sales Tax"
    Private Const RECEIPT_TOTAL_STR As String = "Total"
    Private Const SALES_TAX_AMOUNT As Decimal = 0.06  ' 6% sales tax

    '------------------------------------------------------------
    '-                 Function Name: validate                  -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns true or false based on whether or  -
    '- not the client has valid data.                           -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Boolean - Whether or not the client object is valid      -
    '------------------------------------------------------------
    Public Function validate() As Boolean Implements ReceiptItem.validate
        Return validateGlasses() And validateContacts()
    End Function

    '------------------------------------------------------------
    '-              Function Name: validateGlasses              -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns  true or false based on whether or -
    '- not the glasses object of the client has valid data.     -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- isValid - A boolean that will be returned, holding the   -
    '-           value of the glasses object being valid or     -
    '-           not.                                           -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Boolean - Whether or not the glasses object of a client  -
    '-           is valid                                       -
    '------------------------------------------------------------
    Private Function validateGlasses() As Boolean
        Dim isValid As Boolean = False

        If hasGlasses Then
            isValid = Me.glasses.validate()
        Else
            isValid = True
        End If

        Return isValid
    End Function

    '------------------------------------------------------------
    '-             Function Name: validateContacts              -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns  true or false based on whether or -
    '- not the contacts object of the client has valid data.    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- isValid - A boolean that will be returned, holding the   -
    '-           value of the contacts being valid or not.      -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Boolean - Whether or not the contacts object of a client -
    '-           is valid                                       -
    '------------------------------------------------------------
    Private Function validateContacts() As Boolean
        Dim isValid As Boolean = False

        If hasContacts Then
            isValid = Me.contacts.validate()
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
    '- This returns the subtotal based on what services are     -
    '- selected.                                                -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- subtotal - The accruing subtotal to be returned          -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Decimal - The subtotal for the client object             -
    '------------------------------------------------------------
    Private Function getSubtotal() As Decimal Implements ReceiptItem.getSubtotal
        Dim subtotal As Decimal = 0.0

        If hasEyeExam Then
            subtotal += EYE_EXAM_COST
        End If

        If hasGlasses Then
            subtotal += Me.glasses.getSubtotal()
        End If

        If hasContacts Then
            subtotal += Me.contacts.getSubtotal()
        End If

        Return subtotal
    End Function

    '------------------------------------------------------------
    '-          Function Name: getSubtotalReceiptLine           -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This returns the subtotal line for the receipt.          -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - The subtotal receipt line for the client object -
    '------------------------------------------------------------
    Private Function getSubtotalReceiptLine() As String
        Return getSubItemLineFormatted(RECEIPT_SUBTOTAL_STR, getSubtotal())
    End Function

    '------------------------------------------------------------
    '-             Function Name: getSalesTaxAmount             -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This returns how much sales tax should be added to the   -
    '- total based on the subtotal and the sales tax amount.    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Decimal - How much sales tax should be added to the      -
    '-           total                                          -
    '------------------------------------------------------------
    Private Function getSalesTaxAmount() As Decimal
        Return getSubtotal() * SALES_TAX_AMOUNT
    End Function

    '------------------------------------------------------------
    '-          Function Name: getSalesTaxReceiptLine           -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This returns the properly formatted line for sales tax   -
    '- to be used on the receipt.                               -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - Sales tax line for the receipt                  -
    '------------------------------------------------------------
    Private Function getSalesTaxReceiptLine() As String
        Return getSubItemLineFormatted(SALES_TAX_STR, getSalesTaxAmount())
    End Function

    '------------------------------------------------------------
    '-           Function Name: getReceiptTotalAmount           -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This returns the subtotal plus sales tax, which is the   -
    '- total amount to be used on the receipt.                  -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Decimal - Subtotal + Sales tax                           -
    '------------------------------------------------------------
    Private Function getReceiptTotalAmount() As Decimal
        Return getSubtotal() + getSalesTaxAmount()
    End Function

    '------------------------------------------------------------
    '-            Function Name: getReceiptTotalLine            -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This returns the total cost line for the receipt.        -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - Total cost line for receipt                     -
    '------------------------------------------------------------
    Private Function getReceiptTotalLine() As String
        Return getSubItemLineFormatted(RECEIPT_TOTAL_STR, getReceiptTotalAmount())
    End Function

    '------------------------------------------------------------
    '-             Function Name: getReceiptOutput              -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This returns the subtotal based on what services are     -
    '- selected.                                                -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- returnString - The string that is used to add data based -
    '-                on whether or not certain services are    -
    '-                selected. In the end, it is returned.     -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - The string to be used when displaying the       -
    '-          receipt                                         -
    '------------------------------------------------------------
    Public Function getReceiptOutput() As String Implements ReceiptItem.getReceiptOutput
        Dim returnString As String = getReceiptHeader(frmClientDetailInput.BASE_TITLE) & String.Format(CLIENT_NAME_FORMAT_STR, name) & vbCrLf & vbCrLf

        If hasEyeExam Then
            returnString &= getMainItemWithCostLineFormatted(EYE_EXAM_STR, EYE_EXAM_COST) & vbCrLf & vbCrLf
        End If

        If hasGlasses Then
            returnString &= Me.glasses.getReceiptOutput() & vbCrLf
        End If

        If hasContacts Then
            returnString &= Me.contacts.getReceiptOutput() & vbCrLf
        End If

        returnString &= getSubtotalReceiptLine() & vbCrLf
        returnString &= getSalesTaxReceiptLine() & vbCrLf
        returnString &= getDividerLine() & vbCrLf
        returnString &= getReceiptTotalLine()

        Return returnString
    End Function
End Class
