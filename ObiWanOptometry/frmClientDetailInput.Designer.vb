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
        Me.chkProgressiveLens = New System.Windows.Forms.CheckBox()
        Me.chkPhotosensitiveLens = New System.Windows.Forms.CheckBox()
        Me.chkRolledLensEdges = New System.Windows.Forms.CheckBox()
        Me.chkCompHdLenses = New System.Windows.Forms.CheckBox()
        Me.chkTintedLenses = New System.Windows.Forms.CheckBox()
        Me.chkAntiScratch = New System.Windows.Forms.CheckBox()
        Me.grpLensType = New System.Windows.Forms.GroupBox()
        Me.rdoGlassLens = New System.Windows.Forms.RadioButton()
        Me.rdoPlasticLens = New System.Windows.Forms.RadioButton()
        Me.grpContactsOptions = New System.Windows.Forms.GroupBox()
        Me.lstColoredLensType = New System.Windows.Forms.ListBox()
        Me.chkColoredLens = New System.Windows.Forms.CheckBox()
        Me.chkCleaningSupplies = New System.Windows.Forms.CheckBox()
        Me.chkReplacementInsurance = New System.Windows.Forms.CheckBox()
        Me.grpContactsWearType = New System.Windows.Forms.GroupBox()
        Me.rdoGasPerm = New System.Windows.Forms.RadioButton()
        Me.rdoExtendedWear = New System.Windows.Forms.RadioButton()
        Me.rdoDailyWear = New System.Windows.Forms.RadioButton()
        Me.btnProceedToReceiptScreen = New System.Windows.Forms.Button()
        Me.grpServicesContainer.SuspendLayout()
        Me.grpGlassesOptions.SuspendLayout()
        Me.grpLensType.SuspendLayout()
        Me.grpContactsOptions.SuspendLayout()
        Me.grpContactsWearType.SuspendLayout()
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
        Me.grpGlassesOptions.Visible = False
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
        'grpContactsOptions
        '
        Me.grpContactsOptions.Controls.Add(Me.lstColoredLensType)
        Me.grpContactsOptions.Controls.Add(Me.chkColoredLens)
        Me.grpContactsOptions.Controls.Add(Me.chkCleaningSupplies)
        Me.grpContactsOptions.Controls.Add(Me.chkReplacementInsurance)
        Me.grpContactsOptions.Controls.Add(Me.grpContactsWearType)
        Me.grpContactsOptions.Location = New System.Drawing.Point(21, 336)
        Me.grpContactsOptions.Name = "grpContactsOptions"
        Me.grpContactsOptions.Size = New System.Drawing.Size(466, 194)
        Me.grpContactsOptions.TabIndex = 4
        Me.grpContactsOptions.TabStop = False
        Me.grpContactsOptions.Text = "Contacts Options"
        Me.grpContactsOptions.Visible = False
        '
        'lstColoredLensType
        '
        Me.lstColoredLensType.FormattingEnabled = True
        Me.lstColoredLensType.Location = New System.Drawing.Point(211, 153)
        Me.lstColoredLensType.Name = "lstColoredLensType"
        Me.lstColoredLensType.Size = New System.Drawing.Size(146, 30)
        Me.lstColoredLensType.TabIndex = 4
        Me.lstColoredLensType.Visible = False
        '
        'chkColoredLens
        '
        Me.chkColoredLens.AutoSize = True
        Me.chkColoredLens.Location = New System.Drawing.Point(6, 161)
        Me.chkColoredLens.Name = "chkColoredLens"
        Me.chkColoredLens.Size = New System.Drawing.Size(88, 17)
        Me.chkColoredLens.TabIndex = 3
        Me.chkColoredLens.Text = "Colored Lens"
        Me.chkColoredLens.UseVisualStyleBackColor = True
        '
        'chkCleaningSupplies
        '
        Me.chkCleaningSupplies.AutoSize = True
        Me.chkCleaningSupplies.Location = New System.Drawing.Point(7, 125)
        Me.chkCleaningSupplies.Name = "chkCleaningSupplies"
        Me.chkCleaningSupplies.Size = New System.Drawing.Size(173, 17)
        Me.chkCleaningSupplies.TabIndex = 2
        Me.chkCleaningSupplies.Text = "Cleaning Supplies for One Year"
        Me.chkCleaningSupplies.UseVisualStyleBackColor = True
        '
        'chkReplacementInsurance
        '
        Me.chkReplacementInsurance.AutoSize = True
        Me.chkReplacementInsurance.Location = New System.Drawing.Point(7, 90)
        Me.chkReplacementInsurance.Name = "chkReplacementInsurance"
        Me.chkReplacementInsurance.Size = New System.Drawing.Size(139, 17)
        Me.chkReplacementInsurance.TabIndex = 1
        Me.chkReplacementInsurance.Text = "Replacement Insurance"
        Me.chkReplacementInsurance.UseVisualStyleBackColor = True
        '
        'grpContactsWearType
        '
        Me.grpContactsWearType.Controls.Add(Me.rdoGasPerm)
        Me.grpContactsWearType.Controls.Add(Me.rdoExtendedWear)
        Me.grpContactsWearType.Controls.Add(Me.rdoDailyWear)
        Me.grpContactsWearType.Location = New System.Drawing.Point(7, 20)
        Me.grpContactsWearType.Name = "grpContactsWearType"
        Me.grpContactsWearType.Size = New System.Drawing.Size(452, 43)
        Me.grpContactsWearType.TabIndex = 0
        Me.grpContactsWearType.TabStop = False
        '
        'rdoGasPerm
        '
        Me.rdoGasPerm.AutoSize = True
        Me.rdoGasPerm.Location = New System.Drawing.Point(329, 16)
        Me.rdoGasPerm.Name = "rdoGasPerm"
        Me.rdoGasPerm.Size = New System.Drawing.Size(97, 17)
        Me.rdoGasPerm.TabIndex = 2
        Me.rdoGasPerm.TabStop = True
        Me.rdoGasPerm.Text = "Gas Permeable"
        Me.rdoGasPerm.UseVisualStyleBackColor = True
        '
        'rdoExtendedWear
        '
        Me.rdoExtendedWear.AutoSize = True
        Me.rdoExtendedWear.Location = New System.Drawing.Point(169, 16)
        Me.rdoExtendedWear.Name = "rdoExtendedWear"
        Me.rdoExtendedWear.Size = New System.Drawing.Size(99, 17)
        Me.rdoExtendedWear.TabIndex = 1
        Me.rdoExtendedWear.TabStop = True
        Me.rdoExtendedWear.Text = "Extended Wear"
        Me.rdoExtendedWear.UseVisualStyleBackColor = True
        '
        'rdoDailyWear
        '
        Me.rdoDailyWear.AutoSize = True
        Me.rdoDailyWear.Location = New System.Drawing.Point(19, 16)
        Me.rdoDailyWear.Name = "rdoDailyWear"
        Me.rdoDailyWear.Size = New System.Drawing.Size(77, 17)
        Me.rdoDailyWear.TabIndex = 0
        Me.rdoDailyWear.TabStop = True
        Me.rdoDailyWear.Text = "Daily Wear"
        Me.rdoDailyWear.UseVisualStyleBackColor = True
        '
        'btnProceedToReceiptScreen
        '
        Me.btnProceedToReceiptScreen.Location = New System.Drawing.Point(21, 547)
        Me.btnProceedToReceiptScreen.Name = "btnProceedToReceiptScreen"
        Me.btnProceedToReceiptScreen.Size = New System.Drawing.Size(474, 65)
        Me.btnProceedToReceiptScreen.TabIndex = 5
        Me.btnProceedToReceiptScreen.Text = "Proceed to Receipt Screen"
        Me.btnProceedToReceiptScreen.UseVisualStyleBackColor = True
        '
        'frmClientDetailInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 624)
        Me.Controls.Add(Me.btnProceedToReceiptScreen)
        Me.Controls.Add(Me.grpContactsOptions)
        Me.Controls.Add(Me.grpGlassesOptions)
        Me.Controls.Add(Me.grpServicesContainer)
        Me.Controls.Add(Me.txtClientName)
        Me.Controls.Add(Me.lblClientName)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(523, 662)
        Me.MinimumSize = New System.Drawing.Size(523, 662)
        Me.Name = "frmClientDetailInput"
        Me.Text = "Form1"
        Me.grpServicesContainer.ResumeLayout(False)
        Me.grpServicesContainer.PerformLayout()
        Me.grpGlassesOptions.ResumeLayout(False)
        Me.grpGlassesOptions.PerformLayout()
        Me.grpLensType.ResumeLayout(False)
        Me.grpLensType.PerformLayout()
        Me.grpContactsOptions.ResumeLayout(False)
        Me.grpContactsOptions.PerformLayout()
        Me.grpContactsWearType.ResumeLayout(False)
        Me.grpContactsWearType.PerformLayout()
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
    Friend WithEvents grpContactsOptions As GroupBox
    Friend WithEvents grpContactsWearType As GroupBox
    Friend WithEvents rdoGasPerm As RadioButton
    Friend WithEvents rdoExtendedWear As RadioButton
    Friend WithEvents rdoDailyWear As RadioButton
    Friend WithEvents lstColoredLensType As ListBox
    Friend WithEvents chkColoredLens As CheckBox
    Friend WithEvents chkCleaningSupplies As CheckBox
    Friend WithEvents chkReplacementInsurance As CheckBox
    Friend WithEvents btnProceedToReceiptScreen As Button
End Class
