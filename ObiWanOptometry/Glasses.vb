'------------------------------------------------------------
'-                  File Name: Glasses.vb                   -
'-                 Part of Project: Assign2                 -
'------------------------------------------------------------
'-                Written By: Elijah Wilson                 -
'-                  Written On: 01/22/2016                  -
'------------------------------------------------------------
'- File Purpose:                                            -
'-                                                          -
'- This file contains the Glasses class.                    -
'------------------------------------------------------------
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

    '------------------------------------------------------------
    '-                 Function Name: validate                  -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function validates the Glasses object and returns   -
    '- true or false depending on whether or not it is valid.   -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Boolean - Whether or not the glasses object is valid.    -
    '------------------------------------------------------------
    Public Function validate() As Boolean Implements ReceiptItem.validate
        Return validateLensMaterial()
    End Function

    '------------------------------------------------------------
    '-           Function Name: validateLensMaterial            -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function validates the lens material selected and   -
    '- returns true or false.                                   -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- isValid - Holds whether or not the selected lens         -
    '-           material is valid and is eventually returned   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Boolean - Whether or not the glasses lens material is    -
    '-           valid.                                         -
    '------------------------------------------------------------
    Private Function validateLensMaterial() As Boolean
        Dim isValid As Boolean = lensMaterialType.IsDefined(GetType(lensMaterialType), Me.lensMaterial)

        If Not isValid Then
            MessageBox.Show("Please choose a valid Lens/Frame option.")
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
    '- This function returns the subtotal based on the selected -
    '- options for glasses.                                     -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- subtotal - Accruing subtotal based on the options        -
    '-            selected and is eventually returned.          -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Decimal - The subtotal based on selected glasses         -
    '-           options.                                       -
    '------------------------------------------------------------
    Public Function getSubtotal() As Decimal Implements ReceiptItem.getSubtotal
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

    '------------------------------------------------------------
    '-             Function Name: getReceiptOutput              -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns output to be used on the receipt.  -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- returnString - This string is added to depending on what -
    '-                options are selected. It is eventually    -
    '-                returned.                                 -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - Output to be used on the receipt                -
    '------------------------------------------------------------
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

    '------------------------------------------------------------
    '-        Function Name: getLensMaterialReceiptLine         -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns output to be used on the receipt   -
    '- for lens material.                                       -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - Output to be used on the receipt for lens       -
    '-          material                                        -
    '------------------------------------------------------------
    Private Function getLensMaterialReceiptLine() As String
        Return getSubItemLineFormatted(getReadableLensType(), getLensCost())
    End Function

    '------------------------------------------------------------
    '-         Function Name: getAntiScratchReceiptLine         -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns output to be used on the receipt   -
    '- for anti scratch protection.                             -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - Output to be used on the receipt for anti       -
    '-          scratch protection                              -
    '------------------------------------------------------------
    Private Function getAntiScratchReceiptLine() As String
        Return getSubItemLineFormatted(ANTI_SCRATCH_STR, ANTI_SCRATCH_COST)
    End Function

    '------------------------------------------------------------
    '-         Function Name: getTintedLensReceiptLine          -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns output to be used on the receipt   -
    '- for tinted lenses.                                       -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - Output to be used on the receipt for tinted     -
    '-          lenses                                          -
    '------------------------------------------------------------
    Private Function getTintedLensReceiptLine() As String
        Return getSubItemLineFormatted(TINTED_STR, TINTED_COST)
    End Function

    '------------------------------------------------------------
    '-         Function Name: getCompHdLensReceiptLine          -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns output to be used on the receipt   -
    '- for computer hd lenses.                                  -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - Output to be used on the receipt for computer   -
    '-          hd lenses                                       -
    '------------------------------------------------------------
    Private Function getCompHdLensReceiptLine() As String
        Return getSubItemLineFormatted(COMP_STRAIN_HD_STR, COMP_STRAIN_HD_COST)
    End Function

    '------------------------------------------------------------
    '-         Function Name: getRolledLensReceiptLine          -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns output to be used on the receipt   -
    '- for rolled edges lenses.                                 -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - Output to be used on the receipt for rolled     -
    '-          edges lenses                                    -
    '------------------------------------------------------------
    Private Function getRolledLensReceiptLine() As String
        Return getSubItemLineFormatted(ROLLED_LENS_EDGE_STR, ROLLED_LENS_EDGE_COST)
    End Function

    '------------------------------------------------------------
    '-     Function Name: getPhotosensitiveLensReceiptLine      -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns output to be used on the receipt   -
    '- for photosensitive lenses.                               -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - Output to be used on the receipt for            -
    '-          photosensitive lenses                           -
    '------------------------------------------------------------
    Private Function getPhotosensitiveLensReceiptLine() As String
        Return getSubItemLineFormatted(PHOTOSENSITIVE_LENS_STR, PHOTOSENSITIVE_LENS_COST)
    End Function

    '------------------------------------------------------------
    '-       Function Name: getProgressiveLensReceiptLine       -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns output to be used on the receipt   -
    '- for progressive lenses.                                  -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - Output to be used on the receipt for            -
    '-          progressive lenses                              -
    '------------------------------------------------------------
    Private Function getProgressiveLensReceiptLine() As String
        Return getSubItemLineFormatted(PROGRESSIVE_LENS_STR, PROGRESSIVE_LEN_COST)
    End Function

    Public Enum lensMaterialType
        Plastic
        Glass
    End Enum

    '------------------------------------------------------------
    '-            Function Name: getReadableLensType            -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns readable lens information based on -
    '- the selected lens material.                              -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - Readable lens information based on the selected -
    '-          lens material.                                  -
    '------------------------------------------------------------
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

    '------------------------------------------------------------
    '-                Function Name: getLensCost                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function returns the lens cost based on the         -
    '- material selected.                                       -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Decimal - The lens cost based on the material selected.  -
    '------------------------------------------------------------
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
