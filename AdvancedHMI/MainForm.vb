Option Strict On

Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports System.Security.Permissions
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Timers
Imports System.Windows
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Input
Imports System.Windows.Threading
Imports AdvancedHMIControls
Imports Microsoft.VisualBasic.Logging

Public Class MainForm
    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private NotFirstShow As Boolean

    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        '* Do not start comms on first show in case it was set to disable in design mode
        If NotFirstShow Then
            AdvancedHMIDrivers.Utilities.StopComsOnHidden(components, Me)
        Else
            NotFirstShow = True
        End If
    End Sub

    '***************************************************************
    '* .NET does not close hidden forms, so do it here
    '* to make sure forms are disposed and drivers close
    '***************************************************************
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim index As Integer
        While index < My.Application.OpenForms.Count
            If My.Application.OpenForms(index) IsNot Me Then
                My.Application.OpenForms(index).Close()
            End If
            index += 1
        End While
    End Sub

    Dim taskbarProgress As New Windows.Shell.TaskbarItemInfo


    Public Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click

        StartButton.Checked = False

        LockControls("unlock")

        'taskbarProgress.ProgressState = taskbarProgress.ProgressState.None

    End Sub


    'RECORDING SYSTEM'
    Public Sub ExperimentRecordingTimer_Tick(sender As Object, e As EventArgs) Handles ExperimentRecordingTimer.Tick

        Dim currentTime As String
        Dim displacment As Integer = 0
        Dim force As Integer = 0

        ' Get "high accuracy" position data from PLC
        displacment = CInt(ModbusTCPCom1.Read(Hardware.CURRENT_DISPLACEMENT_ACCURATE))

        ' Get current stopwatch time in seconds, and rounds to nearest 0.1 ms
        currentTime = CStr(Math.Round(ExperimentStopwatch.Elapsed.TotalSeconds, 4))

        ' Log all real-time data
        Log.AddData(currentTime, displacment, force) '<----- arg format will need changed when force param is added

    End Sub

    Private Sub SetupButton_Click(sender As Object, e As EventArgs) Handles SetupButton.Click

        ExperimentSetupWindow.ShowDialog()

    End Sub


    'START/STOP TRIGGER'
    Private Sub StartButton_CheckedChanged(sender As Object, e As EventArgs) Handles StartButton.CheckedChanged

        System.Windows.Forms.Application.DoEvents()

        If StartButton.Checked = True Then

            If PLCconnection = "Connection Status: ✔" = True Then

                SendExperimentParametersToPLC()

                If CheckPLCexperimentParameters() = True Then

                    LockControls("run")
                    StartButton.Text = "❚❚"

                    ExperimentRecordingTimer.Start()
                    ExperimentStopwatch.Start()

                    ModbusTCPCom1.BeginWrite(Hardware.START_BIT, 1, New String() {"1"}) 'Trigger "start" button

                Else

                    StartButton.CheckState = CheckState.Unchecked
                    PLCconnection = "Unknown Connection Error - Please Restart"

                End If

            Else

                ControlBlinker.Start()
                StartButton.CheckState = CheckState.Unchecked

            End If


        ElseIf StartButton.Checked = False Then

            ModbusTCPCom1.BeginWrite(Hardware.STOP_BIT, 1, New String() {"1"}) 'Trigger "stop" button

            If ExperimentRecordingTimer.Enabled = True Then

                ExperimentRecordingTimer.Stop()

            End If

            If ExperimentStopwatch.IsRunning Then

                ExperimentStopwatch.Stop()

            End If

            Thread.Sleep(1000)

            If SaveFileDialog.ShowDialog() = DialogResult.OK Then

                Log.ExportAsCSV(SaveFileDialog.FileName)

            End If

            StartButton.Text = "▶"
            LockControls("unlock")

        End If

    End Sub

    Private Function CheckConnectionToPLC() As Boolean

        Try

            If CBool(ModbusTCPCom1.Read("018384")) = False Then

                Globals.PLCconnection = "Connection Status: ✔"
                Return True

            Else

                Globals.PLCconnection = "Connection Status: ❌"
                Return False

            End If

        Catch ex As Exception

            Globals.PLCconnection = "Connection Status: ❌"
            Return False

        End Try

    End Function

    Private Sub ConnectionCheckTimer_Tick(sender As Object, e As EventArgs) Handles ConnectionCheckTimer.Tick

        ConnectionIndicator.Text = PLCconnection

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Start checking for PLC connection as soon as page loads
        ConnectionCheckTimer.Start()
        ConnectionCheckThread.RunWorkerAsync()
        GraphUpdateTimer.Start()
        Me.DoubleBuffered = True

    End Sub

    'Public Sub MotionControlThread_DoWork(sender As Object, e As DoWorkEventArgs) Handles MotionControlThread.DoWork

    '    'Time spent trying to figure out how make this multithreading work correctly:
    '    '16 days


    '    While MotionControlThread.CancellationPending = False AndAlso Globals.MotionController.MovesComplete = False

    '        'Dim asyncOutputThread As Task = Task.Factory.StartNew(Globals.MotionController.OutputMotionSolution(ModbusTCPCom1, Globals.MovePoints, Globals.cycles))
    '        'asyncOutputThread.Start()
    '        'ThreadPool.QueueUserWorkItem(Globals.MotionController.OutputMotionSolution(ModbusTCPCom1, Globals.MovePoints, Globals.cycles))
    '        'Task.Run(Sub() Globals.MotionController.OutputMotionSolution(ModbusTCPCom1, Globals.MovePoints, Globals.cycles))

    '        Globals.MotionController.OutputMotionSolution(ModbusTCPCom1, Globals.MovePoints, cycles)
    '        System.Windows.Forms.Application.DoEvents()
    '    End While

    '    System.Windows.Forms.Application.DoEvents()
    '    e.Cancel = True
    '    Exit Sub

    'End Sub

    Private Sub ConnectionCheckThread_DoWork(sender As Object, e As DoWorkEventArgs) Handles ConnectionCheckThread.DoWork

        'While not running an active program, this constantly tests to make sure the PLC and software are connected.

        While StartButton.Checked = False

            CheckConnectionToPLC()
            System.Threading.Thread.Sleep(1000)

        End While

    End Sub

    Private Sub ControlBlinker_Tick(sender As Object, e As EventArgs) Handles ControlBlinker.Tick

        ' Makes the PLC connection indicator flash/blink repeatedly if you try to run without being connected

        Dim blinkCount As Integer = 0

        If blinkCount < 5 Then

            If ConnectionIndicator.ForeColor = Color.White Then

                ConnectionIndicator.ForeColor = Color.Red

            ElseIf ConnectionIndicator.ForeColor = Color.Red Then

                ConnectionIndicator.ForeColor = Color.White

            End If

            blinkCount += 1

        Else

            ConnectionIndicator.ForeColor = Color.White
            blinkCount = 0
            ControlBlinker.Stop()

        End If


    End Sub

    Private Sub CheckIfCurrentlyHoming(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles CheckIfHoming.DataChanged

        'Locks the controls if the flex rig is performing a homing operation

        If CheckIfHoming.Value = "True" Then

            LockControls("all")

        ElseIf CheckIfHoming.Value = "False" Then

            LockControls("unlock")

        End If

    End Sub

    Public Sub LockControls(keyword As String)

        'Locks controls while flex rig is in motion to prevent damage or accidental interruptions during
        'experiments; has three different modes.

        If keyword = "all" Then
            'ForceZero.Enabled = False              Not Implemented
            'DisplacementZero.Enabled = False       Not Implemented
            HW_Zero.Enabled = False
            JogMinus.Enabled = False
            JogPlus.Enabled = False
            SetOrigin.Enabled = False
            StartButton.Enabled = False
        End If

        If keyword = "run" Then
            ForceZero.Enabled = False
            DisplacementZero.Enabled = False
            HW_Zero.Enabled = False
            JogMinus.Enabled = False
            JogPlus.Enabled = False
            SetOrigin.Enabled = False
            StartButton.Enabled = True
        End If

        If keyword = "unlock" Then
            'ForceZero.Enabled = True               Not Implemented
            'DisplacementZero.Enabled = True        Not Implemented
            HW_Zero.Enabled = True
            JogMinus.Enabled = True
            JogPlus.Enabled = True
            SetOrigin.Enabled = True
            StartButton.Enabled = True
        End If

    End Sub

    Public Sub SendExperimentParametersToPLC()

        'Sends the stored experiment parameters in Globals over to the PLC.

        With ModbusTCPCom1

            .Write(Hardware.NO_OF_CYCLES_USER_INPUT, CStr(Globals.numberOfCycles))
            .Write(Hardware.DISPLACEMENT_USER_INPUT, CStr(Globals.displacement_mm))
            .Write(Hardware.TRAVERSE_TIME_USER_INPUT, CStr(Globals.traverseTime_s))

        End With

    End Sub

    Public Function CheckPLCexperimentParameters() As Boolean

        'Double-check to make sure the experiment parameters stored in the PLC's memory match the current
        'parameters selected my the user. Used before running.

        With ModbusTCPCom1

            If _
                    .Read(Hardware.NO_OF_CYCLES_USER_INPUT) = CStr(Globals.numberOfCycles) _
                And .Read(Hardware.DISPLACEMENT_USER_INPUT) = CStr(Globals.displacement_mm) _
                And .Read(Hardware.TRAVERSE_TIME_USER_INPUT) = CStr(Globals.traverseTime_s) Then

                Return True

            Else Return False

            End If
        End With

    End Function

    Private Sub StopButtonSubscriber_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles StopButtonSubscriber.DataChanged

        'Supposed to reset mainform controls after cycle stops and PLC resets stop bit to true. TEST THIS

        If StartButton.Checked = True And ModbusTCPCom1.Read(STOP_BIT) = "1" Then

            StartButton.Checked = False

        End If

    End Sub

    Dim testx As Double = 1
    Dim testsin As Double = 0

    Private Sub UpdateGraph()

        Dim x As Double = testx
        Dim y As Double = (15 * Math.Sin(testsin)) + 15
        Dim NewPoint As New DataPoint(x, y)

        Dim datapointsPerSecond As Integer = CInt(1000 / GraphUpdateTimer.Interval) 'ms to Hz
        Dim minimumDataPoint As Integer

        'Find minimum X-value for display based on user selection
        If HalfCycleButton.Checked = True Then
            minimumDataPoint = datapointsPerSecond * CInt(Globals.traverseTime_s / 100)
        End If
        If OneCycleButton.Checked = True Then
            minimumDataPoint = datapointsPerSecond * CInt(Globals.traverseTime_s / 100) * 2
        End If
        If TwoCycleButton.Checked = True Then
            minimumDataPoint = datapointsPerSecond * CInt(Globals.traverseTime_s / 100) * 4
        End If
        If UserSecondsButton.Checked = True Then
            minimumDataPoint = CInt(datapointsPerSecond * UserSecondsInput.Value)
        End If

        'LiveGraph.Series("DisplacementSeries").Points.AddXY(x, y)
        LiveGraph.Series("DisplacementSeries").Points.Insert(0, NewPoint)

        If LiveGraph.Series("DisplacementSeries").Points.Count > minimumDataPoint Then

            'Update X-axis boundaries
            LiveGraph.ChartAreas(0).AxisX.Minimum = LiveGraph.Series("DisplacementSeries").Points.Item(minimumDataPoint).XValue
            LiveGraph.ChartAreas(0).AxisX.Maximum = LiveGraph.Series("DisplacementSeries").Points.Item(0).XValue

        End If

        'Graph data storage tops out at approximately 10 full minutes of recording time, or 600 seconds. Should work?
        If LiveGraph.Series("DisplacementSeries").Points.Count >= datapointsPerSecond * 60 * 10 Then

            '= last point in series
            Dim lastPoint As Integer = LiveGraph.Series("DisplacementSeries").Points.Count - 1

            'Remove last item
            LiveGraph.Series("DisplacementSeries").Points.RemoveAt(lastPoint)

        End If

        testx = testx + 0.05
        testsin = testsin + 0.01

    End Sub

    Private Sub GraphUpdateTimer_Tick(sender As Object, e As EventArgs) Handles GraphUpdateTimer.Tick
        UpdateGraph()
    End Sub

    Private Sub DataMarkersCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles DataMarkersCheckbox.CheckedChanged

        'Switches data markers on the live graph on/off.

        If DataMarkersCheckbox.CheckState = CheckState.Checked Then

            LiveGraph.Series("DisplacementSeries").ChartType = SeriesChartType.Line

        Else

            'FastLine doesn't support datamarkers, so by doing it this way we get a little extra performance as
            'opposed to just switching markers off :)
            LiveGraph.Series("DisplacementSeries").ChartType = SeriesChartType.FastLine

        End If

    End Sub

End Class
