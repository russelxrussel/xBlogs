Imports System.Data.SqlClient


Public Class DataClassX

    Public con As SqlConnection
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Public dt As DataTable
    Public str As String

    Public CURRENT_DONOR_NUM As Integer
    Public DONOR_NUM_PREFIX As String

    Public DONOR_NUMBER As String

    'Public sqlCon As New SqlConnection("Data Source=192.168.2.4;Initial Catalog=Blog;User id=sa")

    Public Sub New()
        con = New SqlConnection("Data Source=192.168.2.4;Initial Catalog=Blog;User id=sa")
    End Sub

    Public Sub connect()
        Dim sqlCon As New SqlConnection("Data Source=192.168.2.4;Initial Catalog=Blog;User id=sa")
        Using (sqlCon)
            con.Open()
        End Using
    End Sub

    Public Sub GET_AUTO_NUM()
        Dim sqlcon As New SqlConnection("Data Source=192.168.2.4;Initial Catalog=Blog;User id=sa")

        Dim strquery As String = "spGET_AUTONUM"

        Using (sqlcon)
            Dim sqlcmd As New SqlCommand(strquery, sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure

            sqlcon.Open()

            Dim sqlReader As SqlDataReader = sqlcmd.ExecuteReader

            If sqlReader.HasRows Then
                While (sqlReader.Read())
                    'ASSIGN DATA ON VARIABLES
                    DONOR_NUM_PREFIX = sqlReader.GetString(0)
                    CURRENT_DONOR_NUM = sqlReader.GetInt32(1)
                End While
            End If

        End Using

    End Sub

    Public Sub UPDATE_AUTONUMBER(ByVal iNewNum As Integer)
        Dim sqlcon As New SqlConnection("Data Source=192.168.2.4;Initial Catalog=Blog;User id=sa")
        Dim strquery As String = "spUpdateAutoNum"

        Try


            Using (sqlcon)
                Dim sqlcmd As New SqlCommand(strquery, sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcon.Open()

                sqlcmd.Parameters.AddWithValue("@NEW_NUMBER", iNewNum)

                sqlcmd.ExecuteNonQuery()

            End Using

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    'Validate Donor Record Existent
    Public Function isDonorExist(ByVal _sLastName As String, ByVal _sFirstName As String, ByVal _sMI As String) As Boolean
        Dim isExist As Boolean = False

        Return isExist
    End Function

End Class
