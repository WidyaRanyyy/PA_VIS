<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCheckIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCheckIn))
        txtNama = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        dtpTanggal = New DateTimePicker()
        Label4 = New Label()
        btnSimpan = New Button()
        GroupBox1 = New GroupBox()
        cmbKamar = New ComboBox()
        btnHapus = New Button()
        dgvCheckIn = New DataGridView()
        Label5 = New Label()
        GroupBox1.SuspendLayout()
        CType(dgvCheckIn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.ForeColor = Color.White
        txtNama.Location = New Point(127, 52)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(310, 35)
        txtNama.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        Label1.Location = New Point(27, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 30)
        Label1.TabIndex = 1
        Label1.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(310, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(175, 74)
        Label3.TabIndex = 6
        Label3.Text = "DATA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        Label2.Location = New Point(27, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 30)
        Label2.TabIndex = 8
        Label2.Text = "Kamar"
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.CalendarMonthBackground = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        dtpTanggal.Location = New Point(127, 172)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(310, 35)
        dtpTanggal.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        Label4.Location = New Point(27, 175)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 30)
        Label4.TabIndex = 10
        Label4.Text = "Tanggal"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(16), CByte(185), CByte(129))
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI Semibold", 10.0F)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(127, 240)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(145, 40)
        btnSimpan.TabIndex = 11
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(cmbKamar)
        GroupBox1.Controls.Add(btnHapus)
        GroupBox1.Controls.Add(btnSimpan)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(dtpTanggal)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtNama)
        GroupBox1.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        GroupBox1.Location = New Point(45, 100)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(480, 350)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Formulir Check-In"
        ' 
        ' cmbKamar
        ' 
        cmbKamar.BackColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        cmbKamar.FlatStyle = FlatStyle.Flat
        cmbKamar.ForeColor = Color.White
        cmbKamar.FormattingEnabled = True
        cmbKamar.Location = New Point(127, 112)
        cmbKamar.Name = "cmbKamar"
        cmbKamar.Size = New Size(310, 38)
        cmbKamar.TabIndex = 13
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(239), CByte(68), CByte(68))
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI Semibold", 10.0F)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(292, 240)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(145, 40)
        btnHapus.TabIndex = 12
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' dgvCheckIn
        ' 
        dgvCheckIn.BackgroundColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        dgvCheckIn.BorderStyle = BorderStyle.None
        dgvCheckIn.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvCheckIn.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvCheckIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCheckIn.EnableHeadersVisualStyles = False
        dgvCheckIn.GridColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        dgvCheckIn.Location = New Point(550, 110)
        dgvCheckIn.Name = "dgvCheckIn"
        dgvCheckIn.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvCheckIn.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvCheckIn.RowHeadersWidth = 30
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        dgvCheckIn.RowsDefaultCellStyle = DataGridViewCellStyle3
        dgvCheckIn.Size = New Size(360, 340)
        dgvCheckIn.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Light", 28.0F)
        Label5.ForeColor = Color.FromArgb(CByte(250), CByte(204), CByte(21))
        Label5.Location = New Point(474, 25)
        Label5.Name = "Label5"
        Label5.Size = New Size(173, 74)
        Label5.TabIndex = 14
        Label5.Text = "TAMU"
        ' 
        ' FormCheckIn
        ' 
        AutoScaleDimensions = New SizeF(12.0F, 30.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(960, 504)
        Controls.Add(Label5)
        Controls.Add(dgvCheckIn)
        Controls.Add(GroupBox1)
        Controls.Add(Label3)
        Font = New Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "FormCheckIn"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Data Check-In"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvCheckIn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvCheckIn As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents cmbKamar As ComboBox

End Class