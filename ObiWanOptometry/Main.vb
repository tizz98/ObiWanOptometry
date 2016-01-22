Module Main
    Friend clientDetailInputForm As New frmClientDetailInput
    Friend clientReceiptForm As New frmClientReceipt

    Sub Main()
        clientReceiptForm.setTitle()
        clientDetailInputForm.ShowDialog()
    End Sub
End Module
