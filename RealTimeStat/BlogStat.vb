

Public Class RealTimeBlogStat
    Dim objx As New DataClass

    Dim Q As Integer = 4
    Dim D As Integer = 3
    Dim P As Integer = 2
    Dim R As Integer = 1

    Dim _servertime As DateTime
    Dim ts As TimeSpan

    'For Video



    Private Sub RealTimeBlogStat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CheckForIllegalCrossThreadCalls = False

        'Will Display Current Stat of Blog Donors
        Call displayStat()

        'Will Background to update Stat
        Call runWorker()


        'default path of video
        txtPath.Text = "C:\xblog.avi"

        'set time to clock
        'Will populate the Server Date and time to Analog Clock
        'Russel 1-16-2014
        _servertime = objx.displayServerTime

        ts = New TimeSpan(0, _servertime.Hour - DateTime.UtcNow.Hour, _servertime.Minute - DateTime.UtcNow.Minute, _servertime.Second - DateTime.UtcNow.Second)

        lblDate.Text = FormatDateTime(_servertime, DateFormat.LongDate)
        lblRegistered.Text = My.Application.Info.Copyright.ToString
    End Sub


    Public Sub displayStat()
        Label1.Text = "Total Qualified : " & objx.QualifiedStat(Q)
        Label2.Text = "Total Deferred :  " & objx.DeferredStat(D)
        Label3.Text = "Total Processing: " & objx.ProcessingStat(P)
        Label6.Text = "Total Pre Registration: " & objx.RegistratoinStat(R)

        lblOnProcess.Text = objx.ProcessingStat(P)
        lblDeferred.Text = objx.DeferredStat(D)
        lblQualified.Text = objx.QualifiedStat(Q)
        lblTotalRegistered.Text = objx.TotalRegistered

        Call objx.TOP1()
        lblStudNum.Text = objx.STUDNUM
        lblStudName.Text = objx.STUDNAME
        lblLevelSection.Text = objx.STUDLEVELSECTION

        If String.IsNullOrEmpty(objx.STUDENTIMAGE) Then
            picRecruiter.Image = Image.FromFile("\\192.168.2.14\share\xphoto\x.jpg")
        Else
            picRecruiter.Image = Image.FromFile(objx.STUDENTIMAGE)
        End If


    End Sub


    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        For i = 0 To 10
            Label5.Text = i
            BackgroundWorker1.ReportProgress(i)
            System.Threading.Thread.Sleep(10)
            Label5.Refresh()
        Next
    End Sub


    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        'Call back again the method to refresh record and run agaun the
        'Background worker
        Call displayStat()
        Call runWorker()

    End Sub


    Public Sub runWorker()
        BackgroundWorker1.RunWorkerAsync()
    End Sub


    'Public Sub playVideo()

    '    Const TestUrl As String = "C:\red1.wmv"
    '    ' Buffer 10 seconds
    '    Dim Options As String() = New String() {":input-repeat=100"}
    '    vlcPlayer.playlist.add(TestUrl, Nothing, Options)

    'End Sub
    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    vlcPlayer.playlist.items.clear()
    '    vlcPlayer.playlist.add("C:\red1.wmv")
    '    vlcPlayer.playlist.play()
    'End Sub

  
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'AVI
        'CTRL + P
        wmvPlayer.URL = txtPath.Text  '"C:\blog.avi"

    End Sub

    'Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
    '    wmvPlayer.URL = "C:\m2.mpg"
    'End Sub

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    '    wmvPlayer.URL = "C:\gentleman.mp3"
    'End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Clock2.UtcOffset = ts
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GroupBox1.Visible = True
        'Show text path
        'ALT + P
        txtPath.Visible = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        GroupBox1.Visible = False
        'ALT + C
        txtPath.Visible = False
    End Sub
End Class
