Public Class prereg_report

    Private Sub prereg_report_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CrystalReportViewer1.ReportSource = Application.StartupPath & "\Reports\prereg_new_report.rpt"
    End Sub
End Class