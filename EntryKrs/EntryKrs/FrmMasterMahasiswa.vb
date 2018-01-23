Imports System.Data.OleDb
Public Class FrmMasterMahasiswa
    Private Function autonumber()
        Dim strTemp As String = ""
        Dim strValue As String = ""

        sql = "SELECT * FROM Mahasiswa ORDER BY nim DESC "
        cmmd = New OleDbCommand(sql, cnn)
        dreader = cmmd.ExecuteReader

        If dreader.Read Then
            strTemp = Mid(dreader.Item("NIM"), 3, 8)
            strValue = Val(strTemp) + 1
            strValue = "MS" & Mid("00000000", 1, 8 - strValue.Length) & strValue
        Else
            strValue = "MS00000001"
        End If
        Return strValue
    End Function
    Private Sub FrmMasterMahasiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNim.Text = autonumber()

    End Sub
    Private Sub FrmMasterMahasiswa_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNama.Focus()
    End Sub
    Private Sub bersih()
        txtNama.Text = ""
        RbJkP.Checked = True
        txtAlamat.Text = ""
        txtTelp.Text = ""
        txtTempLhr.Text = ""
        cmbJurusan.Text = ""

    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        sql = "INSERT INTO MAHASISWA(NIM,NAMA,JNS_KELAMIN,ALAMAT,TELP,TMPT_LAHIR,TGL_LAHIR,JURUSAN)" & _
        " values (?,?,?,?,?,?,?,?)"
        cmmd = New OleDbCommand(sql, cnn)
        cmmd.CommandType = CommandType.Text
        cmmd.Parameters.AddWithValue("NIM", txtNim.Text)
        cmmd.Parameters.AddWithValue("NAMA", txtNama.Text)
        If RbJkL.Checked = True Then
            cmmd.Parameters.AddWithValue("JNS_KELAMIN", RbJkL.Text)
        Else
            cmmd.Parameters.AddWithValue("JNS_KELAMIN", RbJkP.Text)
        End If
        cmmd.Parameters.AddWithValue("ALAMAT", txtAlamat.Text)
        cmmd.Parameters.AddWithValue("TELP", txtTelp.Text)
        cmmd.Parameters.AddWithValue("TMPT_LAHIR", txtTempLhr.Text)
        cmmd.Parameters.AddWithValue("TGL_LAHIR", DateTimePicker1.Value.Date)
        cmmd.Parameters.AddWithValue("JURUSAN", cmbJurusan.Text)

        Dim x As Integer = cmmd.ExecuteNonQuery
        If x = 1 Then
            MessageBox.Show("Data Berhasil Disimpan", "Informasi ", MessageBoxButtons.OK)
            txtNim.Text = autonumber()
            bersih()
        Else
            MessageBox.Show("Gagal Menyimpan Data ", "Informasi ", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click
        sql = "UPDATE MAHASISWA set NAMA =? ,  JNS_KELAMIN =? , ALAMAT=? , TELP=? ,  TMPT_LAHIR=? , TGL_LAHIR=? , JURUSAN=? " & _
        "WHERE NIM= ?"
        cmmd = New OleDbCommand(sql, cnn)

        cmmd.CommandType = CommandType.Text
        cmmd.Parameters.AddWithValue("NAMA ", txtNama.Text)
        If RbJkL.Checked = True Then
            cmmd.Parameters.AddWithValue("JNS_KELAMIN", RbJkL.Text)
        Else
            cmmd.Parameters.AddWithValue("JNS_KELAMIN", RbJkP.Text)
        End If
        cmmd.Parameters.AddWithValue("ALAMAT", txtAlamat.Text)
        cmmd.Parameters.AddWithValue("TELP", txtTelp.Text)
        cmmd.Parameters.AddWithValue("TMPT_LAHIR", txtTempLhr.Text)
        cmmd.Parameters.AddWithValue("TGL_LAHIR", DateTimePicker1.Value.Date)
        cmmd.Parameters.AddWithValue("JURUSAN", cmbJurusan.Text)
        cmmd.Parameters.AddWithValue("NIM", txtNim.Text)

        Dim x As Integer = cmmd.ExecuteNonQuery
        If x = 1 Then
            MessageBox.Show("DATA BERHASIL DIUBAH ", "INFORMASI ", MessageBoxButtons.OK)
            txtNim.Text = autonumber()
            bersih()
        Else
            MessageBox.Show("DATA GAGAL DIRUBAH  ", "INFORMASI ", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        sql = "DELETE FROM MAHASISWA WHERE NIM=?"

        cmmd = New OleDbCommand(sql, cnn)
        cmmd.CommandType = CommandType.Text

        cmmd.Parameters.AddWithValue("NIM", txtNim.Text)

        Dim x As Integer = cmmd.ExecuteNonQuery
        If x = 1 Then
            MessageBox.Show("DATA BERHASIL DIHAPUS ", "INFORMASI ", MessageBoxButtons.OK)
            txtNim.Text = autonumber()
            bersih()
        Else
            MessageBox.Show("DATA GAGAL DIHAPUS   ", "INFORMASI ", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        txtNim.Text = autonumber()
        bersih()

    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()

    End Sub

    Private Sub txtNim_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNim.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmmd = New OleDbCommand("SELECT *FROM mahasiswa WHERE nim='" & txtNim.Text & "'", cnn)
            dreader = cmmd.ExecuteReader

            If dreader.Read Then
                'jika data ditemukan 
                btnSimpan.Enabled = False
                btnUbah.Enabled = True
                btnHapus.Enabled = True
                txtNama.Text = dreader.Item("nama")
                If dreader.Item("Jns_kelamin") = "Laki-Laki" Then
                    RbJkL.Checked = True
                Else
                    RbJkP.Checked = True
                End If
                txtAlamat.Text = dreader.Item("alamat")
                txtTelp.Text = dreader.Item("telp")
                txtTempLhr.Text = dreader.Item("tmpt_lahir")
                DateTimePicker1.Value = dreader.Item("tgl_lahir")
                cmbJurusan.Text = dreader.Item("jurusan")
                txtNama.Focus()
            Else
                txtNama.Focus()
                txtNama.Text = ""
                RbJkP.Checked = True
                txtAlamat.Text = ""
                txtTelp.Text = ""
                txtTempLhr.Text = ""
                DateTimePicker1.Value = Now()
                cmbJurusan.Text = ""


            End If
        End If
    End Sub

    Private Sub txtTelp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelp.KeyPress
        If Not (Asc(e.KeyChar) >= Asc("0") And Asc(e.KeyChar) <= Asc("9") Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13) Then
            e.KeyChar = Chr(0)
            MessageBox.Show("Harap Masukkan angka ")
        ElseIf Asc(e.KeyChar) = 13 Then

        End If
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Dim popupmhs As New PopUp_MasterMahasiswa
        popupmhs.ShowDialog()
        If popupmhs.retNim <> "" Then
            txtNim.Text = popupmhs.retNim
            txtNama.Text = popupmhs.retNama
            If popupmhs.retjenkel = "Laki-Laki" Then
                RbJkL.Checked = True
            Else
                RbJkP.Checked = True

            End If
            txtAlamat.Text = popupmhs.retAlamat
            txtTelp.Text = popupmhs.retTelp
            txtTempLhr.Text = popupmhs.retTmpLhr
            DateTimePicker1.Value = popupmhs.retTgllhr
            cmbJurusan.Text = popupmhs.retjur
            txtNim.Enabled = False
            txtNama.Focus()

        End If
    End Sub
End Class