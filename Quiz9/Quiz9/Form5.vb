Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Focus()

        Dim arr(1, 2) As String
        arr(0, 0) = "NIM"
        arr(0, 1) = "Nama Mahasiswa"
        arr(0, 2) = "Jumlah"
        arr(1, 0) = "Rata-rata"
        arr(1, 1) = "Nilai"
        arr(1, 2) = "Keterangan"
        ListView1.GridLines = True
        ListView1.View = View.Details
        For baris = 0 To 1
            For kolom = 0 To 2
                ListView1.Columns.Add(arr(baris, kolom), 85)
            Next
        Next
        TextBox1.ReadOnly = True
        TextBox1.Text = "202029001"
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TextBox10.Text = (Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6))
        TextBox7.Text = FormatNumber((TextBox10.Text) / 4)
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        TextBox10.Text = Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6)
        TextBox7.Text = FormatNumber((TextBox10.Text) / 4)
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        TextBox10.Text = Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6)
        TextBox7.Text = FormatNumber((TextBox10.Text) / 4)
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        TextBox10.Text = Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6)
        TextBox7.Text = FormatNumber((TextBox10.Text) / 4)
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        If TextBox7.Text >= 90 Then
            TextBox8.Text = "A"
        ElseIf TextBox7.Text >= 85 Then
            TextBox8.Text = "A-"
        ElseIf TextBox7.Text >= 80 Then
            TextBox8.Text = "B+"
        ElseIf TextBox7.Text >= 76 Then
            TextBox8.Text = "B"
        ElseIf TextBox7.Text >= 70 Then
            TextBox8.Text = "B-"
        ElseIf TextBox7.Text >= 66 Then
            TextBox8.Text = "C"
        ElseIf TextBox7.Text < 66 Then
            TextBox8.Text = "D"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arr(5) As String
        arr(0) = TextBox1.Text
        arr(1) = TextBox2.Text
        arr(2) = TextBox10.Text
        arr(3) = TextBox7.Text
        arr(4) = TextBox8.Text
        arr(5) = TextBox9.Text

        If TextBox2.Text = "" Then
            MsgBox("Nama belum dimasukkan")
            TextBox2.Focus()
        ElseIf TextBox3.Text = "" Then
            MsgBox("Nilai absensi belum dimasukkan")
            TextBox3.Focus()
        ElseIf TextBox4.Text = "" Then
            MsgBox("Nilai tugas belum dimasukkan")
            TextBox4.Focus()
        ElseIf TextBox5.Text = "" Then
            MsgBox("Nilai UTS belum dimasukkan")
            TextBox5.Focus()
        ElseIf TextBox6.Text = "" Then
            MsgBox("Nilai UAS belum dimasukkan")
            TextBox6.Focus()
        Else
            Dim list As New ListViewItem
            list = ListView1.Items.Add(arr(0))
            list.SubItems.Add(arr(1))
            list.SubItems.Add(arr(2))
            list.SubItems.Add(arr(3))
            list.SubItems.Add(arr(4))
            list.SubItems.Add(arr(5))

            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()
            TextBox9.Clear()
            TextBox10.Clear()
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        If TextBox8.Text = "A" Then
            TextBox9.Text = "Lulus"
        ElseIf TextBox8.Text = "A-" Then
            TextBox9.Text = "Lulus"
        ElseIf TextBox8.Text = "B+" Then
            TextBox9.Text = "Lulus"
        ElseIf TextBox8.Text = "B" Then
            TextBox9.Text = "Lulus"
        ElseIf TextBox8.Text = "B-" Then
            TextBox9.Text = "Lulus"
        ElseIf TextBox8.Text = "C" Then
            TextBox9.Text = "Lulus"
        ElseIf TextBox8.Text = "D" Then
            TextBox9.Text = "Gagal"
        End If
    End Sub
End Class