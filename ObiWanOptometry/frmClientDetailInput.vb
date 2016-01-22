'------------------------------------------------------------
'-            File Name: frmClientDetailInput.vb            -
'-                 Part of Project: Assign2                 -
'------------------------------------------------------------
'-                Written By: Elijah Wilson                 -
'-                  Written On: 01/22/2016                  -
'------------------------------------------------------------
'- File Purpose:                                            -
'-                                                          -
'- This file contains the main form for the application     -
'- that allows for the input of a client's information.     -
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program allows for inputting client information     -
'- about their optometry needs. It also allows for viewing  -
'- a nicely formatted receipt.                              -
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'- (None)                                                   -
'------------------------------------------------------------
Imports System.ComponentModel

Public Class frmClientDetailInput
    Public myClient As New Client
    Public receiptForm As frmClientReceipt = New frmClientReceipt(Me)
    Public Const BASE_TITLE As String = "Obi-Wan Optometry"
    Public Const TITLE_FORMAT_STR As String = "{0} -- {1}"
    Private Const SUB_TITLE_STR As String = "Eye Care for Generations of Jedi"
    Private TITLE As String = String.Format(TITLE_FORMAT_STR, BASE_TITLE, SUB_TITLE_STR)

    '------------------------------------------------------------
    '-        Subprogram Name: chkGlasses_CheckedChanged        -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subprogram handles when the glasses checkbox is     -
    '- either checked or unchecked. Depending on this, it will  -
    '- change the visibility of the glasses groupbox. If it is  -
    '- unchecked, it will also clear out any data in the        -
    '- glasses options.                                         -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Identifies which particular control raised the  -
    '-          CheckChanged event                              -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub chkGlasses_CheckedChanged(sender As Object, e As EventArgs) Handles chkGlasses.CheckedChanged
        grpGlassesOptions.Visible = chkGlasses.Checked

        If Not chkGlasses.Checked Then
            resetGlassesOptions()
        End If
    End Sub

    '------------------------------------------------------------
    '-       Subprogram Name: chkContacts_CheckedChanged        -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subprogram handles when the contacts checkbox is    -
    '- either checked or unchecked. Depending on this, it will  -
    '- change the visibility of the contacts groupbox. If it is -
    '- unchecked, it will also clear out any data in the        -
    '- contacts options.                                        -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Identifies which particular control raised the  -
    '-          CheckChanged event                              -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub chkContacts_CheckedChanged(sender As Object, e As EventArgs) Handles chkContacts.CheckedChanged
        grpContactsOptions.Visible = chkContacts.Checked

        If Not chkContacts.Checked Then
            resetContactsOptions()
        End If
    End Sub

    '------------------------------------------------------------
    '-      Subprogram Name: chkColoredLens_CheckedChanged      -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subprogram handles when the colored lens checkbox   -
    '- is either checked or unchecked. Depending on this, it    -
    '- will change the visibility of the colored lens listbox.  -
    '- If it is unchecked, it will also reset the selected      -
    '- index of the listbox.                                    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Identifies which particular control raised the  -
    '-          CheckChanged event                              -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub chkColoredLens_CheckedChanged(sender As Object, e As EventArgs) Handles chkColoredLens.CheckedChanged
        lstColoredLensType.Visible = chkColoredLens.Checked

        If Not chkColoredLens.Checked Then
            lstColoredLensType.SelectedIndex = 0
        End If
    End Sub

    '------------------------------------------------------------
    '-        Subprogram Name: frmClientDetailInput_Load        -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sets the colored lens listbox data source to the    -
    '- contacts color list and sets the form's text to the      -
    '- appropriate title.                                       -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Identifies which particular control raised the  -
    '-          Load event                                      -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub frmClientDetailInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstColoredLensType.DataSource = Contacts.COLOR_LIST
        Me.Text = TITLE
    End Sub

    '------------------------------------------------------------
    '-      Subprogram Name: frmClientDetailInput_Closing       -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This prevents closing of the application from the        -
    '- receipt input form. It shows a messagebox and then       -
    '- cancels the closing of the form.                         -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Identifies which control raised the Closing     -
    '-          event                                           -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub frmClientDetailInput_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MessageBox.Show("You can only close the application from the receipt screen!")
        e.Cancel = True
    End Sub

    '------------------------------------------------------------
    '-     Subprogram Name: btnProceedToReceiptScreen_Click     -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This gets the data from the fields on the form and sets  -
    '- them to myClient. If everything is valid, it will hide   -
    '- this form, set the title of the receiptForm, set the     -
    '- receiptData to the client's receipt output and then show -
    '- the receiptForm.                                         -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Which control raised the Click event            -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnProceedToReceiptScreen_Click(sender As Object, e As EventArgs) Handles btnProceedToReceiptScreen.Click
        getDataFromFields()

        If myClient.validate() Then
            Me.Hide()

            receiptForm.setTitle()
            receiptForm.txtReceiptData.Text = myClient.getReceiptOutput()
            receiptForm.Show()
        End If
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: resetData                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This resets all the fields on the form and sets myClient -
    '- to a new client object.                                  -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub resetData()
        resetName()
        resetServices()
        resetGlassesOptions()
        resetContactsOptions()

        myClient = New Client
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: resetName                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This resets the client name field to an empty string.    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub resetName()
        txtClientName.Text = ""
    End Sub

    '------------------------------------------------------------
    '-              Subprogram Name: resetServices              -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This resets all the service check boxes (eye exam,       -
    '- glasses & contacts) to being unchecked.                  -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub resetServices()
        chkEyeExam.Checked = False
        chkGlasses.Checked = False
        chkContacts.Checked = False
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: resetGlassesOptions           -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This resets all the glasses options to their default     -
    '- states.                                                  -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub resetGlassesOptions()
        rdoPlasticLens.Checked = True
        rdoGlassLens.Checked = False

        chkAntiScratch.Checked = False
        chkTintedLenses.Checked = False
        chkCompHdLenses.Checked = False

        chkRolledLensEdges.Checked = False
        chkPhotosensitiveLens.Checked = False
        chkProgressiveLens.Checked = False
    End Sub

    '------------------------------------------------------------
    '-          Subprogram Name: resetContactsOptions           -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This resets all the contacts options to their default    -
    '- states.                                                  -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub resetContactsOptions()
        rdoDailyWear.Checked = True
        rdoExtendedWear.Checked = False
        rdoGasPerm.Checked = False

        chkReplacementInsurance.Checked = False
        chkCleaningSupplies.Checked = False
        chkColoredLens.Checked = False

        lstColoredLensType.SelectedIndex = 0
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: getDataFromFields            -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This retrieves all the data from all the fields on the   -
    '- form and stores the data in myClient.                    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub getDataFromFields()
        myClient.name = txtClientName.Text
        myClient.hasEyeExam = chkEyeExam.Checked
        myClient.hasGlasses = chkGlasses.Checked
        myClient.hasContacts = chkContacts.Checked

        If myClient.hasGlasses Then
            getGlassesDataFromFields()
        End If

        If myClient.hasContacts Then
            getContactsDataFromFields()
        End If
    End Sub

    '------------------------------------------------------------
    '-        Subprogram Name: getGlassesDataFromFields         -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This retrieves all the glasses data from the form fields -
    '- and assigns it to a new glasses object which is then     -
    '- stored in myClient.glasses.                              -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub getGlassesDataFromFields()
        myClient.glasses = New Glasses

        If rdoPlasticLens.Checked Then
            myClient.glasses.lensMaterial = Glasses.lensMaterialType.Plastic
        ElseIf rdoGlassLens.Checked Then
            myClient.glasses.lensMaterial = Glasses.lensMaterialType.Glass
        End If

        myClient.glasses.hasAntiScratch = chkAntiScratch.Checked
        myClient.glasses.hasTintedLens = chkTintedLenses.Checked
        myClient.glasses.hasCompHdLens = chkCompHdLenses.Checked

        myClient.glasses.hasRolledLensEdges = chkRolledLensEdges.Checked
        myClient.glasses.hasPhotosensitiveLens = chkPhotosensitiveLens.Checked
        myClient.glasses.hasProgressiveLens = chkProgressiveLens.Checked
    End Sub

    '------------------------------------------------------------
    '-        Subprogram Name: getContactsDataFromFields        -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 01/22/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This retrieves all the contacts data from the form       -
    '- fields and assigns it to a new contacts object which is  -
    '- then stored in myClient.contacts.                        -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub getContactsDataFromFields()
        myClient.contacts = New Contacts

        If rdoDailyWear.Checked Then
            myClient.contacts.wear = Contacts.contactWearType.DailyWear
        ElseIf rdoExtendedWear.Checked Then
            myClient.contacts.wear = Contacts.contactWearType.ExtendedWear
        ElseIf rdoGasPerm.Checked Then
            myClient.contacts.wear = Contacts.contactWearType.GasPermeable
        End If

        myClient.contacts.hasReplacementInsurance = chkReplacementInsurance.Checked
        myClient.contacts.hasCleaningSupplies = chkCleaningSupplies.Checked
        myClient.contacts.hasColoredLens = chkColoredLens.Checked

        If myClient.contacts.hasColoredLens Then
            Dim lensString = Contacts.COLOR_LIST.Item(Contacts.COLOR_LIST.IndexOf(lstColoredLensType.SelectedItem))

            myClient.contacts.lensColor = myClient.contacts.getLensColorTypeFromString(lensString)
        End If
    End Sub
End Class
