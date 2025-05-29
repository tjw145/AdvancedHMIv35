Option Strict On
Imports AdvancedHMIControls
Imports AdvancedHMIDrivers

Module GlobalInstances

    ' This file contains globally declared instances of various classes and data objects
    ' These can be used by all forms in the program.

    '============ CURRENT VERSION NUMBER =============
    Public CurrentVersion As Double = 1.5
    '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

    Public WithEvents MotionController As New MotionControlSolution
    Public MovePoints As New List(Of MotionProfile)
    Public cycles As Integer
    Public Log As New ExperimentLog
    Public ElapsedTime As String
    Public ExperimentStopwatch As New Stopwatch
    Public loggerInterval As Integer
    Public PLCconnection As String
    Public StartReady As Boolean = False

    'Public DisplacementGraphData As Graph

    Public BackgroundDarkColor As Color = Color.FromArgb(24, 25, 27)

    Public Sub MotionController_OnFinished() Handles MotionController.OnFinished

        MainForm.StartButton.CheckState = CheckState.Unchecked
        Debug.WriteLine("Finished")

    End Sub

    Public testTimer As Stopwatch

    'Public Function TestDataGen() As Double

    '    If testTimer.IsRunning = False Then

    '        testTimer.Start()

    '    End If

    '    Dim out As Double
    '    out = Math.Sin(CDbl(testTimer.ElapsedMilliseconds / 100))
    '    Return out

    'End Function

End Module
