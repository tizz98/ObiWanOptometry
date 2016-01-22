Imports System.ComponentModel

Public Class frmClientReceipt
    Private Const SUB_TITLE_STR As String = "Receipt Screen"
    Private TITLE As String = String.Format(frmClientDetailInput.TITLE_FORMAT_STR,
                                            frmClientDetailInput.BASE_TITLE,
                                            SUB_TITLE_STR)

    Public Sub setTitle()
        Me.Text = TITLE
    End Sub

    Private Sub frmClientReceipt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = MessageBox.Show("Are you sure you want to quit?",
                                   frmClientDetailInput.BASE_TITLE & " Closing",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Exclamation) = DialogResult.No
        If Not e.Cancel Then
            End  ' End the whole application
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnGoBackToBilling_Click(sender As Object, e As EventArgs) Handles btnGoBackToBilling.Click
        Me.Hide()
        frmClientDetailInput.Show()
    End Sub

    Private Sub btnProcessOrder_Click(sender As Object, e As EventArgs) Handles btnProcessOrder.Click
        MessageBox.Show("The order has been processed. Thank you!")
        Me.Hide()
        frmClientDetailInput.resetData()
        frmClientDetailInput.Show()
    End Sub
End Class