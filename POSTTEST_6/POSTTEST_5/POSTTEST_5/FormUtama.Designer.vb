<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
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
        MenuStrip1 = New MenuStrip()
        MasterDataToolStripMenuItem = New ToolStripMenuItem()
        DataKamarToolStripMenuItem = New ToolStripMenuItem()
        TransaksiToolStripMenuItem = New ToolStripMenuItem()
        CheckInToolStripMenuItem = New ToolStripMenuItem()
        ChechkOutToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        PanelBackground = New Panel()
        LabelWelcome = New Label()
        LabelHotel = New Label()
        LabelVisual = New Label()
        PanelDivider = New Panel()
        LabelTagline = New Label()
        PanelFooter = New Panel()
        LabelFooter = New Label()
        PanelIkon1 = New Panel()
        PanelIkon2 = New Panel()
        PanelIkon3 = New Panel()
        PanelIkon4 = New Panel()
        LabelIkon1 = New Label()
        LabelIkon2 = New Label()
        LabelIkon3 = New Label()
        LabelIkon4 = New Label()
        LabelKap1 = New Label()
        LabelKap2 = New Label()
        LabelKap3 = New Label()
        LabelKap4 = New Label()
        MenuStrip1.SuspendLayout()
        PanelBackground.SuspendLayout()
        PanelFooter.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(15, 23, 42)
        MenuStrip1.Font = New Font("Segoe UI", 9.5F)
        MenuStrip1.ForeColor = Color.FromArgb(241, 245, 249)
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MasterDataToolStripMenuItem, TransaksiToolStripMenuItem, ChechkOutToolStripMenuItem, LogoutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(6, 6, 0, 6)
        MenuStrip1.Size = New Size(960, 41)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MasterDataToolStripMenuItem
        ' 
        MasterDataToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DataKamarToolStripMenuItem})
        MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        MasterDataToolStripMenuItem.Size = New Size(110, 29)
        MasterDataToolStripMenuItem.Text = "Master Data"
        ' 
        ' DataKamarToolStripMenuItem
        ' 
        DataKamarToolStripMenuItem.BackColor = Color.FromArgb(30, 41, 59)
        DataKamarToolStripMenuItem.ForeColor = Color.White
        DataKamarToolStripMenuItem.Name = "DataKamarToolStripMenuItem"
        DataKamarToolStripMenuItem.Size = New Size(212, 34)
        DataKamarToolStripMenuItem.Text = "Data Kamar"
        ' 
        ' TransaksiToolStripMenuItem
        ' 
        TransaksiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CheckInToolStripMenuItem})
        TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        TransaksiToolStripMenuItem.Size = New Size(94, 29)
        TransaksiToolStripMenuItem.Text = "Transaksi"
        ' 
        ' CheckInToolStripMenuItem
        ' 
        CheckInToolStripMenuItem.BackColor = Color.FromArgb(30, 41, 59)
        CheckInToolStripMenuItem.ForeColor = Color.White
        CheckInToolStripMenuItem.Name = "CheckInToolStripMenuItem"
        CheckInToolStripMenuItem.Size = New Size(189, 34)
        CheckInToolStripMenuItem.Text = "Check-In"
        ' 
        ' ChechkOutToolStripMenuItem
        ' 
        ChechkOutToolStripMenuItem.Name = "ChechkOutToolStripMenuItem"
        ChechkOutToolStripMenuItem.Size = New Size(132, 29)
        ChechkOutToolStripMenuItem.Text = "Pembayaran"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Alignment = ToolStripItemAlignment.Right
        LogoutToolStripMenuItem.ForeColor = Color.FromArgb(239, 68, 68)
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(87, 29)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' PanelBackground
        ' 
        PanelBackground.BackColor = Color.FromArgb(30, 41, 59)
        PanelBackground.Controls.Add(LabelWelcome)
        PanelBackground.Controls.Add(LabelHotel)
        PanelBackground.Controls.Add(LabelVisual)
        PanelBackground.Controls.Add(PanelDivider)
        PanelBackground.Controls.Add(LabelTagline)
        PanelBackground.Controls.Add(PanelFooter)
        PanelBackground.Dock = DockStyle.Fill
        PanelBackground.Location = New Point(0, 41)
        PanelBackground.Name = "PanelBackground"
        PanelBackground.Size = New Size(960, 463)
        PanelBackground.TabIndex = 1
        ' 
        ' LabelWelcome
        ' 
        LabelWelcome.BackColor = Color.Transparent
        LabelWelcome.Font = New Font("Segoe UI Semilight", 12.0F, FontStyle.Italic)
        LabelWelcome.ForeColor = Color.FromArgb(148, 163, 184)
        LabelWelcome.Location = New Point(0, 40)
        LabelWelcome.Name = "LabelWelcome"
        LabelWelcome.Size = New Size(960, 30)
        LabelWelcome.TabIndex = 0
        LabelWelcome.Text = "Selamat Datang di"
        LabelWelcome.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelHotel
        ' 
        LabelHotel.BackColor = Color.Transparent
        LabelHotel.Font = New Font("Segoe UI", 48.0F, FontStyle.Bold)
        LabelHotel.ForeColor = Color.White
        LabelHotel.Location = New Point(0, 80)
        LabelHotel.Name = "LabelHotel"
        LabelHotel.Size = New Size(475, 100)
        LabelHotel.TabIndex = 1
        LabelHotel.Text = "HOTEL"
        LabelHotel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LabelVisual
        ' 
        LabelVisual.BackColor = Color.Transparent
        LabelVisual.Font = New Font("Segoe UI Light", 48.0F)
        LabelVisual.ForeColor = Color.FromArgb(250, 204, 21)
        LabelVisual.Location = New Point(485, 80)
        LabelVisual.Name = "LabelVisual"
        LabelVisual.Size = New Size(475, 100)
        LabelVisual.TabIndex = 2
        LabelVisual.Text = "VISUAL"
        LabelVisual.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PanelDivider
        ' 
        PanelDivider.BackColor = Color.FromArgb(250, 204, 21)
        PanelDivider.Location = New Point(430, 200)
        PanelDivider.Name = "PanelDivider"
        PanelDivider.Size = New Size(100, 3)
        PanelDivider.TabIndex = 3
        ' 
        ' LabelTagline
        ' 
        LabelTagline.BackColor = Color.Transparent
        LabelTagline.Font = New Font("Segoe UI", 10.0F, FontStyle.Italic)
        LabelTagline.ForeColor = Color.FromArgb(100, 116, 139)
        LabelTagline.Location = New Point(0, 365)
        LabelTagline.Name = "LabelTagline"
        LabelTagline.Size = New Size(960, 30)
        LabelTagline.TabIndex = 4
        LabelTagline.Text = "— Memberikan Pelayanan Terbaik Untuk Anda —"
        LabelTagline.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PanelFooter
        ' 
        PanelFooter.BackColor = Color.FromArgb(15, 23, 42)
        PanelFooter.Controls.Add(LabelFooter)
        PanelFooter.Dock = DockStyle.Bottom
        PanelFooter.Location = New Point(0, 427)
        PanelFooter.Name = "PanelFooter"
        PanelFooter.Size = New Size(960, 36)
        PanelFooter.TabIndex = 5
        ' 
        ' LabelFooter
        ' 
        LabelFooter.BackColor = Color.Transparent
        LabelFooter.Dock = DockStyle.Fill
        LabelFooter.Font = New Font("Segoe UI", 8.5F)
        LabelFooter.ForeColor = Color.FromArgb(100, 116, 139)
        LabelFooter.Location = New Point(0, 0)
        LabelFooter.Name = "LabelFooter"
        LabelFooter.Size = New Size(960, 36)
        LabelFooter.TabIndex = 0
        LabelFooter.Text = "© 2026 HOTEL VISUAL — ALL RIGHTS RESERVED"
        LabelFooter.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormUtama
        ' 
        ' Skala koordinat font distabilkan ke rasio normal (8.0F, 19.0F)
        AutoScaleDimensions = New SizeF(8.0F, 19.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(30, 41, 59)
        ClientSize = New Size(960, 504)
        Controls.Add(PanelBackground)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 10.5F)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 3, 4, 3)
        Name = "FormUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hotel Visual - Dashboard Utama"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        PanelBackground.ResumeLayout(False)
        PanelFooter.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataKamarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChechkOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelBackground As Panel
    Friend WithEvents PanelDivider As Panel
    Friend WithEvents PanelFooter As Panel
    Friend WithEvents LabelWelcome As Label
    Friend WithEvents LabelHotel As Label
    Friend WithEvents LabelVisual As Label
    Friend WithEvents LabelTagline As Label
    Friend WithEvents LabelFooter As Label
    Friend WithEvents PanelIkon1 As Panel
    Friend WithEvents PanelIkon2 As Panel
    Friend WithEvents PanelIkon3 As Panel
    Friend WithEvents PanelIkon4 As Panel
    Friend WithEvents LabelIkon1 As Label
    Friend WithEvents LabelIkon2 As Label
    Friend WithEvents LabelIkon3 As Label
    Friend WithEvents LabelIkon4 As Label
    Friend WithEvents LabelKap1 As Label
    Friend WithEvents LabelKap2 As Label
    Friend WithEvents LabelKap3 As Label
    Friend WithEvents LabelKap4 As Label
End Class