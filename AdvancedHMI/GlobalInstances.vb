Imports AdvancedHMIControls

Module GlobalInstances

    ' This file contains globally declared instances of various classes and data objects
    ' These can be used by all forms in the program.

    Public MotionController As New MotionControlSolution
    Public MovePoints As New List(Of MotionProfile)
    Public MotionProfile1 As New MotionProfile
    Public Log As New ExperimentLog
    Public RecordingInterval As Integer

    Public ElapsedTime As String
    Public ExperimentStopwatch As New Stopwatch

    Public loggerInterval As Integer


End Module
