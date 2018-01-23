Imports System.Data.OleDb
Public Class PopUp_MasterMahasiswa
    Public retNim, retNama, retjenkel, retAlamat, retTelp, retTmpLhr, retTgllhr, retjur As String

    Private Sub isi_view()
        LVData.Items.Clear()
        Dim x As Integer = 1
        koneksi()
        sql = "select * from Mahasiswa where nama like '%" & Trim(txtKataKunci.Text) & "%' order by NIM asc "
        cmmd = New OleDbCommand(sql, cnn)
        dreader = cmmd.ExecuteReader

        Try
            While dreader.Read = True
                LVData.Items.Add(dreader.Item("NIM").ToString)
                LVData.Items(x - 1).SubItems.Add(dreader.Item("NAMA").ToString)
                LVData.Items(x - 1).SubItems.Add(dreader.Item("JNS_KELAMIN").ToString)
                LVData.Items(x - 1).SubItems.Add(dreader.Item("ALAMAT").ToString)
                LVData.Items(x - 1).SubItems.Add(dreader.Item("TELP").ToString)
                LVData.Items(x - 1).SubItems.Add(dreader.Item("TMPT_LAHIR").ToString)
                LVData.Items(x - 1).SubItems.Add(Format(CDate(dreader.Item("TGL_LAHIR")), "dd-MMMM-yyyy").ToString)
                LVData.Items(x - 1).SubItems.Add(dreader.Item("JURUSAN").ToString)
                x = x + 1
            End While
        Finally
            dreader.Close()

        End Try
    End Sub

    Private Sub pilih()
        Try
            retNim = LVData.SelectedItems(0).SubItems(0).Text.ToString
            retNama = LVData.SelectedItems(0).SubItems(1).Text.ToString
            retjenkel = LVData.SelectedItems(0).SubItems(2).Text.ToString
            retAlamat = LVData.SelectedItems(0).SubItems(3).Text.ToString
            retTelp = LVData.SelectedItems(0).SubItems(4).Text.ToString
            retTmpLhr = LVData.SelectedItems(0).SubItems(5).Text.ToString
            retTgllhr = LVData.SelectedItems(0).SubItems(6).Text.ToString
            retjur = LVData.SelectedItems(0).SubItems(7).Text.ToString
            Me.Close()

        Catch ex As Exception
            MsgBox("Pilih salah satu data ", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub PopUp_MasterMahasiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call isi_view()

    End Sub

    Private Sub txtKey_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKataKunci.TextChanged
        Call isi_view()

    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVData.SelectedIndexChanged
        Call pilih()


    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Call pilih()

    End Sub
End Class