<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmZdarzenia
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
        Me.lblZdarzenia = New System.Windows.Forms.Label()
        Me.cmbPrzycisk = New System.Windows.Forms.Button()
        Me.txtTekst = New System.Windows.Forms.TextBox()
        Me.chkWybor = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblZdarzenia
        '
        Me.lblZdarzenia.AutoSize = True
        Me.lblZdarzenia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblZdarzenia.Location = New System.Drawing.Point(65, 62)
        Me.lblZdarzenia.MinimumSize = New System.Drawing.Size(120, 20)
        Me.lblZdarzenia.Name = "lblZdarzenia"
        Me.lblZdarzenia.Size = New System.Drawing.Size(120, 20)
        Me.lblZdarzenia.TabIndex = 0
        '
        'cmbPrzycisk
        '
        Me.cmbPrzycisk.Location = New System.Drawing.Point(65, 138)
        Me.cmbPrzycisk.Name = "cmbPrzycisk"
        Me.cmbPrzycisk.Size = New System.Drawing.Size(75, 23)
        Me.cmbPrzycisk.TabIndex = 1
        Me.cmbPrzycisk.Text = "Poleć"
        Me.cmbPrzycisk.UseVisualStyleBackColor = True
        '
        'txtTekst
        '
        Me.txtTekst.Location = New System.Drawing.Point(65, 89)
        Me.txtTekst.Name = "txtTekst"
        Me.txtTekst.Size = New System.Drawing.Size(120, 20)
        Me.txtTekst.TabIndex = 2
        Me.txtTekst.Text = "Pole tekstowe"
        '
        'chkWybor
        '
        Me.chkWybor.AutoSize = True
        Me.chkWybor.Location = New System.Drawing.Point(65, 115)
        Me.chkWybor.Name = "chkWybor"
        Me.chkWybor.Size = New System.Drawing.Size(84, 17)
        Me.chkWybor.TabIndex = 3
        Me.chkWybor.Text = "Pole wyboru"
        Me.chkWybor.UseVisualStyleBackColor = True
        '
        'frmZdarzenia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.chkWybor)
        Me.Controls.Add(Me.txtTekst)
        Me.Controls.Add(Me.cmbPrzycisk)
        Me.Controls.Add(Me.lblZdarzenia)
        Me.Name = "frmZdarzenia"
        Me.Text = "Przechwytujemy zdarzenia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblZdarzenia As System.Windows.Forms.Label
    Friend WithEvents cmbPrzycisk As System.Windows.Forms.Button
    Friend WithEvents txtTekst As System.Windows.Forms.TextBox
    Friend WithEvents chkWybor As System.Windows.Forms.CheckBox
End Class
