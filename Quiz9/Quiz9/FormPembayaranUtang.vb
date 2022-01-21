Public Class FormPembayaranUtang
    Dim hutang, lamapinjam, angsuranbulan, angsuran, bunga, totbunga As Integer

    Private Sub FormPembayaranUtang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()

        Button2.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        hutang = Val(TextBox1.Text)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        lamapinjam = Val(TextBox2.Text)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If IsNumeric(TextBox3.Text) Then
            'numeric
            If TextBox3.Text < 0 Or TextBox3.Text > 100 Then
                MsgBox("Bunga Pinjaman tidak bisa bisa minus ataupun lebih dari 100")
                TextBox3.Clear()
            Else
                bunga = Val(TextBox3.Text)
            End If
        Else
            TextBox3.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        angsuranbulan = hutang / lamapinjam
        totbunga = angsuranbulan * (bunga / 100)
        angsuran = angsuranbulan + totbunga


        For i As Integer = 1 To lamapinjam
            hutang = hutang - angsuranbulan
            DataGridView1.Rows.Add("Bulan Ke-" & i, TextBox3.Text, FormatCurrency(angsuran), FormatCurrency(hutang))
        Next

        Button2.Enabled = True
        Button1.Enabled = False

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        DataGridView1.Rows.Clear()
        Button1.Enabled = True
    End Sub
End Class