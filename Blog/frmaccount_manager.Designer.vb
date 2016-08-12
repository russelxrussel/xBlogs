<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaccount_manager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmaccount_manager))
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.msk_usercode = New System.Windows.Forms.MaskedTextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.cmbsave_level = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtsave_re = New System.Windows.Forms.TextBox
        Me.txtsave_password = New System.Windows.Forms.TextBox
        Me.txtsave_username = New System.Windows.Forms.TextBox
        Me.btnsave_account = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage8 = New System.Windows.Forms.TabPage
        Me.cmbedit_searchusercode = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbStatus = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtedit_usercode = New System.Windows.Forms.MaskedTextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.cmbedit_levelofaccess = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.txtedit_repassword = New System.Windows.Forms.TextBox
        Me.txtedit_password = New System.Windows.Forms.TextBox
        Me.txtedit_username = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.btnedit_account = New System.Windows.Forms.Button
        Me.TabPage9 = New System.Windows.Forms.TabPage
        Me.cmbdelete_searchaccount = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbldelete_usercode = New System.Windows.Forms.Label
        Me.lbldelete_levelofaccess = New System.Windows.Forms.Label
        Me.lbldelete_password = New System.Windows.Forms.Label
        Me.lbldelete_username = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.btndelete_account = New System.Windows.Forms.Button
        Me.TabControl2.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Controls.Add(Me.TabPage8)
        Me.TabControl2.Controls.Add(Me.TabPage9)
        Me.TabControl2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TabControl2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(2, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(379, 275)
        Me.TabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl2.TabIndex = 9
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.msk_usercode)
        Me.TabPage7.Controls.Add(Me.Label31)
        Me.TabPage7.Controls.Add(Me.Label27)
        Me.TabPage7.Controls.Add(Me.cmbsave_level)
        Me.TabPage7.Controls.Add(Me.Label18)
        Me.TabPage7.Controls.Add(Me.Label17)
        Me.TabPage7.Controls.Add(Me.Label16)
        Me.TabPage7.Controls.Add(Me.txtsave_re)
        Me.TabPage7.Controls.Add(Me.txtsave_password)
        Me.TabPage7.Controls.Add(Me.txtsave_username)
        Me.TabPage7.Controls.Add(Me.btnsave_account)
        Me.TabPage7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(371, 249)
        Me.TabPage7.TabIndex = 0
        Me.TabPage7.Text = "Add New"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'msk_usercode
        '
        Me.msk_usercode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msk_usercode.Location = New System.Drawing.Point(133, 42)
        Me.msk_usercode.Mask = "U-####"
        Me.msk_usercode.Name = "msk_usercode"
        Me.msk_usercode.Size = New System.Drawing.Size(50, 21)
        Me.msk_usercode.TabIndex = 17
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(9, 51)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(99, 13)
        Me.Label31.TabIndex = 16
        Me.Label31.Text = "Enter Usercode:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(9, 77)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(100, 13)
        Me.Label27.TabIndex = 15
        Me.Label27.Text = "Level of Access:"
        '
        'cmbsave_level
        '
        Me.cmbsave_level.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsave_level.FormattingEnabled = True
        Me.cmbsave_level.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3", "Level 4"})
        Me.cmbsave_level.Location = New System.Drawing.Point(133, 69)
        Me.cmbsave_level.Name = "cmbsave_level"
        Me.cmbsave_level.Size = New System.Drawing.Size(224, 21)
        Me.cmbsave_level.TabIndex = 1
        Me.cmbsave_level.Text = "Select Level of Access"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(9, 158)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(120, 13)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Re-Enter Password:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 131)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 13)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Enter Password:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(9, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 13)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Enter Username:"
        '
        'txtsave_re
        '
        Me.txtsave_re.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsave_re.Location = New System.Drawing.Point(133, 150)
        Me.txtsave_re.Name = "txtsave_re"
        Me.txtsave_re.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtsave_re.Size = New System.Drawing.Size(224, 21)
        Me.txtsave_re.TabIndex = 4
        '
        'txtsave_password
        '
        Me.txtsave_password.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsave_password.Location = New System.Drawing.Point(133, 123)
        Me.txtsave_password.Name = "txtsave_password"
        Me.txtsave_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtsave_password.Size = New System.Drawing.Size(224, 21)
        Me.txtsave_password.TabIndex = 3
        '
        'txtsave_username
        '
        Me.txtsave_username.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsave_username.Location = New System.Drawing.Point(133, 96)
        Me.txtsave_username.Name = "txtsave_username"
        Me.txtsave_username.Size = New System.Drawing.Size(224, 21)
        Me.txtsave_username.TabIndex = 2
        '
        'btnsave_account
        '
        Me.btnsave_account.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave_account.ImageKey = "save.ico"
        Me.btnsave_account.ImageList = Me.ImageList1
        Me.btnsave_account.Location = New System.Drawing.Point(318, 179)
        Me.btnsave_account.Name = "btnsave_account"
        Me.btnsave_account.Size = New System.Drawing.Size(39, 37)
        Me.btnsave_account.TabIndex = 5
        Me.btnsave_account.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Information.ico")
        Me.ImageList1.Images.SetKeyName(1, "Delete.ico")
        Me.ImageList1.Images.SetKeyName(2, "Log-Out.ico")
        Me.ImageList1.Images.SetKeyName(3, "User.ico")
        Me.ImageList1.Images.SetKeyName(4, "Add.ico")
        Me.ImageList1.Images.SetKeyName(5, "Add-icon.png")
        Me.ImageList1.Images.SetKeyName(6, "Delete-icon.png")
        Me.ImageList1.Images.SetKeyName(7, "Information-icon.png")
        Me.ImageList1.Images.SetKeyName(8, "Log-Out-icon.png")
        Me.ImageList1.Images.SetKeyName(9, "User-icon.png")
        Me.ImageList1.Images.SetKeyName(10, "save.ico")
        Me.ImageList1.Images.SetKeyName(11, "Edit.ico")
        Me.ImageList1.Images.SetKeyName(12, "User-icon.png")
        Me.ImageList1.Images.SetKeyName(13, "Add-icon.png")
        Me.ImageList1.Images.SetKeyName(14, "Delete-icon.png")
        Me.ImageList1.Images.SetKeyName(15, "Edit-icon.png")
        Me.ImageList1.Images.SetKeyName(16, "Information-icon.png")
        Me.ImageList1.Images.SetKeyName(17, "Print-icon.png")
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.cmbedit_searchusercode)
        Me.TabPage8.Controls.Add(Me.GroupBox1)
        Me.TabPage8.Controls.Add(Me.Label33)
        Me.TabPage8.Controls.Add(Me.btnedit_account)
        Me.TabPage8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(371, 249)
        Me.TabPage8.TabIndex = 1
        Me.TabPage8.Text = "Update"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'cmbedit_searchusercode
        '
        Me.cmbedit_searchusercode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbedit_searchusercode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbedit_searchusercode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbedit_searchusercode.FormattingEnabled = True
        Me.cmbedit_searchusercode.Location = New System.Drawing.Point(163, 5)
        Me.cmbedit_searchusercode.Name = "cmbedit_searchusercode"
        Me.cmbedit_searchusercode.Size = New System.Drawing.Size(121, 21)
        Me.cmbedit_searchusercode.TabIndex = 28
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbStatus)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtedit_usercode)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.cmbedit_levelofaccess)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.txtedit_repassword)
        Me.GroupBox1.Controls.Add(Me.txtedit_password)
        Me.GroupBox1.Controls.Add(Me.txtedit_username)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 174)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Information"
        '
        'cmbStatus
        '
        Me.cmbStatus.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"ACTIVE", "IN-ACTIVE"})
        Me.cmbStatus.Location = New System.Drawing.Point(130, 68)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(224, 21)
        Me.cmbStatus.TabIndex = 39
        Me.cmbStatus.Text = "Select Level of Access"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Account Status :"
        '
        'txtedit_usercode
        '
        Me.txtedit_usercode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtedit_usercode.Location = New System.Drawing.Point(130, 17)
        Me.txtedit_usercode.Mask = "U-####"
        Me.txtedit_usercode.Name = "txtedit_usercode"
        Me.txtedit_usercode.Size = New System.Drawing.Size(50, 21)
        Me.txtedit_usercode.TabIndex = 37
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 26)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(99, 13)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Enter Usercode:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 52)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 13)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "Level of Access:"
        '
        'cmbedit_levelofaccess
        '
        Me.cmbedit_levelofaccess.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbedit_levelofaccess.FormattingEnabled = True
        Me.cmbedit_levelofaccess.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3", "Level 4"})
        Me.cmbedit_levelofaccess.Location = New System.Drawing.Point(130, 44)
        Me.cmbedit_levelofaccess.Name = "cmbedit_levelofaccess"
        Me.cmbedit_levelofaccess.Size = New System.Drawing.Size(224, 21)
        Me.cmbedit_levelofaccess.TabIndex = 28
        Me.cmbedit_levelofaccess.Text = "Select Level of Access"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 148)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(120, 13)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "Re-Enter Password:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(6, 123)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(100, 13)
        Me.Label28.TabIndex = 33
        Me.Label28.Text = "Enter Password:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(6, 96)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(104, 13)
        Me.Label32.TabIndex = 32
        Me.Label32.Text = "Enter Username:"
        '
        'txtedit_repassword
        '
        Me.txtedit_repassword.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtedit_repassword.Location = New System.Drawing.Point(130, 142)
        Me.txtedit_repassword.Name = "txtedit_repassword"
        Me.txtedit_repassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtedit_repassword.Size = New System.Drawing.Size(224, 21)
        Me.txtedit_repassword.TabIndex = 31
        '
        'txtedit_password
        '
        Me.txtedit_password.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtedit_password.Location = New System.Drawing.Point(130, 115)
        Me.txtedit_password.Name = "txtedit_password"
        Me.txtedit_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtedit_password.Size = New System.Drawing.Size(224, 21)
        Me.txtedit_password.TabIndex = 30
        '
        'txtedit_username
        '
        Me.txtedit_username.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtedit_username.Location = New System.Drawing.Point(130, 88)
        Me.txtedit_username.Name = "txtedit_username"
        Me.txtedit_username.Size = New System.Drawing.Size(224, 21)
        Me.txtedit_username.TabIndex = 29
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(60, 13)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(104, 13)
        Me.Label33.TabIndex = 29
        Me.Label33.Text = "Select Usercode:"
        '
        'btnedit_account
        '
        Me.btnedit_account.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit_account.ImageKey = "Edit.ico"
        Me.btnedit_account.ImageList = Me.ImageList1
        Me.btnedit_account.Location = New System.Drawing.Point(326, 209)
        Me.btnedit_account.Name = "btnedit_account"
        Me.btnedit_account.Size = New System.Drawing.Size(34, 34)
        Me.btnedit_account.TabIndex = 16
        Me.btnedit_account.UseVisualStyleBackColor = True
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.cmbdelete_searchaccount)
        Me.TabPage9.Controls.Add(Me.GroupBox2)
        Me.TabPage9.Controls.Add(Me.Label29)
        Me.TabPage9.Controls.Add(Me.btndelete_account)
        Me.TabPage9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(371, 249)
        Me.TabPage9.TabIndex = 2
        Me.TabPage9.Text = "Delete"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'cmbdelete_searchaccount
        '
        Me.cmbdelete_searchaccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbdelete_searchaccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbdelete_searchaccount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdelete_searchaccount.FormattingEnabled = True
        Me.cmbdelete_searchaccount.Location = New System.Drawing.Point(165, 10)
        Me.cmbdelete_searchaccount.Name = "cmbdelete_searchaccount"
        Me.cmbdelete_searchaccount.Size = New System.Drawing.Size(121, 21)
        Me.cmbdelete_searchaccount.TabIndex = 31
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbldelete_usercode)
        Me.GroupBox2.Controls.Add(Me.lbldelete_levelofaccess)
        Me.GroupBox2.Controls.Add(Me.lbldelete_password)
        Me.GroupBox2.Controls.Add(Me.lbldelete_username)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 155)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User Information"
        '
        'lbldelete_usercode
        '
        Me.lbldelete_usercode.AutoSize = True
        Me.lbldelete_usercode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldelete_usercode.Location = New System.Drawing.Point(111, 37)
        Me.lbldelete_usercode.Name = "lbldelete_usercode"
        Me.lbldelete_usercode.Size = New System.Drawing.Size(70, 13)
        Me.lbldelete_usercode.TabIndex = 41
        Me.lbldelete_usercode.Text = "(Usercode)"
        '
        'lbldelete_levelofaccess
        '
        Me.lbldelete_levelofaccess.AutoSize = True
        Me.lbldelete_levelofaccess.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldelete_levelofaccess.Location = New System.Drawing.Point(111, 63)
        Me.lbldelete_levelofaccess.Name = "lbldelete_levelofaccess"
        Me.lbldelete_levelofaccess.Size = New System.Drawing.Size(105, 13)
        Me.lbldelete_levelofaccess.TabIndex = 40
        Me.lbldelete_levelofaccess.Text = "(Level of Access)"
        '
        'lbldelete_password
        '
        Me.lbldelete_password.AutoSize = True
        Me.lbldelete_password.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldelete_password.Location = New System.Drawing.Point(111, 117)
        Me.lbldelete_password.Name = "lbldelete_password"
        Me.lbldelete_password.Size = New System.Drawing.Size(71, 13)
        Me.lbldelete_password.TabIndex = 38
        Me.lbldelete_password.Text = "(Password)"
        '
        'lbldelete_username
        '
        Me.lbldelete_username.AutoSize = True
        Me.lbldelete_username.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldelete_username.Location = New System.Drawing.Point(111, 90)
        Me.lbldelete_username.Name = "lbldelete_username"
        Me.lbldelete_username.Size = New System.Drawing.Size(75, 13)
        Me.lbldelete_username.TabIndex = 37
        Me.lbldelete_username.Text = "(Username)"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 37)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(99, 13)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "Enter Usercode:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(6, 63)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(100, 13)
        Me.Label23.TabIndex = 35
        Me.Label23.Text = "Level of Access:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(6, 117)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(100, 13)
        Me.Label25.TabIndex = 33
        Me.Label25.Text = "Enter Password:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(6, 90)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(104, 13)
        Me.Label26.TabIndex = 32
        Me.Label26.Text = "Enter Username:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(62, 18)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(104, 13)
        Me.Label29.TabIndex = 32
        Me.Label29.Text = "Select Usercode:"
        '
        'btndelete_account
        '
        Me.btndelete_account.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete_account.ImageKey = "Delete-icon.png"
        Me.btndelete_account.ImageList = Me.ImageList1
        Me.btndelete_account.Location = New System.Drawing.Point(326, 200)
        Me.btndelete_account.Name = "btndelete_account"
        Me.btndelete_account.Size = New System.Drawing.Size(39, 37)
        Me.btndelete_account.TabIndex = 16
        Me.btndelete_account.UseVisualStyleBackColor = True
        '
        'frmaccount_manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(383, 280)
        Me.Controls.Add(Me.TabControl2)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmaccount_manager"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Manager"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents msk_usercode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cmbsave_level As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtsave_re As System.Windows.Forms.TextBox
    Friend WithEvents txtsave_password As System.Windows.Forms.TextBox
    Friend WithEvents txtsave_username As System.Windows.Forms.TextBox
    Friend WithEvents btnsave_account As System.Windows.Forms.Button
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents cmbedit_searchusercode As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtedit_usercode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmbedit_levelofaccess As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtedit_repassword As System.Windows.Forms.TextBox
    Friend WithEvents txtedit_password As System.Windows.Forms.TextBox
    Friend WithEvents txtedit_username As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents btnedit_account As System.Windows.Forms.Button
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents cmbdelete_searchaccount As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbldelete_usercode As System.Windows.Forms.Label
    Friend WithEvents lbldelete_levelofaccess As System.Windows.Forms.Label
    Friend WithEvents lbldelete_password As System.Windows.Forms.Label
    Friend WithEvents lbldelete_username As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents btndelete_account As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
