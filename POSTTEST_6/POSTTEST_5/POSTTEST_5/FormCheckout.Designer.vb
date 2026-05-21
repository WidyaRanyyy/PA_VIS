<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCheckOut
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCheckOut))
        cmbPilihTamu = New ComboBox()
        txtKamar = New TextBox()
        txtHarga = New TextBox()
        txtTglCheckIn = New TextBox()
        txtLamaMenginap = New TextBox()
        txtTotalTagihan = New TextBox()
        dtpCheckOut = New DateTimePicker()
        cmbMetodeBayar = New ComboBox()
        btnHitung = New Button()
        btnProsesBayar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        docLaporan = New Printing.PrintDocument()
        dlgPreview = New PrintPreviewDialog()
        btnCetak = New Button()
        btnPreviewCetak = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmbPilihTamu
        ' 
        cmbPilihTamu.BackColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        cmbPilihTamu.FlatStyle = FlatStyle.Flat
        cmbPilihTamu.ForeColor = Color.White
        cmbPilihTamu.FormattingEnabled = True
        cmbPilihTamu.Location = New Point(149, 111)
        cmbPilihTamu.Name = "cmbPilihTamu"
        cmbPilihTamu.Size = New Size(190, 38)
        cmbPilihTamu.TabIndex = 0
        ' 
        ' txtKamar
        ' 
        txtKamar.BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        txtKamar.BorderStyle = BorderStyle.FixedSingle
        txtKamar.ForeColor = Color.FromArgb(CByte(250), CByte(204), CByte(21))
        txtKamar.Location = New Point(135, 58)
        txtKamar.Name = "txtKamar"
        txtKamar.ReadOnly = True
        txtKamar.Size = New Size(150, 35)
        txtKamar.TabIndex = 1
        ' 
        ' txtHarga
        ' 
        txtHarga.BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        txtHarga.BorderStyle = BorderStyle.FixedSingle
        txtHarga.ForeColor = Color.White
        txtHarga.Location = New Point(135, 128)
        txtHarga.Name = "txtHarga"
        txtHarga.ReadOnly = True
        txtHarga.Size = New Size(150, 35)
        txtHarga.TabIndex = 2
        ' 
        ' txtTglCheckIn
        ' 
        txtTglCheckIn.BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        txtTglCheckIn.BorderStyle = BorderStyle.FixedSingle
        txtTglCheckIn.ForeColor = Color.White
        txtTglCheckIn.Location = New Point(334, 106)
        txtTglCheckIn.Name = "txtTglCheckIn"
        txtTglCheckIn.ReadOnly = True
        txtTglCheckIn.Size = New Size(276, 35)
        txtTglCheckIn.TabIndex = 3
        ' 
        ' txtLamaMenginap
        ' 
        txtLamaMenginap.BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        txtLamaMenginap.BorderStyle = BorderStyle.FixedSingle
        txtLamaMenginap.ForeColor = Color.White
        txtLamaMenginap.Location = New Point(219, 198)
        txtLamaMenginap.Name = "txtLamaMenginap"
        txtLamaMenginap.ReadOnly = True
        txtLamaMenginap.Size = New Size(60, 35)
        txtLamaMenginap.TabIndex = 4
        ' 
        ' txtTotalTagihan
        ' 
        txtTotalTagihan.BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        txtTotalTagihan.BorderStyle = BorderStyle.FixedSingle
        txtTotalTagihan.Font = New Font("Microsoft Sans Serif", 14.0F)
        txtTotalTagihan.ForeColor = Color.FromArgb(CByte(16), CByte(185), CByte(129))
        txtTotalTagihan.Location = New Point(334, 230)
        txtTotalTagihan.Name = "txtTotalTagihan"
        txtTotalTagihan.ReadOnly = True
        txtTotalTagihan.Size = New Size(276, 39)
        txtTotalTagihan.TabIndex = 5
        txtTotalTagihan.TextAlign = HorizontalAlignment.Right
        ' 
        ' dtpCheckOut
        ' 
        dtpCheckOut.CalendarMonthBackground = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        dtpCheckOut.Location = New Point(554, 113)
        dtpCheckOut.Name = "dtpCheckOut"
        dtpCheckOut.Size = New Size(365, 35)
        dtpCheckOut.TabIndex = 6
        ' 
        ' cmbMetodeBayar
        ' 
        cmbMetodeBayar.BackColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        cmbMetodeBayar.FlatStyle = FlatStyle.Flat
        cmbMetodeBayar.ForeColor = Color.White
        cmbMetodeBayar.FormattingEnabled = True
        cmbMetodeBayar.Location = New Point(700, 180)
        cmbMetodeBayar.Name = "cmbMetodeBayar"
        cmbMetodeBayar.Size = New Size(220, 38)
        cmbMetodeBayar.TabIndex = 7
        cmbMetodeBayar.Text = "Metode Bayar"
        ' 
        ' btnHitung
        ' 
        btnHitung.BackColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        btnHitung.FlatAppearance.BorderSize = 0
        btnHitung.FlatStyle = FlatStyle.Flat
        btnHitung.Font = New Font("Segoe UI Semibold", 10.0F)
        btnHitung.ForeColor = Color.White
        btnHitung.Location = New Point(700, 230)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(220, 45)
        btnHitung.TabIndex = 8
        btnHitung.Text = "Hitung Tagihan"
        btnHitung.UseVisualStyleBackColor = False
        ' 
        ' btnProsesBayar
        ' 
        btnProsesBayar.BackColor = Color.FromArgb(CByte(16), CByte(185), CByte(129))
        btnProsesBayar.FlatAppearance.BorderSize = 0
        btnProsesBayar.FlatStyle = FlatStyle.Flat
        btnProsesBayar.Font = New Font("Segoe UI Semibold", 10.0F)
        btnProsesBayar.ForeColor = Color.White
        btnProsesBayar.Location = New Point(700, 290)
        btnProsesBayar.Name = "btnProsesBayar"
        btnProsesBayar.Size = New Size(220, 45)
        btnProsesBayar.TabIndex = 9
        btnProsesBayar.Text = "Proses Pembayaran"
        btnProsesBayar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        Label1.Location = New Point(35, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 30)
        Label1.TabIndex = 10
        Label1.Text = "Pilih Tamu"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        Label2.Location = New Point(365, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(182, 30)
        Label2.TabIndex = 11
        Label2.Text = "Tanggal CheckOut"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtTotalTagihan)
        GroupBox1.Controls.Add(txtLamaMenginap)
        GroupBox1.Controls.Add(txtTglCheckIn)
        GroupBox1.Controls.Add(txtHarga)
        GroupBox1.Controls.Add(txtKamar)
        GroupBox1.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        GroupBox1.Location = New Point(35, 170)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(640, 300)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Informasi Menginap"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12.0F)
        Label7.ForeColor = Color.FromArgb(CByte(250), CByte(204), CByte(21))
        Label7.Location = New Point(330, 198)
        Label7.Name = "Label7"
        Label7.Size = New Size(159, 32)
        Label7.TabIndex = 17
        Label7.Text = "Total Tagihan"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        Label6.Location = New Point(25, 200)
        Label6.Name = "Label6"
        Label6.Size = New Size(163, 30)
        Label6.TabIndex = 16
        Label6.Text = "Lama Menginap"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        Label5.Location = New Point(330, 60)
        Label5.Name = "Label5"
        Label5.Size = New Size(165, 30)
        Label5.TabIndex = 15
        Label5.Text = "Tanggal CheckIn"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        Label4.Location = New Point(25, 130)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 30)
        Label4.TabIndex = 14
        Label4.Text = "Harga"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        Label3.Location = New Point(25, 60)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 30)
        Label3.TabIndex = 13
        Label3.Text = "No Kamar"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Light", 28.0F)
        Label8.ForeColor = Color.FromArgb(CByte(250), CByte(204), CByte(21))
        Label8.Location = New Point(485, 19)
        Label8.Name = "Label8"
        Label8.Size = New Size(140, 74)
        Label8.TabIndex = 16
        Label8.Text = "OUT"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(285, 18)
        Label9.Name = "Label9"
        Label9.Size = New Size(211, 74)
        Label9.TabIndex = 15
        Label9.Text = "CHECK"
        ' 
        ' docLaporan
        ' 
        ' 
        ' dlgPreview
        ' 
        dlgPreview.AutoScrollMargin = New Size(0, 0)
        dlgPreview.AutoScrollMinSize = New Size(0, 0)
        dlgPreview.ClientSize = New Size(400, 300)
        dlgPreview.Enabled = True
        dlgPreview.Icon = CType(resources.GetObject("dlgPreview.Icon"), Icon)
        dlgPreview.Name = "dlgPreview"
        dlgPreview.Visible = False
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.FromArgb(CByte(234), CByte(179), CByte(8))
        btnCetak.FlatAppearance.BorderSize = 0
        btnCetak.FlatStyle = FlatStyle.Flat
        btnCetak.Font = New Font("Segoe UI Semibold", 10.0F)
        btnCetak.ForeColor = Color.Black
        btnCetak.Location = New Point(700, 410)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(220, 45)
        btnCetak.TabIndex = 18
        btnCetak.Text = "Cetak Nota"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' btnPreviewCetak
        ' 
        btnPreviewCetak.BackColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        btnPreviewCetak.FlatAppearance.BorderSize = 0
        btnPreviewCetak.FlatStyle = FlatStyle.Flat
        btnPreviewCetak.Font = New Font("Segoe UI Semibold", 10.0F)
        btnPreviewCetak.ForeColor = Color.White
        btnPreviewCetak.Location = New Point(700, 350)
        btnPreviewCetak.Name = "btnPreviewCetak"
        btnPreviewCetak.Size = New Size(220, 45)
        btnPreviewCetak.TabIndex = 17
        btnPreviewCetak.Text = "Preview Nota"
        btnPreviewCetak.UseVisualStyleBackColor = False
        ' 
        ' FormCheckOut
        ' 
        AutoScaleDimensions = New SizeF(12.0F, 30.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        ClientSize = New Size(960, 504)
        Controls.Add(btnCetak)
        Controls.Add(btnPreviewCetak)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnProsesBayar)
        Controls.Add(btnHitung)
        Controls.Add(cmbMetodeBayar)
        Controls.Add(dtpCheckOut)
        Controls.Add(cmbPilihTamu)
        Font = New Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "FormCheckOut"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Pembayaran & Check-Out"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbPilihTamu As ComboBox
    Friend WithEvents txtKamar As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtTglCheckIn As TextBox
    Friend WithEvents txtLamaMenginap As TextBox
    Friend WithEvents txtTotalTagihan As TextBox
    Friend WithEvents dtpCheckOut As DateTimePicker
    Friend WithEvents cmbMetodeBayar As ComboBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnProsesBayar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents docLaporan As Printing.PrintDocument
    Friend WithEvents dlgPreview As PrintPreviewDialog
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnPreviewCetak As Button
End Class