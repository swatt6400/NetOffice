﻿Imports NetOffice.PowerPointApi.Tools

Public Class SamplePane
    Implements ITaskPane ' Not necessary to implement ITaskPane but its helpful

#Region "Properties"

    Private StartTime As DateTime

#End Region

#Region "ITaskPane"

    Public Sub OnConnection(ByVal application As NetOffice.PowerPointApi.Application, ByVal parentPane As NetOffice.OfficeApi._CustomTaskPane, ByVal customArguments() As Object) Implements NetOffice.PowerPointApi.Tools.ITaskPane.OnConnection

        StartTime = DateTime.Now
        buttonEnabled_Click(buttonEnabled, New EventArgs())

    End Sub

    Public Sub OnDisconnection() Implements NetOffice.PowerPointApi.Tools.ITaskPane.OnDisconnection

    End Sub

    Public Sub OnDockPositionChanged(ByVal position As NetOffice.OfficeApi.Enums.MsoCTPDockPosition) Implements NetOffice.PowerPointApi.Tools.ITaskPane.OnDockPositionChanged


    End Sub

    Public Sub OnVisibleStateChanged(ByVal visible As Boolean) Implements NetOffice.PowerPointApi.Tools.ITaskPane.OnVisibleStateChanged


    End Sub

#End Region

#Region "Trigger"

    Private Sub buttonEnabled_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonEnabled.Click

        If (timerRunningTime.Enabled) Then
            timerRunningTime.Enabled = False
            buttonEnabled.Text = "Enable"
            buttonEnabled.ImageKey = "alarmclock_run.png"
            labelTime.ForeColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.ControlText)

        Else
            timerRunningTime.Enabled = True
            buttonEnabled.Text = "Disable"
            buttonEnabled.ImageKey = "alarmclock_stop.png"
            labelTime.ForeColor = System.Drawing.Color.White
        End If

    End Sub

    Private Sub buttonReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonReset.Click

        StartTime = DateTime.Now
        labelTime.Text = "00:00:00"

    End Sub

    Private Sub timerRunningTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerRunningTime.Tick

        Dim ts As TimeSpan = DateTime.Now - StartTime
        labelTime.Text = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds)

    End Sub

#End Region

End Class
