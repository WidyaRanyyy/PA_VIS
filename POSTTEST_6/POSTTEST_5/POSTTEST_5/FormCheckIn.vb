Imports MySqlConnector

Public Class FormCheckIn

    ' --- 1. SUB REFRESH & TAMPILKAN DATA ---
    Private Sub TampilData()
        Try
            ' Query: Hanya menampilkan tamu yang BELUM check-out
            Dim query As String = "SELECT t.id_checkin, t.nama_tamu, t.nomor_kamar, t.tanggal " &
                                  "FROM tamu t LEFT JOIN transaksi tr ON t.id_checkin = tr.id_checkin " &
                                  "WHERE tr.id_transaksi IS NULL ORDER BY t.id_checkin DESC"

            Dim dt As DataTable = ModulData.AmbilData(query)
            dgvCheckIn.DataSource = dt

            ' Atur nama header kolom DataGridView dan sembunyikan ID Sistem database
            If dgvCheckIn.Columns.Count > 0 Then
                dgvCheckIn.Columns(0).HeaderText = "ID Database"
                dgvCheckIn.Columns(0).Visible = False ' Menyembunyikan angka ID asli database dari user

                dgvCheckIn.Columns(1).HeaderText = "Nama Tamu"
                dgvCheckIn.Columns(2).HeaderText = "No. Kamar"
                dgvCheckIn.Columns(3).HeaderText = "Tanggal Masuk"
            End If

            ' Jalankan pembuatan nomor urut dinamis (1, 2, 3...) di baris paling kiri
            AturNomorUrutGrid()

        Catch ex As Exception
            MessageBox.Show("Gagal memuat data tabel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- 2. SUB MEMBUAT NOMOR URUT DINAMIS (MULAI DARI 1) ---
    Private Sub AturNomorUrutGrid()
        RemoveHandler dgvCheckIn.RowPostPaint, AddressOf dgvCheckIn_RowPostPaint
        AddHandler dgvCheckIn.RowPostPaint, AddressOf dgvCheckIn_RowPostPaint
        dgvCheckIn.RowHeadersWidth = 50
    End Sub

    Private Sub dgvCheckIn_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs)
        Dim grid As DataGridView = CType(sender, DataGridView)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()

        Dim centerFormat As New StringFormat() With {
            .Alignment = StringAlignment.Center,
            .LineAlignment = StringAlignment.Center
        }

        Dim headerBounds As New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)
        e.Graphics.DrawString(rowIdx, Me.Font, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub

    ' --- 3. SUB LOADING DATA KAMAR KE COMBOBOX ---
    Private Sub IsiComboBoxKamar()
        Try
            Dim query As String = "SELECT nomor_kamar FROM kamar WHERE status = 'Tersedia'"
            Dim dt As DataTable = ModulData.AmbilData(query)

            cmbKamar.Items.Clear()
            For Each row As DataRow In dt.Rows
                cmbKamar.Items.Add(row("nomor_kamar").ToString())
            Next
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data kamar kosong: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- 4. EVENT SAAT FORM LOAD ---
    Private Sub FormCheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        IsiComboBoxKamar()
    End Sub

    ' --- 5. TOMBOL SIMPAN (PROSES CHECK-IN) ---
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNama.Text.Trim() = "" Or cmbKamar.SelectedIndex = -1 Then
            MessageBox.Show("Nama Tamu dan Nomor Kamar harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = ConnectionModule.GetConnection()
                conn.Open()
                Using tr As MySqlTransaction = conn.BeginTransaction()
                    Try
                        ' A. Simpan data tamu baru
                        Dim queryTamu As String = "INSERT INTO tamu (nama_tamu, nomor_kamar, tanggal) VALUES (@nama, @kamar, @tgl)"
                        Using cmd1 As New MySqlCommand(queryTamu, conn, tr)
                            cmd1.Parameters.AddWithValue("@nama", txtNama.Text.Trim())
                            cmd1.Parameters.AddWithValue("@kamar", cmbKamar.Text)
                            cmd1.Parameters.AddWithValue("@tgl", dtpTanggal.Value.ToString("yyyy-MM-dd"))
                            cmd1.ExecuteNonQuery()
                        End Using

                        ' B. Ubah status kamar menjadi 'Terisi'
                        Dim queryUpdateKamar As String = "UPDATE kamar SET status = 'Terisi' WHERE nomor_kamar = @kamar"
                        Using cmd2 As New MySqlCommand(queryUpdateKamar, conn, tr)
                            cmd2.Parameters.AddWithValue("@kamar", cmbKamar.Text)
                            cmd2.ExecuteNonQuery()
                        End Using

                        tr.Commit()
                        MessageBox.Show("Data Tamu berhasil disimpan!", "Sukses Check-In", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Catch exTrans As Exception
                        tr.Rollback()
                        Dim ex As Exception = exTrans
                        Throw ex
                    End Try
                End Using
            End Using

            TampilData()
            IsiComboBoxKamar()

            txtNama.Clear()
            cmbKamar.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan simpan: " & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- 6. TOMBOL HAPUS DATA TAMU ---
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvCheckIn.CurrentRow IsNot Nothing AndAlso dgvCheckIn.CurrentRow.Index >= 0 Then

            Dim idHapus As String = dgvCheckIn.CurrentRow.Cells(0).Value.ToString()
            Dim noKamarTamu As String = dgvCheckIn.CurrentRow.Cells(2).Value.ToString()

            Dim konfirmasi As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data tamu ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If konfirmasi = DialogResult.Yes Then
                Try
                    Using conn As MySqlConnection = ConnectionModule.GetConnection()
                        conn.Open()
                        Using tr As MySqlTransaction = conn.BeginTransaction()
                            Try
                                ' A. Hapus data tamu dari database
                                Dim queryDelete As String = "DELETE FROM tamu WHERE id_checkin = @id"
                                Using cmd1 As New MySqlCommand(queryDelete, conn, tr)
                                    cmd1.Parameters.AddWithValue("@id", idHapus)
                                    cmd1.ExecuteNonQuery()
                                End Using

                                ' B. Kembalikan status kamar jadi 'Tersedia'
                                Dim queryKamar As String = "UPDATE kamar SET status = 'Tersedia' WHERE nomor_kamar = @kamar"
                                Using cmd2 As New MySqlCommand(queryKamar, conn, tr)
                                    cmd2.Parameters.AddWithValue("@kamar", noKamarTamu)
                                    cmd2.ExecuteNonQuery()
                                End Using

                                tr.Commit()
                                MessageBox.Show("Data tamu berhasil dihapus dan kamar dikosongkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Catch exTrans As Exception
                                tr.Rollback()
                                Dim ex As Exception = exTrans
                                Throw ex
                            End Try
                        End Using
                    End Using

                    TampilData()
                    IsiComboBoxKamar()

                Catch ex As Exception
                    MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Silakan klik/pilih baris data yang ingin dihapus pada tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class