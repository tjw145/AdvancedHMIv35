
Option Strict On
Public Module HardwareLimits

    'This class contains information on the physical limits of the flex rig.

    'This information is used to limit the commands that users can give to the
    'rig and prevent damage/failed experiments/weird stuff.

    'Thomas Waybright, 10/1/2025

    '============== Maximum Physical Ratings: ===============

    Private maxRPM As Integer = 2400    ' motor sharft revolutions per minute
    Private maxAccel As Integer = 32    ' mm/s^2
    Private maxPPS As Integer = 100000  ' pulses per second

    '========== Physical Hardware Configurations: ===========

    Private stepsPerRev As Integer = 200
    Private uStepFactor As Integer = 8
    Private gearRatio As Integer = 5
    Private screwLead As Decimal = CDec(0.125) ' inches per revolution
    Private mmPerRev As Decimal = CDec(25.4 * (screwLead / gearRatio))
    Private pulsesPerMM As Decimal = (1 * stepsPerRev / mmPerRev) * uStepFactor

    '================== Output Variables: ===================
    ' PLC = Pulses/sec^2
    Public AccelerationMM As Decimal    ' mm = mm/sec^2
    Public PeakVelocityMM As Decimal

    Public Function TestProfile(moveTime As Decimal, distance As Decimal) As Boolean

        ' Tests the input motion parameters against the physical limits of the machine; if 
        ' within limits, returns true. If OOR, returns false.

        Dim accel As Double

        accel = (4.0 * distance) / (moveTime ^ 2)

        If accel <= maxAccel Then
            Return True
        Else Return False
        End If

    End Function

    Public Function AdjustTime(time As Decimal, displacement As Decimal) As Decimal
        'If the user adjusts displacement values out of range, this function will adjust the traverse time input
        'value to keep the motion profile within the limits of the machine.

        Dim newTime As Decimal

        newTime = CDec(Math.Sqrt(displacement * 4 / maxAccel)) * 2
        Return newTime

    End Function

    Public Function AdjustDisplacement(time As Decimal, displacement As Decimal) As Decimal
        'If the user adjusts traverse time values out of range, this function will adjust the displacement input
        'value to keep the motion profile within the limits of the machine.

        Dim newDisplacement As Decimal

        newDisplacement = CDec(maxAccel * (time ^ 2) / 4) / 2
        Return newDisplacement

    End Function

End Module
