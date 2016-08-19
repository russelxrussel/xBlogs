

Public Class frmnavigation


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim report1 As New Report1
        report1.Show()
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim report8 As New Report8
        report8.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        On Error Resume Next
        Dim report2 As New Report2
        report2.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error Resume Next
        Dim report3 As New Report3
        report3.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        On Error Resume Next
        Dim report4 As New Report4
        report4.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        On Error Resume Next
        Dim report5 As New Report5
        report5.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        On Error Resume Next
        Dim report6 As New Report6
        report6.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        On Error Resume Next
        Dim report7 As New Report7
        report7.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        On Error Resume Next
        Dim report9 As New Report9
        report9.Show()
    End Sub

    Private Sub frmnavigation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        On Error Resume Next
        Dim report10 As New Report10
        report10.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        On Error Resume Next
        Dim report11 As New Report11
        report11.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        On Error Resume Next
        Dim preregRep As New prereg_report
        preregRep.Show()
    End Sub


   
End Class