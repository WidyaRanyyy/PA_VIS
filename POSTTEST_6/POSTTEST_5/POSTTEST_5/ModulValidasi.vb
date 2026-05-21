Module ModulValidasi

    ' 1. Mengecek apakah ada TextBox/ComboBox yang kosong
    Public Function FormAdaYangKosong(ByVal ParamArray controls() As Control) As Boolean
        For Each ctrl As Control In controls
            If String.IsNullOrWhiteSpace(ctrl.Text) Then
                MsgBox("Mohon lengkapi semua data! Kolom tidak boleh ada yang kosong.", MsgBoxStyle.Exclamation, "Validasi Gagal")
                ctrl.Focus()
                Return True
            End If
        Next
        Return False
    End Function

    ' 2. Membatasi input agar hanya bisa diketik Angka (Untuk textbox Harga / No. Telepon
    Public Sub HanyaAngka(ByVal e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
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
