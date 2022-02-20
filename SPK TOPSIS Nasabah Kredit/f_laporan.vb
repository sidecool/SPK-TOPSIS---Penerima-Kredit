Imports MySql.Data.MySqlClient

Public Class f_laporan

    Private Sub f_laporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FilePath As String = Application.StartupPath & "\setting.ini"
        TextBox1.Text = ReadIni(FilePath, "ConfigDB", "Pimpinan", "")

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd MMMM yyyy"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FilePath As String = Application.StartupPath & "\setting.ini"
        WriteIni(FilePath, "ConfigDB", "Pimpinan", TextBox1.Text)

        Dim DS As New DSPreferensi
        MyDataAdapter = New MySqlDataAdapter("SELECT * FROM v_laporan", MyConn)
        MyDataAdapter.Fill(DS, "v_laporan")

        Dim reportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument
        reportDocument = New CRLaporan
        reportDocument.SetDataSource(DS)
        reportDocument.SetParameterValue("Tanggal", "Merauke, " & DateTimePicker1.Text)
        reportDocument.SetParameterValue("Pimpinan", "( " & TextBox1.Text & " )")
        Me.CRV.ReportSource = reportDocument
        Me.CRV.Refresh()

        MyConn.Close()
        MyConn.Open()
    End Sub
End Class