Imports System.Data.OleDb

Public Class frmDane

    Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='D:\Visual Basic\VB.NET-Cwiczenia\Rozdzial7\Rozdzial7\Rozdzial7\Notrhwind.mdb';Persist Security Info=True"
    Dim conOleDbNorthwind As New OleDbConnection(connectionString)

    Dim comKategorie As New OleDbCommand
    Dim comLKategorii As New OleDbCommand

    Dim conPracownicy As New OleDbConnection(connectionString)
    Dim comPracownicy As New OleDbCommand
    Dim daPracownicy As New OleDbDataAdapter
    Dim dsPracownicy As New DataSet

    Dim Pracownik As New Object

    Dim WithEvents biezacy As CurrencyManager

    Private Sub cmdPolacz_Click(sender As System.Object, e As System.EventArgs) Handles cmdPolacz.Click

        conOleDbNorthwind.Open()
        cmdPolacz.Enabled = False
        Call WyswietlKategorie()

    End Sub

    Private Sub WyswietlKategorie()

        lstKategorie.Items.Clear()
        Dim datKategorie As OleDbDataReader
        comKategorie.Connection = conOleDbNorthwind
        comKategorie.CommandText = "SELECT NazwaKategorii FROM Kategorie ORDER BY NazwaKategorii ASC"
        datKategorie = comKategorie.ExecuteReader()

        Do While datKategorie.Read
            lstKategorie.Items.Add(datKategorie(0).ToString)
        Loop
        datKategorie.Close()

        comLKategorii.Connection = conOleDbNorthwind
        comLKategorii.CommandText = "SELECT Count(*) from Kategorie"
        lblKategorii.Text = "Liczba kategorii: " + vbCrLf + comLKategorii.ExecuteScalar().ToString

    End Sub

    Private Sub cmdDodaj_Click(sender As System.Object, e As System.EventArgs) Handles cmdDodaj.Click
        Dim comDKategorie As New OleDbCommand
        Dim strKategoria As String
        comDKategorie.Connection = conOleDbNorthwind
        strKategoria = InputBox("Podaj nazwę kategorii: ")
        comDKategorie.CommandText = "INSERT INTO Kategorie (NazwaKategorii) VALUES ('" + strKategoria + "')"
        comDKategorie.ExecuteNonQuery()
        Call WyswietlKategorie()
    End Sub

    Private Sub cmdUsun_Click(sender As System.Object, e As System.EventArgs) Handles cmdUsun.Click
        If lstKategorie.SelectedItems.Count = 0 Then Exit Sub

        Dim comUKategorie As New OleDbCommand
        Dim strKategorie As String = ""
        'Dim strKategoria As String
        Dim bytKategorie As Byte

        For Each poz In lstKategorie.SelectedItems
            strKategorie = "'" + poz + "'," + strKategorie
        Next
        strKategorie = Microsoft.VisualBasic.Left(strKategorie, Len(strKategorie) - 1)

        comUKategorie.Connection = conOleDbNorthwind
        comUKategorie.CommandText = "DELETE * FROM Kategorie WHERE NazwaKategorii IN (" + strKategorie + ")"
        bytKategorie = comUKategorie.ExecuteNonQuery()
        MsgBox("Usunięto " + bytKategorie.ToString + " wierszy")
        Call WyswietlKategorie()
    End Sub

    Private Sub cmdKatProd_Click(sender As System.Object, e As System.EventArgs)
        'Dim frmKatProd As New KatProd
        'frmKatProd.Show()
    End Sub

    Private Sub cmdPPolacz_Click(sender As System.Object, e As System.EventArgs) Handles cmdPPolacz.Click


        If conPracownicy.State = ConnectionState.Open Then
            conPracownicy.Close()
            cmdPPolacz.Text = conPracownicy.State.ToString
        Else
            conPracownicy.Open()
            cmdPPolacz.Text = conPracownicy.State.ToString
        End If


    End Sub

    Private Sub frmDane_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        With comPracownicy
            .Connection = conPracownicy
            .CommandText = "SELECT Imie, Nazwisko FROM Pracownicy"
        End With

        daPracownicy.SelectCommand = comPracownicy
        daPracownicy.Fill(dsPracownicy, "PracownicyKopia")

        txtImie.DataBindings.Add("Text", dsPracownicy.Tables("PracownicyKopia"), "Imie")
        txtNazwisko.DataBindings.Add("Text", dsPracownicy.Tables("PracownicyKopia"), "Nazwisko")
        biezacy = CType(Me.BindingContext(dsPracownicy.Tables("PracownicyKopia")), CurrencyManager)
    End Sub

    Private Sub cmdPierwszy_Click(sender As System.Object, e As System.EventArgs) Handles cmdPierwszy.Click
        biezacy.Position = 0
    End Sub

    Private Sub cmdOstatni_Click(sender As System.Object, e As System.EventArgs) Handles cmdOstatni.Click
        biezacy.Position = Me.dsPracownicy.Tables("PracownicyKopia").Rows.Count - 1
    End Sub

    Private Sub cmdPoprzedni_Click(sender As System.Object, e As System.EventArgs) Handles cmdPoprzedni.Click
        biezacy.Position -= 1
    End Sub

    Private Sub cmdNastepny_Click(sender As System.Object, e As System.EventArgs) Handles cmdNastepny.Click
        biezacy.Position += 1
    End Sub

    Private Sub biezacy_PositionChanged(sender As Object, e As System.EventArgs) Handles biezacy.PositionChanged
        lblRekord.Text = "Aktywnym rekorderm jest: " + biezacy.Position.ToString
    End Sub

    Private Sub cmdPDodaj_Click(sender As System.Object, e As System.EventArgs) Handles cmdPDodaj.Click
        Dim drPracownik As DataRow = dsPracownicy.Tables("PracownicyKopia").NewRow

        drPracownik("Imie") = InputBox("Podaj imię")
        drPracownik("Nazwisko") = InputBox("Podaj nazwisko")

        dsPracownicy.Tables("PracownicyKopia").Rows.Add(drPracownik)

    End Sub

    Private Sub cmdPUsun_Click(sender As System.Object, e As System.EventArgs) Handles cmdPUsun.Click
        Dim drPracownik As DataRow = dsPracownicy.Tables("PracownicyKopia").Rows(biezacy.Position)
        drPracownik.Delete()
    End Sub

    Private Sub Pracownik_LostFocus(sender As Object, e As System.EventArgs) Handles txtImie.LostFocus, txtNazwisko.LostFocus
        Dim drPracownik As DataRow = dsPracownicy.Tables("PracownicyKopia").Rows(biezacy.Position)
        drPracownik.BeginEdit()
        drPracownik("Imie") = txtImie.Text
        drPracownik("Nazwisko") = txtNazwisko.Text
        drPracownik.EndEdit()
    End Sub

    Private Sub cmdPZapisz_Click(sender As System.Object, e As System.EventArgs) Handles cmdPZapisz.Click
        If Not dsPracownicy.HasChanges Then Exit Sub
        Dim comIPracownicy As New OleDbCommand
        Dim comDPracownicy As New OleDbCommand
        Dim comUPracownicy As New OleDbCommand
        Dim orgImie As OleDbParameter
        Dim orgNazwisko As OleDbParameter

        With comIPracownicy
            .Connection = conPracownicy
            .Parameters.Add("@imie", OleDbType.VarChar, 10, "Imie")
            .Parameters.Add("@nazwisko", OleDbType.VarChar, 20, "Nazwisko")
            .CommandText = "INSERT INTO Pracownicy(Imie, Nazwisko) VALUES (@imie, @nazwisko)"
        End With
        daPracownicy.InsertCommand = comIPracownicy


        With comDPracownicy
            .Connection = conPracownicy
            .Parameters.Add("@imie", OleDbType.VarChar, 10, "Imie")
            .Parameters.Add("@nazwisko", OleDbType.VarChar, 20, "Nazwisko")
            .CommandText = "DELETE FROM Pracownicy WHERE Imie = @imie AND Nazwisko = @nazwisko"
        End With
        daPracownicy.DeleteCommand = comDPracownicy


        With comUPracownicy
            .Connection = conPracownicy
            .Parameters.Add("@imie", OleDbType.VarChar, 10, "Imie")
            .Parameters.Add("@nazwisko", OleDbType.VarChar, 20, "Nazwisko")
        End With
        orgImie = comUPracownicy.Parameters.Add("@orgImie", OleDbType.VarChar, 10, "Imie")
        orgImie.SourceVersion = DataRowVersion.Original
        orgNazwisko = comUPracownicy.Parameters.Add("@orgNazwisko", OleDbType.VarChar, 20, "Nazwisko")
        orgNazwisko.SourceVersion = DataRowVersion.Original
        comUPracownicy.CommandText = "UPDATE Pracownicy SET Imie = @imie, Nazwisko = @nazwisko WHERE Imie = @orgImie AND Nazwisko = @orgNazwisko"
        daPracownicy.UpdateCommand = comUPracownicy
        daPracownicy.Update(dsPracownicy, "PracownicyKopia")
        dsPracownicy.AcceptChanges()
    End Sub

    Private Sub cmdPobierz_Click(sender As System.Object, e As System.EventArgs) Handles cmdPobierz.Click
        Dim comProdukty As New OleDbCommand
        Dim daProdukty As New OleDbDataAdapter
        Dim dsProdukty As New DataSet

        With comProdukty
            .Connection = conPracownicy
            .CommandText = "SELECT * FROM Produkty"
        End With

        daProdukty.SelectCommand = comProdukty
        daProdukty.Fill(dsProdukty, "Produkty")

        Dim plik As New System.IO.FileStream("D:\produkty.xml", System.IO.FileMode.Create)
        Dim xml As New System.Xml.XmlTextWriter(plik, System.Text.Encoding.Unicode)
        dsProdukty.WriteXml(xml)
        xml.Close()
    End Sub

    Private Sub cmdOtworz_Click(sender As System.Object, e As System.EventArgs) Handles cmdOtworz.Click


        Dim dsXmlProdukty As New DataSet
        dsXmlProdukty.ReadXml("D:\produkty.xml")
        Dim bytLicznik As Byte
        For bytLicznik = 0 To 4
            lblProdukty.Text = lblProdukty.Text + dsXmlProdukty.Tables(0).Rows(bytLicznik)("NazwaProduktu").ToString + " - "
            lblProdukty.Text = lblProdukty.Text + dsXmlProdukty.Tables(0).Rows(bytLicznik)("StanMagazyn").ToString + vbCrLf
        Next

    End Sub
End Class
