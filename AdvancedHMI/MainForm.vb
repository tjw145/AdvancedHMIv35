Imports System.ComponentModel
Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports System.Security.Permissions
Imports System.Threading
Imports System.Timers
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

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click

        StartButton.Checked = False
        'taskbarProgress.ProgressState = taskbarProgress.ProgressState.None

    End Sub

    Public Sub ExperimentRecordingTimer_Tick(sender As Object, e As EventArgs) Handles ExperimentRecordingTimer.Tick

        Dim currentTime As String
        Dim displacment As Integer = ModbusTCPCom1.Read("400008") '"accurate" position log address

        ' Gets current stopwatch time in seconds, and rounds to nearest millisecond
        currentTime = CStr(Math.Round(ExperimentStopwatch.Elapsed.TotalSeconds, 3))

        ' Log all real-time data
        Log.AddData(currentTime, displacment, 0)

        If GlobalInstances.FinishedMoving = True Then

            StartButton.CheckState = CheckState.Unchecked

        End If

    End Sub

    Private Sub SetupButton_Click(sender As Object, e As EventArgs) Handles SetupButton.Click

        ExperimentSetupWindow.ShowDialog()

    End Sub

    Private Sub StartButton_CheckedChanged(sender As Object, e As EventArgs) Handles StartButton.CheckedChanged

        If StartButton.Checked = True Then

            MotionControlThread.RunWorkerAsync()
            ExperimentRecordingTimer.Start()
            ExperimentStopwatch.Start()

            StartButton.Text = "❚❚"

        ElseIf StartButton.Checked = False Then

            MotionControlThread.CancelAsync()
            ExperimentRecordingTimer.Stop()
            ExperimentStopwatch.Stop()

            If SaveFileDialog.ShowDialog() = DialogResult.OK Then

                Log.ExportAsCSV(SaveFileDialog.FileName)

            End If

            ModbusTCPCom1.BeginWrite("017186", 1, New String() {"1"}) 'Trigger "off" button
            StartButton.Text = "▶"

        End If

    End Sub

    Private Function CheckConnectionToPLC() As Boolean

        'Try

        If CBool(ModbusTCPCom1.Read("018384")) = False Then

                ConnectionIndicator.Text = "Connection Status: ✔"
                Return True

            Else

                ConnectionIndicator.Text = "Connection Status: ❌"
                Return False

            End If

        'Catch ex As Exception

        ConnectionIndicator.Text = "Connection Status: ❌"
            Return False

        'End Try

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles ConnectionCheckTimer.Tick

        CheckConnectionToPLC()

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConnectionCheckTimer.Start()
        MotionControlThread.WorkerSupportsCancellation = True

    End Sub

    Private Sub MotionControlThread_DoWork(sender As Object, e As DoWorkEventArgs) Handles MotionControlThread.DoWork

        If MotionControlThread.CancellationPending = True Then

            Return

        End If

        With GlobalInstances.MotionController

            .OutputMotionSolution(ModbusTCPCom1, GlobalInstances.MovePoints, cycles)

        End With

    End Sub

    Private Sub StartButtonSubscriber_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles StartButtonSubscriber.DataChanged

        Dim runBitOn = StartButtonSubscriber.Value

        If runBitOn Is "False" Then

            StartButton.CheckState = CheckState.Unchecked

        ElseIf runBitOn Is "True" Then

            StartButton.CheckState = CheckState.Checked


        End If

    End Sub
End Class
