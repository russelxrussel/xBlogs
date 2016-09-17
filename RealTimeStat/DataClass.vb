Imports System.Data.SqlClient


Public Class DataClass
    Public con As SqlConnection
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Public dt As DataTable
    Public str As String

    Public STUDNUM As String
    Public STUDNAME As String
    Public STUDLEVELSECTION As String
    Public STUDENTIMAGE As String

    'Public CURRENT_DONOR_NUM As Integer
    'Public DONOR_NUM_PREFIX As String

    Public Sub New()
        con = New SqlConnection("Data Source=192.168.2.4;Initial Catalog=Blog;User id=sa")
    End Sub

    Public Function QualifiedStat(ByVal qualifieValue As Integer) As Integer
        Dim i As Integer
        con.Open()
        str = "Select COUNT(*) FROM dinfo where remarksID= '" & qualifieValue & "'"
        cmd = New SqlCommand(str, con)
        i = cmd.ExecuteScalar
        con.Close()
        Return i
    End Function

    Public Function DeferredStat(ByVal deferredValue As Integer) As Integer
        Dim i As Integer
        con.Open()
        str = "Select COUNT(*) FROM dinfo where remarksID= '" & deferredValue & "'"
        cmd = New SqlCommand(str, con)
        i = cmd.ExecuteScalar
        con.Close()
        Return i
    End Function


    Public Sub TOP1()

        Dim sqlcon As New SqlConnection("Data Source=192.168.2.4;Initial Catalog=Blog;User id=sa")

        Dim strquery As String = "spTopRecruiter"

        Using (sqlcon)
            Dim sqlcmd As New SqlCommand(strquery, sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure

            sqlcon.Open()

            Dim sqlReader As SqlDataReader = sqlcmd.ExecuteReader

            If sqlReader.HasRows Then
                While (sqlReader.Read())
                    STUDNUM = sqlReader.GetString(0)
                    STUDNAME = sqlReader.GetString(2)
                    STUDLEVELSECTION = sqlReader.GetString(1)
                    STUDENTIMAGE = sqlReader.GetString(3)
                End While
            Else
                STUDNUM = ""
                STUDNAME = ""
                STUDLEVELSECTION = ""
                STUDENTIMAGE = ""


            End If

        End Using

    End Sub


    Public Function ProcessingStat(ByVal processingValue As Integer) As Integer
        Dim i As Integer
        con.Open()
        str = "Select COUNT(*) FROM dinfo where remarksID= '" & processingValue & "'"
        cmd = New SqlCommand(str, con)
        i = cmd.ExecuteScalar
        con.Close()
        Return i
    End Function

    Public Function RegistratoinStat(ByVal registrationValue As Integer) As Integer
        Dim i As Integer
        con.Open()
        str = "Select COUNT(*) FROM dinfo where remarksID= '" & registrationValue & "'"
        cmd = New SqlCommand(str, con)
        i = cmd.ExecuteScalar
        con.Close()
        Return i
    End Function

    Public Function TotalRegistered() As Integer
        Dim i As Integer
        con.Open()
        str = "Select COUNT(*) FROM dinfo "
        cmd = New SqlCommand(str, con)
        i = cmd.ExecuteScalar
        con.Close()
        Return i
    End Function


    Public Function displayServerTime() As DateTime
        Dim x As DateTime
        con.Open()
        str = "Select GETDATE()"
        cmd = New SqlCommand(str, con)
        x = cmd.ExecuteScalar
        con.Close()

        Return x
    End Function

End Class
