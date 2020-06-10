<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstrukcjeWarunkowe
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
        Me.cmdTest = New System.Windows.Forms.Button()
        Me.frmPoziom = New System.Windows.Forms.GroupBox()
        Me.optPoziom4 = New System.Windows.Forms.RadioButton()
        Me.optPoziom3 = New System.Windows.Forms.RadioButton()
        Me.optPoziom2 = New System.Windows.Forms.RadioButton()
        Me.optPoziom1 = New System.Windows.Forms.RadioButton()
        Me.lblTabliczbaMnozenia = New System.Windows.Forms.Label()
        Me.cmdKoniec = New System.Windows.Forms.Button()
        Me.lblUzytkownik = New System.Windows.Forms.Label()
        Me.lstUzytkownicy = New System.Windows.Forms.ListBox()
        Me.cmdUsun = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.frmPoziom.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdTest
        '
        Me.cmdTest.Location = New System.Drawing.Point(8, 8)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.Size = New System.Drawing.Size(96, 40)
        Me.cmdTest.TabIndex = 0
        Me.cmdTest.Text = "Zadaj pytanie"
        Me.cmdTest.UseVisualStyleBackColor = True
        '
        'frmPoziom
        '
        Me.frmPoziom.Controls.Add(Me.optPoziom4)
        Me.frmPoziom.Controls.Add(Me.optPoziom3)
        Me.frmPoziom.Controls.Add(Me.optPoziom2)
        Me.frmPoziom.Controls.Add(Me.optPoziom1)
        Me.frmPoziom.Location = New System.Drawing.Point(8, 64)
        Me.frmPoziom.Name = "frmPoziom"
        Me.frmPoziom.Size = New System.Drawing.Size(112, 168)
        Me.frmPoziom.TabIndex = 1
        Me.frmPoziom.TabStop = False
        Me.frmPoziom.Text = "Poziom trudności"
        '
        'optPoziom4
        '
        Me.optPoziom4.AutoSize = True
        Me.optPoziom4.Location = New System.Drawing.Point(8, 118)
        Me.optPoziom4.Name = "optPoziom4"
        Me.optPoziom4.Size = New System.Drawing.Size(78, 17)
        Me.optPoziom4.TabIndex = 3
        Me.optPoziom4.TabStop = True
        Me.optPoziom4.Text = "Trudniejszy"
        Me.optPoziom4.UseVisualStyleBackColor = True
        '
        'optPoziom3
        '
        Me.optPoziom3.AutoSize = True
        Me.optPoziom3.Location = New System.Drawing.Point(8, 84)
        Me.optPoziom3.Name = "optPoziom3"
        Me.optPoziom3.Size = New System.Drawing.Size(58, 17)
        Me.optPoziom3.TabIndex = 2
        Me.optPoziom3.TabStop = True
        Me.optPoziom3.Text = "Trudny"
        Me.optPoziom3.UseVisualStyleBackColor = True
        '
        'optPoziom2
        '
        Me.optPoziom2.AutoSize = True
        Me.optPoziom2.Location = New System.Drawing.Point(8, 50)
        Me.optPoziom2.Name = "optPoziom2"
        Me.optPoziom2.Size = New System.Drawing.Size(85, 17)
        Me.optPoziom2.TabIndex = 1
        Me.optPoziom2.TabStop = True
        Me.optPoziom2.Text = "Podstawowy"
        Me.optPoziom2.UseVisualStyleBackColor = True
        '
        'optPoziom1
        '
        Me.optPoziom1.AutoSize = True
        Me.optPoziom1.Location = New System.Drawing.Point(8, 16)
        Me.optPoziom1.Name = "optPoziom1"
        Me.optPoziom1.Size = New System.Drawing.Size(54, 17)
        Me.optPoziom1.TabIndex = 0
        Me.optPoziom1.TabStop = True
        Me.optPoziom1.Text = "Łatwy"
        Me.optPoziom1.UseVisualStyleBackColor = True
        '
        'lblTabliczbaMnozenia
        '
        Me.lblTabliczbaMnozenia.AutoSize = True
        Me.lblTabliczbaMnozenia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTabliczbaMnozenia.Location = New System.Drawing.Point(128, 72)
        Me.lblTabliczbaMnozenia.MinimumSize = New System.Drawing.Size(168, 128)
        Me.lblTabliczbaMnozenia.Name = "lblTabliczbaMnozenia"
        Me.lblTabliczbaMnozenia.Size = New System.Drawing.Size(168, 128)
        Me.lblTabliczbaMnozenia.TabIndex = 2
        '
        'cmdKoniec
        '
        Me.cmdKoniec.Location = New System.Drawing.Point(8, 248)
        Me.cmdKoniec.Name = "cmdKoniec"
        Me.cmdKoniec.Size = New System.Drawing.Size(96, 40)
        Me.cmdKoniec.TabIndex = 3
        Me.cmdKoniec.Text = "Koniec testu"
        Me.cmdKoniec.UseVisualStyleBackColor = True
        '
        'lblUzytkownik
        '
        Me.lblUzytkownik.AutoSize = True
        Me.lblUzytkownik.Location = New System.Drawing.Point(120, 8)
        Me.lblUzytkownik.MinimumSize = New System.Drawing.Size(144, 40)
        Me.lblUzytkownik.Name = "lblUzytkownik"
        Me.lblUzytkownik.Size = New System.Drawing.Size(144, 40)
        Me.lblUzytkownik.TabIndex = 4
        Me.lblUzytkownik.Text = "Użytkownik: Anonim"
        Me.lblUzytkownik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstUzytkownicy
        '
        Me.lstUzytkownicy.FormattingEnabled = True
        Me.lstUzytkownicy.Items.AddRange(New Object() {"Adam", "Heniek", "Paweł", "Przemek", "Tadeusz"})
        Me.lstUzytkownicy.Location = New System.Drawing.Point(312, 16)
        Me.lstUzytkownicy.Name = "lstUzytkownicy"
        Me.lstUzytkownicy.Size = New System.Drawing.Size(152, 264)
        Me.lstUzytkownicy.Sorted = True
        Me.lstUzytkownicy.TabIndex = 5
        '
        'cmdUsun
        '
        Me.cmdUsun.Location = New System.Drawing.Point(128, 240)
        Me.cmdUsun.Name = "cmdUsun"
        Me.cmdUsun.Size = New System.Drawing.Size(80, 40)
        Me.cmdUsun.TabIndex = 6
        Me.cmdUsun.Text = "Usuń użytkownia"
        Me.cmdUsun.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(216, 240)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Dodaj użytkownika"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmInstrukcjeWarunkowe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 297)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdUsun)
        Me.Controls.Add(Me.lstUzytkownicy)
        Me.Controls.Add(Me.lblUzytkownik)
        Me.Controls.Add(Me.cmdKoniec)
        Me.Controls.Add(Me.lblTabliczbaMnozenia)
        Me.Controls.Add(Me.frmPoziom)
        Me.Controls.Add(Me.cmdTest)
        Me.Name = "frmInstrukcjeWarunkowe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.frmPoziom.ResumeLayout(False)
        Me.frmPoziom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdTest As System.Windows.Forms.Button
    Friend WithEvents frmPoziom As System.Windows.Forms.GroupBox
    Friend WithEvents optPoziom4 As System.Windows.Forms.RadioButton
    Friend WithEvents optPoziom3 As System.Windows.Forms.RadioButton
    Friend WithEvents optPoziom2 As System.Windows.Forms.RadioButton
    Friend WithEvents optPoziom1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblTabliczbaMnozenia As System.Windows.Forms.Label
    Friend WithEvents cmdKoniec As System.Windows.Forms.Button
    Friend WithEvents lblUzytkownik As System.Windows.Forms.Label
    Friend WithEvents lstUzytkownicy As System.Windows.Forms.ListBox
    Friend WithEvents cmdUsun As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
