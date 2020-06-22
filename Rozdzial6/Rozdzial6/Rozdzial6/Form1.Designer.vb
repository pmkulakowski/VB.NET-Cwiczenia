<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKlasy
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
        Me.frmT1 = New System.Windows.Forms.GroupBox()
        Me.cmdT1Vat = New System.Windows.Forms.Button()
        Me.lblT1Podatek = New System.Windows.Forms.Label()
        Me.txtT1Cena = New System.Windows.Forms.TextBox()
        Me.txtT1Nazwa = New System.Windows.Forms.TextBox()
        Me.frmT2 = New System.Windows.Forms.GroupBox()
        Me.cmdT2Vat = New System.Windows.Forms.Button()
        Me.lblT2Podatek = New System.Windows.Forms.Label()
        Me.txtT2Cena = New System.Windows.Forms.TextBox()
        Me.txtT2Nazwa = New System.Windows.Forms.TextBox()
        Me.frmZ = New System.Windows.Forms.GroupBox()
        Me.cmdZVat = New System.Windows.Forms.Button()
        Me.lblZPodatek = New System.Windows.Forms.Label()
        Me.txtZNazwa = New System.Windows.Forms.TextBox()
        Me.txtZGatunek = New System.Windows.Forms.TextBox()
        Me.frmT1.SuspendLayout()
        Me.frmT2.SuspendLayout()
        Me.frmZ.SuspendLayout()
        Me.SuspendLayout()
        '
        'frmT1
        '
        Me.frmT1.Controls.Add(Me.cmdT1Vat)
        Me.frmT1.Controls.Add(Me.lblT1Podatek)
        Me.frmT1.Controls.Add(Me.txtT1Cena)
        Me.frmT1.Controls.Add(Me.txtT1Nazwa)
        Me.frmT1.Location = New System.Drawing.Point(16, 16)
        Me.frmT1.Name = "frmT1"
        Me.frmT1.Size = New System.Drawing.Size(208, 176)
        Me.frmT1.TabIndex = 0
        Me.frmT1.TabStop = False
        Me.frmT1.Text = "Pierwszy towar"
        '
        'cmdT1Vat
        '
        Me.cmdT1Vat.Location = New System.Drawing.Point(16, 104)
        Me.cmdT1Vat.Name = "cmdT1Vat"
        Me.cmdT1Vat.Size = New System.Drawing.Size(176, 24)
        Me.cmdT1Vat.TabIndex = 3
        Me.cmdT1Vat.Text = "Wylicz VAT"
        Me.cmdT1Vat.UseVisualStyleBackColor = True
        '
        'lblT1Podatek
        '
        Me.lblT1Podatek.AutoSize = True
        Me.lblT1Podatek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblT1Podatek.Location = New System.Drawing.Point(16, 64)
        Me.lblT1Podatek.MinimumSize = New System.Drawing.Size(176, 20)
        Me.lblT1Podatek.Name = "lblT1Podatek"
        Me.lblT1Podatek.Size = New System.Drawing.Size(176, 20)
        Me.lblT1Podatek.TabIndex = 2
        '
        'txtT1Cena
        '
        Me.txtT1Cena.Location = New System.Drawing.Point(16, 40)
        Me.txtT1Cena.Name = "txtT1Cena"
        Me.txtT1Cena.Size = New System.Drawing.Size(176, 20)
        Me.txtT1Cena.TabIndex = 1
        '
        'txtT1Nazwa
        '
        Me.txtT1Nazwa.Location = New System.Drawing.Point(16, 16)
        Me.txtT1Nazwa.Name = "txtT1Nazwa"
        Me.txtT1Nazwa.Size = New System.Drawing.Size(176, 20)
        Me.txtT1Nazwa.TabIndex = 0
        '
        'frmT2
        '
        Me.frmT2.Controls.Add(Me.cmdT2Vat)
        Me.frmT2.Controls.Add(Me.lblT2Podatek)
        Me.frmT2.Controls.Add(Me.txtT2Cena)
        Me.frmT2.Controls.Add(Me.txtT2Nazwa)
        Me.frmT2.Location = New System.Drawing.Point(248, 16)
        Me.frmT2.Name = "frmT2"
        Me.frmT2.Size = New System.Drawing.Size(208, 176)
        Me.frmT2.TabIndex = 1
        Me.frmT2.TabStop = False
        Me.frmT2.Text = "Drugi towar"
        '
        'cmdT2Vat
        '
        Me.cmdT2Vat.Location = New System.Drawing.Point(16, 104)
        Me.cmdT2Vat.Name = "cmdT2Vat"
        Me.cmdT2Vat.Size = New System.Drawing.Size(176, 24)
        Me.cmdT2Vat.TabIndex = 3
        Me.cmdT2Vat.Text = "Wylicz VAT"
        Me.cmdT2Vat.UseVisualStyleBackColor = True
        '
        'lblT2Podatek
        '
        Me.lblT2Podatek.AutoSize = True
        Me.lblT2Podatek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblT2Podatek.Location = New System.Drawing.Point(16, 64)
        Me.lblT2Podatek.MinimumSize = New System.Drawing.Size(176, 20)
        Me.lblT2Podatek.Name = "lblT2Podatek"
        Me.lblT2Podatek.Size = New System.Drawing.Size(176, 20)
        Me.lblT2Podatek.TabIndex = 2
        '
        'txtT2Cena
        '
        Me.txtT2Cena.Location = New System.Drawing.Point(16, 40)
        Me.txtT2Cena.Name = "txtT2Cena"
        Me.txtT2Cena.Size = New System.Drawing.Size(176, 20)
        Me.txtT2Cena.TabIndex = 1
        '
        'txtT2Nazwa
        '
        Me.txtT2Nazwa.Location = New System.Drawing.Point(16, 16)
        Me.txtT2Nazwa.Name = "txtT2Nazwa"
        Me.txtT2Nazwa.Size = New System.Drawing.Size(176, 20)
        Me.txtT2Nazwa.TabIndex = 0
        '
        'frmZ
        '
        Me.frmZ.Controls.Add(Me.cmdZVat)
        Me.frmZ.Controls.Add(Me.lblZPodatek)
        Me.frmZ.Controls.Add(Me.txtZNazwa)
        Me.frmZ.Controls.Add(Me.txtZGatunek)
        Me.frmZ.Location = New System.Drawing.Point(480, 16)
        Me.frmZ.Name = "frmZ"
        Me.frmZ.Size = New System.Drawing.Size(208, 176)
        Me.frmZ.TabIndex = 4
        Me.frmZ.TabStop = False
        Me.frmZ.Text = "Zwierze"
        '
        'cmdZVat
        '
        Me.cmdZVat.Location = New System.Drawing.Point(16, 104)
        Me.cmdZVat.Name = "cmdZVat"
        Me.cmdZVat.Size = New System.Drawing.Size(176, 24)
        Me.cmdZVat.TabIndex = 3
        Me.cmdZVat.Text = "Wylicz VAT"
        Me.cmdZVat.UseVisualStyleBackColor = True
        '
        'lblZPodatek
        '
        Me.lblZPodatek.AutoSize = True
        Me.lblZPodatek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblZPodatek.Location = New System.Drawing.Point(16, 64)
        Me.lblZPodatek.MinimumSize = New System.Drawing.Size(176, 20)
        Me.lblZPodatek.Name = "lblZPodatek"
        Me.lblZPodatek.Size = New System.Drawing.Size(176, 20)
        Me.lblZPodatek.TabIndex = 2
        '
        'txtZNazwa
        '
        Me.txtZNazwa.Location = New System.Drawing.Point(16, 40)
        Me.txtZNazwa.Name = "txtZNazwa"
        Me.txtZNazwa.Size = New System.Drawing.Size(176, 20)
        Me.txtZNazwa.TabIndex = 1
        '
        'txtZGatunek
        '
        Me.txtZGatunek.Location = New System.Drawing.Point(16, 16)
        Me.txtZGatunek.Name = "txtZGatunek"
        Me.txtZGatunek.Size = New System.Drawing.Size(176, 20)
        Me.txtZGatunek.TabIndex = 0
        '
        'frmKlasy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 201)
        Me.Controls.Add(Me.frmZ)
        Me.Controls.Add(Me.frmT2)
        Me.Controls.Add(Me.frmT1)
        Me.Name = "frmKlasy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programowanie zorientowane obiektowo"
        Me.frmT1.ResumeLayout(False)
        Me.frmT1.PerformLayout()
        Me.frmT2.ResumeLayout(False)
        Me.frmT2.PerformLayout()
        Me.frmZ.ResumeLayout(False)
        Me.frmZ.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frmT1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdT1Vat As System.Windows.Forms.Button
    Friend WithEvents lblT1Podatek As System.Windows.Forms.Label
    Friend WithEvents txtT1Cena As System.Windows.Forms.TextBox
    Friend WithEvents txtT1Nazwa As System.Windows.Forms.TextBox
    Friend WithEvents frmT2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdT2Vat As System.Windows.Forms.Button
    Friend WithEvents lblT2Podatek As System.Windows.Forms.Label
    Friend WithEvents txtT2Cena As System.Windows.Forms.TextBox
    Friend WithEvents txtT2Nazwa As System.Windows.Forms.TextBox
    Friend WithEvents frmZ As System.Windows.Forms.GroupBox
    Friend WithEvents cmdZVat As System.Windows.Forms.Button
    Friend WithEvents lblZPodatek As System.Windows.Forms.Label
    Friend WithEvents txtZNazwa As System.Windows.Forms.TextBox
    Friend WithEvents txtZGatunek As System.Windows.Forms.TextBox

End Class
