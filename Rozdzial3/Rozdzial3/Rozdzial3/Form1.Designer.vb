<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmZmienne
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
        Me.txtPierwszaLiczba = New System.Windows.Forms.TextBox()
        Me.txtDrugaLiczba = New System.Windows.Forms.TextBox()
        Me.lblWynik = New System.Windows.Forms.Label()
        Me.cmdPomnoz = New System.Windows.Forms.Button()
        Me.cmdVat = New System.Windows.Forms.Button()
        Me.cmdGodziny = New System.Windows.Forms.Button()
        Me.cmdRozne = New System.Windows.Forms.Button()
        Me.cmdWieksza = New System.Windows.Forms.Button()
        Me.cmdModulo = New System.Windows.Forms.Button()
        Me.cmdAnd = New System.Windows.Forms.Button()
        Me.cmdOrElse = New System.Windows.Forms.Button()
        Me.txtImie = New System.Windows.Forms.TextBox()
        Me.cmdSS = New System.Windows.Forms.Button()
        Me.cmdSI = New System.Windows.Forms.Button()
        Me.cmdLicznik = New System.Windows.Forms.Button()
        Me.cmdStruktura = New System.Windows.Forms.Button()
        Me.CmdTablica1 = New System.Windows.Forms.Button()
        Me.cmdTablica2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPierwszaLiczba
        '
        Me.txtPierwszaLiczba.Location = New System.Drawing.Point(8, 16)
        Me.txtPierwszaLiczba.Name = "txtPierwszaLiczba"
        Me.txtPierwszaLiczba.Size = New System.Drawing.Size(112, 20)
        Me.txtPierwszaLiczba.TabIndex = 0
        Me.txtPierwszaLiczba.Text = "0"
        '
        'txtDrugaLiczba
        '
        Me.txtDrugaLiczba.Location = New System.Drawing.Point(8, 48)
        Me.txtDrugaLiczba.Name = "txtDrugaLiczba"
        Me.txtDrugaLiczba.Size = New System.Drawing.Size(112, 20)
        Me.txtDrugaLiczba.TabIndex = 1
        Me.txtDrugaLiczba.Text = "0"
        '
        'lblWynik
        '
        Me.lblWynik.AutoSize = True
        Me.lblWynik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWynik.Location = New System.Drawing.Point(8, 112)
        Me.lblWynik.MinimumSize = New System.Drawing.Size(112, 20)
        Me.lblWynik.Name = "lblWynik"
        Me.lblWynik.Size = New System.Drawing.Size(112, 20)
        Me.lblWynik.TabIndex = 2
        '
        'cmdPomnoz
        '
        Me.cmdPomnoz.Location = New System.Drawing.Point(176, 16)
        Me.cmdPomnoz.Name = "cmdPomnoz"
        Me.cmdPomnoz.Size = New System.Drawing.Size(112, 22)
        Me.cmdPomnoz.TabIndex = 3
        Me.cmdPomnoz.Text = "Mnożenie"
        Me.cmdPomnoz.UseVisualStyleBackColor = True
        '
        'cmdVat
        '
        Me.cmdVat.Location = New System.Drawing.Point(128, 16)
        Me.cmdVat.Name = "cmdVat"
        Me.cmdVat.Size = New System.Drawing.Size(40, 22)
        Me.cmdVat.TabIndex = 4
        Me.cmdVat.Text = "VAT"
        Me.cmdVat.UseVisualStyleBackColor = True
        '
        'cmdGodziny
        '
        Me.cmdGodziny.Location = New System.Drawing.Point(128, 48)
        Me.cmdGodziny.Name = "cmdGodziny"
        Me.cmdGodziny.Size = New System.Drawing.Size(40, 22)
        Me.cmdGodziny.TabIndex = 5
        Me.cmdGodziny.Text = "Godz."
        Me.cmdGodziny.UseVisualStyleBackColor = True
        '
        'cmdRozne
        '
        Me.cmdRozne.Location = New System.Drawing.Point(16, 168)
        Me.cmdRozne.Name = "cmdRozne"
        Me.cmdRozne.Size = New System.Drawing.Size(32, 24)
        Me.cmdRozne.TabIndex = 6
        Me.cmdRozne.Text = "<>"
        Me.cmdRozne.UseVisualStyleBackColor = True
        '
        'cmdWieksza
        '
        Me.cmdWieksza.Location = New System.Drawing.Point(72, 168)
        Me.cmdWieksza.Name = "cmdWieksza"
        Me.cmdWieksza.Size = New System.Drawing.Size(32, 24)
        Me.cmdWieksza.TabIndex = 7
        Me.cmdWieksza.Text = ">"
        Me.cmdWieksza.UseVisualStyleBackColor = True
        '
        'cmdModulo
        '
        Me.cmdModulo.Location = New System.Drawing.Point(128, 168)
        Me.cmdModulo.Name = "cmdModulo"
        Me.cmdModulo.Size = New System.Drawing.Size(32, 24)
        Me.cmdModulo.TabIndex = 8
        Me.cmdModulo.Text = "%"
        Me.cmdModulo.UseVisualStyleBackColor = True
        '
        'cmdAnd
        '
        Me.cmdAnd.Location = New System.Drawing.Point(184, 168)
        Me.cmdAnd.Name = "cmdAnd"
        Me.cmdAnd.Size = New System.Drawing.Size(48, 24)
        Me.cmdAnd.TabIndex = 9
        Me.cmdAnd.Text = "And"
        Me.cmdAnd.UseVisualStyleBackColor = True
        '
        'cmdOrElse
        '
        Me.cmdOrElse.Location = New System.Drawing.Point(252, 168)
        Me.cmdOrElse.Name = "cmdOrElse"
        Me.cmdOrElse.Size = New System.Drawing.Size(48, 24)
        Me.cmdOrElse.TabIndex = 10
        Me.cmdOrElse.Text = "OrElse"
        Me.cmdOrElse.UseVisualStyleBackColor = True
        '
        'txtImie
        '
        Me.txtImie.Location = New System.Drawing.Point(8, 80)
        Me.txtImie.Name = "txtImie"
        Me.txtImie.Size = New System.Drawing.Size(112, 20)
        Me.txtImie.TabIndex = 11
        Me.txtImie.Text = "Eleonora"
        '
        'cmdSS
        '
        Me.cmdSS.Location = New System.Drawing.Point(184, 48)
        Me.cmdSS.Name = "cmdSS"
        Me.cmdSS.Size = New System.Drawing.Size(40, 22)
        Me.cmdSS.TabIndex = 12
        Me.cmdSS.Text = "S+S"
        Me.cmdSS.UseVisualStyleBackColor = True
        '
        'cmdSI
        '
        Me.cmdSI.Location = New System.Drawing.Point(240, 48)
        Me.cmdSI.Name = "cmdSI"
        Me.cmdSI.Size = New System.Drawing.Size(40, 22)
        Me.cmdSI.TabIndex = 13
        Me.cmdSI.Text = "S+I"
        Me.cmdSI.UseVisualStyleBackColor = True
        '
        'cmdLicznik
        '
        Me.cmdLicznik.Location = New System.Drawing.Point(176, 80)
        Me.cmdLicznik.Name = "cmdLicznik"
        Me.cmdLicznik.Size = New System.Drawing.Size(112, 22)
        Me.cmdLicznik.TabIndex = 14
        Me.cmdLicznik.Text = "Kliknij"
        Me.cmdLicznik.UseVisualStyleBackColor = True
        '
        'cmdStruktura
        '
        Me.cmdStruktura.Location = New System.Drawing.Point(128, 80)
        Me.cmdStruktura.Name = "cmdStruktura"
        Me.cmdStruktura.Size = New System.Drawing.Size(40, 22)
        Me.cmdStruktura.TabIndex = 15
        Me.cmdStruktura.Text = "Typ"
        Me.cmdStruktura.UseVisualStyleBackColor = True
        '
        'CmdTablica1
        '
        Me.CmdTablica1.Location = New System.Drawing.Point(128, 112)
        Me.CmdTablica1.Name = "CmdTablica1"
        Me.CmdTablica1.Size = New System.Drawing.Size(72, 22)
        Me.CmdTablica1.TabIndex = 16
        Me.CmdTablica1.Text = "Tablica 1W"
        Me.CmdTablica1.UseVisualStyleBackColor = True
        '
        'cmdTablica2
        '
        Me.cmdTablica2.Location = New System.Drawing.Point(216, 112)
        Me.cmdTablica2.Name = "cmdTablica2"
        Me.cmdTablica2.Size = New System.Drawing.Size(72, 22)
        Me.cmdTablica2.TabIndex = 17
        Me.cmdTablica2.Text = "Tablica 2W"
        Me.cmdTablica2.UseVisualStyleBackColor = True
        '
        'frmZmienne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 212)
        Me.Controls.Add(Me.cmdTablica2)
        Me.Controls.Add(Me.CmdTablica1)
        Me.Controls.Add(Me.cmdStruktura)
        Me.Controls.Add(Me.cmdLicznik)
        Me.Controls.Add(Me.cmdSI)
        Me.Controls.Add(Me.cmdSS)
        Me.Controls.Add(Me.txtImie)
        Me.Controls.Add(Me.cmdOrElse)
        Me.Controls.Add(Me.cmdAnd)
        Me.Controls.Add(Me.cmdModulo)
        Me.Controls.Add(Me.cmdWieksza)
        Me.Controls.Add(Me.cmdRozne)
        Me.Controls.Add(Me.cmdGodziny)
        Me.Controls.Add(Me.cmdVat)
        Me.Controls.Add(Me.cmdPomnoz)
        Me.Controls.Add(Me.lblWynik)
        Me.Controls.Add(Me.txtDrugaLiczba)
        Me.Controls.Add(Me.txtPierwszaLiczba)
        Me.Location = New System.Drawing.Point(16, 168)
        Me.Name = "frmZmienne"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Poznajemy zmienne"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPierwszaLiczba As System.Windows.Forms.TextBox
    Friend WithEvents txtDrugaLiczba As System.Windows.Forms.TextBox
    Friend WithEvents lblWynik As System.Windows.Forms.Label
    Friend WithEvents cmdPomnoz As System.Windows.Forms.Button
    Friend WithEvents cmdVat As System.Windows.Forms.Button
    Friend WithEvents cmdGodziny As System.Windows.Forms.Button
    Friend WithEvents cmdRozne As System.Windows.Forms.Button
    Friend WithEvents cmdWieksza As System.Windows.Forms.Button
    Friend WithEvents cmdModulo As System.Windows.Forms.Button
    Friend WithEvents cmdAnd As System.Windows.Forms.Button
    Friend WithEvents cmdOrElse As System.Windows.Forms.Button
    Friend WithEvents txtImie As System.Windows.Forms.TextBox
    Friend WithEvents cmdSS As System.Windows.Forms.Button
    Friend WithEvents cmdSI As System.Windows.Forms.Button
    Friend WithEvents cmdLicznik As System.Windows.Forms.Button
    Friend WithEvents cmdStruktura As System.Windows.Forms.Button
    Friend WithEvents CmdTablica1 As System.Windows.Forms.Button
    Friend WithEvents cmdTablica2 As System.Windows.Forms.Button

End Class
