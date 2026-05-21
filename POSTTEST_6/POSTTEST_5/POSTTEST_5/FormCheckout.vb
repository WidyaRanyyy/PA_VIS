Imports MySqlConnector
Imports System.Drawing.Printing

Public Class FormCheckOut

    ' --- 1. SUB LOADING DATA TAMU AKTIF DENGAN NOMOR URUT DINAMIS (MULAI 1) ---
    Private Sub LoadTamuAktif()
        Try
            Using conn As MySqlConnection = ConnectionModule.GetConnection()
                ' Ambil data tamu yang belum checkout
                Dim query As String = "SELECT t.id_checkin, t.nama_tamu FROM tamu t LEFT JOIN transaksi tr ON t.id_checkin = tr.id_checkin WHERE tr.id_transaksi IS NULL ORDER BY t.id_checkin ASC"
                Using cmd As New MySqlCommand(query, conn)
                    conn.Open()
                    Using rd As MySqlDataReader = cmd.ExecuteReader()

                        Dim comboSource As New Dictionary(Of String, String)()
                        Dim noUrut As Integer = 1

                        While rd.Read()
                            Dim idAsliDb As String = rd("id_checkin").ToString()
                            Dim namaTamu As String = rd("nama_tamu").ToString()

                            ' Format teks tampilan menjadi "1 - nama", "2 - nama", dst.
                            Dim teksTampilan As String = noUrut.ToString() & " - " & namaTamu

                            ' Key = ID Asli DB (13), Value = Teks Tampilan ("1 - nn")
                            comboSource.Add(idAsliDb, teksTampilan)

                            noUrut += 1
                        End While

                        ' Ikat data ke ComboBox
                        If comboSource.Count > 0 Then
                            cmbPilihTamu.DataSource = New BindingSource(comboSource, Nothing)
                            cmbPilihTamu.DisplayMember = "Value"
                            cmbPilihTamu.ValueMember = "Key"
                        Else
                            cmbPilihTamu.DataSource = Nothing
                            cmbPilihTamu.Items.Clear()
                        End If

                        cmbPilihTamu.SelectedIndex = -1
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat list tamu aktif: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- 2. EVENT SAAT FORM LOAD ---
    Private Sub FormCheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbMetodeBayar.Items.Clear()
        cmbMetodeBayar.Items.Add("Tunai")
        cmbMetodeBayar.Items.Add("Transfer Bank")
        cmbMetodeBayar.Items.Add("QRIS")
        cmbMetodeBayar.Items.Add("Kartu Kredit")

        LoadTamuAktif()
    End Sub

    ' --- 3. EVENT SAAT NAMA TAMU DIPILIH ---
    Private Sub cmbPilihTamu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPilihTamu.SelectedIndexChanged
        If cmbPilihTamu.SelectedIndex = -1 OrElse cmbPilihTamu.SelectedValue Is Nothing OrElse Not TypeOf cmbPilihTamu.SelectedValue Is String Then
            Exit Sub
        End If

        Dim idCheckIn As String = cmbPilihTamu.SelectedValue.ToString()

        Try
            Using conn As MySqlConnection = ConnectionModule.GetConnection()
                Dim query As String = "SELECT t.nomor_kamar, t.tanggal, k.harga FROM tamu t LEFT JOIN kamar k ON t.nomor_kamar = k.nomor_kamar WHERE t.id_checkin = @id"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idCheckIn)
                    conn.Open()
                    Using rd As MySqlDataReader = cmd.ExecuteReader()
                        If rd.Read() Then
                            txtKamar.Text = rd("nomor_kamar").ToString()
                            txtTglCheckIn.Text = Convert.ToDateTime(rd("tanggal")).ToString("dd-MM-yyyy")

                            If IsDBNull(rd("harga")) Then
                                txtHarga.Text = "0"
                                MessageBox.Show("Peringatan: Kamar " & txtKamar.Text & " tidak ditemukan di data Master Kamar. Harga di-set Rp 0.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                txtHarga.Text = rd("harga").ToString()
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menarik detail data tamu: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- 4. TOMBOL HITUNG TOTAL TAGIHAN ---
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        If txtTglCheckIn.Text = "" Then
            MessageBox.Show("Silakan pilih tamu terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim tglMasuk As DateTime = DateTime.ParseExact(txtTglCheckIn.Text, "dd-MM-yyyy", Nothing)
        Dim tglKeluar As DateTime = dtpCheckOut.Value.Date
        Dim lamaInap As Integer = (tglKeluar - tglMasuk).Days

        If lamaInap = 0 Then lamaInap = 1

        If lamaInap < 0 Then
            MessageBox.Show("Tanggal Check-Out tidak boleh lebih kecil dari tanggal masuk!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        txtLamaMenginap.Text = lamaInap.ToString()

        Dim harga As Integer = Convert.ToInt32(txtHarga.Text)
        Dim totalTagihan As Integer = lamaInap * harga
        txtTotalTagihan.Text = totalTagihan.ToString()
    End Sub

    ' --- 5. TOMBOL PROSES BAYAR & CHECK-OUT ---
    Private Sub btnProsesBayar_Click(sender As Object, e As EventArgs) Handles btnProsesBayar.Click
        If txtTotalTagihan.Text = "" Or cmbMetodeBayar.SelectedIndex = -1 Then
            MessageBox.Show("Silakan hitung tagihan dan pilih metode pembayaran terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idCheckIn As String = cmbPilihTamu.SelectedValue.ToString()
        Dim tglKeluarSQL As String = dtpCheckOut.Value.ToString("yyyy-MM-dd")

        Try
            Using conn As MySqlConnection = ConnectionModule.GetConnection()
                conn.Open()
                Using tr As MySqlTransaction = conn.BeginTransaction()
                    Try
                        ' A. Simpan ke tabel Transaksi
                        Dim queryInsert As String = "INSERT INTO transaksi (id_checkin, tgl_checkout, lama_menginap, total_tagihan, metode_bayar) VALUES (@id, @tgl, @lama, @total, @metode)"
                        Using cmd1 As New MySqlCommand(queryInsert, conn, tr)
                            cmd1.Parameters.AddWithValue("@id", idCheckIn)
                            cmd1.Parameters.AddWithValue("@tgl", tglKeluarSQL)
                            cmd1.Parameters.AddWithValue("@lama", txtLamaMenginap.Text)
                            cmd1.Parameters.AddWithValue("@total", txtTotalTagihan.Text)
                            cmd1.Parameters.AddWithValue("@metode", cmbMetodeBayar.Text)
                            cmd1.ExecuteNonQuery()
                        End Using

                        ' B. Update status kamar menjadi 'Kotor'
                        Dim queryUpdate As String = "UPDATE kamar SET status = 'Kotor' WHERE nomor_kamar = @kamar"
                        Using cmd2 As New MySqlCommand(queryUpdate, conn, tr)
                            cmd2.Parameters.AddWithValue("@kamar", txtKamar.Text)
                            cmd2.ExecuteNonQuery()
                        End Using

                        tr.Commit()
                        MessageBox.Show("Pembayaran sukses! Kamar " & txtKamar.Text & " sekarang berstatus 'Kotor'.", "Sukses Transaksi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Bersihkan isi form inputan
                        txtKamar.Clear()
                        txtHarga.Clear()
                        txtTglCheckIn.Clear()
                        txtLamaMenginap.Clear()
                        txtTotalTagihan.Clear()
                        cmbMetodeBayar.SelectedIndex = -1

                        ' Muat ulang data ComboBox
                        LoadTamuAktif()

                    Catch exTrans As Exception
                        tr.Rollback()
                        Dim ex As Exception = exTrans
                        Throw ex
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memproses transaksi data check-out: " & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- 6. CETAK NOTA (SUDAH DIPERBAIKI) ---
    Private Sub docLaporan_PrintPage(sender As Object, e As PrintPageEventArgs) Handles docLaporan.PrintPage
        Dim fontJudul As New Font("Arial", 16, FontStyle.Bold)
        Dim fontSubJudul As New Font("Arial", 12, FontStyle.Italic)
        Dim fontIsi As New Font("Arial", 12, FontStyle.Regular)
        Dim fontTebal As New Font("Arial", 12, FontStyle.Bold)
        Dim brush As New SolidBrush(Color.Black)

        Dim startX As Integer = 50
        Dim startY As Integer = 50
        Dim offset As Integer = 40

        ' FIX: Deklarasi nama variabel digabung (namaTamuMurni) agar tidak menyebabkan error compile
        Dim namaTamuMurni As String = cmbPilihTamu.Text
        If cmbPilihTamu.Text.Contains("-") Then
            namaTamuMurni = cmbPilihTamu.Text.Split("-"c)(1).Trim()
        End If

        e.Graphics.DrawString("NOTA PEMBAYARAN HOTEL", fontJudul, brush, startX, startY)
        startY += offset
        e.Graphics.DrawString("---------------------------------------------------------------", fontIsi, brush, startX, startY)
        startY += 30

        e.Graphics.DrawString("Nama Tamu         : " & namaTamuMurni, fontIsi, brush, startX, startY)
        startY += 30
        e.Graphics.DrawString("Nomor Kamar       : " & txtKamar.Text, fontIsi, brush, startX, startY)
        startY += 30
        e.Graphics.DrawString("Tanggal Check-In  : " & txtTglCheckIn.Text, fontIsi, brush, startX, startY)
        startY += 30
        e.Graphics.DrawString("Tanggal Check-Out : " & dtpCheckOut.Value.ToString("dd-MM-yyyy"), fontIsi, brush, startX, startY)
        startY += 30
        e.Graphics.DrawString("Lama Menginap     : " & txtLamaMenginap.Text & " Hari", fontIsi, brush, startX, startY)
        startY += 30
        e.Graphics.DrawString("Metode Bayar      : " & cmbMetodeBayar.Text, fontIsi, brush, startX, startY)

        startY += offset
        e.Graphics.DrawString("---------------------------------------------------------------", fontIsi, brush, startX, startY)
        startY += 30

        e.Graphics.DrawString("TOTAL TAGIHAN     : Rp " & txtTotalTagihan.Text, fontTebal, brush, startX, startY)
        startY += 50
        e.Graphics.DrawString("Terima kasih atas kunjungan Anda!", fontSubJudul, brush, startX, startY)
    End Sub

    Private Sub btnPreviewCetak_Click(sender As Object, e As EventArgs) Handles btnPreviewCetak.Click
        If txtTotalTagihan.Text = "" Then
            MessageBox.Show("Data belum lengkap atau belum dihitung!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        dlgPreview.Document = docLaporan
        dlgPreview.ShowDialog()
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If txtTotalTagihan.Text = "" Then
            MessageBox.Show("Data belum lengkap atau belum dihitung!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        docLaporan.Print()
    End Sub

End Class