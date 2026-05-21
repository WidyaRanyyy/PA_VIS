Imports MySqlConnector

Public Class FormKamar

    ' 1. Sub Routine untuk menampilkan data dari MySQL ke DataGridView
    Private Sub TampilData()
        Try
            Using conn As MySqlConnection = ConnectionModule.GetConnection()
                Dim query As String = "SELECT * FROM kamar ORDER BY nomor_kamar ASC"
                Using cmd As New MySqlCommand(query, conn)
                    conn.Open()
                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        dgvKamar.DataSource = dt
                    End Using
                End Using
            End Using

            ' Rapikan nama kolom (Opsional)
            If dgvKamar.Columns.Count > 0 Then
                dgvKamar.Columns(0).HeaderText = "No. Kamar"
                dgvKamar.Columns(1).HeaderText = "Tipe Kamar"
                dgvKamar.Columns(2).HeaderText = "Harga (Rp)"
                dgvKamar.Columns(3).HeaderText = "Status"
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data kamar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 2. Sub Routine untuk mengosongkan form setelah aksi selesai
    Private Sub BersihkanForm()
        txtNoKamar.Clear()
        txtHarga.Clear()
        cmbTipe.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
        txtNoKamar.Focus()
    End Sub

    ' ------------------ EVENT HANDLER ------------------

    Private Sub FormKamar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Panggil data dari database saat form pertama kali dibuka
        TampilData()

        ' Setup ComboBox Tipe Kamar
        cmbTipe.Items.Clear()
        cmbTipe.Items.Add("Standard")
        cmbTipe.Items.Add("Deluxe")
        cmbTipe.Items.Add("Suite")
        cmbTipe.Items.Add("VIP")

        ' Setup ComboBox Status Kamar (Disamakan dengan data SQL sebelumnya)
        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("Tersedia")
        cmbStatus.Items.Add("Terisi")
        cmbStatus.Items.Add("Kotor")
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtNoKamar.Text = "" Or txtHarga.Text = "" Or cmbTipe.Text = "" Or cmbStatus.Text = "" Then
            MessageBox.Show("Lengkapi semua data terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = ConnectionModule.GetConnection()
                ' Query INSERT untuk menambah data
                Dim query As String = "INSERT INTO kamar (nomor_kamar, tipe_kamar, harga, status) VALUES (@no, @tipe, @harga, @status)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@no", txtNoKamar.Text)
                    cmd.Parameters.AddWithValue("@tipe", cmbTipe.Text)
                    cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
                    cmd.Parameters.AddWithValue("@status", cmbStatus.Text)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Data kamar berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            BersihkanForm()
        Catch ex As Exception
            MessageBox.Show("Gagal menambah data (Mungkin Nomor Kamar sudah ada): " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtNoKamar.Text = "" Then
            MessageBox.Show("Pilih data yang akan diupdate terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = ConnectionModule.GetConnection()
                ' Query UPDATE untuk mengubah data berdasarkan nomor_kamar
                Dim query As String = "UPDATE kamar SET tipe_kamar=@tipe, harga=@harga, status=@status WHERE nomor_kamar=@no"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@no", txtNoKamar.Text)
                    cmd.Parameters.AddWithValue("@tipe", cmbTipe.Text)
                    cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
                    cmd.Parameters.AddWithValue("@status", cmbStatus.Text)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Data kamar berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            BersihkanForm()
        Catch ex As Exception
            MessageBox.Show("Gagal mengupdate data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtNoKamar.Text = "" Then
            MessageBox.Show("Pilih data yang akan dihapus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Konfirmasi sebelum menghapus
        If MessageBox.Show("Yakin ingin menghapus kamar nomor " & txtNoKamar.Text & "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Using conn As MySqlConnection = ConnectionModule.GetConnection()
                    ' Query DELETE untuk menghapus data berdasarkan nomor_kamar
                    Dim query As String = "DELETE FROM kamar WHERE nomor_kamar=@no"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@no", txtNoKamar.Text)

                        conn.Open()
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Data kamar berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                BersihkanForm()
            Catch ex As Exception
                MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Memasukkan data dari DataGridView ke TextBox saat diklik
    Private Sub dgvKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKamar.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvKamar.Rows(e.RowIndex)
            txtNoKamar.Text = row.Cells(0).Value.ToString()
            cmbTipe.Text = row.Cells(1).Value.ToString()
            txtHarga.Text = row.Cells(2).Value.ToString()
            cmbStatus.Text = row.Cells(3).Value.ToString()
        End If
    End Sub

    ' Event untuk tombol Clear (Jika ada)
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        BersihkanForm()
    End Sub

End Class