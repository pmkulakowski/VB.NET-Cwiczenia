<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
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
        Me.lblKursor = New System.Windows.Forms.Label()
        Me.txtEtykieta = New System.Windows.Forms.TextBox()
        Me.cmdWyswietl = New System.Windows.Forms.Button()
        Me.cmdUkryj = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblKursor
        '
        Me.lblKursor.AutoSize = True
        Me.lblKursor.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblKursor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKursor.Location = New System.Drawing.Point(151, 45)
        Me.lblKursor.MinimumSize = New System.Drawing.Size(100, 20)
        Me.lblKursor.Name = "lblKursor"
        Me.lblKursor.Size = New System.Drawing.Size(100, 20)
        Me.lblKursor.TabIndex = 0
        '
        'txtEtykieta
        '
        Me.txtEtykieta.Location = New System.Drawing.Point(24, 45)
        Me.txtEtykieta.Name = "txtEtykieta"
        Me.txtEtykieta.Size = New System.Drawing.Size(100, 20)
        Me.txtEtykieta.TabIndex = 1
        Me.txtEtykieta.Text = "Drugi formularz"
        '
        'cmdWyswietl
        '
        Me.cmdWyswietl.Location = New System.Drawing.Point(24, 81)
        Me.cmdWyswietl.Name = "cmdWyswietl"
        Me.cmdWyswietl.Size = New System.Drawing.Size(75, 23)
        Me.cmdWyswietl.TabIndex = 2
        Me.cmdWyswietl.Text = "Wyswietl"
        Me.cmdWyswietl.UseVisualStyleBackColor = True
        '
        'cmdUkryj
        '
        Me.cmdUkryj.Location = New System.Drawing.Point(151, 81)
        Me.cmdUkryj.Name = "cmdUkryj"
        Me.cmdUkryj.Size = New System.Drawing.Size(75, 23)
        Me.cmdUkryj.TabIndex = 3
        Me.cmdUkryj.Text = "Pokaz/Ukryj"
        Me.cmdUkryj.UseVisualStyleBackColor = True
        '
        'frmStart
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(286, 291)
        Me.Controls.Add(Me.cmdUkryj)
        Me.Controls.Add(Me.cmdWyswietl)
        Me.Controls.Add(Me.txtEtykieta)
        Me.Controls.Add(Me.lblKursor)
        Me.Name = "frmStart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Witaj"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblKursor As System.Windows.Forms.Label
    Friend WithEvents txtEtykieta As System.Windows.Forms.TextBox
    Friend WithEvents cmdWyswietl As System.Windows.Forms.Button
    Friend WithEvents cmdUkryj As System.Windows.Forms.Button

End Class
