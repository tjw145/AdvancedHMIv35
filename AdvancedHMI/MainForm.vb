﻿Imports System.Collections.ObjectModel
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


    'RECORDING SYSTEM'
    Public Sub ExperimentRecordingTimer_Tick(sender As Object, e As EventArgs) Handles ExperimentRecordingTimer.Tick

        Dim currentTime As String
        Dim displacment As Integer = 0
        Dim force As Integer = 0

        If ExperimentSetupWindow.RecDispCheckBox.CheckState = CheckState.Checked Then

            displacment = ModbusTCPCom1.Read("400008") '"accurate" position log address

        End If

        If ExperimentSetupWindow.RecForceCheckBox.CheckState = CheckState.Checked Then

            force = 0 ' whatever the force PLC address will end up being

        End If

        ' Gets current stopwatch time in seconds, and rounds to nearest 0.1 ms
        currentTime = CStr(Math.Round(ExperimentStopwatch.Elapsed.TotalSeconds, 4))

        ' Log all real-time data
        Log.AddData(currentTime, displacment, force) '<----- arg format will need changed when force param is added

        If GlobalInstances.FinishedMoving = True Then

            StartButton.CheckState = CheckState.Unchecked

        End If

    End Sub

    Private Sub SetupButton_Click(sender As Object, e As EventArgs) Handles SetupButton.Click

        ExperimentSetupWindow.ShowDialog()

    End Sub


    'START/STOP TRIGGER'
    Private Sub StartButton_CheckedChanged(sender As Object, e As EventArgs) Handles StartButton.CheckedChanged

        If StartButton.Checked = True Then

            If StartReady = True Then

                If PLCconnection = "Connection Status: ✔" Then

                    MotionControlThread.RunWorkerAsync()
                    ExperimentRecordingTimer.Start() '<------- Might be unneeded?
                    ExperimentStopwatch.Start()

                    StartButton.Text = "❚❚"

                Else

                    ControlBlinker.Start()

                End If


            ElseIf StartReady = False Then

                StartButton.CheckState = CheckState.Unchecked

            End If


        ElseIf StartButton.Checked = False And ExperimentStopwatch.IsRunning Then

            MotionControlThread.CancelAsync() ' throws an error
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

        Try

            If CBool(ModbusTCPCom1.Read("018384")) = False Then

                GlobalInstances.PLCconnection = "Connection Status: ✔"
                Return True

            Else

                GlobalInstances.PLCconnection = "Connection Status: ❌"
                Return False

            End If

        Catch ex As Exception

            GlobalInstances.PLCconnection = "Connection Status: ❌"
            Return False

        End Try

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles ConnectionCheckTimer.Tick

        ConnectionIndicator.Text = PLCconnection

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConnectionCheckTimer.Start()
        ConnectionCheckThread.RunWorkerAsync()
        MotionControlThread.WorkerSupportsCancellation = True

        GraphUpdater.Start()

    End Sub

    Private Sub MotionControlThread_DoWork(sender As Object, e As DoWorkEventArgs) Handles MotionControlThread.DoWork

        If MotionControlThread.CancellationPending = True Then
            'this probably doesn't work
            Return

        End If

        With GlobalInstances.MotionController

            .OutputMotionSolution(ModbusTCPCom1, GlobalInstances.MovePoints, cycles)

        End With

    End Sub

    Private Sub StartButtonSubscriber_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles StartButtonSubscriber.DataChanged

        'I don't think this does anything but I'm too scared to remove it.

        Dim runBitOn = StartButtonSubscriber.Value

        If runBitOn Is "False" Then

            StartButton.CheckState = CheckState.Unchecked

        ElseIf runBitOn Is "True" Then

            StartButton.CheckState = CheckState.Checked

        End If

    End Sub

    Private Sub ConnectionCheckThread_DoWork(sender As Object, e As DoWorkEventArgs) Handles ConnectionCheckThread.DoWork

        While StartButton.Checked = False

            CheckConnectionToPLC()
            System.Threading.Thread.Sleep(1000)

        End While
        Return

    End Sub

    Private Sub ControlBlinker_Tick(sender As Object, e As EventArgs) Handles ControlBlinker.Tick

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

    Private blinkCount As Integer = 0

    'Private Sub GraphUpdater_Tick(sender As Object, e As EventArgs) Handles GraphUpdater.Tick

    '    DispGraph.Series.Clear()
    '    DispGraph.Series.Add(DisplacementGraphData.CurrentData(TestDataGen()))

    'End Sub

End Class
