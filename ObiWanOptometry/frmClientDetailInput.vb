Public Class frmClientDetailInput
    Public myClient As New Client
    Public Const BASE_TITLE As String = "Obi-Wan Optometry"
    Public Const TITLE_FORMAT_STR As String = "{0} -- {1}"
    Private Const SUB_TITLE_STR As String = "Eye Care for Generations of Jedi"
    Private TITLE = String.Format(TITLE_FORMAT_STR, BASE_TITLE, SUB_TITLE_STR)

    Private Sub chkGlasses_CheckedChanged(sender As Object, e As EventArgs) Handles chkGlasses.CheckedChanged
        ' TODO: clear fields when unchecking....
        grpGlassesOptions.Visible = chkGlasses.Checked
    End Sub

    Private Sub chkContacts_CheckedChanged(sender As Object, e As EventArgs) Handles chkContacts.CheckedChanged
        ' TODO: clear fields when unchecking....
        grpContactsOptions.Visible = chkContacts.Checked
    End Sub

    Private Sub chkColoredLens_CheckedChanged(sender As Object, e As EventArgs) Handles chkColoredLens.CheckedChanged
        ' TODO: clear list box selection when unchecking....
        lstColoredLensType.Visible = chkColoredLens.Checked
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
End Class
