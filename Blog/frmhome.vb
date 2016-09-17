Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports System.Drawing
'Imports System.Runtime.InteropServices

Public Class frmhome
    Dim clockDateTime As DateTime
    Dim ts As TimeSpan


#Region "Machine Time Change"
    'It was disable due to need some adjustment needed

    'Added
    '<StructLayoutAttribute(LayoutKind.Sequential)> _
    'Structure SYSTEMTIME
    '    Public year As Short
    '    Public month As Short
    '    Public dayOfWeek As Short
    '    Public day As Short
    '    Public hour As Short
    '    Public minute As Short
    '    Public second As Short
    '    Public milliseconds As Short
    'End Structure

    '<DllImport("kernel32.dll", setLastError:=True)> Public Shared Function SetSystemTime(ByRef theDateTime As SYSTEMTIME) As Boolean
    'End Function

    ''**************

    'Public Sub SetMachineTime(ByVal p_NewDate As DateTime)
    '    'Populate structure...
    '    'Substitute <YOUR DATE OBJECT> with your date object returned via GPRS...

    '    Dim st As SYSTEMTIME
    '    st.year = p_NewDate.Year
    '    st.month = p_NewDate.Month
    '    st.dayOfWeek = p_NewDate.DayOfWeek
    '    st.day = p_NewDate.Day
    '    st.hour = p_NewDate.Hour + 4
    '    st.minute = p_NewDate.Minute
    '    st.second = p_NewDate.Second
    '    st.milliseconds = p_NewDate.Millisecond

    '    'Set the new time...
    '    SetSystemTime(st)
    '    'Return st

    'End Sub
