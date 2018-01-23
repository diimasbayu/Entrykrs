Imports System.Data.OleDb

Public Class FrmMasterMatakuliah
    Private Function autonumber()
        Dim strTemp As String = ""
        Dim strValue As String = ""

        sql = "SELECT  * FROM Matakuliah ORDER BY kd_matkul DESC"
        cmmd = New OleDbCommand(sql, cnn)
        dreader = cmmd.ExecuteReader

        If dreader.Read Then
            strTemp = Mid(dreader.Item("kd_matkul"), 3, 5)
            strValue = Val(strTemp) + 1
            strValue = "MK" & Mid("00000", 1, 5 - strValue.Length) & strValue

        Else
            strValue = "MK00001"
        End If
        Return strValue
    End Function
    Private Sub FrmMasterMatakuliah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtKdmatkul.Text = autonumber()
    End Sub
    Private Sub FrmMasterMatakuliah_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNamamatkul.Focus()
    End Sub

    Private Sub bersih()
        txtNamamatkul.Text = ""
        txtHargaperSks.Text = ""
        txtSks.Text = ""
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        sql = "INSERT INTO MATAKULIAH(KD_MATKUL, NM_MATKUL, SKS ,HARGA_PER_SKS)" & _
        " values (?,?,?,?)"
        cmmd = New OleDbCommand(sql, cnn)
        cmmd.CommandType = CommandType.Text
        cmmd.Parameters.AddWithValue("KD_MATKUL ", txtKdmatkul.Text)
        cmmd.Parameters.AddWithValue("NM_MATKUL ", txtNamamatkul.Text)
        cmmd.Parameters.AddWithValue("SKS", txtSks.Text)
        cmmd.Parameters.AddWithValue("HARGA_PER_SKS", txtHargaperSks.Text)

        Dim x As Integer = cmmd.ExecuteNonQuery
        If x = 1 Then
            MessageBox.Show("Data Berhasil Disimpan", "Informasi ", MessageBoxButtons.OK)
            txtKdmatkul.Text = autonumber()
            bersih()
        Else
            MessageBox.Show("Gagal Menyimpan Data ", "Informasi ", MessageBoxButtons.OK)
        End If

    End Sub


    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click
        sql = "UPDATE MATAKULIAH set NM_MATKUL =? ,  SKS =? , HARGA_PER_SKS=?" & _
        "WHERE KD_MATKUL = ?"
        cmmd = New OleDbCommand(sql, cnn)
        cmmd.CommandType = CommandType.Text
        cmmd.Parameters.AddWithValue("NM_MATKUL ", txtNamamatkul.Text)
        cmmd.Parameters.AddWithValue("SKS ", txtSks.Text)
        cmmd.Parameters.AddWithValue("HARGA_PER_SKS", txtHargaperSks.Text)
        cmmd.Parameters.AddWithValue("KD_MATKUL", txtKdmatkul.Text)

        Dim x As Integer = cmmd.ExecuteNonQuery
        If x = 1 Then
            MessageBox.Show("DATA BERHASIL DIUBAH ", "INFORMASI ", MessageBoxButtons.OK)
            txtKdmatkul.Text = autonumber()
            bersih()
        Else
            MessageBox.Show("DATA GAGAL DIRUBAH  ", "INFORMASI ", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        sql = "DELETE FROM MATAKULIAH WHERE KD_MATKUL=?"

        cmmd = New OleDbCommand(sql, cnn)
        cmmd.CommandType = CommandType.Text
        
        cmmd.Parameters.AddWithValue("KD_MATKUL", txtKdmatkul.Text)

        Dim x As Integer = cmmd.ExecuteNonQuery
        If x = 1 Then
            MessageBox.Show("DATA BERHASIL DIHAPUS ", "INFORMASI ", MessageBoxButtons.OK)
            txtKdmatkul.Text = autonumber()
            bersih()
        Else
            MessageBox.Show("DATA GAGAL DIHAPUS   ", "INFORMASI ", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        txtKdmatkul.Text = autonumber()
        bersih()

    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()

    End Sub

    Private Sub txtKdmatkul_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKdmatkul.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmmd = New OleDbCommand("SELECT *FROM matakuliah WHERE kd_matkul='" & txtKdmatkul.Text & "'", cnn)
            dreader = cmmd.ExecuteReader

            If dreader.Read Then
                'jika data ditemukan 
                btnSimpan.Enabled = False
                btnUbah.Enabled = True
                btnHapus.Enabled = True
                txtNamamatkul.Text = dreader.Item("nm_matkul")
                txtSks.Text = dreader.Item("sks")
                txtHargaperSks.Text = dreader.Item("harga_per_SKS")
                txtNamamatkul.Focus()
            Else
                txtNamamatkul.Focus()
                txtNamamatkul.Text = ""
                txtSks.Text = ""
                txtHargaperSks.Text = ""

            End If
        End If
    End Sub

    Private Sub txtSks_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSks.KeyPress
        If Not (Asc(e.KeyChar) >= Asc("0") And Asc(e.KeyChar) <= Asc("9") Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13) Then
            e.KeyChar = Chr(0)
            MessageBox.Show("Harap Masukkan angka ")
        ElseIf Asc(e.KeyChar) = 13 Then

        End If
    End Sub

    Private Sub txtHargaperSks_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHargaperSks.KeyPress
        If Not (Asc(e.KeyChar) >= Asc("0") And Asc(e.KeyChar) <= Asc("9") Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13) Then
            e.KeyChar = Chr(0)
            MessageBox.Show("Harap Masukkan angka ")
        ElseIf Asc(e.KeyChar) = 13 Then

        End If
    End Sub


    Private Sub btnCariMatkul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariMatkul.Click
        Dim popupMk As New PopUp_MasterMatakuliah

        popupMk.ShowDialog()
        If popupMk.retkdmatkul <> "" Then
            txtKdmatkul.Text = popupMk.retkdmatkul
            txtNamamatkul.Text = popupMk.retNamamatkul
            txtSks.Text = popupMk.retSKS
            txtHargaperSks.Text = Format(CDbl(popupMk.retHargaSKS), "##,###,###,###")
            txtKdmatkul.Enabled = False
            txtNamamatkul.Focus()



        End If
    End Sub

End Class