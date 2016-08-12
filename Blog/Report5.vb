Public Class Report5

    Private Sub Report5_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CrystalReportViewer1.ReportSource = Application.StartupPath & "\Reports\incentives-stud.rpt"
    End Sub
End Class