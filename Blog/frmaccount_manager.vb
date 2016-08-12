Public Class frmaccount_manager
    Dim _status As String

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
            cn.Execute("insert into useracct([usercode],[username],[password],[access],[status]) values('" + msk_usercode.Text + "','" + txtsave_username.Text + "','" + txtsave_password.Text + "','" + cmbsave_level.Text + "','1')")
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
                If rs.Fields("status").Value = 1 Then
                    cmbStatus.Text = "ACTIVE"
                Else
                    cmbStatus.Text = "IN-ACTIVE"
                End If
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
                strsql = "update useracct set usercode='" + txtedit_usercode.Text + "',username='" + txtedit_username.Text + "',access='" + cmbedit_levelofaccess.Text + "',password='" + txtedit_password.Text + "',status='" + _status + "' where usercode='" + cmbedit_searchusercode.Text + "'"
                cn.Execute(strsql)
                MsgBox("Account Update", MsgBoxStyle.Information, "Update")
                Call connection_close()

                txtedit_usercode.Text = "U-____"
                cmbedit_levelofaccess.Text = "Select Level of Access"
                txtedit_username.Text = ""
                txtedit_password.Text = ""
                txtedit_repassword.Text = ""
                cmbedit_searchusercode.Text = ""
                cmbStatus.Text = ""
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
    Private Sub frmaccount_manager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call account_search(Me.cmbedit_searchusercode)
        Call account_search(Me.cmbdelete_searchaccount)
    End Sub
    Public Sub recon()
        cmbedit_searchusercode.Items.Clear()
        cmbdelete_searchaccount.Items.Clear()
        Call account_search(Me.cmbedit_searchusercode)
        Call account_search(Me.cmbdelete_searchaccount)
    End Sub


    Private Sub cmbStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStatus.SelectedIndexChanged
        'Russel 1-8-2014
        'Set status assignment
        If cmbStatus.Text = "ACTIVE" Then
            _status = "1"
        Else
            _status = "0"
        End If

    End Sub
End Class
