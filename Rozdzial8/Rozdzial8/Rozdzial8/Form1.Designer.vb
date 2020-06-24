<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSprDane
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
        Me.components = New System.ComponentModel.Container()
        Me.lblData = New System.Windows.Forms.Label()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.trbLiczba = New System.Windows.Forms.TrackBar()
        Me.lblLiczba = New System.Windows.Forms.Label()
        Me.frmKolory = New System.Windows.Forms.GroupBox()
        Me.optCzarny = New System.Windows.Forms.RadioButton()
        Me.optCzerwony = New System.Windows.Forms.RadioButton()
        Me.optBialy = New System.Windows.Forms.RadioButton()
        Me.lblWybor = New System.Windows.Forms.Label()
        Me.cmdOtworz = New System.Windows.Forms.Button()
        Me.cmdZapisz = New System.Windows.Forms.Button()
        Me.cmdKolor = New System.Windows.Forms.Button()
        Me.txtHaslo = New System.Windows.Forms.TextBox()
        Me.lblHaslo = New System.Windows.Forms.Label()
        Me.medTelefon = New System.Windows.Forms.MaskedTextBox()
        Me.lblTelefon = New System.Windows.Forms.Label()
        Me.txtLiczba = New System.Windows.Forms.TextBox()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.cmdPomoc = New System.Windows.Forms.Button()
        Me.errSprDane = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtNazwaFirmy = New System.Windows.Forms.TextBox()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdSprawdz = New System.Windows.Forms.Button()
        CType(Me.trbLiczba, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmKolory.SuspendLayout()
        CType(Me.errSprDane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblData.Location = New System.Drawing.Point(8, 184)
        Me.lblData.MinimumSize = New System.Drawing.Size(164, 32)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(164, 32)
        Me.lblData.TabIndex = 1
        '
        'dtpData
        '
        Me.dtpData.Location = New System.Drawing.Point(8, 16)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(164, 20)
        Me.dtpData.TabIndex = 2
        '
        'trbLiczba
        '
        Me.trbLiczba.LargeChange = 3
        Me.trbLiczba.Location = New System.Drawing.Point(184, 16)
        Me.trbLiczba.Maximum = 15
        Me.trbLiczba.Name = "trbLiczba"
        Me.trbLiczba.Size = New System.Drawing.Size(112, 45)
        Me.trbLiczba.TabIndex = 3
        '
        'lblLiczba
        '
        Me.lblLiczba.AutoSize = True
        Me.lblLiczba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLiczba.Location = New System.Drawing.Point(184, 64)
        Me.lblLiczba.MinimumSize = New System.Drawing.Size(112, 24)
        Me.lblLiczba.Name = "lblLiczba"
        Me.lblLiczba.Size = New System.Drawing.Size(112, 24)
        Me.lblLiczba.TabIndex = 4
        '
        'frmKolory
        '
        Me.frmKolory.Controls.Add(Me.optCzarny)
        Me.frmKolory.Controls.Add(Me.optCzerwony)
        Me.frmKolory.Controls.Add(Me.optBialy)
        Me.frmKolory.Location = New System.Drawing.Point(184, 104)
        Me.frmKolory.Name = "frmKolory"
        Me.frmKolory.Size = New System.Drawing.Size(112, 120)
        Me.frmKolory.TabIndex = 5
        Me.frmKolory.TabStop = False
        Me.frmKolory.Text = "Kolory"
        '
        'optCzarny
        '
        Me.optCzarny.Appearance = System.Windows.Forms.Appearance.Button
        Me.optCzarny.AutoSize = True
        Me.optCzarny.Location = New System.Drawing.Point(8, 88)
        Me.optCzarny.MinimumSize = New System.Drawing.Size(96, 24)
        Me.optCzarny.Name = "optCzarny"
        Me.optCzarny.Size = New System.Drawing.Size(96, 24)
        Me.optCzarny.TabIndex = 2
        Me.optCzarny.TabStop = True
        Me.optCzarny.Text = "Czarny"
        Me.optCzarny.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.optCzarny.UseVisualStyleBackColor = True
        '
        'optCzerwony
        '
        Me.optCzerwony.Appearance = System.Windows.Forms.Appearance.Button
        Me.optCzerwony.AutoSize = True
        Me.optCzerwony.Location = New System.Drawing.Point(8, 52)
        Me.optCzerwony.MinimumSize = New System.Drawing.Size(96, 24)
        Me.optCzerwony.Name = "optCzerwony"
        Me.optCzerwony.Size = New System.Drawing.Size(96, 24)
        Me.optCzerwony.TabIndex = 1
        Me.optCzerwony.TabStop = True
        Me.optCzerwony.Text = "Czerwony"
        Me.optCzerwony.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.optCzerwony.UseVisualStyleBackColor = True
        '
        'optBialy
        '
        Me.optBialy.Appearance = System.Windows.Forms.Appearance.Button
        Me.optBialy.AutoSize = True
        Me.optBialy.Location = New System.Drawing.Point(8, 16)
        Me.optBialy.MinimumSize = New System.Drawing.Size(96, 24)
        Me.optBialy.Name = "optBialy"
        Me.optBialy.Size = New System.Drawing.Size(96, 24)
        Me.optBialy.TabIndex = 0
        Me.optBialy.TabStop = True
        Me.optBialy.Text = "Biały"
        Me.optBialy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.optBialy.UseVisualStyleBackColor = True
        '
        'lblWybor
        '
        Me.lblWybor.AutoSize = True
        Me.lblWybor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWybor.Location = New System.Drawing.Point(184, 232)
        Me.lblWybor.MinimumSize = New System.Drawing.Size(112, 24)
        Me.lblWybor.Name = "lblWybor"
        Me.lblWybor.Size = New System.Drawing.Size(112, 24)
        Me.lblWybor.TabIndex = 6
        '
        'cmdOtworz
        '
        Me.cmdOtworz.Location = New System.Drawing.Point(7, 272)
        Me.cmdOtworz.Name = "cmdOtworz"
        Me.cmdOtworz.Size = New System.Drawing.Size(56, 24)
        Me.cmdOtworz.TabIndex = 7
        Me.cmdOtworz.Text = "Otwórz"
        Me.cmdOtworz.UseVisualStyleBackColor = True
        '
        'cmdZapisz
        '
        Me.cmdZapisz.Location = New System.Drawing.Point(79, 272)
        Me.cmdZapisz.Name = "cmdZapisz"
        Me.cmdZapisz.Size = New System.Drawing.Size(56, 24)
        Me.cmdZapisz.TabIndex = 8
        Me.cmdZapisz.Text = "Zapisz"
        Me.cmdZapisz.UseVisualStyleBackColor = True
        '
        'cmdKolor
        '
        Me.cmdKolor.Location = New System.Drawing.Point(151, 272)
        Me.cmdKolor.Name = "cmdKolor"
        Me.cmdKolor.Size = New System.Drawing.Size(56, 24)
        Me.cmdKolor.TabIndex = 9
        Me.cmdKolor.Text = "Kolor"
        Me.cmdKolor.UseVisualStyleBackColor = True
        '
        'txtHaslo
        '
        Me.txtHaslo.Location = New System.Drawing.Point(312, 24)
        Me.txtHaslo.MaximumSize = New System.Drawing.Size(96, 20)
        Me.txtHaslo.Name = "txtHaslo"
        Me.txtHaslo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtHaslo.Size = New System.Drawing.Size(96, 20)
        Me.txtHaslo.TabIndex = 10
        '
        'lblHaslo
        '
        Me.lblHaslo.AutoSize = True
        Me.lblHaslo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHaslo.Location = New System.Drawing.Point(312, 64)
        Me.lblHaslo.MinimumSize = New System.Drawing.Size(96, 20)
        Me.lblHaslo.Name = "lblHaslo"
        Me.lblHaslo.Size = New System.Drawing.Size(96, 20)
        Me.lblHaslo.TabIndex = 11
        Me.lblHaslo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'medTelefon
        '
        Me.medTelefon.Location = New System.Drawing.Point(312, 120)
        Me.medTelefon.Mask = "(99)###-##-##"
        Me.medTelefon.Name = "medTelefon"
        Me.medTelefon.Size = New System.Drawing.Size(96, 20)
        Me.medTelefon.TabIndex = 12
        '
        'lblTelefon
        '
        Me.lblTelefon.AutoSize = True
        Me.lblTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTelefon.Location = New System.Drawing.Point(312, 88)
        Me.lblTelefon.MinimumSize = New System.Drawing.Size(96, 20)
        Me.lblTelefon.Name = "lblTelefon"
        Me.lblTelefon.Size = New System.Drawing.Size(96, 20)
        Me.lblTelefon.TabIndex = 13
        '
        'txtLiczba
        '
        Me.txtLiczba.Location = New System.Drawing.Point(312, 160)
        Me.txtLiczba.MaximumSize = New System.Drawing.Size(96, 20)
        Me.txtLiczba.Name = "txtLiczba"
        Me.txtLiczba.Size = New System.Drawing.Size(96, 20)
        Me.txtLiczba.TabIndex = 14
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(312, 196)
        Me.txtData.MaximumSize = New System.Drawing.Size(96, 20)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(96, 20)
        Me.txtData.TabIndex = 15
        '
        'cmdPomoc
        '
        Me.cmdPomoc.CausesValidation = False
        Me.cmdPomoc.Location = New System.Drawing.Point(224, 272)
        Me.cmdPomoc.Name = "cmdPomoc"
        Me.cmdPomoc.Size = New System.Drawing.Size(56, 24)
        Me.cmdPomoc.TabIndex = 16
        Me.cmdPomoc.Text = "Pomoc"
        Me.cmdPomoc.UseVisualStyleBackColor = True
        '
        'errSprDane
        '
        Me.errSprDane.ContainerControl = Me
        '
        'txtNazwaFirmy
        '
        Me.txtNazwaFirmy.Location = New System.Drawing.Point(312, 229)
        Me.txtNazwaFirmy.MaximumSize = New System.Drawing.Size(96, 20)
        Me.txtNazwaFirmy.Name = "txtNazwaFirmy"
        Me.txtNazwaFirmy.Size = New System.Drawing.Size(96, 20)
        Me.txtNazwaFirmy.TabIndex = 17
        '
        'cmdOk
        '
        Me.cmdOk.Enabled = False
        Me.cmdOk.Location = New System.Drawing.Point(352, 272)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(64, 24)
        Me.cmdOk.TabIndex = 18
        Me.cmdOk.Text = "OK"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdSprawdz
        '
        Me.cmdSprawdz.Location = New System.Drawing.Point(288, 272)
        Me.cmdSprawdz.Name = "cmdSprawdz"
        Me.cmdSprawdz.Size = New System.Drawing.Size(56, 24)
        Me.cmdSprawdz.TabIndex = 19
        Me.cmdSprawdz.Text = "Sprawdź"
        Me.cmdSprawdz.UseVisualStyleBackColor = True
        '
        'frmSprDane
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 302)
        Me.Controls.Add(Me.cmdSprawdz)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.txtNazwaFirmy)
        Me.Controls.Add(Me.cmdPomoc)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.txtLiczba)
        Me.Controls.Add(Me.lblTelefon)
        Me.Controls.Add(Me.medTelefon)
        Me.Controls.Add(Me.lblHaslo)
        Me.Controls.Add(Me.txtHaslo)
        Me.Controls.Add(Me.cmdKolor)
        Me.Controls.Add(Me.cmdZapisz)
        Me.Controls.Add(Me.cmdOtworz)
        Me.Controls.Add(Me.lblWybor)
        Me.Controls.Add(Me.frmKolory)
        Me.Controls.Add(Me.lblLiczba)
        Me.Controls.Add(Me.trbLiczba)
        Me.Controls.Add(Me.dtpData)
        Me.Controls.Add(Me.lblData)
        Me.Name = "frmSprDane"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sprawdzamy poprawność danych"
        CType(Me.trbLiczba, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmKolory.ResumeLayout(False)
        Me.frmKolory.PerformLayout()
        CType(Me.errSprDane, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents dtpData As System.Windows.Forms.DateTimePicker
    Friend WithEvents trbLiczba As System.Windows.Forms.TrackBar
    Friend WithEvents lblLiczba As System.Windows.Forms.Label
    Friend WithEvents frmKolory As System.Windows.Forms.GroupBox
    Friend WithEvents optCzarny As System.Windows.Forms.RadioButton
    Friend WithEvents optCzerwony As System.Windows.Forms.RadioButton
    Friend WithEvents optBialy As System.Windows.Forms.RadioButton
    Friend WithEvents lblWybor As System.Windows.Forms.Label
    Friend WithEvents cmdOtworz As System.Windows.Forms.Button
    Friend WithEvents cmdZapisz As System.Windows.Forms.Button
    Friend WithEvents cmdKolor As System.Windows.Forms.Button
    Friend WithEvents txtHaslo As System.Windows.Forms.TextBox
    Friend WithEvents lblHaslo As System.Windows.Forms.Label
    Friend WithEvents medTelefon As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblTelefon As System.Windows.Forms.Label
    Friend WithEvents txtLiczba As System.Windows.Forms.TextBox
    Friend WithEvents txtData As System.Windows.Forms.TextBox
    Friend WithEvents cmdPomoc As System.Windows.Forms.Button
    Friend WithEvents errSprDane As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtNazwaFirmy As System.Windows.Forms.TextBox
    Friend WithEvents cmdSprawdz As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button

End Class
