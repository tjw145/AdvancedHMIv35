Option Strict On
Imports AdvancedHMIControls
Imports AdvancedHMIDrivers

Module Globals

    ' This contains globally declared instances to be shared across the program.

    ' ============ CURRENT SOFTWARE VERSION =============
    Public CurrentVersion As String = "2.0 rev A"

    ' In this version: 
    ' Motion control code has been offloaded to the PLC, made possible 
    ' by simplified motion requirements. Flex-to-failure controls
    ' to be added later. No word on load sensor.

    ' ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

    'Experimental Parameters:
    Public numberOfCycles As Integer = 1
    Public traverseTime_s As Integer = 100   'x100
    Public displacement_mm As Integer = 50  'x10
    Public dataLogRate_ms As Integer = 200
    Public estRunTime_s As Decimal = 1

    'Live Experiment Recording:
    Public ExperimentRunning As Boolean = False
    Public Log As New ExperimentLog
    Public ExperimentStopwatch As New Stopwatch

    'Motion Control & Connection:
    Public PLCconnection As String

End Module
