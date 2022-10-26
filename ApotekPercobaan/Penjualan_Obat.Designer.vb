<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penjualan_Obat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CbNamaObat = New System.Windows.Forms.ComboBox()
        Me.JumlahObat = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.NoPenjualan = New System.Windows.Forms.Label()
        Me.KodeObat = New System.Windows.Forms.Label()
        Me.JenisObat = New System.Windows.Forms.Label()
        Me.HargaObat = New System.Windows.Forms.Label()
        Me.TglPinjam = New System.Windows.Forms.Label()
        Me.KodePetugas = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TotalHarga = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AlamatPembeli = New System.Windows.Forms.TextBox()
        Me.NamaPembeli = New System.Windows.Forms.TextBox()
        Me.KodePembeli = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Bayar = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Kembalian = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Dgpenjualn = New System.Windows.Forms.DataGridView()
        Me.Btnsimpan = New System.Windows.Forms.Button()
        Me.Btnkeluar = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DtPenjualan = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dgpenjualn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Penjualan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Obat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Obata"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Obat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Harga Obat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Exp"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Jumlah Obat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(335, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Kode Petugas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(335, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Tgl Penjualan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(96, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = ":"
        '
        'CbNamaObat
        '
        Me.CbNamaObat.FormattingEnabled = True
        Me.CbNamaObat.Location = New System.Drawing.Point(116, 121)
        Me.CbNamaObat.Name = "CbNamaObat"
        Me.CbNamaObat.Size = New System.Drawing.Size(121, 21)
        Me.CbNamaObat.TabIndex = 10
        '
        'JumlahObat
        '
        Me.JumlahObat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JumlahObat.Location = New System.Drawing.Point(116, 258)
        Me.JumlahObat.Name = "JumlahObat"
        Me.JumlahObat.Size = New System.Drawing.Size(60, 22)
        Me.JumlahObat.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(96, 263)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 15)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(96, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 15)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(96, 192)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(11, 15)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(96, 228)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 15)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(96, 123)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 15)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(96, 91)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 15)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(425, 60)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(11, 15)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = ":"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(425, 91)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(11, 15)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = ":"
        '
        'NoPenjualan
        '
        Me.NoPenjualan.AutoSize = True
        Me.NoPenjualan.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoPenjualan.Location = New System.Drawing.Point(113, 60)
        Me.NoPenjualan.Name = "NoPenjualan"
        Me.NoPenjualan.Size = New System.Drawing.Size(80, 15)
        Me.NoPenjualan.TabIndex = 20
        Me.NoPenjualan.Text = "No Penjualan"
        '
        'KodeObat
        '
        Me.KodeObat.AutoSize = True
        Me.KodeObat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeObat.Location = New System.Drawing.Point(113, 91)
        Me.KodeObat.Name = "KodeObat"
        Me.KodeObat.Size = New System.Drawing.Size(63, 15)
        Me.KodeObat.TabIndex = 21
        Me.KodeObat.Text = "Kode Obat"
        '
        'JenisObat
        '
        Me.JenisObat.AutoSize = True
        Me.JenisObat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JenisObat.Location = New System.Drawing.Point(113, 228)
        Me.JenisObat.Name = "JenisObat"
        Me.JenisObat.Size = New System.Drawing.Size(66, 15)
        Me.JenisObat.TabIndex = 22
        Me.JenisObat.Text = "Jenis Obat"
        '
        'HargaObat
        '
        Me.HargaObat.AutoSize = True
        Me.HargaObat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HargaObat.Location = New System.Drawing.Point(113, 192)
        Me.HargaObat.Name = "HargaObat"
        Me.HargaObat.Size = New System.Drawing.Size(70, 15)
        Me.HargaObat.TabIndex = 23
        Me.HargaObat.Text = "Harga Obat"
        '
        'TglPinjam
        '
        Me.TglPinjam.AutoSize = True
        Me.TglPinjam.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TglPinjam.Location = New System.Drawing.Point(442, 60)
        Me.TglPinjam.Name = "TglPinjam"
        Me.TglPinjam.Size = New System.Drawing.Size(84, 15)
        Me.TglPinjam.TabIndex = 25
        Me.TglPinjam.Text = "Tgl Penjualan"
        '
        'KodePetugas
        '
        Me.KodePetugas.AutoSize = True
        Me.KodePetugas.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodePetugas.Location = New System.Drawing.Point(442, 91)
        Me.KodePetugas.Name = "KodePetugas"
        Me.KodePetugas.Size = New System.Drawing.Size(81, 15)
        Me.KodePetugas.TabIndex = 26
        Me.KodePetugas.Text = "Kode Petugas"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(96, 290)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(11, 15)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = ":"
        '
        'TotalHarga
        '
        Me.TotalHarga.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalHarga.Location = New System.Drawing.Point(116, 285)
        Me.TotalHarga.Name = "TotalHarga"
        Me.TotalHarga.Size = New System.Drawing.Size(88, 22)
        Me.TotalHarga.TabIndex = 28
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(10, 290)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 15)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "Total Harga"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AlamatPembeli)
        Me.GroupBox1.Controls.Add(Me.NamaPembeli)
        Me.GroupBox1.Controls.Add(Me.KodePembeli)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(339, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 134)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PEMBEI"
        '
        'AlamatPembeli
        '
        Me.AlamatPembeli.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlamatPembeli.Location = New System.Drawing.Point(124, 104)
        Me.AlamatPembeli.Name = "AlamatPembeli"
        Me.AlamatPembeli.Size = New System.Drawing.Size(118, 22)
        Me.AlamatPembeli.TabIndex = 38
        '
        'NamaPembeli
        '
        Me.NamaPembeli.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaPembeli.Location = New System.Drawing.Point(124, 68)
        Me.NamaPembeli.Name = "NamaPembeli"
        Me.NamaPembeli.Size = New System.Drawing.Size(118, 22)
        Me.NamaPembeli.TabIndex = 37
        '
        'KodePembeli
        '
        Me.KodePembeli.AutoSize = True
        Me.KodePembeli.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodePembeli.Location = New System.Drawing.Point(124, 37)
        Me.KodePembeli.Name = "KodePembeli"
        Me.KodePembeli.Size = New System.Drawing.Size(81, 15)
        Me.KodePembeli.TabIndex = 33
        Me.KodePembeli.Text = "Kode Pembeli"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(107, 107)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(11, 15)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = ":"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(107, 71)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(11, 15)
        Me.Label25.TabIndex = 29
        Me.Label25.Text = ":"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(107, 37)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(11, 15)
        Me.Label26.TabIndex = 28
        Me.Label26.Text = ":"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(9, 37)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(81, 15)
        Me.Label27.TabIndex = 27
        Me.Label27.Text = "Kode Pembeli"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(9, 71)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(85, 15)
        Me.Label28.TabIndex = 26
        Me.Label28.Text = "Nama Pembeli"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(9, 107)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(93, 15)
        Me.Label29.TabIndex = 25
        Me.Label29.Text = "Alamat Pembeli"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(273, 290)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(11, 15)
        Me.Label30.TabIndex = 33
        Me.Label30.Text = ":"
        '
        'Bayar
        '
        Me.Bayar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bayar.Location = New System.Drawing.Point(290, 287)
        Me.Bayar.Name = "Bayar"
        Me.Bayar.Size = New System.Drawing.Size(87, 22)
        Me.Bayar.TabIndex = 32
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(227, 290)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(40, 15)
        Me.Label31.TabIndex = 31
        Me.Label31.Text = "Bayar"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(483, 290)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(11, 15)
        Me.Label32.TabIndex = 36
        Me.Label32.Text = ":"
        '
        'Kembalian
        '
        Me.Kembalian.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kembalian.Location = New System.Drawing.Point(500, 287)
        Me.Kembalian.Name = "Kembalian"
        Me.Kembalian.Size = New System.Drawing.Size(84, 22)
        Me.Kembalian.TabIndex = 35
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(412, 292)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(65, 15)
        Me.Label33.TabIndex = 34
        Me.Label33.Text = "Kembalian"
        '
        'Dgpenjualn
        '
        Me.Dgpenjualn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgpenjualn.Location = New System.Drawing.Point(13, 368)
        Me.Dgpenjualn.Name = "Dgpenjualn"
        Me.Dgpenjualn.Size = New System.Drawing.Size(571, 138)
        Me.Dgpenjualn.TabIndex = 37
        '
        'Btnsimpan
        '
        Me.Btnsimpan.Location = New System.Drawing.Point(13, 320)
        Me.Btnsimpan.Name = "Btnsimpan"
        Me.Btnsimpan.Size = New System.Drawing.Size(75, 42)
        Me.Btnsimpan.TabIndex = 38
        Me.Btnsimpan.Text = "SIMPAN"
        Me.Btnsimpan.UseVisualStyleBackColor = True
        '
        'Btnkeluar
        '
        Me.Btnkeluar.Location = New System.Drawing.Point(509, 320)
        Me.Btnkeluar.Name = "Btnkeluar"
        Me.Btnkeluar.Size = New System.Drawing.Size(75, 42)
        Me.Btnkeluar.TabIndex = 39
        Me.Btnkeluar.Text = "KELUAR"
        Me.Btnkeluar.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(203, 9)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(188, 23)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "PENJUALAN OBAT"
        '
        'DtPenjualan
        '
        Me.DtPenjualan.CustomFormat = "dd/MM/yyyy"
        Me.DtPenjualan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtPenjualan.Location = New System.Drawing.Point(119, 158)
        Me.DtPenjualan.Name = "DtPenjualan"
        Me.DtPenjualan.Size = New System.Drawing.Size(85, 20)
        Me.DtPenjualan.TabIndex = 41
        '
        'Penjualan_Obat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 518)
        Me.ControlBox = False
        Me.Controls.Add(Me.DtPenjualan)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Btnkeluar)
        Me.Controls.Add(Me.Btnsimpan)
        Me.Controls.Add(Me.Dgpenjualn)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Kembalian)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Bayar)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TotalHarga)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.KodePetugas)
        Me.Controls.Add(Me.TglPinjam)
        Me.Controls.Add(Me.HargaObat)
        Me.Controls.Add(Me.JenisObat)
        Me.Controls.Add(Me.KodeObat)
        Me.Controls.Add(Me.NoPenjualan)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.JumlahObat)
        Me.Controls.Add(Me.CbNamaObat)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Penjualan_Obat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penjualan_Obat"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dgpenjualn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CbNamaObat As ComboBox
    Friend WithEvents JumlahObat As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents NoPenjualan As Label
    Friend WithEvents KodeObat As Label
    Friend WithEvents JenisObat As Label
    Friend WithEvents HargaObat As Label
    Friend WithEvents TglPinjam As Label
    Friend WithEvents KodePetugas As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TotalHarga As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents KodePembeli As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Bayar As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Kembalian As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents AlamatPembeli As TextBox
    Friend WithEvents NamaPembeli As TextBox
    Friend WithEvents Dgpenjualn As DataGridView
    Friend WithEvents Btnsimpan As Button
    Friend WithEvents Btnkeluar As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents DtPenjualan As DateTimePicker
End Class
