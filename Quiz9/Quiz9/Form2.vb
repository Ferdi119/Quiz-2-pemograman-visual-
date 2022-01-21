Public Class Form2
    Dim jam, menit, detik As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As Integer = 0
        Dim b As Integer = 0
        Dim c As Integer = 0

        For a = 0 To 99
            ComboBox1.Items.Add(a)
        Next
        For b = 0 To 59
            ComboBox2.Items.Add(b)
        Next
        For c = 0 To 59
            ComboBox3.Items.Add(c)
        Next

        ComboBox1.Text = "0"
        ComboBox2.Text = "0"
        ComboBox3.Text = "0"

        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        detik -= 1
        If detik < 0 Then
            detik = 59
            menit -= 1
            If menit < 0 Then
                menit = 59
                jam -= 1
            End If
        End If
        Label4.Text = Format(jam, "00") & ":" & Format(menit, "00") & ":" & Format(detik, "00")
        If jam = 0 And menit = 0 And detik = 0 Then
            Timer1.Enabled = False
            MessageBox.Show("Waktu telah Usai")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        jam = ComboBox1.Text
        menit = ComboBox2.Text
        detik = ComboBox3.Text

        Label4.Text = Format(jam, "00") & ":" & Format(menit, "00") & ":" & Format(detik, "00")
        Timer1.Enabled = True

        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Jeda" Then
            Timer1.Enabled = False
            Button2.Text = "Lanjut"
        Else
            Timer1.Enabled = True
            Button2.Text = "Jeda"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Enabled = False
        Button2.Text = "Jeda"
        ComboBox1.Text = "0"
        ComboBox2.Text = "0"
        ComboBox3.Text = "0"
        Label4.Text = "00:00:00"

        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub PenerimaanKaryawaanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenerimaanKaryawaanToolStripMenuItem.Click
        Form3.Show()
        Me.Hide()

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub LoopingAbjadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoopingAbjadToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub
End Class