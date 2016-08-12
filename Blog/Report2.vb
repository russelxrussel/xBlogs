Public Class Report2

    Private Sub Report2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CrystalReportViewer1.ReportSource = Application.StartupPath & "\Reports\donor.rpt"
    End Sub
End Class