Imports System.ComponentModel

Public Class frmClientDetailInput
    Public myClient As New Client
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

        ' ############### DEBUG STUFF ####################
        Dim c As New Contacts
        c.wear = Contacts.contactWearType.ExtendedWear
        c.hasColoredLens = True
        c.lensColor = Contacts.contactLensColorType.R2D2_Blue
        c.hasReplacementInsurance = True

        Dim g As New Glasses
        g.hasCompHdLens = True
        g.hasPhotosensitiveLens = True
        g.lensMaterial = Glasses.lensMaterialType.Glass

        Dim myClient As New Client
        myClient.contacts = c
        myClient.glasses = g
        myClient.hasContacts = True
        myClient.hasGlasses = True
        myClient.name = "Darth Vader"
        myClient.hasEyeExam = True

        Debug.WriteLine(myClient.getReceiptOutput())
    End Sub

    Private Sub frmClientDetailInput_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MessageBox.Show("You can only close the application from the receipt screen!")
        e.Cancel = True
    End Sub

    Private Sub btnProceedToReceiptScreen_Click(sender As Object, e As EventArgs) Handles btnProceedToReceiptScreen.Click
        Me.Hide()
        frmClientReceipt.Show()
    End Sub

    Public Sub resetData()
        resetName()
        resetServices()
        resetGlassesOptions()
        resetContactsOptions()
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
        rdoPlasticLens.Checked = False
        rdoGlassLens.Checked = False

        chkAntiScratch.Checked = False
        chkTintedLenses.Checked = False
        chkCompHdLenses.Checked = False

        chkRolledLensEdges.Checked = False
        chkPhotosensitiveLens.Checked = False
        chkProgressiveLens.Checked = False
    End Sub

    Private Sub resetContactsOptions()
        rdoDailyWear.Checked = False
        rdoExtendedWear.Checked = False
        rdoGasPerm.Checked = False

        chkReplacementInsurance.Checked = False
        chkCleaningSupplies.Checked = False
        chkColoredLens.Checked = False

        lstColoredLensType.SelectedIndex = 0
    End Sub
End Class
