Public Class Report3

    Private Sub Report3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CrystalReportViewer1.ReportSource = Application.StartupPath & "\Reports\final stat.rpt"
    End Sub
End Class