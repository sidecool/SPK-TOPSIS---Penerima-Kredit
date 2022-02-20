Imports MySql.Data.MySqlClient

Module m_koneksi
    Public PESAN_ERR As String
    Public MyConn, RearConn As New MySqlConnection
    Public MyDataAdapter, RearDataAdapter As MySqlDataAdapter
    Public MyDataReader, RearDataReader As MySqlDataReader
    Public MyCommand, RearMyCommand As MySqlCommand
    Public DS, RearDS As DataSet
    Public DT, RearDT As DataTable
    Public SQL As String

    Public USERLOGIN As String

    Public Function cek_koneksi(ByVal Server As String, ByVal Port As String, ByVal User As String, ByVal Password As String, ByVal DBName As String)
        MyConn.Close()
        MyConn.ConnectionString = "datasource=" & Server & ";" _
                                & "port=" & Port & ";" _
                                & "username=" & User & ";" _
                                & "password=" & Password & ";" _
                                & "database=" & DBName & ";" _
                                & "Persist Security Info=True;Convert Zero Datetime=True"
        Try
            MyConn.Open()

            RearConn.Close()
            RearConn.ConnectionString = MyConn.ConnectionString
            RearConn.Open()
            cek_koneksi = True
        Catch ex As MySqlException
            cek_koneksi = False            
            If ex.Message.Contains("Unable") = True Then
                PESAN_ERR = "Tidak dapat terhubung dengan Server, silahkan perbaiki 'Server Host' atau 'Port'."
            ElseIf ex.Message.Contains("Access denied for user") = True Then
                PESAN_ERR = "User/Password database tidak sesuai atau tidak ditemukan."
            ElseIf ex.Message.Contains("Unknown database") = True Then
                PESAN_ERR = "Database tidak ditemukan."
            End If
        End Try
    End Function

    'fungsi untuk write file .ini
    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
    Alias "WritePrivateProfileStringW" (ByVal lpSection As String, ByVal lpParamName As String, _
    ByVal lpParamVal As String, ByVal lpFileName As String) As Int32

    'procedure untuk write .ini
    Public Sub WriteIni(ByVal iniFilename As String, ByVal section As String, ByVal ParamName As String, ByVal ParamVal As String)
        'menanggil fungsi WritePrivateProfilString untuk write file .ini
        Dim result As Integer = WritePrivateProfileString(section, ParamName, ParamVal, iniFilename)
    End Sub

    'function untuk read file .ini
    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
    Alias "GetPrivateProfileStringW" (ByVal lpSection As String, ByVal lpParamName As String, _
    ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, _
    ByVal lpFilename As String) As Int32

    'function untuk read file .ini
    Public Function ReadIni(ByVal iniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamDefault As String) As String
        Dim ParamVal As String = Space$(1024)
        Dim LenParamVal As Long = GetPrivateProfileString(Section, ParamName, ParamDefault, ParamVal, Len(ParamVal), iniFileName)
        'mengembalikan nilai yang sudah didapatkan
        ReadIni = Strings.Left(ParamVal, LenParamVal)
    End Function
End Module
