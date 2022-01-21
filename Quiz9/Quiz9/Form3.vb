Public Class Form3
    Dim hasil As Integer
    Sub menu()
        Me.ComboBox1.Items.Add("Laki-laki")
        Me.ComboBox1.Items.Add("Perempuan")
        Me.ComboBox1.Items.Add("Kosongkan")
    End Sub

    Sub menu1()
        Me.ComboBox2.Items.Add("Islam")
        Me.ComboBox2.Items.Add("Protestan")
        Me.ComboBox2.Items.Add("Katolik")
        Me.ComboBox2.Items.Add("Hindu")
        Me.ComboBox2.Items.Add("Budhha")
        Me.ComboBox2.Items.Add("konguchu")
        Me.ComboBox2.Items.Add("Kosongkan")
    End Sub

    Sub menu2()
        Me.ComboBox3.Items.Add("SMP")
        Me.ComboBox3.Items.Add("SMA")
        Me.ComboBox3.Items.Add("SMK")
        Me.ComboBox3.Items.Add("D3")
        Me.ComboBox3.Items.Add("S1")
        Me.ComboBox3.Items.Add("S2")
        Me.ComboBox3.Items.Add("S3")
    End Sub

    Sub menu3()
        Me.ComboBox4.Items.Add("Menikah")
        Me.ComboBox4.Items.Add("Belum menikah")
        Me.ComboBox4.Items.Add("Kosongkan")
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call menu()
        Call menu1()
        Call menu2()
        Call menu3()


        TextBox1.Focus()

        Button1.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Nama belum dimasukkan")
            TextBox1.Focus()
        ElseIf TextBox2.Text = "" Then
            MsgBox("Umur belum dimasukkan")
            TextBox2.Focus()
        ElseIf ComboBox1.Text = "" Then
            MsgBox("Jenis kelamin belum dimasukkan")
            ComboBox1.Focus()
        ElseIf ComboBox2.Text = "" Then
            MsgBox("Agama belum dimasukkan")
            ComboBox2.Focus()
        ElseIf ComboBox3.Text = "" Then
            MsgBox("Pendidikan akhir belum dimasukkan")
            ComboBox3.Focus()
        ElseIf ComboBox4.Text = "" Then
            MsgBox("Status belum dimasukkan")
            ComboBox4.Focus()
        ElseIf TextBox3.Text = "" Then
            MsgBox("Alamat belum dimasukkan")
            TextBox3.Focus()
        ElseIf TextBox4.Text = "" Then
            MsgBox("Nilai ujian belum dimasukkan")
            TextBox4.Focus()
        ElseIf TextBox5.Text = "" Then
            MsgBox("Nilai kesehatan belum dimasukkan")
            TextBox5.Focus()
        ElseIf TextBox6.Text = "" Then
            MsgBox("Nilai wawancara belum dimasukkan")
            TextBox6.Focus()
        Else
            hasil = (Val(TextBox4.Text) / 2) + (Val(TextBox5.Text) / 2) + (Val(TextBox6.Text) / 2)
            MsgBox("Data sudah dimasukkan")
            DataGridView1.Rows.Add(1)
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = CStr(DataGridView1.RowCount - 1)
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = TextBox1.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = TextBox2.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(3).Value = ComboBox1.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(4).Value = ComboBox2.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(5).Value = ComboBox3.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(6).Value = ComboBox4.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(7).Value = TextBox3.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(8).Value = (nilai(hasil))
            DataGridView1.Update()

            TextBox1.Text = ""
            TextBox2.Text = ""
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            ComboBox4.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
        End If
    End Sub

    Function nilai(ByVal hasil As Integer)
        If hasil >= 120 Then
            nilai = "Lulus"
        Else
            nilai = "Tidak lulus"
        End If

    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Kamu akan menghapus seluruh data yang ada di tabel")
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Button1.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub TimerHitungMundurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimerHitungMundurToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()

        Button1.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub LoopingAbjadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoopingAbjadToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()

        Button1.Enabled = False
        Button3.Enabled = False
    End Sub
End Class