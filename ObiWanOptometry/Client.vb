Imports ObiWanOptometry

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

    Public Function validate() As Boolean Implements ReceiptItem.validate
        Return validateGlasses() And validateContacts()
    End Function

    Private Function validateGlasses() As Boolean
        Dim isValid As Boolean = False

        If hasGlasses Then
            isValid = Me.glasses.validate()
        Else
            isValid = True
        End If

        Return isValid
    End Function

    Private Function validateContacts() As Boolean
        Dim isValid As Boolean = False

        If hasContacts Then
            isValid = Me.contacts.validate()
        Else
            isValid = True
        End If

        Return isValid
    End Function

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

    Private Function getSubtotalReceiptLine() As String
        Return getSubItemLineFormatted(RECEIPT_SUBTOTAL_STR, getSubtotal())
    End Function

    Private Function getSalesTaxAmount() As Decimal
        Return getSubtotal() * SALES_TAX_AMOUNT
    End Function

    Private Function getSalesTaxReceiptLine() As String
        Return getSubItemLineFormatted(SALES_TAX_STR, getSalesTaxAmount())
    End Function

    Private Function getReceiptTotalAmount() As Decimal
        Return getSubtotal() + getSalesTaxAmount()
    End Function

    Private Function getReceiptTotalLine() As String
        Return getSubItemLineFormatted(RECEIPT_TOTAL_STR, getReceiptTotalAmount())
    End Function

    Public Function getReceiptOutput() As String Implements ReceiptItem.getReceiptOutput
        Dim returnString As String = String.Format(CLIENT_NAME_FORMAT_STR, name) & vbCrLf & vbCrLf

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
