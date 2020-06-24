<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDane
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
        Me.cmdPolacz = New System.Windows.Forms.Button()
        Me.lstKategorie = New System.Windows.Forms.ListBox()
        Me.lblKategorii = New System.Windows.Forms.Label()
        Me.cmdDodaj = New System.Windows.Forms.Button()
        Me.cmdUsun = New System.Windows.Forms.Button()
        Me.frmPracownicy = New System.Windows.Forms.GroupBox()
        Me.cmdPZapisz = New System.Windows.Forms.Button()
        Me.cmdPUsun = New System.Windows.Forms.Button()
        Me.cmdPDodaj = New System.Windows.Forms.Button()
        Me.lblRekord = New System.Windows.Forms.Label()
        Me.cmdOstatni = New System.Windows.Forms.Button()
        Me.cmdNastepny = New System.Windows.Forms.Button()
        Me.cmdPoprzedni = New System.Windows.Forms.Button()
        Me.cmdPierwszy = New System.Windows.Forms.Button()
        Me.txtNazwisko = New System.Windows.Forms.TextBox()
        Me.txtImie = New System.Windows.Forms.TextBox()
        Me.cmdPPolacz = New System.Windows.Forms.Button()
        Me.cmdPobierz = New System.Windows.Forms.Button()
        Me.cmdOtworz = New System.Windows.Forms.Button()
        Me.lblProdukty = New System.Windows.Forms.Label()
        Me.frmPracownicy.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdPolacz
        '
        Me.cmdPolacz.Location = New System.Drawing.Point(16, 8)
        Me.cmdPolacz.Name = "cmdPolacz"
        Me.cmdPolacz.Size = New System.Drawing.Size(80, 24)
        Me.cmdPolacz.TabIndex = 0
        Me.cmdPolacz.Text = "Połącz"
        Me.cmdPolacz.UseVisualStyleBackColor = True
        '
        'lstKategorie
        '
        Me.lstKategorie.FormattingEnabled = True
        Me.lstKategorie.Location = New System.Drawing.Point(16, 64)
        Me.lstKategorie.Name = "lstKategorie"
        Me.lstKategorie.Size = New System.Drawing.Size(104, 134)
        Me.lstKategorie.TabIndex = 1
        '
        'lblKategorii
        '
        Me.lblKategorii.AutoSize = True
        Me.lblKategorii.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKategorii.Location = New System.Drawing.Point(16, 208)
        Me.lblKategorii.MinimumSize = New System.Drawing.Size(104, 40)
        Me.lblKategorii.Name = "lblKategorii"
        Me.lblKategorii.Size = New System.Drawing.Size(104, 40)
        Me.lblKategorii.TabIndex = 2
        Me.lblKategorii.Text = "Liczba kategorii: "
        Me.lblKategorii.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdDodaj
        '
        Me.cmdDodaj.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cmdDodaj.Location = New System.Drawing.Point(136, 72)
        Me.cmdDodaj.Name = "cmdDodaj"
        Me.cmdDodaj.Size = New System.Drawing.Size(32, 32)
        Me.cmdDodaj.TabIndex = 3
        Me.cmdDodaj.Text = "+"
        Me.cmdDodaj.UseVisualStyleBackColor = True
        '
        'cmdUsun
        '
        Me.cmdUsun.Location = New System.Drawing.Point(136, 120)
        Me.cmdUsun.Name = "cmdUsun"
        Me.cmdUsun.Size = New System.Drawing.Size(32, 32)
        Me.cmdUsun.TabIndex = 4
        Me.cmdUsun.Text = "-"
        Me.cmdUsun.UseVisualStyleBackColor = True
        '
        'frmPracownicy
        '
        Me.frmPracownicy.Controls.Add(Me.cmdPZapisz)
        Me.frmPracownicy.Controls.Add(Me.cmdPUsun)
        Me.frmPracownicy.Controls.Add(Me.cmdPDodaj)
        Me.frmPracownicy.Controls.Add(Me.lblRekord)
        Me.frmPracownicy.Controls.Add(Me.cmdOstatni)
        Me.frmPracownicy.Controls.Add(Me.cmdNastepny)
        Me.frmPracownicy.Controls.Add(Me.cmdPoprzedni)
        Me.frmPracownicy.Controls.Add(Me.cmdPierwszy)
        Me.frmPracownicy.Controls.Add(Me.txtNazwisko)
        Me.frmPracownicy.Controls.Add(Me.txtImie)
        Me.frmPracownicy.Controls.Add(Me.cmdPPolacz)
        Me.frmPracownicy.Location = New System.Drawing.Point(200, 8)
        Me.frmPracownicy.Name = "frmPracownicy"
        Me.frmPracownicy.Size = New System.Drawing.Size(208, 248)
        Me.frmPracownicy.TabIndex = 6
        Me.frmPracownicy.TabStop = False
        Me.frmPracownicy.Text = "Pracownicy"
        '
        'cmdPZapisz
        '
        Me.cmdPZapisz.Location = New System.Drawing.Point(112, 24)
        Me.cmdPZapisz.Name = "cmdPZapisz"
        Me.cmdPZapisz.Size = New System.Drawing.Size(80, 24)
        Me.cmdPZapisz.TabIndex = 11
        Me.cmdPZapisz.Text = "Zapisz"
        Me.cmdPZapisz.UseVisualStyleBackColor = True
        '
        'cmdPUsun
        '
        Me.cmdPUsun.Location = New System.Drawing.Point(117, 167)
        Me.cmdPUsun.Name = "cmdPUsun"
        Me.cmdPUsun.Size = New System.Drawing.Size(75, 23)
        Me.cmdPUsun.TabIndex = 10
        Me.cmdPUsun.Text = "Usuń"
        Me.cmdPUsun.UseVisualStyleBackColor = True
        '
        'cmdPDodaj
        '
        Me.cmdPDodaj.Location = New System.Drawing.Point(16, 167)
        Me.cmdPDodaj.Name = "cmdPDodaj"
        Me.cmdPDodaj.Size = New System.Drawing.Size(75, 23)
        Me.cmdPDodaj.TabIndex = 9
        Me.cmdPDodaj.Text = "Dodaj"
        Me.cmdPDodaj.UseVisualStyleBackColor = True
        '
        'lblRekord
        '
        Me.lblRekord.AutoSize = True
        Me.lblRekord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRekord.Location = New System.Drawing.Point(16, 216)
        Me.lblRekord.MinimumSize = New System.Drawing.Size(176, 20)
        Me.lblRekord.Name = "lblRekord"
        Me.lblRekord.Size = New System.Drawing.Size(176, 20)
        Me.lblRekord.TabIndex = 8
        Me.lblRekord.Text = "Aktywnym rekordem jest: 0"
        Me.lblRekord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdOstatni
        '
        Me.cmdOstatni.Location = New System.Drawing.Point(160, 123)
        Me.cmdOstatni.Name = "cmdOstatni"
        Me.cmdOstatni.Size = New System.Drawing.Size(32, 32)
        Me.cmdOstatni.TabIndex = 7
        Me.cmdOstatni.Text = ">>"
        Me.cmdOstatni.UseVisualStyleBackColor = True
        '
        'cmdNastepny
        '
        Me.cmdNastepny.Location = New System.Drawing.Point(117, 123)
        Me.cmdNastepny.Name = "cmdNastepny"
        Me.cmdNastepny.Size = New System.Drawing.Size(32, 32)
        Me.cmdNastepny.TabIndex = 6
        Me.cmdNastepny.Text = ">"
        Me.cmdNastepny.UseVisualStyleBackColor = True
        '
        'cmdPoprzedni
        '
        Me.cmdPoprzedni.Location = New System.Drawing.Point(59, 123)
        Me.cmdPoprzedni.Name = "cmdPoprzedni"
        Me.cmdPoprzedni.Size = New System.Drawing.Size(32, 32)
        Me.cmdPoprzedni.TabIndex = 5
        Me.cmdPoprzedni.Text = "<"
        Me.cmdPoprzedni.UseVisualStyleBackColor = True
        '
        'cmdPierwszy
        '
        Me.cmdPierwszy.Location = New System.Drawing.Point(16, 123)
        Me.cmdPierwszy.Name = "cmdPierwszy"
        Me.cmdPierwszy.Size = New System.Drawing.Size(32, 32)
        Me.cmdPierwszy.TabIndex = 4
        Me.cmdPierwszy.Text = "<<"
        Me.cmdPierwszy.UseVisualStyleBackColor = True
        '
        'txtNazwisko
        '
        Me.txtNazwisko.Location = New System.Drawing.Point(16, 96)
        Me.txtNazwisko.Name = "txtNazwisko"
        Me.txtNazwisko.Size = New System.Drawing.Size(176, 20)
        Me.txtNazwisko.TabIndex = 3
        '
        'txtImie
        '
        Me.txtImie.Location = New System.Drawing.Point(16, 64)
        Me.txtImie.Name = "txtImie"
        Me.txtImie.Size = New System.Drawing.Size(176, 20)
        Me.txtImie.TabIndex = 2
        '
        'cmdPPolacz
        '
        Me.cmdPPolacz.Location = New System.Drawing.Point(16, 24)
        Me.cmdPPolacz.Name = "cmdPPolacz"
        Me.cmdPPolacz.Size = New System.Drawing.Size(80, 24)
        Me.cmdPPolacz.TabIndex = 1
        Me.cmdPPolacz.Text = "Połącz"
        Me.cmdPPolacz.UseVisualStyleBackColor = True
        '
        'cmdPobierz
        '
        Me.cmdPobierz.Location = New System.Drawing.Point(424, 8)
        Me.cmdPobierz.Name = "cmdPobierz"
        Me.cmdPobierz.Size = New System.Drawing.Size(80, 24)
        Me.cmdPobierz.TabIndex = 7
        Me.cmdPobierz.Text = "Pobierz"
        Me.cmdPobierz.UseVisualStyleBackColor = True
        '
        'cmdOtworz
        '
        Me.cmdOtworz.Location = New System.Drawing.Point(520, 8)
        Me.cmdOtworz.Name = "cmdOtworz"
        Me.cmdOtworz.Size = New System.Drawing.Size(80, 24)
        Me.cmdOtworz.TabIndex = 8
        Me.cmdOtworz.Text = "Otwórz"
        Me.cmdOtworz.UseVisualStyleBackColor = True
        '
        'lblProdukty
        '
        Me.lblProdukty.AutoSize = True
        Me.lblProdukty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProdukty.Location = New System.Drawing.Point(424, 40)
        Me.lblProdukty.MinimumSize = New System.Drawing.Size(176, 200)
        Me.lblProdukty.Name = "lblProdukty"
        Me.lblProdukty.Size = New System.Drawing.Size(176, 200)
        Me.lblProdukty.TabIndex = 9
        '
        'frmDane
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 257)
        Me.Controls.Add(Me.lblProdukty)
        Me.Controls.Add(Me.cmdOtworz)
        Me.Controls.Add(Me.cmdPobierz)
        Me.Controls.Add(Me.frmPracownicy)
        Me.Controls.Add(Me.cmdUsun)
        Me.Controls.Add(Me.cmdDodaj)
        Me.Controls.Add(Me.lblKategorii)
        Me.Controls.Add(Me.lstKategorie)
        Me.Controls.Add(Me.cmdPolacz)
        Me.Name = "frmDane"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Poznajemy technologię ADO"
        Me.frmPracownicy.ResumeLayout(False)
        Me.frmPracownicy.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdPolacz As System.Windows.Forms.Button
    Friend WithEvents lstKategorie As System.Windows.Forms.ListBox
    Friend WithEvents lblKategorii As System.Windows.Forms.Label
    Friend WithEvents cmdDodaj As System.Windows.Forms.Button
    Friend WithEvents cmdUsun As System.Windows.Forms.Button
    Friend WithEvents frmPracownicy As System.Windows.Forms.GroupBox
    Friend WithEvents txtNazwisko As System.Windows.Forms.TextBox
    Friend WithEvents txtImie As System.Windows.Forms.TextBox
    Friend WithEvents cmdPPolacz As System.Windows.Forms.Button
    Friend WithEvents lblRekord As System.Windows.Forms.Label
    Friend WithEvents cmdOstatni As System.Windows.Forms.Button
    Friend WithEvents cmdNastepny As System.Windows.Forms.Button
    Friend WithEvents cmdPoprzedni As System.Windows.Forms.Button
    Friend WithEvents cmdPierwszy As System.Windows.Forms.Button
    Friend WithEvents cmdPUsun As System.Windows.Forms.Button
    Friend WithEvents cmdPDodaj As System.Windows.Forms.Button
    Friend WithEvents cmdPZapisz As System.Windows.Forms.Button
    Friend WithEvents cmdPobierz As System.Windows.Forms.Button
    Friend WithEvents cmdOtworz As System.Windows.Forms.Button
    Friend WithEvents lblProdukty As System.Windows.Forms.Label

End Class
