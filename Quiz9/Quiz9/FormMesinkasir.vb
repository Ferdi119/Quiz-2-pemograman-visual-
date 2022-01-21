Imports System.Drawing.Printing
Public Class FormMesinkasir
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim Data As ListViewItem
    Private Sub GrandTotal()
        Dim Jumlah As Integer
        For b As Integer = 0 To LV.Items.Count - 1
            Jumlah = Jumlah + Val(LV.Items(b).SubItems(5).Text)
            Hargabarang.Text = Format(Jumlah, "##,##0")
            txt9.Text =  Format(Jumlah, "##,##0")
        Next

        Dim Jumlah2 As Integer
        For b As Integer = 0 To LV.Items.Count - 1
            Jumlah2 = Jumlah2 + Val(LV.Items(b).SubItems(4).Text)
        Next
        TextBox7.Text = Jumlah2
    End Sub
    Private Sub Total()
        Dim Total0 As Integer
        For i As Integer = 0 To LV.Items.Count - 1
            Total0 = Val(LV.Items(i).SubItems(3).Text) * Val(LV.Items(i).SubItems(4).Text)
        Next
        Data.SubItems.Add(Total0)
    End Sub

    Private Sub Bersih()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub FormMesinkasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()

        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        Hargabarang.Enabled = False
        TextBox10.Enabled = False

        TextBox7.Enabled = False
        TextBox9.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Select Case TextBox1.Text
            'rak minuman
            Case "A001"
                TextBox2.Text = "101"
                TextBox3.Text = "FANTA"
                TextBox4.Text = 7500 + ((7500 * 10) / 100)
            Case "A002"
                TextBox2.Text = "102"
                TextBox3.Text = "Coca-cola"
                TextBox4.Text = 7500 + ((7500 * 10) / 100)
            Case "A003"
                TextBox2.Text = "103"
                TextBox3.Text = "Sprite"
                TextBox4.Text = 7500 + ((7500 * 10) / 100)
            Case "A004"
                TextBox2.Text = "104"
                TextBox3.Text = "AW"
                TextBox4.Text = 8000 + ((8000 * 10) / 100)
            Case "A005"
                TextBox2.Text = "105"
                TextBox3.Text = "Red Bull - kaleng"
                TextBox4.Text = 19000 + ((19000 * 10) / 100)
            Case "A006"
                TextBox2.Text = "106"
                TextBox3.Text = "Big cola"
                TextBox4.Text = 6000 + ((6000 * 10) / 100)
            Case "A007"
                TextBox2.Text = "107"
                TextBox3.Text = "Red Bull - botol(s)"
                TextBox4.Text = 10000 + ((10000 * 10) / 100)
            Case "A008"
                TextBox2.Text = "108"
                TextBox3.Text = "Tebs - original"
                TextBox4.Text = 8000 + ((8000 * 10) / 100)
            Case "A009"
                TextBox2.Text = "109"
                TextBox3.Text = "Tebs - lemon"
                TextBox4.Text = 8500 + ((8500 * 10) / 100)
            Case "A010"
                TextBox2.Text = "110"
                TextBox3.Text = "Aqua"
                TextBox4.Text = 5000 + ((5000 * 10) / 100)
            Case "A011"
                TextBox2.Text = "111"
                TextBox3.Text = "Le minerale"
                TextBox4.Text = 4000 + ((4000 * 10) / 100)
            Case "A012"
                TextBox2.Text = "112"
                TextBox3.Text = "Gunung"
                TextBox4.Text = 2000 + ((2000 * 10) / 100)

            'rak makanan
            Case "B001"
                TextBox2.Text = "401"
                TextBox3.Text = "Jaguar"
                TextBox4.Text = 9000 + ((9000 * 10) / 100)
            Case "B002"
                TextBox2.Text = "402"
                TextBox3.Text = "Lays - Original"
                TextBox4.Text = 7500 + ((7500 * 10) / 100)
            Case "B003"
                TextBox2.Text = "403"
                TextBox3.Text = "Taro"
                TextBox4.Text = 6500 + ((6500 * 10) / 100)
            Case "B004"
                TextBox2.Text = "404"
                TextBox3.Text = "Cheetos - sapi panggang"
                TextBox4.Text = 7500 + ((7500 * 10) / 100)
            Case "B005"
                TextBox2.Text = "405"
                TextBox3.Text = "Chitato - sapi panggang"
                TextBox4.Text = 10000 + ((10000 * 10) / 100)
            Case "B006"
                TextBox2.Text = "406"
                TextBox3.Text = "Chitato - original"
                TextBox4.Text = 9500 + ((9500 * 10) / 100)
            Case "B007"
                TextBox2.Text = "407"
                TextBox3.Text = "Chitato - balado"
                TextBox4.Text = 10000 + ((10000 * 10) / 100)
            Case "B008"
                TextBox2.Text = "408"
                TextBox3.Text = "Chitato lite - rumput laut"
                TextBox4.Text = 12000 + ((12000 * 10) / 100)
            Case "B009"
                TextBox2.Text = "409"
                TextBox3.Text = "Chitato lite - keju"
                TextBox4.Text = 1200 + ((12000 * 10) / 100)
        End Select
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If e.KeyChar = Chr(13) Then
            If TextBox1.Text = "" Then
                Exit Sub
            End If
            If LV.SelectedItems.Count > 0 Then
                LV.SelectedItems(0).SubItems(4).Text = TextBox5.Text
                For a As Integer = 0 To LV.Items.Count - 1
                    LV.SelectedItems(0).SubItems(5).Text = Val(LV.Items(a).SubItems(3).Text) * Val(LV.Items(a).SubItems(4).Text)
                Next
                GrandTotal()
                Exit Sub
            End If

            Data = LV.Items.Add(TextBox1.Text)
            Data.SubItems.Add(TextBox2.Text)
            Data.SubItems.Add(TextBox3.Text)
            Data.SubItems.Add(TextBox4.Text)
            Data.SubItems.Add(TextBox5.Text)

            Bersih()
            Total()
            GrandTotal()
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        Dim diskon As Single
        If TextBox8.Text = "" Then TextBox8.Text = 0
        diskon = (Val(Replace(Hargabarang.Text, ".", "") * TextBox8.Text)) / 100
        TextBox10.Text = (Val(Replace(Hargabarang.Text, ".", "")) - Val(diskon)).ToString("#,#")
        txt9.Text = "Rp" & Space(1) & TextBox10.Text
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        Dim q As Double
        If TextBox11.Text = "" Or Not IsNumeric(TextBox11.Text) Then
            TextBox11.Text = ""
            TextBox9.Text = ""
            Exit Sub
        End If

        q = TextBox11.Text
        TextBox11.Text = Format(q, "##,##0")
        TextBox11.SelectionStart = Len(TextBox9.Text)

        Dim kembalian As Single = TextBox11.Text - TextBox10.Text
        TextBox9.Text = Format(kembalian, "##,##0")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PPD.Document = PD
        PPD.ShowDialog()
        'PD.Print()
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10a As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim Lmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim Cmargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim Rmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "------------------------------------------------------"

        e.Graphics.DrawString("Qurmart", f14, Brushes.Black, Cmargin, 5, tengah)
        e.Graphics.DrawString("Jl. Medan Merdeka NO.26", f10, Brushes.Black, Cmargin, 25, tengah)
        e.Graphics.DrawString("Hotline: 0894-455-3542", f10, Brushes.Black, Cmargin, 40, tengah)


        e.Graphics.DrawString("Date", f10, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", f10, Brushes.Black, 65, 60)
        e.Graphics.DrawString("20 Desember 2021  10:42:34", f10, Brushes.Black, 75, 60)

        e.Graphics.DrawString("Kasir", f10, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f10, Brushes.Black, 65, 75)
        e.Graphics.DrawString("Gonzalez", f10, Brushes.Black, 75, 75)

        e.Graphics.DrawString("Pembeli", f10, Brushes.Black, 0, 90)
        e.Graphics.DrawString(":", f10, Brushes.Black, 65, 90)
        e.Graphics.DrawString(Format(TextBox6.Text), f10, Brushes.Black, 75, 90)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 100)
        LV.AllowColumnReorder = False

        Dim tinggi As Integer
        Dim t As Long
        For baris As Integer = 0 To LV.Items.Count - 1
            tinggi += 15
            e.Graphics.DrawString(LV.Items(baris).SubItems(4).Text, f10, Brushes.Black, 0, 100 + tinggi)
            e.Graphics.DrawString(LV.Items(baris).SubItems(2).Text, f10, Brushes.Black, 30, 100 + tinggi)

            t = LV.Items(baris).SubItems(5).Text
            LV.Items(baris).SubItems(5).Text = Format(t, "##,##0")
            e.Graphics.DrawString(LV.Items(baris).SubItems(5).Text, f10, Brushes.Black, Rmargin, 100 + tinggi, kanan)
        Next
        tinggi = 110 + tinggi

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, tinggi)
        e.Graphics.DrawString("Diskon :" & Format(TextBox8.Text), f10, Brushes.Black, Rmargin, 10 + tinggi, kanan)
        e.Graphics.DrawString("sebelum diskon  :" & Format(Hargabarang.Text), f10, Brushes.Black, Rmargin, 25 + tinggi, kanan)
        e.Graphics.DrawString("Total  :" & Format(TextBox10.Text), f10a, Brushes.Black, Rmargin, 40 + tinggi, kanan)
        e.Graphics.DrawString("Bayar  :" & Format(TextBox11.Text), f10a, Brushes.Black, Rmargin, 55 + tinggi, kanan)
        e.Graphics.DrawString("Kembalian  :" & Format(TextBox9.Text), f10, Brushes.Black, Rmargin, 70 + tinggi, kanan)
        e.Graphics.DrawString("QTY :" & Format(TextBox7.Text), f10, Brushes.Black, 0, 20 + tinggi)

        e.Graphics.DrawString("~Terima Kasih Telah Berbelanja~", f10, Brushes.Black, Cmargin, 90 + tinggi, tengah)
        e.Graphics.DrawString("~Di Toko Qurmart~", f10, Brushes.Black, Cmargin, 115 + tinggi, tengah)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Kamu akan menghapus seluruh data keranjang")
        LV.Items.Clear()
        Hargabarang.Text = ""
        txt9.Text = "Rp"
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
    End Sub

    Private Sub LV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LV.SelectedIndexChanged

    End Sub

    Private Sub LV_DoubleClick(sender As Object, e As EventArgs) Handles LV.DoubleClick
        For Each z As ListViewItem In LV.SelectedItems
            LV.Items.Remove(z)
            Bersih()
            Total()
            GrandTotal()
        Next
    End Sub
End Class