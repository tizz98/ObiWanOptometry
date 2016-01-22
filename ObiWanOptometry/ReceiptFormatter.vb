'------------------------------------------------------------
'-              File Name: ReceiptFormatter.vb              -
'-                 Part of Project: Assign2                 -
'------------------------------------------------------------
'-                Written By: Elijah Wilson                 -
'-                  Written On: 01/22/2016                  -
'------------------------------------------------------------
'- File Purpose:                                            -
'-                                                          -
'- This file contains the ReceiptFormatter class that       -
'- should be inherited from to allow calling of the various -
'- formatting functions that give proper formatting for the -
'- receipt.                                                 -
'------------------------------------------------------------
Public Class ReceiptFormatter
    Protected Overridable Property verboseName As String
    Private TAB_LENGTH As Integer = 2
    Private SUBITEM_TAB_LENGTH As Integer = TAB_LENGTH * 2
    Public Const LINEITEM_LINE_LENGTH As Integer = 70
    Public HALF_LINEITEM_LINE_LENGTH As Integer = CInt(Math.Floor(LINEITEM_LINE_LENGTH / 2))
    Public HALF_LINEITEM_LINE_LENGTH_STR As String = CStr(HALF_LINEITEM_LINE_LENGTH)
    Private GENERIC_SUBITEM_FORMAT_STR As String = "{0,-" & HALF_LINEITEM_LINE_LENGTH_STR & "}{1," & HALF_LINEITEM_LINE_LENGTH_STR & ":C2}"

    '------------------------------------------------------------
    '-            Function Name: getOrderHeaderLine             -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This returns the order headline with the appropriate tab -
    '- length and spacing.                                      -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - Order headline based on the verboseName         -
    '------------------------------------------------------------
    Public Overridable Function getOrderHeaderLine() As String
        Return String.Format("{0}{1} Order --", getMainItemTabSpaces(), verboseName)
    End Function

    '------------------------------------------------------------
    '-           Function Name: getMainItemTabSpaces            -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns the appropriate number of spaces   -
    '- for a main item to be indented.                          -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - the appropriate number of spaces for a main     -
    '-          item to be indented                             -
    '------------------------------------------------------------
    Protected Function getMainItemTabSpaces() As String
        Return Strings.StrDup(TAB_LENGTH, " ")
    End Function

    '------------------------------------------------------------
    '-            Function Name: getSubItemTabSpaces            -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns the appropriate number of spaces   -
    '- for a sub item to be indented.                           -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - the appropriate number of spaces for a sub item -
    '-          to be indented                                  -
    '------------------------------------------------------------
    Protected Function getSubItemTabSpaces() As String
        Return Strings.StrDup(SUBITEM_TAB_LENGTH, " ")
    End Function

    '------------------------------------------------------------
    '-          Function Name: getSubItemLineFormatted          -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function formats the generic sub item format string -
    '- with the appropriate number of sub item spaces, the      -
    '- description text and the cost of the item.               -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- descriptionText - Text that will be left aligned for     -
    '-                   this item                              -
    '- cost - Cost of the item that will be left aligned and    -
    '-        formatted as a currency                           -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - a sub item line that is indented appropriately  -
    '-          and formatted correctly                         -
    '------------------------------------------------------------
    Protected Function getSubItemLineFormatted(descriptionText As String, cost As Decimal) As String
        Return String.Format(GENERIC_SUBITEM_FORMAT_STR, getSubItemTabSpaces() & descriptionText, cost)
    End Function

    '------------------------------------------------------------
    '-     Function Name: getMainItemWithCostLineFormatted      -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function formats the generic sub item format string -
    '- with the appropriate number of main item spaces, the     -
    '- description text and the cost of the item.               -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- descriptionText - A description of the item              -
    '- cost - The cost of the item                              -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - a main item line with a cost associated to it   -
    '-          that is indented appropriately and formatted    -
    '-          correctly                                       -
    '------------------------------------------------------------
    Protected Function getMainItemWithCostLineFormatted(descriptionText As String, cost As Decimal) As String
        Return String.Format(GENERIC_SUBITEM_FORMAT_STR, getMainItemTabSpaces() & descriptionText, cost)
    End Function

    '------------------------------------------------------------
    '-              Function Name: getSubtotalLine              -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns a sub item line formatted with the -
    '- verboseName and subtotal as the description and the      -
    '- subtotal amount as the cost.                             -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- subtotal - The subtotal amount to be formatted           -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - Formatted subtotal line with verboseName        -
    '------------------------------------------------------------
    Protected Function getSubtotalLine(subtotal As Decimal) As String
        Return getSubItemLineFormatted(String.Format("{0} {1}", verboseName, "Subtotal"), subtotal)
    End Function

    '------------------------------------------------------------
    '-              Function Name: getDividerLine               -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns the dash (-) character repeated    -
    '- for the length of a line item to be used for dividing    -
    '- sections.                                                -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - A line of a the dash (-) character repeated to  -
    '-          be used for dividing sections                   -
    '------------------------------------------------------------
    Protected Function getDividerLine() As String
        Return getMainItemTabSpaces() & Strings.StrDup(LINEITEM_LINE_LENGTH, "-")
    End Function

    '------------------------------------------------------------
    '-             Function Name: getReceiptHeader              -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function centers a title in between two divider     -
    '- lines (one on top and one on bottom).                    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- title - The title to be centered between two divider     -
    '-         lines                                            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - the receipt header as the title centered        -
    '-          between two divider lines                       -
    '------------------------------------------------------------
    Public Function getReceiptHeader(title As String) As String
        Dim returnString As String = getDividerLine() & vbCrLf

        returnString &= String.Format("{0,-" & CStr(LINEITEM_LINE_LENGTH) & "}",
                                      String.Format("{0," & (Math.Ceiling((LINEITEM_LINE_LENGTH + title.Length) / 2)).ToString() & "}", title)) & vbCrLf
        returnString &= getDividerLine() & vbCrLf & vbCrLf

        Return returnString
    End Function
End Class
