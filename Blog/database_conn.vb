Imports System.Data.SqlClient

Module database_conn
    Public cn As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public strsql As String
    Public msg As String
    Public frmhome As New frmhome
    Public report1 As New Report1
    Public frmlogin As New frmlogin


    '1-11-2014
    'Public variable that expose to all form within the project
    Public _USERCODE As String = ""
    Public _SERVERDATETIME As New DateTime
    Public _ACCESS As String = ""

    Public Sub connect()
        Try
            'Original
            cn.Open("Provider=SQLOLEDB;Data Source=192.168.2.4;user id=sa;Initial Catalog=Blog")
            cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Catch ex As Exception
            MsgBox("Error Message" + ex.ToString)
        End Try
    End Sub
    Public Sub connection_close()
        cn.Close()
    End Sub
    Sub account_search(ByVal cmbsearch As ComboBox)
        Try
            Call connect()
            strsql = "select * from useracct"
            rs.Open(strsql, cn)
            While rs.EOF = False
                cmbsearch.Items.Add(rs.Fields("UserCode").Value)
                rs.MoveNext()
            End While
            Call connection_close()
        Catch ex As Exception
            MsgBox("Error Message" + ex.ToString)
        End Try
    End Sub
End Module
