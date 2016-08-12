Public Class Report10

    Private Sub Report10_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CrystalReportViewer1.ReportSource = Application.StartupPath & "\Reports\Pre-Stud.rpt"
    End Sub
End Class