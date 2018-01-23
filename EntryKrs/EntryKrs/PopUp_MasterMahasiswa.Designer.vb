<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopUp_MasterMahasiswa
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtKataKunci = New System.Windows.Forms.TextBox
        Me.LVData = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.btnOk = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kata Kunci"
        '
        'txtKataKunci
        '
        Me.txtKataKunci.Location = New System.Drawing.Point(110, 2)
        Me.txtKataKunci.Name = "txtKataKunci"
        Me.txtKataKunci.Size = New System.Drawing.Size(100, 20)
        Me.txtKataKunci.TabIndex = 1
        '
        'LVData
        '
        Me.LVData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.LVData.FullRowSelect = True
        Me.LVData.GridLines = True
        Me.LVData.Location = New System.Drawing.Point(15, 37)
        Me.LVData.Name = "LVData"
        Me.LVData.Size = New System.Drawing.Size(847, 194)
        Me.LVData.TabIndex = 2
        Me.LVData.UseCompatibleStateImageBehavior = False
        Me.LVData.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NIM"
        Me.ColumnHeader1.Width = 116
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Jenis Kelamin"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Alamat"
        Me.ColumnHeader4.Width = 135
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Telepon"
        Me.ColumnHeader5.Width = 96
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Tempat Lahir"
        Me.ColumnHeader6.Width = 89
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Tanggal Lahir"
        Me.ColumnHeader7.Width = 93
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Jurusan"
        Me.ColumnHeader8.Width = 89
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(760, 237)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(102, 50)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'PopUp_MasterMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 298)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.LVData)
        Me.Controls.Add(Me.txtKataKunci)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PopUp_MasterMahasiswa"
        Me.Text = "PopUp_MasterMahasiswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKataKunci As System.Windows.Forms.TextBox
    Friend WithEvents LVData As System.Windows.Forms.ListView
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
End Class
