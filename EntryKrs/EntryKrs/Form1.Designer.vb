<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EntryDataMahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EntryDataMatakuliahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EntryKRSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CetakKRSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CetakLaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CetakLaporanMahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CetakLaporanMatakuliahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CetakLaporanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.CetakLaporanToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(444, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileMasterToolStripMenuItem
        '
        Me.FileMasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntryDataMahasiswaToolStripMenuItem, Me.EntryDataMatakuliahToolStripMenuItem})
        Me.FileMasterToolStripMenuItem.Name = "FileMasterToolStripMenuItem"
        Me.FileMasterToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.FileMasterToolStripMenuItem.Text = "File Master"
        '
        'EntryDataMahasiswaToolStripMenuItem
        '
        Me.EntryDataMahasiswaToolStripMenuItem.Name = "EntryDataMahasiswaToolStripMenuItem"
        Me.EntryDataMahasiswaToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.EntryDataMahasiswaToolStripMenuItem.Text = "Entry Data Mahasiswa"
        '
        'EntryDataMatakuliahToolStripMenuItem
        '
        Me.EntryDataMatakuliahToolStripMenuItem.Name = "EntryDataMatakuliahToolStripMenuItem"
        Me.EntryDataMatakuliahToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.EntryDataMatakuliahToolStripMenuItem.Text = "Entry Data Matakuliah"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntryKRSToolStripMenuItem, Me.CetakKRSToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'EntryKRSToolStripMenuItem
        '
        Me.EntryKRSToolStripMenuItem.Name = "EntryKRSToolStripMenuItem"
        Me.EntryKRSToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.EntryKRSToolStripMenuItem.Text = "Entry KRS"
        '
        'CetakKRSToolStripMenuItem
        '
        Me.CetakKRSToolStripMenuItem.Name = "CetakKRSToolStripMenuItem"
        Me.CetakKRSToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.CetakKRSToolStripMenuItem.Text = "Cetak KRS"
        '
        'CetakLaporanToolStripMenuItem
        '
        Me.CetakLaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CetakLaporanMahasiswaToolStripMenuItem, Me.CetakLaporanMatakuliahToolStripMenuItem, Me.CetakLaporanToolStripMenuItem1})
        Me.CetakLaporanToolStripMenuItem.Name = "CetakLaporanToolStripMenuItem"
        Me.CetakLaporanToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.CetakLaporanToolStripMenuItem.Text = "Cetak Laporan"
        '
        'CetakLaporanMahasiswaToolStripMenuItem
        '
        Me.CetakLaporanMahasiswaToolStripMenuItem.Name = "CetakLaporanMahasiswaToolStripMenuItem"
        Me.CetakLaporanMahasiswaToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.CetakLaporanMahasiswaToolStripMenuItem.Text = "Cetak Laporan Mahasiswa"
        '
        'CetakLaporanMatakuliahToolStripMenuItem
        '
        Me.CetakLaporanMatakuliahToolStripMenuItem.Name = "CetakLaporanMatakuliahToolStripMenuItem"
        Me.CetakLaporanMatakuliahToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.CetakLaporanMatakuliahToolStripMenuItem.Text = "Cetak Laporan Matakuliah"
        '
        'CetakLaporanToolStripMenuItem1
        '
        Me.CetakLaporanToolStripMenuItem1.Name = "CetakLaporanToolStripMenuItem1"
        Me.CetakLaporanToolStripMenuItem1.Size = New System.Drawing.Size(212, 22)
        Me.CetakLaporanToolStripMenuItem1.Text = "Cetak Laporan Entry KRS"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(444, 310)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormUtama"
        Me.Text = "Form Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntryDataMahasiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntryDataMatakuliahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntryKRSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakKRSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakLaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakLaporanMahasiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakLaporanMatakuliahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakLaporanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
