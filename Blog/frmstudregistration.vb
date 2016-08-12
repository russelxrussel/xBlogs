Public Class frmstudregistration

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As New ADODB.Connection
        Dim rs As New ADODB.Recordset

        cn.Open("Provider=SQLOLEDB;Data Source=SSI-IT2;Integrated Security=SSPI;Initial Catalog=Blog")



        With rs
            .Open("select * from Sinfo where studno='" + msid.Text + "'", cn, 2, 2)
            If rs.EOF = False Then
                MsgBox("The record you try to enter is already exist please try another one", MsgBoxStyle.Critical, "Warning Message")
                Exit Sub
            Else
                .AddNew()
                .Fields("studno").Value = msid.Text
                .Fields("sname").Value = txtsurname.Text
                .Fields("fname").Value = txtfirstname.Text
                .Fields("mname").Value = txtmi.Text
                .Fields("ltype").Value = txtleveltype.Text
                .Fields("lcode").Value = txtlevelcode.Text
                .Fields("sec").Value = txtsection.Text
                .Fields("typ").Value = txttype.Text
                .Fields("pts").Value = 0
                .Update()
                .Close()
            End If
        End With
        MsgBox("New record of student has been saved", MsgBoxStyle.Information, "Save")
        msid.Text = ""
        txtsurname.Text = ""
        txtfirstname.Text = ""
        txtmi.Text = ""
        txttype.Text = ""
        txtleveltype.Text = ""
        txtlevelcode.Text = ""
        txtsection.Text = ""
    End Sub
End Class