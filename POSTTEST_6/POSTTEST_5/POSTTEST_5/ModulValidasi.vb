Module ModulValidasi

    ' 1. Mengecek apakah ada TextBox/ComboBox yang kosong
    ' Menggunakan ParamArray agar bisa mengecek banyak form sekaligus
    Public Function FormAdaYangKosong(ByVal ParamArray controls() As Control) As Boolean
        For Each ctrl As Control In controls
            If String.IsNullOrWhiteSpace(ctrl.Text) Then
                MsgBox("Mohon lengkapi semua data! Kolom tidak boleh ada yang kosong.", MsgBoxStyle.Exclamation, "Validasi Gagal")
                ctrl.Focus()
                Return True ' Mengembalikan True berarti ADA yang kosong
            End If
        Next
        Return False ' Mengembalikan False berarti semua form TERISI
    End Function

    ' 2. Membatasi input agar hanya bisa diketik Angka (Untuk textbox Harga / No. Telepon)
    ' Cara pakai: Panggil di event KeyPress pada TextBox
    Public Sub HanyaAngka(ByVal e As KeyPressEventArgs)
        ' Mengizinkan angka (Digit) dan tombol kontrol seperti Backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Membatalkan input jika bukan angka
        End If
    End Sub

    ' 3. Membersihkan Form (Clear)
    Public Sub BersihkanForm(ByVal parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim cmb As ComboBox = CType(ctrl, ComboBox)
                cmb.SelectedIndex = -1
                cmb.Text = ""
            End If
        Next
    End Sub

End Module