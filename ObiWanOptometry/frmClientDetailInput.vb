Public Class frmClientDetailInput
    Private Sub chkGlasses_CheckedChanged(sender As Object, e As EventArgs) Handles chkGlasses.CheckedChanged
        ' TODO: clear fields when unchecking....
        grpGlassesOptions.Visible = chkGlasses.Checked
    End Sub
End Class
