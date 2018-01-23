Public Class FormUtama

    Dim oleconn As New OleDb.OleDbConnection
    Private Sub FormUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            koneksi() 'memanggil prosedur yang ada pada modul'
            MessageBox.Show("Koneksi Berhasil", "Informasi ", MessageBoxButtons.OK)

        Catch ex As Exception
            MessageBox.Show("Error", "Informasi ", MessageBoxButtons.OK)
            MessageBox.Show(ex.Message, "Informasi ", MessageBoxButtons.OK)
            Me.Dispose()
        End Try
    End Sub

    Private Sub EntryDataMahasiswaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryDataMahasiswaToolStripMenuItem.Click
        FrmMasterMahasiswa.Show()
    End Sub

    Private Sub EntryDataMatakuliahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryDataMatakuliahToolStripMenuItem.Click
        FrmMasterMatakuliah.Show()
    End Sub

    Private Sub EntryKRSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryKRSToolStripMenuItem.Click
        FrmEntryKRS.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub FileMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMasterToolStripMenuItem.Click

    End Sub
End Class
