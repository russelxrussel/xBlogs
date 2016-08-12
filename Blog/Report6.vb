Public Class Report6

    Private Sub Report6_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CrystalReportViewer1.ReportSource = Application.StartupPath & "\Reports\pre stat.rpt"
    End Sub
End Class