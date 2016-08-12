Public Class Report4

    Private Sub Report4_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CrystalReportViewer1.ReportSource = Application.StartupPath & "\Reports\incentives-div.rpt"
    End Sub
End Class