Public Class frmchangecredit


    Private Sub frmchangecredit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ca As New DataTable
        Dim custDA As New OleDb.OleDbDataAdapter

        Call connect()
        rs.Open("select * from Sinfo where Sname like '%" & TextBox1.Text & "%' or Fname like '%" & TextBox1.Text & "%' ", cn)
        custDA.Fill(ca, rs)
        rs.Close()
        cn.Close()
        dginfo.DataSource = ca

        Dim ca1 As New DataTable
        Dim custDA1 As New OleDb.OleDbDataAdapter

        Call connect()
        rs.Open("select * from Dinfo where Sname like '%" & txtname.Text & "%' or Fname like '%" & txtname.Text & "%' ", cn)

        custDA1.Fill(ca1, rs)
        rs.Close()
        cn.Close()
        DataGridView1.DataSource = ca1
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim ca As New DataTable
        Dim custDA As New OleDb.OleDbDataAdapter

        Call connect()
        rs.Open("select * from Sinfo where Sname +' '+ fname like '%" & TextBox1.Text & "%' or Fname +' '+ sname like '%" & TextBox1.Text & "%' ", cn)

        custDA.Fill(ca, rs)
        rs.Close()
        cn.Close()
        dginfo.DataSource = ca
    End Sub

    Private Sub dginfo_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        If Trim(TextBox6.Text = "") Then
            MsgBox("Please enter donor name", MsgBoxStyle.Critical, "Warning Message")
            Exit Sub
        ElseIf Trim(TextBox7.Text = "") Then
            MsgBox("Please enter donor name", MsgBoxStyle.Critical, "Warning Message")
            Exit Sub
        End If

        If Trim(TextBox8.Text = "") Then
            MsgBox("Please enter recruiter name", MsgBoxStyle.Critical, "Warning Message")
            Exit Sub
        ElseIf Trim(TextBox9.Text = "") Then
            MsgBox("Please enter recruiter name", MsgBoxStyle.Critical, "Warning Message")
            Exit Sub
        End If

        If txtstatus.Text = "Qualified" Then
            txtpts.Text = Val(txtpts.Text) - 1
            txtpts1.Text = Val(txtpts1.Text) + 1
        End If

        Call connect()
        With rs
            .Open("select * from Dinfo where dcode='" + TextBox6.Text + "'", cn, 2, 2)
            .Fields("studno").Value = TextBox8.Text
            .Fields("studname").Value = TextBox9.Text
            .Fields("rtype").Value = TextBox10.Text
            .Update()
            .Close()
        End With

        With rs
            .Open("select * from sinfo where studno='" + TextBox8.Text + "'", cn, 2, 2)
            .Fields("pts").Value = txtpts1.Text
            .Update()
            .Close()
        End With

        With rs
            .Open("select * from sinfo where studno='" + txtstudno.Text + "'", cn, 2, 2)
            .Fields("pts").Value = txtpts.Text
            .Update()
            .Close()
        End With


        With rs
            .Open("select * from atrail", cn, 2, 2)
            .AddNew()
            .Fields("Usercode").Value = _USERCODE
            .Fields("Act1").Value = "Change Credit"
            .Fields("Func").Value = Me.Text & " " & TextBox7.Text & " " & "to" & " " & TextBox9.Text
            .Fields("dte").Value = Now
            .Update()
            .Close()
        End With

        MsgBox("Change credit has been saved", MsgBoxStyle.Information, "Save")
        frmreception.Enabled = True
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""

        cn.Close()
        Me.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        frmreception.ComboBox1.Text = ""
        Me.Close()
    End Sub

    Private Sub txtname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        Dim ca As New DataTable
        Dim dgTest As New DataSet
        Dim custDA As New OleDb.OleDbDataAdapter

        Call connect()
        rs.Open("select * from Dinfo where Sname +' '+ fname  like '%" & txtname.Text & "%' or Fname +' '+ sname like '%" & txtname.Text & "%' ", cn)

        custDA.Fill(ca, rs)
        rs.Close()
        cn.Close()
        DataGridView1.DataSource = ca
    End Sub
    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        On Error Resume Next
        TextBox6.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox7.Text = DataGridView1.CurrentRow.Cells(1).Value & " " & DataGridView1.CurrentRow.Cells(2).Value & " " & DataGridView1.CurrentRow.Cells(3).Value
        txtstudno.Text = DataGridView1.CurrentRow.Cells(10).Value
        txtstatus.Text = DataGridView1.CurrentRow.Cells(8).Value

        Call connect()
        With rs
            .Open("select * from sinfo where studno='" + txtstudno.Text + "'", cn)
            If .EOF = False Then
                txtpts.Text = .Fields("pts").Value()
            End If
        End With
        cn.Close()
    End Sub

    Private Sub dginfo_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dginfo.Click
        On Error Resume Next
        TextBox8.Text = dginfo.CurrentRow.Cells(0).Value
        TextBox9.Text = dginfo.CurrentRow.Cells(1).Value & " " & dginfo.CurrentRow.Cells(2).Value & " " & dginfo.CurrentRow.Cells(3).Value
        txtpts1.Text = dginfo.CurrentRow.Cells(8).Value
        TextBox10.Text = dginfo.CurrentRow.Cells(7).Value
    End Sub
End Class