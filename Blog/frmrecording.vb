
Public Class frmrecording
    Dim objX As New ADO_NET

    Dim dtBloodType As DataTable
    Dim dtStation As DataTable
    Dim dtRemarks As DataTable

  
    'Dim localStationID As Integer = 0
    'Dim localBloodType As String = ""
    'Dim localRemarksID As Integer = 0

    Private Sub frmrecording_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call initSetUp()

        Call fill()
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        Dim ca As New DataTable
        Dim dgTest As New DataSet
        Dim custDA As New OleDb.OleDbDataAdapter
        Call connect()
        rs.Open("select * from Dinfo where Sname like '%" & TextBox2.Text & "%' or Fname like '%" & TextBox2.Text & "%' ", cn)
        custDA.Fill(ca, rs)
        rs.Close()
        cn.Close()
        dginfo.DataSource = ca
        dginfo.SelectionMode = DataGridViewSelectionMode.CellSelect

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next

        If Trim(TextBox1.Text = "") Then
            MsgBox("Please enter recruiter name", MsgBoxStyle.Critical, "Warning Message")
            Exit Sub
        End If

        If Trim(TextBox2.Text = "") Then
            MsgBox("Please enter donor name", MsgBoxStyle.Critical, "Warning Message")
            Exit Sub
        End If

        If ComboBox1.Text = "" Then
            MsgBox("Please select a remark", MsgBoxStyle.Critical, "Warning Message")
            Exit Sub
        End If

        'If TextBox6.Text = "" Then
        '    MsgBox("Please select donor in Grid", MsgBoxStyle.Critical, "Warning Message")
        '    Exit Sub
        'End If

        'Dim cn As New ADODB.Connection
        'Dim rs As New ADODB.Recordset

        'cn.Open("Provider=SQLOLEDB;Data Source=SSI-IT2;Integrated Security=SSPI;Initial Catalog=Blog")

        Call connect()

        With rs
            .Open("select * from dinfo where dcode='" + TextBox5.Text + "'", cn, 2, 2)
            If .EOF = False Then
                If ComboBox1.Text = "Qualified" Then

                    If cmbBloodType.Text = "" Then
                        MsgBox("Please select blood type to save transaction", MsgBoxStyle.Exclamation, "B.L.O.G.E.R.S")
                        Exit Sub
                    Else
                        '.Fields("status").Value = "Qualified"
                        '.Fields("stno").Value = "D-Station 8"
                        .Fields("date").Value = Now.Date

                        'Inserting New fields that update the following
                        'Update Bloodtype
                        'Russel 1-14-2014
                        .Fields("Status").Value = ComboBox1.Text
                        .Fields("stno").Value = cmbStation.Text
                        .Fields("bloodType").Value = cmbBloodType.Text
                        .Fields("stationID").Value = lblStationID.Text
                        .Fields("remarksID").Value = lblRemarksID.Text
                        .Update()

                    End If


                ElseIf ComboBox1.Text = "Deferred" Then
                    '.Fields("status").Value = "Deferred"
                    '.Fields("stno").Value = "D-Station 8"
                    'Updated
                    'Russel 1-14-2014
                    .Fields("Status").Value = ComboBox1.Text
                    .Fields("stno").Value = cmbStation.Text
                    .Fields("bloodType").Value = cmbBloodType.Text
                    .Fields("stationID").Value = lblStationID.Text
                    .Fields("remarksID").Value = lblRemarksID.Text
                    .Fields("date").Value = Now.Date
                    .Update()
                Else
                    '.Fields("stno").Value = ComboBox1.Text
                    '.Fields("status").Value = ComboBox1.Text
                    .Fields("date").Value = Now.Date
                    'Updated
                    'Russel 1-14-2014
                    .Fields("Status").Value = ComboBox1.Text
                    .Fields("stno").Value = cmbStation.Text
                    .Fields("bloodType").Value = cmbBloodType.Text
                    .Fields("stationID").Value = lblStationID.Text
                    .Fields("remarksID").Value = lblRemarksID.Text
                    .Update()
                End If
                .Update()
                .Close()
            End If
        End With

        '      Call connection_close()


        'Dim rs1 As New ADODB.Recordset
        'Dim cn1 As New ADODB.Connection

        'cn1.Open("Provider=SQLOLEDB;Data Source=SSI-IT2;Integrated Security=SSPI;Initial Catalog=Blog")
        '       Call connect()

        With rs
            .Open("select * from sinfo where studno='" + TextBox1.Text + "'", cn, 2, 2)
            If ComboBox1.Text = "Qualified" Then
                .Fields("pts").Value = Val(TextBox4.Text) + 1
                .Update()
            ElseIf TextBox7.Text = "Qualified" And ComboBox1.Text <> "Qualified" Then
                .Fields("pts").Value = Val(TextBox4.Text) - 1
                .Update()
            End If
            .Close()
        End With
        Dim frmhome As New frmhome
        With rs
            .Open("select * from atrail", cn, 2, 2)
            .AddNew()
            .Fields("Usercode").Value = _USERCODE
            .Fields("Act1").Value = "Recording"
            .Fields("Func").Value = Me.Text & " " & ComboBox1.Text & " " & TextBox2.Text
            .Fields("dte").Value = FormatDateTime(_SERVERDATETIME, DateFormat.ShortDate)
            .Update()
            .Close()
        End With

        MsgBox("Recording successfull", MsgBoxStyle.Information, "Save")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = 0
        TextBox5.Text = ""
        'ComboBox1.Text = "Processing"

        Call connection_close()


        ' frmhome.Refresh()
        'dginfo.Rows.Clear()
        Call fill()
        ' Me.DinfoTableAdapter.Fill(Me.BlogDataSet5.dinfo)
        'dginfo.Refresh()
        'frmhome1.Show()
        'Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = 0
        TextBox5.Text = ""
        ComboBox1.Text = ""
        '  frmhome1.Show()
        Me.Close()
    End Sub


    Sub fill()
        Dim ca1 As New DataTable
        Dim custDA1 As New OleDb.OleDbDataAdapter

        Call connect()
        rs.Open("select * from Dinfo", cn)

        custDA1.Fill(ca1, rs)
        rs.Close()
        cn.Close()
        dginfo.DataSource = ca1
    End Sub



    Private Sub dginfo_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dginfo.Click
        On Error Resume Next

        dginfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        TextBox1.Text = dginfo.CurrentRow.Cells(9).Value
        TextBox2.Text = dginfo.CurrentRow.Cells(1).Value & " " & dginfo.CurrentRow.Cells(2).Value & " " & dginfo.CurrentRow.Cells(3).Value
        TextBox3.Text = dginfo.CurrentRow.Cells(10).Value
        TextBox5.Text = dginfo.CurrentRow.Cells(1).Value
        'ComboBox1.Text = dginfo.CurrentRow.Cells(8).Value
        TextBox7.Text = dginfo.CurrentRow.Cells(8).Value

        ' MsgBox(dginfo.CurrentRow.Cells(15).Value & " - " & dginfo.CurrentRow.Cells(16).Value)
        'Added Codes and Function
        'Russel 1-15-2014
        cmbBloodType.Text = showSelectedBloodType(dginfo.CurrentRow.Cells(14).Value)
        cmbStation.Text = showSelectedStation(dginfo.CurrentRow.Cells(15).Value)
        ComboBox1.Text = showSelectedRemarks(dginfo.CurrentRow.Cells(16).Value)

        lblBloodType.Text = showSelectedBloodType(dginfo.CurrentRow.Cells(14).Value)
        lblStationID.Text = dginfo.CurrentRow.Cells(15).Value
        lblRemarksID.Text = dginfo.CurrentRow.Cells(16).Value
        lblRecruiterName.Text = dginfo.CurrentRow.Cells(8).Value


        Call connect()

        With rs
            .Open("select * from sinfo where studno='" + TextBox1.Text + "'", cn)
            If .EOF = False Then
                TextBox4.Text = .Fields("pts").Value
                .Close()
            End If
        End With
        cn.Close()
    End Sub

    Private Sub ComboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.Click
        Call displayRemarks()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        lblRemarksID.Text = ComboBox1.SelectedIndex + 1

        If ComboBox1.Text = "Qualified" Then
            cmbBloodType.Text = "O"
            cmbBloodType.Enabled = True
            '           Call displayBloodType()
        Else
            cmbBloodType.Text = ""
            cmbBloodType.Enabled = False
        End If

    End Sub


    Public Sub displayBloodType()
        With cmbBloodType
            .DataSource = dtBloodType
            .DisplayMember = "bloodtype"
            .ValueMember = "bloodID"
        End With
    End Sub

    Public Sub displayRemarks()
        With ComboBox1
            .DataSource = dtRemarks
            .DisplayMember = "RemarksDescription"
            .ValueMember = "RemarksID"
        End With
    End Sub

    Public Sub displayStation()
        With cmbStation
            .DataSource = dtStation
            .DisplayMember = "StationDescription"
            .ValueMember = "StationID"
        End With
    End Sub

    Public Function showSelectedStation(ByVal value As String) As String
        Dim str As String = ""
        Dim dr() As DataRow = dtStation.Select("stationID = '" & value & "'")

        If dr.Count > 0 Then
            str = dr(0)("StationDescription")
        End If


        Return str
    End Function

    Public Function showSelectedRemarks(ByVal value As String) As String
        Dim str As String = ""
        Dim dr() As DataRow = dtRemarks.Select("remarksID = '" & value & "'")

        If dr.Count > 0 Then
            str = dr(0)("remarksDescription")
        End If


        Return str
    End Function

    Public Function showSelectedBloodType(ByVal value As String) As String
        Dim str As String = ""
        Dim dr() As DataRow = dtBloodType.Select("bloodtype = '" & value & "'")

        If dr.Count > 0 Then
            str = dr(0)("bloodType")
        End If


        Return str
    End Function

    Public Sub initSetUp()
        'Get Information from Blood Type Dataset
        dtBloodType = objX.getBloodType
        dtRemarks = objX.getRemarks
        dtStation = objX.getStation
    End Sub

    Private Sub cmbStation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStation.Click
        Call displayStation()
    End Sub

    Private Sub cmbBloodType_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBloodType.Click
        Call displayBloodType()
    End Sub



    Private Sub cmbStation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStation.SelectedIndexChanged
        lblStationID.Text = cmbStation.SelectedIndex + 1
    End Sub

  
    Private Sub frmrecording_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd

    End Sub
End Class
