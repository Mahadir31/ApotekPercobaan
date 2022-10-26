Imports MySql.Data.MySqlClient
Public Class Pembelian_Obat
    Sub Tampilkan()
        Call OpenConn()
        Da = New MySqlDataAdapter("Select * from pembelian_obat", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "pembelian_obat")
        DgPembelian.DataSource = Ds.Tables("pembelian_obat")
        DgPembelian.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver

        Btntambah.Text = "TAMBAH"
        Btntambah.Enabled = True
        Btnubah.Text = "UBAH"
        Btnubah.Enabled = True
        Btnhapus.Text = "HAPUS"
        Btnhapus.Enabled = True
        Btnkeluar.Text = "KELUAR"
        Btnkeluar.Enabled = True

        KodeObat.Enabled = False
        NamaObat.Enabled = False
        DtPembelian.Enabled = False
        DtExp.Enabled = False
        HargaObat.Enabled = False
        JumlahObat.Enabled = False
        JenisObat.Enabled = False

        KodeObat.Text = ""
        NamaObat.Text = ""
        DtPembelian.ResetText()
        DtExp.ResetText()
        HargaObat.Text = ""
        JumlahObat.Text = ""
        JenisObat.Text = ""
    End Sub
    Sub Isi()
        KodeObat.Enabled = True
        NamaObat.Enabled = True
        DtPembelian.Enabled = True
        DtExp.Enabled = True
        HargaObat.Enabled = True
        JumlahObat.Enabled = True
        JenisObat.Enabled = True
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Btnkeluar.Click
        If Btnkeluar.Text = "KELUAR" Then
            Me.Close()
        Else
            Call Tampilkan()
        End If

    End Sub

    Private Sub Pembelian_Obat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampilkan()
        LblKodePetugas.Text = FormLogin.KdPetugas.Text
        DtPembelian.Text = Today
        KodeObat.Focus()
    End Sub

    Private Sub Btntambah_Click(sender As Object, e As EventArgs) Handles Btntambah.Click
        If Btntambah.Text = "TAMBAH" Then
            Btntambah.Text = "SIMPAN"
            Btnubah.Enabled = False
            Btnhapus.Enabled = False
            Btnkeluar.Text = "&CANCEL"
            Call Isi()
            KodeObat.Focus()
        Else
            If KodeObat.Text = "" Or NamaObat.Text = "" Or DtPembelian.Text = "" Or DtExp.Text = "" Or HargaObat.Text = "" Or JumlahObat.Text = "" Or JenisObat.Text = "" Or LblKodePetugas.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
                KodeObat.Focus()
            Else
                Try
                    Call OpenConn()
                    Dim TambahData As String = "insert into pembelian_obat values ('" & KodeObat.Text & "','" & NamaObat.Text & "','" & Format(DtPembelian.Value, "yyyy-MM-dd") & "','" & Format(DtExp.Value, "yyyy-MM-dd") & "', '" & HargaObat.Text & "','" & JumlahObat.Text & "', '" & JenisObat.Text & "', '" & LblKodePetugas.Text & "')"
                    Cmd = New MySqlCommand(TambahData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil di Simpan !!!")
                    Call Tampilkan()
                Catch ex As Exception
                    MsgBox("Data Gagal di Simpan......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End Try

            End If
        End If
    End Sub

    Private Sub Btnubah_Click(sender As Object, e As EventArgs) Handles Btnubah.Click
        If Btnubah.Text = "UBAH" Then
            Btnubah.Text = "SIMPAN"
            Btntambah.Enabled = False
            Btnhapus.Enabled = False
            Btnkeluar.Text = "&CANCEL"
            Call Isi()
            KodeObat.Focus()
        Else
            If KodeObat.Text = "" Or NamaObat.Text = "" Or DtPembelian.Text = "" Or DtExp.Text = "" Or HargaObat.Text = "" Or JumlahObat.Text = "" Or JenisObat.Text = "" Or LblKodePetugas.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
                KodeObat.Focus()
            Else
                Try
                    Call OpenConn()
                    Dim UpdateData As String = "update pembelian_obat set nama_obat='" & NamaObat.Text & "', tgl_pembelian='" & Format(DtPembelian.Value, "yyyy-MM-dd") & "', exp='" & Format(DtExp.Value, "yyyy-MM-dd") & "', harga='" & HargaObat.Text & "', jumlah_obat='" & JumlahObat.Text & "', jenis_obat ='" & JenisObat.Text & "', kd_petugas='" & LblKodePetugas.Text & "' where kd_obat='" & KodeObat.Text & "'"
                    Cmd = New MySqlCommand(UpdateData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil di Ubah", MsgBoxStyle.MsgBoxRight, "Message")
                    Call Tampilkan()
                Catch ex As Exception
                    MsgBox("Data Gagal di Ubah......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End Try
            End If
        End If
    End Sub

    Private Sub KodeObat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles KodeObat.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            Cmd = New MySqlCommand("Select * from pembelian_obat where kd_obat='" & KodeObat.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data tidak ada")
            Else
                NamaObat.Text = Rd.Item("nama_obat")
                DtPembelian.Text = Rd.Item("tgl_pembelian")
                DtExp.Text = Rd.Item("exp")
                HargaObat.Text = Rd.Item("harga")
                JumlahObat.Text = Rd.Item("jumlah_obat")
                JenisObat.Text = Rd.Item("jenis_obat")
                LblKodePetugas.Text = Rd.Item("kd_petugas")
            End If
        End If
    End Sub

    Private Sub Btnhapus_Click(sender As Object, e As EventArgs) Handles Btnhapus.Click
        If Btnhapus.Text = "HAPUS" Then
            Btnhapus.Text = "DELETE"
            Btntambah.Enabled = False
            Btnubah.Enabled = False
            Btnkeluar.Text = "&CANCEL"
            Call Isi()
            KodeObat.Focus()
        Else
            If KodeObat.Text = "" Or NamaObat.Text = "" Or DtPembelian.Text = "" Or DtExp.Text = "" Or HargaObat.Text = "" Or JumlahObat.Text = "" Or JenisObat.Text = "" Or LblKodePetugas.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
                KodeObat.Focus()
            Else
                Try
                    Call OpenConn()
                    Dim DeleteData As String = "Delete From pembelian_obat where kd_obat='" & KodeObat.Text & "'"
                    Cmd = New MySqlCommand(DeleteData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil di Hapus", MsgBoxStyle.MsgBoxRight, "Message")
                    Call Tampilkan()
                Catch ex As Exception
                    MsgBox("Data Gagal di Hapus......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End Try
            End If
        End If
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        Call OpenConn()
        Da = New MySqlDataAdapter("select * from pembelian_obat where nama_obat like '%" & TxtCari.Text & "%'", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "pembelian_obat")
        DgPembelian.DataSource = Ds.Tables("pembelian_obat")
        DgPembelian.AllowUserToAddRows = False
        DgPembelian.ReadOnly = True
    End Sub
End Class
