Public Class Loginkasir
    Private Sub Loginkasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True

        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Username belum dimasukkan", MsgBoxStyle.Information, "Username ?")
            TextBox1.Focus()
        ElseIf TextBox2.Text = "" Then
            MsgBox("Password belum dimasukkan", MsgBoxStyle.Information, "Password ?")
            TextBox2.Focus()
        Else
            If TextBox1.Text = "gonzalez112" And TextBox2.Text = "qurmart112" Then
                Call pesan1()
                FormMesinkasir.Show()
                Me.Hide()
                TextBox1.Text = ""
                TextBox2.Text = ""
            Else
                MsgBox("Username atau password Salah !", MsgBoxStyle.Information, " Pesan")
                TextBox1.Text = ""
                TextBox2.Text = ""
                Call pesan3()
                TextBox1.Focus()
            End If
        End If
    End Sub

    Sub pesan1()
        MsgBox("Silahkan menuju ke mesin pembayaran", MsgBoxStyle.Information, "Pesan")
    End Sub

    Sub pesan3()
        MsgBox("Tolong masukan dengan benar", MsgBoxStyle.Information, "Pesan")

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.Text = "Hide"
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
            CheckBox1.Text = "Show"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class