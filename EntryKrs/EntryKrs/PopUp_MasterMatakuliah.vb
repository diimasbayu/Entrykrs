Imports System.Data.OleDb
Public Class PopUp_MasterMatakuliah
    Public retkdmatkul, retNamamatkul, retSKS, retHargaSKS As String

    Private Sub isi_view()
        LVData.Items.Clear()
        Dim x As Integer = 1
        koneksi()
        sql = "select * from Matakuliah where nm_matkul like '%" & Trim(txtKataKunci.Text) & "%' order by kd_matkul asc "
        cmmd = New OleDbCommand(sql, cnn)
        dreader = cmmd.ExecuteReader

        Try
            While dreader.Read = True
                LVData.Items.Add(dreader.Item("kd_matkul").ToString)
                LVData.Items(x - 1).SubItems.Add(dreader.Item("nm_matkul").ToString)
                LVData.Items(x - 1).SubItems.Add(dreader.Item("SKS").ToString)
                LVData.Items(x - 1).SubItems.Add(dreader.Item("harga_per_sks").ToString)
                x = x + 1
            End While
        Finally
            dreader.Close()

        End Try
    End Sub
    Private Sub pilih()
        Try
            retkdmatkul = LVData.SelectedItems(0).SubItems(0).Text.ToString
            retNamamatkul = LVData.SelectedItems(0).SubItems(1).Text.ToString
            retSKS = LVData.SelectedItems(0).SubItems(2).Text.ToString
            retHargaSKS = LVData.SelectedItems(0).SubItems(3).Text.ToString
            Me.Close()


        Catch ex As Exception
            MessageBox.Show("Pilih salah satu data ", "Informasi ", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub PopUp_MasterMatakuliah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call isi_view()
    End Sub

    Private Sub txtKey_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKataKunci.TextChanged
        Call isi_view()

    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LVData.DoubleClick
        Call pilih()

    End Sub


    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Call pilih()

    End Sub
End Class