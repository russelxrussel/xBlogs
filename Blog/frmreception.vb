Imports System.Data.SqlClient

Public Class frmreception

    Private Sub frmreception_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim ca As New DataTable
        Dim custDA As New OleDb.OleDbDataAdapter

        Call connect()
        rs.Open("select * from dinfo", cn)

        custDA.Fill(ca, rs)
        rs.Close()
        cn.Close()
        dginfo.DataSource = ca

        Call connect()
        rs.Open("select distinct[studname] from dinfo order by [studname] ASC", cn)
        While rs.EOF = False
            ComboBox1.Items.Add(rs.Fields("studname").Value)
            rs.MoveNext()
        End While
        rs.Close()
        cn.Close()

    End Sub


    Private Sub txtsearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        Dim ca As New DataTable

        Dim custDA As New OleDb.OleDbDataAdapter

        Call connect()

        rs.Open("select * from dinfo where Sname like '%" & txtsearch.Text & "%' or Fname like '%" & txtsearch.Text & "%' ", cn)

        custDA.Fill(ca, rs)
        rs.Close()
        cn.Close()
        dginfo.DataSource = ca

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Call connect()

        With rs
            .Open("Select Distinct studname from dinfo", cn)
            While rs.EOF = False
                ComboBox1.Items.Add(.Fields("studname").Value)
                .MoveNext()
            End While
        End With

        rs.Close()
        cn.Close()

    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim ca As New DataTable
        Dim custDA As New OleDb.OleDbDataAdapter

        Call connect()
        rs.Open("select * from dinfo where Studname like '%" & ComboBox1.Text & "%'order by Status ASC ", cn)

        custDA.Fill(ca, rs)
        rs.Close()
        cn.Close()
        dginfo.DataSource = ca
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()

        Dim ca As New DataTable
        Dim custDA As New OleDb.OleDbDataAdapter

        Call connect()
        rs.Open("select * from dinfo where Studname='" & ComboBox1.Text & "' and remarksID=4 ", cn)

        'rs.Open("select * from dinfo where Studname='" & ComboBox1.Text & "' and Status='Qualified'", cn)
        While rs.EOF = False
            ListBox4.Items.Add(rs.Fields("status").Value)
            rs.MoveNext()
        End While
        rs.Close()
        TextBox6.Text = ListBox4.Items.Count()
 
        ' rs.Open("select * from dinfo where Studname='" & ComboBox1.Text & "' and Status='Pre Reg' order by status ASC", cn)
        rs.Open("select * from dinfo where Studname='" & ComboBox1.Text & "' and remarksID=1 ", cn)
        While rs.EOF = False
            ListBox1.Items.Add(rs.Fields("status").Value)
            rs.MoveNext()
        End While
        rs.Close()
        TextBox3.Text = ListBox1.Items.Count()


        'rs.Open("select * from dinfo where Studname='" & ComboBox1.Text & "' and (Status='Processing' or (Status='D - Station 4' or status='D - Station 5' or status='D - Station 6' or status='D - Station 7')) order by status ASC", cn)
        rs.Open("select * from dinfo where Studname='" & ComboBox1.Text & "' and remarksID=2 ", cn)

        While (rs.EOF = False)
            ListBox2.Items.Add(rs.Fields("status").Value)
            rs.MoveNext()
        End While
        rs.Close()
        TextBox4.Text = ListBox2.Items.Count()


        rs.Open("select * from dinfo where Studname='" & ComboBox1.Text & "' and remarksID=3 ", cn)
        'rs.Open("select * from dinfo where Studname='" & ComboBox1.Text & "' and Status='Deferred' order by status ASC", cn)
        While rs.EOF = False
            ListBox3.Items.Add(rs.Fields("status").Value)
            rs.MoveNext()
        End While
        rs.Close()
        TextBox5.Text = ListBox3.Items.Count()

        If ComboBox1.Text = "SSI-WI" Then
            rs.Open("select * from dinfo where rtype='NA'", cn)
            While rs.EOF = False
                ListBox5.Items.Add(rs.Fields("status").Value)
                rs.MoveNext()
            End While
            rs.Close()
            TextBox7.Text = ListBox5.Items.Count()
        Else
            TextBox7.Text = ListBox5.Items.Count()
        End If
        cn.Close()

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim ca As New DataTable
        Dim custDA As New OleDb.OleDbDataAdapter

        Call connect()
        If ComboBox1.Text = "SSI-WI" Then
            rs.Open("select * from dinfo where rtype='NA' order by Status ASC ", cn)
            custDA.Fill(ca, rs)
            rs.Close()
        Else
            rs.Open("select * from dinfo where Studname like '%" & ComboBox1.Text & "%'order by Status ASC ", cn)
            custDA.Fill(ca, rs)
            rs.Close()
        End If

        'rs.Open("select * from dinfo where Studname like '%" & ComboBox1.Text & "%'order by Status ASC ", cn)
        'custDA.Fill(ca, rs)
        'rs.Close()

        cn.Close()
        dginfo.DataSource = ca

    End Sub

    Private Sub dginfo_Click1(ByVal sender As Object, ByVal e As System.EventArgs)

        On Error Resume Next
        TextBox1.Text = dginfo.CurrentRow.Cells(0).Value
        TextBox2.Text = dginfo.CurrentRow.Cells(1).Value & " " & dginfo.CurrentRow.Cells(2).Value & " " & dginfo.CurrentRow.Cells(3).Value

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim ca As New DataTable
        Dim custDA As New OleDb.OleDbDataAdapter

        Call connect()
        rs.Open("select * from dinfo where Studname like '%" & ComboBox1.Text & "%'order by [sname] ASC ", cn)

        custDA.Fill(ca, rs)
        rs.Close()
        cn.Close()
        dginfo.DataSource = ca

        Call fill_textbox()

    End Sub

    Sub fill_textbox()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()

        Dim ca As New DataTable
        Dim custDA As New OleDb.OleDbDataAdapter

        Call connect()

        'rs.Open("select * from dinfo where Studname='" & ComboBox1.Text & "' and Status='Qualified'", cn)
        rs.Open("select * from dinfo where Studname='" & ComboBox1.Text & "' and remarksID=4 ", cn)
        While rs.EOF = False
            ListBox4.Items.Add(rs.Fields("status").Value)
            rs.MoveNext()
        End While
        rs.Close()
        TextBox6.Text = ListBox4.Items.Count()

        ' rs.Open("select * from dinfo where Studname='" & ComboBox1.Text & "' and Status='Pre Reg' order by status ASC", cn)
        rs.Open("select * from dinfo where Studname='" & ComboBox1.Text & "' and remarksID=1 order by status ASC", cn)
        While rs.EOF = False
            ListBox1.Items.Add(rs.Fields("status").Value)
            rs.MoveNext()
        End While
        rs.Close()
        TextBox3.Text = ListBox1.Items.Count()

        '        rs.Open("select * from dinfo where Studname='" & ComboBox1.Text & "' and (Status='Processing' or (Status='D - Station 4' or status='D - Station 5' or status='D - Station 6' or status='D - Station 7')) order by status ASC", cn)
        rs.Open("select * from dinfo where Studname='" & ComboBox1.Text & "' and remarksID=2 ", cn)
        While (rs.EOF = False)
            ListBox2.Items.Add(rs.Fields("status").Value)
            rs.MoveNext()
        End While
        rs.Close()
        TextBox4.Text = ListBox2.Items.Count()

       
        '  rs.Open("select * from dinfo where Studname='" & ComboBox1.Text & "' and Status='Deferred' order by status ASC", cn)
        rs.Open("select * from dinfo where Studname='" & ComboBox1.Text & "' and remarksID=3 ", cn)
        While rs.EOF = False
            ListBox3.Items.Add(rs.Fields("status").Value)
            rs.MoveNext()
        End While
        rs.Close()
        TextBox5.Text = ListBox3.Items.Count()


        'ORIGINAL CODE
        If ComboBox1.Text = "SSI-WI" Then
            rs.Open("select * from dinfo where rtype='NA'", cn)
            While rs.EOF = False
                ListBox5.Items.Add(rs.Fields("status").Value)
                rs.MoveNext()
            End While
            rs.Close()
            TextBox7.Text = ListBox5.Items.Count()
        Else
            TextBox7.Text = ListBox5.Items.Count()
        End If
        cn.Close()
    End Sub

 
    Private Sub frmreception_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ca As New DataTable
        Dim custDA As New OleDb.OleDbDataAdapter

        Call connect()
        rs.Open("select * from dinfo", cn)

        custDA.Fill(ca, rs)
        rs.Close()
        cn.Close()
        dginfo.DataSource = ca

        Call connect()
        rs.Open("select distinct[studname] from dinfo order by [studname] ASC", cn)
        While rs.EOF = False
            ComboBox1.Items.Add(rs.Fields("studname").Value)
            rs.MoveNext()
        End While
        rs.Close()
        cn.Close()
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim ca As New DataTable
        Dim custDA As New OleDb.OleDbDataAdapter

        Call connect()
        rs.Open("select * from dinfo where Studname like '%" & ComboBox1.Text & "%'order by [sname] ASC ", cn)

        custDA.Fill(ca, rs)
        rs.Close()
        cn.Close()
        dginfo.DataSource = ca

        Call fill_textbox()
    End Sub

    Private Sub ComboBox1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        Dim ca As New DataTable
        Dim custDA As New OleDb.OleDbDataAdapter

        Call connect()
        rs.Open("select * from dinfo where Studname like '%" & ComboBox1.Text & "%'order by Status ASC ", cn)

        custDA.Fill(ca, rs)
        rs.Close()
        cn.Close()
        dginfo.DataSource = ca
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim ca As New DataTable
        Dim custDA As New OleDb.OleDbDataAdapter

        Call connect()
        '1-20-2014
        'ORIGINAL CODE CONDITIONAL STATEMENT

        If ComboBox1.Text = "SSI-WI" Then
            rs.Open("select * from dinfo where rtype='NA' order by Status ASC ", cn)
            custDA.Fill(ca, rs)
            rs.Close()
        Else
            rs.Open("select * from dinfo where Studname like '%" & ComboBox1.Text & "%'order by Status ASC ", cn)
            custDA.Fill(ca, rs)
            rs.Close()
        End If

        'rs.Open("select * from dinfo where Studname like '%" & ComboBox1.Text & "%'order by Status ASC ", cn)
        'custDA.Fill(ca, rs)
        'rs.Close()

        cn.Close()
        dginfo.DataSource = ca
    End Sub


End Class

