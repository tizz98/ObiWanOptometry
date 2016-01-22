Imports System.ComponentModel

Public Class frmClientDetailInput
    Public myClient As New Client
    Public receiptForm As frmClientReceipt = New frmClientReceipt(Me)
    Public Const BASE_TITLE As String = "Obi-Wan Optometry"
    Public Const TITLE_FORMAT_STR As String = "{0} -- {1}"
    Private Const SUB_TITLE_STR As String = "Eye Care for Generations of Jedi"
    Private TITLE As String = String.Format(TITLE_FORMAT_STR, BASE_TITLE, SUB_TITLE_STR)

    Private Sub chkGlasses_CheckedChanged(sender As Object, e As EventArgs) Handles chkGlasses.CheckedChanged
        grpGlassesOptions.Visible = chkGlasses.Checked

        If Not chkGlasses.Checked Then
            resetGlassesOptions()
        End If
    End Sub

    Private Sub chkContacts_CheckedChanged(sender As Object, e As EventArgs) Handles chkContacts.CheckedChanged
        grpContactsOptions.Visible = chkContacts.Checked

        If Not chkContacts.Checked Then
            resetContactsOptions()
        End If
    End Sub

    Private Sub chkColoredLens_CheckedChanged(sender As Object, e As EventArgs) Handles chkColoredLens.CheckedChanged
        lstColoredLensType.Visible = chkColoredLens.Checked

        If Not chkColoredLens.Checked Then
            lstColoredLensType.SelectedIndex = 0
        End If
    End Sub

    Private Sub frmClientDetailInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstColoredLensType.DataSource = Contacts.COLOR_LIST
        Me.Text = TITLE
    End Sub

    Private Sub frmClientDetailInput_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MessageBox.Show("You can only close the application from the receipt screen!")
        e.Cancel = True
    End Sub

    Private Sub btnProceedToReceiptScreen_Click(sender As Object, e As EventArgs) Handles btnProceedToReceiptScreen.Click
        getDataFromFields()

        If myClient.validate() Then
            Me.Hide()

            receiptForm.setTitle()
            receiptForm.txtReceiptData.Text = myClient.getReceiptOutput()
            receiptForm.Show()
        End If
    End Sub

    Public Sub resetData()
        resetName()
        resetServices()
        resetGlassesOptions()
        resetContactsOptions()

        myClient = New Client
    End Sub

    Private Sub resetName()
        txtClientName.Text = ""
    End Sub

    Private Sub resetServices()
        chkEyeExam.Checked = False
        chkGlasses.Checked = False
        chkContacts.Checked = False
    End Sub

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

    Private Sub resetContactsOptions()
        rdoDailyWear.Checked = True
        rdoExtendedWear.Checked = False
        rdoGasPerm.Checked = False

        chkReplacementInsurance.Checked = False
        chkCleaningSupplies.Checked = False
        chkColoredLens.Checked = False

        lstColoredLensType.SelectedIndex = 0
    End Sub

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
        myClient.glasses.hasPhotosensitiveLens = chkRolledLensEdges.Checked
        myClient.glasses.hasProgressiveLens = chkProgressiveLens.Checked
    End Sub

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
