Imports MySqlConnector
' Tambahkan System.Data agar sistem mengenali tipe 'DataTable'
Imports System.Data

Module ModulData

    ' 1. Fungsi untuk DML (Insert, Update, Delete)
    Public Function EksekusiData(ByVal query As String) As Boolean
        Try
            ' Menggunakan pola baru GetConnection() dari ConnectionModule
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(query, conn)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Terjadi kesalahan pada Database: " & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error DB")
            Return False
        End Try
        ' Tidak perlu blok 'Finally' dengan 'conn.Close()' lagi karena
        ' 'Using' sudah otomatis menutup koneksi dengan sendirinya.
    End Function

    ' 2. Fungsi untuk DQL (Select)
    Public Function AmbilData(ByVal query As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(query, conn)
                    conn.Open()
                    ' Mengisi DataTable menggunakan DataAdapter
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Gagal mengambil data: " & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error DB")
        End Try

        Return dt
    End Function

End Module