#End Region
   

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        msg = MsgBox("Are you sure you want to exit", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning Message")
        If msg = vbYes Then
            End
        Else
            Exit Sub
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        msg = MsgBox("Are you sure you want to exit", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning Message")
        If msg = vbYes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub frmhome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call fill_grid()
        Call recon()
        dgrecruiter.ClearSelection()

        'Will populate the Server Date and time to Analog Clock
        'Russel 1-14-2014
        cn.Open()
        rs.Open("Select GETDATE()", cn)
        _SERVERDATETIME = rs.Fields(0).Value
        cn.Close()
        '********************


        lblCaption.Text = "User" & vbCrLf & _
                          "Date" & vbCrLf & _
                          "Time Login"

        lblUserDetails.Text = ":  " & frmlogin._name & vbCrLf & _
                             ":  " & FormatDateTime(_SERVERDATETIME, DateFormat.ShortDate) & vbCrLf & _
                             ":  " & FormatDateTime(_SERVERDATETIME, DateFormat.LongTime).ToString


        lblSystemInfo.Text = "Statefields School Inc." & vbNewLine & _
                             "B.L.O.G.Electronic Registration System ©" & vbNewLine & _
                             "SSI-IT 2016"


      

        ts = New TimeSpan(0, _SERVERDATETIME.Hour - DateTime.UtcNow.Hour, _SERVERDATETIME.Minute - DateTime.UtcNow.Minute, _SERVERDATETIME.Second - DateTime.UtcNow.Second)

        '  SetMachineTime(serverDate)

    End Sub
    Public Sub recon()
        cmbedit_searchusercode.Items.Clear()
        cmbdelete_searchaccount.Items.Clear()
        Call account_search(Me.cmbedit_searchusercode)
        Call account_search(Me.cmbdelete_searchaccount)
    End Sub
    Sub fill_grid()
        dgrecruiter.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Dim dt As New DataTable
        Dim oleb As New OleDb.OleDbDataAdapter
        Call connect()
        rs.Open("select [studno],[sname],[fname],[mname],[ltype],[lcode],[sec],[typ] from sinfo", cn)
        oleb.Fill(dt, rs)
        Call connection_close()
        dgrecruiter.DataSource = dt
        'dgrecruiter.Columns(0).HeaderText
        dgrecruiter.Columns(0).HeaderText = "Student No."
        dgrecruiter.Columns(1).HeaderText = "Surname"
        dgrecruiter.Columns(2).HeaderText = "First Name"
        dgrecruiter.Columns(3).HeaderText = "Middle Name"
        dgrecruiter.Columns(4).HeaderText = "Level Type"
        dgrecruiter.Columns(5).HeaderText = "Level Code"
        dgrecruiter.Columns(6).HeaderText = "Section"
        dgrecruiter.Columns(7).HeaderText = "Type"
        dgrecruiter.Columns(0).Width = 100
        dgrecruiter.Columns(1).Width = 200
        dgrecruiter.Columns(2).Width = 230
        dgrecruiter.Columns(3).Width = 120
        dgrecruiter.Columns(4).Width = 100
        dgrecruiter.Columns(5).Width = 100
        dgrecruiter.Columns(6).Width = 100
        dgrecruiter.Columns(7).Width = 80
    End Sub
    Private Sub dtbirthday_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtbirthday.Leave
        If Now.Day < dtbirthday.Value.Day Or Now.Day > dtbirthday.Value.Day And Now.Month < dtbirthday.Value.Month Then
            lblbdayage.Text = Val(Now.Year) - Val(dtbirthday.Value.Year) - 1
        Else
            lblbdayage.Text = Val(Now.Year) - Val(dtbirthday.Value.Year)
        End If
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave_account.Click
        Try
            Replace(msk_usercode.Text, "_", "")
            If msk_usercode.Text.Length < 6 Then
                MsgBox("Incomplete Usercode", MsgBoxStyle.Critical, "Warning Message")
                Exit Sub
            End If

            If cmbsave_level.Text = "Select Level of Access" Then
                MsgBox("Choose level of access", MsgBoxStyle.Critical, "Warning Message")
                Exit Sub
            End If

            If txtsave_re.Text <> txtsave_password.Text Then
                MsgBox("Password confirmation failed", MsgBoxStyle.Critical, "Warning Message")
                Exit Sub
            End If

            If Trim(txtsave_username.Text = "") Then
                MsgBox("Enter Username", MsgBoxStyle.Critical, "Warning Message")
                Exit Sub
            End If

            If Trim((txtsave_password.Text = "") Or Trim(txtsave_re.Text = "")) Then
                MsgBox("Please enter both password and confirmation", MsgBoxStyle.Critical, "Warning Message")
                Exit Sub
            End If

            Call connect()
            strsql = "select * from useracct where usercode='" + msk_usercode.Text + "'"
            rs.Open(strsql, cn)
            If rs.EOF = False Then
                MsgBox("Usercode already exist please try another one", MsgBoxStyle.Critical, "Warning Message")
                Call connection_close()
                Exit Sub
            End If
            Call connection_close()

            Call connect()
            cn.Execute("insert into useracct([usercode],[username],[password],[access],[status]) values('" + msk_usercode.Text + "','" + txtsave_username.Text + "','" + txtsave_password.Text + "','" + cmbsave_level.Text + "','0')")
            MsgBox("Account Save", MsgBoxStyle.Information, "Save")
            msk_usercode.Text = "U-____"
            cmbsave_level.Text = "Select Level of Access"
            txtsave_username.Text = ""
            txtsave_password.Text = ""
            txtsave_re.Text = ""
            Call connection_close()
        Catch ex As Exception
            MsgBox("Error Message:" + ex.ToString)
        End Try
        Call recon()
    End Sub
    Private Sub cmbedit_searchusercode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbedit_searchusercode.SelectedIndexChanged
        Try
            Call connect()
            strsql = "select * from useracct where usercode='" + cmbedit_searchusercode.Text + "'"
            rs.Open(strsql, cn)
            If rs.EOF = False Then
                txtedit_usercode.Text = rs.Fields("usercode").Value
                txtedit_username.Text = rs.Fields("username").Value
                txtedit_password.Text = rs.Fields("password").Value
                txtedit_repassword.Text = rs.Fields("password").Value
                cmbedit_levelofaccess.Text = rs.Fields("access").Value
            End If
            Call connection_close()
        Catch ex As Exception
            MsgBox("Error Message", +ex.ToString)
        End Try
    End Sub
    Private Sub btnedit_account_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit_account.Click
        Try
            msg = MsgBox("Do you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Update")
            If msg = vbYes Then
                Replace(txtedit_usercode.Text, "_", "")

                If txtedit_usercode.Text.Length < 6 Then
                    MsgBox("Incomplete Usercode", MsgBoxStyle.Critical, "Warning Message")
                    Exit Sub
                End If

                If cmbedit_levelofaccess.Text = "Select Level of Access" Then
                    MsgBox("Choose level of access", MsgBoxStyle.Critical, "Warning Message")
                    Exit Sub
                End If

                If txtedit_repassword.Text <> txtedit_password.Text Then
                    MsgBox("Password confirmation failed", MsgBoxStyle.Critical, "Warning Message")
                    Exit Sub
                End If

                If Trim(txtedit_username.Text = "") Then
                    MsgBox("Enter Username", MsgBoxStyle.Critical, "Warning Message")
                    Exit Sub
                End If

                If Trim((txtedit_password.Text = "") Or Trim(txtedit_repassword.Text = "")) Then
                    MsgBox("Please enter both password and confirmation", MsgBoxStyle.Critical, "Warning Message")
                    Exit Sub
                End If

                Call connect()
                strsql = "update useracct set usercode='" + txtedit_usercode.Text + "',username='" + txtedit_username.Text + "',access='" + cmbedit_levelofaccess.Text + "',password='" + txtedit_password.Text + "' where usercode='" + cmbedit_searchusercode.Text + "'"
                cn.Execute(strsql)
                MsgBox("Account Update", MsgBoxStyle.Information, "Update")
                Call connection_close()

                txtedit_usercode.Text = "U-____"
                cmbedit_levelofaccess.Text = "Select Level of Access"
                txtedit_username.Text = ""
                txtedit_password.Text = ""
                txtedit_repassword.Text = ""
                cmbedit_searchusercode.Text = ""
                Call recon()

                'Call account_search(Me.cmbedit_searchusercode)
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Error Message:" + ex.ToString)
        End Try
    End Sub
    Private Sub btndelete_account_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete_account.Click
        Try
            Call connect()
            msg = MsgBox("Do you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete")
            If msg = vbYes Then
                strsql = "delete from useracct where usercode='" + cmbdelete_searchaccount.Text + "'"
                cn.Execute(strsql)
                MsgBox("Record Deleted", MsgBoxStyle.Information, "Delete")
                cmbdelete_searchaccount.Text = ""
                lbldelete_usercode.Text = "(Usercode)"
                lbldelete_levelofaccess.Text = "(Level of Access)"
                lbldelete_password.Text = "(Password)"
                lbldelete_username.Text = "(Username)"
            Else
                Exit Sub
            End If
            Call connection_close()
            Call recon()
        Catch ex As Exception
            MsgBox("Error Message:" + ex.ToString)
        End Try
    End Sub
    Private Sub cmbdelete_searchaccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdelete_searchaccount.SelectedIndexChanged
        Try
            Call connect()
            strsql = "select * from useracct where usercode='" + cmbdelete_searchaccount.Text + "'"
            rs.Open(strsql, cn)
            If rs.EOF = False Then
                lbldelete_levelofaccess.Text = rs.Fields("Access").Value
                lbldelete_password.Text = "**********"
                lbldelete_usercode.Text = rs.Fields("Usercode").Value
                lbldelete_username.Text = rs.Fields("Username").Value
            End If
            Call connection_close()
        Catch ex As Exception
            MsgBox("Error Message:" + ex.ToString)
        End Try
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabControl1.SelectedIndex = 4
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabControl1.SelectedIndex = 3
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmlogin.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            msg = MsgBox("Do you want to add this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Save")
            If msg = vbYes Then
                Call connect()
                strsql = "insert into dinfo([sname],[fname],[mname],[bday],[age]) values('" + txtsurname.Text + "','" + txtfirstname.Text + "','" + txtmi.Text + "','" + dtbirthday.Text + "','" + lblbdayage.Text + "')"
                cn.Execute(strsql)
                MsgBox("Record Save", MsgBoxStyle.Information, "Save")
                txtsurname.Text = ""
                txtfirstname.Text = ""
                txtmi.Text = ""
                dtbirthday.Value = Now.Date
                rbfemale.Checked = False
                rbmale.Checked = False
                lblbdayage.Text = "(Age)"
                Call connection_close()
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Error Message:" + ex.ToString)
        End Try
    End Sub

    Private Sub txtrecruiter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrecruiter.TextChanged
        Try
            Call connect()
            Dim dt As New DataTable
            Dim oleb As New OleDb.OleDbDataAdapter
            strsql = "select * from sinfo where sname +' '+ fname  LIKE '%" + txtrecruiter.Text + "%' or fname +' '+ sname  LIKE '%" + txtrecruiter.Text + "%'"
            rs.Open(strsql, cn)
            oleb.Fill(dt, rs)
            Call connection_close()
            dgrecruiter.DataSource = dt
        Catch ex As Exception
            MsgBox("Error Message:" + ex.ToString)
        End Try
        dgrecruiter.ClearSelection()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabControl1.SelectedIndex = 5
    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabControl1.SelectedIndex = 5
    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        'TabControl1.SelectedIndex = 0
        Dim x As New frmregdonor
        x.ShowDialog()
        'frmregdonor.Show()
    End Sub

    Private Sub ToolStripButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton15.Click
        'TabControl1.SelectedIndex = 1
        Dim x As New frmrecording
        x.ShowDialog()
        'frmrecording.Show()
    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        'TabControl1.SelectedIndex = 2
        Dim x As New frmchangecredit
        x.ShowDialog()
        'frmchangecredit.Show()
    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click
        'TabControl1.SelectedIndex = 3
        Dim x As New frmreception
        x.ShowDialog()
        'frmreception.Show()
    End Sub

    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click
        'TabControl1.SelectedIndex = 4
        frmnavigation.Show()
    End Sub

    Private Sub ToolStripButton9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        'TabControl1.SelectedIndex = 5
        Dim x As New Form
        frmaccount_manager.ShowDialog()
        'frmaccount_manager.Show()
    End Sub

    Private Sub RegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' TabControl1.SelectedIndex = 0
        frmregdonor.Show()

    End Sub

    Private Sub RecordingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TabControl1.SelectedIndex = 1
        frmrecording.Show()
    End Sub

    Private Sub ChangeCreditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TabControl1.SelectedIndex = 2
        frmchangecredit.Show()
    End Sub

    Private Sub InformationAndReceptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TabControl1.SelectedIndex = 3
        frmreception.Show()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TabControl1.SelectedIndex = 4
        frmnavigation.Show()
    End Sub

    Private Sub AccountManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TabControl1.SelectedIndex = 5
        frmaccount_manager.Show()
    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        frmlogin.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        msg = MsgBox("Do you want to exit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Exit")
        If msg = vbYes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'Clock2.UtcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now)
        'Clock2.UtcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(serverDate)
        'Clock2.UtcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(ts)
        'ts = New TimeSpan(0, serverDate.Hour - DateTime.UtcNow.Hour, serverDate.Minute - DateTime.UtcNow.Minute, serverDate.Second - DateTime.UtcNow.Second)
        Clock2.UtcOffset = ts
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmlogin.Show()
        Me.Close()
    End Sub


End Class


