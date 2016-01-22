'------------------------------------------------------------
'-                File Name: ReceiptItem.vb                 -
'-                 Part of Project: Assign2                 -
'------------------------------------------------------------
'-                Written By: Elijah Wilson                 -
'-                  Written On: 01/22/2016                  -
'------------------------------------------------------------
'- File Purpose:                                            -
'-                                                          -
'- This file contains the interface for ReceiptItem.        -
'------------------------------------------------------------
Public Interface ReceiptItem
    '------------------------------------------------------------
    '-                 Function Name: validate                  -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns true or false depending on whether -
    '- the ReceiptItem is valid.                                -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Boolean - Whether or not the ReceiptItem is valid        -
    '------------------------------------------------------------
    Function validate() As Boolean

    '------------------------------------------------------------
    '-                Function Name: getSubtotal                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function calculates the subtotal of the             -
    '- ReceiptItem.                                             -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Decimal - Subtotal of the ReceiptItem.                   -
    '------------------------------------------------------------
    Function getSubtotal() As Decimal

    '------------------------------------------------------------
    '-             Function Name: getReceiptOutput              -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns the appropriate output to be used  -
    '- on a receipt.                                            -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - The output to be used on a receipt              -
    '------------------------------------------------------------
    Function getReceiptOutput() As String
End Interface