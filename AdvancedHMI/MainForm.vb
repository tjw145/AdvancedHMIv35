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

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Start checking for PLC connection as soon as page loads
        ConnectionCheckTimer.Start()
        ConnectionCheckThread.RunWorkerAsync()

        'Repeatedly run graph updater sub on UI thread (heavy)
        GraphUpdateTimer.Start()

        'General communications for UI
        GeneralCommsUpdateTimer.Start()

        'Separate thread for recording experiment data so that it doesn't get jammed up by the UI
        ExperimentRecordingThread.RunWorkerAsync()

        'Smooth out form graphics
        Me.DoubleBuffered = True

    End Sub

    Public Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click

        StartButton.Checked = False

        LockControls("unlock")

        'taskbarProgress.ProgressState = taskbarProgress.ProgressState.None

    End Sub

    Private Sub SetupButton_Click(sender As Object, e As EventArgs) Handles SetupButton.Click

        ExperimentSetupWindow.ShowDialog()

    End Sub


    'EXPERIMENT START/STOP TRIGGER'
    Private Sub StartButton_CheckedChanged(sender As Object, e As EventArgs) Handles StartButton.CheckedChanged

        System.Windows.Forms.Application.DoEvents()

        If StartButton.Checked = True Then

            If PLCconnection = "Connection Status: ✔" = True Then

                SendExperimentParametersToPLC()

                If CheckPLCexperimentParameters() = True Then

                    LockControls("run")
                    StartButton.Text = "❚❚"
                    Globals.ExperimentRunning = True

                    ExperimentRecordingTimer.Start()
                    ExperimentStopwatch.Start()

                    ModbusTCPCom1.BeginWrite(Hardware.START_BIT, 1, New String() {"1"}) 'Trigger "start" button

                Else

                    StartButton.CheckState = CheckState.Unchecked
                    Globals.PLCconnection = "Connection Status: ❌"

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

            If Globals.ExperimentRunning = True Then

                If SaveFileDialog.ShowDialog() = DialogResult.OK Then

                    Log.ExportAsCSV(SaveFileDialog.FileName)

                End If

                Globals.ExperimentRunning = False
                Log.ClearLog()

            End If

            Thread.Sleep(1000)

            StartButton.Text = "▶"
            LockControls("unlock")

        End If

    End Sub

    Private Function CheckConnectionToPLC() As Boolean

        'Checks connection to PLC by returning the value of a PLC memory bit which is always pulled high. 
        'I used strings here because it works and I didn't want to think about it.

        Try

            If CBool(ModbusTCPCom1.Read(Hardware.CONNECTION_TEST_BIT)) = False Then

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

    Private Sub ConnectionCheckThread_DoWork(sender As Object, e As DoWorkEventArgs) Handles ConnectionCheckThread.DoWork

        'While not running an active program, this constantly tests to make sure the PLC and software are connected.
        Try

            While StartButton.Checked = False

                CheckConnectionToPLC()
                System.Threading.Thread.Sleep(1000)

            End While

        Catch ex As Exception

            Debug.WriteLine("Error attempting to check connection")
            Globals.PLCconnection = "Connection Status: ❌"

        End Try

    End Sub

    Private blinkCount As Integer = 0
    Private Sub ControlBlinker_Tick(sender As Object, e As EventArgs) Handles ControlBlinker.Tick

        ' Makes the PLC connection indicator flash/blink repeatedly if you try to run without being connected
        ' I probably didn't need a whole timer component for this but whatever

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

    Private Sub UpdateGraph()
        Try
            'Update DRO
            DRO_mm.Value = CDbl(ModbusTCPCom1.Read(Hardware.CURRENT_DISPLACEMENT_ROUGH)) / 100 'ROUGH values are *100

            'DRO reads as two decimal places if the number is under 10mm, one if over
            If DRO_mm.Value < 10 Then
                DRO_mm.DecimalPosition = 2
            Else
                DRO_mm.DecimalPosition = 1
            End If


            'Update live graph
            Dim x As Double = Now.TimeOfDay.TotalMilliseconds
            Dim y As Double = CDbl(ModbusTCPCom1.Read(Hardware.CURRENT_DISPLACEMENT_ROUGH)) / 100 'ROUGH values are *100
            Dim NewPoint As New DataPoint(x, y)

            'Add datapoint
            LiveGraph.Series("DisplacementSeries").Points.Insert(0, NewPoint)

            Dim datapointsPerSecond As Integer = CInt(1000 / GraphUpdateTimer.Interval) 'ms to Hz
            Dim minimumDataPoint As Integer

            'Find minimum X-value for display window based on user selection
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

            If minimumDataPoint > LiveGraph.Series("DisplacementSeries").Points.Count Then

                'If there arent enough points to fill the window, just resize to fit all of them until there are
                'If you don't do this, the graph just freezes and it looks like it crashed
                minimumDataPoint = LiveGraph.Series("DisplacementSeries").Points.Count - 1

            End If

            If minimumDataPoint > datapointsPerSecond * 5 Then

                'If the graph shows a timespan over 5 seconds, turn markers off automatically
                DataMarkersCheckbox.CheckState = CheckState.Unchecked

            Else

                'Turn back on automatically
                DataMarkersCheckbox.CheckState = CheckState.Checked

            End If

            If LiveGraph.Series("DisplacementSeries").Points.Count > minimumDataPoint Then

                'Update X-axis boundaries so that graph window moves forward with new data
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
        Catch
            Debug.WriteLine("Error attempting to update graph/DRO")
        End Try

    End Sub

    Private Sub GraphUpdateTimer_Tick(sender As Object, e As EventArgs) Handles GraphUpdateTimer.Tick

        'As long as connection is good, update graph
        If Globals.PLCconnection = "Connection Status: ✔" Then
            UpdateGraph()
        End If

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

    Private Sub ExperimentRecordingThread_DoWork(sender As Object, e As DoWorkEventArgs) Handles ExperimentRecordingThread.DoWork

        'doing this loop /dirty/ because i have 3 hours to have it running and this one is important, all those other
        '"precious" system resources can get off my recording thread's fucking lawn

        While True

            If StartButton.Checked = True Then

                Dim currentTime As String
                Dim displacment As Integer = 0
                Dim force As Integer = 0

                Try

                    ' Get "high accuracy" position data from PLC
                    displacment = CInt(ModbusTCPCom1.Read(Hardware.CURRENT_DISPLACEMENT_ACCURATE))

                    ' Get current stopwatch time in seconds, and rounds to nearest 0.1 ms
                    currentTime = CStr(Math.Round(ExperimentStopwatch.Elapsed.TotalSeconds, 4))

                    ' Log all real-time data
                    Log.AddData(currentTime, displacment, force) '<----- arg format will need changed when force param is added

                    Thread.Sleep(Globals.dataLogRate_ms)

                Catch

                    Debug.WriteLine("Data logging error")

                    ' If a read error occurs, insert a datapoint of "999" to indicate where in the data it happened.
                    displacment = 999
                    currentTime = CStr(Math.Round(ExperimentStopwatch.Elapsed.TotalSeconds, 4))

                    ' Log data
                    Log.AddData(currentTime, displacment, force) '<----- arg format will need changed when force param is added

                    Thread.Sleep(Globals.dataLogRate_ms)

                End Try

            End If


            Try
                If ModbusTCPCom1.Read(Hardware.CYCLE_COMPLETE) = "{1}" Then

                    Globals.ExperimentRunning = False

                End If
            Catch
            End Try

        End While

    End Sub

    Private Sub ExperimentRecordingThread_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles ExperimentRecordingThread.RunWorkerCompleted

        ExperimentRecordingThread.RunWorkerAsync() 'YOU ARE NOT ALLOWED TO DIE

    End Sub

    Private Sub ExperimentCompleteSubscriber_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)

        'If "experiment complete" bit on PLC is pulled high;
        StartButton.CheckState = CheckState.Unchecked
        StopButton.PerformClick()

    End Sub

    Private Sub GeneralCommsUpdateTimer_Tick(sender As Object, e As EventArgs) Handles GeneralCommsUpdateTimer.Tick

        'As one final act of spite, the ONLY remaining thing that actually worked in the AdvancedHMI lib has also inexplicably
        'broken. this is my replacement - testing the state of each individual bit manually every 0.1s. I hate you, Archie.

        Try
            Dim homing As Boolean = CBool(ModbusTCPCom1.Read(Hardware.HOMING_ACTIVE))
            Dim experimentComplete As Boolean = CBool(ModbusTCPCom1.Read(Hardware.CYCLE_COMPLETE))
            Dim stopped As Boolean = CBool(ModbusTCPCom1.Read(Hardware.STOP_BIT))

            'Locks the controls if the flex rig is performing a homing operation
            If homing = True Then
                LockControls("all")
            Else
                If StartButton.Checked = False Then
                    LockControls("unlock")
                End If
            End If

            'Not super clean but *taps watch* not gonna hurt anytihng
            If stopped = True Then
                StartButton.Checked = False
            End If

            If experimentComplete = True Then
                Globals.ExperimentRunning = False
                StopButton.PerformClick()
            End If

        Catch
            Debug.WriteLine("Error attempting to update UI by reading PLC bits")
        End Try

    End Sub

End Class
