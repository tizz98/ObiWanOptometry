'------------------------------------------------------------
'-              File Name: frmClientReceipt.vb              -
'-                 Part of Project: Assign2                 -
'------------------------------------------------------------
'-                Written By: Elijah Wilson                 -
'-                  Written On: 01/22/2016                  -
'------------------------------------------------------------
'- File Purpose:                                            -
'-                                                          -
'- This file contains the receipt form for the application. -
'- It handles displaying the receipt data as well as        -
'- completely shutting down the application.                -
'------------------------------------------------------------
Imports System.ComponentModel

Public Class frmClientReceipt
    Private Const SUB_TITLE_STR As String = "Receipt Screen"
    Private TITLE As String = String.Format(frmClientDetailInput.TITLE_FORMAT_STR,
                                            frmClientDetailInput.BASE_TITLE,
                                            SUB_TITLE_STR)
    Private clientDetailInputForm As frmClientDetailInput

    '------------------------------------------------------------
    '-                   Subprogram Name: New                   -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Creates a new instance of the frmClientReceipt class.    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- detailInputForm - The frmClientDetailInput form that     -
    '-                   will be stored so that we can use it   -
    '-                   from within this form.                 -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub New(ByRef detailInputForm As frmClientDetailInput)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        clientDetailInputForm = detailInputForm
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: setTitle                 -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Sets this form text (the title) to the appropriate text. -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub setTitle()
        Me.Text = TITLE
    End Sub

    '------------------------------------------------------------
    '-        Subprogram Name: frmClientReceipt_Closing         -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This prompts the user if they really want to quit the    -
    '- application and if so, completely shuts down the         -
    '- application. Otherwise, it will cancel the closing.      -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The control that raised the Closing event       -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub frmClientReceipt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = MessageBox.Show("Are you sure you want to quit?",
                                   frmClientDetailInput.BASE_TITLE & " Closing",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Exclamation) = DialogResult.No
        If Not e.Cancel Then
            End  ' End the whole application
        End If
    End Sub

    '------------------------------------------------------------
    '-              Subprogram Name: btnExit_Click              -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This attempts to close the form.                         -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Which control raised the Click event            -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    '------------------------------------------------------------
    '-        Subprogram Name: btnGoBackToBilling_Click         -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This hides the receipt form and shows the client detail  -
    '- input form again, with the same data.                    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Which control raised the click event            -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnGoBackToBilling_Click(sender As Object, e As EventArgs) Handles btnGoBackToBilling.Click
        Me.Hide()
        clientDetailInputForm.Show()
    End Sub

    '------------------------------------------------------------
    '-          Subprogram Name: btnProcessOrder_Click          -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This shows a success message to the user then hides the  -
    '- current receipt form. Next it resets all of the data in  -
    '- the data input form & lastly shows the data input form   -
    '- again.                                                   -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Which control raised the Click event            -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnProcessOrder_Click(sender As Object, e As EventArgs) Handles btnProcessOrder.Click
        MessageBox.Show("The order has been processed. Thank you!")
        Me.Hide()
        clientDetailInputForm.resetData()
        clientDetailInputForm.Show()
    End Sub
End Class