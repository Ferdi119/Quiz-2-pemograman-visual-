
Public Class FormGaji
    Dim gaji, jamkerja, upahnormal, gajinormal, upahlembur, jamlembur, gajilembur, jampotongan, upahpotongan, gajipotongan As Integer


    Private Sub FormGaji_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        TextBox2.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        jamkerja = Val(TextBox1.Text)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If jamkerja >= 50 And jamkerja <= 60 Then
            Call normalgaji()
            TextBox1.Text = ""
        ElseIf jamkerja > 60 Then
            Call lemburgaji()
            TextBox1.Text = ""
        ElseIf jamkerja < 50 Then
            Call kuranggaji()
            TextBox1.Text = ""
        End If
    End Sub

    Function normalgaji()
        upahnormal = 5000
        gajinormal = jamkerja * upahnormal
        gaji = gajinormal
        TextBox2.Text = FormatCurrency(gaji)
        Return upahnormal
        Return gajinormal
    End Function

    Function lemburgaji()
        upahlembur = 7500
        upahnormal = 5000
        jamlembur = jamkerja - 60
        gajilembur = upahlembur * jamlembur
        gajinormal = 60 * upahnormal
        gaji = gajinormal + gajilembur
        TextBox2.Text = FormatCurrency(gaji)
        Return upahlembur
        Return jamlembur
        Return gajilembur
    End Function

    Function kuranggaji()
        upahpotongan = 2500
        upahnormal = 5000
        jampotongan = 50 - jamkerja
        gajipotongan = jampotongan * upahpotongan
        gajinormal = jamkerja * upahnormal
        gaji = gajinormal - gajipotongan
        TextBox2.Text = FormatCurrency(gaji)
        Return upahpotongan
        Return jampotongan
        Return gajipotongan
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = ""
    End Sub
End Class