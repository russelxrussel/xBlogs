Public Class Report11

    Private Sub Report11_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CrystalReportViewer1.ReportSource = Application.StartupPath & "\Reports\Pre-Level.rpt"
    End Sub
End Class