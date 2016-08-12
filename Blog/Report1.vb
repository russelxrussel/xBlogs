Public Class Report1



    Private Sub Report1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CrystalReportViewer1.ReportSource = Application.StartupPath & "\Reports\deffered.rpt"
    End Sub

End Class