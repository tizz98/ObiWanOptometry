﻿Public Class frmClientDetailInput
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
End Class
