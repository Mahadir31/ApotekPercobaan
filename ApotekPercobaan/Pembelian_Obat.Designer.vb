<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pembelian_Obat
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
        Me.KodeObat = New System.Windows.Forms.TextBox()
        Me.NamaObat = New System.Windows.Forms.TextBox()
        Me.HargaObat = New System.Windows.Forms.TextBox()
        Me.JumlahObat = New System.Windows.Forms.TextBox()
        Me.JenisObat = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DtExp = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LblKodePetugas = New System.Windows.Forms.Label()
        Me.DgPembelian = New System.Windows.Forms.DataGridView()
        Me.Btntambah = New System.Windows.Forms.Button()
        Me.Btnubah = New System.Windows.Forms.Button()
        Me.Btnhapus = New System.Windows.Forms.Button()
        Me.Btnkeluar = New System.Windows.Forms.Button()
        Me.DtPembelian = New System.Windows.Forms.DateTimePicker()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        CType(Me.DgPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Obat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Obat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal Pembelian"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Exp"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Harga Obat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jumlah Obat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Jenis Obat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(372, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Kode Petugas"
        '
        'KodeObat
        '
        Me.KodeObat.Location = New System.Drawing.Point(149, 76)
        Me.KodeObat.Name = "KodeObat"
        Me.KodeObat.Size = New System.Drawing.Size(100, 20)
        Me.KodeObat.TabIndex = 8
        '
        'NamaObat
        '
        Me.NamaObat.Location = New System.Drawing.Point(149, 102)
        Me.NamaObat.Name = "NamaObat"
        Me.NamaObat.Size = New System.Drawing.Size(144, 20)
        Me.NamaObat.TabIndex = 9
        '
        'HargaObat
        '
        Me.HargaObat.Location = New System.Drawing.Point(149, 180)
        Me.HargaObat.Name = "HargaObat"
        Me.HargaObat.Size = New System.Drawing.Size(100, 20)
        Me.HargaObat.TabIndex = 12
        '
        'JumlahObat
        '
        Me.JumlahObat.Location = New System.Drawing.Point(149, 206)
        Me.JumlahObat.Name = "JumlahObat"
        Me.JumlahObat.Size = New System.Drawing.Size(58, 20)
        Me.JumlahObat.TabIndex = 13
        '
        'JenisObat
        '
        Me.JenisObat.Location = New System.Drawing.Point(149, 232)
        Me.JenisObat.Name = "JenisObat"
        Me.JenisObat.Size = New System.Drawing.Size(100, 20)
        Me.JenisObat.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(132, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(132, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 15)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(132, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 15)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(132, 156)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 15)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(132, 182)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(11, 15)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(132, 208)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 15)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(132, 233)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 15)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = ":"
        '
        'DtExp
        '
        Me.DtExp.CustomFormat = "dd/MM/yyyy"
        Me.DtExp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtExp.Location = New System.Drawing.Point(149, 154)
        Me.DtExp.Name = "DtExp"
        Me.DtExp.Size = New System.Drawing.Size(85, 20)
        Me.DtExp.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(459, 78)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 15)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = ":"
        '
        'LblKodePetugas
        '
        Me.LblKodePetugas.AutoSize = True
        Me.LblKodePetugas.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKodePetugas.Location = New System.Drawing.Point(476, 78)
        Me.LblKodePetugas.Name = "LblKodePetugas"
        Me.LblKodePetugas.Size = New System.Drawing.Size(81, 15)
        Me.LblKodePetugas.TabIndex = 25
        Me.LblKodePetugas.Text = "Kode Petugas"
        '
        'DgPembelian
        '
        Me.DgPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgPembelian.Location = New System.Drawing.Point(12, 296)
        Me.DgPembelian.Name = "DgPembelian"
        Me.DgPembelian.Size = New System.Drawing.Size(542, 153)
        Me.DgPembelian.TabIndex = 26
        '
        'Btntambah
        '
        Me.Btntambah.Location = New System.Drawing.Point(12, 258)
        Me.Btntambah.Name = "Btntambah"
        Me.Btntambah.Size = New System.Drawing.Size(75, 32)
        Me.Btntambah.TabIndex = 27
        Me.Btntambah.Text = "TAMBAH"
        Me.Btntambah.UseVisualStyleBackColor = True
        '
        'Btnubah
        '
        Me.Btnubah.Location = New System.Drawing.Point(93, 258)
        Me.Btnubah.Name = "Btnubah"
        Me.Btnubah.Size = New System.Drawing.Size(75, 32)
        Me.Btnubah.TabIndex = 28
        Me.Btnubah.Text = "UBAH"
        Me.Btnubah.UseVisualStyleBackColor = True
        '
        'Btnhapus
        '
        Me.Btnhapus.Location = New System.Drawing.Point(174, 258)
        Me.Btnhapus.Name = "Btnhapus"
        Me.Btnhapus.Size = New System.Drawing.Size(75, 32)
        Me.Btnhapus.TabIndex = 29
        Me.Btnhapus.Text = "HAPUS"
        Me.Btnhapus.UseVisualStyleBackColor = True
        '
        'Btnkeluar
        '
        Me.Btnkeluar.Location = New System.Drawing.Point(479, 258)
        Me.Btnkeluar.Name = "Btnkeluar"
        Me.Btnkeluar.Size = New System.Drawing.Size(75, 32)
        Me.Btnkeluar.TabIndex = 30
        Me.Btnkeluar.Text = "KELUAR"
        Me.Btnkeluar.UseVisualStyleBackColor = True
        '
        'DtPembelian
        '
        Me.DtPembelian.CustomFormat = "dd/MM/yyyy"
        Me.DtPembelian.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtPembelian.Location = New System.Drawing.Point(149, 128)
        Me.DtPembelian.Name = "DtPembelian"
        Me.DtPembelian.Size = New System.Drawing.Size(85, 20)
        Me.DtPembelian.TabIndex = 8
        '
        'TxtCari
        '
        Me.TxtCari.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCari.Location = New System.Drawing.Point(273, 264)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(180, 22)
        Me.TxtCari.TabIndex = 32
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(325, 244)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 15)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "CARI OBAT"
        '
        'Pembelian_Obat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtCari)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.DtPembelian)
        Me.Controls.Add(Me.Btnkeluar)
        Me.Controls.Add(Me.Btnhapus)
        Me.Controls.Add(Me.Btnubah)
        Me.Controls.Add(Me.Btntambah)
        Me.Controls.Add(Me.DgPembelian)
        Me.Controls.Add(Me.LblKodePetugas)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.DtExp)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.JenisObat)
        Me.Controls.Add(Me.JumlahObat)
        Me.Controls.Add(Me.HargaObat)
        Me.Controls.Add(Me.NamaObat)
        Me.Controls.Add(Me.KodeObat)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pembelian_Obat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DgPembelian, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents KodeObat As TextBox
    Friend WithEvents NamaObat As TextBox
    Friend WithEvents HargaObat As TextBox
    Friend WithEvents JumlahObat As TextBox
    Friend WithEvents JenisObat As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents DtExp As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents LblKodePetugas As Label
    Friend WithEvents DgPembelian As DataGridView
    Friend WithEvents Btntambah As Button
    Friend WithEvents Btnubah As Button
    Friend WithEvents Btnhapus As Button
    Friend WithEvents Btnkeluar As Button
    Friend WithEvents DtPembelian As DateTimePicker
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents Label18 As Label
End Class
