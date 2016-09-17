<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RealTimeBlogStat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RealTimeBlogStat))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblTotalRegistered = New System.Windows.Forms.Label
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.lblQualified = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Clock2 = New AnalogClock.Clock
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.lblOnProcess = New System.Windows.Forms.Label
        Me.lblDeferred = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.lblRegistered = New System.Windows.Forms.Label
        Me.wmvPlayer = New AxWMPLib.AxWindowsMediaPlayer
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.picRecruiter = New System.Windows.Forms.PictureBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblStudNum = New System.Windows.Forms.Label
        Me.lblStudName = New System.Windows.Forms.Label
        Me.lblLevelSection = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.wmvPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.picRecruiter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(161, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Label4"
        '
        'lblTotalRegistered
        '
        Me.lblTotalRegistered.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalRegistered.Font = New System.Drawing.Font("DS-Digital", 110.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRegistered.ForeColor = System.Drawing.Color.White
        Me.lblTotalRegistered.Location = New System.Drawing.Point(626, 212)
        Me.lblTotalRegistered.Name = "lblTotalRegistered"
        Me.lblTotalRegistered.Size = New System.Drawing.Size(372, 119)
        Me.lblTotalRegistered.TabIndex = 5
        Me.lblTotalRegistered.Text = "0"
        Me.lblTotalRegistered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'lblQualified
        '
        Me.lblQualified.BackColor = System.Drawing.Color.Transparent
        Me.lblQualified.Font = New System.Drawing.Font("DS-Digital", 150.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQualified.ForeColor = System.Drawing.Color.White
        Me.lblQualified.Location = New System.Drawing.Point(202, 214)
        Me.lblQualified.Name = "lblQualified"
        Me.lblQualified.Size = New System.Drawing.Size(453, 198)
        Me.lblQualified.TabIndex = 6
        Me.lblQualified.Text = "0"
        Me.lblQualified.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(169, 225)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1034, 585)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(10, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Q"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(226, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 14)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Label5"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtPath)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(209, 524)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 160)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detailed"
        Me.GroupBox1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 14)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Label6"
        '
        'txtPath
        '
        Me.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPath.Location = New System.Drawing.Point(49, 123)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(186, 22)
        Me.txtPath.TabIndex = 70
        Me.txtPath.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(289, 225)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "mp3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(275, 196)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "mpg"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1034, 643)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(10, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "&P"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Clock2
        '
        Me.Clock2.BackColor = System.Drawing.Color.Transparent
        Me.Clock2.BackgroundImage = CType(resources.GetObject("Clock2.BackgroundImage"), System.Drawing.Image)
        Me.Clock2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Clock2.BigMarkers = New AnalogClock.Marker() {New AnalogClock.Marker("BigMarker90", 90.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker60", 60.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker30", 30.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker0", 0.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker330", 330.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker300", 300.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker270", 270.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker240", 240.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker210", 210.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker180", 180.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker150", 150.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker120", 120.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing)}
        Me.Clock2.CenterPoint.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.Clock2.CenterPoint.RelativeRadius = 0.03!
        Me.Clock2.CenterPoint.Tag = Nothing
        Me.Clock2.FrameColor = System.Drawing.Color.White
        Me.Clock2.HourHand.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.Clock2.HourHand.RelativeRadius = 0.65!
        Me.Clock2.HourHand.Tag = Nothing
        Me.Clock2.HourHand.Width = 5.0!
        Me.Clock2.Location = New System.Drawing.Point(21, 109)
        Me.Clock2.MinuteHand.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.Clock2.MinuteHand.RelativeRadius = 0.8!
        Me.Clock2.MinuteHand.Tag = Nothing
        Me.Clock2.MinuteHand.Width = 5.0!
        Me.Clock2.Name = "Clock2"
        Me.Clock2.SecondHand.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.Clock2.SecondHand.RelativeRadius = 0.9!
        Me.Clock2.SecondHand.Tag = Nothing
        Me.Clock2.SecondHand.Width = 1.0!
        Me.Clock2.Size = New System.Drawing.Size(141, 147)
        Me.Clock2.SmallMarkers = New AnalogClock.Marker() {New AnalogClock.Marker("SmallMarker90", 90.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker84", 84.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker78", 78.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker72", 72.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker66", 66.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker60", 60.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker54", 54.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker48", 48.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker42", 42.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker36", 36.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker30", 30.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker24", 24.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker18", 18.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker12", 12.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker6", 6.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker0", 0.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker354", 354.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker348", 348.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker342", 342.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker336", 336.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker330", 330.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker324", 324.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker318", 318.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker312", 312.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker306", 306.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker300", 300.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker294", 294.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker288", 288.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker282", 282.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker276", 276.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker270", 270.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker264", 264.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker258", 258.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker252", 252.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker246", 246.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker240", 240.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker234", 234.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker228", 228.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker222", 222.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker216", 216.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker210", 210.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker204", 204.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker198", 198.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker192", 192.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker186", 186.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker180", 180.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker174", 174.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker168", 168.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker162", 162.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker156", 156.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker150", 150.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker144", 144.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker138", 138.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker132", 132.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker126", 126.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker120", 120.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker114", 114.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker108", 108.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker102", 102.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker96", 96.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 70.5!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing)}
        Me.Clock2.Symbols = New AnalogClock.Symbol() {New AnalogClock.Symbol("Symbol90", 90.0!, "12", New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 0, True, True, AnalogClock.SymbolStyle.Numeric, 70.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol60", 60.0!, "1", New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 1, True, True, AnalogClock.SymbolStyle.Numeric, 70.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol30", 30.0!, "2", New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 2, True, True, AnalogClock.SymbolStyle.Numeric, 70.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol0", 0.0!, "3", New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 3, True, True, AnalogClock.SymbolStyle.Numeric, 70.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol330", 330.0!, "4", New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 4, True, True, AnalogClock.SymbolStyle.Numeric, 70.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol300", 300.0!, "5", New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 5, True, True, AnalogClock.SymbolStyle.Numeric, 70.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol270", 270.0!, "6", New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 6, True, True, AnalogClock.SymbolStyle.Numeric, 70.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol240", 240.0!, "7", New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 7, True, True, AnalogClock.SymbolStyle.Numeric, 70.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol210", 210.0!, "8", New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 8, True, True, AnalogClock.SymbolStyle.Numeric, 70.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol180", 180.0!, "9", New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 9, True, True, AnalogClock.SymbolStyle.Numeric, 70.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol150", 150.0!, "10", New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 10, True, True, AnalogClock.SymbolStyle.Numeric, 70.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol120", 120.0!, "11", New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 11, True, True, AnalogClock.SymbolStyle.Numeric, 70.5!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing)}
        Me.Clock2.TabIndex = 62
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1034, 672)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(10, 23)
        Me.Button5.TabIndex = 63
        Me.Button5.Text = "&X"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(1034, 614)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(10, 23)
        Me.Button6.TabIndex = 64
        Me.Button6.Text = "&C"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'lblOnProcess
        '
        Me.lblOnProcess.BackColor = System.Drawing.Color.Transparent
        Me.lblOnProcess.Font = New System.Drawing.Font("DS-Digital", 110.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnProcess.ForeColor = System.Drawing.Color.White
        Me.lblOnProcess.Location = New System.Drawing.Point(629, 400)
        Me.lblOnProcess.Name = "lblOnProcess"
        Me.lblOnProcess.Size = New System.Drawing.Size(372, 119)
        Me.lblOnProcess.TabIndex = 65
        Me.lblOnProcess.Text = "0"
        Me.lblOnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDeferred
        '
        Me.lblDeferred.BackColor = System.Drawing.Color.Transparent
        Me.lblDeferred.Font = New System.Drawing.Font("DS-Digital", 110.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeferred.ForeColor = System.Drawing.Color.White
        Me.lblDeferred.Location = New System.Drawing.Point(629, 575)
        Me.lblDeferred.Name = "lblDeferred"
        Me.lblDeferred.Size = New System.Drawing.Size(372, 119)
        Me.lblDeferred.TabIndex = 66
        Me.lblDeferred.Text = "0"
        Me.lblDeferred.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(4, 49)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(174, 46)
        Me.lblDate.TabIndex = 68
        Me.lblDate.Text = "date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRegistered
        '
        Me.lblRegistered.AutoSize = True
        Me.lblRegistered.BackColor = System.Drawing.Color.Transparent
        Me.lblRegistered.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistered.ForeColor = System.Drawing.Color.White
        Me.lblRegistered.Location = New System.Drawing.Point(3, 746)
        Me.lblRegistered.Name = "lblRegistered"
        Me.lblRegistered.Size = New System.Drawing.Size(41, 14)
        Me.lblRegistered.TabIndex = 69
        Me.lblRegistered.Text = "sadasd"
        '
        'wmvPlayer
        '
        Me.wmvPlayer.Enabled = True
        Me.wmvPlayer.Location = New System.Drawing.Point(243, 434)
        Me.wmvPlayer.Name = "wmvPlayer"
        Me.wmvPlayer.OcxState = CType(resources.GetObject("wmvPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmvPlayer.Size = New System.Drawing.Size(386, 284)
        Me.wmvPlayer.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(21, 279)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 5)
        Me.Panel1.TabIndex = 70
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 18)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "TOP RECRUITER"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Green
        Me.Panel2.Controls.Add(Me.picRecruiter)
        Me.Panel2.Location = New System.Drawing.Point(42, 316)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(105, 109)
        Me.Panel2.TabIndex = 106
        '
        'picRecruiter
        '
        Me.picRecruiter.BackColor = System.Drawing.Color.Gray
        Me.picRecruiter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRecruiter.Location = New System.Drawing.Point(3, 3)
        Me.picRecruiter.Name = "picRecruiter"
        Me.picRecruiter.Size = New System.Drawing.Size(99, 103)
        Me.picRecruiter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRecruiter.TabIndex = 99
        Me.picRecruiter.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(21, 473)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(148, 5)
        Me.Panel3.TabIndex = 107
        '
        'lblStudNum
        '
        Me.lblStudNum.AutoSize = True
        Me.lblStudNum.BackColor = System.Drawing.Color.Transparent
        Me.lblStudNum.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudNum.Location = New System.Drawing.Point(42, 431)
        Me.lblStudNum.Name = "lblStudNum"
        Me.lblStudNum.Size = New System.Drawing.Size(107, 13)
        Me.lblStudNum.TabIndex = 108
        Me.lblStudNum.Text = "TOP RECRUITER"
        Me.lblStudNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStudName
        '
        Me.lblStudName.AutoSize = True
        Me.lblStudName.BackColor = System.Drawing.Color.Transparent
        Me.lblStudName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudName.Location = New System.Drawing.Point(42, 444)
        Me.lblStudName.Name = "lblStudName"
        Me.lblStudName.Size = New System.Drawing.Size(101, 13)
        Me.lblStudName.TabIndex = 109
        Me.lblStudName.Text = "TOP RECRUITER"
        Me.lblStudName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLevelSection
        '
        Me.lblLevelSection.AutoSize = True
        Me.lblLevelSection.BackColor = System.Drawing.Color.Transparent
        Me.lblLevelSection.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevelSection.Location = New System.Drawing.Point(42, 457)
        Me.lblLevelSection.Name = "lblLevelSection"
        Me.lblLevelSection.Size = New System.Drawing.Size(101, 13)
        Me.lblLevelSection.TabIndex = 110
        Me.lblLevelSection.Text = "TOP RECRUITER"
        Me.lblLevelSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RealTimeBlogStat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1020, 686)
        Me.Controls.Add(Me.lblLevelSection)
        Me.Controls.Add(Me.lblStudName)
        Me.Controls.Add(Me.lblStudNum)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblRegistered)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblDeferred)
        Me.Controls.Add(Me.lblOnProcess)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Clock2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.wmvPlayer)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblQualified)
        Me.Controls.Add(Me.lblTotalRegistered)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RealTimeBlogStat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.wmvPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.picRecruiter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotalRegistered As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblQualified As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents wmvPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Clock2 As AnalogClock.Clock
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents lblOnProcess As System.Windows.Forms.Label
    Friend WithEvents lblDeferred As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblRegistered As System.Windows.Forms.Label
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents picRecruiter As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblStudNum As System.Windows.Forms.Label
    Friend WithEvents lblStudName As System.Windows.Forms.Label
    Friend WithEvents lblLevelSection As System.Windows.Forms.Label

End Class
