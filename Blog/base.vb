Imports System.Data.SqlClient

Public Class base
    Private conn As SqlConnection
    Private cmd As SqlCommand


    Private da As SqlDataAdapter
    Private ds As DataSet
    Private dt As DataTable
    Private dr As SqlDataReader

    Private str As String


    Public Property _CONN() As SqlConnection
        Get
            Return conn
        End Get
        Set(ByVal value As SqlConnection)
            conn = value
        End Set
    End Property

    Public Property _CMD() As SqlCommand
        Get
            Return cmd
        End Get
        Set(ByVal value As SqlCommand)
            cmd = value
        End Set
    End Property

    Public Property _DA() As SqlDataAdapter
        Get
            Return da
        End Get
        Set(ByVal value As SqlDataAdapter)
            da = value
        End Set
    End Property

    Public Property _DR() As SqlDataReader
        Get
            Return dr
        End Get
        Set(ByVal value As SqlDataReader)
            dr = value
        End Set
    End Property

    Public Property _DS() As DataSet
        Get
            Return ds
        End Get
        Set(ByVal value As DataSet)
            ds = value
        End Set
    End Property

    Public Property _DT() As DataTable
        Get
            Return dt
        End Get
        Set(ByVal value As DataTable)
            dt = value
        End Set
    End Property

    Public Property _STR() As String
        Get
            Return str
        End Get
        Set(ByVal value As String)
            str = value
        End Set
    End Property



End Class
