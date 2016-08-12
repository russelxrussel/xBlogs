Public Class Report7

    Private Sub Report7_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CrystalReportViewer1.ReportSource = Application.StartupPath & "\Reports\prereg.rpt"
    End Sub
End Class