Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms

Module reportConnection



    Public rd As New ReportDocument
    'Dim objRep As New reportConnection

    Public Sub reportConn(ByVal path As String)
        '    Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo

        Dim CrTables As Tables
        Dim CrTable As Table

        'insert 12/7/2012
        'rd.Refresh()
        rd.Load(path) 'parameter that need to fill up the path of report.

        With crConnectionInfo
            .ServerName = Application.StartupPath & "192.168.2.4"
            .DatabaseName = Application.StartupPath & "Blog"
            .UserID = "sa"
            .Password = ""
            .AllowCustomConnection = False
            .IntegratedSecurity = False
        End With

        CrTables = rd.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next

    End Sub



    Public Sub refresh_RESET(ByVal cr As CrystalReportViewer, ByVal e As CrystalDecisions.Windows.Forms.ViewerEventArgs)
        Dim rpt As Object
        e.Handled = True
        rpt = cr.ReportSource
        cr.ReportSource = Nothing
        cr.ParameterFieldInfo = rpt.ParameterFields
        rpt.Refresh()
        cr.ReportSource = rpt
    End Sub

End Module


