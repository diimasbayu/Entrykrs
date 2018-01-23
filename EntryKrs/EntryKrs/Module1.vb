Imports System.Data.OleDb

Module ModuleEntryKRS
    Public strConn As String = _
    "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\entryKRS.mdb;"

    Public cnn As OleDbConnection
    Public cmmd As OleDbCommand
    Public dreader As OleDbDataReader
    Public sql As String

    Public Sub koneksi()
        cnn = New OleDbConnection(strConn)
        If cnn.State <> ConnectionState.Closed Then cnn.Close()
        cnn.Open()
    End Sub
End Module
