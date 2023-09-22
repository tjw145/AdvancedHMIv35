﻿Imports System.ComponentModel
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

    Private Sub BasicButton2_Click(sender As Object, e As EventArgs) Handles StartButtonOld.Click

        'If GlobalInstances.MotionProfile1.() Then


        'End If
        'StartButton.BackColor = Color.FromArgb(24, 25, 27)
        'taskbarProgress.ProgressState = taskbarProgress.ProgressState.Normal

    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click

        taskbarProgress.ProgressState = taskbarProgress.ProgressState.None

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub DataSubscriber1_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles DataSubscriber1.DataChanged

        ProgressBar.Value = DataSubscriber1.Value
        taskbarProgress.ProgressValue = DataSubscriber1.Value


    End Sub

    Dim Log As New ExperimentLog


    Public Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles RecordButton.CheckedChanged

        If RecordButton.Checked = True Then

            RecordButton.Text = "❚❚"

            ' Set data logging interval to the user-defined rate, then start the system stopwatch and recording trigger.

            With ExperimentRecording

                '.Interval = loggerInterval
                .Interval = 500  'REMOVE BEFORE FLIGHT******************************************* <----------------
                .Start()

            End With

            ExperimentStopwatch.Start()


        ElseIf RecordButton.Checked = False Then

            ' Stop recording triggers and reset system stopwatch.

            ExperimentRecording.Stop()

            With ExperimentStopwatch

                .Stop()
                .Reset()

            End With

            Log.ExportAsCSV()

            'SaveFileDialog.ShowDialog()

            RecordButton.Text = "●"

            'expLog.filepath = SaveFileDialog.FileName
            'expLog.AddData(1, 2, 3)

            'expLog.ExportAsCSV("")

        End If



    End Sub

    Dim currentTime As String

    Dim test As Integer

    Public Sub ExperimentTimer_Tick(sender As Object, e As EventArgs) Handles ExperimentRecording.Tick

        test += 1
        Debug.WriteLine("Testing: " & test)

        ' Gets current stopwatch time in seconds, and rounds to nearest millisecond
        currentTime = Math.Round(ExperimentStopwatch.Elapsed.TotalSeconds, 3).ToString()

        ' Log all real-time data
        Log.AddData(currentTime, test, test)

    End Sub

    Private Sub SaveFileDialog_FileOk(sender As Object, e As CancelEventArgs) Handles SaveFileDialog.FileOk

        'Log.filename = SaveFileDialog.FileName
        Log.ExportAsCSV()

    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs)

        ' Sets data recording interval to user input, coverted from hertz to milliseconds.
        'loggerInterval = 1000 / (NumericUpDown3.Value)

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles SetupButton.Click

        'ExperimentSetupWindow.ShowDialog()
        Form1.ShowDialog()

    End Sub

    Private Sub CheckIfPLCStarted_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles CheckIfPLCStarted.DataChanged

        If CheckIfPLCStarted.Value = True Then

            StartButtonOld.BackColor = Color.FromArgb(24, 25, 27)
            taskbarProgress.ProgressState = taskbarProgress.ProgressState.Normal

        ElseIf CheckIfPLCStarted.Value = False Then

            StartButtonOld.BackColor = Color.Green
            taskbarProgress.ProgressState = taskbarProgress.ProgressState.None

        End If

    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButtonOld2.Click



        StartButtonOld2.Text = "❚❚"

    End Sub

    Private Sub StartButton_CheckedChanged(sender As Object, e As EventArgs) Handles StartButton.CheckedChanged

        If StartButton.Checked = True Then

            With GlobalInstances.MotionController

                .OutputMotionSolution(ModbusTCPCom1, GlobalInstances.MovePoints, 1)
                .Pause = False

            End With

            StartButton.Text = "❚❚"

        ElseIf StartButton.Checked = False Then

            StartButton.Text = "▶"
            GlobalInstances.MotionController.Pause = True

        End If

    End Sub

    Private Sub CheckConnectionToPLC()

        Dim val As String = ModbusTCPCom1.Read("017183")

        'If PLCConnectionCheck.Value Is "0" Then


        '    Debug.WriteLine("ACK")
        '    ConnectionIndicator.Text = "Connection Status: ACK"

        'Else

        '    Debug.WriteLine("NAK")
        '    ConnectionIndicator.Text = "Connection Status: NAK"

        'End If


        If ModbusTCPCom1.Read("017183", 1)(0) = False Then

            ConnectionIndicator.Text = "Connection Status: ACK"
            Debug.WriteLine("ACK")

        Else

            ConnectionIndicator.Text = "Connection Status: NAK"
            Debug.WriteLine("NAK")

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        CheckConnectionToPLC()

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        ModbusTCPCom1.Subscribe("017183", 1, 1, )

    End Sub
End Class