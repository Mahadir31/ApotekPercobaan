Imports MySql.Data.MySqlClient

Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KdPetugas.Text = ""
        PwPetugas.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If KdPetugas.Text = "" Or PwPetugas.Text = "" Then
            MsgBox("Kode Petugas Atau Password Tidak Boleh Kosong !!!")
            KdPetugas.Focus()
        Else
            Call OpenConn()
            Cmd = New MySqlCommand("select * from petugas where kd_petugas = '" & KdPetugas.Text & "' and password ='" & PwPetugas.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Me.Hide()
                Penjualan_Obat.ShowDialog()

            Else
                MsgBox("Kode Petugas Atau password SALAH !!!")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class