'Imports System.Windows.Forms
Public Class frmhome1
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        On Error Resume Next
        Dim a As String
        Dim cn As New ADODB.Connection
        Dim rs As New ADODB.Recordset

        a = MsgBox("Are you sure you want to exit", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Exit")
        If a = vbYes Then
           

            cn.Open("Provider=SQLOLEDB;Data Source=SSI-IT2;Integrated Security=SSPI;Initial Catalog=Blog")

            With rs
                .Open("Select * from useracct where usercode='" + TextBox1.Text + "'", cn, 2, 2)
                .Fields("status").Value = 0
                .Update()
                .Close()
            End With
            cn.Close()
            'cn.ConnectionTimeout = 0
            End
        Else
            Exit Sub
        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmreception.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmregdonor.Show()
        frmregdonor.TextBox10.Text = TextBox1.Text
        frmregdonor.TextBox11.Text = TextBox2.Text
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmrecording.Show()
    End Sub
    Private Sub frmhome_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        On Error Resume Next
        Dim cn As New ADODB.Connection
        Dim rs As New ADODB.Recordset
        cn.Open("Provider=SQLOLEDB;Data Source=SSI-IT2;Integrated Security=SSPI;Initial Catalog=Blog")
        With rs
            .Open("Select * from useracct where usercode='" + TextBox1.Text + "'", cn, 2, 2)
            .Fields("status").Value = 0
            .Update()
            .Close()
        End With
        cn.Close()
    End Sub
    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.White
        Button1.ForeColor = Color.Red
    End Sub

    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        Button1.BackColor = Color.Red
        Button1.ForeColor = Color.White
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.White
        Button2.ForeColor = Color.Red
    End Sub

    Private Sub Button2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseMove
        Button2.BackColor = Color.Red
        Button2.ForeColor = Color.White
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.White
        Button3.ForeColor = Color.Red
    End Sub

    Private Sub Button3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseMove
        Button3.BackColor = Color.Red
        Button3.ForeColor = Color.White
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        Button4.BackColor = Color.White
        Button4.ForeColor = Color.Red
    End Sub

    Private Sub Button4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button4.MouseMove
        Button4.BackColor = Color.Red
        Button4.ForeColor = Color.White
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frmnavigation.Show()
    End Sub

    Private Sub Button5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave
        Button5.BackColor = Color.White
        Button5.ForeColor = Color.Red
    End Sub

    Private Sub Button5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button5.MouseMove
        Button5.BackColor = Color.Red
        Button5.ForeColor = Color.White
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
