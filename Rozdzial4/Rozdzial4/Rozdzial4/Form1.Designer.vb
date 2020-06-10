<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcedury
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
        Me.txtParametr = New System.Windows.Forms.TextBox()
        Me.lblWartoscPoczatkowa = New System.Windows.Forms.Label()
        Me.frmProcedura = New System.Windows.Forms.GroupBox()
        Me.lblWartoscKoncowa = New System.Windows.Forms.Label()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.frmOpcjonalne = New System.Windows.Forms.GroupBox()
        Me.lblWysokosc = New System.Windows.Forms.Label()
        Me.cmdZmiana = New System.Windows.Forms.Button()
        Me.frmFunkcjaKonwersji = New System.Windows.Forms.GroupBox()
        Me.lblMile = New System.Windows.Forms.Label()
        Me.cmdKonwersja = New System.Windows.Forms.Button()
        Me.frmProcedura.SuspendLayout()
        Me.frmOpcjonalne.SuspendLayout()
        Me.frmFunkcjaKonwersji.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtParametr
        '
        Me.txtParametr.Location = New System.Drawing.Point(16, 8)
        Me.txtParametr.Name = "txtParametr"
        Me.txtParametr.Size = New System.Drawing.Size(88, 20)
        Me.txtParametr.TabIndex = 0
        Me.txtParametr.Text = "500"
        '
        'lblWartoscPoczatkowa
        '
        Me.lblWartoscPoczatkowa.AutoSize = True
        Me.lblWartoscPoczatkowa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWartoscPoczatkowa.Location = New System.Drawing.Point(16, 40)
        Me.lblWartoscPoczatkowa.MinimumSize = New System.Drawing.Size(88, 20)
        Me.lblWartoscPoczatkowa.Name = "lblWartoscPoczatkowa"
        Me.lblWartoscPoczatkowa.Size = New System.Drawing.Size(88, 20)
        Me.lblWartoscPoczatkowa.TabIndex = 1
        '
        'frmProcedura
        '
        Me.frmProcedura.Controls.Add(Me.lblWartoscKoncowa)
        Me.frmProcedura.Controls.Add(Me.cmdStart)
        Me.frmProcedura.Location = New System.Drawing.Point(16, 80)
        Me.frmProcedura.Name = "frmProcedura"
        Me.frmProcedura.Size = New System.Drawing.Size(136, 96)
        Me.frmProcedura.TabIndex = 2
        Me.frmProcedura.TabStop = False
        Me.frmProcedura.Text = "Procedura Potęga"
        '
        'lblWartoscKoncowa
        '
        Me.lblWartoscKoncowa.AutoSize = True
        Me.lblWartoscKoncowa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWartoscKoncowa.Location = New System.Drawing.Point(8, 56)
        Me.lblWartoscKoncowa.MinimumSize = New System.Drawing.Size(112, 20)
        Me.lblWartoscKoncowa.Name = "lblWartoscKoncowa"
        Me.lblWartoscKoncowa.Size = New System.Drawing.Size(112, 20)
        Me.lblWartoscKoncowa.TabIndex = 1
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(8, 24)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(112, 20)
        Me.cmdStart.TabIndex = 0
        Me.cmdStart.Text = "Wywołaj porcedurę"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'frmOpcjonalne
        '
        Me.frmOpcjonalne.Controls.Add(Me.lblWysokosc)
        Me.frmOpcjonalne.Controls.Add(Me.cmdZmiana)
        Me.frmOpcjonalne.Location = New System.Drawing.Point(158, 80)
        Me.frmOpcjonalne.Name = "frmOpcjonalne"
        Me.frmOpcjonalne.Size = New System.Drawing.Size(136, 96)
        Me.frmOpcjonalne.TabIndex = 3
        Me.frmOpcjonalne.TabStop = False
        Me.frmOpcjonalne.Text = "Parametry opcjonalne"
        '
        'lblWysokosc
        '
        Me.lblWysokosc.AutoSize = True
        Me.lblWysokosc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWysokosc.Location = New System.Drawing.Point(8, 56)
        Me.lblWysokosc.MinimumSize = New System.Drawing.Size(112, 20)
        Me.lblWysokosc.Name = "lblWysokosc"
        Me.lblWysokosc.Size = New System.Drawing.Size(112, 20)
        Me.lblWysokosc.TabIndex = 1
        '
        'cmdZmiana
        '
        Me.cmdZmiana.Location = New System.Drawing.Point(6, 24)
        Me.cmdZmiana.Name = "cmdZmiana"
        Me.cmdZmiana.Size = New System.Drawing.Size(114, 20)
        Me.cmdZmiana.TabIndex = 0
        Me.cmdZmiana.Text = "Zmień rozmiar"
        Me.cmdZmiana.UseVisualStyleBackColor = True
        '
        'frmFunkcjaKonwersji
        '
        Me.frmFunkcjaKonwersji.Controls.Add(Me.lblMile)
        Me.frmFunkcjaKonwersji.Controls.Add(Me.cmdKonwersja)
        Me.frmFunkcjaKonwersji.Location = New System.Drawing.Point(300, 80)
        Me.frmFunkcjaKonwersji.Name = "frmFunkcjaKonwersji"
        Me.frmFunkcjaKonwersji.Size = New System.Drawing.Size(136, 96)
        Me.frmFunkcjaKonwersji.TabIndex = 3
        Me.frmFunkcjaKonwersji.TabStop = False
        Me.frmFunkcjaKonwersji.Text = "Funkcja km > mile"
        '
        'lblMile
        '
        Me.lblMile.AutoSize = True
        Me.lblMile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMile.Location = New System.Drawing.Point(8, 56)
        Me.lblMile.MinimumSize = New System.Drawing.Size(112, 20)
        Me.lblMile.Name = "lblMile"
        Me.lblMile.Size = New System.Drawing.Size(112, 20)
        Me.lblMile.TabIndex = 1
        Me.lblMile.Text = "Przelicz km na mile"
        '
        'cmdKonwersja
        '
        Me.cmdKonwersja.Location = New System.Drawing.Point(8, 24)
        Me.cmdKonwersja.Name = "cmdKonwersja"
        Me.cmdKonwersja.Size = New System.Drawing.Size(112, 20)
        Me.cmdKonwersja.TabIndex = 0
        Me.cmdKonwersja.Text = "Przelicz km a mile"
        Me.cmdKonwersja.UseVisualStyleBackColor = True
        '
        'frmProcedury
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 257)
        Me.Controls.Add(Me.frmFunkcjaKonwersji)
        Me.Controls.Add(Me.frmOpcjonalne)
        Me.Controls.Add(Me.frmProcedura)
        Me.Controls.Add(Me.lblWartoscPoczatkowa)
        Me.Controls.Add(Me.txtParametr)
        Me.Name = "frmProcedury"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Poznajemy procedury i funkcje"
        Me.frmProcedura.ResumeLayout(False)
        Me.frmProcedura.PerformLayout()
        Me.frmOpcjonalne.ResumeLayout(False)
        Me.frmOpcjonalne.PerformLayout()
        Me.frmFunkcjaKonwersji.ResumeLayout(False)
        Me.frmFunkcjaKonwersji.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtParametr As System.Windows.Forms.TextBox
    Friend WithEvents lblWartoscPoczatkowa As System.Windows.Forms.Label
    Friend WithEvents frmProcedura As System.Windows.Forms.GroupBox
    Friend WithEvents lblWartoscKoncowa As System.Windows.Forms.Label
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents frmOpcjonalne As System.Windows.Forms.GroupBox
    Friend WithEvents lblWysokosc As System.Windows.Forms.Label
    Friend WithEvents cmdZmiana As System.Windows.Forms.Button
    Friend WithEvents frmFunkcjaKonwersji As System.Windows.Forms.GroupBox
    Friend WithEvents lblMile As System.Windows.Forms.Label
    Friend WithEvents cmdKonwersja As System.Windows.Forms.Button

End Class
