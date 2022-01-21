Public Class Form4
    Dim A As String
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        A = Asc(“A”)
        Do Until A > Asc(“Z”)
            ListBox1.Items.Add(Chr(A))
            A = A + 1
        Loop
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        A = Asc(“Z”)
        Do Until A < Asc(“A”)
            ListBox1.Items.Add(Chr(A))
            A = A - 1
        Loop
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        MsgBox("Kamua kan mereset listbox tersebut")
    End Sub

    Private Sub TimerHitungMundurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimerHitungMundurToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub PenerimaanKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenerimaanKaryawanToolStripMenuItem.Click
        Form3.Show()
        Me.Hide()

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub
End Class