<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBledy
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
        Me.cmdSilnia = New System.Windows.Forms.Button()
        Me.cmdOtworz = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdSilnia
        '
        Me.cmdSilnia.Location = New System.Drawing.Point(16, 16)
        Me.cmdSilnia.Name = "cmdSilnia"
        Me.cmdSilnia.Size = New System.Drawing.Size(75, 23)
        Me.cmdSilnia.TabIndex = 0
        Me.cmdSilnia.Text = "Silnia"
        Me.cmdSilnia.UseVisualStyleBackColor = True
        '
        'cmdOtworz
        '
        Me.cmdOtworz.Location = New System.Drawing.Point(154, 16)
        Me.cmdOtworz.Name = "cmdOtworz"
        Me.cmdOtworz.Size = New System.Drawing.Size(75, 23)
        Me.cmdOtworz.TabIndex = 1
        Me.cmdOtworz.Text = "Otwórz"
        Me.cmdOtworz.UseVisualStyleBackColor = True
        '
        'frmBledy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 73)
        Me.Controls.Add(Me.cmdOtworz)
        Me.Controls.Add(Me.cmdSilnia)
        Me.Name = "frmBledy"
        Me.Text = "Wyszukujemy i przechwytujemy błędy"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSilnia As System.Windows.Forms.Button
    Friend WithEvents cmdOtworz As System.Windows.Forms.Button

End Class
