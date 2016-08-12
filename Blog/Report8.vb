Public Class Report8

    Private Sub Report8_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CrystalReportViewer1.ReportSource = Application.StartupPath & "\Reports\presum.rpt"
    End Sub
End Class