Option Strict On
Imports AdvancedHMIControls
Imports AdvancedHMIDrivers

Module GlobalInstances

    ' This file contains globally declared instances of various classes and data objects
    ' These can be used by all forms in the program.

    Public CurrentVersion As Double = 1.1

    Public WithEvents MotionController As New MotionControlSolution
    Public MovePoints As New List(Of MotionProfile)
    Public MotionProfile1 As New MotionProfile
    Public cycles As Integer = 1

    Public Log As New ExperimentLog
    Public ElapsedTime As String
    Public ExperimentStopwatch As New Stopwatch
    Public loggerInterval As Integer
    Public PLCconnection As String
    Public StartReady As Boolean = False

    Public BackgroundDarkColor As Color = Color.FromArgb(24, 25, 27)

    Public Sub MotionController_OnFinished() Handles MotionController.OnFinished

        MainForm.StartButton.CheckState = CheckState.Unchecked
        Debug.WriteLine("Finished")

    End Sub

End Module
