Option Strict On
Imports MfgControl.AdvancedHMI.Controls

Public Class MotionProfile

    'This class is used to generate motion control data for our attached stepper motor driver, in pulses per second.
    '
    'TO ADD:
    'Handling for negative distance values, handling for absolute vs. incremental modes of input.
    '
    'Thomas Waybright, 9/15/2023

    '============== Maximum Physical Ratings: ===============

    Private maxRPM As Integer = 2400 ' motor sharft revolutions per minute
    Private maxAccel As Integer = 32 ' mm/s^2
    Private maxPPS As Integer = 100000 ' pulses per second

    '========== Physical Hardware Configurations: ===========

    Private stepsPerRev As Integer = 200
    Private uStepFactor As Integer = 8
    Private gearRatio As Integer = 5
    Private screwLead As Decimal = CDec(0.125) ' inches per revolution
    Private mmPerRev As Decimal = CDec(25.4 * (screwLead / gearRatio))
    Private pulsesPerMM As Decimal = (1 * stepsPerRev / mmPerRev) * uStepFactor

    '================== Output Variables: ===================

    Public AccelerationPLC() As UInt16 ' PLC = Pulses/sec^2
    Public AccelerationMM As Decimal ' mm = mm/sec^2
    Public DecelerationPLC() As UInt16
    Public DecelerationMM As Decimal
    Public TargetPositionPLC() As UInt16
    Public PeakVelocityMM As Decimal
    Public PeakPPS As Integer
    Public AccelDecelDistanceTime As Decimal
    Public CoastTime As Decimal
    Public TotalMoveTime As Decimal
    Public TotalExperimentTime As Decimal
    Public DwellTime As UInt16

    Public Function GenerateProfile(moveTime As Decimal, distance As Decimal, dwell As Decimal) As Boolean

        ' Generates a complete stepper motor motion profile based on user inputs of: distance to move (in mm), and
        ' time to cover the given distance in (in seconds). Output values are stored as fields, which can then be
        ' passed to the PLC.

        Dim accel As Double
        Dim targetPosition As Integer
        Dim maxAccelExceeded As Boolean

        accel = (4.0 * distance) / (moveTime ^ 2)
        targetPosition = CInt(distance * pulsesPerMM)

        'Checks if the given distance-over-time values are within the physical capabilities of the hardware.
        'If yes, this will generate a "triangular" ramp-up and ramp-down profile.
        'If no, this will generate a "trapezoidal" ramp-up, cruise (at max speed), and ramp-down profile.

        If accel <= maxAccel Then

            maxAccelExceeded = False
            AccelerationMM = CDec(accel)
            DecelerationMM = CDec(accel)
            PeakVelocityMM = CDec((2 * distance) / moveTime)
            TotalMoveTime = moveTime

        ElseIf accel > maxAccel Then

            maxAccelExceeded = True
            AccelerationMM = maxAccel
            DecelerationMM = maxAccel
            PeakVelocityMM = maxAccel
            AccelDecelDistanceTime = CDec((1 / 2) * 1 * (accel) + (1 / 2) * 1 * (accel))
            CoastTime = ((distance - AccelDecelDistanceTime) / PeakVelocityMM)
            TotalMoveTime = CoastTime + 2

        End If

        AccelerationPLC = SplitIntoWords(CInt(accel * pulsesPerMM))
        DecelerationPLC = AccelerationPLC
        TargetPositionPLC = SplitIntoWords(targetPosition)
        PeakPPS = CInt(PeakVelocityMM * pulsesPerMM)
        DwellTime = CUShort(dwell)   '<-------------------- going to have to do some financial decimal point shifting magic here later

        Return maxAccelExceeded


    End Function

    Public Function CalculateSteps(mmPerSec As Decimal) As Integer

        Try

            Dim stepsPerSec As Integer = CInt(mmPerSec * pulsesPerMM)
            Return stepsPerSec

        Catch ex As Exception

            Debug.WriteLine("Error while attempting to generate manual stepper control data.")

            Return 0

        End Try

    End Function

    'Public Function CalculateExperimentTime(cycles)

    '    Try

    '        Dim total As Decimal
    '        total = TotalMoveTime * cycles
    '        total = Math.Round(total, 2)
    '        Return total

    '    Catch ex As Exception

    '        Return "N/A"

    '    End Try

    'End Function

    Function SplitIntoWords(input As Integer) As UInt16()

        Dim output(1) As UInt16

        output(0) = CUShort(input >> 16)
        output(1) = CUShort(input And &HFFFF)

        Dim testRebuild As Integer = (output(0) << 16) Or (output(1) And &HFFFF)

        Debug.WriteLine(testRebuild)

        Return output

    End Function

End Class
