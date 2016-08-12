<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreception
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmreception))
        Me.txtsearch = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.ListBox3 = New System.Windows.Forms.ListBox
        Me.ListBox4 = New System.Windows.Forms.ListBox
        Me.dginfo = New System.Windows.Forms.DataGridView
        Me.SnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DinfoBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BlogDataSet10 = New WindowsApplication1.BlogDataSet10
        Me.Label6 = New System.Windows.Forms.Label
        Me.ListBox5 = New System.Windows.Forms.ListBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.BlogDataSet1 = New WindowsApplication1.BlogDataSet1
        Me.SInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SInfoTableAdapter = New WindowsApplication1.BlogDataSet1TableAdapters.SInfoTableAdapter
        Me.DinfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BlogDataSet2 = New WindowsApplication1.BlogDataSet2
        Me.DinfoTableAdapter = New WindowsApplication1.BlogDataSet2TableAdapters.dinfoTableAdapter
        Me.DinfoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BlogDataSet3 = New WindowsApplication1.BlogDataSet3
        Me.DinfoTableAdapter1 = New WindowsApplication1.BlogDataSet3TableAdapters.dinfoTableAdapter
        Me.BlogDataSet9 = New WindowsApplication1.BlogDataSet9
        Me.DinfoBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DinfoTableAdapter2 = New WindowsApplication1.BlogDataSet9TableAdapters.dinfoTableAdapter
        Me.DinfoTableAdapter3 = New WindowsApplication1.BlogDataSet10TableAdapters.dinfoTableAdapter
        Me.SInfoTableAdapter1 = New WindowsApplication1.BlogDataSet7TableAdapters.SInfoTableAdapter
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label
        CType(Me.dginfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DinfoBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlogDataSet10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlogDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DinfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlogDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DinfoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlogDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlogDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DinfoBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(12, 470)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(241, 23)
        Me.txtsearch.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Recruiter  Name:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(11, 407)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(11, 433)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "PR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 16)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "P"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(134, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "D"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(200, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 16)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Q"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(25, 330)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(47, 21)
        Me.TextBox3.TabIndex = 43
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(87, 330)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(47, 21)
        Me.TextBox4.TabIndex = 44
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(149, 330)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(47, 21)
        Me.TextBox5.TabIndex = 45
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(215, 330)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(47, 21)
        Me.TextBox6.TabIndex = 46
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(109, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(241, 21)
        Me.ComboBox1.TabIndex = 47
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(703, 134)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(176, 56)
        Me.ListBox1.TabIndex = 48
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(735, 196)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(176, 56)
        Me.ListBox2.TabIndex = 49
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(703, 258)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(176, 56)
        Me.ListBox3.TabIndex = 50
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(702, 320)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(176, 56)
        Me.ListBox4.TabIndex = 51
        '
        'dginfo
        '
        Me.dginfo.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dginfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dginfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dginfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SnameDataGridViewTextBoxColumn, Me.FnameDataGridViewTextBoxColumn, Me.MnameDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.dginfo.DataSource = Me.DinfoBindingSource3
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dginfo.DefaultCellStyle = DataGridViewCellStyle2
        Me.dginfo.Location = New System.Drawing.Point(7, 39)
        Me.dginfo.Name = "dginfo"
        Me.dginfo.ReadOnly = True
        Me.dginfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dginfo.Size = New System.Drawing.Size(643, 277)
        Me.dginfo.TabIndex = 52
        '
        'SnameDataGridViewTextBoxColumn
        '
        Me.SnameDataGridViewTextBoxColumn.DataPropertyName = "sname"
        Me.SnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SnameDataGridViewTextBoxColumn.Name = "SnameDataGridViewTextBoxColumn"
        Me.SnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.SnameDataGridViewTextBoxColumn.Width = 200
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "fname"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        Me.FnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FnameDataGridViewTextBoxColumn.Width = 200
        '
        'MnameDataGridViewTextBoxColumn
        '
        Me.MnameDataGridViewTextBoxColumn.DataPropertyName = "mname"
        Me.MnameDataGridViewTextBoxColumn.HeaderText = "Middlename"
        Me.MnameDataGridViewTextBoxColumn.Name = "MnameDataGridViewTextBoxColumn"
        Me.MnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DinfoBindingSource3
        '
        Me.DinfoBindingSource3.DataMember = "dinfo"
        Me.DinfoBindingSource3.DataSource = Me.BlogDataSet10
        '
        'BlogDataSet10
        '
        Me.BlogDataSet10.DataSetName = "BlogDataSet10"
        Me.BlogDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(62, 378)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 16)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Walk In:"
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.Location = New System.Drawing.Point(605, 370)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(173, 56)
        Me.ListBox5.TabIndex = 55
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(129, 374)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(47, 23)
        Me.TextBox7.TabIndex = 56
        '
        'BlogDataSet1
        '
        Me.BlogDataSet1.DataSetName = "BlogDataSet1"
        Me.BlogDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SInfoBindingSource
        '
        Me.SInfoBindingSource.DataMember = "SInfo"
        Me.SInfoBindingSource.DataSource = Me.BlogDataSet1
        '
        'SInfoTableAdapter
        '
        Me.SInfoTableAdapter.ClearBeforeFill = True
        '
        'DinfoBindingSource
        '
        Me.DinfoBindingSource.DataMember = "dinfo"
        Me.DinfoBindingSource.DataSource = Me.BlogDataSet2
        '
        'BlogDataSet2
        '
        Me.BlogDataSet2.DataSetName = "BlogDataSet2"
        Me.BlogDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DinfoTableAdapter
        '
        Me.DinfoTableAdapter.ClearBeforeFill = True
        '
        'DinfoBindingSource1
        '
        Me.DinfoBindingSource1.DataMember = "dinfo"
        Me.DinfoBindingSource1.DataSource = Me.BlogDataSet3
        '
        'BlogDataSet3
        '
        Me.BlogDataSet3.DataSetName = "BlogDataSet3"
        Me.BlogDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DinfoTableAdapter1
        '
        Me.DinfoTableAdapter1.ClearBeforeFill = True
        '
        'BlogDataSet9
        '
        Me.BlogDataSet9.DataSetName = "BlogDataSet9"
        Me.BlogDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DinfoBindingSource2
        '
        Me.DinfoBindingSource2.DataMember = "dinfo"
        Me.DinfoBindingSource2.DataSource = Me.BlogDataSet9
        '
        'DinfoTableAdapter2
        '
        Me.DinfoTableAdapter2.ClearBeforeFill = True
        '
        'DinfoTableAdapter3
        '
        Me.DinfoTableAdapter3.ClearBeforeFill = True
        '
        'SInfoTableAdapter1
        '
        Me.SInfoTableAdapter1.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(288, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(363, 12)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "PR - Pre Registration     P - Processing      D - Deferred      Q - Qualified"
        '
        'frmreception
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(655, 355)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dginfo)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtsearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmreception"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reception and Information"
        CType(Me.dginfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DinfoBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlogDataSet10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlogDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DinfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlogDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DinfoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlogDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlogDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DinfoBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents BlogDataSet1 As WindowsApplication1.BlogDataSet1
    Friend WithEvents SInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SInfoTableAdapter As WindowsApplication1.BlogDataSet1TableAdapters.SInfoTableAdapter
    Friend WithEvents BlogDataSet2 As WindowsApplication1.BlogDataSet2
    Friend WithEvents DinfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DinfoTableAdapter As WindowsApplication1.BlogDataSet2TableAdapters.dinfoTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BlogDataSet3 As WindowsApplication1.BlogDataSet3
    Friend WithEvents DinfoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DinfoTableAdapter1 As WindowsApplication1.BlogDataSet3TableAdapters.dinfoTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents BlogDataSet9 As WindowsApplication1.BlogDataSet9
    Friend WithEvents DinfoBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents DinfoTableAdapter2 As WindowsApplication1.BlogDataSet9TableAdapters.dinfoTableAdapter
    Friend WithEvents dginfo As System.Windows.Forms.DataGridView
    Friend WithEvents BlogDataSet10 As WindowsApplication1.BlogDataSet10
    Friend WithEvents DinfoBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents DinfoTableAdapter3 As WindowsApplication1.BlogDataSet10TableAdapters.dinfoTableAdapter
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ListBox5 As System.Windows.Forms.ListBox
    Friend WithEvents SInfoTableAdapter1 As WindowsApplication1.BlogDataSet7TableAdapters.SInfoTableAdapter
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
