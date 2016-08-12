Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Data.OleDb.OleDbCommand
Public Class frmregdonor

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtage.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim donorSurname = ComboBox1.Text
        Dim donorFirstName = ComboBox2.Text
        Dim donorMI = ComboBox3.Text


        On Error Resume Next
        'If Trim(ComboBox1.Text = "") Then
        '    MsgBox("Please enter the Surname", MsgBoxStyle.Critical, "Warning Message")
        '    Exit Sub String.IsNullOrEmpty(Trim(donorSurname)) Or 
        ' ComboBox1.Text.Trim.Length = 0 Then
        If String.IsNullOrEmpty(ComboBox1.Text) Then
            MsgBox("Please enter the Surname", MsgBoxStyle.Critical, "Warning Message")
            Exit Sub
        ElseIf Trim(ComboBox2.Text = "") Then
            MsgBox("Please enter the Firstname", MsgBoxStyle.Critical, "Warning Message")
            Exit Sub
        ElseIf Trim(ComboBox3.Text = "") Then
            MsgBox("Please enter the Middle Initial", MsgBoxStyle.Critical, "Warning Message")
            Exit Sub
        ElseIf Trim(txtage.Text = "") Then
            MsgBox("Please enter the Age", MsgBoxStyle.Critical, "Warning Message")
            Exit Sub
        ElseIf Trim(txtrecruiter.Text = "") Then
            MsgBox("Please enter recruiter name", MsgBoxStyle.Critical, "Warning Message")
            Exit Sub
        End If

        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MsgBox("Please select a gender", MsgBoxStyle.Critical, "Warning Message")
            Exit Sub
        End If

        Call connect()
        With rs
            .Open("select * from dinfo where dcode='" + TextBox14.Text + "' ", cn, 2, 2)
            If .EOF = False Then
                .Fields("sname").Value = ComboBox1.Text
                .Fields("fname").Value = ComboBox2.Text
                .Fields("mname").Value = ComboBox3.Text
                .Fields("bday").Value = DateTimePicker1.Value
                .Fields("age").Value = txtage.Text

                If RadioButton1.Checked = True Then
                    .Fields("gender").Value = RadioButton1.Text
                ElseIf RadioButton2.Checked = True Then
                    .Fields("gender").Value = RadioButton2.Text
                End If

                .Fields("studno").Value = TextBox9.Text
                .Fields("stno").Value = "Station 3"
                .Fields("status").Value = "Pre Reg"
                'Additional Information for Relationship 
                'Russel Vasquez 1-15-2014
                .Fields("stationID").Value = 3
                'Pre Registration
                .Fields("remarksID").Value = 1

                .Fields("studname").Value = txtrecruiter.Text
                .Update()
                .Close()
            Else
                Dim a As String
                With rs
                    If .State <> 0 Then .Close()
                    .Open("select * from dinfo", cn)
                    If rs.EOF = False Then
                        TextBox1.Text = .Fields("id").Value
                    End If
                    .Close()
                End With

                TextBox1.Text = Val(TextBox1.Text) + 1
                a = TextBox1.Text
                If a.Length = 1 Then
                    TextBox6.Text = "000" & a
                ElseIf a.Length = 2 Then
                    TextBox6.Text = "00" & a
                ElseIf a.Length = 3 Then
                    TextBox6.Text = "0" & a
                ElseIf a.Length = 4 Then
                    TextBox6.Text = a
                End If

                With rs
                    .Open("select * from dinfo", cn, 2, 2)
                    .Fields("id").Value = TextBox1.Text
                    .Update()
                    .Close()
                End With

                With rs
                    .Open("select * from dinfo", cn, 2, 2)
                    .AddNew()
                    .Fields("dcode").Value = Format("DM14-" + TextBox6.Text)
                    .Fields("sname").Value = ComboBox1.Text
                    .Fields("fname").Value = ComboBox2.Text
                    .Fields("mname").Value = ComboBox3.Text
                    .Fields("bday").Value = DateTimePicker1.Value.Date
                    .Fields("age").Value = txtage.Text

                    If RadioButton1.Checked = True Then
                        .Fields("gender").Value = RadioButton1.Text
                    ElseIf RadioButton2.Checked = True Then
                        .Fields("gender").Value = RadioButton2.Text
                    End If
                    If TextBox4.Text = "" Then
                        .Fields("Rtype").Value = "NA"
                    Else
                        .Fields("Rtype").Value = TextBox4.Text
                    End If
                    .Fields("studno").Value = TextBox3.Text
                    .Fields("stno").Value = "Station 3"
                    .Fields("status").Value = "Pre Reg"
                    'Additional Information for Relationship 
                    'Russel Vasquez 1-15-2014
                    .Fields("stationID").Value = 3
                    'Pre Registration
                    .Fields("remarksID").Value = 1

                    .Fields("studname").Value = TextBox5.Text
                    .Fields("date").Value = Now.Date
                    .Update()
                End With
            End If
            .Close()
        End With
        Dim frmhome As New frmhome
        With rs
            .Open("select * from atrail", cn, 2, 2)
            .AddNew()
            .Fields("Usercode").Value = _USERCODE
            .Fields("Act1").Value = "Pre Reg"
            .Fields("Func").Value = Me.Text & " " & ComboBox1.Text & " " & ComboBox2.Text & " " & ComboBox3.Text
            .Fields("dte").Value = Now
            .Update()
            .Close()
        End With
        'rs.Close()
        cn.Close()
        ComboBox1.Items.Clear()
        Call recon()
        txtbirthday.Text = "##/##/####"
        txtage.Text = ""
        txtrecruiter.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        txtrecruiter.Text = ""
        TextBox4.Text = ""
        TextBox14.Text = ""
        '  Me.SInfoTableAdapter2.Fill(Me.BlogDataSet8.SInfo)
        MsgBox("Registration has been successfully made", MsgBoxStyle.Information, "Registration")
        DateTimePicker1.Value = Now.Date
        txtrecruiter.ReadOnly = False
        dginfo.Enabled = True

    End Sub

    Private Sub frmregdonor_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate

    End Sub

    Private Sub frmregdonor_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed

    End Sub

    Private Sub frmregdonor_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If cn.State = 1 Then
            'MsgBox(cn.State.ToString)
            cn.Close()
        Else
        End If
    End Sub
 
    Private Sub frmregdonor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dt As New DataTable
        Dim oleb As New OleDb.OleDbDataAdapter

        Call connect()
        rs.Open("select * from sinfo", cn)
        oleb.Fill(dt, rs)
        Call connection_close()
        dginfo.DataSource = dt

        Call connect()

        With rs
            If .State <> 0 Then .Close()
            .Open("select * from dinfo order by sname ASC", cn, 2, 2)
            While .EOF = False
                ComboBox1.Items.Add(.Fields("sname").Value)
                .MoveNext()
            End While
        End With

        cn.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        Me.Close()
        'frmhome1.Show()
        txtbirthday.Text = "##/##/####"
        txtage.Text = ""
        txtrecruiter.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        txtrecruiter.ReadOnly = False
        dginfo.Enabled = True
        Dim cn As New ADODB.Connection
        Dim rs As New ADODB.Recordset

        Call connect()
        With rs
            .Open("select * from dinfo", cn)
            .Close()
        End With
        cn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error Resume Next
        If Trim(ComboBox1.Text = "") Then
            MsgBox("Please enter the Surname", MsgBoxStyle.Critical, "Warning Message")
            Exit Sub
        ElseIf Trim(ComboBox2.Text = "") Then
            MsgBox("Please enter the Firstname", MsgBoxStyle.Critical, "Warning Message")
            Exit Sub
        ElseIf Trim(ComboBox3.Text = "") Then
            MsgBox("Please enter the Middle Initial", MsgBoxStyle.Critical, "Warning Message")
            Exit Sub
        ElseIf Trim(txtage.Text = "") Then
            MsgBox("Please enter the Age", MsgBoxStyle.Critical, "Warning Message")
            Exit Sub
        ElseIf Trim(txtrecruiter.Text = "") Then
            MsgBox("Please enter recruiter name", MsgBoxStyle.Critical, "Warning Message")
            Exit Sub
        End If

        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MsgBox("Please select a gender", MsgBoxStyle.Critical, "Warning Message")
            Exit Sub
        End If

        Call connect()
        With rs
            .Open("select * from dinfo where dcode='" + TextBox14.Text + "' ", cn, 2, 2)
            If .EOF = False Then
                .Fields("sname").Value = ComboBox1.Text
                .Fields("fname").Value = ComboBox2.Text
                .Fields("mname").Value = ComboBox3.Text
                .Fields("bday").Value = DateTimePicker1.Value
                .Fields("age").Value = txtage.Text

                If RadioButton1.Checked = True Then
                    .Fields("gender").Value = RadioButton1.Text
                ElseIf RadioButton2.Checked = True Then
                    .Fields("gender").Value = RadioButton2.Text
                End If

                .Fields("studno").Value = TextBox9.Text
                .Fields("stno").Value = "Station 3"
                .Fields("status").Value = "Processing"
                'Additional Information for Relationship 
                'Russel Vasquez 1-15-2014
                .Fields("stationID").Value = 3
                .Fields("remarksID").Value = 2
                .Fields("studname").Value = txtrecruiter.Text
                .Update()
                .Close()
            Else
                Dim a As String
                With rs
                    If .State <> 0 Then .Close()
                    .Open("select * from dinfo", cn)
                    If rs.EOF = False Then
                        TextBox1.Text = .Fields("id").Value
                    End If
                    .Close()
                End With

                TextBox1.Text = Val(TextBox1.Text) + 1
                a = TextBox1.Text
                If a.Length = 1 Then
                    TextBox6.Text = "000" & a
                ElseIf a.Length = 2 Then
                    TextBox6.Text = "00" & a
                ElseIf a.Length = 3 Then
                    TextBox6.Text = "0" & a
                ElseIf a.Length = 4 Then
                    TextBox6.Text = a
                End If

                With rs
                    .Open("select * from dinfo", cn, 2, 2)
                    .Fields("id").Value = TextBox1.Text
                    .Update()
                    .Close()
                End With

                With rs
                    .Open("select * from dinfo", cn, 2, 2)
                    .AddNew()
                    .Fields("dcode").Value = Format("DM14-" + TextBox6.Text)
                    .Fields("sname").Value = ComboBox1.Text
                    .Fields("fname").Value = ComboBox2.Text
                    .Fields("mname").Value = ComboBox3.Text
                    .Fields("bday").Value = DateTimePicker1.Value.Date
                    .Fields("age").Value = txtage.Text

                    If RadioButton1.Checked = True Then
                        .Fields("gender").Value = RadioButton1.Text
                    ElseIf RadioButton2.Checked = True Then
                        .Fields("gender").Value = RadioButton2.Text
                    End If
                    If TextBox4.Text = "" Then
                        .Fields("Rtype").Value = "NA"
                    Else
                        .Fields("Rtype").Value = TextBox4.Text
                    End If
                    .Fields("studno").Value = TextBox3.Text
                    .Fields("stno").Value = "Station 3"
                    .Fields("status").Value = "Processing"
                    'Additional Information for Relationship 
                    'Russel Vasquez 1-15-2014
                    .Fields("stationID").Value = 3
                    .Fields("remarksID").Value = 2

                    .Fields("studname").Value = TextBox5.Text
                    .Fields("date").Value = Now.Date
                    .Update()
                End With
            End If
            .Close()
        End With
        Dim frmhome As New frmhome
        With rs
            .Open("select * from atrail", cn, 2, 2)
            .AddNew()
            .Fields("Usercode").Value = _USERCODE
            .Fields("Act1").Value = "Processing"
            .Fields("Func").Value = Me.Text & " " & ComboBox1.Text & " " & ComboBox2.Text & " " & ComboBox3.Text
            .Fields("dte").Value = Now
            .Update()
            .Close()
        End With
        'rs.Close()
        cn.Close()
        ComboBox1.Items.Clear()
        Call recon()
        txtbirthday.Text = "##/##/####"
        txtage.Text = ""
        txtrecruiter.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        txtrecruiter.Text = ""
        TextBox4.Text = ""
        TextBox14.Text = ""
        '  Me.SInfoTableAdapter2.Fill(Me.BlogDataSet8.SInfo)
        MsgBox("Process has been saved", MsgBoxStyle.Information, "Process")
        DateTimePicker1.Value = Now.Date
        txtrecruiter.ReadOnly = False
        dginfo.Enabled = True
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress

        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox2.Text = ""
        ComboBox3.Text = ""

        Call connect()

        With rs
            If .State <> 0 Then .Close()
            .Open("select * from dinfo where sname='" + ComboBox1.Text + "' order by fname ASC", cn)
            While .EOF = False
                ComboBox2.Items.Add(.Fields("fname").Value)
                .MoveNext()
            End While
        End With

        Call connection_close()

    End Sub

    Private Sub ComboBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.LostFocus
        ComboBox1.Text = UCase(ComboBox1.Text)
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox2.Text = ""
        ComboBox3.Text = ""
    
        Call connect()

        With rs
            .Open("select * from dinfo where sname='" + ComboBox1.Text + "' order by fname ASC", cn)
            While .EOF = False
                ComboBox2.Items.Add(.Fields("fname").Value)
                .MoveNext()
            End While
        End With

        rs.Close()
        cn.Close()

    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        ComboBox3.Items.Clear()
        ComboBox3.Text = ""

        Call connect()

        With rs
            .Open("select * from dinfo where fname='" + ComboBox2.Text + "' order by mname ASC", cn)
            While .EOF = False
                ComboBox3.Items.Add(.Fields("mname").Value)
                .MoveNext()
            End While
        End With
        cn.Close()
    End Sub

    Private Sub ComboBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.LostFocus
        ComboBox2.Text = UCase(ComboBox2.Text)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox3.Items.Clear()
        ComboBox3.Text = ""
        Call connect()
        With rs
            .Open("select * from dinfo where fname='" + ComboBox2.Text + "' order by mname ASC", cn)
            While .EOF = False
                ComboBox3.Items.Add(.Fields("mname").Value)
                .MoveNext()
            End While
        End With
        rs.Close()
        cn.Close()
    End Sub

    Private Sub ComboBox3_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox3.LostFocus
        Dim a As String
        Call connect()
        With rs
            .Open("select * from dinfo where sname='" + ComboBox1.Text + "' and fname='" + ComboBox2.Text + "' and mname='" + ComboBox3.Text + "'", cn)
            If .EOF = False Then
                a = MsgBox("The donor's name exists!! Do you want to continue?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Continue")
                If a = vbYes Then
                    If rs.EOF = False Then
                        TextBox8.Text = .Fields("gender").Value
                        DateTimePicker1.Value = .Fields("bday").Value
                        txtage.Text = .Fields("age").Value
                        txtrecruiter.Text = .Fields("studname").Value
                        TextBox9.Text = .Fields("studno").Value
                        TextBox14.Text = .Fields("dcode").Value
                        If .Fields("gender").Value() = "M" Then
                            RadioButton1.Checked = True
                        Else
                            RadioButton2.Checked = True
                        End If
                        txtrecruiter.ReadOnly = True
                        txtrecruiter.BackColor = Color.White
                        dginfo.Enabled = False
                    End If

                Else
                    ComboBox1.Text = ""
                    ComboBox2.Text = ""
                    ComboBox3.Text = ""
                    dginfo.Enabled = True
                End If
            End If

        End With
        ComboBox3.Text = UCase(ComboBox3.Text)
        cn.Close()
    End Sub
    Private Sub recon()
        'Me.SInfoTableAdapter.Fill(Me.BlogDataSet8.SInfo

        Call connect()
        With rs
            If .State <> 0 Then .Close()
            .Open("select * from dinfo order by sname ASC", cn, 2, 2)
            While .EOF = False
                ComboBox1.Items.Add(.Fields("sname").Value)
                .MoveNext()
            End While
        End With
        rs.Close()
        cn.Close()
    End Sub
    Private Sub txtrecruiter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrecruiter.KeyPress
        Dim ca As New DataTable
        Dim custDA As New OleDb.OleDbDataAdapter
        Call connect()
        rs.Open("select * from Sinfo where Sname like '%" & txtrecruiter.Text & "%' or Fname like '%" & txtrecruiter.Text & "%' ", cn)
        custDA.Fill(ca, rs)
        rs.Close()
        cn.Close()
        dginfo.DataSource = ca
    End Sub

    Private Sub dginfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dginfo.Click
        On Error Resume Next
        TextBox3.Text = dginfo.CurrentRow.Cells(0).Value
        TextBox4.Text = dginfo.CurrentRow.Cells(7).Value
        TextBox5.Text = dginfo.CurrentRow.Cells(1).Value & " " & dginfo.CurrentRow.Cells(2).Value & " " & dginfo.CurrentRow.Cells(3).Value
        txtrecruiter.Text = ""
        txtrecruiter.Text = dginfo.CurrentRow.Cells(1).Value & " " & dginfo.CurrentRow.Cells(2).Value & " " & dginfo.CurrentRow.Cells(3).Value
    End Sub

    Private Sub DateTimePicker1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker1.LostFocus
        If DateTimePicker1.Value.Month > DateTimePicker2.Value.Month Then
            txtage.Text = Val(DateTimePicker2.Value.Year) - Val(DateTimePicker1.Value.Year) - 1
            Exit Sub
        End If
        If DateTimePicker1.Value.Month = DateTimePicker2.Value.Month Then
            If DateTimePicker1.Value.Day > DateTimePicker2.Value.Day Then
                txtage.Text = Val(DateTimePicker2.Value.Year) - Val(DateTimePicker1.Value.Year) - 1
                Exit Sub
            End If
        End If
        txtage.Text = Val(DateTimePicker2.Value.Year) - Val(DateTimePicker1.Value.Year)
    End Sub


End Class