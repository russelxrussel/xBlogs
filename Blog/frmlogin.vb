Imports System.Text.RegularExpressions

Public Class frmlogin
    Public _name As String = ""
    Dim _flgUCODE As Boolean = False
    Dim _status As Integer = 0


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmlogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'msg = MsgBox("Are you sure you want to exit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Exit")
        'If msg = vbYes Then
        'Me.Close()
        'Else
        'Exit Sub
        'End If
    End Sub

    Private Sub frmlogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ''GET DATABASE SERVER DATE AND TIME
        'Call connect()
        'cn.Open()
        'rs.Open("SELECT GETDATE()", cn)
        '_SERVERDATETIME = rs.Fields(0).Value
        'rs.Close()
        'cn.Close()
        'Call connection_close()

        lblInfo.Text = "Operating System: " & My.Computer.Info.OSFullName.ToString & vbCrLf & _
                   "Product " & My.Application.Info.Description.ToString & vbCrLf & _
                   "Registered to: " & My.Application.Info.CompanyName.ToString & vbCrLf & _
                   My.Application.Info.Copyright.ToString()



        MaskedTextBox1.Focus()
        MaskedTextBox1.SelectionStart = 4
        AcceptButton = Button3
    End Sub
    Private Sub MaskedTextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox1.LostFocus
        Try


            Call connect()
            With rs
                .Open("Select * from useracct where usercode='" + MaskedTextBox1.Text + "'", cn)
                If rs.EOF = False Then
                    'Russel 1-8-2014
                    'Check first if status is enable or disable
                    _status = .Fields("status").Value
                    'MsgBox(_status)
                    'If _status = 0 Then
                    '    MsgBox("Sorry your account was disable at this time, Please coordinate to I.T Department", MsgBoxStyle.Exclamation, "Disable Account")
                    '    lblusername.Text = "Account disabled"
                    '    MaskedTextBox1.Focus()
                    'Else

                    TextBox3.Text = .Fields("Access").Value
                    _ACCESS = .Fields("Access").Value
                    'lblusername.Text = .Fields("username").Value
                    _name = .Fields("username").Value
                    _flgUCODE = True
                    lblusername.Text = "Verified"

                    'enable password
                    TextBox2.Enabled = True
                    TextBox2.Focus()
                    rs.Close()
                    Call connection_close()

                Else
                    'MsgBox("User code not exist", MsgBoxStyle.Critical, "Warning Message")
                    _flgUCODE = False
                    TextBox2.Text = ""
                    lblusername.Text = "Usercode not exist"
                    TextBox2.Enabled = False
                    MaskedTextBox1.Focus()
                    rs.Close()
                    Call connection_close()
                    Exit Sub
                End If
            End With

        Catch ex As Exception

        End Try

        'cn.Close()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        msg = MsgBox("Are you sure you want to exit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Exit")
        If msg = vbYes Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'On Error Resume Next
        ''Russel 1-8-2014
        ''New Condition
        'If _flgUCODE = True Then
        '    If _status = 0 Then
        '        MsgBox("Sorry your account was disable at this time, Please coordinate to I.T Department", MsgBoxStyle.Exclamation, "Disable Account")
        '        Exit Sub
        '    Else

        '        If Not Regex.Match(MaskedTextBox1.Text, "^U-\d{4}$").Success Then
        '            MsgBox("Please complete the user ID code", MsgBoxStyle.Critical, "Warning Message")
        '            MaskedTextBox1.Focus()
        '            Exit Sub
        '        End If
        '        If Trim(TextBox2.Text = "") Then
        '            MsgBox("Please Enter Password", MsgBoxStyle.Critical, "Warning Message")
        '            TextBox2.Focus()
        '            Exit Sub
        '        End If
        '        Call connect()
        '        With rs
        '            '.Open("select * from useracct where usercode='" + MaskedTextBox1.Text + "' and (username='" + lblusername.Text + "' and password='" + TextBox2.Text + "')", cn, 2, 2)
        '            .Open("select * from useracct where usercode='" + MaskedTextBox1.Text + "' and (password='" + TextBox2.Text + "')", cn, 2, 2)

        '            If .EOF = True Then
        '                MsgBox("Password and Usercode didn't match", MsgBoxStyle.Critical, "Warning Message")
        '                TextBox2.Focus()
        '                Call connection_close()
        '                Exit Sub
        '            Else
        '                _USERCODE = rs.Fields("usercode").Value
        '                txtstatus.Text = rs.Fields("access").Value
        '                MsgBox("Hi " & _name & ", Welcome to ERS-Blog", MsgBoxStyle.Information, "Login Success")
        '                If txtstatus.Text = "Level 1" Then
        '                    Call connection_close()
        '                    Dim frmhome As New frmhome
        '                    frmhome.Show()
        '                    frmhome.TextBox10.Text = MaskedTextBox1.Text
        '                    'frmhome.ToolStrip2.Enabled = False
        '                    frmhome.ToolStripButton13.Enabled = True
        '                    frmhome.ToolStripButton14.Enabled = True
        '                    frmhome.ToolStripButton11.Enabled = True
        '                    frmhome.ToolStripButton10.Enabled = True
        '                    '     frmhome.ToolStripButton1.Enabled = True
        '                    frmhome.ToolStripButton15.Enabled = False
        '                    frmhome.ToolStripButton12.Enabled = False
        '                    frmhome.ToolStripButton9.Enabled = False
        '                    Me.Close()
        '                End If
        '                If txtstatus.Text = "Level 2" Then
        '                    Call connection_close()
        '                    Dim frmhome As New frmhome
        '                    frmhome.Show()
        '                    frmhome.TextBox10.Text = MaskedTextBox1.Text
        '                    'frmhome.ToolStrip2.Enabled = False
        '                    frmhome.ToolStripButton13.Enabled = False
        '                    frmhome.ToolStripButton14.Enabled = True
        '                    frmhome.ToolStripButton11.Enabled = True
        '                    frmhome.ToolStripButton10.Enabled = True
        '                    '   frmhome.ToolStripButton1.Enabled = True
        '                    frmhome.ToolStripButton15.Enabled = True
        '                    frmhome.ToolStripButton12.Enabled = True
        '                    frmhome.ToolStripButton9.Enabled = False
        '                    Me.Close()
        '                End If
        '                If txtstatus.Text = "Level 3" Then
        '                    Call connection_close()
        '                    Dim frmhome As New frmhome
        '                    frmhome.Show()
        '                    frmhome.TextBox10.Text = MaskedTextBox1.Text
        '                    'frmhome.ToolStrip2.Enabled = False
        '                    frmhome.ToolStripButton13.Enabled = False
        '                    frmhome.ToolStripButton14.Enabled = True
        '                    frmhome.ToolStripButton11.Enabled = True
        '                    frmhome.ToolStripButton10.Enabled = True
        '                    ' frmhome.ToolStripButton1.Enabled = True
        '                    frmhome.ToolStripButton15.Enabled = False
        '                    frmhome.ToolStripButton12.Enabled = False
        '                    frmhome.ToolStripButton9.Enabled = False
        '                    Me.Close()
        '                End If
        '                If txtstatus.Text = "Level 4" Then
        '                    Call connection_close()
        '                    Dim frmhome As New frmhome
        '                    frmhome.Show()
        '                    frmhome.TextBox10.Text = MaskedTextBox1.Text
        '                    'frmhome.ToolStrip2.Enabled = False
        '                    frmhome.ToolStripButton13.Enabled = True
        '                    frmhome.ToolStripButton14.Enabled = True
        '                    frmhome.ToolStripButton11.Enabled = True
        '                    frmhome.ToolStripButton10.Enabled = True
        '                    'frmhome.ToolStripButton1.Enabled = True
        '                    frmhome.ToolStripButton15.Enabled = True
        '                    frmhome.ToolStripButton12.Enabled = True
        '                    frmhome.ToolStripButton9.Enabled = True
        '                    Me.Close()
        '                End If
        '            End If

        '        End With
        '        Call connection_close()
        '    End If

        '    Exit Sub
        'Else 'from flgUCODE
        '    MsgBox("User code not verified", MsgBoxStyle.Exclamation, "Verify User Code First")
        '    MaskedTextBox1.Focus()
        '    Exit Sub
        'End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        'Russel 1-8-2014
        'New Condition
        If _flgUCODE = True Then
            If _status = 0 Then
                MsgBox("Sorry your account was disable at this time, Please coordinate to I.T Department", MsgBoxStyle.Exclamation, "Disable Account")
                Exit Sub
            Else

                If Not Regex.Match(MaskedTextBox1.Text, "^U-\d{4}$").Success Then
                    MsgBox("Please complete the user ID code", MsgBoxStyle.Critical, "Warning Message")
                    MaskedTextBox1.Focus()
                    Exit Sub
                End If
                If Trim(TextBox2.Text = "") Then
                    MsgBox("Please Enter Password", MsgBoxStyle.Critical, "Warning Message")
                    TextBox2.Focus()
                    Exit Sub
                End If
                Call connect()
                With rs
                    '.Open("select * from useracct where usercode='" + MaskedTextBox1.Text + "' and (username='" + lblusername.Text + "' and password='" + TextBox2.Text + "')", cn, 2, 2)
                    .Open("select * from useracct where usercode='" + MaskedTextBox1.Text + "' and (password='" + TextBox2.Text + "')", cn, 2, 2)

                    If .EOF = True Then
                        MsgBox("Password and Usercode didn't match", MsgBoxStyle.Critical, "Warning Message")
                        TextBox2.Focus()
                        Call connection_close()
                        Exit Sub
                    Else
                        _USERCODE = .Fields("usercode").Value
                        _ACCESS = .Fields("Access").Value

                        MsgBox("Hi " & _name & ", Welcome to BLOG-Electronic Registration System", MsgBoxStyle.Information, "Login Success")

                        If _access = "Level 1" Then
                            Call connection_close()
                            Dim frmhome As New frmhome
                            frmhome.Show()
                            frmhome.TextBox10.Text = MaskedTextBox1.Text
                            'frmhome.ToolStrip2.Enabled = False
                            frmhome.ToolStripButton13.Enabled = True
                            frmhome.ToolStripButton14.Enabled = False
                            frmhome.ToolStripButton11.Enabled = True
                            frmhome.ToolStripButton10.Enabled = True
                            '     frmhome.ToolStripButton1.Enabled = True
                            frmhome.ToolStripButton15.Enabled = False
                            frmhome.ToolStripButton12.Enabled = False
                            frmhome.ToolStripButton9.Enabled = False
                            Me.Close()
                        End If
                        If _access = "Level 2" Then
                            Call connection_close()
                            Dim frmhome As New frmhome
                            frmhome.Show()
                            frmhome.TextBox10.Text = MaskedTextBox1.Text
                            'frmhome.ToolStrip2.Enabled = False
                            frmhome.ToolStripButton13.Enabled = False
                            frmhome.ToolStripButton14.Enabled = False
                            frmhome.ToolStripButton11.Enabled = True
                            frmhome.ToolStripButton10.Enabled = True
                            '   frmhome.ToolStripButton1.Enabled = True
                            frmhome.ToolStripButton15.Enabled = True
                            frmhome.ToolStripButton12.Enabled = True
                            frmhome.ToolStripButton9.Enabled = False
                            Me.Close()
                        End If
                        If _access = "Level 3" Then
                            Call connection_close()
                            Dim frmhome As New frmhome
                            frmhome.Show()
                            frmhome.TextBox10.Text = MaskedTextBox1.Text
                            'frmhome.ToolStrip2.Enabled = False
                            frmhome.ToolStripButton13.Enabled = True
                            frmhome.ToolStripButton14.Enabled = True
                            frmhome.ToolStripButton12.Enabled = True
                            frmhome.ToolStripButton11.Enabled = True
                            frmhome.ToolStripButton10.Enabled = True
                            ' frmhome.ToolStripButton1.Enabled = True
                            frmhome.ToolStripButton15.Enabled = True

                            frmhome.ToolStripButton9.Enabled = False
                            Me.Close()
                        End If
                        If _access = "Level 4" Then
                            Call connection_close()
                            Dim frmhome As New frmhome
                            frmhome.Show()
                            frmhome.TextBox10.Text = MaskedTextBox1.Text
                            'frmhome.ToolStrip2.Enabled = False
                            frmhome.ToolStripButton13.Enabled = True
                            frmhome.ToolStripButton14.Enabled = True
                            frmhome.ToolStripButton11.Enabled = True
                            frmhome.ToolStripButton10.Enabled = True
                            'frmhome.ToolStripButton1.Enabled = True
                            frmhome.ToolStripButton15.Enabled = True
                            frmhome.ToolStripButton12.Enabled = True
                            frmhome.ToolStripButton9.Enabled = True
                            Me.Close()
                        End If
                    End If

                End With
                Call connection_close()
            End If

            Exit Sub
        Else 'from flgUCODE
            MsgBox("User code not verified", MsgBoxStyle.Exclamation, "Verify User Code First")
            MaskedTextBox1.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.LightGreen
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.LightGray
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        msg = MsgBox("Are you sure you want to exit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Exit")
        If msg = vbYes Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.LightGreen
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.LightGray
    End Sub
End Class
