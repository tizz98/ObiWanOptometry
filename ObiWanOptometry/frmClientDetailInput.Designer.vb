<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientDetailInput
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
        Me.lblClientName = New System.Windows.Forms.Label()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.grpServicesContainer = New System.Windows.Forms.GroupBox()
        Me.chkContacts = New System.Windows.Forms.CheckBox()
        Me.chkGlasses = New System.Windows.Forms.CheckBox()
        Me.chkEyeExam = New System.Windows.Forms.CheckBox()
        Me.grpGlassesOptions = New System.Windows.Forms.GroupBox()
        Me.grpLensType = New System.Windows.Forms.GroupBox()
        Me.rdoPlasticLens = New System.Windows.Forms.RadioButton()
        Me.rdoGlassLens = New System.Windows.Forms.RadioButton()
        Me.chkAntiScratch = New System.Windows.Forms.CheckBox()
        Me.chkTintedLenses = New System.Windows.Forms.CheckBox()
        Me.chkCompHdLenses = New System.Windows.Forms.CheckBox()
        Me.chkProgressiveLens = New System.Windows.Forms.CheckBox()
        Me.chkPhotosensitiveLens = New System.Windows.Forms.CheckBox()
        Me.chkRolledLensEdges = New System.Windows.Forms.CheckBox()
        Me.grpServicesContainer.SuspendLayout()
        Me.grpGlassesOptions.SuspendLayout()
        Me.grpLensType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblClientName
        '
        Me.lblClientName.AutoSize = True
        Me.lblClientName.Location = New System.Drawing.Point(18, 21)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(67, 13)
        Me.lblClientName.TabIndex = 0
        Me.lblClientName.Text = "Client Name:"
        '
        'txtClientName
        '
        Me.txtClientName.Location = New System.Drawing.Point(91, 18)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(204, 20)
        Me.txtClientName.TabIndex = 1
        '
        'grpServicesContainer
        '
        Me.grpServicesContainer.Controls.Add(Me.chkContacts)
        Me.grpServicesContainer.Controls.Add(Me.chkGlasses)
        Me.grpServicesContainer.Controls.Add(Me.chkEyeExam)
        Me.grpServicesContainer.Location = New System.Drawing.Point(21, 57)
        Me.grpServicesContainer.Name = "grpServicesContainer"
        Me.grpServicesContainer.Size = New System.Drawing.Size(466, 39)
        Me.grpServicesContainer.TabIndex = 2
        Me.grpServicesContainer.TabStop = False
        Me.grpServicesContainer.Text = "Services"
        '
        'chkContacts
        '
        Me.chkContacts.AutoSize = True
        Me.chkContacts.Location = New System.Drawing.Point(391, 16)
        Me.chkContacts.Name = "chkContacts"
        Me.chkContacts.Size = New System.Drawing.Size(68, 17)
        Me.chkContacts.TabIndex = 2
        Me.chkContacts.Text = "Contacts"
        Me.chkContacts.UseVisualStyleBackColor = True
        '
        'chkGlasses
        '
        Me.chkGlasses.AutoSize = True
        Me.chkGlasses.Location = New System.Drawing.Point(211, 16)
        Me.chkGlasses.Name = "chkGlasses"
        Me.chkGlasses.Size = New System.Drawing.Size(63, 17)
        Me.chkGlasses.TabIndex = 1
        Me.chkGlasses.Text = "Glasses"
        Me.chkGlasses.UseVisualStyleBackColor = True
        '
        'chkEyeExam
        '
        Me.chkEyeExam.AutoSize = True
        Me.chkEyeExam.Location = New System.Drawing.Point(7, 16)
        Me.chkEyeExam.Name = "chkEyeExam"
        Me.chkEyeExam.Size = New System.Drawing.Size(73, 17)
        Me.chkEyeExam.TabIndex = 0
        Me.chkEyeExam.Text = "Eye Exam"
        Me.chkEyeExam.UseVisualStyleBackColor = True
        '
        'grpGlassesOptions
        '
        Me.grpGlassesOptions.Controls.Add(Me.chkProgressiveLens)
        Me.grpGlassesOptions.Controls.Add(Me.chkPhotosensitiveLens)
        Me.grpGlassesOptions.Controls.Add(Me.chkRolledLensEdges)
        Me.grpGlassesOptions.Controls.Add(Me.chkCompHdLenses)
        Me.grpGlassesOptions.Controls.Add(Me.chkTintedLenses)
        Me.grpGlassesOptions.Controls.Add(Me.chkAntiScratch)
        Me.grpGlassesOptions.Controls.Add(Me.grpLensType)
        Me.grpGlassesOptions.Location = New System.Drawing.Point(21, 120)
        Me.grpGlassesOptions.Name = "grpGlassesOptions"
        Me.grpGlassesOptions.Size = New System.Drawing.Size(466, 192)
        Me.grpGlassesOptions.TabIndex = 3
        Me.grpGlassesOptions.TabStop = False
        Me.grpGlassesOptions.Text = "Glasses Options"
        '
        'grpLensType
        '
        Me.grpLensType.Controls.Add(Me.rdoGlassLens)
        Me.grpLensType.Controls.Add(Me.rdoPlasticLens)
        Me.grpLensType.Location = New System.Drawing.Point(7, 20)
        Me.grpLensType.Name = "grpLensType"
        Me.grpLensType.Size = New System.Drawing.Size(452, 45)
        Me.grpLensType.TabIndex = 0
        Me.grpLensType.TabStop = False
        '
        'rdoPlasticLens
        '
        Me.rdoPlasticLens.AutoSize = True
        Me.rdoPlasticLens.Location = New System.Drawing.Point(63, 19)
        Me.rdoPlasticLens.Name = "rdoPlasticLens"
        Me.rdoPlasticLens.Size = New System.Drawing.Size(116, 17)
        Me.rdoPlasticLens.TabIndex = 0
        Me.rdoPlasticLens.TabStop = True
        Me.rdoPlasticLens.Text = "Plastic Lens/Frame"
        Me.rdoPlasticLens.UseVisualStyleBackColor = True
        '
        'rdoGlassLens
        '
        Me.rdoGlassLens.AutoSize = True
        Me.rdoGlassLens.Location = New System.Drawing.Point(261, 19)
        Me.rdoGlassLens.Name = "rdoGlassLens"
        Me.rdoGlassLens.Size = New System.Drawing.Size(111, 17)
        Me.rdoGlassLens.TabIndex = 1
        Me.rdoGlassLens.TabStop = True
        Me.rdoGlassLens.Text = "Glass Lens/Frame"
        Me.rdoGlassLens.UseVisualStyleBackColor = True
        '
        'chkAntiScratch
        '
        Me.chkAntiScratch.AutoSize = True
        Me.chkAntiScratch.Location = New System.Drawing.Point(7, 82)
        Me.chkAntiScratch.Name = "chkAntiScratch"
        Me.chkAntiScratch.Size = New System.Drawing.Size(123, 17)
        Me.chkAntiScratch.TabIndex = 1
        Me.chkAntiScratch.Text = "Anti-Scratch Coating"
        Me.chkAntiScratch.UseVisualStyleBackColor = True
        '
        'chkTintedLenses
        '
        Me.chkTintedLenses.AutoSize = True
        Me.chkTintedLenses.Location = New System.Drawing.Point(7, 122)
        Me.chkTintedLenses.Name = "chkTintedLenses"
        Me.chkTintedLenses.Size = New System.Drawing.Size(93, 17)
        Me.chkTintedLenses.TabIndex = 2
        Me.chkTintedLenses.Text = "Tinted Lenses"
        Me.chkTintedLenses.UseVisualStyleBackColor = True
        '
        'chkCompHdLenses
        '
        Me.chkCompHdLenses.AutoSize = True
        Me.chkCompHdLenses.Location = New System.Drawing.Point(7, 163)
        Me.chkCompHdLenses.Name = "chkCompHdLenses"
        Me.chkCompHdLenses.Size = New System.Drawing.Size(146, 17)
        Me.chkCompHdLenses.TabIndex = 3
        Me.chkCompHdLenses.Text = "Computer Strain HD Lens"
        Me.chkCompHdLenses.UseVisualStyleBackColor = True
        '
        'chkProgressiveLens
        '
        Me.chkProgressiveLens.AutoSize = True
        Me.chkProgressiveLens.Location = New System.Drawing.Point(286, 163)
        Me.chkProgressiveLens.Name = "chkProgressiveLens"
        Me.chkProgressiveLens.Size = New System.Drawing.Size(107, 17)
        Me.chkProgressiveLens.TabIndex = 6
        Me.chkProgressiveLens.Text = "Progressive Lens"
        Me.chkProgressiveLens.UseVisualStyleBackColor = True
        '
        'chkPhotosensitiveLens
        '
        Me.chkPhotosensitiveLens.AutoSize = True
        Me.chkPhotosensitiveLens.Location = New System.Drawing.Point(286, 122)
        Me.chkPhotosensitiveLens.Name = "chkPhotosensitiveLens"
        Me.chkPhotosensitiveLens.Size = New System.Drawing.Size(121, 17)
        Me.chkPhotosensitiveLens.TabIndex = 5
        Me.chkPhotosensitiveLens.Text = "Photosensitive Lens"
        Me.chkPhotosensitiveLens.UseVisualStyleBackColor = True
        '
        'chkRolledLensEdges
        '
        Me.chkRolledLensEdges.AutoSize = True
        Me.chkRolledLensEdges.Location = New System.Drawing.Point(286, 82)
        Me.chkRolledLensEdges.Name = "chkRolledLensEdges"
        Me.chkRolledLensEdges.Size = New System.Drawing.Size(115, 17)
        Me.chkRolledLensEdges.TabIndex = 4
        Me.chkRolledLensEdges.Text = "Rolled Lens Edges"
        Me.chkRolledLensEdges.UseVisualStyleBackColor = True
        '
        'frmClientDetailInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 793)
        Me.Controls.Add(Me.grpGlassesOptions)
        Me.Controls.Add(Me.grpServicesContainer)
        Me.Controls.Add(Me.txtClientName)
        Me.Controls.Add(Me.lblClientName)
        Me.Name = "frmClientDetailInput"
        Me.Text = "Form1"
        Me.grpServicesContainer.ResumeLayout(False)
        Me.grpServicesContainer.PerformLayout()
        Me.grpGlassesOptions.ResumeLayout(False)
        Me.grpGlassesOptions.PerformLayout()
        Me.grpLensType.ResumeLayout(False)
        Me.grpLensType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtClientName As TextBox
    Friend WithEvents grpServicesContainer As GroupBox
    Friend WithEvents chkContacts As CheckBox
    Friend WithEvents chkGlasses As CheckBox
    Friend WithEvents chkEyeExam As CheckBox
    Friend WithEvents lblClientName As Label
    Friend WithEvents grpGlassesOptions As GroupBox
    Friend WithEvents grpLensType As GroupBox
    Friend WithEvents rdoGlassLens As RadioButton
    Friend WithEvents rdoPlasticLens As RadioButton
    Friend WithEvents chkProgressiveLens As CheckBox
    Friend WithEvents chkPhotosensitiveLens As CheckBox
    Friend WithEvents chkRolledLensEdges As CheckBox
    Friend WithEvents chkCompHdLenses As CheckBox
    Friend WithEvents chkTintedLenses As CheckBox
    Friend WithEvents chkAntiScratch As CheckBox
End Class
