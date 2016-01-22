Public Class frmClientDetailInput
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
        Dim c As New Contacts
        c.wear = Contacts.contactWearType.ExtendedWear
        c.hasColoredLens = True
        c.lensColor = Contacts.contactLensColorType.R2D2_Blue
        c.hasReplacementInsurance = True
        Debug.WriteLine(c.getReceiptOutput())
    End Sub
End Class
