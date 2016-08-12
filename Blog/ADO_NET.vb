Imports System.Data.SqlClient

Public Class ADO_NET
    Inherits base

    

    Public Sub New()
        _CONN = New SqlConnection("Data Source=192.168.2.4;Initial Catalog=Blog;User id=sa")
    End Sub


#Region "Query ang Get Data"
    'Get BloodType
    Public Function getBloodType() As DataTable
        _DT = New DataTable
        _STR = "Select * from bloodType_RF"
        _DA = New SqlDataAdapter(_STR, _CONN)
        _DA.Fill(_DT)

        Return _DT
    End Function

    Public Function getRemarks() As DataTable
        _DT = New DataTable
        _STR = "Select * from remarks_RF"
        _DA = New SqlDataAdapter(_STR, _CONN)
        _DA.Fill(_DT)

        Return _DT
    End Function

    Public Function getStation() As DataTable
        _DT = New DataTable
        _STR = "Select * from station_RF"
        _DA = New SqlDataAdapter(_STR, _CONN)
        _DA.Fill(_DT)

        Return _DT
    End Function
#End Region


End Class
