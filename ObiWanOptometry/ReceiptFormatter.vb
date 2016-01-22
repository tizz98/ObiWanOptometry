Public Class ReceiptFormatter
    Protected Overridable Property verboseName As String
    Private TAB_LENGTH As Integer = 2
    Private SUBITEM_TAB_LENGTH As Integer = TAB_LENGTH * 2
    Public Const LINEITEM_LINE_LENGTH As Integer = 70
    Public HALF_LINEITEM_LINE_LENGTH As Integer = CInt(Math.Floor(LINEITEM_LINE_LENGTH / 2))
    Public HALF_LINEITEM_LINE_LENGTH_STR As String = CStr(HALF_LINEITEM_LINE_LENGTH)
    Private GENERIC_SUBITEM_FORMAT_STR As String = "{0,-" & HALF_LINEITEM_LINE_LENGTH_STR & "}{1," & HALF_LINEITEM_LINE_LENGTH_STR & ":C2}"

    Public Overridable Function getOrderHeaderLine() As String
        Return String.Format("{0}{1} Order --", getMainItemTabSpaces(), verboseName)
    End Function

    Protected Function getMainItemTabSpaces() As String
        Return Strings.StrDup(TAB_LENGTH, " ")
    End Function

    Protected Function getSubItemTabSpaces() As String
        Return Strings.StrDup(SUBITEM_TAB_LENGTH, " ")
    End Function

    Protected Function getSubItemLineFormatted(descriptionText As String, cost As Decimal) As String
        Return String.Format(GENERIC_SUBITEM_FORMAT_STR, getSubItemTabSpaces() & descriptionText, cost)
    End Function

    Protected Function getMainItemWithCostLineFormatted(descriptionText As String, cost As Decimal) As String
        Return String.Format(GENERIC_SUBITEM_FORMAT_STR, getMainItemTabSpaces() & descriptionText, cost)
    End Function

    Protected Function getSubtotalLine(subtotal As Decimal) As String
        Return getSubItemLineFormatted(String.Format("{0} {1}", verboseName, "Subtotal"), subtotal)
    End Function

    Protected Function getDividerLine() As String
        Return getMainItemTabSpaces() & Strings.StrDup(LINEITEM_LINE_LENGTH, "-")
    End Function

    Public Function getReceiptHeader(title As String) As String
        Dim returnString As String = getDividerLine() & vbCrLf

        returnString &= String.Format("{0,-" & CStr(LINEITEM_LINE_LENGTH) & "}",
                                      String.Format("{0," & (Math.Ceiling((LINEITEM_LINE_LENGTH + title.Length) / 2)).ToString() & "}", title)) & vbCrLf
        returnString &= getDividerLine() & vbCrLf & vbCrLf

        Return returnString
    End Function
End Class
