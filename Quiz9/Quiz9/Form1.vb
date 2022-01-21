Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        End
    End Sub

    Private Sub MesinKasirLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MesinKasirLToolStripMenuItem.Click
        Loginkasir.MdiParent = Me
        Loginkasir.Show()

        FormGaji.Hide()
        FormPembayaranUtang.Hide()
        Form2.Hide()
        Form3.Hide()
        Form4.Hide()
        Form5.Hide()
    End Sub

    Private Sub GajiKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GajiKaryawanToolStripMenuItem.Click
        FormGaji.MdiParent = Me
        FormGaji.Show()

        Loginkasir.Hide()
        FormMesinkasir.Hide()
        FormPembayaranUtang.Hide()
        Form2.Hide()
        Form3.Hide()
        Form4.Hide()
        Form5.Hide()
    End Sub

    Private Sub HutangPiutangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HutangPiutangToolStripMenuItem.Click
        FormPembayaranUtang.MdiParent = Me
        FormPembayaranUtang.Show()

        Loginkasir.Hide()
        FormMesinkasir.Hide()
        FormGaji.Hide()
        Form2.Hide()
        Form3.Hide()
        Form4.Hide()
        Form5.Hide()
    End Sub

    Private Sub TimerHitungMundurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimerHitungMundurToolStripMenuItem.Click
        Form2.MdiParent = Me
        Form2.Show()

        Loginkasir.Hide()
        FormMesinkasir.Hide()
        Form3.Hide()
        Form4.Hide()
        Form5.Hide()
        FormGaji.Hide()
        FormPembayaranUtang.Hide()
    End Sub

    Private Sub PenerimaanSiswaBaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenerimaanSiswaBaruToolStripMenuItem.Click
        Form3.MdiParent = Me
        Form3.Show()

        Loginkasir.Hide()
        FormMesinkasir.Hide()
        Form2.Hide()
        Form4.Hide()
        Form5.Hide()
        FormGaji.Hide()
        FormPembayaranUtang.Hide()
    End Sub

    Private Sub LoopingAbjadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoopingAbjadToolStripMenuItem.Click
        Form4.MdiParent = Me
        Form4.Show()


        Loginkasir.Hide()
        FormMesinkasir.Hide()
        Form2.Hide()
        Form3.Hide()
        Form5.Hide()
        FormGaji.Hide()
        FormPembayaranUtang.Hide()
    End Sub
End Class
