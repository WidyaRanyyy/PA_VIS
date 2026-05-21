<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKamar
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKamar))
        txtNoKamar = New TextBox()
        Label1 = New Label()
        cmbTipe = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        txtHarga = New TextBox()
        cmbStatus = New ComboBox()
        Label4 = New Label()
        dgvKamar = New DataGridView()
        FormGroup = New GroupBox()
        btnTambah = New Button()
        btnHapus = New Button()
        btnUpdate = New Button()
        btnClear = New Button()
        Label5 = New Label()
        Label6 = New Label()
        CType(dgvKamar, ComponentModel.ISupportInitialize).BeginInit()
        FormGroup.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtNoKamar
        ' 
        txtNoKamar.BackColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        txtNoKamar.BorderStyle = BorderStyle.FixedSingle
        txtNoKamar.ForeColor = Color.White
        txtNoKamar.Location = New Point(184, 48)
        txtNoKamar.Name = "txtNoKamar"
        txtNoKamar.Size = New Size(226, 35)
        txtNoKamar.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        Label1.Location = New Point(35, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 30)
        Label1.TabIndex = 1
        Label1.Text = "Nomor Kamar"
        ' 
        ' cmbTipe
        ' 
        cmbTipe.BackColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        cmbTipe.FlatStyle = FlatStyle.Flat
        cmbTipe.ForeColor = Color.White
        cmbTipe.FormattingEnabled = True
        cmbTipe.Location = New Point(184, 107)
        cmbTipe.Name = "cmbTipe"
        cmbTipe.Size = New Size(226, 38)
        cmbTipe.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        Label2.Location = New Point(35, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 30)
        Label2.TabIndex = 3
        Label2.Text = "Tipe Kamar"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        Label3.Location = New Point(35, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 30)
        Label3.TabIndex = 4
        Label3.Text = "Harga"
        ' 
        ' txtHarga
        ' 
        txtHarga.BackColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        txtHarga.BorderStyle = BorderStyle.FixedSingle
        txtHarga.ForeColor = Color.White
        txtHarga.Location = New Point(184, 168)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(226, 35)
        txtHarga.TabIndex = 5
        ' 
        ' cmbStatus
        ' 
        cmbStatus.BackColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        cmbStatus.FlatStyle = FlatStyle.Flat
        cmbStatus.ForeColor = Color.White
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(184, 227)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(226, 38)
        cmbStatus.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        Label4.Location = New Point(35, 230)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 30)
        Label4.TabIndex = 7
        Label4.Text = "Status"
        ' 
        ' dgvKamar
        ' 
        dgvKamar.BackgroundColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        dgvKamar.BorderStyle = BorderStyle.None
        dgvKamar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvKamar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvKamar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKamar.EnableHeadersVisualStyles = False
        dgvKamar.GridColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        dgvKamar.Location = New Point(510, 120)
        dgvKamar.Name = "dgvKamar"
        dgvKamar.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvKamar.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvKamar.RowHeadersWidth = 30
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        dgvKamar.RowsDefaultCellStyle = DataGridViewCellStyle3
        dgvKamar.Size = New Size(410, 280)
        dgvKamar.TabIndex = 8
        ' 
        ' FormGroup
        ' 
        FormGroup.BackColor = Color.Transparent
        FormGroup.Controls.Add(Label4)
        FormGroup.Controls.Add(cmbStatus)
        FormGroup.Controls.Add(txtHarga)
        FormGroup.Controls.Add(Label3)
        FormGroup.Controls.Add(Label2)
        FormGroup.Controls.Add(cmbTipe)
        FormGroup.Controls.Add(Label1)
        FormGroup.Controls.Add(txtNoKamar)
        FormGroup.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        FormGroup.Location = New Point(35, 110)
        FormGroup.Name = "FormGroup"
        FormGroup.Size = New Size(450, 290)
        FormGroup.TabIndex = 9
        FormGroup.TabStop = False
        FormGroup.Text = "Form Entri Data"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.FromArgb(CByte(16), CByte(185), CByte(129))
        btnTambah.FlatAppearance.BorderSize = 0
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Font = New Font("Segoe UI Semibold", 10F)
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(230, 425)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(110, 40)
        btnTambah.TabIndex = 10
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(239), CByte(68), CByte(68))
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI Semibold", 10F)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(490, 425)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(110, 40)
        btnHapus.TabIndex = 11
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI Semibold", 10F)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(360, 425)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(110, 40)
        btnUpdate.TabIndex = 12
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI Semibold", 10F)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(620, 425)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(110, 40)
        btnClear.TabIndex = 13
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 28F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(276, 25)
        Label5.Name = "Label5"
        Label5.Size = New Size(175, 74)
        Label5.TabIndex = 14
        Label5.Text = "DATA"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Light", 28F)
        Label6.ForeColor = Color.FromArgb(CByte(250), CByte(204), CByte(21))
        Label6.Location = New Point(445, 25)
        Label6.Name = "Label6"
        Label6.Size = New Size(210, 74)
        Label6.TabIndex = 15
        Label6.Text = "KAMAR"
        ' 
        ' FormKamar
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(960, 504)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(btnClear)
        Controls.Add(btnUpdate)
        Controls.Add(btnHapus)
        Controls.Add(btnTambah)
        Controls.Add(FormGroup)
        Controls.Add(dgvKamar)
        Font = New Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "FormKamar"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Master Data Kamar"
        CType(dgvKamar, ComponentModel.ISupportInitialize).EndInit()
        FormGroup.ResumeLayout(False)
        FormGroup.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNoKamar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTipe As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvKamar As DataGridView
    Friend WithEvents FormGroup As GroupBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class