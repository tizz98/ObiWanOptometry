<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientReceipt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtReceiptData = New System.Windows.Forms.TextBox()
        Me.btnGoBackToBilling = New System.Windows.Forms.Button()
        Me.btnProcessOrder = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtReceiptData
        '
        Me.txtReceiptData.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptData.Location = New System.Drawing.Point(4, 3)
        Me.txtReceiptData.Multiline = True
        Me.txtReceiptData.Name = "txtReceiptData"
        Me.txtReceiptData.ReadOnly = True
        Me.txtReceiptData.Size = New System.Drawing.Size(532, 474)
        Me.txtReceiptData.TabIndex = 0
        Me.txtReceiptData.TabStop = False
        '
        'btnGoBackToBilling
        '
        Me.btnGoBackToBilling.Location = New System.Drawing.Point(13, 484)
        Me.btnGoBackToBilling.Name = "btnGoBackToBilling"
        Me.btnGoBackToBilling.Size = New System.Drawing.Size(515, 45)
        Me.btnGoBackToBilling.TabIndex = 1
        Me.btnGoBackToBilling.Text = "Go Back to Billing Screen"
        Me.btnGoBackToBilling.UseVisualStyleBackColor = True
        '
        'btnProcessOrder
        '
        Me.btnProcessOrder.Location = New System.Drawing.Point(12, 535)
        Me.btnProcessOrder.Name = "btnProcessOrder"
        Me.btnProcessOrder.Size = New System.Drawing.Size(516, 45)
        Me.btnProcessOrder.TabIndex = 2
        Me.btnProcessOrder.Text = "Process Order"
        Me.btnProcessOrder.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 586)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(516, 45)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit System"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmClientReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 640)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnProcessOrder)
        Me.Controls.Add(Me.btnGoBackToBilling)
        Me.Controls.Add(Me.txtReceiptData)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(556, 678)
        Me.MinimumSize = New System.Drawing.Size(556, 678)
        Me.Name = "frmClientReceipt"
        Me.Text = "frmClientReceipt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtReceiptData As TextBox
    Friend WithEvents btnGoBackToBilling As Button
    Friend WithEvents btnProcessOrder As Button
    Friend WithEvents btnExit As Button
End Class
