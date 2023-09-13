Public Class MotionProfile

    '============== Maximum Physical Ratings: ===============

    Private maxRPM As Integer = 2400 ' motor sharft revolutions per minute
    Private maxAccel As Integer = 32 ' mm/s^2
    Private maxPPS As Integer = 100000 ' pulses per second

    '========== Physical Hardware Configurations: ===========

    Private stepsPerRev As Integer = 200
    Private uStepFactor As Integer = 8
    Private gearRatio As Integer = 5
    Private screwLead As Decimal = 0.125 ' inches per revolution
    Private mmPerRev As Decimal = 25.4 * (screwLead / gearRatio)
    Private pulsesPerMM As Decimal = (1 * stepsPerRev / mmPerRev) * uStepFactor

    '================== Output Variables: ===================

    Public AccelerationPLC As Integer ' PLC = Pulses/sec^2
    Public AccelerationMM             ' mm = mm/sec^2
    Public DecelerationPLC As Integer
    Public DecelerationMM As Integer
    Public TargetPositionPLC As Integer
    Public PeakVelocity As Decimal
    Public PeakPPS As Integer
    Public AccelDecelDistance As Decimal
    Public CoastTime As Decimal
    Public TotalMoveTime As Decimal
    Public TotalExperimentTime As Decimal

    Public Sub GenerateProfile(moveTime, distance)

        ' Generates a complete stepper motor motion profile based on user inputs of: distance to move (in mm), and
        ' time to cover the given distance in (in seconds). Output values are stored as fields, which can then be
        ' passed to the PLC.

        Try

            Dim accel As Decimal
            Dim targetPosition As Integer

            accel = (4 * distance) / (moveTime ^ 2)
            targetPosition = distance * pulsesPerMM

            If accel <= maxAccel Then

                AccelerationMM = accel
                DecelerationMM = accel
                PeakVelocity = (2 * distance) / moveTime

            ElseIf accel > maxAccel Then

                AccelerationMM = maxAccel
                DecelerationMM = maxAccel
                PeakVelocity = maxAccel
                AccelDecelDistance = ((1 / 2) * accel) ^ 2
                CoastTime = ((distance - AccelDecelDistance) / PeakVelocity)
                TotalMoveTime = CoastTime + 2

            End If

            AccelerationPLC = accel * pulsesPerMM
            DecelerationPLC = AccelerationPLC
            TargetPositionPLC = targetPosition
            PeakPPS = PeakVelocity * pulsesPerMM

        Catch ex As Exception

            Debug.WriteLine("Error while attempting to generate motion profile.")

        End Try

    End Sub

    Public Function CalculateSteps(mmPerSec As Decimal)

        Try

            Dim stepsPerSec As Integer = mmPerSec * pulsesPerMM
            Return stepsPerSec

        Catch ex As Exception

            Debug.WriteLine("Error while attempting to generate manual stepper control values.")

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

End Class
