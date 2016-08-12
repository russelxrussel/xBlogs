Public Class Report9


    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Me.CrystalReportViewer1.ReportSource = Application.StartupPath & "\Reports\summary.rpt"
    End Sub
End Class